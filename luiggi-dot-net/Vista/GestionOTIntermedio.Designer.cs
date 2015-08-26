namespace Vista
{
    partial class GestionOTIntermedio
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
            this.txt_fin = new System.Windows.Forms.MaskedTextBox();
            this.txt_inicio = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_maquinaria = new System.Windows.Forms.Label();
            this.cmb_maquinaria = new System.Windows.Forms.ComboBox();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.cmb_empleado = new System.Windows.Forms.ComboBox();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_estructuraOT = new System.Windows.Forms.DataGridView();
            this.idPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_creacion_OT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.btn_cargar_combos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estructuraOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errores)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_fin
            // 
            this.txt_fin.Enabled = false;
            this.txt_fin.Location = new System.Drawing.Point(343, 71);
            this.txt_fin.Mask = "00:00";
            this.txt_fin.Name = "txt_fin";
            this.txt_fin.Size = new System.Drawing.Size(54, 20);
            this.txt_fin.TabIndex = 94;
            this.txt_fin.ValidatingType = typeof(System.DateTime);
            // 
            // txt_inicio
            // 
            this.txt_inicio.Enabled = false;
            this.txt_inicio.Location = new System.Drawing.Point(343, 38);
            this.txt_inicio.Mask = "00:00";
            this.txt_inicio.Name = "txt_inicio";
            this.txt_inicio.Size = new System.Drawing.Size(54, 20);
            this.txt_inicio.TabIndex = 93;
            this.txt_inicio.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Hora Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Hora Inicio";
            // 
            // lbl_maquinaria
            // 
            this.lbl_maquinaria.AutoSize = true;
            this.lbl_maquinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_maquinaria.Location = new System.Drawing.Point(438, 71);
            this.lbl_maquinaria.Name = "lbl_maquinaria";
            this.lbl_maquinaria.Size = new System.Drawing.Size(97, 20);
            this.lbl_maquinaria.TabIndex = 90;
            this.lbl_maquinaria.Text = "Maquinaria";
            // 
            // cmb_maquinaria
            // 
            this.cmb_maquinaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_maquinaria.Enabled = false;
            this.cmb_maquinaria.FormattingEnabled = true;
            this.cmb_maquinaria.Location = new System.Drawing.Point(541, 71);
            this.cmb_maquinaria.Name = "cmb_maquinaria";
            this.cmb_maquinaria.Size = new System.Drawing.Size(121, 21);
            this.cmb_maquinaria.TabIndex = 89;
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_empleado.Location = new System.Drawing.Point(446, 38);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(89, 20);
            this.lbl_empleado.TabIndex = 88;
            this.lbl_empleado.Text = "Empleado";
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empleado.Enabled = false;
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(541, 38);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(121, 21);
            this.cmb_empleado.TabIndex = 87;
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Location = new System.Drawing.Point(101, 70);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(13, 13);
            this.lbl_cant.TabIndex = 86;
            this.lbl_cant.Text = "0";
            this.lbl_cant.Click += new System.EventHandler(this.lbl_cant_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.btn_salir_consulta);
            this.groupBox1.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox1.Location = new System.Drawing.Point(12, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 59);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Image = global::Vista.Properties.Resources.floppy1;
            this.btn_guardar.Location = new System.Drawing.Point(484, 15);
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
            this.btn_nuevo.Location = new System.Drawing.Point(311, 15);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 38);
            this.btn_nuevo.TabIndex = 37;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_salir_consulta
            // 
            this.btn_salir_consulta.AutoSize = true;
            this.btn_salir_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir_consulta.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir_consulta.Location = new System.Drawing.Point(612, 15);
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
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(440, 16);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 36);
            this.btn_limpiar_filtros.TabIndex = 34;
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Producto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_estructuraOT);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 224);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Orden Trabajo";
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
            this.categoria,
            this.cantidad,
            this.unidad,
            this.idUnidad});
            this.dgv_estructuraOT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_estructuraOT.Location = new System.Drawing.Point(8, 19);
            this.dgv_estructuraOT.MultiSelect = false;
            this.dgv_estructuraOT.Name = "dgv_estructuraOT";
            this.dgv_estructuraOT.ReadOnly = true;
            this.dgv_estructuraOT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estructuraOT.Size = new System.Drawing.Size(642, 193);
            this.dgv_estructuraOT.TabIndex = 49;
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
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad Medida";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // idUnidad
            // 
            this.idUnidad.HeaderText = "idUnidad";
            this.idUnidad.Name = "idUnidad";
            this.idUnidad.ReadOnly = true;
            this.idUnidad.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 80;
            this.label4.Text = "Cantidad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtp_creacion_OT
            // 
            this.dtp_creacion_OT.Enabled = false;
            this.dtp_creacion_OT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_creacion_OT.Location = new System.Drawing.Point(162, 8);
            this.dtp_creacion_OT.Name = "dtp_creacion_OT";
            this.dtp_creacion_OT.Size = new System.Drawing.Size(95, 20);
            this.dtp_creacion_OT.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "Fecha Creación";
            // 
            // txt_Producto
            // 
            this.txt_Producto.Enabled = false;
            this.txt_Producto.Location = new System.Drawing.Point(104, 40);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(169, 20);
            this.txt_Producto.TabIndex = 95;
            // 
            // errores
            // 
            this.errores.ContainerControl = this;
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Location = new System.Drawing.Point(143, 70);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(0, 13);
            this.lbl_unidad.TabIndex = 96;
            // 
            // btn_cargar_combos
            // 
            this.btn_cargar_combos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar_combos.Location = new System.Drawing.Point(403, 37);
            this.btn_cargar_combos.Name = "btn_cargar_combos";
            this.btn_cargar_combos.Size = new System.Drawing.Size(33, 23);
            this.btn_cargar_combos.TabIndex = 97;
            this.btn_cargar_combos.Text = "...";
            this.btn_cargar_combos.UseVisualStyleBackColor = true;
            this.btn_cargar_combos.Click += new System.EventHandler(this.btn_cargar_combos_Click);
            // 
            // GestionOTIntermedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 405);
            this.Controls.Add(this.btn_cargar_combos);
            this.Controls.Add(this.lbl_unidad);
            this.Controls.Add(this.txt_Producto);
            this.Controls.Add(this.label3);
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_creacion_OT);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionOTIntermedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Orden Trabajo de Productos Intermedio";
            this.Load += new System.EventHandler(this.GestionOTIntermedio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estructuraOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_estructuraOT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_creacion_OT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidad;
        private System.Windows.Forms.ErrorProvider errores;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Button btn_cargar_combos;
    }
}