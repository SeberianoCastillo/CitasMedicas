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
    public partial class FormDoctores : Form
    {
        DoctoresBL _doctores;

        public FormDoctores()
        {
            InitializeComponent();

            _doctores = new DoctoresBL();
            listaDoctoresBindingSource.DataSource = _doctores.ObtenerDoctores();
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void precioLabel_Click(object sender, EventArgs e)
        {

        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void disponibilidadLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormDoctores_Load(object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void activoLabel_Click(object sender, EventArgs e)
        {

        }

        private void disponibilidadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void especialidadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void especialidadLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
