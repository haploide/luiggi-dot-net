namespace Vista
{
    partial class RegistrarFactura
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_agregar_a_factura = new System.Windows.Forms.Button();
            this.txt_totalIva = new System.Windows.Forms.TextBox();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_monto_total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtn_cc = new System.Windows.Forms.RadioButton();
            this.rbtn_contado = new System.Windows.Forms.RadioButton();
            this.cmb_tipo_factura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_iva = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nroFactura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_fecha_factura = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cuit = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nro_doc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_tipo_doc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.helpProviderRegistrarFactura = new System.Windows.Forms.HelpProvider();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txt_subtotal);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.btn_agregar_a_factura);
            this.groupBox4.Controls.Add(this.txt_totalIva);
            this.groupBox4.Controls.Add(this.lbl_iva);
            this.groupBox4.Controls.Add(this.dgv_detalle);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt_monto_total);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(12, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 290);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle de Factura";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(464, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 52;
            this.label16.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(464, 241);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "$";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Location = new System.Drawing.Point(485, 210);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal.TabIndex = 50;
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(409, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "SubTotal:";
            // 
            // btn_agregar_a_factura
            // 
            this.btn_agregar_a_factura.Image = global::Vista.Properties.Resources.add187;
            this.btn_agregar_a_factura.Location = new System.Drawing.Point(6, 199);
            this.btn_agregar_a_factura.Name = "btn_agregar_a_factura";
            this.btn_agregar_a_factura.Size = new System.Drawing.Size(55, 44);
            this.btn_agregar_a_factura.TabIndex = 48;
            this.btn_agregar_a_factura.UseVisualStyleBackColor = true;
            this.btn_agregar_a_factura.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_totalIva
            // 
            this.txt_totalIva.Enabled = false;
            this.txt_totalIva.Location = new System.Drawing.Point(485, 236);
            this.txt_totalIva.Name = "txt_totalIva";
            this.txt_totalIva.Size = new System.Drawing.Size(100, 20);
            this.txt_totalIva.TabIndex = 38;
            this.txt_totalIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Location = new System.Drawing.Point(385, 243);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(83, 13);
            this.lbl_iva.TabIndex = 37;
            this.lbl_iva.Text = "Total IVA (21%):";
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
            this.unidadmedida,
            this.cantidad,
            this.preciodetalle,
            this.sub,
            this.idProductodetalle,
            this.sinIva,
            this.add});
            this.dgv_detalle.Location = new System.Drawing.Point(9, 19);
            this.dgv_detalle.MultiSelect = false;
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.ReadOnly = true;
            this.dgv_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalle.Size = new System.Drawing.Size(579, 174);
            this.dgv_detalle.TabIndex = 4;
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
            // unidadmedida
            // 
            this.unidadmedida.HeaderText = "Unidad de Medida";
            this.unidadmedida.Name = "unidadmedida";
            this.unidadmedida.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
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
            // sub
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.sub.DefaultCellStyle = dataGridViewCellStyle3;
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
            // sinIva
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.sinIva.DefaultCellStyle = dataGridViewCellStyle4;
            this.sinIva.HeaderText = "Iva (21%)";
            this.sinIva.Name = "sinIva";
            this.sinIva.ReadOnly = true;
            // 
            // add
            // 
            this.add.HeaderText = "add";
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Monto Total:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_monto_total
            // 
            this.txt_monto_total.Enabled = false;
            this.txt_monto_total.Location = new System.Drawing.Point(485, 262);
            this.txt_monto_total.MaxLength = 6;
            this.txt_monto_total.Name = "txt_monto_total";
            this.txt_monto_total.Size = new System.Drawing.Size(100, 20);
            this.txt_monto_total.TabIndex = 5;
            this.txt_monto_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_monto_total.TextChanged += new System.EventHandler(this.txt_monto_total_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(464, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "$";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.cmb_tipo_factura);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmb_iva);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_nroFactura);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.dtp_fecha_factura);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(318, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 202);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Factura";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtn_cc);
            this.groupBox5.Controls.Add(this.rbtn_contado);
            this.groupBox5.Location = new System.Drawing.Point(78, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 68);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Forma de Pago";
            // 
            // rbtn_cc
            // 
            this.rbtn_cc.AutoSize = true;
            this.rbtn_cc.Location = new System.Drawing.Point(46, 42);
            this.rbtn_cc.Name = "rbtn_cc";
            this.rbtn_cc.Size = new System.Drawing.Size(104, 17);
            this.rbtn_cc.TabIndex = 1;
            this.rbtn_cc.TabStop = true;
            this.rbtn_cc.Text = "Cuenta Corriente";
            this.rbtn_cc.UseVisualStyleBackColor = true;
            // 
            // rbtn_contado
            // 
            this.rbtn_contado.AutoSize = true;
            this.rbtn_contado.Checked = true;
            this.rbtn_contado.Location = new System.Drawing.Point(46, 19);
            this.rbtn_contado.Name = "rbtn_contado";
            this.rbtn_contado.Size = new System.Drawing.Size(65, 17);
            this.rbtn_contado.TabIndex = 0;
            this.rbtn_contado.TabStop = true;
            this.rbtn_contado.Text = "Contado";
            this.rbtn_contado.UseVisualStyleBackColor = true;
            // 
            // cmb_tipo_factura
            // 
            this.cmb_tipo_factura.DisplayMember = "A";
            this.cmb_tipo_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_factura.FormattingEnabled = true;
            this.cmb_tipo_factura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmb_tipo_factura.Location = new System.Drawing.Point(124, 75);
            this.cmb_tipo_factura.Name = "cmb_tipo_factura";
            this.cmb_tipo_factura.Size = new System.Drawing.Size(63, 21);
            this.cmb_tipo_factura.TabIndex = 44;
            this.cmb_tipo_factura.ValueMember = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tipo Factura:";
            // 
            // cmb_iva
            // 
            this.cmb_iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_iva.Enabled = false;
            this.cmb_iva.FormattingEnabled = true;
            this.cmb_iva.Location = new System.Drawing.Point(124, 47);
            this.cmb_iva.Name = "cmb_iva";
            this.cmb_iva.Size = new System.Drawing.Size(149, 21);
            this.cmb_iva.TabIndex = 40;
            this.cmb_iva.SelectedValueChanged += new System.EventHandler(this.cmb_iva_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "IVA: ";
            // 
            // txt_nroFactura
            // 
            this.txt_nroFactura.Enabled = false;
            this.txt_nroFactura.Location = new System.Drawing.Point(124, 19);
            this.txt_nroFactura.Name = "txt_nroFactura";
            this.txt_nroFactura.Size = new System.Drawing.Size(124, 20);
            this.txt_nroFactura.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Nro Factura: ";
            // 
            // dtp_fecha_factura
            // 
            this.dtp_fecha_factura.Enabled = false;
            this.dtp_fecha_factura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_factura.Location = new System.Drawing.Point(124, 102);
            this.dtp_fecha_factura.Name = "dtp_fecha_factura";
            this.dtp_fecha_factura.Size = new System.Drawing.Size(98, 20);
            this.dtp_fecha_factura.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha de Creación:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cuit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_nro_doc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_tipo_doc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_razon_social);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 202);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Cliente";
            // 
            // txt_cuit
            // 
            this.txt_cuit.Enabled = false;
            this.txt_cuit.Location = new System.Drawing.Point(105, 131);
            this.txt_cuit.Mask = "00-00000000-0";
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(121, 20);
            this.txt_cuit.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "CUIT/CUIL";
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Enabled = false;
            this.txt_nro_doc.Location = new System.Drawing.Point(105, 51);
            this.txt_nro_doc.MaxLength = 8;
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.Size = new System.Drawing.Size(121, 20);
            this.txt_nro_doc.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Nro Documento";
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_doc.Enabled = false;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(105, 22);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_doc.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Tipo Documento";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Enabled = false;
            this.txt_razon_social.Location = new System.Drawing.Point(105, 155);
            this.txt_razon_social.MaxLength = 25;
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(168, 20);
            this.txt_razon_social.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Razon Social:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            this.txt_apellido.Location = new System.Drawing.Point(105, 105);
            this.txt_apellido.MaxLength = 25;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(149, 20);
            this.txt_apellido.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(105, 79);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(149, 20);
            this.txt_nombre.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Location = new System.Drawing.Point(12, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 66);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.AutoSize = true;
            this.btn_limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar.Image = global::Vista.Properties.Resources.mop2;
            this.btn_limpiar.Location = new System.Drawing.Point(341, 19);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(38, 38);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir.Location = new System.Drawing.Point(547, 19);
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
            this.btn_guardar.Image = global::Vista.Properties.Resources.floppy1;
            this.btn_guardar.Location = new System.Drawing.Point(430, 19);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(38, 38);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // helpProviderRegistrarFactura
            // 
            this.helpProviderRegistrarFactura.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // RegistrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 594);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.helpProviderRegistrarFactura.SetHelpKeyword(this, "29");
            this.helpProviderRegistrarFactura.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarFactura";
            this.helpProviderRegistrarFactura.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Factura";
            this.Load += new System.EventHandler(this.RegistrarFactura_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_monto_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_fecha_factura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_cuit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nro_doc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_tipo_doc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_nroFactura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_iva;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.TextBox txt_totalIva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_tipo_factura;
        private System.Windows.Forms.Button btn_agregar_a_factura;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtn_cc;
        private System.Windows.Forms.RadioButton rbtn_contado;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn add;
        private System.Windows.Forms.HelpProvider helpProviderRegistrarFactura;
    }
}