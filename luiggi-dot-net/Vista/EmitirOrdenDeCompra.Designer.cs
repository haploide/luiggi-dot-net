namespace Vista
{
    partial class EmitirOrdenDeCompra
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetOrdenDeCompra = new Vista.DataSetOrdenDeCompra();
            this.OrdenDeCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenDeCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenDeCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.OrdenDeCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.ReportOrdenDeCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(698, 608);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetOrdenDeCompra
            // 
            this.DataSetOrdenDeCompra.DataSetName = "DataSetOrdenDeCompra";
            this.DataSetOrdenDeCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdenDeCompraBindingSource
            // 
            this.OrdenDeCompraBindingSource.DataMember = "OrdenDeCompra";
            this.OrdenDeCompraBindingSource.DataSource = this.DataSetOrdenDeCompra;
            // 
            // EmitirOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 608);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmitirOrdenDeCompra";
            this.Text = "Emitir Orden de Compra";
            this.Load += new System.EventHandler(this.EmitirOrdenDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenDeCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenDeCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdenDeCompraBindingSource;
        private DataSetOrdenDeCompra DataSetOrdenDeCompra;
    }
}