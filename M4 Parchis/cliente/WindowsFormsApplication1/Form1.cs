using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;
        public string correo, nombreUsuario, contrasena;
        string ip = "10.4.119.5";
        int puerto = 50015;
        Form2 form2 = new Form2 ();
        bool conectado;


        //Recibimos del servidor
        public void AtenderServidor()
        {
            while (conectado)
            {
                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                string [] recibido;
                server.Receive(msg2);
                recibido = Encoding.ASCII.GetString(msg2).Split('/');

                if (recibido[0] == "1")
                {

                    if (recibido[1] == "0")
                    {
                        MessageBox.Show("Registrado con éxito.\nBienvenido , " + signupUsuariotextBox.Text + "!");
                        consultasBox.Visible = true;
                        consultasNombretextBox.Text = signupUsuariotextBox.Text;
                        nombreUsuario = consultasNombretextBox.Text;

                        signupButton.Visible = false;
                        loginButton.Visible = false;
                        signupLabel.Visible = false;
                        signupCorreoLabel.Visible = false;
                        signupUsuarioLabel.Visible = false;
                        signupContraseñaLabel.Visible = false;
                        signupCorreotextBox.Visible = false;
                        signupUsuariotextBox.Visible = false;
                        signupContraseñatextBox.Visible = false;
                        signupRegistrarButton.Visible = false;
                       
                    }
                    else if (recibido[1] == "-1")
                    {
                        MessageBox.Show("Este usuario ya existe.");
                    }
                    else MessageBox.Show("Otro error.");
                }
                if (recibido[0] == "2")
                {
                    if (recibido[1] == "0")
                    {
                        MessageBox.Show("Bienvenido de nuevo, " + loginUsuariotextBox.Text + "!");
                        consultasBox.Visible = true;
                        consultasNombretextBox.Text = loginUsuariotextBox.Text;
                        nombreUsuario = consultasNombretextBox.Text;

                        signupButton.Visible = false;
                        loginButton.Visible = false;
                        loginLabel.Visible = false;
                        loginUsuarioLabel.Visible = false;
                        loginContraseñaLabel.Visible = false;
                        loginUsuariotextBox.Visible = false;
                        loginContraseñatextBox.Visible = false;
                        loginEntrarButton.Visible = false;
                        
                    }
                    else if (recibido[1] == "-1")
                    {
                        MessageBox.Show("Te has equivocado de contraseña o usuario.");
                    }
                    else
                    {
                        MessageBox.Show("Este usuario ya está conectado.");
                    }
                }
                if (recibido[0] == "3")
                {
                    MessageBox.Show("El número de partida és: " + recibido[1]);
                }
                if (recibido[0] == "4")
                {
                    MessageBox.Show("La respuesta a la consulta 2 és: " + recibido[1]);
                }
                if (recibido[0] == "5")
                {
                    MessageBox.Show("La respuesta a la consulta 3 és: " + recibido[1]);
                }
                if (recibido[0] == "6")
                {
                    
                    if (recibido[1] == null)
                    {
                        dataGridView1.RowCount = 1;
                        dataGridView1.Rows[0].Cells[0].Value = "No hay usuarios conectados";
                    }
                    else
                    {
                        
                        string[] usuariosConectados = recibido[1].Split(',');
                        dataGridView1.RowCount += usuariosConectados.Length;
                        Console.WriteLine(usuariosConectados.Length);
                        
                        for (int i = 0; i < usuariosConectados.Length; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = usuariosConectados[i];
                        }
                    }
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IP.Text = ip;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos

            IPAddress direc = IPAddress.Parse(IP.Text);
            IPEndPoint ipep = new IPEndPoint(direc, puerto);
            

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                conectado = true;
                MessageBox.Show("Conectado");
                dataGridView1.Visible = true;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.ColumnCount = 1;
                //Pongo en Marcha el therd que atendera los mensajes del servidor
                ThreadStart ts = delegate { AtenderServidor(); };
                atender = new Thread(ts);
                atender.Start();
            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nombreUsuario = consultasNombretextBox.Text;
            if (consulta1.Checked)
            {
                string mensaje = "3/" + nombreUsuario;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
                
            }
            else if (consulta2.Checked)
            {
                string mensaje = "4/" + correo + "/" + nombreUsuario + "/" + contrasena;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                
                
            }
            else if (consulta3.Checked)
            {
                string mensaje = "5/" + correo + "/" + nombreUsuario + "/" + contrasena;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

            }
            else
            {
                MessageBox.Show("Seleccione una consulta.");
            }

            // Se terminó el servicio. 
            // Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            consultasBox.Visible = false;
            signupLabel.Visible = true;
            signupCorreoLabel.Visible = true;
            signupUsuarioLabel.Visible = true;
            signupContraseñaLabel.Visible = true;
            signupCorreotextBox.Visible = true;
            signupUsuariotextBox.Visible = true;
            signupContraseñatextBox.Visible = true;
            signupRegistrarButton.Visible = true;

            loginLabel.Visible = false;
            loginUsuarioLabel.Visible = false;
            loginContraseñaLabel.Visible = false;
            loginUsuariotextBox.Visible = false;
            loginContraseñatextBox.Visible = false;
            loginEntrarButton.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            consultasBox.Visible = false;
            loginLabel.Visible = true;
            loginUsuarioLabel.Visible = true;
            loginContraseñaLabel.Visible = true;
            loginUsuariotextBox.Visible = true;
            loginContraseñatextBox.Visible = true;
            loginEntrarButton.Visible = true;

            signupLabel.Visible = false;
            signupCorreoLabel.Visible = false;
            signupUsuarioLabel.Visible = false;
            signupContraseñaLabel.Visible = false;
            signupCorreotextBox.Visible = false;
            signupUsuariotextBox.Visible = false;
            signupContraseñatextBox.Visible = false;
            signupRegistrarButton.Visible = false;
        }
        private void desconectarButton_Click(object sender, EventArgs e)
        {
            // Envío a la base de datos los datos introducidos
            nombreUsuario = consultasNombretextBox.Text;
            string mensaje = $"0/{nombreUsuario}";
            // Enviamos al servidor los datos tecleados
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            MessageBox.Show("Hasta pronto.");
            this.Close();
            conectado = false;
            atender.Abort();
        }

        private void listaConectadosButton_Click(object sender, EventArgs e)
        {
            
        }

        private void signupRegistrarButton_Click(object sender, EventArgs e)
        {
            if (signupCorreotextBox.Text != "" && signupUsuariotextBox.Text != "" && signupContraseñatextBox.Text != "")
            {
                //Envío a la base de datos los datos introducidos
                string mensaje = $"1/{signupCorreotextBox.Text}/{signupUsuariotextBox.Text}/{signupContraseñatextBox.Text}";
                // Enviamos al servidor los datos tecleados
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos.");
            }
        }

        private void loginEntrarButton_Click(object sender, EventArgs e)
        {
            if (loginUsuariotextBox.Text != "" && loginContraseñatextBox.Text != "")
            {
                //Envío a la base de datos los datos introducidos
                string mensaje = $"2/{loginUsuariotextBox.Text}/{loginContraseñatextBox.Text}";
                // Enviamos al servidor los datos tecleados
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                
            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos.");
            }
        }        
    }
}
