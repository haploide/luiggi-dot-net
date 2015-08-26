
namespace Vista
{
    partial class Gestion_de_orden_de_Trabajo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_creacion_OT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_estructuraOT = new System.Windows.Forms.DataGridView();
            this.idPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maquinaria = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_productos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.cmb_empleado = new System.Windows.Forms.ComboBox();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.cmb_maquinaria = new System.Windows.Forms.ComboBox();
            this.lbl_maquinaria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_inicio = new System.Windows.Forms.MaskedTextBox();
            this.txt_fin = new System.Windows.Forms.MaskedTextBox();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.btn_cargar_combos = new System.Windows.Forms.Button();
            this.lbl_tiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estructuraOT)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errores
            // 
            this.errores.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fecha Creación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtp_creacion_OT
            // 
            this.dtp_creacion_OT.Enabled = false;
            this.dtp_creacion_OT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_creacion_OT.Location = new System.Drawing.Point(162, 16);
            this.dtp_creacion_OT.Name = "dtp_creacion_OT";
            this.dtp_creacion_OT.Size = new System.Drawing.Size(95, 20);
            this.dtp_creacion_OT.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Cantidad:";
            // 
            // dgv_estructuraOT
            // 
            this.dgv_estructuraOT.AllowUserToAddRows = false;
            this.dgv_estructuraOT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_estructuraOT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_estructuraOT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_estructuraOT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_estructuraOT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgv_estructuraOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estructuraOT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPro,
            this.Producto,
            this.duracion,
            this.tiempo,
            this.categoria,
            this.idCategoria,
            this.horaInicio,
            this.horaFin,
            this.maquinaria,
            this.empleado,
            this.cantidad,
            this.idUnidad,
            this.unidad,
            this.Estado});
            this.dgv_estructuraOT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_estructuraOT.Location = new System.Drawing.Point(8, 34);
            this.dgv_estructuraOT.MultiSelect = false;
            this.dgv_estructuraOT.Name = "dgv_estructuraOT";
            this.dgv_estructuraOT.ReadOnly = true;
            this.dgv_estructuraOT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estructuraOT.Size = new System.Drawing.Size(750, 178);
            this.dgv_estructuraOT.TabIndex = 49;
            this.dgv_estructuraOT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estructuraOT_CellDoubleClick);
            // 
            // idPro
            // 
            this.idPro.HeaderText = "idProducto";
            this.idPro.Name = "idPro";
            this.idPro.ReadOnly = true;
            this.idPro.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // duracion
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.duracion.DefaultCellStyle = dataGridViewCellStyle2;
            this.duracion.HeaderText = "Duracion";
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "Unidad Tiempo";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            // 
            // horaInicio
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.horaInicio.DefaultCellStyle = dataGridViewCellStyle3;
            this.horaInicio.HeaderText = "Hora Inicio";
            this.horaInicio.MaxInputLength = 5;
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.ReadOnly = true;
            this.horaInicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.horaInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.horaInicio.Visible = false;
            // 
            // horaFin
            // 
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.horaFin.DefaultCellStyle = dataGridViewCellStyle4;
            this.horaFin.HeaderText = "Hora Fin";
            this.horaFin.MaxInputLength = 5;
            this.horaFin.Name = "horaFin";
            this.horaFin.ReadOnly = true;
            this.horaFin.Visible = false;
            // 
            // maquinaria
            // 
            this.maquinaria.HeaderText = "Maquinaria";
            this.maquinaria.Name = "maquinaria";
            this.maquinaria.ReadOnly = true;
            this.maquinaria.Visible = false;
            // 
            // empleado
            // 
            this.empleado.HeaderText = "Empleado";
            this.empleado.Name = "empleado";
            this.empleado.ReadOnly = true;
            this.empleado.Visible = false;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // idUnidad
            // 
            this.idUnidad.HeaderText = "idUnidad";
            this.idUnidad.Name = "idUnidad";
            this.idUnidad.ReadOnly = true;
            this.idUnidad.Visible = false;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_estructuraOT);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 227);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Orden Trabajo";
            // 
            // cmb_productos
            // 
            this.cmb_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productos.FormattingEnabled = true;
            this.cmb_productos.Location = new System.Drawing.Point(95, 12);
            this.cmb_productos.Name = "cmb_productos";
            this.cmb_productos.Size = new System.Drawing.Size(213, 21);
            this.cmb_productos.TabIndex = 65;
            this.cmb_productos.SelectedIndexChanged += new System.EventHandler(this.cmb_productos_SelectedIndexChanged);
            this.cmb_productos.SelectionChangeCommitted += new System.EventHandler(this.cmb_productos_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Producto:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_productos);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 46);
            this.panel1.TabIndex = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.btn_salir_consulta);
            this.groupBox1.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox1.Location = new System.Drawing.Point(12, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 59);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Image = global::Vista.Properties.Resources.floppy1;
            this.btn_guardar.Location = new System.Drawing.Point(592, 13);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(38, 38);
            this.btn_guardar.TabIndex = 38;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo.Image = global::Vista.Properties.Resources.mop2;
            this.btn_nuevo.Location = new System.Drawing.Point(419, 13);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 38);
            this.btn_nuevo.TabIndex = 37;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_salir_consulta
            // 
            this.btn_salir_consulta.AutoSize = true;
            this.btn_salir_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir_consulta.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir_consulta.Location = new System.Drawing.Point(720, 13);
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
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(548, 14);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 36);
            this.btn_limpiar_filtros.TabIndex = 34;
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros.Click += new System.EventHandler(this.btn_limpiar_filtros_Click);
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Location = new System.Drawing.Point(105, 107);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(13, 13);
            this.lbl_cant.TabIndex = 68;
            this.lbl_cant.Text = "0";
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empleado.Enabled = false;
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(659, 70);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(121, 21);
            this.cmb_empleado.TabIndex = 69;
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_empleado.Location = new System.Drawing.Point(564, 70);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(89, 20);
            this.lbl_empleado.TabIndex = 70;
            this.lbl_empleado.Text = "Empleado";
            // 
            // cmb_maquinaria
            // 
            this.cmb_maquinaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_maquinaria.Enabled = false;
            this.cmb_maquinaria.FormattingEnabled = true;
            this.cmb_maquinaria.Location = new System.Drawing.Point(659, 103);
            this.cmb_maquinaria.Name = "cmb_maquinaria";
            this.cmb_maquinaria.Size = new System.Drawing.Size(121, 21);
            this.cmb_maquinaria.TabIndex = 71;
            // 
            // lbl_maquinaria
            // 
            this.lbl_maquinaria.AutoSize = true;
            this.lbl_maquinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_maquinaria.Location = new System.Drawing.Point(556, 103);
            this.lbl_maquinaria.Name = "lbl_maquinaria";
            this.lbl_maquinaria.Size = new System.Drawing.Size(97, 20);
            this.lbl_maquinaria.TabIndex = 72;
            this.lbl_maquinaria.Text = "Maquinaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Hora Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Hora Fin";
            // 
            // txt_inicio
            // 
            this.txt_inicio.Enabled = false;
            this.txt_inicio.Location = new System.Drawing.Point(461, 70);
            this.txt_inicio.Mask = "00:00";
            this.txt_inicio.Name = "txt_inicio";
            this.txt_inicio.Size = new System.Drawing.Size(54, 20);
            this.txt_inicio.TabIndex = 78;
            this.txt_inicio.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fin
            // 
            this.txt_fin.Enabled = false;
            this.txt_fin.Location = new System.Drawing.Point(461, 103);
            this.txt_fin.Mask = "00:00";
            this.txt_fin.Name = "txt_fin";
            this.txt_fin.Size = new System.Drawing.Size(54, 20);
            this.txt_fin.TabIndex = 79;
            this.txt_fin.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Location = new System.Drawing.Point(143, 107);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(0, 13);
            this.lbl_unidad.TabIndex = 80;
            // 
            // btn_cargar_combos
            // 
            this.btn_cargar_combos.Enabled = false;
            this.btn_cargar_combos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar_combos.Location = new System.Drawing.Point(521, 68);
            this.btn_cargar_combos.Name = "btn_cargar_combos";
            this.btn_cargar_combos.Size = new System.Drawing.Size(33, 23);
            this.btn_cargar_combos.TabIndex = 98;
            this.btn_cargar_combos.Text = "...";
            this.btn_cargar_combos.UseVisualStyleBackColor = true;
            this.btn_cargar_combos.Click += new System.EventHandler(this.btn_cargar_combos_Click);
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.Location = new System.Drawing.Point(362, 22);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(13, 13);
            this.lbl_tiempo.TabIndex = 99;
            this.lbl_tiempo.Text = "0";
            this.lbl_tiempo.Visible = false;
            // 
            // Gestion_de_orden_de_Trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 437);
            this.Controls.Add(this.lbl_tiempo);
            this.Controls.Add(this.btn_cargar_combos);
            this.Controls.Add(this.lbl_unidad);
            this.Controls.Add(this.txt_fin);
            this.Controls.Add(this.txt_inicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_maquinaria);
            this.Controls.Add(this.cmb_maquinaria);
            this.Controls.Add(this.lbl_empleado);
            this.Controls.Add(this.cmb_empleado);
            this.Controls.Add(this.lbl_cant);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_creacion_OT);
            this.Controls.Add(this.label1);
            this.Name = "Gestion_de_orden_de_Trabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Ordenes de Trabajo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestion_de_orden_de_Trabajo_FormClosing);
            this.Load += new System.EventHandler(this.Gestion_de_orden_de_Trabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estructuraOT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errores;
        private System.Windows.Forms.MaskedTextBox txt_fin;
        private System.Windows.Forms.MaskedTextBox txt_inicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_maquinaria;
        private System.Windows.Forms.ComboBox cmb_maquinaria;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.ComboBox cmb_empleado;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_salir_consulta;
        private System.Windows.Forms.Button btn_limpiar_filtros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_productos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_estructuraOT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_creacion_OT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Button btn_cargar_combos;
        private System.Windows.Forms.Label lbl_tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFin;
        private System.Windows.Forms.DataGridViewComboBoxColumn maquinaria;
        private System.Windows.Forms.DataGridViewComboBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;

    }
}