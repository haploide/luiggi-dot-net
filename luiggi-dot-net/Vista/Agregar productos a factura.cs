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
    public partial class Agregar_productos_a_factura : Form
    {
        public Agregar_productos_a_factura()
        {
            InitializeComponent();
        }

        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Agregar_productos_a_factura_Load(object sender, EventArgs e)
        {
            cargarGrillaProductos();
            dgv_detalle.Enabled = true;
            dgv_productos_finales.Enabled = true;
            txt_cantidad.Enabled = true;
            btn_agregar.Enabled = true;
            btn_quitar.Enabled = true;

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

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (validarDouble(e, txt_cantidad.Text + e.KeyChar) == false)
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }

        private void dgv_productos_finales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cantidad.Text = "";
            txt_cantidad.Focus();
            lbl_unidad.Text = dgv_productos_finales.CurrentRow.Cells["unidad"].Value.ToString();
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
                            dgv_detalle.Rows.Add(cod, nom, pre, can, uni, subTot, idPro);
                            txt_cantidad.Text = "";
                            calcularMontoTotal();
                            btn_quitar.Enabled = true;
                            btn_agregar_a_factura.Enabled = true;
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
                                        calcularMontoTotal();
                                    }
                                }

                                txt_cantidad.Text = "";
                            }
                        }
                        
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
            for (int c = 0; c < dgv_detalle.RowCount; c++)
            {
                montoTotal = montoTotal + (double)dgv_detalle.Rows[c].Cells["sub"].Value;

            }
            txt_monto_total.Text = montoTotal.ToString();
            //if (montoTotal > 0)
            //{
            //    btn_guardar.Enabled = true;
            //}
            //else
            //{
            //    btn_guardar.Enabled = false;
            //}

        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgv_detalle.Rows.Count > 0)
            {
                dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow);
                calcularMontoTotal();
                if (dgv_detalle.Rows.Count == 0)
                {
                    btn_agregar_a_factura.Enabled = false;
 
                }
            }
            else
            {
                btn_agregar_a_factura.Enabled = false;
            }
        }

        private void btn_agregar_a_factura_Click(object sender, EventArgs e)
        {
            
            if (dgv_detalle.Rows.Count >= 1)
            {
                  List<DetalleFactura> detalle = new List<DetalleFactura>();
                
                  for (int c = 0; c < dgv_detalle.RowCount; c++)
                    {
                      DetalleFactura de = new DetalleFactura();
                      Producto p = new Producto();
                      UnidadMedida u = new  UnidadMedida();

                      p.idProducto = (int)dgv_detalle.Rows[c].Cells["idProductodetalle"].Value;
                      p.CODProducto = (int)dgv_detalle.Rows[c].Cells["codigo"].Value;
                      p.Nombre = (string )dgv_detalle.Rows[c].Cells["nombreproductodetalle"].Value;
                      u.Nombre = (string)dgv_detalle.Rows[c].Cells["unidadmedida"].Value;
                      p.Unidad = u;
                      p.precio  = (double)dgv_detalle.Rows[c].Cells["preciodetalle"].Value;
                      de.cantidad = Convert.ToDouble(dgv_detalle.Rows[c].Cells["cantidad"].Value);
                      de.producto = p;
                      detalle.Add(de);
                    } 

                
                Vista.iniciador.detalle = detalle;
                Close();
                Dispose(); 
            }
           

        }

    }
}
