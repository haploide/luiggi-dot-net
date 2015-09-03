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
    public partial class Gestion_de_Facturas : Form
    {
        private static Gestion_de_Facturas InstanciaFormulario = null;

        public Gestion_de_Facturas()
        {
            InitializeComponent();
        }

        public static Gestion_de_Facturas Instance()
        {
            if (InstanciaFormulario == null)
            {
                InstanciaFormulario = new Gestion_de_Facturas();
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

        private void Gestion_de_Facturas_Load(object sender, EventArgs e)
        {
            cargarCombos();
            cargarGrilla();
            dtp_desde.Value = Convert.ToDateTime("01/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
            dtp_hasta.Value = Convert.ToDateTime("28/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
        }


        public void cargarCombos()
        {
            try
            {

                List<Estado> est = EstadoDAO.GetAllFactura(); ;
                List<TipoDocumento> tipoD = TipoDocumentoDAO.GetAll();
                est.Add(new Estado { idEstado = 0, Nombre = "TODOS" });
                tipoD.Add(new TipoDocumento { IDTipoDoc = 0, Nombre = "TODOS" });
                cmb_estado_pedido.DataSource = est;
                cmb_estado_pedido.DisplayMember = "Nombre";
                cmb_estado_pedido.ValueMember = "idEstado";
                cmb_estado_pedido.SelectedValue = 0;

                cmb_tipo_doc.DataSource = tipoD;
                cmb_tipo_doc.DisplayMember = "Nombre";
                cmb_tipo_doc.ValueMember = "IDTipoDoc";
                cmb_tipo_doc.SelectedValue = 0;

                cmb_tipo_factura.SelectedIndex = 3;

            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }
        private void cargarGrilla()
        {
            String opcion = "Sin Opción";
            try
            {
                List<Factura> facturas = FacturaDAO.GetAll();


                dgv_factura.Rows.Clear();
                foreach (Factura factura in facturas)
                {
                    switch (factura.estado.idEstado)
                    {
                        
                        case 27:
                            opcion = "Registrar Cobro";
                            break;
                        default:
                            opcion = "Sin Opción";
                            break;
                    }
                    DateTime aux=Convert.ToDateTime("01/01/1900");
                    DateTime? fec;

                    if (factura.fechaPago.Date == aux.Date)
                    {
                        fec = null;
                    }
                    else
                    {
                        fec = factura.fechaPago.Date;
                    }
                    int fila = dgv_factura.Rows.Add(factura.idFactura,factura.fechaCreacion,factura.cliente.RazonSocial,factura.cliente.Nombre,factura.cliente.Apellido,factura.estado.Nombre,factura.tipoFactura,factura.importeTotal,fec,opcion,factura.estado.idEstado);

                    dgv_factura.Rows[fila].DefaultCellStyle.BackColor = Color.Khaki;


                    if (factura.estado.idEstado == 28)
                    {
                        dgv_factura.Rows[fila].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    if (factura.estado.idEstado == 30)
                    {
                        dgv_factura.Rows[fila].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }

            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dgv_factura_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int idFactura = (int)dgv_factura.Rows[dgv_factura.CurrentRow.Index].Cells["idFactura"].Value;
                cargarGrillaDetalle(idFactura);

                dgv_detalle_factura.ClearSelection();
            }
            catch (Exception ex)
            {
                
                
            }
        }
        private void cargarGrillaDetalle(int idfactura)
        {
            try
            {
                List<DetalleFactura> detFactura = DetalleFacturaDAO.GetDetalleFactura(idfactura);
                dgv_detalle_factura.Rows.Clear();
                foreach (DetalleFactura detFac in detFactura)
                {
                    if (detFac.producto.idProducto == -1)
                    {
                        double subtotal = (detFac.subTotal * detFac.cantidad) + detFac.iva;
                        dgv_detalle_factura.Rows.Add(detFac.detPedido.producto.idProducto, detFac.detPedido.producto.Nombre, detFac.detPedido.producto.Unidad.Nombre, detFac.cantidad, detFac.subTotal, subtotal, detFac.iva, null, detFac.idDetalle);
                    }else
                    {
                        if (detFac.detPedido.producto.idProducto == -1)
                        {
                            double subtotal = (detFac.subTotal * detFac.cantidad) + detFac.iva;
                            dgv_detalle_factura.Rows.Add(detFac.producto.idProducto, detFac.producto.Nombre, detFac.producto.Unidad.Nombre, detFac.cantidad, detFac.subTotal, subtotal, detFac.iva, null, detFac.idDetalle);
          
                        }
                    }
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
            int? nroDoc = null;

            DateTime fdesde = dtp_desde.Value;
            DateTime fhasta = dtp_hasta.Value;

            String opcion = "Sin Opción";

            if (!string.IsNullOrEmpty(txt_monto_desde.Text))
                mDesde = double.Parse(txt_monto_desde.Text);

            if (!string.IsNullOrEmpty(txt_monto_hasta.Text))
                mHasta = double.Parse(txt_monto_hasta.Text);

            if (!string.IsNullOrEmpty(txt_cuit.Text))
                cuit = int.Parse(txt_cuit.Text);
            if (!string.IsNullOrEmpty(txt_nro_doc.Text))
                nroDoc = int.Parse(txt_nro_doc.Text);
            try
            {
                char tipo = 'j';
                if (cmb_tipo_factura.SelectedIndex!=3)
                {
                    tipo=Convert.ToChar(cmb_tipo_factura.Text);
                }

                List<Factura> facturas = FacturaDAO.GetByFiltros((int)cmb_estado_pedido.SelectedValue, (int)cmb_tipo_doc.SelectedValue, nroDoc, mDesde, mHasta, txt_nombre.Text, txt_apellido.Text, txt_razon_social.Text, cuit, fdesde, fhasta, tipo, cmb_tipo_factura.SelectedIndex);

                dgv_factura.Rows.Clear();
                foreach (Factura factura in facturas)
                {

                    switch (factura.estado.idEstado)
                    {
                        
                        case 27:
                            opcion = "Registrar Cobro";
                            break;
                        default:
                            opcion = "Sin Opción";
                            break;
                    }
                    DateTime aux = Convert.ToDateTime("01/01/1900");
                    DateTime? fec;

                    if (factura.fechaPago.Date == aux.Date)
                    {
                        fec = null;
                    }
                    else
                    {
                        fec = factura.fechaPago.Date;
                    }
                    int fila = dgv_factura.Rows.Add(factura.idFactura, factura.fechaCreacion, factura.cliente.RazonSocial, factura.cliente.Nombre, factura.cliente.Apellido, factura.estado.Nombre, factura.tipoFactura, factura.importeTotal, fec, opcion, factura.estado.idEstado);

                    dgv_factura.Rows[fila].DefaultCellStyle.BackColor = Color.Khaki;


                    if (factura.estado.idEstado == 28)
                    {
                        dgv_factura.Rows[fila].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    if (factura.estado.idEstado == 30)
                    {
                        dgv_factura.Rows[fila].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                    
                }

            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            foreach (Control cont in gp_filtros.Controls)
            {
                if (cont is TextBox)
                {
                    cont.Text = "";
                }
                if (cont is ComboBox)
                {
                    ((ComboBox)cont).SelectedIndex = 0;
                }
            }
            Gestion_de_Facturas_Load(sender, e);

        }

        private void dgv_factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_factura.CurrentCell is DataGridViewButtonCell)
            {

                if ((int)dgv_factura.CurrentRow.Cells["idestado"].Value!=28)
                {
                    int idFactura = (int)dgv_factura.CurrentRow.Cells["idFactura"].Value;

                    try
                    {
                        FacturaDAO.UpdateEstado(idFactura, 28, DateTime.Now.Date);
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

        private void Gestion_de_Facturas_FormClosed(object sender, FormClosedEventArgs e)
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
