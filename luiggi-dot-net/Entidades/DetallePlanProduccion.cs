using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetallePlanProduccion
    {
        public int idPlan { get; set; }
        public Producto producto { get; set; }
        public double cantidadPLan { get; set; }
        public double cantidadPedido { get; set; }
        public DateTime fechaProduccion { get; set; }
    }
}
 