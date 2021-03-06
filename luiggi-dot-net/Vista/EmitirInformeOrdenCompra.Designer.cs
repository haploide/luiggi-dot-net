﻿namespace Vista
{
    partial class EmitirInformeOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmitirInformeOrdenCompra));
            this.InformeOrdenCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetInformeOrdenCompra = new Vista.DataSetInformeOrdenCompra();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbt_sinDif = new System.Windows.Forms.RadioButton();
            this.rbt_conDiferencias = new System.Windows.Forms.RadioButton();
            this.rbt_todos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aplicar_filtro = new System.Windows.Forms.Button();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetOrdenDeCompra = new Vista.DataSetOrdenDeCompra();
            this.OrdenDeCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpProviderEmitirInformeOrdenesDeCompra = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.InformeOrdenCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInformeOrdenCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenDeCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenDeCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InformeOrdenCompraBindingSource
            // 
            this.InformeOrdenCompraBindingSource.DataMember = "OrdenCompra";
            this.InformeOrdenCompraBindingSource.DataSource = this.DataSetInformeOrdenCompra;
            // 
            // DataSetInformeOrdenCompra
            // 
            this.DataSetInformeOrdenCompra.DataSetName = "DataSetInformeOrdenCompra";
            this.DataSetInformeOrdenCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_proveedor);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_aplicar_filtro);
            this.groupBox1.Controls.Add(this.dtp_fecha_hasta);
            this.groupBox1.Controls.Add(this.dtp_fecha_desde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btn_limpiar_filtros
            // 
            this.btn_limpiar_filtros.AutoSize = true;
            this.btn_limpiar_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar_filtros.Image = global::Vista.Properties.Resources.mop2;
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(351, 73);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 38);
            this.btn_limpiar_filtros.TabIndex = 6;
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros.Click += new System.EventHandler(this.btn_limpiar_filtros_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Proveedor:";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Location = new System.Drawing.Point(80, 82);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(100, 20);
            this.txt_proveedor.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbt_sinDif);
            this.groupBox3.Controls.Add(this.rbt_conDiferencias);
            this.groupBox3.Controls.Add(this.rbt_todos);
            this.groupBox3.Location = new System.Drawing.Point(207, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 91);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar Ordenes";
            // 
            // rbt_sinDif
            // 
            this.rbt_sinDif.AutoSize = true;
            this.rbt_sinDif.Location = new System.Drawing.Point(6, 65);
            this.rbt_sinDif.Name = "rbt_sinDif";
            this.rbt_sinDif.Size = new System.Drawing.Size(96, 17);
            this.rbt_sinDif.TabIndex = 2;
            this.rbt_sinDif.Text = "Sin Diferencias";
            this.rbt_sinDif.UseVisualStyleBackColor = true;
            // 
            // rbt_conDiferencias
            // 
            this.rbt_conDiferencias.AutoSize = true;
            this.rbt_conDiferencias.Location = new System.Drawing.Point(6, 42);
            this.rbt_conDiferencias.Name = "rbt_conDiferencias";
            this.rbt_conDiferencias.Size = new System.Drawing.Size(100, 17);
            this.rbt_conDiferencias.TabIndex = 1;
            this.rbt_conDiferencias.Text = "Con Diferencias";
            this.rbt_conDiferencias.UseVisualStyleBackColor = true;
            // 
            // rbt_todos
            // 
            this.rbt_todos.AutoSize = true;
            this.rbt_todos.Checked = true;
            this.rbt_todos.Location = new System.Drawing.Point(6, 19);
            this.rbt_todos.Name = "rbt_todos";
            this.rbt_todos.Size = new System.Drawing.Size(55, 17);
            this.rbt_todos.TabIndex = 0;
            this.rbt_todos.TabStop = true;
            this.rbt_todos.Text = "Todas";
            this.rbt_todos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
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
            this.btn_aplicar_filtro.Location = new System.Drawing.Point(351, 23);
            this.btn_aplicar_filtro.Name = "btn_aplicar_filtro";
            this.btn_aplicar_filtro.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro.TabIndex = 5;
            this.btn_aplicar_filtro.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro.Click += new System.EventHandler(this.btn_aplicar_filtro_Click);
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.CustomFormat = "";
            this.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(80, 54);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(96, 20);
            this.dtp_fecha_hasta.TabIndex = 2;
            this.dtp_fecha_hasta.ValueChanged += new System.EventHandler(this.dtp_fecha_hasta_ValueChanged);
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.CustomFormat = "";
            this.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_desde.Location = new System.Drawing.Point(80, 28);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(96, 20);
            this.dtp_fecha_desde.TabIndex = 1;
            this.dtp_fecha_desde.ValueChanged += new System.EventHandler(this.dtp_fecha_desde_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 605);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.InformeOrdenCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.ReportInformeOrdenCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(856, 586);
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
            // helpProviderEmitirInformeOrdenesDeCompra
            // 
            this.helpProviderEmitirInformeOrdenesDeCompra.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // EmitirInformeOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 780);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.helpProviderEmitirInformeOrdenesDeCompra.SetHelpKeyword(this, "43");
            this.helpProviderEmitirInformeOrdenesDeCompra.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmitirInformeOrdenCompra";
            this.helpProviderEmitirInformeOrdenesDeCompra.SetShowHelp(this, true);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Informe Ordenes de Compras";
            this.Load += new System.EventHandler(this.EmitirInformeOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InformeOrdenCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInformeOrdenCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetOrdenDeCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenDeCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aplicar_filtro;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hasta;
        private System.Windows.Forms.DateTimePicker dtp_fecha_desde;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdenDeCompraBindingSource;
        private DataSetOrdenDeCompra DataSetOrdenDeCompra;
        private System.Windows.Forms.BindingSource InformeOrdenCompraBindingSource;
        private DataSetInformeOrdenCompra DataSetInformeOrdenCompra;
        private System.Windows.Forms.HelpProvider helpProviderEmitirInformeOrdenesDeCompra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbt_todos;
        private System.Windows.Forms.RadioButton rbt_conDiferencias;
        private System.Windows.Forms.RadioButton rbt_sinDif;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_limpiar_filtros;
    }
}