using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class Acceso
           
    {
        private String cadena_de_conexion = "Data Source=(local);Initial Catalog=Luiggi;Integrated Security=True";

        public string getCadenaConexion()
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration("Vista.exe");
            string connString = config.ConnectionStrings.ConnectionStrings["luiggi_db"].ConnectionString;

            return connString;
        }
    }
}
