namespace Vista
{
    partial class Gestion_de_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_de_Clientes));
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nro_doc = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.cmb_tipo_doc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_barrio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_depto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_calle_nro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_provincia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_localidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dtp_fechaNac = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.cmd_tipo_cons = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmb_cond_iva = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tab_persona_cliente = new System.Windows.Forms.TabControl();
            this.Persona = new System.Windows.Forms.TabPage();
            this.empresa = new System.Windows.Forms.TabPage();
            this.txt_cuit = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.helpProviderGesCli = new System.Windows.Forms.HelpProvider();
            this.btn_verificar_existencia_persona = new System.Windows.Forms.Button();
            this.btn_verificar_existencia_empresa = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tab_persona_cliente.SuspendLayout();
            this.Persona.SuspendLayout();
            this.empresa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Enabled = false;
            this.txt_razon_social.Location = new System.Drawing.Point(83, 46);
            this.txt_razon_social.MaxLength = 25;
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(134, 20);
            this.txt_razon_social.TabIndex = 3;
            this.txt_razon_social.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_calle_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Razon Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "CUIT/CUIL";
            // 
            // txt_nro_doc
            // 
            this.txt_nro_doc.Enabled = false;
            this.txt_nro_doc.Location = new System.Drawing.Point(80, 44);
            this.txt_nro_doc.MaxLength = 8;
            this.txt_nro_doc.Name = "txt_nro_doc";
            this.txt_nro_doc.Size = new System.Drawing.Size(106, 20);
            this.txt_nro_doc.TabIndex = 2;
            this.txt_nro_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(98, 133);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_nombre.TabIndex = 4;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Apellido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Nro Doc";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            this.txt_apellido.Location = new System.Drawing.Point(97, 159);
            this.txt_apellido.MaxLength = 25;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(201, 20);
            this.txt_apellido.TabIndex = 5;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_doc.Enabled = false;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(80, 15);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Size = new System.Drawing.Size(133, 21);
            this.cmb_tipo_doc.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Tipo Doc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_barrio);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_depto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_piso);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_calle_nro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_calle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_provincia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_localidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de Cliente";
            // 
            // txt_barrio
            // 
            this.txt_barrio.Enabled = false;
            this.txt_barrio.Location = new System.Drawing.Point(438, 103);
            this.txt_barrio.MaxLength = 25;
            this.txt_barrio.Name = "txt_barrio";
            this.txt_barrio.Size = new System.Drawing.Size(128, 20);
            this.txt_barrio.TabIndex = 15;
            this.txt_barrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(365, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Barrio";
            // 
            // txt_depto
            // 
            this.txt_depto.Enabled = false;
            this.txt_depto.Location = new System.Drawing.Point(438, 207);
            this.txt_depto.MaxLength = 10;
            this.txt_depto.Name = "txt_depto";
            this.txt_depto.Size = new System.Drawing.Size(61, 20);
            this.txt_depto.TabIndex = 19;
            this.txt_depto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Depto";
            // 
            // txt_piso
            // 
            this.txt_piso.Enabled = false;
            this.txt_piso.Location = new System.Drawing.Point(438, 181);
            this.txt_piso.MaxLength = 10;
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(62, 20);
            this.txt_piso.TabIndex = 18;
            this.txt_piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Piso";
            // 
            // txt_calle_nro
            // 
            this.txt_calle_nro.Enabled = false;
            this.txt_calle_nro.Location = new System.Drawing.Point(438, 155);
            this.txt_calle_nro.MaxLength = 10;
            this.txt_calle_nro.Name = "txt_calle_nro";
            this.txt_calle_nro.Size = new System.Drawing.Size(61, 20);
            this.txt_calle_nro.TabIndex = 17;
            this.txt_calle_nro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Número";
            // 
            // txt_calle
            // 
            this.txt_calle.Enabled = false;
            this.txt_calle.Location = new System.Drawing.Point(438, 129);
            this.txt_calle.MaxLength = 25;
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(148, 20);
            this.txt_calle.TabIndex = 16;
            this.txt_calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_calle_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Calle";
            // 
            // cmb_provincia
            // 
            this.cmb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_provincia.Enabled = false;
            this.cmb_provincia.FormattingEnabled = true;
            this.cmb_provincia.Location = new System.Drawing.Point(437, 49);
            this.cmb_provincia.Name = "cmb_provincia";
            this.cmb_provincia.Size = new System.Drawing.Size(148, 21);
            this.cmb_provincia.TabIndex = 13;
            this.cmb_provincia.SelectionChangeCommitted += new System.EventHandler(this.cmb_provincia_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Provincia";
            // 
            // cmb_localidad
            // 
            this.cmb_localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_localidad.Enabled = false;
            this.cmb_localidad.FormattingEnabled = true;
            this.cmb_localidad.Location = new System.Drawing.Point(438, 76);
            this.cmb_localidad.Name = "cmb_localidad";
            this.cmb_localidad.Size = new System.Drawing.Size(148, 21);
            this.cmb_localidad.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Localidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(347, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 375);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Direccion";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_sexo);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.dtp_fechaNac);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.cmd_tipo_cons);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.cmb_cond_iva);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txt_celular);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.tab_persona_cliente);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt_telefono);
            this.groupBox4.Controls.Add(this.txt_apellido);
            this.groupBox4.Controls.Add(this.txt_nombre);
            this.groupBox4.Controls.Add(this.txt_mail);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(15, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 375);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Personales";
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sexo.Enabled = false;
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Location = new System.Drawing.Point(98, 208);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(121, 21);
            this.cmb_sexo.TabIndex = 79;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 211);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 13);
            this.label24.TabIndex = 78;
            this.label24.Text = "Sexo";
            // 
            // dtp_fechaNac
            // 
            this.dtp_fechaNac.Enabled = false;
            this.dtp_fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaNac.Location = new System.Drawing.Point(98, 184);
            this.dtp_fechaNac.Name = "dtp_fechaNac";
            this.dtp_fechaNac.Size = new System.Drawing.Size(93, 20);
            this.dtp_fechaNac.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 188);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 13);
            this.label23.TabIndex = 76;
            this.label23.Text = "Fecha Nacimiento";
            // 
            // cmd_tipo_cons
            // 
            this.cmd_tipo_cons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_tipo_cons.Enabled = false;
            this.cmd_tipo_cons.FormattingEnabled = true;
            this.cmd_tipo_cons.Location = new System.Drawing.Point(98, 340);
            this.cmd_tipo_cons.Name = "cmd_tipo_cons";
            this.cmd_tipo_cons.Size = new System.Drawing.Size(158, 21);
            this.cmd_tipo_cons.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 343);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 74;
            this.label22.Text = "Tipo Consumidor";
            // 
            // cmb_cond_iva
            // 
            this.cmb_cond_iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cond_iva.Enabled = false;
            this.cmb_cond_iva.FormattingEnabled = true;
            this.cmb_cond_iva.Location = new System.Drawing.Point(97, 313);
            this.cmb_cond_iva.Name = "cmb_cond_iva";
            this.cmb_cond_iva.Size = new System.Drawing.Size(158, 21);
            this.cmb_cond_iva.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 316);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 72;
            this.label21.Text = "Condición IVA";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(195, 290);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 13);
            this.label20.TabIndex = 71;
            this.label20.Text = "ej: 03541-15662539";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(84, 290);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 70;
            this.label19.Text = "0";
            // 
            // txt_celular
            // 
            this.txt_celular.Enabled = false;
            this.txt_celular.Location = new System.Drawing.Point(97, 287);
            this.txt_celular.Mask = "0000-00000000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(92, 20);
            this.txt_celular.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 290);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 68;
            this.label18.Text = "Celular";
            // 
            // tab_persona_cliente
            // 
            this.tab_persona_cliente.Controls.Add(this.Persona);
            this.tab_persona_cliente.Controls.Add(this.empresa);
            this.tab_persona_cliente.Location = new System.Drawing.Point(9, 22);
            this.tab_persona_cliente.Name = "tab_persona_cliente";
            this.tab_persona_cliente.SelectedIndex = 0;
            this.tab_persona_cliente.Size = new System.Drawing.Size(247, 104);
            this.tab_persona_cliente.TabIndex = 67;
            // 
            // Persona
            // 
            this.Persona.BackColor = System.Drawing.SystemColors.Control;
            this.Persona.Controls.Add(this.label12);
            this.Persona.Controls.Add(this.label11);
            this.Persona.Controls.Add(this.txt_nro_doc);
            this.Persona.Controls.Add(this.cmb_tipo_doc);
            this.Persona.Controls.Add(this.btn_verificar_existencia_persona);
            this.Persona.Location = new System.Drawing.Point(4, 22);
            this.Persona.Name = "Persona";
            this.Persona.Padding = new System.Windows.Forms.Padding(3);
            this.Persona.Size = new System.Drawing.Size(239, 78);
            this.Persona.TabIndex = 0;
            this.Persona.Text = "Persona";
            // 
            // empresa
            // 
            this.empresa.BackColor = System.Drawing.SystemColors.Control;
            this.empresa.Controls.Add(this.txt_cuit);
            this.empresa.Controls.Add(this.label2);
            this.empresa.Controls.Add(this.label1);
            this.empresa.Controls.Add(this.txt_razon_social);
            this.empresa.Controls.Add(this.btn_verificar_existencia_empresa);
            this.empresa.Location = new System.Drawing.Point(4, 22);
            this.empresa.Name = "empresa";
            this.empresa.Padding = new System.Windows.Forms.Padding(3);
            this.empresa.Size = new System.Drawing.Size(239, 78);
            this.empresa.TabIndex = 1;
            this.empresa.Text = "Empresa";
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(85, 14);
            this.txt_cuit.Mask = "00-00000000-0";
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(100, 20);
            this.txt_cuit.TabIndex = 1;
            this.txt_cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(180, 264);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 66;
            this.label17.Text = "ej: 03541-430280";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(84, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Enabled = false;
            this.txt_telefono.Location = new System.Drawing.Point(96, 261);
            this.txt_telefono.Mask = "9999-000000";
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(78, 20);
            this.txt_telefono.TabIndex = 9;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_doc_KeyPress);
            // 
            // txt_mail
            // 
            this.txt_mail.Enabled = false;
            this.txt_mail.Location = new System.Drawing.Point(97, 236);
            this.txt_mail.MaxLength = 50;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(201, 20);
            this.txt_mail.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "e-mail";
            // 
            // helpProviderGesCli
            // 
            this.helpProviderGesCli.HelpNamespace = ".\\Ayuda\\Luiggi.chm";
            // 
            // btn_verificar_existencia_persona
            // 
            this.btn_verificar_existencia_persona.AutoSize = true;
            this.btn_verificar_existencia_persona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_verificar_existencia_persona.Image = global::Vista.Properties.Resources.magnifier14;
            this.btn_verificar_existencia_persona.Location = new System.Drawing.Point(193, 42);
            this.btn_verificar_existencia_persona.Name = "btn_verificar_existencia_persona";
            this.btn_verificar_existencia_persona.Size = new System.Drawing.Size(22, 22);
            this.btn_verificar_existencia_persona.TabIndex = 3;
            this.btn_verificar_existencia_persona.UseVisualStyleBackColor = true;
            this.btn_verificar_existencia_persona.Click += new System.EventHandler(this.btn_verificar_existencia_persona_Click);
            // 
            // btn_verificar_existencia_empresa
            // 
            this.btn_verificar_existencia_empresa.AutoSize = true;
            this.btn_verificar_existencia_empresa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_verificar_existencia_empresa.Image = global::Vista.Properties.Resources.magnifier14;
            this.btn_verificar_existencia_empresa.Location = new System.Drawing.Point(197, 12);
            this.btn_verificar_existencia_empresa.Name = "btn_verificar_existencia_empresa";
            this.btn_verificar_existencia_empresa.Size = new System.Drawing.Size(22, 22);
            this.btn_verificar_existencia_empresa.TabIndex = 2;
            this.btn_verificar_existencia_empresa.UseVisualStyleBackColor = true;
            this.btn_verificar_existencia_empresa.Click += new System.EventHandler(this.btn_verificar_existencia_empresa_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_nuevo.Image = global::Vista.Properties.Resources.mop2;
            this.btn_nuevo.Location = new System.Drawing.Point(428, 19);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(38, 38);
            this.btn_nuevo.TabIndex = 21;
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
            this.btn_guardar.TabIndex = 20;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir.Location = new System.Drawing.Point(587, 19);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(38, 38);
            this.btn_salir.TabIndex = 22;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Location = new System.Drawing.Point(12, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Gestion_de_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.helpProviderGesCli.SetHelpKeyword(this, "7");
            this.helpProviderGesCli.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Gestion_de_Clientes";
            this.helpProviderGesCli.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion_de_Clientes";
            this.Load += new System.EventHandler(this.Gestion_de_Clientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tab_persona_cliente.ResumeLayout(false);
            this.Persona.ResumeLayout(false);
            this.Persona.PerformLayout();
            this.empresa.ResumeLayout(false);
            this.empresa.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nro_doc;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.ComboBox cmb_tipo_doc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_provincia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_localidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_barrio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_depto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_calle_nro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_verificar_existencia_empresa;
        private System.Windows.Forms.Button btn_verificar_existencia_persona;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.MaskedTextBox txt_telefono;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tab_persona_cliente;
        private System.Windows.Forms.TabPage Persona;
        private System.Windows.Forms.TabPage empresa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmb_cond_iva;
        private System.Windows.Forms.ComboBox cmd_tipo_cons;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox txt_cuit;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtp_fechaNac;
        private System.Windows.Forms.ComboBox cmb_sexo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.HelpProvider helpProviderGesCli;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}