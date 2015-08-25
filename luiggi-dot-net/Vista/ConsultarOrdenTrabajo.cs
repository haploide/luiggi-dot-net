using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Controlador;
using DAO;


namespace Vista
{
    public partial class ConsultarOrdenTrabajo : Form
    {
        private static ConsultarOrdenTrabajo InstanciaFormulario = null;

        public ConsultarOrdenTrabajo()
        {
            InitializeComponent();
        }

        public static ConsultarOrdenTrabajo Instance()
        {
            if (InstanciaFormulario == null)
            {
                InstanciaFormulario = new ConsultarOrdenTrabajo();
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

        private void ConsultarOrdenTrabajo_Load(object sender, EventArgs e)
        {
            cargaCombo();
            cargarGrilla();
        }
        private void cargarGrilla()
        {
                     
            try
            {
                List<OrdenDeTrabajo> oTPadres = OrdenDeTrabajoDAO.GetAllOTPadre ();

                
                dgv_OTproductosPadres.Rows.Clear();
                foreach (OrdenDeTrabajo ot in oTPadres)
                {
                    
                    int fila=dgv_OTproductosPadres.Rows.Add(ot.idOrdenTrabajo, ot.fechaCreacion.ToShortDateString(), ot.horaInicio.ToShortTimeString(), ot.horaFin.ToShortTimeString(), ot.producto.idProducto, ot.producto.Nombre, ot.cantidad, ot.cantidadReal,ot.producto.Unidad.Nombre , ot.estado.idEstado,ot.estado.Nombre,ot.idPlan, ot.maquinaria.idMaquinaria,ot.maquinaria.Nombre,ot.empleado.idEmpleado,ot.empleado.Nombre +" "+ ot.empleado.Apellido );
                    if (ot.estado.idEstado == 19)
                    {
                        dgv_OTproductosPadres.Rows[fila].DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                    if (ot.estado.idEstado == 20)
                    {
                        dgv_OTproductosPadres.Rows[fila].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                    
                }
                dgv_OTproductosPadres.ClearSelection();

            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void cargaCombo()
        {
            List<Estado> estad = EstadoDAO.GetAllXAmbito(5);

            estad.Add(new Estado() { idEstado = -1, Nombre = "TODOS" });

            cmb_estado_plan.DataSource = estad;
            cmb_estado_plan.DisplayMember = "nombre";
            cmb_estado_plan.ValueMember = "idEstado";

            cmb_estado_plan.SelectedValue = -1;

        }
        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
           
        }
        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Gestion_de_orden_de_Trabajo gestPlan = new Gestion_de_orden_de_Trabajo();
            gestPlan.ShowDialog();

            cargarGrilla();
        }
        private void dgv_OTproductosPadres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPlan = (int)dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["idPlan"].Value;
            int idProd = (int)dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["idProducto"].Value;
            DateTime fecha = Convert.ToDateTime(dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["fechaCreacion"].Value);
            cargarGrillaOTHijo(idProd, fecha, idPlan);


            dgv_OTproductosHijos.ClearSelection();
        }
        private void cargarGrillaOTHijo(int idProd, DateTime fecha, int  idPlan)
        {
            try
            {
                List<OrdenDeTrabajo> OThijos = OrdenDeTrabajoDAO.GetAllOTHija(idProd,fecha, idPlan);

                dgv_OTproductosHijos .Rows.Clear();
                foreach (OrdenDeTrabajo oth in OThijos)
                {
                    int fila=dgv_OTproductosHijos.Rows.Add(oth.idOrdenTrabajo, oth.fechaCreacion.ToShortDateString(), oth.horaInicio.ToShortTimeString(), oth.horaFin.ToShortTimeString(), oth.productoIntermedio.idProducto, oth.productoIntermedio.Nombre,oth.cantidad,oth.cantidadReal,oth.productoIntermedio.Unidad.Nombre, oth.estado.Nombre, oth.maquinaria.idMaquinaria, oth.maquinaria.Nombre,oth.empleado.idEmpleado, oth.empleado.Nombre + " " + oth.empleado.Apellido, oth.estado.idEstado);
                    if (oth.estado.idEstado == 19)
                    {
                        dgv_OTproductosHijos.Rows[fila].DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                    if (oth.estado.idEstado == 20)
                    {
                        dgv_OTproductosHijos.Rows[fila].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (dgv_OTproductosPadres.Rows.Count > 0 && dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].DefaultCellStyle.BackColor == Color.IndianRed )
            {
                OrdenDeTrabajo orden = new OrdenDeTrabajo();

                orden.producto = new Producto() { idProducto = (int)dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["idProducto"].Value };
                orden.fechaCreacion = Convert.ToDateTime(dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["fechaCreacion"].Value);
                orden.idPlan = (int)dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["idPlan"].Value;

                Emitir_Orden_De_Trabajo emitir = new Emitir_Orden_De_Trabajo();

                emitir._orden = orden;
                emitir._reporte = reporteOT.intermedio;
                emitir.ShowDialog();

                emitir = new Emitir_Orden_De_Trabajo();

                emitir._orden = orden;
                emitir._reporte = reporteOT.final;
                emitir.ShowDialog();





            }
            else 
            {
                MessageBox.Show("Esta Orden de Trabajo ya fue Finalizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void dgv_OTproductosPadres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (dgv_OTproductosPadres.CurrentCell is DataGridViewButtonCell)
                {
                    if (dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].DefaultCellStyle.BackColor != Color.MediumSeaGreen)
                    {
                        if (tieneHijosFinalizados() == true)
                        {
                            try
                            {
                                double cant = (double)dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["cantidad"].Value;
                                if (dgv_OTproductosPadres.CurrentRow.Cells["cantiReal"].Value != String.Empty)
                                {
                                    double cantidadPlan = 0;
                                    double cantidadPedido = DetallePlanProduccionDAO.GetCantidadPedidosParaOT((int)dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["idProducto"].Value, Convert.ToDateTime(dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["fechaCreacion"].Value));
                                    cantidadPlan = cant - cantidadPedido;
                                    DateTime fecha = Convert.ToDateTime(dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["fechaCreacion"].Value);


                                    OrdenDeTrabajo orden = new OrdenDeTrabajo();
                                    orden.idOrdenTrabajo = int.Parse(dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["idOrden"].Value.ToString());
                                    Producto prod = new Producto();
                                    prod.idProducto = int.Parse(dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["idProducto"].Value.ToString());
                                    prod.Nombre = dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["nomProducto"].Value.ToString();
                                    UnidadMedida unidad = new UnidadMedida();
                                    unidad.Nombre = dgv_OTproductosPadres.Rows[dgv_OTproductosPadres.CurrentRow.Index].Cells["unidad"].Value.ToString();
                                    prod.Unidad = unidad;
                                    orden.fechaCreacion = fecha;
                                    orden.producto = prod;
                                    orden.cantidad = cant;
                                    ActualizarStock act = new ActualizarStock(orden, cantidadPedido,cantidadPlan);
                                    act.ShowDialog();
                                    if (orden.estado != null)
                                    {
                                        if (orden.estado.Nombre == "LISTO")
                                        {
                                            MessageBox.Show("Finalizado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                            dgv_OTproductosPadres.CurrentRow.DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                                            dgv_OTproductosPadres.CurrentRow.Cells["cantiReal"].Value = orden.cantidadReal;
                                            cargarGrilla();
                                        }
                                    }
                                }
                            }
                            catch (FormatException ex)
                            {

                                MessageBox.Show("Ingrese solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                            }
                            catch (ApplicationException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Primero debe Finalizar las Ordenes de Trabajo de los Productos Intermedios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                        }


                    }
                    
            }
            
        }
        private Boolean tieneHijosFinalizados()
        {
            Boolean result = true;
            for (int i = 0; i < dgv_OTproductosHijos.Rows.Count; i++)
            {
                if(dgv_OTproductosHijos.Rows[i].DefaultCellStyle.BackColor!=Color.MediumSeaGreen)
                {
                    result = false;
                }
            }

            return result;
        }
        private void dgv_OTproductosHijos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_OTproductosHijos.CurrentCell is DataGridViewButtonCell)
            {
                if (dgv_OTproductosHijos.Rows[dgv_OTproductosHijos.CurrentRow.Index].DefaultCellStyle.BackColor != Color.MediumSeaGreen)
                {
                    try
                    {
                        double canti = (double)dgv_OTproductosHijos.Rows[dgv_OTproductosHijos.CurrentRow.Index].Cells["cant"].Value;
                        OrdenDeTrabajo orden = new OrdenDeTrabajo();
                        orden.idOrdenTrabajo = (int)dgv_OTproductosHijos.Rows[dgv_OTproductosHijos.CurrentRow.Index].Cells["idOT"].Value;
                        Producto prod = new Producto();
                        prod.idProducto =(int)dgv_OTproductosHijos.Rows[dgv_OTproductosHijos.CurrentRow.Index].Cells["idProd"].Value;
                        prod.Nombre = dgv_OTproductosHijos.Rows[dgv_OTproductosHijos.CurrentRow.Index].Cells["poductoDetalle"].Value.ToString();
                        UnidadMedida unidad = new UnidadMedida();
                        unidad.Nombre = dgv_OTproductosHijos.Rows[dgv_OTproductosHijos.CurrentRow.Index].Cells["unidadMedida"].Value.ToString();
                        prod.Unidad = unidad;
                        orden.producto = prod;
                        orden.cantidad = canti;
                        ActualizarStock act = new ActualizarStock(orden);
                        act.ShowDialog();
                        if (orden.estado != null)
                        {
                            if (orden.estado.Nombre == "LISTO")
                            {
                                MessageBox.Show("Finalizado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                dgv_OTproductosHijos.CurrentRow.DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                                dgv_OTproductosHijos.CurrentRow.Cells["cantReal"].Value = orden.cantidadReal;
                            }
                        }
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    catch (FormatException ex)
                    {

                        MessageBox.Show("Ingrese solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    }
                    
                }

             }
            dgv_OTproductosHijos.ClearSelection();

            
        }

        private void dgv_OTproductosHijos_Click(object sender, EventArgs e)
        {
            dgv_OTproductosHijos.ClearSelection();
        }

        private void ConsultarOrdenTrabajo_FormClosed(object sender, FormClosedEventArgs e)
        {
            iniciador.cantVentanasAbiertas--;

            if (iniciador.cantVentanasAbiertas == 0)
            {
                ((Menu_Principal)(MdiParent)).btn_impresiones.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_ventas.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_pedido.Visible = true;
            }
        }

        


    }
}
