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
            
             //return "Data Source=(local);Initial Catalog=DB_Usuarios;Integrated Security=SSPI;";
            // 1er db online return "Data Source=5d4d5fd8-c1fc-4551-a083-a5a600143ec9.sqlserver.sequelizer.com;Initial Catalog=db5d4d5fd8c1fc4551a083a5a600143ec9;User Id=gioidjclvbhzbbmm;Password=X8KpPqhDKeuEuETy2m3QWaxfKhyNPMVrkriP6BG8ndScdJfur2cYkVPXHDLGYAW7";
            return "Data Source=77b6ca3e-6edc-48f0-8239-a5a90043d1b0.sqlserver.sequelizer.com;Initial Catalog=db77b6ca3e6edc48f08239a5a90043d1b0;User Id=hlvhrmqdqdkbaebi;Password=NKnhqBVreEiwXdQMmT4V8ARghuGA7q6GCkdcs7LWNHmitqrHAUZpqqtn3ga53utW";
        }
    }
}