namespace Vista
{
    partial class Gestion_de_Pago_a_Proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_de_Pago_a_Proveedores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Orden_Compra = new System.Windows.Forms.DataGridView();
            this.idOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_detalle_orden_compra = new System.Windows.Forms.DataGridView();
            this.codProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_monto_desde = new System.Windows.Forms.TextBox();
            this.txt_monto_hasta = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_aplicar_filtro_empresa = new System.Windows.Forms.Button();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gp_filtros = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orden_Compra)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_orden_compra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gp_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Orden_Compra);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 264);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenes de Compra";
            // 
            // dgv_Orden_Compra
            // 
            this.dgv_Orden_Compra.AllowUserToAddRows = false;
            this.dgv_Orden_Compra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_Orden_Compra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Orden_Compra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Orden_Compra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Orden_Compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orden_Compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrden,
            this.fecOrden,
            this.razSoc,
            this.responsable,
            this.total,
            this.fecPago,
            this.estado,
            this.idEstado,
            this.opciones});
            this.dgv_Orden_Compra.Location = new System.Drawing.Point(6, 19);
            this.dgv_Orden_Compra.MultiSelect = false;
            this.dgv_Orden_Compra.Name = "dgv_Orden_Compra";
            this.dgv_Orden_Compra.ReadOnly = true;
            this.dgv_Orden_Compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Orden_Compra.Size = new System.Drawing.Size(917, 239);
            this.dgv_Orden_Compra.TabIndex = 49;
            this.dgv_Orden_Compra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Orden_Compra_CellClick);
            this.dgv_Orden_Compra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Orden_Compra_CellContentClick);
            // 
            // idOrden
            // 
            this.idOrden.HeaderText = "Nro Orden ";
            this.idOrden.Name = "idOrden";
            this.idOrden.ReadOnly = true;
            this.idOrden.Visible = false;
            // 
            // fecOrden
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fecOrden.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecOrden.HeaderText = "Fecha Orden";
            this.fecOrden.Name = "fecOrden";
            this.fecOrden.ReadOnly = true;
            // 
            // razSoc
            // 
            this.razSoc.HeaderText = "Razon Social";
            this.razSoc.Name = "razSoc";
            this.razSoc.ReadOnly = true;
            // 
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            // 
            // total
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle3;
            this.total.HeaderText = "Monto Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // fecPago
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.fecPago.DefaultCellStyle = dataGridViewCellStyle4;
            this.fecPago.HeaderText = "Fecha Pago";
            this.fecPago.Name = "fecPago";
            this.fecPago.ReadOnly = true;
            // 
            // Estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "Estado";
            this.estado.ReadOnly = true;
            // 
            // idEstado
            // 
            this.idEstado.HeaderText = "idEstado";
            this.idEstado.Name = "idEstado";
            this.idEstado.ReadOnly = true;
            this.idEstado.Visible = false;
            // 
            // opciones
            // 
            this.opciones.HeaderText = "Opciones";
            this.opciones.Name = "opciones";
            this.opciones.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_detalle_orden_compra);
            this.groupBox3.Location = new System.Drawing.Point(2, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(929, 189);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de Orden de Compra";
            // 
            // dgv_detalle_orden_compra
            // 
            this.dgv_detalle_orden_compra.AllowUserToAddRows = false;
            this.dgv_detalle_orden_compra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_detalle_orden_compra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_detalle_orden_compra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_detalle_orden_compra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalle_orden_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_orden_compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProd,
            this.nomProd,
            this.cant,
            this.unidad,
            this.precio,
            this.subTotal,
            this.idProd,
            this.idDetalle});
            this.dgv_detalle_orden_compra.Location = new System.Drawing.Point(6, 19);
            this.dgv_detalle_orden_compra.MultiSelect = false;
            this.dgv_detalle_orden_compra.Name = "dgv_detalle_orden_compra";
            this.dgv_detalle_orden_compra.ReadOnly = true;
            this.dgv_detalle_orden_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalle_orden_compra.Size = new System.Drawing.Size(913, 164);
            this.dgv_detalle_orden_compra.TabIndex = 50;
            // 
            // codProd
            // 
            this.codProd.HeaderText = "Codigo Producto";
            this.codProd.Name = "codProd";
            this.codProd.ReadOnly = true;
            // 
            // nomProd
            // 
            this.nomProd.HeaderText = "Nombre";
            this.nomProd.Name = "nomProd";
            this.nomProd.ReadOnly = true;
            // 
            // cant
            // 
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.cant.DefaultCellStyle = dataGridViewCellStyle6;
            this.cant.HeaderText = "Cantidad";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad de Medida";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // precio
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.precio.DefaultCellStyle = dataGridViewCellStyle7;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // subTotal
            // 
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.subTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // idProd
            // 
            this.idProd.HeaderText = "idProd";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            this.idProd.Visible = false;
            // 
            // idDetalle
            // 
            this.idDetalle.HeaderText = "idDetalle";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Controls.Add(this.btn_salir_consulta);
            this.groupBox2.Location = new System.Drawing.Point(2, 591);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(929, 59);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo.Image = global::Vista.Properties.Resources.mop2;
            this.btn_nuevo.Location = new System.Drawing.Point(842, 15);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 38);
            this.btn_nuevo.TabIndex = 48;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_salir_consulta
            // 
            this.btn_salir_consulta.AutoSize = true;
            this.btn_salir_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir_consulta.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir_consulta.Location = new System.Drawing.Point(885, 15);
            this.btn_salir_consulta.Name = "btn_salir_consulta";
            this.btn_salir_consulta.Size = new System.Drawing.Size(38, 38);
            this.btn_salir_consulta.TabIndex = 46;
            this.btn_salir_consulta.UseVisualStyleBackColor = true;
            this.btn_salir_consulta.Click += new System.EventHandler(this.btn_salir_consulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rango Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde";
            // 
            // dtp_desde
            // 
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(77, 41);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(96, 20);
            this.dtp_desde.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Hasta";
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(78, 66);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(95, 20);
            this.dtp_hasta.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Rango Monto Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Desde";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Hasta";
            // 
            // txt_monto_desde
            // 
            this.txt_monto_desde.Location = new System.Drawing.Point(581, 41);
            this.txt_monto_desde.MaxLength = 5;
            this.txt_monto_desde.Name = "txt_monto_desde";
            this.txt_monto_desde.Size = new System.Drawing.Size(100, 20);
            this.txt_monto_desde.TabIndex = 61;
            // 
            // txt_monto_hasta
            // 
            this.txt_monto_hasta.Location = new System.Drawing.Point(581, 66);
            this.txt_monto_hasta.MaxLength = 5;
            this.txt_monto_hasta.Name = "txt_monto_hasta";
            this.txt_monto_hasta.Size = new System.Drawing.Size(100, 20);
            this.txt_monto_hasta.TabIndex = 62;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(229, 66);
            this.txt_apellido.MaxLength = 25;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(95, 20);
            this.txt_apellido.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(229, 41);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(95, 20);
            this.txt_nombre.TabIndex = 64;
            // 
            // btn_aplicar_filtro_empresa
            // 
            this.btn_aplicar_filtro_empresa.AutoSize = true;
            this.btn_aplicar_filtro_empresa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro_empresa.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro_empresa.Location = new System.Drawing.Point(723, 44);
            this.btn_aplicar_filtro_empresa.Name = "btn_aplicar_filtro_empresa";
            this.btn_aplicar_filtro_empresa.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro_empresa.TabIndex = 71;
            this.btn_aplicar_filtro_empresa.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro_empresa.Click += new System.EventHandler(this.btn_aplicar_filtro_empresa_Click);
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(415, 66);
            this.txt_cuit.MaxLength = 8;
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(95, 20);
            this.txt_cuit.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "CUIT/CUIL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Razon Social";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Location = new System.Drawing.Point(415, 41);
            this.txt_razon_social.MaxLength = 25;
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(95, 20);
            this.txt_razon_social.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(569, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 16);
            this.label14.TabIndex = 77;
            this.label14.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(569, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 16);
            this.label15.TabIndex = 78;
            this.label15.Text = "$";
            // 
            // gp_filtros
            // 
            this.gp_filtros.Controls.Add(this.label15);
            this.gp_filtros.Controls.Add(this.label14);
            this.gp_filtros.Controls.Add(this.txt_razon_social);
            this.gp_filtros.Controls.Add(this.label8);
            this.gp_filtros.Controls.Add(this.label9);
            this.gp_filtros.Controls.Add(this.txt_cuit);
            this.gp_filtros.Controls.Add(this.btn_aplicar_filtro_empresa);
            this.gp_filtros.Controls.Add(this.txt_nombre);
            this.gp_filtros.Controls.Add(this.label10);
            this.gp_filtros.Controls.Add(this.label11);
            this.gp_filtros.Controls.Add(this.txt_apellido);
            this.gp_filtros.Controls.Add(this.txt_monto_hasta);
            this.gp_filtros.Controls.Add(this.txt_monto_desde);
            this.gp_filtros.Controls.Add(this.label7);
            this.gp_filtros.Controls.Add(this.label6);
            this.gp_filtros.Controls.Add(this.label5);
            this.gp_filtros.Controls.Add(this.dtp_hasta);
            this.gp_filtros.Controls.Add(this.label3);
            this.gp_filtros.Controls.Add(this.dtp_desde);
            this.gp_filtros.Controls.Add(this.label2);
            this.gp_filtros.Controls.Add(this.label1);
            this.gp_filtros.Location = new System.Drawing.Point(2, 468);
            this.gp_filtros.Name = "gp_filtros";
            this.gp_filtros.Size = new System.Drawing.Size(929, 107);
            this.gp_filtros.TabIndex = 61;
            this.gp_filtros.TabStop = false;
            this.gp_filtros.Text = "Filtros";
            // 
            // Gestion_de_Pago_a_Proveedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(935, 679);
            this.Controls.Add(this.gp_filtros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestion_de_Pago_a_Proveedores";
            this.Text = "Gestion de Pago a Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gestion_de_Pago_a_Proveedores_FormClosed);
            this.Load += new System.EventHandler(this.Gestion_de_Pago_a_Proveedores_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orden_Compra)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_orden_compra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gp_filtros.ResumeLayout(false);
            this.gp_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Orden_Compra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_detalle_orden_compra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_salir_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_monto_desde;
        private System.Windows.Forms.TextBox txt_monto_hasta;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_aplicar_filtro_empresa;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gp_filtros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn razSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewButtonColumn opciones;
    }
}