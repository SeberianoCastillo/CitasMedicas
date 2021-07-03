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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void crearCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservacionDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void citaMedicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void citaMedicasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var formlogin = new FormLogin();
            formlogin.ShowDialog();
        }

        private void crearCitaMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCrearCitaMedica = new FormCrearCitaMedica();
            formCrearCitaMedica.MdiParent = this;
            formCrearCitaMedica.Show();

        }

        private void buscarCitasProgramadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formBuscarCitasProgramadas = new FormBuscarCitaProgramada();
            formBuscarCitasProgramadas.MdiParent = this;
            formBuscarCitasProgramadas.Show();
        }

        private void listaDeDoctoresYEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formListaDoctoresYEspecialidades = new FormDoctores();
            formListaDoctoresYEspecialidades.MdiParent = this;
            formListaDoctoresYEspecialidades.Show();
        }
    }
}
