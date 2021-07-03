using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CitasMedicas
{
   public class DoctoresBL
    {
        public BindingList<Doctor> ListaDoctores { get; set; }

        public DoctoresBL()
        {
            ListaDoctores = new BindingList<Doctor>();

            var doctor1 = new Doctor();
            doctor1.Id = 001;
            doctor1.Nombre = "Mauricio Calderon";
            doctor1.Especialidad = "Cardiologo";
            doctor1.Precio = 450;
            doctor1.Disponibilidad = 5;
            doctor1.Activo = true;

            ListaDoctores.Add(doctor1);

            var doctor2 = new Doctor();
            doctor2.Id = 002;
            doctor2.Nombre = "Paola Valencia";
            doctor2.Especialidad = "Pediatra";
            doctor2.Precio = 550;
            doctor2.Disponibilidad = 8;
            doctor2.Activo = true;

            ListaDoctores.Add(doctor2);

            var doctor3 = new Doctor();
            doctor3.Id = 003;
            doctor3.Nombre = " Megan Mendoza";
            doctor3.Especialidad = "Ginecologo";
            doctor3.Precio = 400;
            doctor3.Disponibilidad = 7;
            doctor3.Activo = true;

            ListaDoctores.Add(doctor3);
        }

        public BindingList<Doctor> ObtenerDoctores()
        {
            return ListaDoctores;
        }
    }
    public class Doctor
        {
        public int Id { get; set; }
        public  string Nombre { get; set; }
        public string Especialidad { get; set; }
        public double Precio { get; set; }
        public int Disponibilidad{ get; set; }
        public bool Activo { get; set; }
    }
}
