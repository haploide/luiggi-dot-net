using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAO;
namespace Vista
{
   public static  class Seguridad
    {
        public static  Usuario  usuario { get; set; }

        public static bool GetAutorizacion(string permiso)
        {
         
            if (AutorizacionDAO.GetAutorizacionPorUsuario(usuario.idUsuario, permiso))
            {
                return true;
 
            }
            return false;
        }
    }
}
