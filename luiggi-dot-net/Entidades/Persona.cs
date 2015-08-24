using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        public int idPersona { get; set; }
        public int NroCliente { get; set; }
        public int NroProveedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string  cuil { get; set; }
        public string RazonSocial { get; set; }
        public TipoDocumento TipoDoc { get; set; }
        public long  NroDoc { get; set; }
        public string calle { get; set; } 
        public int calle_nro { get; set; }
        public int piso { get; set; }
        public int depto { get; set; }
        public string Barrio { get; set; }
        public string mail { get; set; }
        public string  telefono { get; set; }
        public Localidad Localidad { get; set; }
        public CondicionIVA condicionIVA { get; set; }
        public TipoConsumidor tipoConsumidor { get; set; }
        public string tefefonoCelular { get; set; }
        public DateTime fechaNAc { get; set; }
        public Char Sexo { get; set; }
      
    }
}
