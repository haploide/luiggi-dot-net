using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class Acceso
           
    {
        private String cadena_de_conexion = "Data Source=PABLO-PC;Initial Catalog=Luiggi;Integrated Security=True";

        public string getCadenaConexion() {
            return cadena_de_conexion;
        }

        public void setCadenaConexion(string cadena)
        {
            cadena_de_conexion = cadena;
        }
    }
}
