namespace Vista
{
    partial class Emitir_Informe_de_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emitir_Informe_de_Ventas));
            this.VolumenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetInformeVolumenVentas = new Vista.DataSetInformeVolumenVentas();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aplicar_filtro = new System.Windows.Forms.Button();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_desde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.VolumenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInformeVolumenVentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VolumenBindingSource
            // 
            this.VolumenBindingSource.DataMember = "Volumen";
            this.VolumenBindingSource.DataSource = this.DataSetInformeVolumenVentas;
            // 
            // DataSetInformeVolumenVentas
            // 
            this.DataSetInformeVolumenVentas.DataSetName = "DataSetInformeVolumenVentas";
            this.DataSetInformeVolumenVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(952, 619);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VolumenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.ReportInformeVolumenVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(946, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_aplicar_filtro);
            this.groupBox1.Controls.Add(this.dtp_fecha_hasta);
            this.groupBox1.Controls.Add(this.dtp_fecha_desde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha Desde";
            // 
            // btn_aplicar_filtro
            // 
            this.btn_aplicar_filtro.AutoSize = true;
            this.btn_aplicar_filtro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro.Location = new System.Drawing.Point(258, 30);
            this.btn_aplicar_filtro.Name = "btn_aplicar_filtro";
            this.btn_aplicar_filtro.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro.TabIndex = 36;
            this.btn_aplicar_filtro.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro.Click += new System.EventHandler(this.btn_aplicar_filtro_Click);
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.CustomFormat = "MM/yyyy";
            this.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(107, 56);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(96, 20);
            this.dtp_fecha_hasta.TabIndex = 1;
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.CustomFormat = "MM/yyyy";
            this.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_desde.Location = new System.Drawing.Point(107, 30);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(96, 20);
            this.dtp_fecha_desde.TabIndex = 0;
            // 
            // Emitir_Informe_de_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emitir_Informe_de_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Informe de Ventas";
            this.Load += new System.EventHandler(this.Emitir_Informe_de_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolumenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInformeVolumenVentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VolumenBindingSource;
        private DataSetInformeVolumenVentas DataSetInformeVolumenVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aplicar_filtro;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hasta;
        private System.Windows.Forms.DateTimePicker dtp_fecha_desde;
    }
}