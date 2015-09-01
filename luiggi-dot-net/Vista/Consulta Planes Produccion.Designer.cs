namespace Vista
{
    partial class Consulta_Planes_Produccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Planes_Produccion));
            this.gp_filtros = new System.Windows.Forms.GroupBox();
            this.dtp_hasta_fin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_desde_fin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_aplicar_filtro = new System.Windows.Forms.Button();
            this.cmb_estado_plan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_planes = new System.Windows.Forms.DataGridView();
            this.nroPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_detalle_plan = new System.Windows.Forms.DataGridView();
            this.codProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPLan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helpProviderConsultaPlanProduccion = new System.Windows.Forms.HelpProvider();
            this.gp_filtros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planes)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_plan)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_filtros
            // 
            this.gp_filtros.Controls.Add(this.dtp_hasta_fin);
            this.gp_filtros.Controls.Add(this.label5);
            this.gp_filtros.Controls.Add(this.dtp_desde_fin);
            this.gp_filtros.Controls.Add(this.label6);
            this.gp_filtros.Controls.Add(this.label7);
            this.gp_filtros.Controls.Add(this.btn_aplicar_filtro);
            this.gp_filtros.Controls.Add(this.cmb_estado_plan);
            this.gp_filtros.Controls.Add(this.label4);
            this.gp_filtros.Location = new System.Drawing.Point(12, 440);
            this.gp_filtros.Name = "gp_filtros";
            this.gp_filtros.Size = new System.Drawing.Size(628, 85);
            this.gp_filtros.TabIndex = 57;
            this.gp_filtros.TabStop = false;
            this.gp_filtros.Text = "Filtros";
            // 
            // dtp_hasta_fin
            // 
            this.dtp_hasta_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta_fin.Location = new System.Drawing.Point(235, 44);
            this.dtp_hasta_fin.Name = "dtp_hasta_fin";
            this.dtp_hasta_fin.Size = new System.Drawing.Size(95, 20);
            this.dtp_hasta_fin.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Hasta";
            // 
            // dtp_desde_fin
            // 
            this.dtp_desde_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde_fin.Location = new System.Drawing.Point(81, 44);
            this.dtp_desde_fin.Name = "dtp_desde_fin";
            this.dtp_desde_fin.Size = new System.Drawing.Size(96, 20);
            this.dtp_desde_fin.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Desde";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Periodo Planificacion";
            // 
            // btn_aplicar_filtro
            // 
            this.btn_aplicar_filtro.AutoSize = true;
            this.btn_aplicar_filtro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro.Location = new System.Drawing.Point(584, 23);
            this.btn_aplicar_filtro.Name = "btn_aplicar_filtro";
            this.btn_aplicar_filtro.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro.TabIndex = 71;
            this.btn_aplicar_filtro.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro.Click += new System.EventHandler(this.btn_aplicar_filtro_Click);
            // 
            // cmb_estado_plan
            // 
            this.cmb_estado_plan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado_plan.FormattingEnabled = true;
            this.cmb_estado_plan.Location = new System.Drawing.Point(380, 48);
            this.cmb_estado_plan.Name = "cmb_estado_plan";
            this.cmb_estado_plan.Size = new System.Drawing.Size(153, 21);
            this.cmb_estado_plan.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Estado del Plan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_salir_consulta);
            this.groupBox2.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox2.Location = new System.Drawing.Point(12, 531);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 59);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo.Image = global::Vista.Properties.Resources.mop2;
            this.btn_nuevo.Location = new System.Drawing.Point(355, 15);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 38);
            this.btn_nuevo.TabIndex = 48;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSize = true;
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_eliminar.Image = global::Vista.Properties.Resources.bin2;
            this.btn_eliminar.Location = new System.Drawing.Point(524, 15);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(38, 38);
            this.btn_eliminar.TabIndex = 47;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Visible = false;
            // 
            // btn_salir_consulta
            // 
            this.btn_salir_consulta.AutoSize = true;
            this.btn_salir_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir_consulta.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir_consulta.Location = new System.Drawing.Point(584, 15);
            this.btn_salir_consulta.Name = "btn_salir_consulta";
            this.btn_salir_consulta.Size = new System.Drawing.Size(38, 38);
            this.btn_salir_consulta.TabIndex = 46;
            this.btn_salir_consulta.UseVisualStyleBackColor = true;
            this.btn_salir_consulta.Click += new System.EventHandler(this.btn_salir_consulta_Click);
            // 
            // btn_limpiar_filtros
            // 
            this.btn_limpiar_filtros.AutoSize = true;
            this.btn_limpiar_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar_filtros.Image = global::Vista.Properties.Resources.new10;
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(478, 15);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 36);
            this.btn_limpiar_filtros.TabIndex = 45;
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros.Click += new System.EventHandler(this.btn_limpiar_filtros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_planes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 233);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planes";
            // 
            // dgv_planes
            // 
            this.dgv_planes.AllowUserToAddRows = false;
            this.dgv_planes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_planes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_planes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_planes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_planes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroPlan,
            this.fecCreacion,
            this.Estado,
            this.fechaInicio,
            this.fechaFinal});
            this.dgv_planes.Location = new System.Drawing.Point(6, 19);
            this.dgv_planes.MultiSelect = false;
            this.dgv_planes.Name = "dgv_planes";
            this.dgv_planes.ReadOnly = true;
            this.dgv_planes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_planes.Size = new System.Drawing.Size(616, 208);
            this.dgv_planes.TabIndex = 49;
            this.dgv_planes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_planes_CellClick);
            this.dgv_planes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_planes_CellDoubleClick);
            // 
            // nroPlan
            // 
            this.nroPlan.HeaderText = "Numero de Plan";
            this.nroPlan.Name = "nroPlan";
            this.nroPlan.ReadOnly = true;
            // 
            // fecCreacion
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fecCreacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecCreacion.HeaderText = "Fecha Creacion";
            this.fecCreacion.Name = "fecCreacion";
            this.fecCreacion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // fechaInicio
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.fechaInicio.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaInicio.HeaderText = "Fecha Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // fechaFinal
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.fechaFinal.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaFinal.HeaderText = "Fecha Finalización";
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_detalle_plan);
            this.groupBox3.Location = new System.Drawing.Point(12, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 183);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de Plan";
            // 
            // dgv_detalle_plan
            // 
            this.dgv_detalle_plan.AllowUserToAddRows = false;
            this.dgv_detalle_plan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_detalle_plan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_detalle_plan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalle_plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_plan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProd,
            this.nomProd,
            this.unidad,
            this.cantPLan,
            this.cantPedido,
            this.cant,
            this.fechaProd});
            this.dgv_detalle_plan.Location = new System.Drawing.Point(6, 19);
            this.dgv_detalle_plan.MultiSelect = false;
            this.dgv_detalle_plan.Name = "dgv_detalle_plan";
            this.dgv_detalle_plan.ReadOnly = true;
            this.dgv_detalle_plan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalle_plan.Size = new System.Drawing.Size(616, 164);
            this.dgv_detalle_plan.TabIndex = 50;
            // 
            // codProd
            // 
            this.codProd.HeaderText = "Codigo Producto";
            this.codProd.Name = "codProd";
            this.codProd.ReadOnly = true;
            this.codProd.Visible = false;
            // 
            // nomProd
            // 
            this.nomProd.HeaderText = "Nombre";
            this.nomProd.Name = "nomProd";
            this.nomProd.ReadOnly = true;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad de Medida";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // cantPLan
            // 
            this.cantPLan.HeaderText = "Cantidad Planificada";
            this.cantPLan.Name = "cantPLan";
            this.cantPLan.ReadOnly = true;
            // 
            // cantPedido
            // 
            this.cantPedido.HeaderText = "Cantidad De Pedidos";
            this.cantPedido.Name = "cantPedido";
            this.cantPedido.ReadOnly = true;
            // 
            // cant
            // 
            this.cant.HeaderText = "Cantidad Total a Producir";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            // 
            // fechaProd
            // 
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.fechaProd.DefaultCellStyle = dataGridViewCellStyle6;
            this.fechaProd.HeaderText = "Fecha de Producción";
            this.fechaProd.Name = "fechaProd";
            this.fechaProd.ReadOnly = true;
            // 
            // helpProviderConsultaPlanProduccion
            // 
            this.helpProviderConsultaPlanProduccion.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // Consulta_Planes_Produccion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(652, 597);
            this.Controls.Add(this.gp_filtros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.helpProviderConsultaPlanProduccion.SetHelpKeyword(this, "13");
            this.helpProviderConsultaPlanProduccion.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_Planes_Produccion";
            this.helpProviderConsultaPlanProduccion.SetShowHelp(this, true);
            this.Text = "Consulta Planes Produccion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consulta_Planes_Produccion_FormClosed);
            this.Load += new System.EventHandler(this.Consulta_Planes_Produccion_Load);
            this.gp_filtros.ResumeLayout(false);
            this.gp_filtros.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_plan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_filtros;
        private System.Windows.Forms.Button btn_aplicar_filtro;
        private System.Windows.Forms.ComboBox cmb_estado_plan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir_consulta;
        private System.Windows.Forms.Button btn_limpiar_filtros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_planes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_detalle_plan;
        private System.Windows.Forms.DateTimePicker dtp_hasta_fin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_desde_fin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPLan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.HelpProvider helpProviderConsultaPlanProduccion;
    }
}