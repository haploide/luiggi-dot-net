namespace Vista
{
    partial class EmitirInformeOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmitirInformeOrdenTrabajo));
            this.OrdenTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetInformeOrdenTrabajo = new Vista.DataSetInformeOrdenTrabajo();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aplicar_filtro = new System.Windows.Forms.Button();
            this.dtp_fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.helpProviderEmitirInformeOrdenesDeTrabajo = new System.Windows.Forms.HelpProvider();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_productos = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbt_sinDif = new System.Windows.Forms.RadioButton();
            this.rbt_conDiferencias = new System.Windows.Forms.RadioButton();
            this.rbt_todos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenTrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInformeOrdenTrabajo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdenTrabajoBindingSource
            // 
            this.OrdenTrabajoBindingSource.DataMember = "OrdenTrabajo";
            this.OrdenTrabajoBindingSource.DataSource = this.DataSetInformeOrdenTrabajo;
            // 
            // DataSetInformeOrdenTrabajo
            // 
            this.DataSetInformeOrdenTrabajo.DataSetName = "DataSetInformeOrdenTrabajo";
            this.DataSetInformeOrdenTrabajo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_desc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_productos);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dtp_fecha_hasta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_aplicar_filtro);
            this.groupBox2.Controls.Add(this.dtp_fecha_desde);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(83, 43);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(96, 20);
            this.dtp_fecha_hasta.TabIndex = 39;
            this.dtp_fecha_hasta.ValueChanged += new System.EventHandler(this.dtp_fecha_hasta_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
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
            this.btn_aplicar_filtro.Location = new System.Drawing.Point(364, 17);
            this.btn_aplicar_filtro.Name = "btn_aplicar_filtro";
            this.btn_aplicar_filtro.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro.TabIndex = 36;
            this.btn_aplicar_filtro.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro.Click += new System.EventHandler(this.btn_aplicar_filtro_Click);
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.CustomFormat = "";
            this.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_desde.Location = new System.Drawing.Point(83, 17);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(96, 20);
            this.dtp_fecha_desde.TabIndex = 0;
            this.dtp_fecha_desde.ValueChanged += new System.EventHandler(this.dtp_fecha_desde_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 664);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrdenTrabajoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista.Reportes.ReportInformeOrdenTrabajo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(976, 645);
            this.reportViewer1.TabIndex = 0;
            // 
            // helpProviderEmitirInformeOrdenesDeTrabajo
            // 
            this.helpProviderEmitirInformeOrdenesDeTrabajo.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // btn_limpiar_filtros
            // 
            this.btn_limpiar_filtros.AutoSize = true;
            this.btn_limpiar_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar_filtros.Image = global::Vista.Properties.Resources.mop2;
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(364, 75);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 38);
            this.btn_limpiar_filtros.TabIndex = 44;
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros.Click += new System.EventHandler(this.btn_limpiar_filtros_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Productos";
            // 
            // txt_productos
            // 
            this.txt_productos.Location = new System.Drawing.Point(83, 69);
            this.txt_productos.Name = "txt_productos";
            this.txt_productos.Size = new System.Drawing.Size(100, 20);
            this.txt_productos.TabIndex = 42;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbt_sinDif);
            this.groupBox3.Controls.Add(this.rbt_conDiferencias);
            this.groupBox3.Controls.Add(this.rbt_todos);
            this.groupBox3.Location = new System.Drawing.Point(206, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 91);
            this.groupBox3.TabIndex = 43;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Descripción";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(83, 95);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(100, 20);
            this.txt_desc.TabIndex = 49;
            // 
            // EmitirInformeOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 822);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.helpProviderEmitirInformeOrdenesDeTrabajo.SetHelpKeyword(this, "44");
            this.helpProviderEmitirInformeOrdenesDeTrabajo.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmitirInformeOrdenTrabajo";
            this.helpProviderEmitirInformeOrdenesDeTrabajo.SetShowHelp(this, true);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Informe Ordenes de Trabajo";
            this.Load += new System.EventHandler(this.EmitirInformeOrdenTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInformeOrdenTrabajo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aplicar_filtro;
        private System.Windows.Forms.DateTimePicker dtp_fecha_desde;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdenTrabajoBindingSource;
        private DataSetInformeOrdenTrabajo DataSetInformeOrdenTrabajo;
        private System.Windows.Forms.HelpProvider helpProviderEmitirInformeOrdenesDeTrabajo;
        private System.Windows.Forms.Button btn_limpiar_filtros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_productos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbt_sinDif;
        private System.Windows.Forms.RadioButton rbt_conDiferencias;
        private System.Windows.Forms.RadioButton rbt_todos;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label4;

    }
}