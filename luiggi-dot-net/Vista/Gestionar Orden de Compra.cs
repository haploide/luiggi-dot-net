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
    public partial class Gestionar_Orden_de_Compra : Form
    {
        private estados estadoFormulario;
        public estados _estado
        {
            get { return estadoFormulario; }
            set { estadoFormulario = value; }
        }
        public Gestionar_Orden_de_Compra()
        {
            InitializeComponent();
        }

        private void Gestionar_Orden_de_Compra_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }
        public void cargarCombos()
        {
            List<Persona> prov = PersonaDAO.GetAllProveedores ();
            prov.Add(new Persona { idPersona  = 0, RazonSocial  = "SELECCIONE" });

            cmb_proveedores.DataSource = prov;
            cmb_proveedores.DisplayMember = "RazonSocial";
            cmb_proveedores.ValueMember = "idPersona";
            cmb_proveedores.SelectedValue = 0;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmb_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_proveedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgv_productos.Rows.Clear();
            cargarGrillaProdXProveedor();
            if (dgv_productos.RowCount != 0)
            {
                dgv_productos.ClearSelection();
            }
            dgv_detalle.Rows.Clear();
        }
        private void cargarGrillaProdXProveedor()
        {
            if ((int)cmb_proveedores.SelectedValue != 0)
            {
                dgv_productos.Enabled = true;
                dgv_detalle.Enabled = true;
                btn_agregar.Enabled = true ;
                txt_cantidad.Enabled = true;
                int idProveedor = Convert.ToInt32(cmb_proveedores.SelectedValue);
                List<ProductoXProveedor> prod = new List<ProductoXProveedor>();

                try
                {
                    prod = ProductoXProveedorDAO.GetByIdProd(idProveedor);
                    double prodFaltante = 0;
                    foreach (ProductoXProveedor p in prod)
                    {
                        if (p.producto.Unidad.Nombre == "g")
                        {
                            p.producto.Unidad.Nombre= "Kilo";
                            p.producto.StockDisponible = double.Parse(p.producto.StockDisponible.ToString()) / 1000;
                            p.producto.StockActual = double.Parse(p.producto.StockActual.ToString()) / 1000;
                            p.producto.StockReservado = double.Parse(p.producto.StockReservado.ToString()) / 1000;
                            p.producto.StockRiesgo = double.Parse(p.producto.StockRiesgo.ToString()) / 1000;
                        }
                        if (p.producto.StockDisponible < 0)
                        {
                            prodFaltante = p.producto.StockDisponible * -1;
                            p.producto.StockDisponible = 0;
                        }
                        else
                        {
                            prodFaltante = 0;
                        }

                        int fila=dgv_productos.Rows.Add(p.producto.idProducto, p.producto.Nombre, p.producto.Descripcion, p.precioProveedor, p.producto.Unidad.Nombre, p.producto.StockRiesgo, p.producto.StockActual, p.producto.StockDisponible, p.producto.StockReservado, p.producto.idProducto,prodFaltante);
                        
                        if(p.producto.StockDisponible<=(p.producto.StockRiesgo)*1.25)
                        {
                            dgv_productos.Rows[fila].DefaultCellStyle.BackColor = Color.LightSalmon;
                        }
                        txt_celular.Text = p.proveedor.telefono;
                        txt_contacto.Text = p.proveedor.Apellido + " " + p.proveedor.Nombre;
                        txt_mail.Text = p.proveedor.mail;
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }


            }
            else 
            {
                limpiar();
            }
 
        }
        private void limpiar()
        {
            dgv_productos.Enabled = false;
            btn_agregar.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_celular.Text = "";
            txt_contacto.Text = "";
            txt_mail.Text = "";
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validarDouble(e, txt_cantidad.Text + e.KeyChar) == false)
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cantidad.Text == "")
                {
                    MessageBox.Show("Complete el campo cantidad ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    Boolean result = false;
                    int comparar = (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["idProducto"].Value;

                    for (int c = 0; c < dgv_detalle.RowCount; c++)
                    {
                        if (comparar == (int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value)
                        {
                            dgv_productos.CurrentRow.Cells["stockDisponible"].Value = Convert.ToDouble(dgv_productos.CurrentRow.Cells["stockDisponible"].Value) + Convert.ToDouble(dgv_detalle.Rows[c].Cells["cantidad"].Value);
                            result = true;
                            break;
                        }


                    }

                    if (result == false)
                    {
                        int idPro = (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["idProducto"].Value;
                        int cod = (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["cod"].Value;
                        string nom = (string)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["nombreproducto"].Value;
                        string uni = (string)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["unidad"].Value;
                        double can = Convert.ToDouble(txt_cantidad.Text);
                        double pre = (double)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["precio"].Value;
                        double subTot = can * pre;
                        if (uni.Equals("g"))
                        {
                            subTot = can * (pre / 1000);
                        }




                        dgv_detalle.Rows.Add(cod, nom, pre, can, uni, subTot, idPro);
                        //dgv_productos_finales.Rows.Remove(dgv_productos_finales.CurrentRow);

                        txt_cantidad.Text = "";
                        calcularMontoTotal();
                        btn_quitar.Enabled = true;

                    }
                    else
                    {
                        if (MessageBox.Show("Ya se cargó el producto, ¿Desea Modificar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            int index = (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["idProducto"].Value;

                            for (int c = 0; c < dgv_detalle.RowCount; c++)
                            {
                                if ((int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value == index)
                                {
                                    int can = Convert.ToInt32(txt_cantidad.Text);
                                    dgv_detalle.Rows[c].Cells["cantidad"].Value = can;
                                    double pre = (double)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["precio"].Value;

                                    dgv_detalle.Rows[c].Cells["sub"].Value = can * pre;
                                    calcularMontoTotal();

                                }
                            }

                            txt_cantidad.Text = "";
                        }

                    }
                }
                if (dgv_productos.RowCount != 0)
                    dgv_productos.ClearSelection();
                if (dgv_detalle.RowCount != 0)
                    dgv_detalle.ClearSelection();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al agregar el Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        public void calcularMontoTotal()
        {
            double montoTotal = 0;
            for (int c = 0; c < dgv_detalle.RowCount; c++)
            {
                montoTotal = montoTotal + (double)dgv_detalle.Rows[c].Cells["sub"].Value;

            }
            txt_monto_total.Text = montoTotal.ToString();
            if (montoTotal > 0)
            {
                btn_guardar.Enabled = true;

            }
            else
            {
                btn_guardar.Enabled = false;
            }

        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgv_detalle.Rows.Count > 0)
            {
                if (dgv_detalle.SelectedRows.Count > 0)
                {

                    Producto producto = new Producto();

                    producto.idProducto = (int)dgv_detalle.Rows[dgv_detalle.CurrentRow.Index].Cells["idProductodetalle"].Value;
                    producto.cantidadProductos = Convert.ToDouble(dgv_detalle.Rows[dgv_detalle.CurrentRow.Index].Cells["cantidad"].Value);

                    dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow);
                    calcularMontoTotal();
                }
                if (dgv_detalle.RowCount > 0)
                    dgv_detalle.ClearSelection();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (_estado == estados.nuevo)
            {
                if (dgv_detalle.Rows.Count >= 1)
                {
                    List<DetalleOrdenCompra> detalle = new List<DetalleOrdenCompra>();

                    for (int c = 0; c < dgv_detalle.RowCount; c++)
                    {
                        DetalleOrdenCompra de = new DetalleOrdenCompra();
                        Producto p = new Producto();

                        p.idProducto = (int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value;
                        p.precio = (double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value;

                        de.cantidad = Convert.ToDouble(dgv_detalle.Rows[c].Cells["cantidad"].Value);
                        de.precio = (double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value;
                        de.subTotal = (double)dgv_detalle.Rows[c].Cells["sub"].Value;

                        de.producto = p;

                        detalle.Add(de);
                    }
                    Persona prov = new Persona();
                    prov.idPersona = (int)cmb_proveedores.SelectedValue;
                    OrdenDeCompra oc = new OrdenDeCompra()
                      {
                          detalleOrdenCompra = detalle,
                          proveedor = prov,
                          monto = Convert.ToDouble(txt_monto_total.Text),
                          fechaOrden = dtp_creacion_OT.Value.Date

                      };
                    try
                    {
                        OrdenDeCompraDAO.Insert(oc);
                        MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        limpiarCampos();
                        btn_guardar.Enabled = false;

                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }


                }
                else
                {
                    MessageBox.Show("La orden de compra no tiene productos, Por favor carguelos", "ATENCION");
                }
                
            }
                       
            
        }
        public void limpiarCampos()
        {
            dtp_creacion_OT.Value = DateTime.Now.Date;
            dgv_detalle.Rows.Clear();
            txt_cantidad.Text = "";
            txt_mail .Text = "";
            txt_monto_total.Text = "";
            txt_contacto .Text = "";
            txt_celular .Text = "";
            txt_contacto .Text = "";
            cmb_proveedores.SelectedValue = 0;
            estadoFormulario = estados.nuevo;
            txt_celular.Text = "";
         
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_unidad.Text = (String)dgv_productos.CurrentRow.Cells["unidad"].Value;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            dgv_detalle.Rows.Clear();
            cmb_proveedores.SelectedValue = 0;
            cmb_proveedores_SelectionChangeCommitted(sender, e);
            txt_monto_total.Text = "0";
        }

        private void btn_Informe_Click(object sender, EventArgs e)
        {
            EmitirInformeProductoXProveedor infProdProv = new EmitirInformeProductoXProveedor();
            infProdProv.ShowDialog();

        }
       
    }
}
