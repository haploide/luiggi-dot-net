using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Entidades
{
    public class DetalleProducto
    {
        public int idProducto { get; set; }
        public int CODProducto { get; set; }
        public string Nombre { get; set; }
        public double cantidad { get; set; }
        public Categoria Categoria { get; set; }
        public string Descripcion { get; set; }
        public UnidadMedida Unidad { get; set; }
        public int Stock { get; set; }
        public int StockRiesgo { get; set; }
        public double precio { get; set; }
        public Image foto { get; set; }
        public int idProductoPadre { get; set; }
        public UnidadMedida UnidadTiempo { get; set; }
        public double tiempoProduccion { get; set; }
        public double cantidadProductos { get; set; }
        public TipoMaquinaria TipoMaquinaria { get; set; }
    }

}
