using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;
using Entidades;

namespace Vista
{
    public partial class Gestionar_Estructura_Productos : Form
    {
        Boolean b = false;
        bool eliminarEstructura = false;
        bool estructuraProductoSeleccionado = false;
        GestorEstructuraProducto gestor = new GestorEstructuraProducto();
        
        DetalleProducto detProd = new DetalleProducto();
        public Gestionar_Estructura_Productos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            { 
                MessageBox.Show("Falta cantidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            DetalleProducto det;
            Categoria cat;
            UnidadMedida u;
            UnidadMedida uT;
          

            if (DGVEstructuraProductos.Rows.Count == 0)
            {
                det = new DetalleProducto();
                cat = new Categoria();
                u = new UnidadMedida();
                uT = new UnidadMedida();
                det.idProductoPadre = int.Parse(DGVProductos.SelectedRows[0].Cells["idProduct"].Value.ToString());
                det.idProducto = int.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["idProd"].Value.ToString());
                det.Nombre = DGVProductosAAgregar.SelectedRows[0].Cells["nombreProductoAAgregar"].Value.ToString();

                cat.IDCategoria = int.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["idCategoriaAAgregar"].Value.ToString());
                cat.Nombre = DGVProductosAAgregar.SelectedRows[0].Cells["categoriaAAgregar"].Value.ToString();

                det.cantidad = double.Parse(txtCantidad.Text);

                u.IDUnidad = int.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["idUnidadAAgregar"].Value.ToString());
                u.Nombre = DGVProductosAAgregar.SelectedRows[0].Cells["unidadMedidaAAgregar"].Value.ToString();

                det.cantidadProductos = double.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["cantidadDeProductos1"].Value.ToString());
                det.tiempoProduccion = double.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["tiempoProduccion1"].Value.ToString());
                uT.Nombre = DGVProductosAAgregar.SelectedRows[0].Cells["unidadTiempo1"].Value.ToString();

                DGVEstructuraProductos.Rows.Add(det.idProductoPadre, det.idProducto, det.Nombre, det.cantidad, cat.Nombre, det.cantidadProductos, u.Nombre, det.tiempoProduccion, uT.Nombre);
               
            }
            else
            {
                int band = 0;
                if (estructuraProductoSeleccionado == false)
                {
                    for (int i = 0; i < DGVEstructuraProductos.Rows.Count; i++)
                    {
                        if (int.Parse(DGVEstructuraProductos.Rows[i].Cells["idProducto"].Value.ToString()) == int.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["idProd"].Value.ToString()))
                        {
                            band = 1;
                            DGVEstructuraProductos.Rows[i].Cells["cantidad"].Value = txtCantidad.Text;
                            break;
                        }
                    }

                    if (band == 0)
                    {
                        det = new DetalleProducto();
                        cat = new Categoria();
                        u = new UnidadMedida();
                        uT = new UnidadMedida();
                        det.idProductoPadre = int.Parse(DGVProductos.SelectedRows[0].Cells["idProduct"].Value.ToString());
                        det.idProducto = int.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["idProd"].Value.ToString());
                        det.Nombre = DGVProductosAAgregar.SelectedRows[0].Cells["nombreProductoAAgregar"].Value.ToString();

                        cat.IDCategoria = int.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["idCategoriaAAgregar"].Value.ToString());
                        cat.Nombre = DGVProductosAAgregar.SelectedRows[0].Cells["categoriaAAgregar"].Value.ToString();

                        det.cantidad = double.Parse(txtCantidad.Text);

                        u.IDUnidad = int.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["idUnidadAAgregar"].Value.ToString());
                        u.Nombre = DGVProductosAAgregar.SelectedRows[0].Cells["unidadMedidaAAgregar"].Value.ToString();

                        det.cantidadProductos = double.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["cantidadDeProductos1"].Value.ToString());
                        det.tiempoProduccion = double.Parse(DGVProductosAAgregar.SelectedRows[0].Cells["tiempoProduccion1"].Value.ToString());
                        uT.Nombre = DGVProductosAAgregar.SelectedRows[0].Cells["unidadTiempo1"].Value.ToString();

                        DGVEstructuraProductos.Rows.Add(det.idProductoPadre, det.idProducto, det.Nombre, det.cantidad, cat.Nombre, det.cantidadProductos, u.Nombre, det.tiempoProduccion, uT.Nombre);
                    }
                }
                else
                {
                    DGVEstructuraProductos.SelectedRows[0].Cells["cantidad"].Value = txtCantidad.Text;
                }
            }
            btnAgregar.Enabled = false;
            DGVEstructuraProductos.Enabled = true;
            DGVProductosAAgregar.Enabled = true;

        }

        private void Gestionar_Estructura_Productos_Load(object sender, EventArgs e)
        {
            DGVProductos.Rows.Clear();
            cargarGrillaProductosAAgregar();
            DGVProductosAAgregar.Enabled = false;
            cargarGrillaProductos("todo");
            DGVEstructuraProductos.Rows.Clear();
            btnAgregar.Enabled = false;
            btnSacar.Enabled = false;
        }
        private void cargarGrillaProductosAAgregar()
        {
            try
            {
                List<Producto> productos = GestorEstructuraProducto.buscarProductosAAgregar();

                DGVProductosAAgregar.Rows.Clear();
                foreach (Producto prod in productos)
                {
                    DGVProductosAAgregar.Rows.Add(prod.CODProducto, prod.Nombre, prod.Categoria.Nombre, prod.cantidadProductos, prod.Unidad.Nombre, prod.tiempoProduccion, prod.UnidadTiempo.Nombre, prod.Categoria.IDCategoria, prod.Unidad.IDUnidad, prod.idProducto, prod.tipoMaquina.Nombre, prod.tipoMaquina.idTipoMaquinaria);
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void cargarGrillaProductos(string Cargar)
        {
            if (Cargar == "nuevo")
            {
                try
                {
                    List<Producto> productos = GestorEstructuraProducto.buscarProductosSinEstructura();

                    DGVProductos.Rows.Clear();
                    foreach (Producto prod in productos)
                    {
                        DGVProductos.Rows.Add(prod.CODProducto, prod.Nombre, prod.Descripcion, prod.Categoria.Nombre, prod.Unidad.Nombre, prod.Categoria.IDCategoria, prod.Unidad.IDUnidad, prod.idProducto, prod.tipoMaquina.Nombre, prod.tipoMaquina.idTipoMaquinaria);
                    }

                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            if (Cargar == "modificar")
            {
                try
                {
                    List<Producto> productos = GestorEstructuraProducto.buscarProductosConEstructura();

                    DGVProductos.Rows.Clear();
                    foreach (Producto prod in productos)
                    {
                        DGVProductos.Rows.Add(prod.CODProducto, prod.Nombre, prod.Descripcion, prod.Categoria.Nombre, prod.Unidad.Nombre, prod.Categoria.IDCategoria, prod.Unidad.IDUnidad, prod.idProducto, prod.tipoMaquina.Nombre, prod.tipoMaquina.idTipoMaquinaria);
                    }

                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            if(Cargar == "todo")
            {
                try
                {
                    List<Producto> productos = GestorEstructuraProducto.buscarProductos();

                    DGVProductos.Rows.Clear();
                    foreach (Producto prod in productos)
                    {
                        DGVProductos.Rows.Add(prod.CODProducto, prod.Nombre, prod.Descripcion, prod.Categoria.Nombre, prod.Unidad.Nombre, prod.Categoria.IDCategoria, prod.Unidad.IDUnidad,prod.idProducto, prod.tipoMaquina.Nombre, prod.tipoMaquina.idTipoMaquinaria);
                    }

                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            eliminarEstructura = false;
            cargarGrillaProductos("nuevo");
            lblAccion.Text  = "NUEVA ESTRUCTURA";
            lblDetalle.Text = "";
            DGVEstructuraProductos.Rows.Clear();
            
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btn_eliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            lblProductos.Text = "Todos los Productos SIN ESTRUCTURA";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            eliminarEstructura = false;
            cargarGrillaProductos("modificar");
            lblAccion.Text = "MODIFICAR ESTRUCTURA";
            lblDetalle.Text = "";
            lblProductos.Text = "Todos los Productos CON ESTRUCTURA";
            DGVEstructuraProductos.Rows.Clear();
            DGVEstructuraProductos.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btn_eliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void DGVProductos_DoubleClick(object sender, EventArgs e)
        {
            
            if (lblAccion.Text == "NUEVA ESTRUCTURA" )
            {
                lblDetalle.Text = DGVProductos.SelectedRows[0].Cells["productoPadre"].Value.ToString() + " X " + DGVProductos.SelectedRows[0].Cells["unidad"].Value.ToString();
                DGVEstructuraProductos.Enabled = true;
                DGVProductosAAgregar.Enabled = true;
                DGVProductos.Enabled = false;
            }
            if (lblAccion.Text == "MODIFICAR ESTRUCTURA")
            {
                lblDetalle.Text = DGVProductos.SelectedRows[0].Cells["productoPadre"].Value.ToString() + " X " + DGVProductos.SelectedRows[0].Cells["unidad"].Value.ToString();
                cargarGrillaDetalleProducto();
                DGVEstructuraProductos.Enabled = true;
                DGVProductosAAgregar.Enabled = true;
                DGVProductos.Enabled = false;
            }
            if (lblAccion.Text == "ELIMINAR ESTRUCTURA")
            {
                lblDetalle.Text = DGVProductos.SelectedRows[0].Cells["productoPadre"].Value.ToString() + " X " + DGVProductos.SelectedRows[0].Cells["unidad"].Value.ToString();
                cargarGrillaDetalleProducto();
                DGVProductosAAgregar.Enabled = false;
                DGVProductos.Enabled = false;
                DGVEstructuraProductos.Enabled = false;
 // habilito el boton de eliminar para eliminar con este boton y no con el de guardar....
                btn_eliminar.Enabled = true;
            }
        }

        private void cargarGrillaDetalleProducto()
        {
            if (DGVProductos.SelectedRows[0].Cells["idProduct"].Value == null)
                return;
            try
            {
                List<DetalleProducto> productos = GestorEstructuraProducto.buscarProductosDetalle(int.Parse(DGVProductos.SelectedRows[0].Cells["idProduct"].Value.ToString()));

                DGVEstructuraProductos.Rows.Clear();
                foreach (DetalleProducto prod in productos)
                {
                    DGVEstructuraProductos.Rows.Add(prod.idProductoPadre, prod.idProducto, prod.Nombre, prod.cantidad, prod.Categoria.Nombre, prod.cantidadProductos, prod.Unidad.Nombre, prod.tiempoProduccion, prod.UnidadTiempo.Nombre, prod.Unidad.IDUnidad, prod.Categoria.IDCategoria, prod.TipoMaquinaria.Nombre, prod.TipoMaquinaria.idTipoMaquinaria);
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<DetalleProducto> lista = new List<DetalleProducto>();
            //if (eliminarEstructura == false)
            //{
                if (lblDetalle.Text == "")
                {
                    MessageBox.Show(this, "Falta seleccionar Producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                if (DGVEstructuraProductos.RowCount == 0)
                {
                    MessageBox.Show(this, "Falta asignarle al menos un producto al detalle", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantidad.Focus();
                    return;
                }

                for (int i = 0; i < DGVEstructuraProductos.RowCount; i++)
                {
                    DetalleProducto detalleProducto = new DetalleProducto();
                    detalleProducto.idProductoPadre = int.Parse(DGVEstructuraProductos.Rows[i].Cells["idProductoPadre"].Value.ToString());
                    detalleProducto.idProducto = int.Parse(DGVEstructuraProductos.Rows[i].Cells["idProducto"].Value.ToString());
                    detalleProducto.cantidad = double.Parse(DGVEstructuraProductos.Rows[i].Cells["cantidad"].Value.ToString());
                    lista.Add(detalleProducto);
                }
            //}
            if (lblAccion.Text == "NUEVA ESTRUCTURA")
            {
                try
                {
                    if (MessageBox.Show(this, "¿Desea confirmar nueva estructura?", "Confirmar Nueva Estructura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes )
                    {
                        gestor.tomarDetalleProductos(lista);
                        gestor.nuevaEstructura();
                        MessageBox.Show("Nueva Estructura Registrada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        DGVEstructuraProductos.Enabled = false;
                    }
                    else
                        return;
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            if (lblAccion.Text == "MODIFICAR ESTRUCTURA")
            {
                
                gestor.tomarDetalleProductos(lista);
                gestor.tomarIdProductoPadre(int.Parse(DGVEstructuraProductos.Rows[0].Cells["idProductoPadre"].Value.ToString()));
                try
                {
                    gestor.modificacionConfirmada();
                    MessageBox.Show("Modificacion de Estructura Registrada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    DGVEstructuraProductos.Enabled = false;
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

             
            }

            //if (lblAccion.Text == "ELIMINAR ESTRUCTURA")
            //{

            //    gestor.tomarIdProductoPadre(int.Parse(DGVProductos.SelectedRows[0].Cells[7].Value.ToString()));
            //    try
            //    {
            //        gestor.eliminacionConfirmada();
            //        MessageBox.Show("Eliminada Estructura con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //    }
            //    catch (ApplicationException ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //    }


            //}
            
            cargarGrillaProductos("todo");

            txtCantidad.Text = "";
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btn_eliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAgregar.Enabled = false;
            btnSacar.Enabled = false;

            lblAccion.Text = "SELECCIONE OPCION";
            lblProductos.Text = "TODOS LOS PRODUCTOS";
            lblDetalle.Text = "";
            lblUnidad.Text = "";
            lblSeleccionado.Text = "";

            DGVProductosAAgregar.Enabled = false;
            DGVProductos.Enabled = true;
            DGVEstructuraProductos.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargarGrillaProductos("todo");

            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btn_eliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAgregar.Enabled = false;
            btnSacar.Enabled = false;

            txtCantidad.Text = "";
            lblAccion.Text = "SELECCIONE OPCION";
            lblProductos.Text = "TODOS LOS PRODUCTOS";
            lblDetalle.Text = "";
            lblUnidad.Text = "";
            lblSeleccionado.Text = "";

            DGVEstructuraProductos.Rows.Clear();
            DGVEstructuraProductos.Enabled = false;
            DGVProductosAAgregar.Enabled = false;
            DGVProductos.Enabled = true ;

            
            
        }

        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DGVProductosAAgregar_DoubleClick(object sender, EventArgs e)
        {
            lblSeleccionado.Text = DGVProductosAAgregar.SelectedRows[0].Cells["nombreProductoAAgregar"].Value.ToString();
            lblUnidad.Text = DGVProductosAAgregar.SelectedRows[0].Cells["unidadMedidaAAgregar"].Value.ToString();
            DGVProductosAAgregar.Enabled = false;
            btnAgregar.Enabled = true;
            btnSacar.Enabled = false;
            txtCantidad.Text = "";
            txtCantidad.Focus();
            estructuraProductoSeleccionado = false;
        }

        private void DGVEstructuraProductos_DoubleClick(object sender, EventArgs e)
        {
            if (DGVEstructuraProductos.RowCount != 0)
            {
                lblSeleccionado.Text = DGVEstructuraProductos.SelectedRows[0].Cells["nombreProductoEstructura"].Value.ToString();
                lblUnidad.Text = DGVEstructuraProductos.SelectedRows[0].Cells["unidadMedidaEstructura"].Value.ToString();
                txtCantidad.Text = DGVEstructuraProductos.SelectedRows[0].Cells["cantidad"].Value.ToString();
                DGVProductosAAgregar.Enabled = false;
                btnAgregar.Enabled = true;
                btnSacar.Enabled = true;
                txtCantidad.Focus();
                estructuraProductoSeleccionado = true;
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (DGVEstructuraProductos.RowCount != 0)
            {
                DGVEstructuraProductos.Rows.Remove(DGVEstructuraProductos.CurrentRow);
                DGVProductosAAgregar.Enabled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validarDouble(e, txtCantidad.Text + e.KeyChar) == false)
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
           
            if (b == false)
            {

                DGVEstructuraProductos.Enabled = false;
                DGVProductosAAgregar.Enabled = false;
                DGVProductos.Enabled = true;
                eliminarEstructura = true;

                cargarGrillaProductos("modificar");
                lblAccion.Text = "ELIMINAR ESTRUCTURA";
                lblDetalle.Text = "";
                lblProductos.Text = "Todos los Productos CON ESTRUCTURA";
                DGVEstructuraProductos.Rows.Clear();
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btn_eliminar.Enabled = false;
                //btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                b = true;
            }
            else 
            {
                if (lblAccion.Text == "ELIMINAR ESTRUCTURA")
                {

                    gestor.tomarIdProductoPadre(int.Parse(DGVProductos.SelectedRows[0].Cells["idProduct"].Value.ToString()));
                    try
                    {
                        gestor.eliminacionConfirmada();
                        MessageBox.Show("Eliminada Estructura con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                btnCancelar_Click(sender,e);
                b = false;
                DGVProductos.Enabled = true;
            }
        }
        private void DGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDetalle.Text = DGVProductos.SelectedRows[0].Cells["productoPadre"].Value.ToString() + " X " + DGVProductos.SelectedRows[0].Cells["unidad"].Value.ToString();
            cargarGrillaDetalleProducto();
        }
        private void DGVProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVProductos.SelectedRows.Count != 0)
            {
                lblDetalle.Text = DGVProductos.SelectedRows[0].Cells["productoPadre"].Value.ToString() + " X " + DGVProductos.SelectedRows[0].Cells["unidad"].Value.ToString();
                cargarGrillaDetalleProducto();
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

        private void Gestionar_Estructura_Productos_FormClosed(object sender, FormClosedEventArgs e)
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
