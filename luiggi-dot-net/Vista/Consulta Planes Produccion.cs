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
    public partial class Consulta_Planes_Produccion : Form
    {
        private static Consulta_Planes_Produccion InstanciaFormulario = null;

        public Consulta_Planes_Produccion()
        {
            InitializeComponent();
        }

        public static Consulta_Planes_Produccion Instance()
        {
            if (InstanciaFormulario == null)
            {
                InstanciaFormulario = new Consulta_Planes_Produccion();
            }
            return InstanciaFormulario;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            InstanciaFormulario = null;
        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            GestionPlanMaestroProduccion gestPlan = new GestionPlanMaestroProduccion();
            gestPlan.ShowDialog();
            cargarGrilla();
        }
        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        private void Consulta_Planes_Produccion_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrilla();
        }
        private void cargarCombo()
        {
            try
            {

                List<Estado> est = EstadoDAO.GetAllPlan();
                est.Add(new Estado { idEstado = 0, Nombre = "TODOS" });

                cmb_estado_plan.DataSource = est;
                cmb_estado_plan.DisplayMember = "Nombre";
                cmb_estado_plan.ValueMember = "idEstado";
                cmb_estado_plan.SelectedValue = 0;

            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void cargarGrilla()
        {
            try
            {
                List<PlanMaestroProduccion> planes = PlanMaestroProduccionDAO.GetAll();

                dgv_planes.Rows.Clear();
                foreach (PlanMaestroProduccion plan in planes)
                {
                    dgv_planes.Rows.Add(plan.IDPlanProduccion, plan.fechaCreacion,plan.estado.Nombre,plan.fechaInicio,plan.fechaFin);
                }

            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void dgv_planes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPlan = (int)dgv_planes.Rows[dgv_planes.CurrentRow.Index].Cells["nroPlan"].Value;
            cargarGrillaDetalle(idPlan);
        }
        private void cargarGrillaDetalle(int plan)
        {
            try
            {
                List<DetallePlanProduccion> detPlan = DetallePlanProduccionDAO.GetDetalleXPlan(plan);

                dgv_detalle_plan.Rows.Clear();
                foreach (DetallePlanProduccion detP in detPlan)
                {
                    dgv_detalle_plan.Rows.Add(detP.producto.idProducto, detP.producto.Nombre, detP.producto.Unidad.Nombre, detP.cantidadPLan,detP.cantidadPedido,detP.cantidadPLan+detP.cantidadPedido,detP.fechaProduccion);
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void dgv_planes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PlanMaestroProduccion plan = new PlanMaestroProduccion();

            plan.IDPlanProduccion = (int)dgv_planes.Rows[dgv_planes.CurrentRow.Index].Cells["nroPlan"].Value;


            GestionPlanMaestroProduccion gestPlan = new GestionPlanMaestroProduccion();
            gestPlan._estado = estados.modificar;
            gestPlan._planModificar = plan;
            
           gestPlan.ShowDialog();
            
            cargarGrilla();
            dgv_detalle_plan.Rows.Clear();
        }
        private void btn_aplicar_filtro_Click(object sender, EventArgs e)
        {
            cargaGrillaFiltros();
        }
        private void cargaGrillaFiltros()
        {
            DateTime fFdesde = dtp_desde_fin.Value;
            DateTime fFhasta = dtp_hasta_fin.Value;


            try
            {
                List<PlanMaestroProduccion> planes = PlanMaestroProduccionDAO.GetByFiltros((int)cmb_estado_plan.SelectedValue, fFdesde, fFhasta);

                dgv_planes.Rows.Clear();
                foreach (PlanMaestroProduccion plan in planes)
                {
                    dgv_planes.Rows.Add(plan.IDPlanProduccion, plan.fechaCreacion, plan.estado.Nombre, plan.fechaInicio, plan.fechaFin);
                }

            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Consulta_Planes_Produccion_Load(sender, e);
            dtp_desde_fin.Value = DateTime.Now;
            dtp_hasta_fin.Value = DateTime.Now;
        }

        private void Consulta_Planes_Produccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            iniciador.cantVentanasAbiertas--;

            if (iniciador.cantVentanasAbiertas == 0)
            {
                ((Menu_Principal)(MdiParent)).btn_impresiones.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_ventas.Visible = true;
            }
        }
    }
}
