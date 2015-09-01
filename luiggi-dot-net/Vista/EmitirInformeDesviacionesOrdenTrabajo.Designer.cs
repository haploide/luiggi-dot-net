namespace Vista
{
    partial class EmitirInformeDesviacionesOrdenTrabajo
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
            this.OrdenDeTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetInformeDesviacionesOrdenesDeTrabajo = new Vista.DataSetInformeDesviacionesOrdenesDeTrabajo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aplicar_filtro = new System.Windows.Forms.Button();
            this.dtp_fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.helpProviderEmitirInformeDesviacionesOrdenTrabajo = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenDeTrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInformeDesviacionesOrdenesDeTrabajo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdenDeTrabajoBindingSource
            // 
            this.OrdenDeTrabajoBindingSource.DataMember = "OrdenDeTrabajo";
            this.OrdenDeTrabajoBindingSource.DataSource = this.DataSetInformeDesviacionesOrdenesDeTrabajo;
            // 
            // DataSetInformeDesviacionesOrdenesDeTrabajo
            // 
            this.DataSetInformeDesviacionesOrdenesDeTrabajo.DataSetName = "DataSetInformeDesviacionesOrdenesDeTrabajo";
            this.DataSetInformeDesviacionesOrdenesDeTrabajo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 708);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrdenDeTrabajoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.ReportInformeDesviacionesOrdenTrabajo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(928, 689);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_aplicar_filtro);
            this.groupBox2.Controls.Add(this.dtp_fecha_desde);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(931, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Año";
            // 
            // btn_aplicar_filtro
            // 
            this.btn_aplicar_filtro.AutoSize = true;
            this.btn_aplicar_filtro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro.Location = new System.Drawing.Point(111, 10);
            this.btn_aplicar_filtro.Name = "btn_aplicar_filtro";
            this.btn_aplicar_filtro.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro.TabIndex = 41;
            this.btn_aplicar_filtro.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro.Click += new System.EventHandler(this.btn_aplicar_filtro_Click);
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.CustomFormat = "yyyy";
            this.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_desde.Location = new System.Drawing.Point(38, 21);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(67, 20);
            this.dtp_fecha_desde.TabIndex = 39;
            this.dtp_fecha_desde.ValueChanged += new System.EventHandler(this.dtp_fecha_desde_ValueChanged);
            // 
            // helpProviderEmitirInformeDesviacionesOrdenTrabajo
            // 
            this.helpProviderEmitirInformeDesviacionesOrdenTrabajo.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // EmitirInformeDesviacionesOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.helpProviderEmitirInformeDesviacionesOrdenTrabajo.SetHelpKeyword(this, "42");
            this.helpProviderEmitirInformeDesviacionesOrdenTrabajo.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Name = "EmitirInformeDesviacionesOrdenTrabajo";
            this.helpProviderEmitirInformeDesviacionesOrdenTrabajo.SetShowHelp(this, true);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Informe Desviaciones Orden Trabajo";
            this.Load += new System.EventHandler(this.EmitirInformeDesviacionesOrdenTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenDeTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInformeDesviacionesOrdenesDeTrabajo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aplicar_filtro;
        private System.Windows.Forms.DateTimePicker dtp_fecha_desde;
        private System.Windows.Forms.BindingSource OrdenDeTrabajoBindingSource;
        private DataSetInformeDesviacionesOrdenesDeTrabajo DataSetInformeDesviacionesOrdenesDeTrabajo;
        private System.Windows.Forms.HelpProvider helpProviderEmitirInformeDesviacionesOrdenTrabajo;
    }
}