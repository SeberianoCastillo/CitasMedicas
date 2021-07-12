using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace BL.CitasMedicas
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string MotivoCita { get; set; }
        public string Medico { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public double Precio { get; set; }
    }
    public class CitasBL
    {
        contexto _contexto;
        public BindingList<Paciente> ListaPacientes { get; set; }

        public CitasBL()
        {
            _contexto = new contexto();
            ListaPacientes = new BindingList<Paciente>();

           
        }

        public BindingList<Paciente> ObtenerCitas()
        {

            _contexto.Paciente.Load();
            ListaPacientes = _contexto.Paciente.Local.ToBindingList();
            return ListaPacientes;
        }

        public Resultado GuardarPaciente(Paciente paciente)
        {
            var resultado = Validar(paciente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarPaciente()
        {
            var nuevoPaciente = new Paciente();
            ListaPacientes.Add(nuevoPaciente);
        }

        public bool EliminarPaciente(int id)
        {
            foreach (var paciente in ListaPacientes)
            {
                if (paciente.Id == id)
                {
                    ListaPacientes.Remove(paciente);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Paciente paciente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (paciente.Precio <= 0)
            {
                resultado.Mensaje = "Ingrese un pecio de la cita";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(paciente.Hora) == true)
            {
                resultado.Mensaje = "Ingrese una hora de cita";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(paciente.Fecha) == true)
            {
                resultado.Mensaje = "Ingrese una fecha para la cita";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(paciente.Medico) == true)
            {
                resultado.Mensaje = "Ingrese un Medico al paciente";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(paciente.MotivoCita) == true)
            {
                resultado.Mensaje = "Ingrese un nombre Motivo de Cita";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(paciente.Nombre) ==  true)
            {
                resultado.Mensaje = "Ingrese un nombre de paciente";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
