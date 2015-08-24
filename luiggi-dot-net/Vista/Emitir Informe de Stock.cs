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
    public partial class Emitir_Informe_de_Stock : Form
    {
        public Emitir_Informe_de_Stock()
        {
            InitializeComponent();
        }

        private void Emitir_Informe_de_Stock_Load(object sender, EventArgs e)
        {
            cargarCombos();
            try
            {
                DataTable tabla = ProductoDAO.GetByFiltrosInforme(1, null, false);


                ProductoBindingSource.DataSource = tabla;

                this.reportViewer1.RefreshReport();
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

                List<Categoria> cat = CategoriaDAO.GetAll();

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

            int? categoria = null;
            int? unidad = null;

            if ((int)cmb_cat_filtro.SelectedValue != 0)
            {
                categoria = (int)cmb_cat_filtro.SelectedValue;
            }
            if ((int)cmb_unidad_filtro.SelectedValue != 0)
            {
                unidad = (int)cmb_unidad_filtro.SelectedValue;
            }



            try
            {
                DataTable tabla = ProductoDAO.GetByFiltrosInforme(categoria, unidad,chk_bajo.Checked);


                ProductoBindingSource.DataSource = tabla;

                this.reportViewer1.RefreshReport();
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
