namespace Vista
{
    partial class Emitir_Orden_De_Trabajo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emitir_Orden_De_Trabajo));
            this.OrdenDeTrabajoIntermediasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetOrdenDeTrabajo = new Vista.DataSetOrdenDeTrabajo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenDeTrabajoIntermediasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenDeTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdenDeTrabajoIntermediasBindingSource
            // 
            this.OrdenDeTrabajoIntermediasBindingSource.DataMember = "OrdenDeTrabajoIntermedias";
            this.OrdenDeTrabajoIntermediasBindingSource.DataSource = this.DataSetOrdenDeTrabajo;
            // 
            // DataSetOrdenDeTrabajo
            // 
            this.DataSetOrdenDeTrabajo.DataSetName = "DataSetOrdenDeTrabajo";
            this.DataSetOrdenDeTrabajo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrdenDeTrabajoIntermediasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.OrdenDeTrabajo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(713, 664);
            this.reportViewer1.TabIndex = 0;
            // 
            // Emitir_Orden_De_Trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 664);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emitir_Orden_De_Trabajo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Emitir Orden De Trabajo";
            this.Load += new System.EventHandler(this.Emitir_Orden_De_Trabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenDeTrabajoIntermediasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenDeTrabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetOrdenDeTrabajo DataSetOrdenDeTrabajo;
        private System.Windows.Forms.BindingSource OrdenDeTrabajoIntermediasBindingSource;
    }
}