namespace Vista
{
    partial class Consultas_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas_Producto));
            this.cmb_unidad_filtro = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_cat_filtro = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_precio_hasta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_precio_desde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_riesg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioMayorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoMaquinaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnidadTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aplicar_filtro_unidad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_unidad_filtro
            // 
            this.cmb_unidad_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unidad_filtro.FormattingEnabled = true;
            this.cmb_unidad_filtro.Location = new System.Drawing.Point(416, 44);
            this.cmb_unidad_filtro.Name = "cmb_unidad_filtro";
            this.cmb_unidad_filtro.Size = new System.Drawing.Size(121, 21);
            this.cmb_unidad_filtro.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Unidad de Medida";
            // 
            // cmb_cat_filtro
            // 
            this.cmb_cat_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat_filtro.FormattingEnabled = true;
            this.cmb_cat_filtro.Location = new System.Drawing.Point(214, 47);
            this.cmb_cat_filtro.Name = "cmb_cat_filtro";
            this.cmb_cat_filtro.Size = new System.Drawing.Size(121, 21);
            this.cmb_cat_filtro.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Categoria";
            // 
            // txt_precio_hasta
            // 
            this.txt_precio_hasta.Location = new System.Drawing.Point(93, 70);
            this.txt_precio_hasta.MaxLength = 5;
            this.txt_precio_hasta.Name = "txt_precio_hasta";
            this.txt_precio_hasta.Size = new System.Drawing.Size(59, 20);
            this.txt_precio_hasta.TabIndex = 28;
            this.txt_precio_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_desde_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Hasta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Desde";
            // 
            // txt_precio_desde
            // 
            this.txt_precio_desde.Location = new System.Drawing.Point(93, 44);
            this.txt_precio_desde.MaxLength = 5;
            this.txt_precio_desde.Name = "txt_precio_desde";
            this.txt_precio_desde.Size = new System.Drawing.Size(59, 20);
            this.txt_precio_desde.TabIndex = 25;
            this.txt_precio_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_desde_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Rango de Precios";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_productos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Nombre,
            this.Desc,
            this.Precio,
            this.cat,
            this.Unidad,
            this.stock_riesg,
            this.idUnidad,
            this.codCategoria,
            this.foto,
            this.precioMayorista,
            this.idTipoMaquinaria,
            this.tiempo,
            this.idUnidadTiempo,
            this.cantidadProductos});
            this.dgv_productos.Location = new System.Drawing.Point(6, 19);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(974, 298);
            this.dgv_productos.TabIndex = 23;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            this.dgv_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descripcion";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Width = 88;
            // 
            // Precio
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 62;
            // 
            // cat
            // 
            this.cat.HeaderText = "Categoria";
            this.cat.Name = "cat";
            this.cat.ReadOnly = true;
            this.cat.Width = 77;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad de Medida";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Width = 119;
            // 
            // stock_riesg
            // 
            this.stock_riesg.HeaderText = "Stock de Riesgo";
            this.stock_riesg.Name = "stock_riesg";
            this.stock_riesg.ReadOnly = true;
            this.stock_riesg.Width = 111;
            // 
            // idUnidad
            // 
            this.idUnidad.HeaderText = "idUnidad";
            this.idUnidad.Name = "idUnidad";
            this.idUnidad.ReadOnly = true;
            this.idUnidad.Visible = false;
            // 
            // codCategoria
            // 
            this.codCategoria.HeaderText = "codCategoria";
            this.codCategoria.Name = "codCategoria";
            this.codCategoria.ReadOnly = true;
            this.codCategoria.Visible = false;
            // 
            // foto
            // 
            this.foto.HeaderText = "foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Visible = false;
            // 
            // precioMayorista
            // 
            this.precioMayorista.HeaderText = "Precio Mayorista";
            this.precioMayorista.Name = "precioMayorista";
            this.precioMayorista.ReadOnly = true;
            this.precioMayorista.Visible = false;
            // 
            // idTipoMaquinaria
            // 
            this.idTipoMaquinaria.HeaderText = "Tipo Maq";
            this.idTipoMaquinaria.Name = "idTipoMaquinaria";
            this.idTipoMaquinaria.ReadOnly = true;
            this.idTipoMaquinaria.Visible = false;
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "Tiempo Prod";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            this.tiempo.Visible = false;
            // 
            // idUnidadTiempo
            // 
            this.idUnidadTiempo.HeaderText = "Unidad Tiempo";
            this.idUnidadTiempo.Name = "idUnidadTiempo";
            this.idUnidadTiempo.ReadOnly = true;
            this.idUnidadTiempo.Visible = false;
            // 
            // cantidadProductos
            // 
            this.cantidadProductos.HeaderText = "cantidadProductos";
            this.cantidadProductos.Name = "cantidadProductos";
            this.cantidadProductos.ReadOnly = true;
            this.cantidadProductos.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_aplicar_filtro_unidad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_precio_desde);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_unidad_filtro);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_precio_hasta);
            this.groupBox1.Controls.Add(this.cmb_cat_filtro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 107);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "$";
            // 
            // btn_aplicar_filtro_unidad
            // 
            this.btn_aplicar_filtro_unidad.AutoSize = true;
            this.btn_aplicar_filtro_unidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro_unidad.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro_unidad.Location = new System.Drawing.Point(556, 40);
            this.btn_aplicar_filtro_unidad.Name = "btn_aplicar_filtro_unidad";
            this.btn_aplicar_filtro_unidad.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro_unidad.TabIndex = 35;
            this.btn_aplicar_filtro_unidad.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro_unidad.Click += new System.EventHandler(this.btn_aplicar_filtro_unidad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_salir_consulta);
            this.groupBox2.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox2.Location = new System.Drawing.Point(12, 575);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 59);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo.Image = global::Vista.Properties.Resources.mop2;
            this.btn_nuevo.Location = new System.Drawing.Point(523, 15);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 38);
            this.btn_nuevo.TabIndex = 37;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSize = true;
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_eliminar.Image = global::Vista.Properties.Resources.bin2;
            this.btn_eliminar.Location = new System.Drawing.Point(874, 15);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(38, 38);
            this.btn_eliminar.TabIndex = 36;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_salir_consulta
            // 
            this.btn_salir_consulta.AutoSize = true;
            this.btn_salir_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir_consulta.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir_consulta.Location = new System.Drawing.Point(942, 15);
            this.btn_salir_consulta.Name = "btn_salir_consulta";
            this.btn_salir_consulta.Size = new System.Drawing.Size(38, 38);
            this.btn_salir_consulta.TabIndex = 35;
            this.btn_salir_consulta.UseVisualStyleBackColor = true;
            this.btn_salir_consulta.Click += new System.EventHandler(this.btn_salir_consulta_Click);
            // 
            // btn_limpiar_filtros
            // 
            this.btn_limpiar_filtros.AutoSize = true;
            this.btn_limpiar_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar_filtros.Image = global::Vista.Properties.Resources.new10;
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(830, 17);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 36);
            this.btn_limpiar_filtros.TabIndex = 34;
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros.Click += new System.EventHandler(this.btn_limpiar_filtros_Click);
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_foto.Image = global::Vista.Properties.Resources.photo3;
            this.pb_foto.Location = new System.Drawing.Point(6, 323);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(198, 113);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_foto.TabIndex = 39;
            this.pb_foto.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_productos);
            this.groupBox3.Controls.Add(this.pb_foto);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(990, 444);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // Consultas_Producto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1013, 645);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas_Producto";
            this.Text = "Consultas Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consultas_Producto_FormClosed);
            this.Load += new System.EventHandler(this.Consultas_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir_consulta;
        private System.Windows.Forms.Button btn_limpiar_filtros;
        private System.Windows.Forms.ComboBox cmb_unidad_filtro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_cat_filtro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_precio_hasta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_precio_desde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_aplicar_filtro_unidad;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_riesg;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioMayorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoMaquinaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidadTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductos;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}