namespace Vista
{
    partial class EmitirPresupuesto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmitirPresupuesto));
            this.PresupuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPresupuesto = new Vista.DataSetPresupuesto();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.helpProviderEmitirPresupuesto = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPresupuesto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PresupuestoBindingSource
            // 
            this.PresupuestoBindingSource.DataMember = "Presupuesto";
            this.PresupuestoBindingSource.DataSource = this.DataSetPresupuesto;
            // 
            // DataSetPresupuesto
            // 
            this.DataSetPresupuesto.DataSetName = "DataSetPresupuesto";
            this.DataSetPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 531);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PresupuestoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.ReportPresupuesto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(651, 512);
            this.reportViewer1.TabIndex = 0;
            // 
            // helpProviderEmitirPresupuesto
            // 
            this.helpProviderEmitirPresupuesto.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // EmitirPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 545);
            this.Controls.Add(this.groupBox1);
            this.helpProviderEmitirPresupuesto.SetHelpKeyword(this, "34");
            this.helpProviderEmitirPresupuesto.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmitirPresupuesto";
            this.helpProviderEmitirPresupuesto.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Emitir Presupuesto";
            this.Load += new System.EventHandler(this.EmitirPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPresupuesto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PresupuestoBindingSource;
        private DataSetPresupuesto DataSetPresupuesto;
        private System.Windows.Forms.HelpProvider helpProviderEmitirPresupuesto;
    }
}