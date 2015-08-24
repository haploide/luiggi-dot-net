using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Entidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public int CODProducto { get; set; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public string Descripcion { get; set; }
        public UnidadMedida Unidad { get; set; }
        public UnidadMedida UnidadTiempo { get; set; }
        public double StockActual { get; set; }
        public double StockRiesgo { get; set; }
        public double StockDisponible { get; set; }
        public double StockReservado { get; set; }
        public double precio { get; set; }
        public Byte[]  foto { get; set; }
        public TipoMaquinaria tipoMaquina { get; set; }
        public double precioMayorista { get; set; }
        public double tiempoProduccion { get; set; }
        public double cantidadProductos { get; set; }
        public double cantidadAProd { get; set; }
       
    }
}
