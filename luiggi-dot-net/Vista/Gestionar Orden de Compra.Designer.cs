namespace Vista
{
    partial class Gestionar_Orden_de_Compra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_proveedores = new System.Windows.Forms.ComboBox();
            this.dtp_creacion_OT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.txt_monto_total = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stcokRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockReservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockFaltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contacto = new System.Windows.Forms.TextBox();
            this.helpProviderGestionOrdenDeCompra = new System.Windows.Forms.HelpProvider();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Location = new System.Drawing.Point(12, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 66);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir.Location = new System.Drawing.Point(589, 19);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(38, 38);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Image = global::Vista.Properties.Resources.floppy1;
            this.btn_guardar.Location = new System.Drawing.Point(472, 19);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(38, 38);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo.Image = global::Vista.Properties.Resources.mop2;
            this.btn_nuevo.Location = new System.Drawing.Point(428, 19);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 38);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_proveedores);
            this.panel1.Location = new System.Drawing.Point(13, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 46);
            this.panel1.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Proveedor:";
            // 
            // cmb_proveedores
            // 
            this.cmb_proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_proveedores.FormattingEnabled = true;
            this.cmb_proveedores.Location = new System.Drawing.Point(104, 12);
            this.cmb_proveedores.Name = "cmb_proveedores";
            this.cmb_proveedores.Size = new System.Drawing.Size(213, 21);
            this.cmb_proveedores.TabIndex = 65;
            this.cmb_proveedores.SelectedIndexChanged += new System.EventHandler(this.cmb_proveedores_SelectedIndexChanged);
            this.cmb_proveedores.SelectionChangeCommitted += new System.EventHandler(this.cmb_proveedores_SelectionChangeCommitted);
            // 
            // dtp_creacion_OT
            // 
            this.dtp_creacion_OT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_creacion_OT.Location = new System.Drawing.Point(163, 9);
            this.dtp_creacion_OT.Name = "dtp_creacion_OT";
            this.dtp_creacion_OT.Size = new System.Drawing.Size(95, 20);
            this.dtp_creacion_OT.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Fecha de Pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbl_unidad);
            this.groupBox1.Controls.Add(this.dgv_detalle);
            this.groupBox1.Controls.Add(this.btn_quitar);
            this.groupBox1.Controls.Add(this.txt_monto_total);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgv_productos);
            this.groupBox1.Location = new System.Drawing.Point(13, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 427);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Pedido a Proveedor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(505, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 73;
            this.label11.Text = "$";
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Location = new System.Drawing.Point(271, 207);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(0, 13);
            this.lbl_unidad.TabIndex = 9;
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.AllowUserToAddRows = false;
            this.dgv_detalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_detalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombreproductodetalle,
            this.preciodetalle,
            this.cantidad,
            this.unidadmedida,
            this.sub,
            this.idProductodetalle,
            this.idestado});
            this.dgv_detalle.Enabled = false;
            this.dgv_detalle.Location = new System.Drawing.Point(6, 230);
            this.dgv_detalle.MultiSelect = false;
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.ReadOnly = true;
            this.dgv_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalle.Size = new System.Drawing.Size(620, 154);
            this.dgv_detalle.TabIndex = 8;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // nombreproductodetalle
            // 
            this.nombreproductodetalle.HeaderText = "Nombre";
            this.nombreproductodetalle.Name = "nombreproductodetalle";
            this.nombreproductodetalle.ReadOnly = true;
            // 
            // preciodetalle
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.preciodetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.preciodetalle.HeaderText = "Precio";
            this.preciodetalle.Name = "preciodetalle";
            this.preciodetalle.ReadOnly = true;
            // 
            // cantidad
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // unidadmedida
            // 
            this.unidadmedida.HeaderText = "Unidad de Medida";
            this.unidadmedida.Name = "unidadmedida";
            this.unidadmedida.ReadOnly = true;
            // 
            // sub
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.sub.DefaultCellStyle = dataGridViewCellStyle4;
            this.sub.HeaderText = "SubTotal";
            this.sub.Name = "sub";
            this.sub.ReadOnly = true;
            // 
            // idProductodetalle
            // 
            this.idProductodetalle.HeaderText = "idProducto";
            this.idProductodetalle.Name = "idProductodetalle";
            this.idProductodetalle.ReadOnly = true;
            this.idProductodetalle.Visible = false;
            // 
            // idestado
            // 
            this.idestado.HeaderText = "idestado";
            this.idestado.Name = "idestado";
            this.idestado.ReadOnly = true;
            this.idestado.Visible = false;
            // 
            // btn_quitar
            // 
            this.btn_quitar.Enabled = false;
            this.btn_quitar.Location = new System.Drawing.Point(405, 203);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(75, 21);
            this.btn_quitar.TabIndex = 7;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // txt_monto_total
            // 
            this.txt_monto_total.Enabled = false;
            this.txt_monto_total.Location = new System.Drawing.Point(525, 394);
            this.txt_monto_total.MaxLength = 6;
            this.txt_monto_total.Name = "txt_monto_total";
            this.txt_monto_total.Size = new System.Drawing.Size(100, 20);
            this.txt_monto_total.TabIndex = 72;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(324, 203);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 21);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Enabled = false;
            this.txt_cantidad.Location = new System.Drawing.Point(165, 203);
            this.txt_cantidad.MaxLength = 6;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 4;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Monto Total:";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_productos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nombreproducto,
            this.descr,
            this.precio,
            this.unidad,
            this.stcokRiesgo,
            this.stockActual,
            this.stockDisponible,
            this.stockReservado,
            this.idProducto,
            this.stockFaltante});
            this.dgv_productos.Enabled = false;
            this.dgv_productos.Location = new System.Drawing.Point(6, 19);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(620, 176);
            this.dgv_productos.TabIndex = 1;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "Codigo";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // nombreproducto
            // 
            this.nombreproducto.HeaderText = "Nombre";
            this.nombreproducto.Name = "nombreproducto";
            this.nombreproducto.ReadOnly = true;
            // 
            // descr
            // 
            this.descr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descr.HeaderText = "Descripcion";
            this.descr.Name = "descr";
            this.descr.ReadOnly = true;
            this.descr.Width = 88;
            // 
            // precio
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.precio.DefaultCellStyle = dataGridViewCellStyle6;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad de Medida";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // stcokRiesgo
            // 
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.stcokRiesgo.DefaultCellStyle = dataGridViewCellStyle7;
            this.stcokRiesgo.HeaderText = "Stock Riesgo";
            this.stcokRiesgo.Name = "stcokRiesgo";
            this.stcokRiesgo.ReadOnly = true;
            // 
            // stockActual
            // 
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.stockActual.DefaultCellStyle = dataGridViewCellStyle8;
            this.stockActual.HeaderText = "Stock Actual";
            this.stockActual.Name = "stockActual";
            this.stockActual.ReadOnly = true;
            this.stockActual.Visible = false;
            // 
            // stockDisponible
            // 
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.stockDisponible.DefaultCellStyle = dataGridViewCellStyle9;
            this.stockDisponible.HeaderText = "Stock Disponible";
            this.stockDisponible.Name = "stockDisponible";
            this.stockDisponible.ReadOnly = true;
            // 
            // stockReservado
            // 
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.stockReservado.DefaultCellStyle = dataGridViewCellStyle10;
            this.stockReservado.HeaderText = "Stock Reservado";
            this.stockReservado.Name = "stockReservado";
            this.stockReservado.ReadOnly = true;
            this.stockReservado.Visible = false;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // stockFaltante
            // 
            this.stockFaltante.HeaderText = "Stock Faltante";
            this.stockFaltante.Name = "stockFaltante";
            this.stockFaltante.ReadOnly = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(480, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 76;
            this.label19.Text = "0";
            // 
            // txt_celular
            // 
            this.txt_celular.Enabled = false;
            this.txt_celular.Location = new System.Drawing.Point(501, 11);
            this.txt_celular.Mask = "0000-00000000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(92, 20);
            this.txt_celular.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(374, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Telefono contacto:";
            // 
            // txt_mail
            // 
            this.txt_mail.Enabled = false;
            this.txt_mail.Location = new System.Drawing.Point(433, 32);
            this.txt_mail.MaxLength = 50;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(160, 20);
            this.txt_mail.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 78;
            this.label14.Text = "e-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Contacto:";
            // 
            // txt_contacto
            // 
            this.txt_contacto.Enabled = false;
            this.txt_contacto.Location = new System.Drawing.Point(433, 53);
            this.txt_contacto.MaxLength = 50;
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(160, 20);
            this.txt_contacto.TabIndex = 80;
            // 
            // helpProviderGestionOrdenDeCompra
            // 
            this.helpProviderGestionOrdenDeCompra.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // Gestionar_Orden_de_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 600);
            this.Controls.Add(this.txt_contacto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtp_creacion_OT);
            this.Controls.Add(this.label1);
            this.helpProviderGestionOrdenDeCompra.SetHelpKeyword(this, "18");
            this.helpProviderGestionOrdenDeCompra.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestionar_Orden_de_Compra";
            this.helpProviderGestionOrdenDeCompra.SetShowHelp(this, true);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestionar Orden de Compra";
            this.Load += new System.EventHandler(this.Gestionar_Orden_de_Compra_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_proveedores;
        private System.Windows.Forms.DateTimePicker dtp_creacion_OT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_monto_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stcokRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockReservado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockFaltante;
        private System.Windows.Forms.HelpProvider helpProviderGestionOrdenDeCompra;
    }
}