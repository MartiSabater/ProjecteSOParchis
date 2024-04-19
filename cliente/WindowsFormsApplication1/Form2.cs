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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void signupRegistrarButton_Click(object sender, EventArgs e)
        {
            if (signupCorreotextBox.Text != "" && signupUsuariotextBox.Text != "" && signupContraseñatextBox.Text != "")
            {
                MessageBox.Show("Usuario registrado con éxito.");
                
                this.Close();

            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos.");
            }
        }
    }
}
