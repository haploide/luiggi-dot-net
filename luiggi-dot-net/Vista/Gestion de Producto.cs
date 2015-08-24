using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Controlador;
using System.IO;
using System.Drawing.Imaging;
using DAO;



namespace Vista
{
    
    public partial class Gestion_de_Producto : Form
    {
        int b = 0;
        private GestorRegistrarProducto gestor;
        private string dirFoto;
        private Producto prodModificar;
        private estados estadoFormulario;
        private Boolean mostrar;
        public estados _estado
        {
            get { return estadoFormulario; }
            set { estadoFormulario = value; }
        }
        public Producto _prodModificar
        {
            get { return prodModificar;}
            set { prodModificar = value; }
        }
        public Gestion_de_Producto()
        {
            InitializeComponent();
        }
        private void Gestion_de_Producto_Load(object sender, EventArgs e)
        {

            gestor = new GestorRegistrarProducto();
            if (estadoFormulario == estados.nuevo)
            {
                gestor.nuevoProducto();
                habilitarPantalla();
            }

            cargarCombos();
            if (estadoFormulario == estados.modificar && !(prodModificar == null))
            {
                txt_nombre_producto.Enabled = true;
                btn_verificar_existencia.Enabled = true;
                mostrar = true;
                desbloquearCampos();
                cargarModificacion();
            }
            comprobarUnidadMedida();
            
        }
        private void cargarModificacion() 
        {
            txt_nombre_producto.Text = prodModificar.Nombre;
            txt_descripcion_producto.Text = prodModificar.Descripcion;
            txt_stock_riesgo.Text = prodModificar.StockRiesgo.ToString();
            txt_precio_minorista.Text = prodModificar.precio.ToString();
            //foto
            cmb_categoria.SelectedValue = prodModificar.Categoria.IDCategoria;
            cmb_unidad_medida.SelectedValue = prodModificar.Unidad.IDUnidad;
            
            btn_verificar_existencia.Enabled = false;
           // txt_nombre_producto.Enabled = false;
            Byte[] byteImagen = prodModificar.foto;
            MemoryStream ms = new MemoryStream(byteImagen);
            pb_foto.Image = Image.FromStream(ms);
            pb_foto.SizeMode = PictureBoxSizeMode.StretchImage;

            txtHorasHombre.Text = prodModificar.tiempoProduccion.ToString();
            txt_Precio_Mayorista.Text = prodModificar.precioMayorista.ToString();
            cmbTipoMaquinarias.SelectedValue = prodModificar.tipoMaquina.idTipoMaquinaria;
            cmb_tiempo.SelectedValue = prodModificar.UnidadTiempo.IDUnidad;
            txtCantidad.Text = prodModificar.cantidadProductos.ToString();
            
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        public void habilitarPantalla()
        {
            txt_nombre_producto.Enabled = true;
        }
        public void cargarCombos()
        {
            List<Categoria> cat = gestor.buscarCategorias();
            List<UnidadMedida> uni = gestor.buscarUnidadDeMedida();
            List<TipoMaquinaria> maq = TipoMaquinariaDAO.GetAll();
            List<UnidadMedida> tiemp = gestor.buscarUnidadDeTiempo();
           


            
            cmb_categoria.DataSource = cat;
            cmb_categoria.DisplayMember = "Nombre";
            cmb_categoria.ValueMember = "IDCategoria";
           
            cmb_unidad_medida.DataSource = uni;
            cmb_unidad_medida.DisplayMember = "Nombre";
            cmb_unidad_medida.ValueMember = "IDUnidad";

            cmb_unidad_catidad.DataSource = uni;
            cmb_unidad_catidad.DisplayMember = "Nombre";
            cmb_unidad_catidad.ValueMember = "IDUnidad";
            
            
            cmbTipoMaquinarias.DataSource = maq;
            cmbTipoMaquinarias.DisplayMember = "nombre";
            cmbTipoMaquinarias.ValueMember = "idTipoMaquinaria";
          
            cmb_tiempo.DataSource   = tiemp;
            cmb_tiempo.DisplayMember = "Nombre";
            cmb_tiempo.ValueMember = "IDUnidad";
            
        }
        public void desbloquearCampos()
        {
            btn_guardar.Enabled = true;
            txt_descripcion_producto.Enabled = true;
            txt_stock_riesgo.Enabled = true;
            txt_precio_minorista.Enabled = true;
            txt_Precio_Mayorista.Enabled = true;
            cmb_categoria.Enabled = true;
            cmb_unidad_medida.Enabled = true;
            cmbTipoMaquinarias.Enabled = true;
            btn_buscar_imagen.Enabled = true;
            cmb_tiempo.Enabled = true;
            txt_descripcion_producto.Focus();
        }
        public void bloquearCampos()
        {
            btn_guardar.Enabled = false;
            txt_descripcion_producto.Enabled = false;
            txt_stock_riesgo.Enabled = false;
            txt_precio_minorista.Enabled = false;
            txt_Precio_Mayorista.Enabled = false;
            cmb_categoria.Enabled = false;
            cmb_unidad_medida.Enabled = false;
            btn_buscar_imagen.Enabled = false;
            cmbTipoMaquinarias.Enabled = false ;
            cmb_tiempo.Enabled = false;
            txt_nombre_producto.Focus();
        }
        private void btn_verificar_existencia_Click(object sender, EventArgs e)
        {
            if (!txt_nombre_producto.Text.Equals(""))
            {
                gestor.nombreProductoTomado(txt_nombre_producto.Text);

                try
                {
                    if (gestor.verificarExistenciaProducto())
                    {
                        MessageBox.Show(this, "El Producto ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        desbloquearCampos();
                        mostrar = true;
                        comprobarUnidadMedida();
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                

            }
            else
            {
                MessageBox.Show("Complete el campo\"Nombre\" antes de verificar su existencia", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void txt_nombre_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar)|| char.IsSymbol(e.KeyChar))
            {
                e.KeyChar=(char)Keys.Clear;
                return;
            }
            
        }
        private void txt_stock_riesgo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private void darFoco()
        {
            if (txt_nombre_producto.Text == "")
            {
                txt_nombre_producto.Focus();
                return;
            }
            if (txt_descripcion_producto.Text == "")
            {
                txt_descripcion_producto.Focus();
                return;
            }
            if (txt_stock_riesgo.Text == "")
            {
                txt_stock_riesgo.Focus();
                return;
            }
            if (txt_precio_minorista.Text == "")
            {
                txt_precio_minorista.Focus();
                return;
            }
        }
        private void limpiarCampos()
        {
            txt_nombre_producto.Text = "";
            txt_descripcion_producto.Text = "";
            txt_stock_riesgo.Text = "";
            txt_precio_minorista.Text = "";
            cmb_categoria.SelectedIndex = 0;
            cmb_unidad_medida.SelectedIndex = 0;
            cmb_tiempo.SelectedIndex = 0;
            cmbTipoMaquinarias.SelectedIndex = 0;
            estadoFormulario = estados.nuevo;
            pb_foto.Image = Vista.Properties.Resources.photo3;
            pb_foto.SizeMode = PictureBoxSizeMode.CenterImage;
            bloquearCampos();
            darFoco();
            txt_Precio_Mayorista.Text = "";
            txtHorasHombre.Text = "";
            lbl_tipo_maquinaria.Visible = false;
            lbl_precio_minorista.Visible = false;
            lbl_precio_mayorista.Visible = false;
            txt_Precio_Mayorista.Visible = false;
            txt_precio_minorista.Visible = false;
            cmbTipoMaquinarias.Visible = false;
            grb_Horas.Visible = false;
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private Boolean validarCampos()
        {
            if (txt_nombre_producto.Text == "")
            {
                MessageBox.Show("Complete el campo\"Nombre\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_nombre_producto.Focus();
                return false;
            }
            if (txt_descripcion_producto.Text == "")
            {
                MessageBox.Show("Complete el campo\"Descripcion\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                txt_descripcion_producto.Focus();
                return false;
            }
            if (txt_stock_riesgo.Text == "")
            {
                MessageBox.Show("Complete el campo\"Stock de Riesgo\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                txt_stock_riesgo.Focus();
                return false;
            }
            if (txt_stock_riesgo.TextLength >= 6)
            {
                MessageBox.Show("El campo\"Stock de Riesgo\" contiene un numero muy grande", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                txt_stock_riesgo.Focus();
                return false;
            }
            if (txt_precio_minorista.Text == "")
            {
                MessageBox.Show("Complete el campo\"Precio\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                txt_precio_minorista.Focus();
                return false;
            }
            if (txt_precio_minorista.TextLength>=6)
            {
                MessageBox.Show("El campo\"Precio\" contiene un numero muy grande", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                txt_precio_minorista.Focus();
                return false;
            }
            //if (pb_foto.Image.PixelFormat==Vista.Properties.Resources.photo3.PixelFormat)
            //{
            //    MessageBox.Show("No cargo ninguna Foto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            //    btn_buscar_imagen.Focus();
            //    return false;
            //}

            return true;
        }
        private void btn_buscar_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            //Aquí incluiremos los filtros que queramos.

            BuscarImagen.FileName = "";

            BuscarImagen.Title = "Buscar Foto...";

            BuscarImagen.InitialDirectory = "C:\\";
            //BuscarImagen.FileName = this.textBox1.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {

                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control


                dirFoto = BuscarImagen.FileName;
                String Direccion = BuscarImagen.FileName;
                this.pb_foto.ImageLocation = Direccion;


                //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 



                //this.pictureBox1.ImageLocation = textBox1.Text;


                pb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (_estado == estados.nuevo && validarCampos() == true)
            {
                MemoryStream memoriaImagen = new MemoryStream();
                pb_foto.Image.Save(memoriaImagen, ImageFormat.Jpeg);
                Byte [] byteFoto = new byte[memoriaImagen.Length];
                memoriaImagen.Position = 0;
                memoriaImagen.Read(byteFoto, 0, Convert.ToInt32(memoriaImagen.Length));

                gestor.datosProductoTomado(txt_nombre_producto.Text, Convert.ToInt32(txt_stock_riesgo.Text), Convert.ToDouble(txt_precio_minorista.Text), txt_descripcion_producto.Text, byteFoto,Convert.ToDouble( txt_Precio_Mayorista.Text), Convert.ToDouble(txtHorasHombre.Text), Convert.ToDouble(txtCantidad.Text)  );
                gestor.categoriaSeleccionada(new Categoria() { IDCategoria = Convert.ToInt32(cmb_categoria.SelectedValue), Nombre = cmb_categoria.SelectedText });
                gestor.unidadSeleccionada(new UnidadMedida() { IDUnidad = Convert.ToInt32(cmb_unidad_medida.SelectedValue), Nombre = cmb_unidad_medida.SelectedItem.ToString() });
                gestor.tipoMaquinariaSeleccionada (new TipoMaquinaria (){ idTipoMaquinaria = Convert.ToInt32(cmbTipoMaquinarias.SelectedValue ),Nombre = cmb_unidad_medida.SelectedItem.ToString() });
                gestor.UnidadTiempoSeleccionada(new UnidadMedida() { IDUnidad  = Convert.ToInt32(cmb_tiempo.SelectedValue), Nombre = cmb_tiempo.SelectedItem.ToString() });
                try
                {
                    gestor.registroConfirmado();
                    MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                if (cmb_categoria.SelectedText == "Producto Final")
                {
                    if (MessageBox.Show("Desea cargar la estructura del producto: " + txt_nombre_producto.Text, "ATENCION",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Gestionar_Estructura_Productos gest = new Gestionar_Estructura_Productos();
                        gest.ShowDialog();
                    }
                }
                limpiarCampos();
            }
            else
            {
                if (_estado == estados.modificar && validarCampos() == true)
                {
                    if (txt_nombre_producto.Text != prodModificar.Nombre)
                    {
                        gestor.nombreProductoTomado(txt_nombre_producto.Text);

                        try
                        {
                            if (gestor.verificarExistenciaProducto())
                            {
                                MessageBox.Show(this, "El Producto ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                            }
                            else
                            {
                                desbloquearCampos();
                            }
                        }
                        catch (ApplicationException ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        
                
                    }

                    MemoryStream memoriaImagen = new MemoryStream();
                    pb_foto.Image.Save(memoriaImagen, ImageFormat.Jpeg);
                    Byte[] byteFoto = new byte[memoriaImagen.Length];
                    memoriaImagen.Position = 0;
                    memoriaImagen.Read(byteFoto, 0, Convert.ToInt32(memoriaImagen.Length));

                    gestor.nombreProductoTomado(txt_nombre_producto.Text);
                    gestor.codigoTomado(prodModificar.CODProducto);
                    gestor.datosProductoTomado(txt_nombre_producto.Text, Convert.ToInt32(txt_stock_riesgo.Text), Convert.ToDouble(txt_precio_minorista.Text), txt_descripcion_producto.Text, byteFoto, Convert.ToDouble(txt_Precio_Mayorista.Text), Convert.ToDouble(txtHorasHombre.Text), Convert.ToDouble (txtCantidad.Text));
                    gestor.categoriaSeleccionada(new Categoria() { IDCategoria = Convert.ToInt32(cmb_categoria.SelectedValue), Nombre = cmb_categoria.SelectedText });
                    gestor.unidadSeleccionada(new UnidadMedida() { IDUnidad = Convert.ToInt32(cmb_unidad_medida.SelectedValue), Nombre = cmb_unidad_medida.SelectedItem.ToString() });
                    gestor.tipoMaquinariaSeleccionada(new TipoMaquinaria() { idTipoMaquinaria = Convert.ToInt32(cmbTipoMaquinarias.SelectedValue), Nombre = cmb_unidad_medida.SelectedItem.ToString() });
                    gestor.UnidadTiempoSeleccionada(new UnidadMedida() { IDUnidad = Convert.ToInt32(cmb_tiempo.SelectedValue), Nombre = cmb_tiempo.SelectedItem.ToString() });
                    
                    try
                    {
                        gestor.modificacionConfirmada();
                        MessageBox.Show("Modificado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        Close();
                        Dispose();
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }

        }
        
        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            comprobarUnidadMedida();
           
            
        }
        private void comprobarUnidadMedida()
        {
            if (cmb_categoria.SelectedIndex == 0 && mostrar == true )
            {
                //lbl_precio_mayorista.Visible = true;
                lbl_precio_minorista.Visible = true;
                lbl_tipo_maquinaria.Visible = true;
                txt_precio_minorista.Visible = true;
                //txt_Precio_Mayorista.Visible = true;
                
                cmbTipoMaquinarias.Visible = true;
                grb_Horas.Visible = true;
            }
            else
            {
                if (cmb_categoria.SelectedIndex == 1)
                {
                    cmbTipoMaquinarias.Visible = true;
                    grb_Horas.Visible = true;
                    lbl_tipo_maquinaria.Visible = true;
                }
                txt_precio_minorista.Visible = false;
                txt_Precio_Mayorista.Visible = false;
                lbl_precio_mayorista.Visible = false;
                lbl_precio_minorista.Visible = false;
                
                txt_Precio_Mayorista.Text = "0";
                txt_precio_minorista.Text = "0";
                
                if (cmb_categoria.SelectedIndex == 2 || cmb_categoria.SelectedIndex == 3)
                {
                    cmbTipoMaquinarias.Visible = false;
                    lbl_tipo_maquinaria.Visible = false;
                    txtHorasHombre.Text = "0";
                    txtCantidad.Text = "0";
                    grb_Horas.Visible = false;

                }
            }
        }

               
       

        
    }
}
