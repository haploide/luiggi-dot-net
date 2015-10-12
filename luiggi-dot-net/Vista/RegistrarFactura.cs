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
    public partial class RegistrarFactura : Form
    {
        private estados estadoFormulario;
        private int idPedido;
        Pedido ped;
        private List<DetalleFactura> detalleAgregado = null;


        public int _idPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        public estados _estado
        {
            get { return estadoFormulario; }
            set { estadoFormulario = value; }
        }
        public RegistrarFactura()
        {
            InitializeComponent();
        }
        private void RegistrarFactura_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarCliente(idPedido);

            txt_nroFactura.Text = FacturaDAO.getUltimoNumeroFactura().ToString();

            dgv_detalle.ClearSelection();
        }
        public void cargarCombo()
        {

            List<TipoDocumento> tipDoc = TipoDocumentoDAO.GetAll();
            List<CondicionIVA> condIva = CondicionIVADAO.GetAll();

            tipDoc.Add(new TipoDocumento { IDTipoDoc = 0, Nombre = "SELECCIONE" });

            cmb_tipo_doc.DataSource = tipDoc;
            cmb_tipo_doc.DisplayMember = "nombre";
            cmb_tipo_doc.ValueMember = "IDTipoDoc";

            cmb_tipo_doc.SelectedValue = 0;

            

            cmb_iva.DataSource = condIva;
            cmb_iva.DisplayMember = "nombre";
            cmb_iva.ValueMember = "idCondicionIVA";

            cmb_iva.SelectedValue = 4;

           
        }
        private void cargarCliente(int id)
        {
            ped=PedidoDAO.GetById(id);

            txt_apellido.Text = ped.cliente.Apellido.ToString();
            txt_nombre.Text = ped.cliente.Nombre.ToString();
            txt_razon_social.Text = ped.cliente.RazonSocial.ToString();
            txt_cuit.Text = ped.cliente.cuil.ToString();
            txt_nro_doc.Text = ped.cliente.NroDoc.ToString();
            cmb_tipo_doc.SelectedValue = ped.cliente.TipoDoc.IDTipoDoc;
            cmb_iva.SelectedValue = ped.cliente.condicionIVA.idCondicionIVA;
           
            txt_monto_total.Text = ped.montoTotal.ToString();
            cargarGrillaDetalle(ped.idPedido);
            
        }
        private void cargarGrillaDetalle(int idPed)
        {
            double totalIVA=0;
            double subtotal = 0;
            try
            {
                List<DetallePedido> detP = DetallePedidoDAO.GetDetalleXPedido(idPed);
                ped.detallePedido = detP;
                dgv_detalle.Rows.Clear();
                foreach (DetallePedido detPed in detP)
                {
                    if (Convert.ToInt32(cmb_iva.SelectedIndex) == 0)
                    {
                        //ACA CAMBIAR EL PORCENTAJE DEL IVA
                        double Iva=detPed.precio*0.21;
                        totalIVA += Iva * detPed.cantidad;
                        subtotal += (detPed.precio - Iva)*detPed.cantidad;
                        dgv_detalle.Rows.Add(detPed.producto.CODProducto, detPed.producto.Nombre, detPed.producto.Unidad.Nombre, detPed.cantidad, detPed.precio - Iva, detPed.subTotal, detPed.producto.idProducto, (Iva) * detPed.cantidad,0);
                    }
                    else
                    {
                        subtotal += detPed.precio*detPed.cantidad;
                        dgv_detalle.Rows.Add(detPed.producto.CODProducto, detPed.producto.Nombre, detPed.producto.Unidad.Nombre, detPed.cantidad, detPed.precio, detPed.subTotal, detPed.producto.idProducto,0,0);
           
                    }
                }
                txt_subtotal.Text = subtotal.ToString();
                txt_totalIva.Text = totalIVA.ToString();
                
             }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }
        private void cmb_iva_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmb_iva.SelectedIndex) == 0)
            {
                sinIva.Visible = true;
                //lbl_iva.Visible = true;
                //txt_totalIva.Visible = true;
                cmb_tipo_factura.SelectedIndex = 0;
            }
            else
            {
                sinIva.Visible = false;
                //lbl_iva.Visible = false;
                //txt_totalIva.Visible = false;
                cmb_tipo_factura.SelectedIndex = 1;
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            iniciador.detalle = null;
            this.Close();
            this.Dispose();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            if (estadoFormulario == estados.nuevo)
            {
                Factura factura = new Factura();
                List<DetalleFactura> detalle= new List<DetalleFactura>();

                try
                {
                    if (Convert.ToInt32(cmb_iva.SelectedIndex) == 0)
                    {
                        for (int c = 0; c < dgv_detalle.RowCount; c++)
                        {
                            int esSinpedido = (int)dgv_detalle.Rows[c].Cells["add"].Value;
                            DetalleFactura det = new DetalleFactura();

                            det.cantidad = Convert.ToDouble(dgv_detalle.Rows[c].Cells["cantidad"].Value);
                            if (esSinpedido == 0)
                            {
                                det.detPedido = new DetallePedido() { producto = new Producto() { idProducto = Convert.ToInt32(dgv_detalle.Rows[c].Cells["idProductodetalle"].Value) }, pedido = new Pedido() { idPedido = idPedido }, };
                                foreach (DetallePedido detp in ped.detallePedido)
                                {
                                    if(detp.producto.idProducto==Convert.ToInt32(dgv_detalle.Rows[c].Cells["idProductodetalle"].Value))
                                    {
                                        det.detPedido.cantidad = detp.cantidad;
                                    }
                                }
                            }
                            else
                            {
                                det.producto = new Producto() { idProducto = Convert.ToInt32(dgv_detalle.Rows[c].Cells["idProductodetalle"].Value) };
                            }
                            det.subTotal = Convert.ToDouble(dgv_detalle.Rows[c].Cells["preciodetalle"].Value);
                            det.iva = Convert.ToDouble(dgv_detalle.Rows[c].Cells["sinIva"].Value);
                            



                            detalle.Add(det);
                        }

                        factura.detalleFactura = detalle;
                        factura.cliente = ped.cliente;
                        factura.pedido = ped; 
                        factura.fechaCreacion = dtp_fecha_factura.Value.Date;
                        factura.importeTotal = Convert.ToDouble(txt_monto_total.Text);
                        if (rbtn_contado.Checked)
                        {
                            factura.estado = new Estado() { idEstado = 28 };
                        }
                        else
                        {
                            factura.estado = new Estado() { idEstado = 27 };
                        }
                        factura.totalIVA = Convert.ToDouble(txt_totalIva.Text);
                        factura.tipoFactura = Convert.ToChar(cmb_tipo_factura.Text);

                    }
                    else
                    {
                        for (int c = 0; c < dgv_detalle.RowCount; c++)
                        {
                            int esSinpedido = (int)dgv_detalle.Rows[c].Cells["add"].Value;
                            DetalleFactura det = new DetalleFactura();

                            det.cantidad = Convert.ToDouble(dgv_detalle.Rows[c].Cells["cantidad"].Value);
                            if (esSinpedido == 0)
                            {
                                det.detPedido = new DetallePedido() { producto = new Producto() { idProducto = Convert.ToInt32(dgv_detalle.Rows[c].Cells["idProductodetalle"].Value) }, pedido = new Pedido() { idPedido = idPedido } };
                                foreach (DetallePedido detp in ped.detallePedido)
                                {
                                    if (detp.producto.idProducto == Convert.ToInt32(dgv_detalle.Rows[c].Cells["idProductodetalle"].Value))
                                    {
                                        det.detPedido.cantidad = detp.cantidad;
                                    }
                                }
                            }
                            else
                            {
                                det.producto = new Producto() { idProducto = Convert.ToInt32(dgv_detalle.Rows[c].Cells["idProductodetalle"].Value) };
                            }
                            det.subTotal = Convert.ToDouble(dgv_detalle.Rows[c].Cells["preciodetalle"].Value);
                            
                        



                            detalle.Add(det);
                        }

                        factura.detalleFactura = detalle;
                        factura.cliente = ped.cliente;
                        factura.fechaCreacion = dtp_fecha_factura.Value.Date;
                        factura.importeTotal = Convert.ToDouble(txt_monto_total.Text);
                        if (rbtn_contado.Checked)
                        {
                            factura.estado = new Estado() { idEstado = 28 };
                        }
                        else
                        {
                            factura.estado = new Estado() { idEstado = 27 };
                        }
                        factura.pedido = ped;
                        factura.tipoFactura = Convert.ToChar(cmb_tipo_factura.Text);
                    }

                    iniciador.idFactura = FacturaDAO.Insert(factura, detalleAgregado);
                
                        
                    //MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    _estado = estados.guardado;

                    btn_guardar.Enabled = false;
                    btn_salir_Click(sender, e);

                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Agregar_productos_a_factura agregar = new Agregar_productos_a_factura();
            agregar.ShowDialog();
            detalleAgregado = Vista.iniciador.detalle;
            if (detalleAgregado != null)
            {
                foreach (DetalleFactura det in detalleAgregado)
                {
                    Boolean result = false;
                    int comparar = det.producto.idProducto;

                    for (int c = 0; c < dgv_detalle.RowCount; c++)
                    {
                        if (comparar == (int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value)
                        {
                            result = true;
                            break;
                        }

                    }

                    if (result == false)
                    {
                        int idPro = det.producto.idProducto;
                        int cod = det.producto.CODProducto;
                        string nom = det.producto.Nombre;
                        string uni = det.producto.Unidad.Nombre;
                        double can = det.cantidad;
                        double pre = det.producto.precio;
                        double subTot = can * pre;

                        if ((int)cmb_iva.SelectedValue == 1)
                        {
                            double iva=det.producto.precio*0.21;
                            dgv_detalle.Rows.Add(cod, nom, uni, can, pre-iva, subTot, idPro, iva * det.cantidad,1);
                        }
                        else
                        {
                            dgv_detalle.Rows.Add(cod, nom, uni, can, pre, subTot, idPro, 0,1);
                        }
 
                        calcularMontoTotal();
                       

                    }
                    else
                    {

                        if ((int)cmb_iva.SelectedValue == 1)
                        {
                            for (int c = 0; c < dgv_detalle.RowCount; c++)
                            {
                                if ((int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value == det.producto.idProducto)
                                {
                                    double can = (double)dgv_detalle.Rows[c].Cells["cantidad"].Value + det.cantidad;
                                    dgv_detalle.Rows[c].Cells["cantidad"].Value = can;

                                    

                                    double pre = (double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value;
                                    dgv_detalle.Rows[c].Cells["sub"].Value = can * det.producto.precio;

                                    double iva = det.producto.precio * 0.21;
                                    dgv_detalle.Rows[c].Cells["sinIva"].Value = can * iva;


                                    calcularMontoTotal();

                                }
                            }
                        }
                        else
                        {
                            for (int c = 0; c < dgv_detalle.RowCount; c++)
                            {
                                if ((int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value == det.producto.idProducto)
                                {
                                    double can = (double)dgv_detalle.Rows[c].Cells["cantidad"].Value + det.cantidad;
                                    dgv_detalle.Rows[c].Cells["cantidad"].Value = can;



                                    double pre = (double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value;
                                    dgv_detalle.Rows[c].Cells["sub"].Value = can * det.producto.precio;

                                    
                                    dgv_detalle.Rows[c].Cells["sinIva"].Value = 0;


                                    calcularMontoTotal();

                                }

                                
                            } 
                        }

                            
                        

                    }
 
                }
                btn_agregar_a_factura.Enabled = false;
            }

            
        }
        public void calcularMontoTotal()
        {
            double montoTotal = 0;
            double subTotal = 0;
            double iva = 0;
            for (int c = 0; c < dgv_detalle.RowCount; c++)
            {
                montoTotal = montoTotal + (double)dgv_detalle.Rows[c].Cells["sub"].Value;
                subTotal = subTotal + ((double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value * (double)dgv_detalle.Rows[c].Cells["cantidad"].Value);
                iva = iva + Convert.ToDouble(dgv_detalle.Rows[c].Cells["sinIva"].Value);

            }
            txt_monto_total.Text = montoTotal.ToString();
            txt_totalIva.Text = iva.ToString();
            txt_subtotal.Text = subTotal.ToString();
            if (montoTotal > 0)
            {
                btn_guardar.Enabled = true;

            }
            else
            {
                btn_guardar.Enabled = false;
            }

        }

        private void txt_monto_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Vista.iniciador.detalle = null;
            RegistrarFactura_Load(sender, e);
            btn_agregar_a_factura.Enabled = true;
        }


        
    }
}
