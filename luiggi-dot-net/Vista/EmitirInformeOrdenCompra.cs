using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using Microsoft.Reporting.WinForms;

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
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("desde", "01/01/1900"));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("hasta", "01/01/1900"));
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

                string filtro = "";
                if (rbt_todos.Checked==true)
                {
                    filtro += "1=1";
                }
                if (rbt_conDiferencias.Checked == true)
                {
                    filtro += "cantidad <> cantidadRealIngresada";
                    
 
                }

                if (rbt_sinDif.Checked == true)
                {
                    filtro += "cantidad = cantidadRealIngresada";
                }
                if (txt_proveedor.Text != String.Empty)
                {
                    filtro += " and razonSocial like '" + txt_proveedor.Text + "%'";
                }

                InformeOrdenCompraBindingSource.Filter = filtro;
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("desde",dtp_fecha_desde.Value.Date.ToString()));
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("hasta",dtp_fecha_hasta.Value.Date.ToString()));
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

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            try
            {
                rbt_todos.Checked = true;
                txt_proveedor.Text = "";
                dtp_fecha_desde.Value = DateTime.Now;
                InformeOrdenCompraBindingSource.Filter="";
                EmitirInformeOrdenCompra_Load(sender, e);
                
            }
            
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            
        }
    }
}
