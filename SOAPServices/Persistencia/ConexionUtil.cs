using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            
            // return "Data Source=(local);Initial Catalog=DB_Usuarios;Integrated Security=SSPI;";
            return "Data Source=5d4d5fd8-c1fc-4551-a083-a5a600143ec9.sqlserver.sequelizer.com;Initial Catalog=db5d4d5fd8c1fc4551a083a5a600143ec9;User Id=gioidjclvbhzbbmm;Password=X8KpPqhDKeuEuETy2m3QWaxfKhyNPMVrkriP6BG8ndScdJfur2cYkVPXHDLGYAW7";
        }
    }
}