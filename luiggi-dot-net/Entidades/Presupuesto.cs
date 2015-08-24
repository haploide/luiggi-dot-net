using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Presupuesto
    {
        public string raSocial { get; set; }
        public int idFactura { get; set; }
        public DateTime fechaCreacion { get; set; }
        public Persona cliente { get; set; }
        public Pedido pedido { get; set; }
        public Double importeTotal { get; set; }
        public Estado estado { get; set; }
        public DateTime fechaPago { get; set; }
        public Char tipoFactura { get; set; }
        public List<DetalleFactura> detalleFactura { get; set; }
        public int numeroFactura { get; set; }
        public Double totalIVA { get; set; }
        public Double montoSinImpuesto { get; set; }
    }
}
