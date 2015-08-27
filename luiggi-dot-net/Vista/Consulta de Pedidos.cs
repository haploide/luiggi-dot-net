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
    public partial class Consulta_de_Pedidos : Form
    {
        public GestorConsultaPedido gestor ;
        private static Consulta_de_Pedidos InstanciaFormulario = null;


        public Consulta_de_Pedidos()
        {
            InitializeComponent();
        }
        public static Consulta_de_Pedidos Instance()
        {
            if (InstanciaFormulario == null)
            {
                InstanciaFormulario = new Consulta_de_Pedidos();
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

        private void Consulta_de_Pedidos_Load(object sender, EventArgs e)
        {
            //dtp_desde.Format = DateTimePickerFormat.Custom;
            //dtp_desde.CustomFormat = " ";

            gestor = new GestorConsultaPedido();
            cargarGrilla();
            dtp_desde.Value = Convert.ToDateTime("01/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
            dtp_hasta.Value = Convert.ToDateTime("28/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
            cargarCombos();
           
        }
        public void cargarCombos()
        {
            try
            {

                List<Estado > est = gestor.buscarEstado ();
                List<TipoDocumento > tipoD = gestor.buscarTipoDoc ();
                est.Add(new Estado { idEstado  = 0, Nombre = "TODOS" });
                tipoD.Add(new TipoDocumento { IDTipoDoc  = 0, Nombre = "TODOS" });
                cmb_estado_pedido.DataSource = est ;
                cmb_estado_pedido.DisplayMember = "Nombre";
                cmb_estado_pedido.ValueMember = "idEstado";
                cmb_estado_pedido.SelectedValue = 0;

                cmb_tipo_doc.DataSource = tipoD ;
                cmb_tipo_doc.DisplayMember = "Nombre";
                cmb_tipo_doc.ValueMember = "IDTipoDoc";
                cmb_tipo_doc.SelectedValue = 0;



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
                List<Pedido> perdidos = GestorConsultaPedido.buscarPedidos();
                

                dgv_pedidos.Rows.Clear();
                foreach (Pedido ped in perdidos)
                {
                    switch (ped.estado.idEstado)
                    {
                        case 1:
                            opcion = "Sin Opción";
                            break;
                        case 2:
                            opcion = "Registrar Fin Preparación";
                            break;
                        case 5:
                            opcion = "Registrar Factura";
                            break;
                        case 6:
                            opcion = "Registrar Entrega";
                            break;
                        default:
                            opcion = "Sin Opción";
                            break;
                    }

                    int fila = dgv_pedidos.Rows.Add(ped.idPedido, ped.nroPedido, ped.fechaPedido.ToShortDateString(), ped.estado.Nombre, ped.cliente.RazonSocial, ped.cliente.Nombre, ped.cliente.Apellido, ped.fechaNecesidad.ToShortDateString(), ped.montoTotal, ped.dirEntraga, opcion,ped.estado.idEstado);

                    dgv_pedidos.Rows[fila].DefaultCellStyle.BackColor = Color.Khaki;
                    
                    
                    if (ped.estado.idEstado == 7)
                    {
                        dgv_pedidos.Rows[fila].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                    if (ped.estado.idEstado == 9 || ped.estado.idEstado == 10)
                    {
                        dgv_pedidos.Rows[fila].DefaultCellStyle.BackColor = Color.IndianRed;
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
        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            Gestion_de_Pedidos gestPedido = new Gestion_de_Pedidos();
            gestPedido._estado = estados.nuevo;
            gestPedido.ShowDialog();
            cargarGrilla();
        }
        private void dgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idPedido = (int)dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["idPedido"].Value;
                cargarGrillaDetalle(idPedido);

                dgv_detalle_pedido.ClearSelection();
            }
            catch (Exception ex)
            {
                
                
            }
        }
        private void cargarGrillaDetalle(int ped)
        {
            try
            {
                List<DetallePedido> detP = GestorConsultaPedido.buscarDetallePedido(ped);
                dgv_detalle_pedido.Rows.Clear();
                foreach (DetallePedido detPed in detP)
                {
                    int fila=dgv_detalle_pedido.Rows.Add(detPed.producto.CODProducto, detPed.producto.Nombre, detPed.producto.Unidad.Nombre, detPed.cantidad,detPed.precio,detPed.subTotal,detPed.producto.idProducto,detPed.Estado.idEstado);

                    if (detPed.Estado.idEstado == 25 || detPed.Estado.idEstado == 4)
                    {
                        dgv_detalle_pedido.Rows[fila].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                    if (detPed.Estado.idEstado == 26)
                    {
                        dgv_detalle_pedido.Rows[fila].DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void dgv_pedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["Estado"].Value.ToString() == "Pendiente de prepacacion" || sonTodosReservados())
                {
                    Pedido ped = new Pedido();

                    ped.idPedido = (int)dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["idPedido"].Value;


                    Gestion_de_Pedidos gestion = new Gestion_de_Pedidos();

                    gestion._estado = estados.modificar;
                    gestion._pedModificar = ped;
                    gestion.ShowDialog();

                    cargarGrilla();
                }
            } 
            catch (Exception ex)
            {
                
                
            }
            
        }
        private void btn_aplicar_filtro_necesidad_Click(object sender, EventArgs e)
        {
            DateTime desde= dtp_desde.Value;
            DateTime hasta=dtp_hasta.Value;
            for (int c = 0; c <= dgv_pedidos.RowCount; c++)
            {
                DateTime necesidad=Convert.ToDateTime(dgv_pedidos.Rows[c].Cells["fecNec"].Value);

                if(!(necesidad.Date>desde.Date && necesidad.Date<hasta.Date))
                {
                    dgv_pedidos.Rows.Remove(dgv_pedidos.Rows[c]);
                }
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

            DateTime  fdesde = dtp_desde.Value;
            DateTime fhasta = dtp_hasta.Value;

            String opcion = "Sin Opción";

            if (!string.IsNullOrEmpty(txt_monto_desde.Text))
               mDesde = double.Parse(txt_monto_desde.Text);

            if (!string.IsNullOrEmpty(txt_monto_hasta.Text))
                mHasta = double.Parse(txt_monto_hasta.Text);

             if (!string.IsNullOrEmpty(txt_cuit.Text))
               cuit  = int.Parse(txt_cuit.Text);
             if (!string.IsNullOrEmpty(txt_nro_doc.Text))
                 nroDoc  = int.Parse(txt_nro_doc.Text);
            try
            {
                List<Pedido> perdidos = GestorConsultaPedido.buscarPedidosFiltrados((int)cmb_estado_pedido.SelectedValue, (int)cmb_tipo_doc.SelectedValue, nroDoc, mDesde, mHasta, txt_nombre.Text, txt_apellido.Text, txt_razon_social.Text , cuit, fdesde , fhasta );

                dgv_pedidos.Rows.Clear();
                foreach (Pedido ped in perdidos)
                {

                    switch (ped.estado.idEstado)
                    {
                        case 2:
                            opcion = "Registrar Fin Preparación";
                            break;
                        case 5:
                            opcion = "Registrar Factura";
                            break;
                        case 6:
                            opcion = "Registrar Entrega";
                            break;
                        default:
                            opcion = "Sin Opción";
                            break;

                    }
                    int fila =dgv_pedidos.Rows.Add(ped.idPedido, ped.nroPedido, ped.fechaPedido.ToShortDateString(), ped.estado.Nombre, ped.cliente.RazonSocial, ped.cliente.Nombre, ped.cliente.Apellido, ped.fechaNecesidad.ToShortDateString(), ped.montoTotal, ped.dirEntraga, opcion, ped.estado.idEstado);

                    dgv_pedidos.Rows[fila].DefaultCellStyle.BackColor = Color.Khaki;
                    
                    if (ped.estado.idEstado == 7)
                    {
                        dgv_pedidos.Rows[fila].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                    if (ped.estado.idEstado == 9 || ped.estado.idEstado == 10)
                    {
                        dgv_pedidos.Rows[fila].DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                }

            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
 
        }
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private void txt_razon_social_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private void txt_nro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private void txt_cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            foreach (Control cont in gp_filtros.Controls)
            {
                if(cont is TextBox)
                {
                    cont.Text = "";
                }
                if (cont is ComboBox)
                {
                    ((ComboBox)cont).SelectedIndex = 0;
                }
            }
            Consulta_de_Pedidos_Load(sender,e);
            
        }
        private void dgv_pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_pedidos.CurrentCell is DataGridViewButtonCell)
            {
                int idPedido = (int)dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["idPedido"].Value;
                int estadoDesde = (int)dgv_pedidos.Rows[dgv_pedidos.CurrentRow.Index].Cells["idestado"].Value;
                int estadoHasta = estadoDesde;

                switch (estadoDesde)
                {
                    case 2:
                        estadoHasta = 5;
                        if (tieneProductosFinalizados())
                        {
                            try
                            {
                                PedidoDAO.UpdateEstados(idPedido, estadoHasta);
                                MessageBox.Show("Fin Preparación ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                cargarGrilla();
                            }
                            catch (ApplicationException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Faltan Productos Por Preparar ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                        break;
                    case 5:
                        estadoHasta = 6;
                        
                        //Abrir Interface de Factura 

                        int idPed = (int)dgv_pedidos.CurrentRow.Cells["idPedido"].Value;
                        RegistrarFactura factura = new RegistrarFactura();
                        factura._idPedido = idPed;
                        factura.ShowDialog();
                        //Si se registro la factura hacer
                        if (factura._estado==estados.guardado)
                        {
                            try
                            {
                                //PedidoDAO.UpdateEstados(idPedido, estadoHasta);
                                MessageBox.Show("Factura Registrada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                cargarGrilla();
                            }
                            catch (ApplicationException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }


                            Emitir_Factura fact = new Emitir_Factura();

                            fact.ShowDialog();
                        }


                        break;
                    case 6:
                        estadoHasta = 7;


                        if (pagaronLaFactura(idPedido))
                        {
                            try
                            {

                                for (int i = 0; i < dgv_detalle_pedido.Rows.Count; i++)
                                {
                                    DetallePedido det = new DetallePedido();
                                    det.producto = new Producto() { idProducto = (int)dgv_detalle_pedido.Rows[i].Cells["idProd"].Value };
                                    det.cantidad = (double)dgv_detalle_pedido.Rows[i].Cells["cant"].Value;


                                    ProductoDAO.UpdateStockReservadoYActualdePedidoEntregado(det, idPedido, estadoHasta);
                                }

                                MessageBox.Show("Registro de Entrega Completado ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                cargarGrilla();
                            }
                            catch (ApplicationException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Falta el Pago de la Factura ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }


                        break;
                    

                } 
            }



        }
        private Boolean tieneProductosFinalizados()
        {
            Boolean result = true;
            for (int i = 0; i < dgv_detalle_pedido.Rows.Count; i++)
            {
                if (dgv_detalle_pedido.Rows[i].DefaultCellStyle.BackColor != Color.MediumSeaGreen)
                {
                    result = false;
                }
            }

            return result;
        }
        private Boolean sonTodosReservados()
        {
            Boolean result = true;
            if ((int)dgv_pedidos.CurrentRow.Cells["idestado"].Value == 5)
            {
                for (int i = 0; i < dgv_detalle_pedido.Rows.Count; i++)
                {
                    if ((int)dgv_detalle_pedido.Rows[i].Cells["idEstadoDetalle"].Value != 25)
                    {
                        result = false;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        private Boolean pagaronLaFactura(int idPedido)
        {
            Boolean result = true;

            if (!FacturaDAO.GetFacturasPagadas(idPedido))
            {
                result = false;
            }

            return result;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            int idEstado=(int)dgv_pedidos.CurrentRow.Cells["idestado"].Value;
            if (idEstado == 5 || idEstado == 1 || idEstado == 2)
            {
                MessageBox.Show("cancelada");
            }
        }

        private void Consulta_de_Pedidos_FormClosed(object sender, FormClosedEventArgs e)
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
