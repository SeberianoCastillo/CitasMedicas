using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BL.CitasMedicas
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            //Especialidades Médicas
            var especialidad1 = new Especialidades();
            especialidad1.Id = 1;
            especialidad1.Especialidad = "Neurología";
            contexto.Especialidades.Add(especialidad1);

            var especialidad2 = new Especialidades();
            especialidad2.Id = 2;
            especialidad2.Especialidad = "Cardiología";
            contexto.Especialidades.Add(especialidad2);

            var especialidad3 = new Especialidades();
            especialidad3.Id = 3;
            especialidad3.Especialidad = "Prediatría";
            contexto.Especialidades.Add(especialidad3);

            //Medicos
            var doctor1 = new Doctor();
            doctor1.Id = 3;
            doctor1.Nombre = "Chapatín";
            doctor1.EspecialidadId = 1;
            doctor1.Precio = 700;
            doctor1.Disponibilidad = 10;
            doctor1.Activo = true;
            contexto.Doctor.Add(doctor1);

            var doctor2 = new Doctor();
            doctor2.Id = 4;
            doctor2.Nombre = "Jorge Ortíz";
            doctor2.EspecialidadId = 3;
            doctor2.Precio = 700;
            doctor2.Disponibilidad = 10;
            doctor2.Activo = true;
            contexto.Doctor.Add(doctor2);

            //Tipos de Consulta
            var tipo1 = new Tipo();
            tipo1.Descripcion = "General";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Emergencia";
            contexto.Tipos.Add(tipo2);

            var tipo3 = new Tipo();
            tipo3.Descripcion = "Retiro/Lectura Exámenes";
            contexto.Tipos.Add(tipo3);

            //Tipos de Consulta
            var usuario1 = new Usuario();
            usuario1.Id = 1;
            usuario1.NombreUsuario = "admin";
            usuario1.Contrasena = "123";
            contexto.Usuarios.Add(usuario1);

            var usuario2 = new Usuario();
            usuario2.Id = 2;
            usuario2.NombreUsuario = "invitado";
            usuario2.Contrasena = "123";
            contexto.Usuarios.Add(usuario2);

            base.Seed(contexto);
        }
    }
}
