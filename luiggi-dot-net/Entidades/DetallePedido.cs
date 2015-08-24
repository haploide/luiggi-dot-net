using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetallePedido
    {
        public Pedido  pedido { get; set; }
        public double precio { get; set; }
        public Double  cantidad { get; set; }
        public Producto   producto { get; set; }
        public double subTotal { get; set; }
        public Double cantidadReservada { get; set; }
        public bool reservado { get; set; }
        public Estado  Estado { get; set; }

    }
}
