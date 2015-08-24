using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public  class Empleado
    {
        public int idEmpleado { get; set; }
        public int edad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime fechaAlta { get; set; }
        public Estado estado { get; set; }
        public DateTime fechaNac { get; set; }
        public string telefono { get; set; }
    }
}
