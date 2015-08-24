using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public  class OrdenDeCompra
    {
        public int idOrdenCompra { set; get; }
        public DateTime  fechaOrden { set; get; }
        public DateTime fechaRemito { set; get; }
        public DateTime fechaPago { set; get; }
        public Double  monto { set; get; }
        public Double montoReal { set; get; }
        public Persona proveedor { set; get; }
        public List<DetalleOrdenCompra > detalleOrdenCompra { get; set; }
        public Estado estado { set; get; }
    }
}
