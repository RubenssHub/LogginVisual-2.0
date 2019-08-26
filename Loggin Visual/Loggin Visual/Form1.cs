using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loggin_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(TextBoxUsuario.Text=="Juancho"&& textBoxContra.Text=="123tamarindo")
            {
                MessageBox.Show("Sesión iniciada");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no válido");
                TextBoxUsuario.Text = "";
                textBoxContra.Text = "";
                TextBoxUsuario.Focus(); //Envia al cursos al espacio de usuario
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario
        }
    }
}
