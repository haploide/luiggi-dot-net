using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class PlanMaestroProduccion
    {

        public int IDPlanProduccion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public Estado estado { get; set; }
        public string observaciones { get; set; }
        public DateTime fechaCancelacion { get; set; }
        public string motivoCancelacion { get; set; }
        public List<DetallePlanProduccion> detallePlan { get; set; } 
    }
}
