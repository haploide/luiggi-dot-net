using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Entidades
{
    public  class ProductoXProveedor
    {
        public Persona proveedor { get; set; }
        public Producto producto { get; set; }
        public double precioProveedor { get; set; }
        public DateTime fechaPrecio { get; set; }
    }
}
