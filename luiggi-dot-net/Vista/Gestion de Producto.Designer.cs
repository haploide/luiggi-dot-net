namespace Vista
{
    partial class Gestion_de_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_de_Producto));
            this.cmb_unidad_medida = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_buscar_imagen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_precio_minorista = new System.Windows.Forms.TextBox();
            this.lbl_precio_minorista = new System.Windows.Forms.Label();
            this.txt_stock_riesgo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion_producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.btn_verificar_existencia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grb_Horas = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_tiempo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtHorasHombre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_unidad_catidad = new System.Windows.Forms.ComboBox();
            this.cmbTipoMaquinarias = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_maquinaria = new System.Windows.Forms.Label();
            this.lbl_precio_mayorista = new System.Windows.Forms.Label();
            this.txt_Precio_Mayorista = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.helpProviderGestionProducto = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grb_Horas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_unidad_medida
            // 
            this.cmb_unidad_medida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unidad_medida.Enabled = false;
            this.cmb_unidad_medida.FormattingEnabled = true;
            this.cmb_unidad_medida.Location = new System.Drawing.Point(108, 86);
            this.cmb_unidad_medida.Name = "cmb_unidad_medida";
            this.cmb_unidad_medida.Size = new System.Drawing.Size(121, 21);
            this.cmb_unidad_medida.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Unidad de Medida:";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.Enabled = false;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(108, 137);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cmb_categoria.TabIndex = 7;
            this.cmb_categoria.SelectionChangeCommitted += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Categoria:";
            // 
            // btn_buscar_imagen
            // 
            this.btn_buscar_imagen.Enabled = false;
            this.btn_buscar_imagen.Location = new System.Drawing.Point(441, 271);
            this.btn_buscar_imagen.Name = "btn_buscar_imagen";
            this.btn_buscar_imagen.Size = new System.Drawing.Size(83, 23);
            this.btn_buscar_imagen.TabIndex = 14;
            this.btn_buscar_imagen.Text = "Buscar foto";
            this.btn_buscar_imagen.UseVisualStyleBackColor = true;
            this.btn_buscar_imagen.Click += new System.EventHandler(this.btn_buscar_imagen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Foto";
            // 
            // txt_precio_minorista
            // 
            this.txt_precio_minorista.Enabled = false;
            this.txt_precio_minorista.Location = new System.Drawing.Point(108, 163);
            this.txt_precio_minorista.MaxLength = 6;
            this.txt_precio_minorista.Name = "txt_precio_minorista";
            this.txt_precio_minorista.Size = new System.Drawing.Size(60, 20);
            this.txt_precio_minorista.TabIndex = 8;
            this.txt_precio_minorista.Visible = false;
            this.txt_precio_minorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // lbl_precio_minorista
            // 
            this.lbl_precio_minorista.AutoSize = true;
            this.lbl_precio_minorista.Location = new System.Drawing.Point(50, 166);
            this.lbl_precio_minorista.Name = "lbl_precio_minorista";
            this.lbl_precio_minorista.Size = new System.Drawing.Size(52, 13);
            this.lbl_precio_minorista.TabIndex = 26;
            this.lbl_precio_minorista.Text = "Precio:  $";
            this.lbl_precio_minorista.Visible = false;
            // 
            // txt_stock_riesgo
            // 
            this.txt_stock_riesgo.Enabled = false;
            this.txt_stock_riesgo.Location = new System.Drawing.Point(108, 112);
            this.txt_stock_riesgo.MaxLength = 6;
            this.txt_stock_riesgo.Name = "txt_stock_riesgo";
            this.txt_stock_riesgo.Size = new System.Drawing.Size(47, 20);
            this.txt_stock_riesgo.TabIndex = 6;
            this.txt_stock_riesgo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_riesgo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Stock de riesgo:";
            // 
            // txt_descripcion_producto
            // 
            this.txt_descripcion_producto.Enabled = false;
            this.txt_descripcion_producto.Location = new System.Drawing.Point(108, 44);
            this.txt_descripcion_producto.MaxLength = 150;
            this.txt_descripcion_producto.Multiline = true;
            this.txt_descripcion_producto.Name = "txt_descripcion_producto";
            this.txt_descripcion_producto.Size = new System.Drawing.Size(305, 36);
            this.txt_descripcion_producto.TabIndex = 4;
            this.txt_descripcion_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_producto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descripción";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Enabled = false;
            this.txt_nombre_producto.Location = new System.Drawing.Point(108, 19);
            this.txt_nombre_producto.MaxLength = 50;
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(228, 20);
            this.txt_nombre_producto.TabIndex = 2;
            this.txt_nombre_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_producto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre:";
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir.Location = new System.Drawing.Point(587, 19);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(38, 38);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo.Image = global::Vista.Properties.Resources.mop2;
            this.btn_nuevo.Location = new System.Drawing.Point(53, 19);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 38);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
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
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_foto.Image = global::Vista.Properties.Resources.photo3;
            this.pb_foto.Location = new System.Drawing.Point(441, 94);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(165, 159);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_foto.TabIndex = 29;
            this.pb_foto.TabStop = false;
            // 
            // btn_verificar_existencia
            // 
            this.btn_verificar_existencia.AutoSize = true;
            this.btn_verificar_existencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_verificar_existencia.Image = global::Vista.Properties.Resources.magnifier14;
            this.btn_verificar_existencia.Location = new System.Drawing.Point(342, 19);
            this.btn_verificar_existencia.Name = "btn_verificar_existencia";
            this.btn_verificar_existencia.Size = new System.Drawing.Size(22, 22);
            this.btn_verificar_existencia.TabIndex = 3;
            this.btn_verificar_existencia.UseVisualStyleBackColor = true;
            this.btn_verificar_existencia.Click += new System.EventHandler(this.btn_verificar_existencia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grb_Horas);
            this.groupBox1.Controls.Add(this.pb_foto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre_producto);
            this.groupBox1.Controls.Add(this.cmbTipoMaquinarias);
            this.groupBox1.Controls.Add(this.cmb_unidad_medida);
            this.groupBox1.Controls.Add(this.btn_verificar_existencia);
            this.groupBox1.Controls.Add(this.lbl_tipo_maquinaria);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_categoria);
            this.groupBox1.Controls.Add(this.txt_descripcion_producto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_buscar_imagen);
            this.groupBox1.Controls.Add(this.txt_stock_riesgo);
            this.groupBox1.Controls.Add(this.lbl_precio_mayorista);
            this.groupBox1.Controls.Add(this.lbl_precio_minorista);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Precio_Mayorista);
            this.groupBox1.Controls.Add(this.txt_precio_minorista);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 347);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Producto";
            // 
            // grb_Horas
            // 
            this.grb_Horas.Controls.Add(this.label10);
            this.grb_Horas.Controls.Add(this.cmb_tiempo);
            this.grb_Horas.Controls.Add(this.txtCantidad);
            this.grb_Horas.Controls.Add(this.txtHorasHombre);
            this.grb_Horas.Controls.Add(this.label14);
            this.grb_Horas.Controls.Add(this.label13);
            this.grb_Horas.Controls.Add(this.cmb_unidad_catidad);
            this.grb_Horas.Location = new System.Drawing.Point(21, 240);
            this.grb_Horas.Name = "grb_Horas";
            this.grb_Horas.Size = new System.Drawing.Size(376, 85);
            this.grb_Horas.TabIndex = 37;
            this.grb_Horas.TabStop = false;
            this.grb_Horas.Text = "Horas Trabajadas En La Produccion";
            this.grb_Horas.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Horas Hombre";
            // 
            // cmb_tiempo
            // 
            this.cmb_tiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tiempo.Enabled = false;
            this.cmb_tiempo.FormattingEnabled = true;
            this.cmb_tiempo.Location = new System.Drawing.Point(199, 58);
            this.cmb_tiempo.Name = "cmb_tiempo";
            this.cmb_tiempo.Size = new System.Drawing.Size(110, 21);
            this.cmb_tiempo.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(133, 20);
            this.txtCantidad.MaxLength = 6;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 20);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txtHorasHombre
            // 
            this.txtHorasHombre.Location = new System.Drawing.Point(133, 59);
            this.txtHorasHombre.MaxLength = 6;
            this.txtHorasHombre.Name = "txtHorasHombre";
            this.txtHorasHombre.Size = new System.Drawing.Size(60, 20);
            this.txtHorasHombre.TabIndex = 12;
            this.txtHorasHombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(80, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Cantidad de productos";
            // 
            // cmb_unidad_catidad
            // 
            this.cmb_unidad_catidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unidad_catidad.Enabled = false;
            this.cmb_unidad_catidad.FormattingEnabled = true;
            this.cmb_unidad_catidad.Location = new System.Drawing.Point(199, 19);
            this.cmb_unidad_catidad.Name = "cmb_unidad_catidad";
            this.cmb_unidad_catidad.Size = new System.Drawing.Size(110, 21);
            this.cmb_unidad_catidad.TabIndex = 34;
            // 
            // cmbTipoMaquinarias
            // 
            this.cmbTipoMaquinarias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMaquinarias.Enabled = false;
            this.cmbTipoMaquinarias.FormattingEnabled = true;
            this.cmbTipoMaquinarias.Location = new System.Drawing.Point(108, 213);
            this.cmbTipoMaquinarias.Name = "cmbTipoMaquinarias";
            this.cmbTipoMaquinarias.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMaquinarias.TabIndex = 10;
            this.cmbTipoMaquinarias.Visible = false;
            // 
            // lbl_tipo_maquinaria
            // 
            this.lbl_tipo_maquinaria.AutoSize = true;
            this.lbl_tipo_maquinaria.Location = new System.Drawing.Point(4, 213);
            this.lbl_tipo_maquinaria.Name = "lbl_tipo_maquinaria";
            this.lbl_tipo_maquinaria.Size = new System.Drawing.Size(98, 13);
            this.lbl_tipo_maquinaria.TabIndex = 33;
            this.lbl_tipo_maquinaria.Text = "Tipo de Maquinaria";
            this.lbl_tipo_maquinaria.Visible = false;
            // 
            // lbl_precio_mayorista
            // 
            this.lbl_precio_mayorista.AutoSize = true;
            this.lbl_precio_mayorista.Location = new System.Drawing.Point(4, 191);
            this.lbl_precio_mayorista.Name = "lbl_precio_mayorista";
            this.lbl_precio_mayorista.Size = new System.Drawing.Size(100, 13);
            this.lbl_precio_mayorista.TabIndex = 26;
            this.lbl_precio_mayorista.Text = "Precio Mayorista:  $";
            this.lbl_precio_mayorista.Visible = false;
            // 
            // txt_Precio_Mayorista
            // 
            this.txt_Precio_Mayorista.Enabled = false;
            this.txt_Precio_Mayorista.Location = new System.Drawing.Point(108, 188);
            this.txt_Precio_Mayorista.MaxLength = 6;
            this.txt_Precio_Mayorista.Name = "txt_Precio_Mayorista";
            this.txt_Precio_Mayorista.Size = new System.Drawing.Size(60, 20);
            this.txt_Precio_Mayorista.TabIndex = 9;
            this.txt_Precio_Mayorista.Visible = false;
            this.txt_Precio_Mayorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Location = new System.Drawing.Point(3, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 66);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // helpProviderGestionProducto
            // 
            this.helpProviderGestionProducto.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // Gestion_de_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.helpProviderGestionProducto.SetHelpKeyword(this, "11");
            this.helpProviderGestionProducto.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestion_de_Producto";
            this.helpProviderGestionProducto.SetShowHelp(this, true);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Producto";
            this.Load += new System.EventHandler(this.Gestion_de_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_Horas.ResumeLayout(false);
            this.grb_Horas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cmb_unidad_medida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_buscar_imagen;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_precio_minorista;
        private System.Windows.Forms.Label lbl_precio_minorista;
        private System.Windows.Forms.TextBox txt_stock_riesgo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_verificar_existencia;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTipoMaquinarias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_tipo_maquinaria;
        private System.Windows.Forms.Label lbl_precio_mayorista;
        private System.Windows.Forms.TextBox txtHorasHombre;
        private System.Windows.Forms.TextBox txt_Precio_Mayorista;
        private System.Windows.Forms.ComboBox cmb_tiempo;
        private System.Windows.Forms.GroupBox grb_Horas;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_unidad_catidad;
        private System.Windows.Forms.HelpProvider helpProviderGestionProducto;

    }
}