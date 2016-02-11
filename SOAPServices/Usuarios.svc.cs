using SOAPServices.Dominio;
using SOAPServices.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices

    //demo
{
    public class Usuarios : IUsuarios
    {
        private UsuarioDAO usuarioDAO = null;
        private UsuarioDAO UsuarioDAO
        {
            get
            {
                if (usuarioDAO == null)
                    usuarioDAO = new UsuarioDAO();
                return usuarioDAO;

            }
        }

        private RolDAO rolDAO = null;
        private RolDAO RolDAO
        {
            get 
            {
                if (rolDAO == null)
                    rolDAO = new RolDAO();
                return rolDAO;
            }
        }

        
        public Usuario CrearUsuario(string nombre, string correo, int rol, string password)
        {
            Rol rolExistente = RolDAO.Obtener(rol);
            Usuario usuarioACrear = new Usuario()
            {
                Nombre = nombre,
                Correo = correo,
                Rol = rolExistente,
                Password = password

                //demo
            };
            return UsuarioDAO.Crear(usuarioACrear);
        }

        public Usuario ObtenerUsuario(int codigo)
        {
            return UsuarioDAO.Obtener(codigo);
        }

        public Usuario ModificarUsuario(int codigo, string nombre, string correo, int rol, string password)
        {
            Rol rolExistente = RolDAO.Obtener(rol);
            Usuario usuarioAModificar = new Usuario()
            {
                Codigo = codigo,
                Nombre = nombre,
                Correo = correo,
                Rol = rolExistente,
                Password = password
            };
            return UsuarioDAO.Modificar(usuarioAModificar);
        }

        public void EliminarUsuario(int codigo)
        {
            Usuario usuarioExiste = UsuarioDAO.Obtener(codigo);
            UsuarioDAO.Eliminar(usuarioExiste);
        }

        public List<Usuario> ListarUsuarios()
        {
            return UsuarioDAO.ListarTodos().ToList();
        }
    }
}
