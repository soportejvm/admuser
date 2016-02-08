using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOAPServicesTest.UsuariosWS;

namespace SOAPServicesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1Crear()
        {
            // 1. Instanciar el objeto a probar
            UsuariosWS.UsuariosClient proxy = new UsuariosWS.UsuariosClient();
            // 2. Invoca el método a probar
            Usuario resultado = proxy.CrearUsuario("Alejandro","alejandro@dms.com.pe",1);
            // 3. Verificar/validar el resultado esperado
            Assert.IsNotNull(resultado);


        }
        [TestMethod]
        public void TestMethod1Eliminar()
        {
            UsuariosWS.UsuariosClient proxy = new UsuariosWS.UsuariosClient();
            proxy.EliminarUsuario(7);
            Usuario resultado2 = proxy.ObtenerUsuario(7);
            Assert.IsNull(resultado2);
        }

        [TestMethod]
        public void TestMethod1Listar()
        {
            UsuariosWS.UsuariosClient proxy = new UsuariosWS.UsuariosClient();
            Usuario[] Lista = proxy.ListarUsuarios();
            Assert.AreEqual(6, Lista.Length);
        }
    }
}
