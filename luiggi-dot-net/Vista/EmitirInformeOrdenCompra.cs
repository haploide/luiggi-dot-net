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
    public partial class EmitirInformeOrdenCompra : Form
    {
        public EmitirInformeOrdenCompra()
        {
            InitializeComponent();
        }

        private void EmitirInformeOrdenCompra_Load(object sender, EventArgs e)
        {
            try
            {
                InformeOrdenCompraBindingSource.DataSource = InformesDAO.GetInformeOrdenesCompra(null, null);
                this.reportViewer1.RefreshReport();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_aplicar_filtro_Click(object sender, EventArgs e)
        {
            try
            {
                InformeOrdenCompraBindingSource.DataSource = InformesDAO.GetInformeOrdenesCompra(dtp_fecha_desde.Value.Date, dtp_fecha_hasta.Value.Date);
                this.reportViewer1.RefreshReport();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void dtp_fecha_desde_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_fecha_desde.Value.Date >= DateTime.Now.Date)
            {
                dtp_fecha_desde.Value = DateTime.Now;
                dtp_fecha_hasta_ValueChanged(sender, e);
            }
            dtp_fecha_hasta_ValueChanged(sender, e);
        }

        private void dtp_fecha_hasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_fecha_hasta.Value.Date >= DateTime.Now.Date)
            {
                dtp_fecha_hasta.Value = DateTime.Now.Date;
            }
            if (dtp_fecha_hasta.Value.Date <= dtp_fecha_desde.Value.Date)
            {
                dtp_fecha_hasta.Value = dtp_fecha_desde.Value.Date;
            }
        }
    }
}
