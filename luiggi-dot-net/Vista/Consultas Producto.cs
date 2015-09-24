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
using System.Drawing.Imaging;
using System.IO;

namespace Vista
{
    public partial class Consultas_Producto : Form
    {
        public GestorConsultaProducto gestor;
        private static Consultas_Producto InstanciaFormulario = null;
        public Consultas_Producto()
        {
            InitializeComponent();
        }

        public static Consultas_Producto Instance()
        {
            if (InstanciaFormulario == null)
            {
                InstanciaFormulario = new Consultas_Producto();
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

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            Gestion_de_Producto gestProd = new Gestion_de_Producto();
            gestProd._estado = estados.nuevo;
            gestProd.ShowDialog();
            cargarGrilla();

        }

        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Consultas_Producto_Load(object sender, EventArgs e)
        {
            ((Menu_Principal)(MdiParent)).btn_ventas.Visible = false;
            ((Menu_Principal)(MdiParent)).btn_impresiones.Visible = false;
            ((Menu_Principal)(MdiParent)).btn_pedido.Visible = false;
            iniciador.cantVentanasAbiertas++;
            
            cargarGrilla();
            gestor = new GestorConsultaProducto ();
            limpiar();
            cargarCombos();
          
        }
        private void limpiar()
        {
            txt_precio_desde.Text = "";
            txt_precio_hasta.Text = "";
        }
        private void cargarGrilla()
        {
            try
            {
                List<Producto> productos = GestorConsultaProducto.buscarProductos();

                dgv_productos.Rows.Clear();
                foreach (Producto prod in productos)
                {
                    dgv_productos.Rows.Add(prod.CODProducto, prod.Nombre, prod.Descripcion, prod.precio, prod.Categoria.Nombre, prod.Unidad.Nombre, prod.StockRiesgo, prod.Unidad.IDUnidad, prod.Categoria.IDCategoria, prod.foto, prod.precioMayorista, prod.tipoMaquina.idTipoMaquinaria, prod.tiempoProduccion, prod.UnidadTiempo.IDUnidad, prod.cantidadProductos);
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        public void cargarCombos()
        {
            try
            {
                
                List<Categoria> cat = gestor.buscarCategorias();
                
                List<UnidadMedida> uni = gestor.buscarUnidadDeMedida();
                cat.Add(new Categoria { IDCategoria = 0, Nombre = "TODOS" });
                uni.Add(new UnidadMedida {IDUnidad =0, Nombre= "TODOS"});
                cmb_cat_filtro.DataSource = cat;
                cmb_cat_filtro.DisplayMember = "Nombre";
                cmb_cat_filtro.ValueMember = "IDCategoria";
                cmb_cat_filtro.SelectedValue   = 0;

                cmb_unidad_filtro.DataSource = uni;
                cmb_unidad_filtro.DisplayMember = "Nombre";
                cmb_unidad_filtro.ValueMember = "IDUnidad";
                cmb_unidad_filtro.SelectedValue   = 0;
                
          
                
            }
                
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string productoselec = (string)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["Nombre"].Value;
            if (MessageBox.Show("Desea eliminar el Producto: " + productoselec, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
                int codProd = (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["codigo"].Value;
               
                try
                {
                    gestor.eliminacionConfirmada();
                    MessageBox.Show("Producto eliminado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cargarGrilla();
                    Consultas_Producto_Load(sender, e);

                }
                catch(ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
            }
        }
        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Gestion_de_Producto gestProd = new Gestion_de_Producto();
            gestProd._estado = estados.modificar;

            Categoria cat = new Categoria()
            {
                IDCategoria = (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["codCategoria"].Value,
                Nombre = (string)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["cat"].Value,
            };
            UnidadMedida uni = new UnidadMedida()
            {
                IDUnidad = (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["idUnidad"].Value,
                Nombre = (string)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["Unidad"].Value,
            };
            TipoMaquinaria tm = new TipoMaquinaria ()
            {
                idTipoMaquinaria = (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["idTipoMaquinaria"].Value,
            };
            UnidadMedida  ut = new UnidadMedida ()
            {
                IDUnidad  = (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["idUnidadTiempo"].Value,
            };
            Producto prodModificar = new Producto()
            {
                CODProducto = (int)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["codigo"].Value,
                Nombre = (string)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["Nombre"].Value,
                Descripcion = (string)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["Desc"].Value,
                precio=(double)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["precio"].Value,
                StockRiesgo = (double )dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["stock_riesg"].Value,
                Categoria =cat,
                Unidad=uni,
                UnidadTiempo = ut,
                foto  = (Byte[])dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["foto"].Value,
                precioMayorista = (double)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["precioMayorista"].Value,
                tiempoProduccion = (double)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["tiempo"].Value,
                tipoMaquina = tm,
                cantidadProductos = (double)dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["cantidadProductos"].Value,
            };
            
            gestProd._prodModificar=prodModificar;
            gestProd.ShowDialog();
            cargarGrilla();
        }
        private void btn_aplicar_filtro_Click(object sender, EventArgs e)
        {
            if(!(txt_precio_desde.Text=="") && !(txt_precio_hasta.Text==""))
            {

            }
        }
        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Byte[] byteImagen = (Byte[])dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["foto"].Value;
            Byte[] a1 = new Byte[] {0,0,0,0};
           


            if (ByteArrayCompare(byteImagen,a1  ))
            {

                pb_foto.Image = Vista.Properties.Resources.photo3;
                pb_foto.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            else
            {


                //Byte[] byteImagen = (Byte[])dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells["foto"].Value;
                MemoryStream ms = new MemoryStream(byteImagen);
                pb_foto.Image = Image.FromStream(ms);
                pb_foto.SizeMode = PictureBoxSizeMode.StretchImage ;
               
            }
               
           

        }
        private static bool ByteArrayCompare(byte[] a1, byte[] a2)
        {
            if (a1.Length != a2.Length)
                return false;

            for (int i = 0; i < a1.Length; i++)
                if (a1[i] != a2[i])
                    return false;

            return true;
        }
        private void btn_aplicar_filtro_unidad_Click(object sender, EventArgs e)
        {
            pb_foto.Image = Vista.Properties.Resources.photo3;
            pb_foto.SizeMode = PictureBoxSizeMode.CenterImage;
            cargarGrillafiltros();
        }
        private void cargarGrillafiltros()
        {
            double? precioDesde = null;
            double? precioHasta = null;

            if (!string.IsNullOrEmpty(txt_precio_desde.Text ))
                precioDesde = double.Parse(txt_precio_desde.Text);

            if (!string.IsNullOrEmpty(txt_precio_hasta.Text ))
                precioHasta = double.Parse(txt_precio_hasta.Text);

            try
            {
                List<Producto> productos = GestorConsultaProducto.buscarProductosFiltrados((int)cmb_cat_filtro.SelectedValue, (int)cmb_unidad_filtro.SelectedValue,precioDesde, precioHasta  );

                dgv_productos.Rows.Clear();
                foreach (Producto prod in productos)
                {
                    dgv_productos.Rows.Add(prod.CODProducto, prod.Nombre, prod.Descripcion, prod.precio, prod.Categoria.Nombre, prod.Unidad.Nombre, prod.StockRiesgo, prod.Unidad.IDUnidad, prod.Categoria.IDCategoria, prod.foto, prod.precioMayorista, prod.tipoMaquina.idTipoMaquinaria, prod.tiempoProduccion, prod.UnidadTiempo.IDUnidad, prod.cantidadProductos);
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            pb_foto.Image = Vista.Properties.Resources.photo3;
            pb_foto.SizeMode = PictureBoxSizeMode.CenterImage;
            Consultas_Producto_Load(sender,e);

        }
        private void txt_precio_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }

        private void Consultas_Producto_FormClosed(object sender, FormClosedEventArgs e)
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
