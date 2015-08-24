using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleFactura
    {
        public int idDetalle { get; set; }
        public Producto producto { get; set; }
        public DetallePedido detPedido { get; set; }
        public Double subTotal { get; set; }
        public Double cantidad { get; set; }
        public Double iva { get; set; }
        public int esSinPedido { get; set; }
    }
}
