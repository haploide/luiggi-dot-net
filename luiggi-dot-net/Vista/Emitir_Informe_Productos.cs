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
    public partial class Emitir_Informe_Productos : Form
    {
        public Emitir_Informe_Productos()
        {
            InitializeComponent();
        }

        private void Emitir_Informe_Productos_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = InformesDAO.GetInformeProductos();

                if (tabla.Rows.Count > 0)
                {
                    ProductoBindingSource.DataSource = tabla;
                    this.reportViewer1.RefreshReport(); 
                }
                else
                {
                    MessageBox.Show("No hay datos disponibles", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }

            }
            catch (ApplicationException ex)
            {
                
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
