namespace Vista
{
    partial class ActualizarStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarStock));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidad_real = new System.Windows.Forms.TextBox();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_detalle_Productos = new System.Windows.Forms.DataGridView();
            this.nroProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPlanificada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Actualizar_OTPadre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detalle_Productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad real producida:";
            // 
            // txt_cantidad_real
            // 
            this.txt_cantidad_real.Location = new System.Drawing.Point(218, 45);
            this.txt_cantidad_real.Name = "txt_cantidad_real";
            this.txt_cantidad_real.Size = new System.Drawing.Size(93, 20);
            this.txt_cantidad_real.TabIndex = 1;
            this.txt_cantidad_real.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_real_KeyPress);
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidad.ForeColor = System.Drawing.Color.Blue;
            this.lbl_unidad.Location = new System.Drawing.Point(317, 46);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(0, 20);
            this.lbl_unidad.TabIndex = 0;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.ForeColor = System.Drawing.Color.Blue;
            this.lbl_producto.Location = new System.Drawing.Point(97, 16);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(0, 20);
            this.lbl_producto.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Productos Utilizados: ";
            // 
            // DGV_detalle_Productos
            // 
            this.DGV_detalle_Productos.AllowUserToAddRows = false;
            this.DGV_detalle_Productos.AllowUserToDeleteRows = false;
            this.DGV_detalle_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_detalle_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_detalle_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroProducto,
            this.producto,
            this.cantidadPlanificada,
            this.cantidadReal,
            this.unidad});
            this.DGV_detalle_Productos.Location = new System.Drawing.Point(10, 99);
            this.DGV_detalle_Productos.Name = "DGV_detalle_Productos";
            this.DGV_detalle_Productos.Size = new System.Drawing.Size(446, 150);
            this.DGV_detalle_Productos.TabIndex = 2;
            // 
            // nroProducto
            // 
            this.nroProducto.HeaderText = "Column1";
            this.nroProducto.Name = "nroProducto";
            this.nroProducto.ReadOnly = true;
            this.nroProducto.Visible = false;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // cantidadPlanificada
            // 
            this.cantidadPlanificada.HeaderText = "Cantidad";
            this.cantidadPlanificada.Name = "cantidadPlanificada";
            this.cantidadPlanificada.ReadOnly = true;
            // 
            // cantidadReal
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cantidadReal.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantidadReal.HeaderText = "Cantidad Real";
            this.cantidadReal.Name = "cantidadReal";
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackgroundImage = global::Vista.Properties.Resources.floppy1;
            this.btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Actualizar.Location = new System.Drawing.Point(10, 19);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(38, 38);
            this.btn_Actualizar.TabIndex = 3;
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Visible = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salir.Image = global::Vista.Properties.Resources.exit6;
            this.btn_salir.Location = new System.Drawing.Point(419, 19);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(38, 38);
            this.btn_salir.TabIndex = 23;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Actualizar_OTPadre
            // 
            this.btn_Actualizar_OTPadre.BackgroundImage = global::Vista.Properties.Resources.floppy1;
            this.btn_Actualizar_OTPadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Actualizar_OTPadre.Location = new System.Drawing.Point(10, 19);
            this.btn_Actualizar_OTPadre.Name = "btn_Actualizar_OTPadre";
            this.btn_Actualizar_OTPadre.Size = new System.Drawing.Size(38, 38);
            this.btn_Actualizar_OTPadre.TabIndex = 3;
            this.btn_Actualizar_OTPadre.UseVisualStyleBackColor = true;
            this.btn_Actualizar_OTPadre.Visible = false;
            this.btn_Actualizar_OTPadre.Click += new System.EventHandler(this.btn_Actualizar_OTPadre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_unidad);
            this.groupBox1.Controls.Add(this.DGV_detalle_Productos);
            this.groupBox1.Controls.Add(this.lbl_producto);
            this.groupBox1.Controls.Add(this.txt_cantidad_real);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 259);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Actualizar_OTPadre);
            this.groupBox2.Controls.Add(this.btn_Actualizar);
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Location = new System.Drawing.Point(12, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 70);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // ActualizarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActualizarStock";
            this.Text = "Actualizar Stock";
            this.Load += new System.EventHandler(this.ActualizarStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detalle_Productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cantidad_real;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_detalle_Productos;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPlanificada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_Actualizar_OTPadre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}