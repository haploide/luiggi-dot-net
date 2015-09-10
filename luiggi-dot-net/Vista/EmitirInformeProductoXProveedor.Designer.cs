namespace Vista
{
    partial class EmitirInformeProductoXProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmitirInformeProductoXProveedor));
            this.ProductoXProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.btn_aplicar_filtro_unidad = new System.Windows.Forms.Button();
            this.cmb_unidad_filtro = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_cat_filtro = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoXProveedorBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductoXProveedorBindingSource
            // 
            this.ProductoXProveedorBindingSource.DataMember = "ProductoXProveedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_producto);
            this.groupBox1.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_proveedor);
            this.groupBox1.Controls.Add(this.btn_aplicar_filtro_unidad);
            this.groupBox1.Controls.Add(this.cmb_unidad_filtro);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmb_cat_filtro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 80);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Producto:";
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(80, 19);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(100, 20);
            this.txt_producto.TabIndex = 45;
            // 
            // btn_limpiar_filtros
            // 
            this.btn_limpiar_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar_filtros.AutoSize = true;
            this.btn_limpiar_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar_filtros.Image = global::Vista.Properties.Resources.mop2;
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(863, 24);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 38);
            this.btn_limpiar_filtros.TabIndex = 43;
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Proveedor:";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Location = new System.Drawing.Point(80, 49);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(100, 20);
            this.txt_proveedor.TabIndex = 42;
            // 
            // btn_aplicar_filtro_unidad
            // 
            this.btn_aplicar_filtro_unidad.AutoSize = true;
            this.btn_aplicar_filtro_unidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro_unidad.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro_unidad.Location = new System.Drawing.Point(439, 19);
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
            this.cmb_unidad_filtro.Location = new System.Drawing.Point(302, 19);
            this.cmb_unidad_filtro.Name = "cmb_unidad_filtro";
            this.cmb_unidad_filtro.Size = new System.Drawing.Size(121, 21);
            this.cmb_unidad_filtro.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Unidad de Medida";
            // 
            // cmb_cat_filtro
            // 
            this.cmb_cat_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat_filtro.FormattingEnabled = true;
            this.cmb_cat_filtro.Location = new System.Drawing.Point(302, 46);
            this.cmb_cat_filtro.Name = "cmb_cat_filtro";
            this.cmb_cat_filtro.Size = new System.Drawing.Size(121, 21);
            this.cmb_cat_filtro.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 49);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 579);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductoXProveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.ReportInformeProductoXProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(901, 560);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmitirInformeProductoXProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 689);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmitirInformeProductoXProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Informe Producto/Proveedor";
            this.Load += new System.EventHandler(this.EmitirInformeProductoXProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoXProveedorBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Button btn_limpiar_filtros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductoXProveedorBindingSource;
        private DataSetInformeProductosXProveedor DataSetInformeProductosXProveedor;
    }
}