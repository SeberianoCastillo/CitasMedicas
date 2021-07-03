using System.ComponentModel;
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

        public BindingList<Paciente> ListaPacientes { get; set; }

        public CitasBL()
        {
            ListaPacientes = new BindingList<Paciente>();

            var paciente1 = new Paciente();
            paciente1.Id = 501;
            paciente1.Nombre = "Carlos Carlos";
            paciente1.MotivoCita = "Revisión de Rutina";
            paciente1.Medico = "Cardiologo";
            paciente1.Fecha = "01/08/2021";
            paciente1.Hora = "08:00";
            paciente1.Precio = 500.00;

            ListaPacientes.Add(paciente1);

            var paciente2 = new Paciente();
            paciente2.Id = 502;
            paciente2.Nombre = "Juan Juan";
            paciente2.MotivoCita = "Revisión de Rutina";
            paciente2.Medico = "Pediatra";
            paciente2.Fecha = "01/08/2021";
            paciente2.Hora = "09:00";
            paciente2.Precio = 600.00;

            ListaPacientes.Add(paciente2);

            var paciente3 = new Paciente();
            paciente3.Id = 503;
            paciente3.Nombre = "Pedro Pedro";
            paciente3.MotivoCita = "Revisión de Rutina";
            paciente3.Medico = "Internista";
            paciente3.Fecha = "01/08/2021";
            paciente3.Hora = "10:00";
            paciente3.Precio = 700.00;

            ListaPacientes.Add(paciente3);
        }

        public BindingList<Paciente> ObtenerCitas()
        {
            return ListaPacientes;
        }

        public Resultado GuardarPaciente(Paciente paciente)
        {
            var resultado = Validar(paciente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if (paciente.Id == 0)
            {
                paciente.Id = ListaPacientes.Max(item => item.Id) + 1;
            }
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
