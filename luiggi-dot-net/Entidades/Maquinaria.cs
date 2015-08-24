using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public  class Maquinaria
    {
        public int idMaquinaria { get; set; }
        public string Nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaAlta { get; set; }
        public Estado estado { get; set; }
        public TipoMaquinaria tipoMaquinaria { get; set; }
    }
}
