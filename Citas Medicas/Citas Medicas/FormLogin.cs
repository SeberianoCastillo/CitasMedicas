using BL.CitasMedicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citas_Medicas
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = textBox1.Text;
            var contrasena = textBox2.Text;

            button1.Enabled = false;
            button1.Text = @"Verificando...";
            Application.DoEvents();

           var usuariosDB = _seguridad.Autorizar(usuario, contrasena);

            if (usuariosDB != null)
            {
                Utilidades.NombreUsuario = usuariosDB.NombreUsuario;
                Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                button1.Enabled = true;
                button1.Text = "Aceptar";
                textBox1.Clear();  
                textBox2.Clear();
                textBox1.Focus();

                Application.DoEvents();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
                && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
                 && !string.IsNullOrEmpty(textBox2.Text))
            {
                button1.PerformClick();
            }
        }
    }
}
