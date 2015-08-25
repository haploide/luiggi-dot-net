namespace Vista
{
    partial class Consulta_de_Pedidos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_de_Pedidos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_pedidos = new System.Windows.Forms.DataGridView();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecNec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_detalle_pedido = new System.Windows.Forms.DataGridView();
            this.codProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gp_filtros = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.txt_nro_doc = new System.Windows.Forms.TextBox();
            this.btn_aplicar_filtro_empresa = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.cmb_tipo_doc = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_monto_hasta = new System.Windows.Forms.TextBox();
            this.txt_monto_desde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_estado_pedido = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.helpProviderConsultaPedidos = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_pedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gp_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_salir_consulta);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Location = new System.Drawing.Point(13, 605);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 67);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // btn_limpiar_filtros
            // 
            this.btn_limpiar_filtros.AutoSize = true;
            this.btn_limpiar_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar_filtros.Image = global::Vista.Properties.Resources.mop2;
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(629, 19);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 38);
            this.btn_limpiar_filtros.TabIndex = 48;
            this.toolTip1.SetToolTip(this.btn_limpiar_filtros, "Limpiar Filtros");
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSize = true;
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_eliminar.Image = global::Vista.Properties.Resources.bin2;
            this.btn_eliminar.Location = new System.Drawing.Point(902, 19);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(38, 38);
            this.btn_eliminar.TabIndex = 47;
            this.toolTip1.SetToolTip(this.btn_eliminar, "Borrar un pedido seleccionado");
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Visible = false;
            // 
            // btn_salir_consulta
            // 
            this.btn_salir_consulta.AutoSize = true;
            this.btn_salir_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir_consulta.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir_consulta.Location = new System.Drawing.Point(970, 19);
            this.btn_salir_consulta.Name = "btn_salir_consulta";
            this.btn_salir_consulta.Size = new System.Drawing.Size(38, 38);
            this.btn_salir_consulta.TabIndex = 46;
            this.toolTip1.SetToolTip(this.btn_salir_consulta, "Salir del formulario");
            this.btn_salir_consulta.UseVisualStyleBackColor = true;
            this.btn_salir_consulta.Click += new System.EventHandler(this.btn_salir_consulta_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo.Image = global::Vista.Properties.Resources.new10;
            this.btn_nuevo.Location = new System.Drawing.Point(858, 21);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 36);
            this.btn_nuevo.TabIndex = 45;
            this.toolTip1.SetToolTip(this.btn_nuevo, "Registrar un nuevo pedido");
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_limpiar_filtros_Click);
            // 
            // dgv_pedidos
            // 
            this.dgv_pedidos.AllowUserToAddRows = false;
            this.dgv_pedidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_pedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedido,
            this.nroPedido,
            this.fecPedido,
            this.Estado,
            this.razSoc,
            this.Nombre,
            this.ape,
            this.fecNec,
            this.total,
            this.dirEntrega,
            this.opciones,
            this.idestado});
            this.dgv_pedidos.Location = new System.Drawing.Point(6, 19);
            this.dgv_pedidos.MultiSelect = false;
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.ReadOnly = true;
            this.dgv_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pedidos.Size = new System.Drawing.Size(1006, 176);
            this.dgv_pedidos.TabIndex = 49;
            this.dgv_pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedidos_CellClick);
            this.dgv_pedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedidos_CellContentClick);
            this.dgv_pedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedidos_CellDoubleClick);
            // 
            // idPedido
            // 
            this.idPedido.HeaderText = "idPedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            this.idPedido.Visible = false;
            // 
            // nroPedido
            // 
            this.nroPedido.HeaderText = "Numero de Pedido";
            this.nroPedido.Name = "nroPedido";
            this.nroPedido.ReadOnly = true;
            // 
            // fecPedido
            // 
            this.fecPedido.HeaderText = "Fecha Pedido";
            this.fecPedido.Name = "fecPedido";
            this.fecPedido.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // razSoc
            // 
            this.razSoc.HeaderText = "Razon Social";
            this.razSoc.Name = "razSoc";
            this.razSoc.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ape
            // 
            this.ape.HeaderText = "Apellido";
            this.ape.Name = "ape";
            this.ape.ReadOnly = true;
            // 
            // fecNec
            // 
            this.fecNec.HeaderText = "Fecha Necesidad";
            this.fecNec.Name = "fecNec";
            this.fecNec.ReadOnly = true;
            // 
            // total
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle2;
            this.total.HeaderText = "Monto Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // dirEntrega
            // 
            this.dirEntrega.HeaderText = "Dir. Entrega";
            this.dirEntrega.Name = "dirEntrega";
            this.dirEntrega.ReadOnly = true;
            // 
            // opciones
            // 
            this.opciones.HeaderText = "Opciones";
            this.opciones.Name = "opciones";
            this.opciones.ReadOnly = true;
            // 
            // idestado
            // 
            this.idestado.HeaderText = "idestado";
            this.idestado.Name = "idestado";
            this.idestado.ReadOnly = true;
            this.idestado.Visible = false;
            // 
            // dgv_detalle_pedido
            // 
            this.dgv_detalle_pedido.AllowUserToAddRows = false;
            this.dgv_detalle_pedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_detalle_pedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_detalle_pedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_detalle_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalle_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_pedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProd,
            this.nomProd,
            this.unidad,
            this.cant,
            this.precio,
            this.subTotal,
            this.idProd,
            this.idEstadoDetalle});
            this.dgv_detalle_pedido.Location = new System.Drawing.Point(6, 19);
            this.dgv_detalle_pedido.MultiSelect = false;
            this.dgv_detalle_pedido.Name = "dgv_detalle_pedido";
            this.dgv_detalle_pedido.ReadOnly = true;
            this.dgv_detalle_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalle_pedido.Size = new System.Drawing.Size(1002, 164);
            this.dgv_detalle_pedido.TabIndex = 50;
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
            // cant
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.cant.DefaultCellStyle = dataGridViewCellStyle4;
            this.cant.HeaderText = "Cantidad";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
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
            // subTotal
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.subTotal.DefaultCellStyle = dataGridViewCellStyle6;
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
            // idEstadoDetalle
            // 
            this.idEstadoDetalle.HeaderText = "idEstadoDetalle";
            this.idEstadoDetalle.Name = "idEstadoDetalle";
            this.idEstadoDetalle.ReadOnly = true;
            this.idEstadoDetalle.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_pedidos);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 201);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_detalle_pedido);
            this.groupBox3.Location = new System.Drawing.Point(13, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 189);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de Pedido";
            // 
            // gp_filtros
            // 
            this.gp_filtros.Controls.Add(this.label15);
            this.gp_filtros.Controls.Add(this.label14);
            this.gp_filtros.Controls.Add(this.txt_razon_social);
            this.gp_filtros.Controls.Add(this.label8);
            this.gp_filtros.Controls.Add(this.label9);
            this.gp_filtros.Controls.Add(this.txt_cuit);
            this.gp_filtros.Controls.Add(this.txt_nro_doc);
            this.gp_filtros.Controls.Add(this.btn_aplicar_filtro_empresa);
            this.gp_filtros.Controls.Add(this.txt_nombre);
            this.gp_filtros.Controls.Add(this.label10);
            this.gp_filtros.Controls.Add(this.label11);
            this.gp_filtros.Controls.Add(this.label12);
            this.gp_filtros.Controls.Add(this.txt_apellido);
            this.gp_filtros.Controls.Add(this.cmb_tipo_doc);
            this.gp_filtros.Controls.Add(this.label13);
            this.gp_filtros.Controls.Add(this.txt_monto_hasta);
            this.gp_filtros.Controls.Add(this.txt_monto_desde);
            this.gp_filtros.Controls.Add(this.label7);
            this.gp_filtros.Controls.Add(this.label6);
            this.gp_filtros.Controls.Add(this.label5);
            this.gp_filtros.Controls.Add(this.cmb_estado_pedido);
            this.gp_filtros.Controls.Add(this.label4);
            this.gp_filtros.Controls.Add(this.dtp_hasta);
            this.gp_filtros.Controls.Add(this.label3);
            this.gp_filtros.Controls.Add(this.dtp_desde);
            this.gp_filtros.Controls.Add(this.label2);
            this.gp_filtros.Controls.Add(this.label1);
            this.gp_filtros.Location = new System.Drawing.Point(13, 415);
            this.gp_filtros.Name = "gp_filtros";
            this.gp_filtros.Size = new System.Drawing.Size(1018, 184);
            this.gp_filtros.TabIndex = 53;
            this.gp_filtros.TabStop = false;
            this.gp_filtros.Text = "Filtros";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(539, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 16);
            this.label15.TabIndex = 78;
            this.label15.Text = "$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(539, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 16);
            this.label14.TabIndex = 77;
            this.label14.Text = "$";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Location = new System.Drawing.Point(529, 118);
            this.txt_razon_social.MaxLength = 25;
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(95, 20);
            this.txt_razon_social.TabIndex = 73;
            this.txt_razon_social.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_razon_social_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Razon Social";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "CUIT/CUIL";
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(529, 147);
            this.txt_cuit.MaxLength = 8;
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(95, 20);
            this.txt_cuit.TabIndex = 76;
            this.txt_cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuit_KeyPress);
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Location = new System.Drawing.Point(259, 147);
            this.txt_nro_doc.MaxLength = 8;
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.Size = new System.Drawing.Size(121, 20);
            this.txt_nro_doc.TabIndex = 72;
            this.txt_nro_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
            // 
            // btn_aplicar_filtro_empresa
            // 
            this.btn_aplicar_filtro_empresa.AutoSize = true;
            this.btn_aplicar_filtro_empresa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro_empresa.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro_empresa.Location = new System.Drawing.Point(642, 118);
            this.btn_aplicar_filtro_empresa.Name = "btn_aplicar_filtro_empresa";
            this.btn_aplicar_filtro_empresa.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro_empresa.TabIndex = 71;
            this.toolTip1.SetToolTip(this.btn_aplicar_filtro_empresa, "Filtrar la grilla de pedidos");
            this.btn_aplicar_filtro_empresa.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro_empresa.Click += new System.EventHandler(this.btn_aplicar_filtro_empresa_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(74, 118);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(95, 20);
            this.txt_nombre.TabIndex = 64;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Apellido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Nro Doc";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(74, 147);
            this.txt_apellido.MaxLength = 25;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(95, 20);
            this.txt_apellido.TabIndex = 67;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(259, 118);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_doc.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "Tipo Doc";
            // 
            // txt_monto_hasta
            // 
            this.txt_monto_hasta.Location = new System.Drawing.Point(551, 74);
            this.txt_monto_hasta.MaxLength = 5;
            this.txt_monto_hasta.Name = "txt_monto_hasta";
            this.txt_monto_hasta.Size = new System.Drawing.Size(100, 20);
            this.txt_monto_hasta.TabIndex = 62;
            this.txt_monto_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuit_KeyPress);
            // 
            // txt_monto_desde
            // 
            this.txt_monto_desde.Location = new System.Drawing.Point(551, 48);
            this.txt_monto_desde.MaxLength = 5;
            this.txt_monto_desde.Name = "txt_monto_desde";
            this.txt_monto_desde.Size = new System.Drawing.Size(100, 20);
            this.txt_monto_desde.TabIndex = 61;
            this.txt_monto_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuit_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Rango Monto Total";
            // 
            // cmb_estado_pedido
            // 
            this.cmb_estado_pedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado_pedido.FormattingEnabled = true;
            this.cmb_estado_pedido.Location = new System.Drawing.Point(228, 45);
            this.cmb_estado_pedido.Name = "cmb_estado_pedido";
            this.cmb_estado_pedido.Size = new System.Drawing.Size(198, 21);
            this.cmb_estado_pedido.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Estado";
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(74, 71);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(95, 20);
            this.dtp_hasta.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Hasta";
            // 
            // dtp_desde
            // 
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(73, 45);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(96, 20);
            this.dtp_desde.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rango Fecha Necesidad";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.helpProviderConsultaPedidos.SetHelpKeyword(this.btn_cancelar, "6");
            this.helpProviderConsultaPedidos.SetHelpNavigator(this.btn_cancelar, System.Windows.Forms.HelpNavigator.TopicId);
            this.btn_cancelar.Image = global::Vista.Properties.Resources.shopping86__2_;
            this.btn_cancelar.Location = new System.Drawing.Point(871, 442);
            this.btn_cancelar.Name = "btn_cancelar";
            this.helpProviderConsultaPedidos.SetShowHelp(this.btn_cancelar, true);
            this.btn_cancelar.Size = new System.Drawing.Size(57, 54);
            this.btn_cancelar.TabIndex = 54;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // helpProviderConsultaPedidos
            // 
            this.helpProviderConsultaPedidos.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // Consulta_de_Pedidos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1043, 679);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gp_filtros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.helpProviderConsultaPedidos.SetHelpKeyword(this, "6");
            this.helpProviderConsultaPedidos.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_de_Pedidos";
            this.helpProviderConsultaPedidos.SetShowHelp(this, true);
            this.Text = "Consulta de Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consulta_de_Pedidos_FormClosed);
            this.Load += new System.EventHandler(this.Consulta_de_Pedidos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_pedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gp_filtros.ResumeLayout(false);
            this.gp_filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir_consulta;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_pedidos;
        private System.Windows.Forms.DataGridView dgv_detalle_pedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gp_filtros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_estado_pedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_monto_desde;
        private System.Windows.Forms.TextBox txt_monto_hasta;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.TextBox txt_nro_doc;
        private System.Windows.Forms.Button btn_aplicar_filtro_empresa;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.ComboBox cmb_tipo_doc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_limpiar_filtros;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn razSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecNec;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirEntrega;
        private System.Windows.Forms.DataGridViewButtonColumn opciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestado;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.HelpProvider helpProviderConsultaPedidos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}