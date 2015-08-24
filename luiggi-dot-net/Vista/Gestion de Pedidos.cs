using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entidades;
using Controlador;
using DAO;


namespace Vista
{
    public partial class Gestion_de_Pedidos : Form
    {
        private List<DetallePedido> tablaAModificar = null;
        private List<Producto > productosEliminados = null; // productos que se quitan del detalle para actualizar sus stocks disponibles
        
        private int b = 0;
        private GestorRegistrarPedido gestor = new GestorRegistrarPedido();
        private estados estadoFormulario;
        public Persona resultado;
        public Pedido pedidoModificar;
        

        public estados _estado
        {
            get { return estadoFormulario; }
            set { estadoFormulario = value; }
        }
        public Pedido _pedModificar
        {
            get { return pedidoModificar; }
            set { pedidoModificar = value; }
        }
        public Gestion_de_Pedidos()
        {
            InitializeComponent();
        }
        private void Gestion_de_Pedidos_Load(object sender, EventArgs e)
        {


            cargarCombo();
            cargarGrillaProductos();
            productosEliminados = new List<Producto>();
           
            if(estadoFormulario==estados.nuevo)
            {
                habilitarPantalla();
                gestor.nuevoProducto();
            }
            if (estadoFormulario == estados.modificar)
            {
                btn_verificar_empresa.Enabled = false;
                btn_verificar_persona.Enabled = false;
                btn_aplicar_filtro_empresa.Enabled = false;
                txt_apellido.Enabled=false;
                txt_nombre.Enabled=false;
                txt_razon_social.Enabled=false;
                txt_cuit.Enabled = false;
                
                dgv_detalle.Enabled = true;
                dgv_productos_finales.Enabled = true;
                txt_cantidad.Enabled = true;
                btn_agregar.Enabled = true;
                btn_quitar.Enabled = true;
                btn_guardar.Enabled = true;
                dtp_fecha_necesidad.Enabled = true;
                cargarModificacion();
            }
            
            
        }
        public void cargarModificacion()
        {
            gestor.pedidoModificar(pedidoModificar.idPedido);
            Pedido ped = gestor.buscarPedido();

            txt_apellido.Text = ped.cliente.Apellido.ToString();
            txt_nombre.Text = ped.cliente.Nombre.ToString();
            txt_razon_social.Text = ped.cliente.RazonSocial.ToString();
            txt_cuit.Text = ped.cliente.cuil.ToString();
            txt_nro_doc.Text = ped.cliente.NroDoc.ToString();
            txt_dir_entrega.Text = ped.dirEntraga;
            cmb_tipo_doc.SelectedValue = ped.cliente.TipoDoc.IDTipoDoc;
            dtp_fecha_necesidad.Value = ped.fechaNecesidad;
            dtp_fecha_pedido.Value = ped.fechaPedido;

            txt_monto_total.Text = ped.montoTotal.ToString();
            cargarGrillaDetalle(ped.idPedido);
           
            txt_celular.Text = ped.cliente.tefefonoCelular.ToString();


        }
        private void cargarGrillaDetalle(int idPed)
        {
            try
            {
                List<DetallePedido> detP = GestorConsultaPedido.buscarDetallePedido(idPed);

                dgv_detalle.Rows.Clear();
                foreach (DetallePedido detPed in detP)
                {
                    if (detPed.reservado == true)
                    {
                        dgv_detalle.Rows.Add(detPed.producto.CODProducto, detPed.producto.Nombre, detPed.precio, detPed.cantidad, detPed.producto.Unidad.Nombre, detPed.subTotal, detPed.producto.idProducto, "SI", "Reservar",detPed.Estado.idEstado);
                    }
                    else
                    {
                        dgv_detalle.Rows.Add(detPed.producto.CODProducto, detPed.producto.Nombre, detPed.precio, detPed.cantidad, detPed.producto.Unidad.Nombre, detPed.subTotal, detPed.producto.idProducto, "NO", "Reservar",detPed.Estado.idEstado);
                    }
                }
                tablaAModificar = detP;

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        public void cargarCombo()
        {

            List<TipoDocumento> tipDoc = gestor.buscarTipoDoc();

            tipDoc.Add(new TipoDocumento { IDTipoDoc = 0, Nombre = "SELECCIONE" });

            cmb_tipo_doc.DataSource = tipDoc;
            cmb_tipo_doc.DisplayMember = "nombre";
            cmb_tipo_doc.ValueMember = "IDTipoDoc";

            cmb_tipo_doc.SelectedValue = 0;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btn_verificar_persona_Click(object sender, EventArgs e)
        {
            if (!(txt_nro_doc.Text == ""))
            {
                int tipo = (int)cmb_tipo_doc.SelectedValue;
                int nro = (int)Convert.ToInt32(txt_nro_doc.Text);

                try
                {
                    resultado = gestor.buscarClientePersona(tipo,nro);

                    txt_nombre.Text = resultado.Nombre;
                    txt_apellido.Text = resultado.Apellido;
                    txt_cuit.Enabled = false;
                    txt_razon_social.Enabled = false;
                    dtp_fecha_necesidad.Enabled = true;
                    btn_verificar_empresa.Enabled = true;
                    btn_agregar.Enabled = true;
                    
                    txt_cantidad.Enabled = true;
                    dgv_productos_finales.Enabled = true;
                    dgv_detalle.Enabled = true;

                }
                catch (ApplicationException ex)
                {
                    if (MessageBox.Show("No se encuentra el cliente, ¿Decea crear uno?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Gestion_de_Clientes gestCli = new Gestion_de_Clientes();
                        gestCli._estado = estados.nuevo;
                        gestCli.ShowDialog();
                    }

                }
                
            }
            else
            {
                MessageBox.Show("Complete el campo\"Nro Documento\" antes de buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
        }
        public void habilitarPantalla()
        {
            txt_nro_doc.Enabled = true;
            txt_cuit.Enabled = true;
            txt_apellido.Enabled = true;
            txt_nombre.Enabled = true;
            txt_razon_social.Enabled = true;
            cmb_tipo_doc.Enabled = true;
            btn_verificar_persona.Enabled = false;
            btn_verificar_empresa.Enabled = false;
            btn_aplicar_filtro_empresa.Enabled = true;
            txt_nro_doc.Enabled = true;
            dtp_fecha_necesidad.Value = DateTime.Now.Date.AddDays(1);
        }
        private void btn_verificar_empresa_Click(object sender, EventArgs e)
        {
            if (!(txt_cuit.Text == ""))
            {
                int cui = (int)Convert.ToInt32(txt_cuit.Text);

                try
                {
                    resultado = gestor.buscarClienteEmpresa(cui);

                    
                    txt_nombre.Enabled = false;
                    txt_apellido.Enabled = false;
                    txt_cuit.Enabled = false;
                    txt_nro_doc.Enabled = false;
                    txt_razon_social.Enabled = false;
                    txt_razon_social.Text = resultado.RazonSocial;
                    dtp_fecha_necesidad.Enabled = true;
                    cmb_tipo_doc.Enabled = false;
                    btn_verificar_persona.Enabled = false;
                    btn_agregar.Enabled = true;
                   
                    txt_cantidad.Enabled = true;
                    dgv_productos_finales.Enabled = true;
                    dgv_detalle.Enabled = true;

                }
                catch (ApplicationException ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    MessageBox.Show("No se encuentra la empresa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
               
            }
            else
            {
                MessageBox.Show("Complete el campo\"CUIT/CUIL\" antes de buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtp_fecha_necesidad.Enabled = true;
        }
        public void cargarGrillaProductos()
        {
            try
            {
                List<Producto> productos = gestor.buscarProductosFinales();

                dgv_productos_finales.Rows.Clear();
                foreach (Producto prod in productos)
                {
                    dgv_productos_finales.Rows.Add(prod.CODProducto, prod.Nombre, prod.Descripcion, prod.precio, prod.Unidad.Nombre, prod.idProducto, prod.StockDisponible );
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("Complete el campo cantidad ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
            else
            {
                Boolean result = false;
                int comparar = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["idProducto"].Value;
 
                for (int c = 0; c < dgv_detalle.RowCount; c++)
                {
                    if (comparar == (int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value)
                    {
                        dgv_productos_finales.CurrentRow.Cells["stockDisp"].Value = (double)dgv_productos_finales.CurrentRow.Cells["stockDisp"].Value + (double)dgv_detalle.Rows[c].Cells["cantidad"].Value;
                        result = true;
                        break;
                    }
                    

                }

                if (result == false)
                {
                    int idPro = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["idProducto"].Value;
                    int cod = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["cod"].Value;
                    string nom = (string)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["nombreproducto"].Value;
                    string uni = (string)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["unidad"].Value;
                    double can = Convert.ToDouble(txt_cantidad.Text);
                    double pre = (double)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["precio"].Value;
                    double subTot = can * pre;

                    dgv_detalle.Rows.Add(cod, nom, pre, can, uni, subTot, idPro, "NO","Reservar");

                    //dgv_productos_finales.Rows.Remove(dgv_productos_finales.CurrentRow);

                    txt_cantidad.Text = "";
                    calcularMontoTotal();
                    btn_quitar.Enabled = true;
                   
                }
                else 
                {
                    if (MessageBox.Show("Ya se cargó el producto, ¿Desea Modificar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)==DialogResult.Yes)
                    {
                        int index = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["idProducto"].Value;

                        for (int c = 0; c < dgv_detalle.RowCount; c++)
                        {
                            if ((int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value == index)
                            {
                                int can = Convert.ToInt32(txt_cantidad.Text);
                                dgv_detalle.Rows[c].Cells["cantidad"].Value = can;
                                double pre = (double)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["precio"].Value;
                                dgv_detalle.Rows[c].Cells["reservado"].Value =  "NO";
                                dgv_detalle.Rows[c].Cells["sub"].Value = can*pre;
                                calcularMontoTotal();
                                
                            }
                        }
                        
                        txt_cantidad.Text = "";
                    } 
                    
                }
            }
        }
        public void calcularMontoTotal()
        {
            double montoTotal = 0;
            for(int c=0; c < dgv_detalle.RowCount  ; c++)
            {
                montoTotal = montoTotal + (double)dgv_detalle.Rows[c].Cells["sub"].Value; 

            }
            txt_monto_total.Text = montoTotal.ToString();
            if (montoTotal > 0 )
            {
                btn_guardar.Enabled = true;

            }
            else
            {
                btn_guardar.Enabled = false;
            }
 
        }
        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validarDouble(e,txt_cantidad.Text+e.KeyChar)==false)
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private Boolean validarDouble(KeyPressEventArgs e, string texto)
        {
            String datos = "0123456789,";
            Boolean result = false;
            double numero;

            try
            {
                if (datos.IndexOf(e.KeyChar) != -1)
                {
                    if (double.TryParse(texto, out numero))
                    {
                        result = true;
                    }
                }
                if (e.KeyChar == '\b')
                {
                    result = true;
                }
            }
            catch (FormatException ex)
            {

                result = false;
            }


            return result;
        }
        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgv_detalle.Rows.Count > 0)
            {
                if (dgv_detalle.CurrentRow.Cells["reservado"].Value.ToString() == "SI")
                {
                    Producto producto = new Producto();

                    producto.idProducto = (int)dgv_detalle.Rows[dgv_detalle.CurrentRow.Index].Cells["idProductodetalle"].Value;
                    producto.cantidadProductos = Convert.ToDouble(dgv_detalle.Rows[dgv_detalle.CurrentRow.Index].Cells["cantidad"].Value);


                    productosEliminados.Add(producto); 
                }
               
                
                dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow);
               
              
                calcularMontoTotal();
                cargarGrillaProductos();
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int idPedido=0;
            
            if (dtp_fecha_necesidad.Value.Date >= DateTime.Now.Date)
            {
                if (dgv_detalle.Rows.Count >= 1)
                {
                    List<DetallePedido> detalle = new List<DetallePedido>();


                    for (int c = 0; c < dgv_detalle.RowCount; c++)
                    {
                        DetallePedido de = new DetallePedido();
                        Producto p = new Producto();
                        Estado est = new Estado();

                        p.idProducto = (int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value;
                        p.precio = (double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value;
                        
                        de.cantidad = Convert.ToDouble(dgv_detalle.Rows[c].Cells["cantidad"].Value);
                        de.precio = (double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value;
                        if (dgv_detalle.Rows[c].Cells["reservado"].Value.ToString() == "NO")
                        {
                            de.reservado = false;
                            de.cantidadReservada = 0;
                            est.idEstado = 26;
                            if (estadoFormulario == estados.modificar && dgv_detalle.Rows[c].Cells["idestado"].Value!=null)
                            {
                                est.idEstado = (int)dgv_detalle.Rows[c].Cells["idestado"].Value;
                            }
                            de.Estado = est;

                        }
                        else {
                            de.reservado = true;
                            de.cantidadReservada = de.cantidad;
                            est.idEstado = 25;
                            de.Estado = est ;
                        }
                        
                        de.producto = p;

                        detalle.Add(de);
                    }
                    if (estadoFormulario == estados.nuevo)
                    {
                        gestor.clienteSeleccionado(resultado);
                        gestor.tomarProductosSeleccionados(detalle);
                        gestor.fechaDeNecesidadTomada(dtp_fecha_necesidad.Value.Date);
                        gestor.dirEntregaTomada(txt_dir_entrega.Text);

                        if(!estanTodosReservados())
                        {
                            gestor.estado(1);
                        }
                        else{
                            gestor.estado(5);
                        }


                        try
                        {
                            List<Producto> productosConPocaMP = new List<Producto>();
                            idPedido = gestor.confirmacionTomada(productosConPocaMP);
                            ////////////// MOSTRAR LOS PRODUCTOS CON BAJO STOCK
                            if (productosConPocaMP.Count > 0)
                            {
                                string mensaje = "";
                                List<Producto> prodConPocoStock = new List<Producto>();
                                Boolean MPRepetida = false;
                                foreach (Producto Prod in productosConPocaMP)
                                {
                                    foreach (Producto P in prodConPocoStock)
                                    {
                                        if (P.idProducto == Prod.idProducto)
                                        {
                                            MPRepetida = true;
                                            break;
                                        }
                                    }
                                    if (MPRepetida == false)
                                    {
                                        mensaje += Environment.NewLine + Prod.Nombre.ToString();
                                        prodConPocoStock.Add(Prod);
                                    }

                                }
                                MessageBox.Show("Los siguientes productos estan con bajo stock: " + mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            /////////////////////////////////////////////////////////////
                            MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            limpiarCampos();
                        }
                        catch (ApplicationException ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        if (estadoFormulario == estados.modificar)
                        {
                            //foreach (Producto  pro in productosEliminados )
                            //{

                            //    ProductoDAO.UpdateStockReservadoYDisponibleEliminado(pro.idProducto,pro.cantidadProductos );
                               
                            //}
                            
                            

                            gestor.tomarProductosSeleccionados(detalle);
                            gestor.fechaDeNecesidadTomada(dtp_fecha_necesidad.Value.Date);
                            gestor.dirEntregaTomada(txt_dir_entrega.Text);

                            if (!estanTodosReservados())
                            {
                                gestor.estado(1);
                            }
                            else
                            {
                                gestor.estado(5);
                            }

                            try
                            {
                                
                                List<Producto> productosConPocaMP = new List<Producto>();
                                gestor.modificacionConfirmada(tablaAModificar, productosConPocaMP);
                                ////////////// MOSTRAR LOS PRODUCTOS CON BAJO STOCK
                                if (productosConPocaMP.Count > 0)
                                {
                                    string mensaje = "";
                                    List<Producto> prodConPocoStock = new List<Producto>();
                                    Boolean MPRepetida = false;
                                    foreach (Producto Prod in productosConPocaMP)
                                    {
                                        foreach (Producto P in prodConPocoStock)
                                        {
                                            if (P.idProducto == Prod.idProducto)
                                            {
                                                MPRepetida = true;
                                                break;
                                            }
                                        }
                                        if (MPRepetida == false)
                                        {
                                            mensaje += Environment.NewLine + Prod.Nombre.ToString();
                                            prodConPocoStock.Add(Prod);
                                        }

                                    }
                                    MessageBox.Show("Los siguientes productos estan con bajo stock: " + mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                /////////////////////////////////////////////////////////////
                                MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                limpiarCampos();
                            }
                            catch (ApplicationException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }

                        }
                    }
                    cargarGrillaProductos();

                }
                else
                {
                    MessageBox.Show("Agrege productos al pedido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                }
            }
            else
            {
                MessageBox.Show("La fecha de necesidad no puede ser anterior a la actual", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }

            
        }
        public Boolean estanTodosReservados()
        {
            Boolean result = true;

            for (int i = 0; i < dgv_detalle.Rows.Count; i++)
            {
                if (dgv_detalle.Rows[i].Cells["reservado"].Value.ToString() == "NO")
                {
                    result = false;
                }
            }


            return result;

        }
        public void limpiarCampos()
        {
            dtp_fecha_pedido.Value = DateTime.Now.Date;
            dtp_fecha_necesidad.Value = dtp_fecha_pedido.Value.AddDays(1);
            dgv_detalle.Rows.Clear();
            txt_apellido.Text = "";
            txt_cantidad.Text = "";
            txt_cuit.Text = "";
            txt_monto_total.Text = "";
            txt_nombre.Text = "";
            txt_nro_doc.Text = "";
            txt_razon_social.Text = "";
            txt_dir_entrega.Text = "";
            cmb_tipo_doc.SelectedValue = 0;
            resultado = null;
            estadoFormulario = estados.nuevo;
            txt_celular.Text = "";
            habilitarPantalla();
            txt_nro_doc.Focus();
            productosEliminados.Clear();
        }
        private void txt_nro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
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
        //private void dgv_detalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txt_cantidad.Text = dgv_detalle.Rows[dgv_detalle.CurrentRow.Index].Cells["cantidad"].Value.ToString();

        //    int index = (int)dgv_detalle.Rows[dgv_detalle.CurrentRow.Index].Cells["idProductodetalle"].Value;

        //    for (int c = 0; c < dgv_productos_finales.RowCount; c++)
        //    {
        //        if ((int)dgv_productos_finales.Rows[c].Cells["idProducto"].Value==index)
        //        {
        //            dgv_productos_finales.Rows[c].Cells["cod"].Selected = true; 
        //        }
        //    }

        //}
        private void dgv_productos_finales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cantidad.Text = "";
            lbl_unidad.Text = dgv_productos_finales.CurrentRow.Cells["unidad"].Value.ToString();
        }
        private void btn_aplicar_filtro_empresa_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();

            if (txt_apellido.Text != "")
            {
                per.Apellido = txt_apellido.Text;
            }
            if (txt_nombre.Text != "")
            {
                per.Nombre = txt_nombre.Text;
            }
            if (txt_nro_doc.Text != "")
            {
                per.NroDoc = Convert.ToInt64(txt_nro_doc.Text);
            }
            per.TipoDoc = new TipoDocumento() { IDTipoDoc = (int)cmb_tipo_doc.SelectedValue };
            if (txt_razon_social.Text != "")
            {
                per.RazonSocial = txt_razon_social.Text;
            }

            if (txt_cuit.Text != "  -        -")
            {
                per.cuil = txt_cuit.Text;
            }

            
            List<Persona> resul = null;
            try
            {

                resul = GestorDeFiltros.filtrarCliente(per);
              
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


            if (resul.Count == 1)
            {
                Persona res = resul.ElementAt<Persona>(0);

                txt_apellido.Text = res.Apellido;
                txt_nombre.Text = res.Nombre;
                txt_nro_doc.Text = res.NroDoc.ToString();
                txt_razon_social.Text = res.RazonSocial;
                cmb_tipo_doc.SelectedValue = res.TipoDoc.IDTipoDoc;
                txt_celular.Text = res.tefefonoCelular.ToString();
            }
            else
            {
                ResultadoDeFiltro resFiltro = new ResultadoDeFiltro();
                resFiltro._resultado = resul;
               
                resFiltro.ShowDialog();

                Persona res = Vista.iniciador.per;
                resultado = res;
                if (res != null)
                {
                    txt_apellido.Text = res.Apellido;
                    txt_nombre.Text = res.Nombre;
                    txt_nro_doc.Text = res.NroDoc.ToString();
                    txt_razon_social.Text = res.RazonSocial;
                    cmb_tipo_doc.SelectedValue = res.TipoDoc.IDTipoDoc;
                    txt_celular.Text = res.tefefonoCelular.ToString();
                }
            }
            dtp_fecha_necesidad.Enabled = true;
            btn_agregar.Enabled = true;
            txt_cantidad.Enabled = true;
            dgv_productos_finales.Enabled = true;
            dgv_detalle.Enabled = true;
        }
        public void btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_aplicar_filtro_empresa.Enabled = true;
            txt_nombre.Enabled = true;
            txt_apellido.Enabled = true;
            txt_razon_social.Enabled = true;
            txt_cuit.Enabled = true;
            txt_dir_entrega.Enabled = true;
            dgv_productos_finales.Enabled = false;
            txt_cantidad.Enabled = true;
            btn_agregar.Enabled = true;
            btn_quitar.Enabled = true;
            btn_guardar.Enabled = true;
            dtp_fecha_necesidad.Enabled = true;
            
            limpiarCampos();
        }
        private void dgv_detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgv_detalle.CurrentCell is DataGridViewButtonCell )
            {
                float cantidadNecesaria = 0;
                int idProducto = 0;
                float cantidadDisponible = 0;

                cantidadNecesaria = float.Parse(dgv_detalle.CurrentRow.Cells[3].Value.ToString());
                idProducto = (int)dgv_detalle.CurrentRow.Cells[6].Value;
                cantidadDisponible = ProductoDAO.getStockDisponible(idProducto);

                if (dgv_detalle.CurrentRow.Cells["reservado"].Value.ToString() == "NO")
                {
                    if (ProductoDAO.verificarProductoPlanificado(dtp_fecha_necesidad.Value.Date, idProducto) == false)
                    {
                        if (cantidadNecesaria <= cantidadDisponible)
                        {
                            dgv_detalle.CurrentRow.Cells["reservado"].Value = "SI";
                            dgv_detalle.CurrentRow.Cells["idestado"].Value = 25;

                            ///////// MODIFICO LA GRILLA CON LA DIFERENCIA DEL STOCK DISPONIBLE - CANTIDAD RESERVADA
                            for (int a = 0; a < dgv_productos_finales.RowCount; a++)
                            {
                                if (dgv_productos_finales.Rows[a].Cells["idProducto"].Value.ToString() == dgv_detalle.CurrentRow.Cells["idProductoDetalle"].Value.ToString())
                                {
                                    dgv_productos_finales.Rows[a].Cells["stockDisp"].Value = float.Parse(dgv_productos_finales.Rows[a].Cells["stockDisp"].Value.ToString()) - float.Parse(dgv_detalle.CurrentRow.Cells["cantidad"].Value.ToString());
                                }
                            }
                            /////////////////////////////////////////////////////////////////////////////

                            int resul = -1;
                            for (int c = 1; c < dgv_detalle.RowCount - 1; c++)
                            {
                                if (productosEliminados.Count>=1 && productosEliminados.ElementAt(c).idProducto.Equals(dgv_detalle.CurrentRow.Cells["idProductodetalle"].Value))
                                {
                                    resul = c;
                                    return;
                                }
                            }
                            if (resul != -1)
                            {
                                productosEliminados.RemoveAt(resul);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede reservar esa cantidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se puede reservar, ya se planifico su producción", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                }

                else
                {
                    ///////// MODIFICO LA GRILLA CON LA SUMA DEL STOCK DISPONIBLE + CANTIDAD QUE DEJO DE RESERVAR

                    if (dgv_detalle.CurrentRow.Cells["reservado"].Value.ToString() == "SI")
                    {
                        for (int a = 0; a < dgv_productos_finales.RowCount; a++)
                        {
                            if (dgv_productos_finales.Rows[a].Cells["idProducto"].Value.ToString() == dgv_detalle.CurrentRow.Cells["idProductoDetalle"].Value.ToString())
                            {
                                dgv_productos_finales.Rows[a].Cells["stockDisp"].Value = float.Parse(dgv_productos_finales.Rows[a].Cells["stockDisp"].Value.ToString()) + float.Parse(dgv_detalle.CurrentRow.Cells["cantidad"].Value.ToString());
                            }
                        }
                    }
                    /////////////////////////////////////////////////////////////////////////////
                    dgv_detalle.CurrentRow.Cells["reservado"].Value = "NO";
                    dgv_detalle.CurrentRow.Cells["idestado"].Value = 26;

                    
                    Producto producto = new Producto();
                    producto.idProducto = (int)dgv_detalle.Rows[dgv_detalle.CurrentRow.Index].Cells["idProductodetalle"].Value;
                    producto.cantidadProductos = Convert.ToDouble(dgv_detalle.Rows[dgv_detalle.CurrentRow.Index].Cells["cantidad"].Value);

                    int resul = -1;
                    for (int c = 1; c < dgv_detalle.RowCount - 1; c++)
                    {
                        if (productosEliminados.Count >= 1 && productosEliminados.ElementAt(c).idProducto.Equals(dgv_detalle.CurrentRow.Cells["idProductodetalle"].Value))
                        {
                            resul = c;
                            return;
                        }
                    }
                    if (resul != -1)
                    {
                        productosEliminados.Add(producto);
                    }

                }
            }
                
                
        }

        private void dtp_fecha_necesidad_ValueChanged(object sender, EventArgs e)
        {
            if (estadoFormulario == estados.nuevo)
            {
                if (dtp_fecha_necesidad.Value.Date < dtp_fecha_pedido.Value.Date)
                {
                    dtp_fecha_necesidad.Value = dtp_fecha_pedido.Value.Date.AddDays(1);
                }
                if (dtp_fecha_necesidad.Value.Date == dtp_fecha_pedido.Value.Date)
                {
                    MessageBox.Show("Los Pedidos se deben realizar con un dia de anticipación", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    dtp_fecha_necesidad.Value = dtp_fecha_pedido.Value.Date.AddDays(1);
                }
            }
        }

      

        
       
    }
}
