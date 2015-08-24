namespace Vista
{
    partial class ConsultarOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarOrdenTrabajo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_OTproductosPadres = new System.Windows.Forms.DataGridView();
            this.idOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantiReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmaquinaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPadre = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_OTproductosHijos = new System.Windows.Forms.DataGridView();
            this.idOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaquin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maquinaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHija = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gp_filtros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OTproductosPadres)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OTproductosHijos)).BeginInit();
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
            this.gp_filtros.Location = new System.Drawing.Point(12, 446);
            this.gp_filtros.Name = "gp_filtros";
            this.gp_filtros.Size = new System.Drawing.Size(1102, 85);
            this.gp_filtros.TabIndex = 61;
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
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Periodo de Orden de Trabajo";
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
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Estado de la Orden de Trabajo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_imprimir);
            this.groupBox2.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_salir_consulta);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Location = new System.Drawing.Point(12, 537);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1102, 59);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Location = new System.Drawing.Point(907, 15);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(38, 38);
            this.btn_imprimir.TabIndex = 49;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_limpiar_filtros
            // 
            this.btn_limpiar_filtros.AutoSize = true;
            this.btn_limpiar_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar_filtros.Image = global::Vista.Properties.Resources.mop2;
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(828, 15);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 38);
            this.btn_limpiar_filtros.TabIndex = 48;
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros.Click += new System.EventHandler(this.btn_limpiar_filtros_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSize = true;
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_eliminar.Image = global::Vista.Properties.Resources.bin2;
            this.btn_eliminar.Location = new System.Drawing.Point(997, 15);
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
            this.btn_salir_consulta.Location = new System.Drawing.Point(1057, 15);
            this.btn_salir_consulta.Name = "btn_salir_consulta";
            this.btn_salir_consulta.Size = new System.Drawing.Size(38, 38);
            this.btn_salir_consulta.TabIndex = 46;
            this.btn_salir_consulta.UseVisualStyleBackColor = true;
            this.btn_salir_consulta.Click += new System.EventHandler(this.btn_salir_consulta_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo.Image = global::Vista.Properties.Resources.new10;
            this.btn_nuevo.Location = new System.Drawing.Point(951, 17);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 36);
            this.btn_nuevo.TabIndex = 45;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_OTproductosPadres);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 233);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenes de Trabajo";
            // 
            // dgv_OTproductosPadres
            // 
            this.dgv_OTproductosPadres.AllowUserToAddRows = false;
            this.dgv_OTproductosPadres.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_OTproductosPadres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_OTproductosPadres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_OTproductosPadres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_OTproductosPadres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OTproductosPadres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrden,
            this.fechaCreacion,
            this.horaInicio,
            this.horaFin,
            this.idProducto,
            this.nomProducto,
            this.cantidad,
            this.cantiReal,
            this.unidad,
            this.idEstado,
            this.Estado,
            this.idPlan,
            this.idmaquinaria,
            this.maquina,
            this.idEmpleado,
            this.nombre,
            this.btnPadre});
            this.dgv_OTproductosPadres.Location = new System.Drawing.Point(12, 19);
            this.dgv_OTproductosPadres.MultiSelect = false;
            this.dgv_OTproductosPadres.Name = "dgv_OTproductosPadres";
            this.dgv_OTproductosPadres.ReadOnly = true;
            this.dgv_OTproductosPadres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OTproductosPadres.Size = new System.Drawing.Size(1084, 208);
            this.dgv_OTproductosPadres.TabIndex = 49;
            this.dgv_OTproductosPadres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_OTproductosPadres_CellClick);
            this.dgv_OTproductosPadres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_OTproductosPadres_CellContentClick);
            // 
            // idOrden
            // 
            this.idOrden.HeaderText = "Nro Orden Trabajo";
            this.idOrden.Name = "idOrden";
            this.idOrden.ReadOnly = true;
            this.idOrden.Visible = false;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.HeaderText = "Fecha Creacion";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            this.fechaCreacion.Width = 98;
            // 
            // horaInicio
            // 
            this.horaInicio.HeaderText = "Hora Inicio";
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.ReadOnly = true;
            this.horaInicio.Width = 77;
            // 
            // horaFin
            // 
            this.horaFin.HeaderText = "Hora Fin";
            this.horaFin.Name = "horaFin";
            this.horaFin.ReadOnly = true;
            this.horaFin.Width = 67;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // nomProducto
            // 
            this.nomProducto.HeaderText = "Producto";
            this.nomProducto.Name = "nomProducto";
            this.nomProducto.ReadOnly = true;
            this.nomProducto.Width = 75;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad Planeada";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 112;
            // 
            // cantiReal
            // 
            this.cantiReal.HeaderText = "Cantidad Real";
            this.cantiReal.Name = "cantiReal";
            this.cantiReal.ReadOnly = true;
            this.cantiReal.Width = 91;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad de Medida";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            this.unidad.Width = 109;
            // 
            // idEstado
            // 
            this.idEstado.HeaderText = "Id Estado";
            this.idEstado.Name = "idEstado";
            this.idEstado.ReadOnly = true;
            this.idEstado.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // idPlan
            // 
            this.idPlan.HeaderText = "Id Plan";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            this.idPlan.Visible = false;
            // 
            // idmaquinaria
            // 
            this.idmaquinaria.HeaderText = "idMaquinaria";
            this.idmaquinaria.Name = "idmaquinaria";
            this.idmaquinaria.ReadOnly = true;
            this.idmaquinaria.Visible = false;
            // 
            // maquina
            // 
            this.maquina.HeaderText = "Maquinaria";
            this.maquina.Name = "maquina";
            this.maquina.ReadOnly = true;
            this.maquina.Width = 84;
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "idEmpleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Empleado";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 79;
            // 
            // btnPadre
            // 
            this.btnPadre.HeaderText = "";
            this.btnPadre.Name = "btnPadre";
            this.btnPadre.ReadOnly = true;
            this.btnPadre.Text = "Finalizar OT";
            this.btnPadre.UseColumnTextForButtonValue = true;
            this.btnPadre.Width = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_OTproductosHijos);
            this.groupBox3.Location = new System.Drawing.Point(12, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1102, 189);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de Orden de Trabajo";
            // 
            // dgv_OTproductosHijos
            // 
            this.dgv_OTproductosHijos.AllowUserToAddRows = false;
            this.dgv_OTproductosHijos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_OTproductosHijos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_OTproductosHijos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_OTproductosHijos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_OTproductosHijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OTproductosHijos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOT,
            this.fechaCreac,
            this.horaInicioDetalle,
            this.horaFinDetalle,
            this.idProd,
            this.poductoDetalle,
            this.cant,
            this.cantReal,
            this.unidadMedida,
            this.estadoDetalle,
            this.idMaquin,
            this.maquinaria,
            this.idEmp,
            this.empleado,
            this.idEstadoDetalle,
            this.btnHija});
            this.dgv_OTproductosHijos.Location = new System.Drawing.Point(6, 19);
            this.dgv_OTproductosHijos.MultiSelect = false;
            this.dgv_OTproductosHijos.Name = "dgv_OTproductosHijos";
            this.dgv_OTproductosHijos.ReadOnly = true;
            this.dgv_OTproductosHijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OTproductosHijos.Size = new System.Drawing.Size(1090, 164);
            this.dgv_OTproductosHijos.TabIndex = 50;
            this.dgv_OTproductosHijos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_OTproductosHijos_CellContentClick);
            this.dgv_OTproductosHijos.Click += new System.EventHandler(this.dgv_OTproductosHijos_Click);
            // 
            // idOT
            // 
            this.idOT.HeaderText = "idOrdenTrabajo";
            this.idOT.Name = "idOT";
            this.idOT.ReadOnly = true;
            this.idOT.Visible = false;
            // 
            // fechaCreac
            // 
            this.fechaCreac.HeaderText = "Fecha";
            this.fechaCreac.Name = "fechaCreac";
            this.fechaCreac.ReadOnly = true;
            this.fechaCreac.Width = 62;
            // 
            // horaInicioDetalle
            // 
            this.horaInicioDetalle.HeaderText = "Hora Inicio";
            this.horaInicioDetalle.Name = "horaInicioDetalle";
            this.horaInicioDetalle.ReadOnly = true;
            this.horaInicioDetalle.Width = 77;
            // 
            // horaFinDetalle
            // 
            this.horaFinDetalle.HeaderText = "Hora Fin";
            this.horaFinDetalle.Name = "horaFinDetalle";
            this.horaFinDetalle.ReadOnly = true;
            this.horaFinDetalle.Width = 67;
            // 
            // idProd
            // 
            this.idProd.HeaderText = "idProducto";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            this.idProd.Visible = false;
            // 
            // poductoDetalle
            // 
            this.poductoDetalle.HeaderText = "Producto";
            this.poductoDetalle.Name = "poductoDetalle";
            this.poductoDetalle.ReadOnly = true;
            this.poductoDetalle.Width = 75;
            // 
            // cant
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cant.DefaultCellStyle = dataGridViewCellStyle3;
            this.cant.HeaderText = "Cantidad Planeada";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            this.cant.Width = 112;
            // 
            // cantReal
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.cantReal.DefaultCellStyle = dataGridViewCellStyle4;
            this.cantReal.HeaderText = "Cantidad Real";
            this.cantReal.Name = "cantReal";
            this.cantReal.ReadOnly = true;
            this.cantReal.Width = 91;
            // 
            // unidadMedida
            // 
            this.unidadMedida.HeaderText = "Unidad Medida";
            this.unidadMedida.Name = "unidadMedida";
            this.unidadMedida.ReadOnly = true;
            this.unidadMedida.Width = 96;
            // 
            // estadoDetalle
            // 
            this.estadoDetalle.HeaderText = "Estado";
            this.estadoDetalle.Name = "estadoDetalle";
            this.estadoDetalle.ReadOnly = true;
            this.estadoDetalle.Width = 65;
            // 
            // idMaquin
            // 
            this.idMaquin.HeaderText = "idmaquinaria";
            this.idMaquin.Name = "idMaquin";
            this.idMaquin.ReadOnly = true;
            this.idMaquin.Visible = false;
            // 
            // maquinaria
            // 
            this.maquinaria.HeaderText = "Maquinaria";
            this.maquinaria.Name = "maquinaria";
            this.maquinaria.ReadOnly = true;
            this.maquinaria.Width = 84;
            // 
            // idEmp
            // 
            this.idEmp.HeaderText = "idEmpleado";
            this.idEmp.Name = "idEmp";
            this.idEmp.ReadOnly = true;
            this.idEmp.Visible = false;
            // 
            // empleado
            // 
            this.empleado.HeaderText = "Empleado";
            this.empleado.Name = "empleado";
            this.empleado.ReadOnly = true;
            this.empleado.Width = 79;
            // 
            // idEstadoDetalle
            // 
            this.idEstadoDetalle.HeaderText = "Id Estado ";
            this.idEstadoDetalle.Name = "idEstadoDetalle";
            this.idEstadoDetalle.ReadOnly = true;
            this.idEstadoDetalle.Visible = false;
            // 
            // btnHija
            // 
            this.btnHija.HeaderText = "";
            this.btnHija.Name = "btnHija";
            this.btnHija.ReadOnly = true;
            this.btnHija.Text = "Finalizar OT";
            this.btnHija.UseColumnTextForButtonValue = true;
            this.btnHija.Width = 5;
            // 
            // ConsultarOrdenTrabajo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1126, 605);
            this.Controls.Add(this.gp_filtros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarOrdenTrabajo";
            this.Text = "Consultar Orden Trabajo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultarOrdenTrabajo_FormClosed);
            this.Load += new System.EventHandler(this.ConsultarOrdenTrabajo_Load);
            this.gp_filtros.ResumeLayout(false);
            this.gp_filtros.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OTproductosPadres)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OTproductosHijos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_filtros;
        private System.Windows.Forms.DateTimePicker dtp_hasta_fin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_desde_fin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_aplicar_filtro;
        private System.Windows.Forms.ComboBox cmb_estado_plan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar_filtros;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir_consulta;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_OTproductosPadres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_OTproductosHijos;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantiReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmaquinaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewButtonColumn btnPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreac;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaquin;
        private System.Windows.Forms.DataGridViewTextBoxColumn maquinaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoDetalle;
        private System.Windows.Forms.DataGridViewButtonColumn btnHija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}