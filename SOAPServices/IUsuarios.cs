using SOAPServices.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices
{
    
    [ServiceContract]
    public interface IUsuarios
    {
        [OperationContract]
        Usuario CrearUsuario(string nombre, string correo, int rol, string password ) ;
        [OperationContract]
        Usuario ObtenerUsuario(int codigo);
        [OperationContract]
        Usuario ModificarUsuario(int codigo, string nombre, string correo, int rol, string password );
        [OperationContract]
        void EliminarUsuario(int codigo);
        [OperationContract]
        List<Usuario> ListarUsuarios();
    }
}


