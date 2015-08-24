namespace Vista
{
    partial class Gestion_Producto_X_Proveedor
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
            this.btn_nuevo_proveedor = new System.Windows.Forms.Button();
            this.btn_nuevo_producto = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbl_precio_minorista = new System.Windows.Forms.Label();
            this.txt_precio_proveedor = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockReservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Productos_X_Proveedores = new System.Windows.Forms.DataGridView();
            this.idProducto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroProv2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersona2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.nroProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinvia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprovincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_unidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos_X_Proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nuevo_proveedor
            // 
            this.btn_nuevo_proveedor.Location = new System.Drawing.Point(861, 16);
            this.btn_nuevo_proveedor.Name = "btn_nuevo_proveedor";
            this.btn_nuevo_proveedor.Size = new System.Drawing.Size(117, 23);
            this.btn_nuevo_proveedor.TabIndex = 64;
            this.btn_nuevo_proveedor.Text = "Nuevo Proveedor";
            this.btn_nuevo_proveedor.UseVisualStyleBackColor = true;
            this.btn_nuevo_proveedor.Click += new System.EventHandler(this.btn_nuevo_proveedor_Click);
            // 
            // btn_nuevo_producto
            // 
            this.btn_nuevo_producto.Location = new System.Drawing.Point(130, 18);
            this.btn_nuevo_producto.Name = "btn_nuevo_producto";
            this.btn_nuevo_producto.Size = new System.Drawing.Size(117, 23);
            this.btn_nuevo_producto.TabIndex = 65;
            this.btn_nuevo_producto.Text = "Nuevo Producto";
            this.btn_nuevo_producto.UseVisualStyleBackColor = true;
            this.btn_nuevo_producto.Click += new System.EventHandler(this.btn_nuevo_producto_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(727, 275);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(24, 20);
            this.Label2.TabIndex = 60;
            this.Label2.Text = " $";
            // 
            // lbl_precio_minorista
            // 
            this.lbl_precio_minorista.AutoSize = true;
            this.lbl_precio_minorista.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precio_minorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_minorista.Location = new System.Drawing.Point(654, 275);
            this.lbl_precio_minorista.Name = "lbl_precio_minorista";
            this.lbl_precio_minorista.Size = new System.Drawing.Size(64, 20);
            this.lbl_precio_minorista.TabIndex = 61;
            this.lbl_precio_minorista.Text = "Precio:";
            // 
            // txt_precio_proveedor
            // 
            this.txt_precio_proveedor.Location = new System.Drawing.Point(757, 275);
            this.txt_precio_proveedor.MaxLength = 10;
            this.txt_precio_proveedor.Name = "txt_precio_proveedor";
            this.txt_precio_proveedor.Size = new System.Drawing.Size(67, 20);
            this.txt_precio_proveedor.TabIndex = 59;
            this.txt_precio_proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_proveedor_KeyPress);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 300);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(273, 24);
            this.Label4.TabIndex = 56;
            this.Label4.Text = "Productos Por Proveedores:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(720, 15);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(135, 24);
            this.Label3.TabIndex = 57;
            this.Label3.Text = "Proveedores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Productos:";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_productos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.producto,
            this.descProducto,
            this.categoria,
            this.unidad,
            this.stockDisponible,
            this.stockRiesgo,
            this.stockActual,
            this.stockReservado,
            this.idUnidad,
            this.idCategoria});
            this.dgv_productos.Location = new System.Drawing.Point(12, 53);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(706, 208);
            this.dgv_productos.TabIndex = 54;
            this.dgv_productos.Click += new System.EventHandler(this.dgv_productos_Click);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "CodProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // descProducto
            // 
            this.descProducto.HeaderText = "Descripcion";
            this.descProducto.Name = "descProducto";
            this.descProducto.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // stockDisponible
            // 
            this.stockDisponible.HeaderText = "Stock Disponible";
            this.stockDisponible.Name = "stockDisponible";
            this.stockDisponible.ReadOnly = true;
            this.stockDisponible.Visible = false;
            // 
            // stockRiesgo
            // 
            this.stockRiesgo.HeaderText = "Stock de Riesgo";
            this.stockRiesgo.Name = "stockRiesgo";
            this.stockRiesgo.ReadOnly = true;
            // 
            // stockActual
            // 
            this.stockActual.HeaderText = "Stock Actual";
            this.stockActual.Name = "stockActual";
            this.stockActual.ReadOnly = true;
            this.stockActual.Visible = false;
            // 
            // stockReservado
            // 
            this.stockReservado.HeaderText = "Stock Reservado";
            this.stockReservado.Name = "stockReservado";
            this.stockReservado.ReadOnly = true;
            this.stockReservado.Visible = false;
            // 
            // idUnidad
            // 
            this.idUnidad.HeaderText = "idUnidad";
            this.idUnidad.Name = "idUnidad";
            this.idUnidad.ReadOnly = true;
            this.idUnidad.Visible = false;
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            // 
            // dgv_Productos_X_Proveedores
            // 
            this.dgv_Productos_X_Proveedores.AllowUserToAddRows = false;
            this.dgv_Productos_X_Proveedores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv_Productos_X_Proveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Productos_X_Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Productos_X_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos_X_Proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto2,
            this.producto2,
            this.nroProv2,
            this.proveedor2,
            this.precioProducto,
            this.unidad2,
            this.fechaPrecio,
            this.idPersona2});
            this.dgv_Productos_X_Proveedores.Location = new System.Drawing.Point(12, 337);
            this.dgv_Productos_X_Proveedores.MultiSelect = false;
            this.dgv_Productos_X_Proveedores.Name = "dgv_Productos_X_Proveedores";
            this.dgv_Productos_X_Proveedores.ReadOnly = true;
            this.dgv_Productos_X_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Productos_X_Proveedores.Size = new System.Drawing.Size(949, 182);
            this.dgv_Productos_X_Proveedores.TabIndex = 55;
            this.dgv_Productos_X_Proveedores.Click += new System.EventHandler(this.dgv_Productos_X_Proveedores_Click);
            // 
            // idProducto2
            // 
            this.idProducto2.HeaderText = "CodProducto";
            this.idProducto2.Name = "idProducto2";
            this.idProducto2.ReadOnly = true;
            this.idProducto2.Visible = false;
            // 
            // producto2
            // 
            this.producto2.HeaderText = "Producto";
            this.producto2.Name = "producto2";
            this.producto2.ReadOnly = true;
            // 
            // nroProv2
            // 
            this.nroProv2.HeaderText = "Numero Proveedor";
            this.nroProv2.Name = "nroProv2";
            this.nroProv2.ReadOnly = true;
            this.nroProv2.Visible = false;
            // 
            // proveedor2
            // 
            this.proveedor2.HeaderText = "Proveedor";
            this.proveedor2.Name = "proveedor2";
            this.proveedor2.ReadOnly = true;
            // 
            // precioProducto
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.precioProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            // 
            // unidad2
            // 
            this.unidad2.HeaderText = "Unidad";
            this.unidad2.Name = "unidad2";
            this.unidad2.ReadOnly = true;
            // 
            // fechaPrecio
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.fechaPrecio.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaPrecio.HeaderText = "Fecha de Creacion";
            this.fechaPrecio.Name = "fechaPrecio";
            this.fechaPrecio.ReadOnly = true;
            // 
            // idPersona2
            // 
            this.idPersona2.HeaderText = "idPersona";
            this.idPersona2.Name = "idPersona2";
            this.idPersona2.ReadOnly = true;
            this.idPersona2.Visible = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSize = true;
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_eliminar.Image = global::Vista.Properties.Resources.bin2;
            this.btn_eliminar.Location = new System.Drawing.Point(62, 526);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(38, 38);
            this.btn_eliminar.TabIndex = 68;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_salir_consulta
            // 
            this.btn_salir_consulta.AutoSize = true;
            this.btn_salir_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir_consulta.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir_consulta.Location = new System.Drawing.Point(738, 526);
            this.btn_salir_consulta.Name = "btn_salir_consulta";
            this.btn_salir_consulta.Size = new System.Drawing.Size(38, 38);
            this.btn_salir_consulta.TabIndex = 67;
            this.btn_salir_consulta.UseVisualStyleBackColor = true;
            this.btn_salir_consulta.Click += new System.EventHandler(this.btn_salir_consulta_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Image = global::Vista.Properties.Resources.floppy1;
            this.btn_guardar.Location = new System.Drawing.Point(374, 526);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(38, 38);
            this.btn_guardar.TabIndex = 69;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo.Image = global::Vista.Properties.Resources.new10;
            this.btn_nuevo.Location = new System.Drawing.Point(12, 528);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 36);
            this.btn_nuevo.TabIndex = 70;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.AllowUserToAddRows = false;
            this.dgv_proveedores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_proveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroProv,
            this.raSocial,
            this.cuit,
            this.apellido,
            this.Nombre,
            this.telefono,
            this.mail,
            this.idCondicion,
            this.idPersona,
            this.calle,
            this.calleNro,
            this.piso,
            this.depto,
            this.barrio,
            this.localidad,
            this.provinvia,
            this.idtipo,
            this.idprovincia,
            this.idlocalidad});
            this.dgv_proveedores.Location = new System.Drawing.Point(724, 53);
            this.dgv_proveedores.MultiSelect = false;
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.ReadOnly = true;
            this.dgv_proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_proveedores.Size = new System.Drawing.Size(240, 208);
            this.dgv_proveedores.TabIndex = 71;
            // 
            // nroProv
            // 
            this.nroProv.HeaderText = "Nro Proveedor";
            this.nroProv.Name = "nroProv";
            this.nroProv.ReadOnly = true;
            this.nroProv.Visible = false;
            // 
            // raSocial
            // 
            this.raSocial.HeaderText = "Razon Social";
            this.raSocial.Name = "raSocial";
            this.raSocial.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT/CUIL";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            this.cuit.Visible = false;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido del Responsable";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Responsable";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "e-mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // idCondicion
            // 
            this.idCondicion.HeaderText = "idCondicion";
            this.idCondicion.Name = "idCondicion";
            this.idCondicion.ReadOnly = true;
            this.idCondicion.Visible = false;
            // 
            // idPersona
            // 
            this.idPersona.HeaderText = "idPersona";
            this.idPersona.Name = "idPersona";
            this.idPersona.ReadOnly = true;
            this.idPersona.Visible = false;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Visible = false;
            // 
            // calleNro
            // 
            this.calleNro.HeaderText = "Nro";
            this.calleNro.Name = "calleNro";
            this.calleNro.ReadOnly = true;
            this.calleNro.Visible = false;
            // 
            // piso
            // 
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            this.piso.Visible = false;
            // 
            // depto
            // 
            this.depto.HeaderText = "Depto";
            this.depto.Name = "depto";
            this.depto.ReadOnly = true;
            this.depto.Visible = false;
            // 
            // barrio
            // 
            this.barrio.HeaderText = "Barrio";
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            this.barrio.Visible = false;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            this.localidad.Visible = false;
            // 
            // provinvia
            // 
            this.provinvia.HeaderText = "Provincia";
            this.provinvia.Name = "provinvia";
            this.provinvia.ReadOnly = true;
            this.provinvia.Visible = false;
            // 
            // idtipo
            // 
            this.idtipo.HeaderText = "idtipo";
            this.idtipo.Name = "idtipo";
            this.idtipo.ReadOnly = true;
            this.idtipo.Visible = false;
            // 
            // idprovincia
            // 
            this.idprovincia.HeaderText = "idprovincia";
            this.idprovincia.Name = "idprovincia";
            this.idprovincia.ReadOnly = true;
            this.idprovincia.Visible = false;
            // 
            // idlocalidad
            // 
            this.idlocalidad.HeaderText = "idlocalidad";
            this.idlocalidad.Name = "idlocalidad";
            this.idlocalidad.ReadOnly = true;
            this.idlocalidad.Visible = false;
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidad.Location = new System.Drawing.Point(830, 275);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(0, 20);
            this.lbl_unidad.TabIndex = 60;
            // 
            // Gestion_Producto_X_Proveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(973, 575);
            this.Controls.Add(this.dgv_proveedores);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_salir_consulta);
            this.Controls.Add(this.btn_nuevo_proveedor);
            this.Controls.Add(this.btn_nuevo_producto);
            this.Controls.Add(this.lbl_unidad);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lbl_precio_minorista);
            this.Controls.Add(this.txt_precio_proveedor);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.dgv_Productos_X_Proveedores);
            this.Name = "Gestion_Producto_X_Proveedor";
            this.Text = "Gestion_Producto_X_Proveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gestion_Producto_X_Proveedor_FormClosed);
            this.Load += new System.EventHandler(this.Gestion_Producto_X_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos_X_Proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_nuevo_proveedor;
        internal System.Windows.Forms.Button btn_nuevo_producto;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label lbl_precio_minorista;
        private System.Windows.Forms.TextBox txt_precio_proveedor;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dgv_productos;
        internal System.Windows.Forms.DataGridView dgv_Productos_X_Proveedores;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir_consulta;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroProv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn raSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinvia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprovincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocalidad;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockReservado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
    }
}