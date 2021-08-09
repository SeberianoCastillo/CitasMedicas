using BL.CitasMedicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citas_Medicas
{
    public partial class FormDoctores : Form
    {
        DoctoresBl _doctores;
        private EspecialidadesBL _especialidades;

        public FormDoctores()
        {
            InitializeComponent();

            _doctores = new DoctoresBl();
            listaDoctoresBindingSource.DataSource = _doctores.ObtenerDoctores();

            _especialidades = new EspecialidadesBL();
            listaEspecialidadesBindingSource.DataSource = _especialidades.ObtenerEspecialidades();
        }
        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            var doctor = (Doctor)listaDoctoresBindingSource.Current;
            if (doctor != null)
            {
                openFileDialogImage.ShowDialog();
                var archivo = openFileDialogImage.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un doctor antes de asignar la imagen");
            }

        }

        private void btnDeleteFoto_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }
        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _doctores.AgregarDoctor();
            listaDoctoresBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void listaPacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaDoctoresBindingSource.EndEdit();
            var doctor = (Doctor)listaDoctoresBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                doctor.Foto = Program.imagenToByteArray(fotoPictureBox.Image);
            }
            else
            {
                doctor.Foto = null;
            }



            var resultado = _doctores.GuardarDoctor(doctor);

            if (resultado.Exitoso == true)
            {
                listaDoctoresBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Doctor Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea Eliminar esta Doctor?", "Eliminar Doctor", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _doctores.Eliminardoctor(id);

            if (resultado == true)
            {
                listaDoctoresBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error al eliminar Doctor");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _doctores.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void FormDoctores_Load(object sender, EventArgs e)
        {

        }

        private void especialidadIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void fotoLabel_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void activoLabel_Click (object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void disponibilidadLabel_Click(object sender, EventArgs e)
        {

        }

        private void disponibilidadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void especialidadLabel_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }
            private void Buscar()
        {
            var busqueda = textBox1.Text;

            if (busqueda != "")
            {
                listaDoctoresBindingSource.DataSource = _doctores.ObtenerDoctores(busqueda);
            }
            else
            {
                listaDoctoresBindingSource.DataSource = _doctores.ObtenerDoctores();
            }

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Buscar();
                
            }
        }
    }
}
