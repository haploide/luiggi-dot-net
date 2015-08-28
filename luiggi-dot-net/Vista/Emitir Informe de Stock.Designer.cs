namespace Vista
{
    partial class Emitir_Informe_de_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emitir_Informe_de_Stock));
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetInformeDeStock = new Vista.DataSetInformeDeStock();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_bajo = new System.Windows.Forms.CheckBox();
            this.btn_aplicar_filtro_unidad = new System.Windows.Forms.Button();
            this.cmb_unidad_filtro = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_cat_filtro = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInformeDeStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataMember = "Producto";
            this.ProductoBindingSource.DataSource = this.DataSetInformeDeStock;
            // 
            // DataSetInformeDeStock
            // 
            this.DataSetInformeDeStock.DataSetName = "DataSetInformeDeStock";
            this.DataSetInformeDeStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chk_bajo);
            this.groupBox1.Controls.Add(this.btn_aplicar_filtro_unidad);
            this.groupBox1.Controls.Add(this.cmb_unidad_filtro);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmb_cat_filtro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1198, 95);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chk_bajo
            // 
            this.chk_bajo.AutoSize = true;
            this.chk_bajo.Location = new System.Drawing.Point(361, 55);
            this.chk_bajo.Name = "chk_bajo";
            this.chk_bajo.Size = new System.Drawing.Size(78, 17);
            this.chk_bajo.TabIndex = 36;
            this.chk_bajo.Text = "Stock Bajo";
            this.chk_bajo.UseVisualStyleBackColor = true;
            // 
            // btn_aplicar_filtro_unidad
            // 
            this.btn_aplicar_filtro_unidad.AutoSize = true;
            this.btn_aplicar_filtro_unidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro_unidad.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro_unidad.Location = new System.Drawing.Point(516, 28);
            this.btn_aplicar_filtro_unidad.Name = "btn_aplicar_filtro_unidad";
            this.btn_aplicar_filtro_unidad.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro_unidad.TabIndex = 35;
            this.btn_aplicar_filtro_unidad.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro_unidad.Click += new System.EventHandler(this.btn_aplicar_filtro_unidad_Click);
            // 
            // cmb_unidad_filtro
            // 
            this.cmb_unidad_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unidad_filtro.FormattingEnabled = true;
            this.cmb_unidad_filtro.Location = new System.Drawing.Point(165, 53);
            this.cmb_unidad_filtro.Name = "cmb_unidad_filtro";
            this.cmb_unidad_filtro.Size = new System.Drawing.Size(121, 21);
            this.cmb_unidad_filtro.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Unidad de Medida";
            // 
            // cmb_cat_filtro
            // 
            this.cmb_cat_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat_filtro.FormattingEnabled = true;
            this.cmb_cat_filtro.Location = new System.Drawing.Point(9, 53);
            this.cmb_cat_filtro.Name = "cmb_cat_filtro";
            this.cmb_cat_filtro.Size = new System.Drawing.Size(121, 21);
            this.cmb_cat_filtro.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Categoria";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1196, 639);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.ReportInformeDeStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1190, 620);
            this.reportViewer1.TabIndex = 0;
            // 
            // Emitir_Informe_de_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 764);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emitir_Informe_de_Stock";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Informe de Stock";
            this.Load += new System.EventHandler(this.Emitir_Informe_de_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInformeDeStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_aplicar_filtro_unidad;
        private System.Windows.Forms.ComboBox cmb_unidad_filtro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_cat_filtro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private DataSetInformeDeStock DataSetInformeDeStock;
        private System.Windows.Forms.CheckBox chk_bajo;

    }
}