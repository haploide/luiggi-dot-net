using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Controlador;
using System.IO;
using System.Drawing.Imaging;
using DAO;

namespace Vista
{
    public partial class Gestion_Producto_X_Proveedor : Form
    {
        Boolean esNuevo = false;
        ProductoXProveedor productoXProveedor = new ProductoXProveedor();
        ProductoXProveedor prodXProvViejo = new ProductoXProveedor();
        Producto prod = new Producto();
        Persona prov = new Persona();
        private static Gestion_Producto_X_Proveedor InstanciaFormulario = null;

        public Gestion_Producto_X_Proveedor()
        {
            InitializeComponent();
        }

        public static Gestion_Producto_X_Proveedor Instance()
        {
            if (InstanciaFormulario == null)
            {
                InstanciaFormulario = new Gestion_Producto_X_Proveedor();
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

        private void Gestion_Producto_X_Proveedor_Load(object sender, EventArgs e)
        {
            ((Menu_Principal)(MdiParent)).btn_ventas.Visible = false;
            ((Menu_Principal)(MdiParent)).btn_impresiones.Visible = false;
            ((Menu_Principal)(MdiParent)).btn_pedido.Visible = false;
            iniciador.cantVentanasAbiertas++;

            cargarGrilla();
            cargarGrillaProductos();
            cargarGrillaProveedores();
            limpiar();
            esNuevo = true;
        }
        private void limpiar()
        {
            txt_precio_proveedor.Text = "";
            lbl_unidad.Text = "";
            dgv_productos.ClearSelection();
            dgv_proveedores.ClearSelection();
            dgv_Productos_X_Proveedores.ClearSelection();
        }
        private void cargarGrillaProductos()
        {
            try
            {
                List<Producto> productos = ProductoDAO.GetPeductosMPeInsumos();

                dgv_productos.Rows.Clear();
                foreach (Producto prod in productos)
                {
                    if (prod.Unidad.Nombre == "g")
                    {
                        prod.Unidad.Nombre = "Kilo";
                        prod.StockActual = int.Parse(prod.StockActual.ToString()) / 1000;
                        prod.StockReservado = int.Parse(prod.StockReservado.ToString()) / 1000;
                        prod.StockRiesgo = int.Parse(prod.StockRiesgo.ToString()) / 1000;
                        prod.StockDisponible = int.Parse(prod.StockDisponible.ToString()) / 1000;

                    }
                    dgv_productos.Rows.Add(prod.idProducto, prod.Nombre, prod.Descripcion, prod.Categoria.Nombre, prod.Unidad.Nombre, prod.StockDisponible, prod.StockRiesgo, prod.StockActual, prod.StockReservado, prod.Unidad.IDUnidad, prod.Categoria.IDCategoria);
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void cargarGrillaProveedores()
        {
            try
            {
                List<Persona> Proveedor = PersonaDAO.GetAll();
                dgv_proveedores.Rows.Clear();
                foreach (Persona prov in Proveedor)
                {
                    if (prov.NroCliente == 0)
                    {
                        dgv_proveedores.Rows.Add(prov.NroProveedor, prov.RazonSocial, prov.cuil, prov.Apellido, prov.Nombre, prov.telefono, prov.mail, prov.condicionIVA.idCondicionIVA, prov.idPersona);
                    }
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void cargarGrilla()
        {
            try
            {
                List<ProductoXProveedor> productos = ProductoXProveedorDAO.buscarProductosXProveedor();

                dgv_Productos_X_Proveedores.Rows.Clear();
                foreach (ProductoXProveedor prodXP in productos)
                {
                    if (prodXP.producto.Unidad.Nombre == "g")
                    {
                        prodXP.producto.Unidad.Nombre = "Kilo";
                    }
                    dgv_Productos_X_Proveedores.Rows.Add(prodXP.producto.idProducto, prodXP.producto.Nombre, prodXP.proveedor.NroProveedor, prodXP.proveedor.RazonSocial, prodXP.precioProveedor, prodXP.producto.Unidad.Nombre,prodXP.fechaPrecio, prodXP.proveedor.idPersona);
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }

        private void btn_nuevo_producto_Click(object sender, EventArgs e)
        {
            Gestion_de_Producto gestProd = new Gestion_de_Producto();
            gestProd.ShowDialog();
            cargarGrillaProductos();
            limpiar();
        }

        private void btn_nuevo_proveedor_Click(object sender, EventArgs e)
        {
            Gestion_de_Proveedores gestProv = new Gestion_de_Proveedores();
            gestProv.ShowDialog();
            cargarGrillaProveedores();
            limpiar();
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            esNuevo = true;
        }

        private void txt_precio_proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validarDouble(e, txt_precio_proveedor.Text + e.KeyChar) == false)
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

        private void dgv_Productos_X_Proveedores_Click(object sender, EventArgs e)
        {
            if (dgv_Productos_X_Proveedores.SelectedRows.Count != 0)
            {
                for (int i = 0; i < dgv_productos.Rows.Count; i++)
                {
                    if (dgv_Productos_X_Proveedores.CurrentRow.Cells["idProducto2"].Value.ToString() == dgv_productos.Rows[i].Cells["idProducto"].Value.ToString())
                    {
                        dgv_productos.Rows[i].Selected = true;
                        break;
                    }
                }

                for (int i = 0; i < dgv_proveedores.Rows.Count; i++)
                {
                    if (dgv_Productos_X_Proveedores.CurrentRow.Cells["nroProv2"].Value.ToString() == dgv_proveedores.Rows[i].Cells["idPersona"].Value.ToString())
                    {
                        dgv_proveedores.Rows[i].Selected = true;
                        break;
                    }
                }
                txt_precio_proveedor.Text = dgv_Productos_X_Proveedores.CurrentRow.Cells["precioProducto"].Value.ToString();
                lbl_unidad.Text = "x " + dgv_Productos_X_Proveedores.CurrentRow.Cells["unidad2"].Value.ToString();
                esNuevo = false;
                prodXProvViejo.fechaPrecio = Convert.ToDateTime(dgv_Productos_X_Proveedores.CurrentRow.Cells["fechaPrecio"].Value);
                prodXProvViejo.precioProveedor = Convert.ToDouble(dgv_Productos_X_Proveedores.CurrentRow.Cells["precioProducto"].Value.ToString());
                Producto p = new Producto();
                p.idProducto = Convert.ToInt32(dgv_Productos_X_Proveedores.CurrentRow.Cells["idProducto2"].Value.ToString());
                prodXProvViejo.producto = p;
                Persona per = new Persona();
                per.idPersona = Convert.ToInt32(dgv_Productos_X_Proveedores.CurrentRow.Cells["nroProv2"].Value.ToString());
                prodXProvViejo.proveedor = per;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_precio_proveedor.Text == "")
            {
                MessageBox.Show("El campo Precio no puequede quedar vacio, porfavor escriba uno.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precio_proveedor.Focus();
                return;
            }
            if (dgv_productos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un producto a asociar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgv_proveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un proveedor a asociar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            productoXProveedor.fechaPrecio = DateTime.Now;
            productoXProveedor.precioProveedor = double.Parse(txt_precio_proveedor.Text);
            prod.idProducto = int.Parse(dgv_productos.SelectedRows[0].Cells["idProducto"].Value.ToString());
            prod.Nombre = dgv_productos.SelectedRows[0].Cells["producto"].Value.ToString();
            prov.NroProveedor = int.Parse(dgv_proveedores.SelectedRows[0].Cells["nroProv"].Value.ToString());
            prov.RazonSocial = dgv_proveedores.SelectedRows[0].Cells["raSocial"].Value.ToString();
            prov.idPersona = int.Parse(dgv_proveedores.SelectedRows[0].Cells["idPersona"].Value.ToString());
            productoXProveedor.producto = prod;
            productoXProveedor.proveedor = prov;

            if (esNuevo == true)
            {
                if (ProductoXProveedorDAO.sePuedeInsertar(productoXProveedor.proveedor.idPersona, productoXProveedor.producto.idProducto) == true)
                {
                    ProductoXProveedorDAO.Insert(productoXProveedor);
                    MessageBox.Show("Nuevo Producto Por Proveedor cargado con exito", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrilla();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Ya se tiene cargado el producto: " + productoXProveedor.producto.Nombre.ToString() + " al Proveedor: " + productoXProveedor.proveedor.RazonSocial , "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                if (productoXProveedor.proveedor.idPersona == prodXProvViejo.proveedor.idPersona && productoXProveedor.producto.idProducto == prodXProvViejo.producto.idProducto)
                {
                    ProductoXProveedorDAO.Update(productoXProveedor, prodXProvViejo);
                    MessageBox.Show("Producto Por Proveedor actualizado con exito", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrilla();
                    limpiar();
                }
                else
                {
                    if (ProductoXProveedorDAO.sePuedeInsertar(productoXProveedor.proveedor.idPersona, productoXProveedor.producto.idProducto) == true)
                    {
                        ProductoXProveedorDAO.Update(productoXProveedor, prodXProvViejo);
                        MessageBox.Show("Producto Por Proveedor actualizado con exito", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.None);
                        cargarGrilla();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ya se tiene cargado el producto: " + productoXProveedor.producto.Nombre.ToString() + " al Proveedor: " + productoXProveedor.proveedor.RazonSocial, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
        }

        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Productos_X_Proveedores.SelectedRows.Count != 0)
            {
                Persona per = new Persona();
                Producto prod = new Producto();
                per.idPersona = int.Parse(dgv_Productos_X_Proveedores.SelectedRows[0].Cells["nroProv2"].Value.ToString());
                per.RazonSocial = dgv_Productos_X_Proveedores.SelectedRows[0].Cells["proveedor2"].Value.ToString();
                productoXProveedor.proveedor = per;
                prod.idProducto = int.Parse(dgv_Productos_X_Proveedores.SelectedRows[0].Cells["idProducto2"].Value.ToString());
                prod.Nombre =dgv_Productos_X_Proveedores.SelectedRows[0].Cells["producto2"].Value.ToString();
                productoXProveedor.producto = prod;
                productoXProveedor.fechaPrecio = Convert.ToDateTime(dgv_Productos_X_Proveedores.SelectedRows[0].Cells["fechaPrecio"].Value.ToString());
                if (MessageBox.Show("Esta seguro de querer eliminar el producto: " + productoXProveedor.producto.Nombre + " del Proveedor: " + productoXProveedor.proveedor.RazonSocial, "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    ProductoXProveedorDAO.Delete(productoXProveedor);
                    MessageBox.Show("Producto Por Proveedor: " + prod.Nombre + " de " + per.RazonSocial + " ELIMINADO con exito", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.None);
                    cargarGrilla();
                    limpiar();
                    esNuevo = true;
                }
            }
        }

        private void dgv_productos_Click(object sender, EventArgs e)
        {
            lbl_unidad.Text = "x " + dgv_productos.CurrentRow.Cells["unidad"].Value.ToString();
        }

        private void Gestion_Producto_X_Proveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            iniciador.cantVentanasAbiertas--;

            if (iniciador.cantVentanasAbiertas == 0)
            {
                ((Menu_Principal)(MdiParent)).btn_impresiones.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_pedido.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_ventas.Visible = true;
            }
        }
    }
}
