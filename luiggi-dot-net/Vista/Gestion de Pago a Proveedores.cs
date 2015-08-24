using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using DAO;

namespace Vista
{
    public partial class Gestion_de_Pago_a_Proveedores : Form
    {
        public Gestion_de_Pago_a_Proveedores()
        {
            InitializeComponent();
        }

        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Gestion_de_Pago_a_Proveedores_Load(object sender, EventArgs e)
        {
            dtp_desde.Value = Convert.ToDateTime("01/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
            dtp_hasta.Value = Convert.ToDateTime("28/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
            cargarGrilla();
        }
        private void cargarGrilla()
        {

            try
            {
                List<OrdenDeCompra> ordenes = OrdenDeCompraDAO.GetAll();
                dgv_Orden_Compra.Rows.Clear();
                foreach (OrdenDeCompra or in ordenes)
                {
                    if (or.estado.idEstado!=31)
                    {
                        DateTime aux = Convert.ToDateTime("01/01/1900");
                        DateTime? fec;
                        DateTime? fecPago;

                        if (or.fechaRemito.Date == aux.Date)
                        {
                            fec = null;
                        }
                        else
                        {
                            fec = or.fechaRemito.Date;
                        }
                        if (or.fechaPago.Date == aux.Date)
                        {
                            fecPago = null;
                        }
                        else
                        {
                            fecPago = or.fechaPago.Date;
                        }
                        String op = "Sin Opción";

                        if (or.estado.idEstado != 33)
                        {
                            op = "Registrar Pago";
                        }

                        int fila = dgv_Orden_Compra.Rows.Add(or.idOrdenCompra, or.fechaOrden, or.proveedor.RazonSocial, or.proveedor.Apellido + " " + or.proveedor.Nombre, or.monto, fecPago, or.estado.Nombre, or.estado.idEstado, op);

                        if (or.estado.idEstado != 33)
                        {
                            dgv_Orden_Compra.Rows[fila].DefaultCellStyle.BackColor = Color.Khaki;
                        }
                        else
                        {
                            dgv_Orden_Compra.Rows[fila].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                        } 
                    }

                }

            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void dgv_Orden_Compra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idOrden = (int)dgv_Orden_Compra.Rows[dgv_Orden_Compra.CurrentRow.Index].Cells["idOrden"].Value;
            cargarGrillaDetalle(idOrden);

            dgv_detalle_orden_compra.ClearSelection();
        }
        private void cargarGrillaDetalle(int idOrden)
        {
            try
            {
                List<DetalleOrdenCompra> detOrden = DetalleOrdenCompraDAO.GetDetalleXOrdenDeCompra(idOrden);
                dgv_detalle_orden_compra.Rows.Clear();
                foreach (DetalleOrdenCompra detOrd in detOrden)
                {

                    dgv_detalle_orden_compra.Rows.Add(detOrd.producto.idProducto, detOrd.producto.Nombre, detOrd.cantidad, detOrd.producto.Unidad.Nombre, detOrd.precio, detOrd.subTotal);

                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btn_aplicar_filtro_empresa_Click(object sender, EventArgs e)
        {
            cargaGrillsFiltros();

        }
        private void cargaGrillsFiltros()
        {
            //DateTime? fdesde = null;
            //DateTime? fhasta = null;
            double? mDesde = null;
            double? mHasta = null;
            int? cuit = null;


            DateTime fdesde = dtp_desde.Value;
            DateTime fhasta = dtp_hasta.Value;



            if (!string.IsNullOrEmpty(txt_monto_desde.Text))
                mDesde = double.Parse(txt_monto_desde.Text);

            if (!string.IsNullOrEmpty(txt_monto_hasta.Text))
                mHasta = double.Parse(txt_monto_hasta.Text);

            if (!string.IsNullOrEmpty(txt_cuit.Text))
                cuit = int.Parse(txt_cuit.Text);

            try
            {


                //List<OrdenDeCompra > ordenes = FacturaDAO.GetByFiltros((int)cmb_estado_pedido.SelectedValue, (int)cmb_tipo_doc.SelectedValue, nroDoc, mDesde, mHasta, txt_nombre.Text, txt_apellido.Text, txt_razon_social.Text, cuit, fdesde, fhasta, tipo, cmb_tipo_factura.SelectedIndex);

                List<OrdenDeCompra> ordenes = OrdenDeCompraDAO.GetByFiltros(mDesde, mHasta, txt_nombre.Text, txt_apellido.Text, txt_razon_social.Text, cuit, fdesde, fhasta);
                dgv_Orden_Compra.Rows.Clear();
                foreach (OrdenDeCompra or in ordenes)
                {

                    DateTime aux = Convert.ToDateTime("01/01/1900");
                    DateTime? fec;
                    DateTime? fecPago;

                    if (or.fechaRemito.Date == aux.Date)
                    {
                        fec = null;
                    }
                    else
                    {
                        fec = or.fechaRemito.Date;
                    }
                    if (or.fechaPago.Date == aux.Date)
                    {
                        fecPago = null;
                    }
                    else
                    {
                        fecPago = or.fechaPago.Date;
                    }
                    String op = "Sin Opción";

                    if (or.estado.idEstado != 33)
                    {
                        op = "Registrar Pago";
                    }

                    int fila = dgv_Orden_Compra.Rows.Add(or.idOrdenCompra, or.fechaOrden, or.proveedor.RazonSocial, or.proveedor.Apellido + " " + or.proveedor.Nombre, or.monto, fecPago, or.estado.Nombre, or.estado.idEstado, op);

                    if (or.estado.idEstado != 33)
                    {
                        dgv_Orden_Compra.Rows[fila].DefaultCellStyle.BackColor = Color.Khaki;
                    }
                    else
                    {
                        dgv_Orden_Compra.Rows[fila].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void dgv_Orden_Compra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Orden_Compra.CurrentCell is DataGridViewButtonCell)
            {

                if ((int)dgv_Orden_Compra.CurrentRow.Cells["idestado"].Value != 33)
                {
                    int idOrden = (int)dgv_Orden_Compra.CurrentRow.Cells["idOrden"].Value;

                    try
                    {
                        OrdenDeCompraDAO.UpdateOrdenCompraPagada(idOrden);
                        MessageBox.Show("Pago Registrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    cargarGrilla();
                }
            }

        }

        private void Gestion_de_Pago_a_Proveedores_FormClosed(object sender, FormClosedEventArgs e)
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