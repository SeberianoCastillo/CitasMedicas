using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CitasMedicas
{
	public class Usuario
	{
        Contexto _contexto;

        public BindingList<Usuario> ListaUsuarios { get; set; }

        public int Id { get; set; }
		public string NombreUsuario { get; set; }
		public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }


        public Usuario()
        {
            _contexto = new Contexto();
            ListaUsuarios = new BindingList<Usuario>();
        }

        public BindingList<Usuario> ObtenerUsuarios()
        {
            _contexto.Usuarios.Load();
            ListaUsuarios = _contexto.Usuarios.Local.ToBindingList();

            return ListaUsuarios;
        }

        
        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();
            _contexto.Usuarios.Add(nuevoUsuario);
        }

        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListaUsuarios.ToList())
            {
                if (usuario.Id == id)
                {
                    ListaUsuarios.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Usuario usuario)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (usuario == null)
            {
                resultado.Mensaje = "Agregue un usuario valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(usuario.NombreUsuario) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del usuario";
                resultado.Exitoso = false;
            }

            return resultado;
        }
 

    }
	public class UsuariosBL
	{
		private Contexto _contexto;

		 public BindingList<Usuario> ListaUsuarios { get; set; }

			public UsuariosBL()
			{
				_contexto = new Contexto();
				ListaUsuarios = new BindingList<Usuario>();
			}

			public BindingList<Usuario> ObtenerUsuarios()
			{
				_contexto.Usuarios.Load();
				ListaUsuarios = _contexto.Usuarios.Local.ToBindingList();

				return ListaUsuarios;
			}
		}

}

