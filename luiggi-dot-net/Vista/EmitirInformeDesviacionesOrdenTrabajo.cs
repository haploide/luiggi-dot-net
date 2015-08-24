using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;

namespace Vista
{
    public partial class EmitirInformeDesviacionesOrdenTrabajo : Form
    {
        public EmitirInformeDesviacionesOrdenTrabajo()
        {
            InitializeComponent();
        }

        private void EmitirInformeDesviacionesOrdenTrabajo_Load(object sender, EventArgs e)
        {
            try
            {
                OrdenDeTrabajoBindingSource.DataSource = InformesDAO.GetInformeDesviacionOrdenesTrabajo(dtp_fecha_desde.Value.Year);
                this.reportViewer1.RefreshReport();
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
                DataTable tabla = InformesDAO.GetInformeDesviacionOrdenesTrabajo(dtp_fecha_desde.Value.Year);

                if (tabla.Rows.Count > 0)
                {
                    OrdenDeTrabajoBindingSource.DataSource = tabla;
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
