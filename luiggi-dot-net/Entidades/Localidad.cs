using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Localidad
    {
        public int codPostal { get; set; }
        public string Nombre { get; set; }
        public Provincia Provincia { get; set; }
       
    }
}
