using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void loginEntrarButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            if (loginUsuariotextBox.Text != "" && loginContraseñatextBox.Text != "")
            {
                MessageBox.Show("Bienvenido de nuevo, " +  loginUsuariotextBox.Text + "!");                
                this.Close();

            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos.");
            }
        }
    }
}
