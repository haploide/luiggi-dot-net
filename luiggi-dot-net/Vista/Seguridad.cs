using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Vista
{
   public static  class Seguridad
    {
        public static  Usuario  usuario { get; set; }

        public static bool GetAutorizacion(string permiso)
        {
            // buscar si el usuario esta autorizado

            return false;
        }
    }
}
