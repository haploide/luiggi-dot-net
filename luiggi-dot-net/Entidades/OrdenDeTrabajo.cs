using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class OrdenDeTrabajo
    {
        public int idOrdenTrabajo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idOrdenTrabajoPadre { get; set; }
        public DateTime fechaPlan { get; set; }
        public Producto producto { get; set; }
        public Producto productoIntermedio { get; set; }
        public Estado estado { get; set; }
        public int idPlan { get; set; }
        public string observaciones { get; set; }
        public PlanMaestroProduccion plan { get; set; }
        public Pedido pedido { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
        public Empleado  empleado { get; set; }
        public Maquinaria  maquinaria { get; set; }
        public double cantidad { get; set; }
        public double cantidadReal { get; set; }
        //public List<DetalleOrdenTrabajo> detalle { get; set; }
    }
}
