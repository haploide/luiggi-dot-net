namespace Vista
{
    partial class Consulta_Maquinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Maquinaria));
            this.gp_filtros = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.cmb_tipo_maq = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_aplicar_filtro = new System.Windows.Forms.Button();
            this.cmb_estado_maq = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.btn_nueva = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_maquinas = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaquinaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gp_filtros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_maquinas)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_filtros
            // 
            this.gp_filtros.Controls.Add(this.txt_nombre);
            this.gp_filtros.Controls.Add(this.label9);
            this.gp_filtros.Controls.Add(this.label10);
            this.gp_filtros.Controls.Add(this.txt_descrip);
            this.gp_filtros.Controls.Add(this.cmb_tipo_maq);
            this.gp_filtros.Controls.Add(this.label12);
            this.gp_filtros.Controls.Add(this.btn_aplicar_filtro);
            this.gp_filtros.Controls.Add(this.cmb_estado_maq);
            this.gp_filtros.Controls.Add(this.label4);
            this.gp_filtros.Location = new System.Drawing.Point(12, 367);
            this.gp_filtros.Name = "gp_filtros";
            this.gp_filtros.Size = new System.Drawing.Size(662, 82);
            this.gp_filtros.TabIndex = 61;
            this.gp_filtros.TabStop = false;
            this.gp_filtros.Text = "Filtros";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(56, 19);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(95, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Descripción";
            // 
            // txt_descrip
            // 
            this.txt_descrip.Location = new System.Drawing.Point(75, 45);
            this.txt_descrip.MaxLength = 25;
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(95, 20);
            this.txt_descrip.TabIndex = 1;
            this.txt_descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // cmb_tipo_maq
            // 
            this.cmb_tipo_maq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_maq.FormattingEnabled = true;
            this.cmb_tipo_maq.Location = new System.Drawing.Point(268, 20);
            this.cmb_tipo_maq.Name = "cmb_tipo_maq";
            this.cmb_tipo_maq.Size = new System.Drawing.Size(140, 21);
            this.cmb_tipo_maq.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Tipo Maquinaria";
            // 
            // btn_aplicar_filtro
            // 
            this.btn_aplicar_filtro.AutoSize = true;
            this.btn_aplicar_filtro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro.Location = new System.Drawing.Point(477, 19);
            this.btn_aplicar_filtro.Name = "btn_aplicar_filtro";
            this.btn_aplicar_filtro.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro.TabIndex = 6;
            this.btn_aplicar_filtro.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro.Click += new System.EventHandler(this.btn_aplicar_filtro_Click);
            // 
            // cmb_estado_maq
            // 
            this.cmb_estado_maq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado_maq.FormattingEnabled = true;
            this.cmb_estado_maq.Location = new System.Drawing.Point(295, 45);
            this.cmb_estado_maq.Name = "cmb_estado_maq";
            this.cmb_estado_maq.Size = new System.Drawing.Size(153, 21);
            this.cmb_estado_maq.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Estado de Maquinaria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_salir_consulta);
            this.groupBox2.Controls.Add(this.btn_nueva);
            this.groupBox2.Location = new System.Drawing.Point(12, 455);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 59);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            // 
            // btn_limpiar_filtros
            // 
            this.btn_limpiar_filtros.AutoSize = true;
            this.btn_limpiar_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar_filtros.Image = global::Vista.Properties.Resources.mop2;
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(389, 15);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 38);
            this.btn_limpiar_filtros.TabIndex = 0;
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros.Click += new System.EventHandler(this.btn_limpiar_filtros_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSize = true;
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_eliminar.Image = global::Vista.Properties.Resources.bin2;
            this.btn_eliminar.Location = new System.Drawing.Point(558, 15);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(38, 38);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_salir_consulta
            // 
            this.btn_salir_consulta.AutoSize = true;
            this.btn_salir_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir_consulta.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir_consulta.Location = new System.Drawing.Point(618, 15);
            this.btn_salir_consulta.Name = "btn_salir_consulta";
            this.btn_salir_consulta.Size = new System.Drawing.Size(38, 38);
            this.btn_salir_consulta.TabIndex = 3;
            this.btn_salir_consulta.UseVisualStyleBackColor = true;
            this.btn_salir_consulta.Click += new System.EventHandler(this.btn_salir_consulta_Click);
            // 
            // btn_nueva
            // 
            this.btn_nueva.AutoSize = true;
            this.btn_nueva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nueva.Image = global::Vista.Properties.Resources.new10;
            this.btn_nueva.Location = new System.Drawing.Point(512, 15);
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(38, 36);
            this.btn_nueva.TabIndex = 1;
            this.btn_nueva.UseVisualStyleBackColor = true;
            this.btn_nueva.Click += new System.EventHandler(this.btn_nueva_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_maquinas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 349);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maquinaria";
            // 
            // dgv_maquinas
            // 
            this.dgv_maquinas.AllowUserToAddRows = false;
            this.dgv_maquinas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_maquinas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_maquinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_maquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_maquinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.descripcion,
            this.tipo,
            this.fechaAlta,
            this.Estado,
            this.idMaquinaria,
            this.idTipo,
            this.idEstado,
            this.opciones});
            this.dgv_maquinas.Location = new System.Drawing.Point(6, 19);
            this.dgv_maquinas.MultiSelect = false;
            this.dgv_maquinas.Name = "dgv_maquinas";
            this.dgv_maquinas.ReadOnly = true;
            this.dgv_maquinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_maquinas.Size = new System.Drawing.Size(650, 324);
            this.dgv_maquinas.TabIndex = 0;
            this.dgv_maquinas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_maquinas_CellContentClick);
            this.dgv_maquinas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_maquinas_CellDoubleClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 69;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 88;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo Maquinaria";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 99;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "Fecha Alta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            this.fechaAlta.Width = 77;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // idMaquinaria
            // 
            this.idMaquinaria.HeaderText = "idMaquinaria";
            this.idMaquinaria.Name = "idMaquinaria";
            this.idMaquinaria.ReadOnly = true;
            this.idMaquinaria.Visible = false;
            // 
            // idTipo
            // 
            this.idTipo.HeaderText = "idTipo";
            this.idTipo.Name = "idTipo";
            this.idTipo.ReadOnly = true;
            this.idTipo.Visible = false;
            // 
            // idEstado
            // 
            this.idEstado.HeaderText = "idEstado";
            this.idEstado.Name = "idEstado";
            this.idEstado.ReadOnly = true;
            this.idEstado.Visible = false;
            // 
            // opciones
            // 
            this.opciones.HeaderText = "Opciones";
            this.opciones.Name = "opciones";
            this.opciones.ReadOnly = true;
            this.opciones.Width = 58;
            // 
            // Consulta_Maquinaria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(686, 525);
            this.Controls.Add(this.gp_filtros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_Maquinaria";
            this.Text = "Consulta Maquinaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consulta_Maquinaria_FormClosed);
            this.Load += new System.EventHandler(this.Consulta_Maquinaria_Load);
            this.gp_filtros.ResumeLayout(false);
            this.gp_filtros.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_maquinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_filtros;
        private System.Windows.Forms.Button btn_aplicar_filtro;
        private System.Windows.Forms.ComboBox cmb_estado_maq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar_filtros;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir_consulta;
        private System.Windows.Forms.Button btn_nueva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_maquinas;
        private System.Windows.Forms.ComboBox cmb_tipo_maq;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaquinaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn opciones;
    }
}