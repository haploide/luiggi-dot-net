namespace Vista
{
    partial class Agregar_productos_a_factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_productos_a_factura));
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.txt_totalIva = new System.Windows.Forms.TextBox();
            this.txt_monto_total = new System.Windows.Forms.TextBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_agregar_a_factura = new System.Windows.Forms.Button();
            this.helpProviderAgregarProductosAFactura = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_finales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir_consulta
            // 
            this.btn_salir_consulta.AutoSize = true;
            this.btn_salir_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir_consulta.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir_consulta.Location = new System.Drawing.Point(591, 19);
            this.btn_salir_consulta.Name = "btn_salir_consulta";
            this.btn_salir_consulta.Size = new System.Drawing.Size(38, 38);
            this.btn_salir_consulta.TabIndex = 43;
            this.btn_salir_consulta.UseVisualStyleBackColor = true;
            this.btn_salir_consulta.Click += new System.EventHandler(this.btn_salir_consulta_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lbl_unidad);
            this.groupBox4.Controls.Add(this.txt_totalIva);
            this.groupBox4.Controls.Add(this.txt_monto_total);
            this.groupBox4.Controls.Add(this.btn_quitar);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.dgv_detalle);
            this.groupBox4.Controls.Add(this.btn_agregar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt_cantidad);
            this.groupBox4.Controls.Add(this.dgv_productos_finales);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(635, 437);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Productos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(457, 314);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "$";
            this.label15.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(457, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 31);
            this.label11.TabIndex = 36;
            this.label11.Text = "$";
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Location = new System.Drawing.Point(191, 244);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(0, 13);
            this.lbl_unidad.TabIndex = 5;
            // 
            // txt_totalIva
            // 
            this.txt_totalIva.Enabled = false;
            this.txt_totalIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalIva.Location = new System.Drawing.Point(493, 308);
            this.txt_totalIva.MaxLength = 6;
            this.txt_totalIva.Name = "txt_totalIva";
            this.txt_totalIva.Size = new System.Drawing.Size(100, 31);
            this.txt_totalIva.TabIndex = 5;
            this.txt_totalIva.Text = "0";
            this.txt_totalIva.Visible = false;
            // 
            // txt_monto_total
            // 
            this.txt_monto_total.Enabled = false;
            this.txt_monto_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_total.Location = new System.Drawing.Point(493, 386);
            this.txt_monto_total.MaxLength = 6;
            this.txt_monto_total.Name = "txt_monto_total";
            this.txt_monto_total.Size = new System.Drawing.Size(100, 38);
            this.txt_monto_total.TabIndex = 5;
            this.txt_monto_total.Text = "0";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(460, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Total IVA:";
            this.label14.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(432, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "Monto Total:";
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.AllowUserToAddRows = false;
            this.dgv_detalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
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
            this.idProductodetalle});
            this.dgv_detalle.Enabled = false;
            this.dgv_detalle.Location = new System.Drawing.Point(9, 277);
            this.dgv_detalle.MultiSelect = false;
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.ReadOnly = true;
            this.dgv_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalle.Size = new System.Drawing.Size(401, 154);
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
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
            this.dgv_productos_finales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_finales_CellContentClick);
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
            // btn_agregar_a_factura
            // 
            this.btn_agregar_a_factura.Enabled = false;
            this.btn_agregar_a_factura.Image = global::Vista.Properties.Resources.add187;
            this.btn_agregar_a_factura.Location = new System.Drawing.Point(543, 17);
            this.btn_agregar_a_factura.Name = "btn_agregar_a_factura";
            this.btn_agregar_a_factura.Size = new System.Drawing.Size(42, 40);
            this.btn_agregar_a_factura.TabIndex = 49;
            this.btn_agregar_a_factura.UseVisualStyleBackColor = true;
            this.btn_agregar_a_factura.Click += new System.EventHandler(this.btn_agregar_a_factura_Click);
            // 
            // helpProviderAgregarProductosAFactura
            // 
            this.helpProviderAgregarProductosAFactura.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_agregar_a_factura);
            this.groupBox1.Controls.Add(this.btn_salir_consulta);
            this.groupBox1.Location = new System.Drawing.Point(12, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 67);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // Agregar_productos_a_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.helpProviderAgregarProductosAFactura.SetHelpKeyword(this, "30");
            this.helpProviderAgregarProductosAFactura.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar_productos_a_factura";
            this.helpProviderAgregarProductosAFactura.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Productos a Factura";
            this.Load += new System.EventHandler(this.Agregar_productos_a_factura_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_finales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir_consulta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.TextBox txt_totalIva;
        private System.Windows.Forms.TextBox txt_monto_total;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductodetalle;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.DataGridView dgv_productos_finales;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDisp;
        private System.Windows.Forms.Button btn_agregar_a_factura;
        private System.Windows.Forms.HelpProvider helpProviderAgregarProductosAFactura;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}