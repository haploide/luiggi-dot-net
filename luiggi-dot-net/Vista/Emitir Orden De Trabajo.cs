using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using Entidades;

namespace Vista
{
    public partial class Emitir_Orden_De_Trabajo : Form
    {
        private OrdenDeTrabajo orden;
        private reporteOT reporte;


        public OrdenDeTrabajo _orden
        {
            get { return orden; }
            set { orden = value; }
        }
        public reporteOT _reporte
        {
            get { return reporte; }
            set { reporte = value; }
        }


        public Emitir_Orden_De_Trabajo()
        {
            InitializeComponent();
        }

        private void Emitir_Orden_De_Trabajo_Load(object sender, EventArgs e)
        {
            if (reporte==reporteOT.intermedio)
            {
                OrdenDeTrabajoIntermediasBindingSource.DataSource = OrdenDeTrabajoDAO.GetAllEmitir(orden.producto.idProducto, orden.fechaCreacion, orden.idPlan);
                this.reportViewer1.RefreshReport(); 
            }
            if (reporte == reporteOT.final)
            {
                OrdenDeTrabajoIntermediasBindingSource.DataSource = OrdenDeTrabajoDAO.GetAllEmitirFinal(orden.producto.idProducto, orden.fechaCreacion, orden.idPlan);
                this.reportViewer1.RefreshReport(); 
            }
        }
    }
}
