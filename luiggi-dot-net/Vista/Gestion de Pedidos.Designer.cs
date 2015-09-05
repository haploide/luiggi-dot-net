namespace Vista
{
    partial class Gestion_de_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_de_Pedidos));
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_aplicar_filtro_empresa = new System.Windows.Forms.Button();
            this.txt_cuit = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nro_doc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_tipo_doc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_verificar_empresa = new System.Windows.Forms.Button();
            this.btn_verificar_persona = new System.Windows.Forms.Button();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_dir_entrega = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_monto_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fecha_pedido = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_necesidad = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.dgv_productos_finales = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helpProviderGestionPedidos = new System.Windows.Forms.HelpProvider();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_finales)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir.Location = new System.Drawing.Point(582, 19);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(38, 38);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Location = new System.Drawing.Point(12, 652);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 66);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Image = global::Vista.Properties.Resources.floppy1;
            this.btn_guardar.Location = new System.Drawing.Point(465, 19);
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
            this.btn_nuevo.Location = new System.Drawing.Point(421, 19);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 38);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_aplicar_filtro_empresa);
            this.groupBox1.Controls.Add(this.txt_cuit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_nro_doc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_tipo_doc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_verificar_empresa);
            this.groupBox1.Controls.Add(this.btn_verificar_persona);
            this.groupBox1.Controls.Add(this.txt_razon_social);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 191);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Cliente";
            // 
            // btn_aplicar_filtro_empresa
            // 
            this.btn_aplicar_filtro_empresa.AutoSize = true;
            this.btn_aplicar_filtro_empresa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro_empresa.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro_empresa.Location = new System.Drawing.Point(279, 129);
            this.btn_aplicar_filtro_empresa.Name = "btn_aplicar_filtro_empresa";
            this.btn_aplicar_filtro_empresa.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro_empresa.TabIndex = 72;
            this.btn_aplicar_filtro_empresa.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro_empresa.Click += new System.EventHandler(this.btn_aplicar_filtro_empresa_Click);
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(105, 131);
            this.txt_cuit.Mask = "00-00000000-0";
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(121, 20);
            this.txt_cuit.TabIndex = 54;
            this.txt_cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
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
            this.txt_nro_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
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
            // btn_verificar_empresa
            // 
            this.btn_verificar_empresa.AutoSize = true;
            this.btn_verificar_empresa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_verificar_empresa.Enabled = false;
            this.btn_verificar_empresa.Image = global::Vista.Properties.Resources.magnifier14;
            this.btn_verificar_empresa.Location = new System.Drawing.Point(232, 131);
            this.btn_verificar_empresa.Name = "btn_verificar_empresa";
            this.btn_verificar_empresa.Size = new System.Drawing.Size(22, 22);
            this.btn_verificar_empresa.TabIndex = 47;
            this.btn_verificar_empresa.UseVisualStyleBackColor = true;
            this.btn_verificar_empresa.Visible = false;
            this.btn_verificar_empresa.Click += new System.EventHandler(this.btn_verificar_empresa_Click);
            // 
            // btn_verificar_persona
            // 
            this.btn_verificar_persona.AutoSize = true;
            this.btn_verificar_persona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_verificar_persona.Enabled = false;
            this.btn_verificar_persona.Image = global::Vista.Properties.Resources.magnifier14;
            this.btn_verificar_persona.Location = new System.Drawing.Point(232, 47);
            this.btn_verificar_persona.Name = "btn_verificar_persona";
            this.btn_verificar_persona.Size = new System.Drawing.Size(22, 22);
            this.btn_verificar_persona.TabIndex = 46;
            this.btn_verificar_persona.UseVisualStyleBackColor = true;
            this.btn_verificar_persona.Visible = false;
            this.btn_verificar_persona.Click += new System.EventHandler(this.btn_verificar_persona_Click);
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Location = new System.Drawing.Point(105, 155);
            this.txt_razon_social.MaxLength = 25;
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(168, 20);
            this.txt_razon_social.TabIndex = 43;
            this.txt_razon_social.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_razon_social_KeyPress);
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
            this.txt_apellido.Location = new System.Drawing.Point(105, 105);
            this.txt_apellido.MaxLength = 25;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(149, 20);
            this.txt_apellido.TabIndex = 43;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
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
            this.txt_nombre.Location = new System.Drawing.Point(105, 79);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(149, 20);
            this.txt_nombre.TabIndex = 43;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txt_celular);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_dir_entrega);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_monto_total);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtp_fecha_pedido);
            this.groupBox3.Controls.Add(this.dtp_fecha_necesidad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(347, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 191);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Pedido";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(137, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 72;
            this.label19.Text = "0";
            // 
            // txt_celular
            // 
            this.txt_celular.Enabled = false;
            this.txt_celular.Location = new System.Drawing.Point(150, 143);
            this.txt_celular.Mask = "0000-00000000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(92, 20);
            this.txt_celular.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Telefono contacto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Dirección Entrega:";
            // 
            // txt_dir_entrega
            // 
            this.txt_dir_entrega.Location = new System.Drawing.Point(142, 115);
            this.txt_dir_entrega.Name = "txt_dir_entrega";
            this.txt_dir_entrega.Size = new System.Drawing.Size(143, 20);
            this.txt_dir_entrega.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(121, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "$";
            // 
            // txt_monto_total
            // 
            this.txt_monto_total.Enabled = false;
            this.txt_monto_total.Location = new System.Drawing.Point(142, 89);
            this.txt_monto_total.MaxLength = 6;
            this.txt_monto_total.Name = "txt_monto_total";
            this.txt_monto_total.Size = new System.Drawing.Size(100, 20);
            this.txt_monto_total.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Monto Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha de Pedido:";
            // 
            // dtp_fecha_pedido
            // 
            this.dtp_fecha_pedido.Enabled = false;
            this.dtp_fecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_pedido.Location = new System.Drawing.Point(142, 27);
            this.dtp_fecha_pedido.Name = "dtp_fecha_pedido";
            this.dtp_fecha_pedido.Size = new System.Drawing.Size(98, 20);
            this.dtp_fecha_pedido.TabIndex = 2;
            // 
            // dtp_fecha_necesidad
            // 
            this.dtp_fecha_necesidad.Enabled = false;
            this.dtp_fecha_necesidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_necesidad.Location = new System.Drawing.Point(142, 63);
            this.dtp_fecha_necesidad.Name = "dtp_fecha_necesidad";
            this.dtp_fecha_necesidad.Size = new System.Drawing.Size(98, 20);
            this.dtp_fecha_necesidad.TabIndex = 1;
            this.dtp_fecha_necesidad.ValueChanged += new System.EventHandler(this.dtp_fecha_necesidad_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha de Necesidad:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_unidad);
            this.groupBox4.Controls.Add(this.btn_quitar);
            this.groupBox4.Controls.Add(this.dgv_detalle);
            this.groupBox4.Controls.Add(this.btn_agregar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt_cantidad);
            this.groupBox4.Controls.Add(this.dgv_productos_finales);
            this.groupBox4.Location = new System.Drawing.Point(12, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(635, 437);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle de Pedido";
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Location = new System.Drawing.Point(191, 244);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(0, 13);
            this.lbl_unidad.TabIndex = 5;
            // 
            // btn_quitar
            // 
            this.btn_quitar.Enabled = false;
            this.btn_quitar.Location = new System.Drawing.Point(335, 239);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(75, 23);
            this.btn_quitar.TabIndex = 3;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
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
            this.reservado,
            this.reservar,
            this.idestado});
            this.dgv_detalle.Enabled = false;
            this.dgv_detalle.Location = new System.Drawing.Point(9, 277);
            this.dgv_detalle.MultiSelect = false;
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.ReadOnly = true;
            this.dgv_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_detalle.Size = new System.Drawing.Size(620, 154);
            this.dgv_detalle.TabIndex = 4;
            this.dgv_detalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalle_CellContentClick);
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
            dataGridViewCellStyle2.Format = "C3";
            dataGridViewCellStyle2.NullValue = null;
            this.preciodetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.preciodetalle.HeaderText = "Precio";
            this.preciodetalle.Name = "preciodetalle";
            this.preciodetalle.ReadOnly = true;
            // 
            // cantidad
            // 
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
            dataGridViewCellStyle3.Format = "C3";
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
            // reservado
            // 
            this.reservado.HeaderText = "Reservado";
            this.reservado.Name = "reservado";
            this.reservado.ReadOnly = true;
            this.reservado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reservado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // reservar
            // 
            this.reservar.HeaderText = "Reservar";
            this.reservar.Name = "reservar";
            this.reservar.ReadOnly = true;
            this.reservar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reservar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reservar.Text = "Reservar";
            // 
            // idestado
            // 
            this.idestado.HeaderText = "idestado";
            this.idestado.Name = "idestado";
            this.idestado.ReadOnly = true;
            this.idestado.Visible = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(254, 239);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Enabled = false;
            this.txt_cantidad.Location = new System.Drawing.Point(84, 240);
            this.txt_cantidad.MaxLength = 6;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 1;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // dgv_productos_finales
            // 
            this.dgv_productos_finales.AllowUserToAddRows = false;
            this.dgv_productos_finales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_productos_finales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_productos_finales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos_finales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos_finales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nombreproducto,
            this.descr,
            this.precio,
            this.unidad,
            this.idProducto,
            this.stockDisp});
            this.dgv_productos_finales.Enabled = false;
            this.dgv_productos_finales.Location = new System.Drawing.Point(9, 19);
            this.dgv_productos_finales.MultiSelect = false;
            this.dgv_productos_finales.Name = "dgv_productos_finales";
            this.dgv_productos_finales.ReadOnly = true;
            this.dgv_productos_finales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos_finales.Size = new System.Drawing.Size(620, 206);
            this.dgv_productos_finales.TabIndex = 0;
            this.dgv_productos_finales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_finales_CellClick);
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
            this.descr.HeaderText = "Descripcion";
            this.descr.Name = "descr";
            this.descr.ReadOnly = true;
            // 
            // precio
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.precio.DefaultCellStyle = dataGridViewCellStyle5;
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
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // stockDisp
            // 
            this.stockDisp.HeaderText = "Stock Disponible";
            this.stockDisp.Name = "stockDisp";
            this.stockDisp.ReadOnly = true;
            // 
            // helpProviderGestionPedidos
            // 
            this.helpProviderGestionPedidos.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // Gestion_de_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(659, 730);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.helpProviderGestionPedidos.SetHelpKeyword(this, "8");
            this.helpProviderGestionPedidos.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestion_de_Pedidos";
            this.helpProviderGestionPedidos.SetShowHelp(this, true);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Pedidos";
            this.Load += new System.EventHandler(this.Gestion_de_Pedidos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_finales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_verificar_empresa;
        private System.Windows.Forms.Button btn_verificar_persona;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtp_fecha_necesidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fecha_pedido;
        private System.Windows.Forms.DataGridView dgv_productos_finales;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_monto_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nro_doc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_tipo_doc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_cuit;
        private System.Windows.Forms.Button btn_aplicar_filtro_empresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_dir_entrega;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDisp;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservado;
        private System.Windows.Forms.DataGridViewButtonColumn reservar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestado;
        private System.Windows.Forms.HelpProvider helpProviderGestionPedidos;
    }
}