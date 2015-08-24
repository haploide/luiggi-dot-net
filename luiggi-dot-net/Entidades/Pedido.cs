using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Pedido
    {
        public int nroPedido { get; set; }
        public int idPedido { get; set; }
        public Persona  cliente { get; set; }
        public Estado  estado { get; set; }
        public DateTime fechaNecesidad { get; set; }
        public DateTime fechaPedido { get; set; }
        public List<DetallePedido>  detallePedido { get; set; }
        public double montoTotal { get; set; }
        public string dirEntraga { get; set; }
       
    }
}
