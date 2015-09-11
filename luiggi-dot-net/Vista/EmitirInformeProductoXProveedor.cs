using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using Entidades;

namespace Vista
{
    public partial class EmitirInformeProductoXProveedor : Form
    {
        public EmitirInformeProductoXProveedor()
        {
            InitializeComponent();
        }

        private void EmitirInformeProductoXProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                ProductoXProveedorBindingSource.DataSource = ProductoXProveedorDAO.GetAll();
                this.reportViewer1.RefreshReport();
            }
            catch (ApplicationException ex)
            {
                
               MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            cargarCombos();
        }
        public void cargarCombos()
        {
            try
            {

                List<Categoria> cat = CategoriaDAO.GetFiltro();

                List<UnidadMedida> uni = UnidadMedidaDAO.GetAll();
                cat.Add(new Categoria { IDCategoria = 0, Nombre = "SELECCIONE" });
                
               

                uni.Add(new UnidadMedida { IDUnidad = 0, Nombre = "SELECCIONE" });

                cmb_cat_filtro.DataSource = cat;
                cmb_cat_filtro.DisplayMember = "Nombre";
                cmb_cat_filtro.ValueMember = "IDCategoria";
                cmb_cat_filtro.SelectedValue = 0;

                cmb_unidad_filtro.DataSource = uni;
                cmb_unidad_filtro.DisplayMember = "Nombre";
                cmb_unidad_filtro.ValueMember = "IDUnidad";
                cmb_unidad_filtro.SelectedValue = 0;



            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btn_aplicar_filtro_unidad_Click(object sender, EventArgs e)
        {
            string filtros = "1=1";

            if (txt_producto.Text != String.Empty)
            {
                filtros += " and nombre like '"+ txt_producto.Text +"%'";
            }
            if (txt_proveedor.Text != String.Empty)
            {
                filtros += " and razonSocial like '" + txt_proveedor.Text + "%'";
            }
            if ((int)cmb_unidad_filtro.SelectedValue != 0)
            {
                filtros += " and idUnidad=" + (int)cmb_unidad_filtro.SelectedValue;
            }
            if ((int)cmb_cat_filtro.SelectedValue != 0)
            {
                filtros += " and idCategoria=" + (int)cmb_cat_filtro.SelectedValue;
            }


            ProductoXProveedorBindingSource.Filter = filtros;
            this.reportViewer1.RefreshReport();
        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            txt_producto.Text = "";
            txt_proveedor.Text = "";
            cmb_cat_filtro.SelectedValue = 0;
            cmb_unidad_filtro.SelectedValue = 0;
            ProductoXProveedorBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
        }
    }
}
