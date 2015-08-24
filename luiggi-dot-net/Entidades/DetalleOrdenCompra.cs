using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleOrdenCompra
    {
        public OrdenDeCompra  ordenCompra { get; set; }
        public Double precio { get; set; }
        public Double cantidad { get; set; }
        public Producto producto { get; set; }
        public Double subTotal { get; set; }
        public Double cantidadRealIngresada { get; set; }
      
    }
}
