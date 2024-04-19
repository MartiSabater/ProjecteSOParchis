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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        public string correo, nombreUsuario, contrasena;
        string ip = "10.4.119.5";
        int puerto = 50015;

        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Conectado");

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

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                int nBytes = server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2, 0, nBytes);
                MessageBox.Show("El número de partida és: " + mensaje);
            }
            else if (consulta2.Checked)
            {
                string mensaje = "4/" + correo + "/" + nombreUsuario + "/" + contrasena;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split (',')[0];
                MessageBox.Show("La respuesta a la consulta 2 és: " + mensaje);
            }
            else if (consulta3.Checked)
            {
                string mensaje = "5/" + correo + "/" + nombreUsuario + "/" + contrasena;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                MessageBox.Show("La respuesta a la consulta 3 és: " + mensaje);
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
        }

        private void listaConectadosButton_Click(object sender, EventArgs e)
        {
            // Enviamos al servidor la solicitud de lista de usuarios conectados
            string mensaje = "6";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Recibimos la respuesta del servidor
            byte[] msgBuffer = new byte[1024]; // Asegurémonos de tener suficiente espacio para recibir los datos
            int bytesRecibidos = server.Receive(msgBuffer);
            mensaje = Encoding.ASCII.GetString(msgBuffer, 0, bytesRecibidos);

            if (mensaje == "0")
            {
                MessageBox.Show("No hay usuarios conectados en este momento.");
            }
            else
            {
                dataGridView1.Visible = true;
                string[] usuariosConectados = mensaje.Split('/');
                Console.WriteLine(usuariosConectados.Length);
                dataGridView1.RowCount = usuariosConectados.Length;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.ColumnCount = 1;
                for (int i = 0; i < usuariosConectados.Length; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = usuariosConectados[i];
                }                
            }
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

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                int nBytes = server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2, 0, nBytes);

                if (mensaje == "0")
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
                else if (mensaje == "-1")
                {
                    MessageBox.Show("Este usuario ya existe.");
                }
                else MessageBox.Show("Otro error.");
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

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                int nBytes = server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2, 0, nBytes);

                if(mensaje == "0")
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
                else if (mensaje == "-1")
                {
                    MessageBox.Show("Te has equivocado de contraseña o usuario.");
                }
                else 
                {
                    MessageBox.Show("Este usuario ya está conectado.");
                }
            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos.");
            }
        }        
    }
}
