using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleOrdenTrabajo
    {
        public Maquinaria maquinaria { get; set; }
        public Empleado empleado { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
    }
}
