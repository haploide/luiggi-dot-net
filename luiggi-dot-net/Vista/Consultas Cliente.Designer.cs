namespace Vista
{
    partial class Consultas_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas_Cliente));
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.nroCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinvia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprovincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConsumidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cuit = new System.Windows.Forms.MaskedTextBox();
            this.btn_aplicar_filtro_persona = new System.Windows.Forms.Button();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nro_doc = new System.Windows.Forms.TextBox();
            this.btn_aplicar_filtro_empresa = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.cmb_tipo_doc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_limpiar_filtros = new System.Windows.Forms.Button();
            this.btn_salir_consulta = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProviderConsultasClientes = new System.Windows.Forms.HelpProvider();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroCli,
            this.apellido,
            this.Nombre,
            this.raSocial,
            this.cuit,
            this.tipoDoc,
            this.nroDoc,
            this.calle,
            this.calleNro,
            this.piso,
            this.depto,
            this.barrio,
            this.localidad,
            this.provinvia,
            this.mail,
            this.telefono,
            this.idtipo,
            this.idprovincia,
            this.idlocalidad,
            this.idCondicion,
            this.idConsumidor,
            this.celular,
            this.fecha,
            this.sexo});
            this.dgv_clientes.Location = new System.Drawing.Point(6, 19);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(737, 320);
            this.dgv_clientes.TabIndex = 39;
            this.dgv_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellDoubleClick);
            // 
            // nroCli
            // 
            this.nroCli.HeaderText = "Nro Cliente";
            this.nroCli.Name = "nroCli";
            this.nroCli.ReadOnly = true;
            this.nroCli.Visible = false;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 69;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // raSocial
            // 
            this.raSocial.HeaderText = "Razon Social";
            this.raSocial.Name = "raSocial";
            this.raSocial.ReadOnly = true;
            this.raSocial.Width = 95;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT/CUIL";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            this.cuit.Visible = false;
            // 
            // tipoDoc
            // 
            this.tipoDoc.HeaderText = "Tipo Doc";
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            this.tipoDoc.Visible = false;
            // 
            // nroDoc
            // 
            this.nroDoc.HeaderText = "Nro Doc";
            this.nroDoc.Name = "nroDoc";
            this.nroDoc.ReadOnly = true;
            this.nroDoc.Visible = false;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 55;
            // 
            // calleNro
            // 
            this.calleNro.HeaderText = "Nro";
            this.calleNro.Name = "calleNro";
            this.calleNro.ReadOnly = true;
            this.calleNro.Width = 49;
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
            this.barrio.Width = 59;
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
            // mail
            // 
            this.mail.HeaderText = "e-mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Visible = false;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 74;
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
            // idCondicion
            // 
            this.idCondicion.HeaderText = "idCondicion";
            this.idCondicion.Name = "idCondicion";
            this.idCondicion.ReadOnly = true;
            this.idCondicion.Visible = false;
            // 
            // idConsumidor
            // 
            this.idConsumidor.HeaderText = "idConsumidor";
            this.idConsumidor.Name = "idConsumidor";
            this.idConsumidor.ReadOnly = true;
            this.idConsumidor.Visible = false;
            // 
            // celular
            // 
            this.celular.HeaderText = "Tel Cel";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 65;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Visible = false;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cuit);
            this.groupBox1.Controls.Add(this.btn_aplicar_filtro_persona);
            this.groupBox1.Controls.Add(this.txt_razon_social);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nro_doc);
            this.groupBox1.Controls.Add(this.btn_aplicar_filtro_empresa);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.cmb_tipo_doc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 87);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(508, 44);
            this.txt_cuit.Mask = "00-00000000-0";
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(100, 20);
            this.txt_cuit.TabIndex = 40;
            this.txt_cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
            // 
            // btn_aplicar_filtro_persona
            // 
            this.btn_aplicar_filtro_persona.AutoSize = true;
            this.btn_aplicar_filtro_persona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro_persona.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro_persona.Location = new System.Drawing.Point(379, 18);
            this.btn_aplicar_filtro_persona.Name = "btn_aplicar_filtro_persona";
            this.btn_aplicar_filtro_persona.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro_persona.TabIndex = 39;
            this.btn_aplicar_filtro_persona.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro_persona.Visible = false;
            this.btn_aplicar_filtro_persona.Click += new System.EventHandler(this.btn_aplicar_filtro_persona_Click);
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Location = new System.Drawing.Point(508, 18);
            this.txt_razon_social.MaxLength = 25;
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(95, 20);
            this.txt_razon_social.TabIndex = 35;
            this.txt_razon_social.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_razon_social_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Razon Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "CUIT/CUIL";
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Location = new System.Drawing.Point(241, 47);
            this.txt_nro_doc.MaxLength = 8;
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.Size = new System.Drawing.Size(121, 20);
            this.txt_nro_doc.TabIndex = 34;
            this.txt_nro_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
            // 
            // btn_aplicar_filtro_empresa
            // 
            this.btn_aplicar_filtro_empresa.AutoSize = true;
            this.btn_aplicar_filtro_empresa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aplicar_filtro_empresa.Image = global::Vista.Properties.Resources.looking2;
            this.btn_aplicar_filtro_empresa.Location = new System.Drawing.Point(621, 18);
            this.btn_aplicar_filtro_empresa.Name = "btn_aplicar_filtro_empresa";
            this.btn_aplicar_filtro_empresa.Size = new System.Drawing.Size(38, 46);
            this.btn_aplicar_filtro_empresa.TabIndex = 33;
            this.btn_aplicar_filtro_empresa.UseVisualStyleBackColor = true;
            this.btn_aplicar_filtro_empresa.Click += new System.EventHandler(this.btn_aplicar_filtro_empresa_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(67, 18);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(95, 20);
            this.txt_nombre.TabIndex = 25;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Apellido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Nro Doc";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(67, 47);
            this.txt_apellido.MaxLength = 25;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(95, 20);
            this.txt_apellido.TabIndex = 28;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(241, 18);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_doc.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tipo Doc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_limpiar_filtros);
            this.groupBox2.Controls.Add(this.btn_salir_consulta);
            this.groupBox2.Location = new System.Drawing.Point(12, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 59);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.AutoSize = true;
            this.btn_limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar.Image = global::Vista.Properties.Resources.mop2;
            this.btn_limpiar.Location = new System.Drawing.Point(523, 15);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(38, 38);
            this.btn_limpiar.TabIndex = 0;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSize = true;
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_eliminar.Image = global::Vista.Properties.Resources.bin2;
            this.btn_eliminar.Location = new System.Drawing.Point(637, 15);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(38, 38);
            this.btn_eliminar.TabIndex = 42;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_limpiar_filtros
            // 
            this.btn_limpiar_filtros.AutoSize = true;
            this.btn_limpiar_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar_filtros.Image = global::Vista.Properties.Resources.new10;
            this.btn_limpiar_filtros.Location = new System.Drawing.Point(593, 17);
            this.btn_limpiar_filtros.Name = "btn_limpiar_filtros";
            this.btn_limpiar_filtros.Size = new System.Drawing.Size(38, 36);
            this.btn_limpiar_filtros.TabIndex = 40;
            this.btn_limpiar_filtros.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros.Click += new System.EventHandler(this.btn_limpiar_filtros_Click);
            // 
            // btn_salir_consulta
            // 
            this.btn_salir_consulta.AutoSize = true;
            this.btn_salir_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir_consulta.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir_consulta.Location = new System.Drawing.Point(705, 15);
            this.btn_salir_consulta.Name = "btn_salir_consulta";
            this.btn_salir_consulta.Size = new System.Drawing.Size(38, 38);
            this.btn_salir_consulta.TabIndex = 41;
            this.btn_salir_consulta.UseVisualStyleBackColor = true;
            this.btn_salir_consulta.Click += new System.EventHandler(this.btn_salir_consulta_Click);
            // 
            // helpProviderConsultasClientes
            // 
            this.helpProviderConsultasClientes.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_clientes);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(749, 345);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes";
            // 
            // Consultas_Cliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(775, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.helpProviderConsultasClientes.SetHelpKeyword(this, "5");
            this.helpProviderConsultasClientes.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas_Cliente";
            this.helpProviderConsultasClientes.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consultas_Cliente_FormClosed);
            this.Load += new System.EventHandler(this.Consultas_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir_consulta;
        private System.Windows.Forms.Button btn_limpiar_filtros;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_aplicar_filtro_empresa;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.ComboBox cmb_tipo_doc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nro_doc;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aplicar_filtro_persona;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox txt_cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn raSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinvia;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprovincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsumidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.HelpProvider helpProviderConsultasClientes;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}