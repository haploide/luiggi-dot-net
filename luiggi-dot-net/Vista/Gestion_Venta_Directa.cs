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
    public partial class Gestion_Venta_Directa : Form
    {
        public Persona resultado;
        public Persona res;
        public Gestion_Venta_Directa()
        {
            InitializeComponent();
        }

        public void cargarCombo()
        {

            List<CondicionIVA> condIva = CondicionIVADAO.GetAll();

            cmb_iva.DataSource = condIva;
            cmb_iva.DisplayMember = "nombre";
            cmb_iva.ValueMember = "idCondicionIVA";

            cmb_iva.SelectedValue = 4;
            if (cmb_iva.SelectedIndex == 0)
            {
                cmb_tipo_factura.SelectedIndex = 0;
            }
            else
            {
                cmb_tipo_factura.SelectedIndex = 1 ;
            }
            
           
        }

        public void cargarGrillaProductos()
        {
            try
            {
                List<Producto> productos = ProductoDAO.GetPeductosFinales();

                dgv_productos_finales.Rows.Clear();
                foreach (Producto prod in productos)
                {
                    dgv_productos_finales.Rows.Add(prod.CODProducto, prod.Nombre, prod.Descripcion, prod.precio, prod.Unidad.Nombre, prod.idProducto, prod.StockDisponible);
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Gestion_Venta_Directa_Load(object sender, EventArgs e)
        {
            txt_nroFactura.Text = (int.Parse(FacturaDAO.getUltimoNumeroFactura().ToString())).ToString();
            cargarCombo();
            cargarGrillaProductos();
            chk_Venta_Rapida.Checked = true;

            dgv_detalle.Enabled = true;
            dgv_productos_finales.Enabled = true;
            txt_cantidad.Enabled = true;
            btn_agregar.Enabled = true;
            btn_quitar.Enabled = true;
            btn_guardar.Enabled = true;
            rdb_Contado.Checked = true;
            
        }
        private void checkear()
        {
            btn_aplicar_filtro_empresa.Enabled = false;
            txt_apellido.Enabled = false;
            txt_nombre.Enabled = false;
            txt_razon_social.Enabled = false;
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_razon_social.Text = "";
            cmb_iva.SelectedValue = 4;
            txt_cuit.Enabled = false;
            txt_cuit.Text = "";
        }
        private void chk_Venta_Rapida_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Venta_Rapida.Checked == true)
            {
                checkear();
                
            }
            else
            {
                btn_aplicar_filtro_empresa.Enabled = true;
                txt_apellido.Enabled = true;
                txt_nombre.Enabled = true;
                txt_razon_social.Enabled = true;
                txt_cuit.Enabled = true;
                res = null;
            }
        }

        private void dgv_productos_finales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cantidad.Text = "";
            lbl_unidad.Text = dgv_productos_finales.CurrentRow.Cells["unidad"].Value.ToString();
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
            if (dgv_productos_finales.SelectedRows.Count != 0)
            {
                if (txt_cantidad.Text == "")
                {
                    MessageBox.Show("Complete el campo cantidad ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    if (double.Parse(dgv_productos_finales.CurrentRow.Cells["stockDisp"].Value.ToString()) >= double.Parse(txt_cantidad.Text))
                    {
                        Boolean result = false;
                        int comparar = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["idProducto"].Value;

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
                            int idPro = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["idProducto"].Value;
                            int cod = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["cod"].Value;
                            string nom = (string)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["nombreproducto"].Value;
                            string uni = (string)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["unidad"].Value;
                            double can = Convert.ToDouble(txt_cantidad.Text);
                            double pre = (double)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["precio"].Value;
                            double subTot = can * pre;
                            double Iva = 0 ;
                            if((int)cmb_iva.SelectedValue==1)
                            {
                                Iva = pre * 0.21;
                                pre -= Iva;
                            }

                            dgv_detalle.Rows.Add(cod, nom, pre, can, uni, subTot, idPro, Iva*can);
                            txt_cantidad.Text = "";
                            calcularMontoTotal();
                            btn_quitar.Enabled = true;
                        }
                        else
                        {
                            if (MessageBox.Show("Ya se cargó el producto, ¿Desea Modificar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                int index = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["idProducto"].Value;

                                for (int c = 0; c < dgv_detalle.RowCount; c++)
                                {
                                    if ((int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value == index)
                                    {
                                        int can = Convert.ToInt32(txt_cantidad.Text);
                                        dgv_detalle.Rows[c].Cells["cantidad"].Value = can;
                                        double pre = (double)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["precio"].Value;
                                        dgv_detalle.Rows[c].Cells["sub"].Value = can * pre;
                                        double Iva = 0;
                                        if ((int)cmb_iva.SelectedValue == 1)
                                        {
                                            Iva = pre * 0.21;
                                            pre -= Iva;
                                        }
                                        dgv_detalle.Rows[c].Cells["iva"].Value = Iva * can;
                                        calcularMontoTotal();
                                    }
                                }

                                txt_cantidad.Text = "";
                            }
                        }
                        cmb_tipo_factura_SelectedValueChanged(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No hay suficientes " + dgv_productos_finales.CurrentRow.Cells["nombreproducto"].Value, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }
        public void calcularMontoTotal()
        {
            double montoTotal = 0;
            double subTotal = 0;
            for (int c = 0; c < dgv_detalle.RowCount; c++)
            {
                montoTotal = montoTotal + (double)dgv_detalle.Rows[c].Cells["sub"].Value;
                subTotal += (double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value * (double)dgv_detalle.Rows[c].Cells["cantidad"].Value;
            }
            txt_subTotal.Text = subTotal.ToString();
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
                dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow);
                calcularMontoTotal();
                cmb_tipo_factura_SelectedValueChanged(sender, e);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (dgv_detalle.Rows.Count >= 1)
            {
                if (res == null && chk_Venta_Rapida.Checked == true || res != null && chk_Venta_Rapida.Checked == false)
                {
                    List<DetalleFactura> detalle = new List<DetalleFactura>();
                    Factura fact = new Factura();
                    Persona per = new Persona();
                    Estado est = new Estado();
                    if (chk_Venta_Rapida.Checked == true)
                    {
                        per.idPersona = 17;
                    }
                    else
                    {
                        per.idPersona = res.idPersona;
                    }
                    fact.cliente = per;
                    fact.fechaCreacion = DateTime.Now.Date;
                    est.idEstado = 27;
                    fact.estado = est;
                    fact.importeTotal = int.Parse(txt_monto_total.Text);
                    fact.tipoFactura = char.Parse( cmb_tipo_factura.Text);
                    fact.totalIVA = double.Parse(txt_totalIva.Text);
                    for (int c = 0; c < dgv_detalle.RowCount; c++)
                    {
                        DetalleFactura de = new DetalleFactura();
                        Producto p = new Producto();

                        p.idProducto = (int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value;
                        de.subTotal = (double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value;
                        de.cantidad = Convert.ToDouble(dgv_detalle.Rows[c].Cells["cantidad"].Value);
                        de.iva = Convert.ToDouble(dgv_detalle.Rows[c].Cells["iva"].Value);
                        de.producto = p;
                        detalle.Add(de);
                    }
                    fact.detalleFactura = detalle;

                    try
                    {
                        iniciador.idFactura = FacturaDAO.InsertFacturaDirecta(fact);
                        MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        btn_guardar.Enabled = false;
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    Emitir_Factura factura = new Emitir_Factura();
                    factura.ShowDialog();
                    btn_nuevo_Click(sender, e);
                }
            }
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
            if (txt_cuit.Text != "  -        -")
            {
                per.cuil = txt_cuit.Text;
            }
            if (txt_razon_social.Text != "")
            {
                per.RazonSocial = txt_razon_social.Text;
            }
            List<Persona> resul = null;
            try
            {
                resul = PersonaDAO.GetByFiltro(per);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            if (resul.Count == 1)
            {
                res = resul.ElementAt<Persona>(0);
                txt_apellido.Text = res.Apellido;
                txt_nombre.Text = res.Nombre;
                txt_razon_social.Text = res.RazonSocial;
                cmb_iva.SelectedValue = res.condicionIVA.idCondicionIVA;
                txt_cuit.Text = res.cuil;
            }
            else
            {
                ResultadoDeFiltro resFiltro = new ResultadoDeFiltro();
                resFiltro._resultado = resul;

                resFiltro.ShowDialog();

                res = Vista.iniciador.per;
                resultado = res;
                if (res != null)
                {
                    txt_apellido.Text = res.Apellido;
                    txt_nombre.Text = res.Nombre;
                    txt_razon_social.Text = res.RazonSocial;
                    txt_cuit.Text = res.cuil;
                    cmb_iva.SelectedValue = res.condicionIVA.idCondicionIVA;
                }
            }
            btn_agregar.Enabled = true;
            txt_cantidad.Enabled = true;
            dgv_productos_finales.Enabled = true;
            dgv_detalle.Enabled = true;
        }


        private void cmb_iva_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_iva.SelectedIndex == 0)
            {
                cmb_tipo_factura.SelectedIndex = 0;
            }
            else
            {
                cmb_tipo_factura.SelectedIndex = 1;
            }
        }

        private void cmb_tipo_factura_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_tipo_factura.SelectedIndex == 0)
            {
                if (txt_monto_total.Text != "")
                {
                    double montoTotal = double.Parse(txt_monto_total.Text.ToString());
                    txt_totalIva.Text = (montoTotal * 0.21).ToString();
                }

            }
            else
            {
                txt_totalIva.Text = "0";
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            dgv_detalle.Rows.Clear();
            txt_monto_total.Text = "0";
            txt_totalIva.Text = "0";
            txt_subTotal.Text = "0";
            txt_nroFactura.Text = (int.Parse(FacturaDAO.getUltimoNumeroFactura().ToString()) + 1).ToString();
            cargarCombo();
            cargarGrillaProductos();
            chk_Venta_Rapida.Checked = true;
            chk_Venta_Rapida_CheckedChanged(sender, e);
            dgv_detalle.Enabled = true;
            dgv_productos_finales.Enabled = true;
            txt_cantidad.Enabled = true;
            btn_agregar.Enabled = true;
            btn_quitar.Enabled = true;
            btn_guardar.Enabled = true;
            rdb_Contado.Checked = true;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (dgv_detalle.Rows.Count >= 1)
            {
                if (res == null && chk_Venta_Rapida.Checked == true || res != null && chk_Venta_Rapida.Checked == false)
                {
                    List<DetalleFactura> detalle = new List<DetalleFactura>();
                    Factura fact = new Factura();
                    Persona per = new Persona();
                    Estado est = new Estado();
                    if (chk_Venta_Rapida.Checked == true)
                    {
                        per.idPersona = 17;
                    }
                    else
                    {
                        per.idPersona = res.idPersona;
                    }
                    fact.cliente = per;
                    fact.fechaCreacion = DateTime.Now.Date;
                    est.idEstado = 27;
                    fact.estado = est;
                    fact.importeTotal = int.Parse(txt_monto_total.Text);
                    fact.tipoFactura = char.Parse(cmb_tipo_factura.Text);
                    fact.totalIVA = double.Parse(txt_totalIva.Text);
                    for (int c = 0; c < dgv_detalle.RowCount; c++)
                    {
                        DetalleFactura de = new DetalleFactura();
                        Producto p = new Producto();

                        p.idProducto = (int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value;
                        de.subTotal = (double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value;
                        de.cantidad = Convert.ToDouble(dgv_detalle.Rows[c].Cells["cantidad"].Value);
                        de.iva = Convert.ToDouble(dgv_detalle.Rows[c].Cells["iva"].Value);
                        de.producto = p;
                        detalle.Add(de);
                    }
                    fact.detalleFactura = detalle;

                    try
                    {
                        //iniciador.idFactura = FacturaDAO.InsertFacturaDirecta(fact);
                        MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        btn_guardar.Enabled = false;
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    Emitir_Factura factura = new Emitir_Factura();
                    factura.ShowDialog();
                    btn_nuevo_Click(sender, e);
                }
            }
            EmitirPresupuesto emitir = new EmitirPresupuesto();
            emitir.ShowDialog();
        }

           

        

    }
}
