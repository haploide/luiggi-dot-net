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
    public partial class Consultar_Orden_de_Compra : Form
    {
        private static Consultar_Orden_de_Compra InstanciaFormulario = null;

        public Consultar_Orden_de_Compra()
        {
            InitializeComponent();
        }

        public static Consultar_Orden_de_Compra Instance()
        {
            if (InstanciaFormulario == null)
            {
                InstanciaFormulario = new Consultar_Orden_de_Compra();
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
 

        private void Consultar_Orden_de_Compra_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            
        }
        private void cargarGrilla()
        {
            
            try
            {
                List<OrdenDeCompra> ordenes = OrdenDeCompraDAO.GetAll();

                dgv_pedidos.Rows.Clear();
                foreach (OrdenDeCompra o in ordenes)
                {
                    String op = "Sin Opción";

                    if (o.estado.idEstado==31)
                    {
                        op = "Registrar Recepción";
                    }
                   

                    int fila= dgv_pedidos.Rows.Add(o.idOrdenCompra, o.fechaOrden.Date.ToShortDateString(), o.proveedor.RazonSocial, o.proveedor.Apellido + " " + o.proveedor.Nombre, o.proveedor.telefono, o.proveedor.calle + " " + o.proveedor.calle_nro, o.proveedor.mail, o.monto,o.estado.Nombre, o.estado.idEstado,op, false);

                    if (o.estado.idEstado != 33)
                    {
                        dgv_pedidos.Rows[fila].DefaultCellStyle.BackColor = Color.Khaki;
                    }
                    else
                    {
                        dgv_pedidos.Rows[fila].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                    
                }
                if (dgv_pedidos.RowCount > 0)
                    dgv_pedidos.ClearSelection();

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            Gestionar_Orden_de_Compra gestPedido = new Gestionar_Orden_de_Compra();
            gestPedido._estado = estados.nuevo;
            gestPedido.ShowDialog();

            cargarGrilla();
            dgv_detalle_pedido.Rows.Clear();
        }

        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!(Boolean)dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["cerrar"].Value)
                {


                    int idOrd = (int)dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["idOrden"].Value;
                    cargarGrillaDetalle(idOrd);

                    dgv_detalle_pedido.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                
                
            }
        }
        private void cargarGrillaDetalle(int idOrd)
        {
            try
            {

                List<DetalleOrdenCompra> detOC = DetalleOrdenCompraDAO.GetDetalleXOrdenDeCompra(idOrd);
                dgv_detalle_pedido.Rows.Clear();
                foreach (DetalleOrdenCompra dor in detOC)
                {
                    Double? aux = null ;
                    String op = "Registrar Recepción";
                    if (dor.cantidadRealIngresada != 0.0)
                   {
                       aux = dor.cantidadRealIngresada;
                       op = "Sin Opción";
                   }
                    string unidadReal = "";
                    if (dor.producto.Unidad.Nombre == "g")
                    {
                        dor.producto.Unidad.Nombre = "Kilo";
                        unidadReal = "g";
                    }
                    int fila = dgv_detalle_pedido.Rows.Add(dor.producto.idProducto, dor.producto.Nombre, dor.cantidad, dor.producto.Unidad.Nombre,dor.precio, dor.subTotal,aux ,dor.ordenCompra.idOrdenCompra, op,unidadReal);
                   
                    //if (detPed.Estado.idEstado == 25 || detPed.Estado.idEstado == 4)
                    //{
                    //    dgv_detalle_pedido.Rows[fila].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    //}
                    //if (detPed.Estado.idEstado == 26)
                    //{
                    //    dgv_detalle_pedido.Rows[fila].DefaultCellStyle.BackColor = Color.IndianRed;
                    //}
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }

        private void dgv_detalle_pedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_detalle_pedido.CurrentCell is DataGridViewButtonCell)
            {
                try
                {
                    double? valor = ((Double?)dgv_detalle_pedido.CurrentRow.Cells["cantReal"].Value);

                    if (valor == null)
                    {
                        double canti = (double)dgv_detalle_pedido.Rows[dgv_detalle_pedido.CurrentRow.Index].Cells["cant"].Value;
                        string resul = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la Cantidad Comprada", "Orden de Compra", canti.ToString());
                        try
                        {
                            if (!string.IsNullOrEmpty(resul))
                            {


                                DetalleOrdenCompra det = new DetalleOrdenCompra();


                                //det.ordenCompra  = new OrdenDeCompra (){ idOrdenCompra =  (int)dgv_detalle_pedido.Rows[dgv_detalle_pedido.CurrentRow.Index].Cells["codProd"].Value};
                                det.producto = new Producto() { idProducto = (int)dgv_detalle_pedido.Rows[dgv_detalle_pedido.CurrentRow.Index].Cells["codProd"].Value };
                                det.cantidad = canti;
                                det.cantidadRealIngresada = Convert.ToDouble(resul);

                                //OrdenDeTrabajoDAO.finalizarOTHija(det);

                                MessageBox.Show("Finalizado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


                                dgv_detalle_pedido.CurrentRow.Cells["cantReal"].Value = resul;
                                dgv_detalle_pedido.CurrentRow.Cells["carrar"].Value = "Sin Opción";
                                cerraronLosHIjo();
                            }
                            dgv_detalle_pedido.ClearSelection();

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
                catch (InvalidCastException ex)
                {
                    
                    
                }
              
                
            }
        }

        private Boolean cerraronLosHIjo()
        {
            Boolean result = true;
            
                for (int i = 0; i < dgv_detalle_pedido.Rows.Count; i++)
                {
                    try
                    {
                        if (((Double?)dgv_detalle_pedido.Rows[i].Cells["cantReal"].Value) == null)
                        {
                            result = false;
                        }
                     }
                    catch (InvalidCastException ex)
                    {

                        dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["cerrar"].Value = true;
                    }
                }
            
                //dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["cerrar"].Value = true;
            

                return result;
        }
        

        private void dgv_pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_pedidos.CurrentCell is DataGridViewButtonCell)
            {
                if ((int)dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["idestado"].Value==31)
                {
                    if (cerraronLosHIjo())
                    {
                        try
                        {
                            List<DetalleOrdenCompra> detalle = new List<DetalleOrdenCompra>();

                            for (int i = 0; i < dgv_detalle_pedido.Rows.Count; i++)//SE CARGA CADA DETALLE PARA LUEGO ACTUALIZAR STOCK DE MP
                            {
                                DetalleOrdenCompra det = new DetalleOrdenCompra();

                                det.producto = new Producto() { idProducto = (int)dgv_detalle_pedido.Rows[i].Cells["codProd"].Value };
                                det.cantidadRealIngresada = Convert.ToDouble(dgv_detalle_pedido.Rows[i].Cells["cantReal"].Value);
                                UnidadMedida u = new UnidadMedida();
                                
                                if (dgv_detalle_pedido.Rows[i].Cells["unidadReal"].Value == "g")
                                {
                                    u.Descripcion = "g";
                                }
                                else
                                    u.Descripcion = "";
                                det.producto.Unidad = u;
                                det.precio = (Double)dgv_detalle_pedido.Rows[i].Cells["precio"].Value;
                                if(((string)dgv_detalle_pedido.Rows[i].Cells["unidad"].Value).Equals("g"))
                                {
                                    det.precio = det.precio/1000;
                                }

                                detalle.Add(det);
                            }

                            OrdenDeCompra ord = new OrdenDeCompra();

                            ord.detalleOrdenCompra = detalle;
                            ord.idOrdenCompra = (int)dgv_pedidos.CurrentRow.Cells["idOrden"].Value;
                            ord.estado = new Estado() { idEstado = 32 };

                            OrdenDeCompraDAO.UpdateEstadoOrdenCompra(ord);

                            MessageBox.Show("Finalizado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        }
                        catch (ApplicationException ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta Registrar la Cantidades de Productos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                    cargarGrilla();
                    dgv_detalle_pedido.Rows.Clear();
                }
            }
        }

        private void dgv_pedidos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["cerrar"].Value = false;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

            if (dgv_pedidos.Rows.Count > 0)
            {
                if ((int)dgv_pedidos.CurrentRow.Cells["idestado"].Value == 31)
                {
                    EmitirOrdenDeCompra orden = new EmitirOrdenDeCompra();

                    orden._idOrden = (int)dgv_pedidos.CurrentRow.Cells["idOrden"].Value;

                    orden.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay Ordenes para Imprimir", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void Consultar_Orden_de_Compra_FormClosed(object sender, FormClosedEventArgs e)
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
