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
    public partial class Emitir_Informe_de_Venta_por_Producto : Form
    {
        public Emitir_Informe_de_Venta_por_Producto()
        {
            InitializeComponent();
        }

        private void Emitir_Informe_de_Venta_por_Producto_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable tabla = InformesDAO.GetInformeVentasProducto(dtp_fecha_desde.Value.Date, dtp_fecha_hasta.Value.Date);

                if (tabla.Rows.Count > 0)
                {
                    ProductosBindingSource.DataSource = tabla;

                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    //MessageBox.Show("No hay datos disponibles", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_aplicar_filtro_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = InformesDAO.GetInformeVentasProducto(dtp_fecha_desde.Value.Date,dtp_fecha_hasta.Value.Date);

                if (tabla.Rows.Count > 0)
                {
                    ProductosBindingSource.DataSource = tabla;

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

        private void dtp_fecha_desde_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_fecha_desde.Value.Date >= DateTime.Now.Date)
            {
                dtp_fecha_desde.Value = DateTime.Now;
            }
        }

        private void dtp_fecha_hasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_fecha_hasta.Value.Date >= DateTime.Now.Date||dtp_fecha_hasta.Value.Date <= dtp_fecha_desde.Value.Date)
            {
                dtp_fecha_hasta.Value = DateTime.Now;
            }
            
        }
    }
}
