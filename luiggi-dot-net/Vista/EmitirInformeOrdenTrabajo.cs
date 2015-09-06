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
using Microsoft.Reporting.WinForms;

namespace Vista
{
    public partial class EmitirInformeOrdenTrabajo : Form
    {
        public EmitirInformeOrdenTrabajo()
        {
            InitializeComponent();
        }

        private void EmitirInformeOrdenTrabajo_Load(object sender, EventArgs e)
        {
            try

            {
                DataTable tabla = OrdenDeTrabajoDAO.GetByFiltrosInforme(null,null);

                if (tabla.Rows.Count > 0)
                {
                    OrdenTrabajoBindingSource.DataSource = tabla;

                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter("desde", "01/01/1900"));
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter("hasta", "01/01/1900"));
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
            
        private void btn_aplicar_filtro_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = OrdenDeTrabajoDAO.GetByFiltrosInforme(dtp_fecha_desde.Value.Date, dtp_fecha_hasta.Value.Date);

                if (tabla.Rows.Count > 0)
                {
                    OrdenTrabajoBindingSource.DataSource = tabla;

                    string filtro = "1=1";

                    if (rbt_todos.Checked == true)
                    {
                        filtro += "";
                    }
                    if (rbt_conDiferencias.Checked == true)
                    {
                        filtro += " and cantidad <> cantidadProducidaReal";
                    }

                    if (rbt_sinDif.Checked == true)
                    {
                        filtro += "and cantidad = cantidadProducidaReal";
                    }
                    if (txt_productos.Text != String.Empty)
                    {
                        filtro += " and (nombreIntermedio like '" + txt_productos.Text + "%' or nombreFinal like '" + txt_productos.Text + "%')";
                    }
                    if (txt_desc.Text != String.Empty)
                    {
                        filtro += " and ([observaciones] like '%" + txt_desc.Text + "%')";
                    }
                    

                    OrdenTrabajoBindingSource.Filter = filtro;
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter("desde", dtp_fecha_desde.Value.Date.ToString()));
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter("hasta", dtp_fecha_hasta.Value.Date.ToString()));
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
                txt_productos.Text = "";
                txt_desc.Text = "";
                dtp_fecha_desde.Value = DateTime.Now;
                OrdenTrabajoBindingSource.Filter = "";
                EmitirInformeOrdenTrabajo_Load(sender, e);
               

            }

            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        
    }
}
