using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Controlador;
using DAO;



namespace Vista
{
    public partial class Gestion_de_Clientes : Form
    {
        private GestorRegistrarCliente  gestor;
        private estados estadoFormulario;
        private Persona persModificar;
        private Boolean verifico = false;

        public estados _estado
        {
            get { return estadoFormulario; }
            set { estadoFormulario = value; }
        }
        public Persona _persModificar
        {
            get { return persModificar; }
            set { persModificar = value; }
        }
        public Gestion_de_Clientes()
        {
            InitializeComponent();
        }
        private void Gestion_de_Clientes_Load(object sender, EventArgs e)
        {
            gestor = new GestorRegistrarCliente ();

            if (estadoFormulario==estados.nuevo)
            {
                gestor.nuevoCliente();
                habilitarPantalla();
            }
            
            cargarCombos();
            cmb_provincia_SelectionChangeCommitted(sender, e);
            if (estadoFormulario==estados.modificar && !(persModificar==null))
            {
                desbloquearCampos();
                cargarPersonaModificar(sender,e);
                if (persModificar.cuil == "1" || persModificar.cuil == String.Empty || persModificar.cuil == "1 -        -" || persModificar.cuil == "  -        -")
                {
                    bloquearEmpresa();
                }
                else
                {
                    bloquearPersona();
                }

            }
        }
        private void cargarPersonaModificar(object sender, EventArgs e)
        {
            cmb_provincia.SelectedValue = persModificar.Localidad.Provincia.idProvincia;
            cmb_provincia_SelectionChangeCommitted(sender, e);
            cmb_tipo_doc.SelectedValue = persModificar.TipoDoc.IDTipoDoc;
            txt_apellido.Text = persModificar.Apellido;
            txt_barrio.Text = persModificar.Barrio;
            txt_calle.Text = persModificar.calle;
            txt_calle_nro.Text = persModificar.calle_nro.ToString();
            txt_cuit.Text = persModificar.cuil.ToString();
            txt_depto.Text = persModificar.depto.ToString();
            txt_mail.Text = persModificar.mail;
            txt_nombre.Text = persModificar.Nombre;
            txt_nro_doc.Text = persModificar.NroDoc.ToString();
            txt_piso.Text = persModificar.piso.ToString();
            txt_razon_social.Text = persModificar.RazonSocial;
            txt_telefono.Text = persModificar.telefono.ToString();
            txt_celular.Text = persModificar.tefefonoCelular;
            cmb_cond_iva.SelectedValue = persModificar.condicionIVA.idCondicionIVA;
            cmd_tipo_cons.SelectedValue = persModificar.tipoConsumidor.idTipoConsumidor;
            cmb_localidad.SelectedValue = persModificar.Localidad.codPostal;

            cmb_sexo.SelectedIndex = 0;
            if (persModificar.Sexo == 'M' || persModificar.Sexo == 'm')
            {
                cmb_sexo.SelectedIndex = 2;
            }
            else if (persModificar.Sexo == 'H' || persModificar.Sexo == 'h')
            {
                cmb_sexo.SelectedIndex = 1;
            }

            dtp_fechaNac.Value = persModificar.fechaNAc;
            


        }
        public void habilitarPantalla()
        {
            cmb_tipo_doc.Enabled = true;
            txt_nro_doc.Enabled = true;
            txt_cuit.Enabled = true;
        }
        public void cargarCombos()
        {
            
                List<TipoDocumento> tipDoc = gestor.buscarTipoDoc();
                List<Provincia> prov = gestor.buscarProvincias();
                List<CondicionIVA> condiva = CondicionIVADAO.GetAll();
                List<TipoConsumidor> consu = TipoConsumidorDAO.GetAll();


                cmb_tipo_doc.DataSource = tipDoc;
                cmb_tipo_doc.DisplayMember = "nombre";
                cmb_tipo_doc.ValueMember = "IDTipoDoc";

                cmb_provincia.DataSource = prov;
                cmb_provincia.DisplayMember = "nombre";
                cmb_provincia.ValueMember = "idProvincia";

                cmb_cond_iva.DataSource = condiva;
                cmb_cond_iva.DisplayMember = "nombre";
                cmb_cond_iva.ValueMember = "idCondicionIVA";

                cmd_tipo_cons.DataSource = consu;
                cmd_tipo_cons.DisplayMember = "nombre";
                cmd_tipo_cons.ValueMember = "idTipoConsumidor";

                cmb_sexo.Items.Insert(0, "Sin Definir");    
                cmb_sexo.Items.Insert(1, "Hombre");
                cmb_sexo.Items.Insert(2, "Mujer");
                cmb_sexo.SelectedIndex = 0;
                                                                      
            
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void cmb_provincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int provincia = Convert.ToInt32(cmb_provincia.SelectedValue );
            
            List<Localidad> loc = gestor.buscarLocalidades(provincia );
            cmb_localidad.DataSource = loc;
            cmb_localidad.DisplayMember = "nombre";
            cmb_localidad.ValueMember = "codPostal";
        }
        private void desbloquearCampos()
        {
            txt_razon_social.Enabled = true;
            txt_apellido.Enabled = true;
            txt_barrio.Enabled = true;
            txt_calle.Enabled = true;
            txt_calle_nro.Enabled = true;
            txt_cuit.Enabled = true;
            txt_depto.Enabled = true;
            txt_mail.Enabled = true;
            txt_nombre.Enabled = true;
            txt_piso.Enabled = true;
            txt_telefono.Enabled = true;
            txt_celular.Enabled = true;
            cmb_localidad.Enabled = true;
            cmb_provincia.Enabled = true;
            cmb_cond_iva.Enabled = true;
            cmd_tipo_cons.Enabled = true;
            cmb_sexo.Enabled = true;
            dtp_fechaNac.Enabled = true;
        }
        private void btn_verificar_existencia_persona_Click(object sender, EventArgs e)
        {
            if(!(txt_nro_doc.Text==""))
            {
                TipoDocumento tipo = new TipoDocumento()
                { 
                    IDTipoDoc=(int)cmb_tipo_doc.SelectedValue,
                    Nombre=(string)cmb_tipo_doc.SelectedText
                };
                gestor.datosClienteIngresados("", Convert.ToInt64(txt_nro_doc.Text), tipo);
                try
                {
                    if (gestor.verificarExistenciaCliente())
                    {
                        MessageBox.Show(this, "El Cliente ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        desbloquearCampos();
                        verifico = true;
                        bloquearEmpresa();
                        
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                

            }
            else
            {
                MessageBox.Show("Complete el campo\"Nro Doc\" antes de verificar su existencia", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void bloquearEmpresa()
        {
            txt_cuit.Enabled = false;
            txt_razon_social.Enabled = false;
            btn_verificar_existencia_empresa.Enabled = false;
            btn_guardar.Enabled = true;
            tab_persona_cliente.SelectedIndex = 0;
            txt_nombre.Focus();
        }
        private void btn_verificar_existencia_empresa_Click(object sender, EventArgs e)
        {
            if (!(txt_cuit.Text == "") && !(txt_cuit.Text == "  -        -"))
            {
                TipoDocumento tipo = new TipoDocumento()
                {
                    IDTipoDoc = (int)cmb_tipo_doc.SelectedValue,
                    Nombre = (string)cmb_tipo_doc.SelectedText
                };
                gestor.datosClienteIngresados(txt_cuit.Text,0, tipo);
                try
                {
                    if (gestor.verificarExistenciaCliente())
                    {
                        MessageBox.Show(this, "El Cliente Empresa ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        desbloquearCampos();
                        verifico = true;
                        bloquearPersona();
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }


            }
            if ((txt_cuit.Text == "  -        -"))
            {
                MessageBox.Show("Complete el campo\"CUIT/CUIL\" antes de verificar su existencia", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void bloquearPersona()
        {
            txt_nro_doc.Enabled = false;
            cmb_tipo_doc.Enabled = false;
            cmb_sexo.Enabled = false;
            dtp_fechaNac.Enabled = false;
            btn_verificar_existencia_persona.Enabled = false;
            btn_guardar.Enabled = true;
            tab_persona_cliente.SelectedIndex = 1;
            txt_razon_social.Focus();
        }
        private void limpiarCampos()
        {
            estadoFormulario = estados.nuevo;
            verifico = false;
            cmb_provincia.SelectedIndex = 0;
            cmb_localidad.DataSource = null;
            cmb_tipo_doc.SelectedIndex = 0;
            cmd_tipo_cons.SelectedIndex = 0;
            cmb_cond_iva.SelectedIndex = 0;
            cmb_sexo.SelectedIndex = 0;
            dtp_fechaNac.Value = DateTime.Now;
            txt_apellido.Text = "";
            txt_barrio.Text = "";
            txt_calle.Text = "";
            txt_calle_nro.Text = "";
            txt_cuit.Text = "";
            txt_depto.Text = "";
            txt_mail.Text = "";
            txt_nombre.Text = "";
            txt_nro_doc.Text = "";
            txt_piso.Text = "";
            txt_razon_social.Text = "";
            txt_telefono.Text = "";
            txt_celular.Text = "";
            bloquearCampos();
        }
        private void bloquearCampos()
        {
            cmb_provincia.Enabled = false;
            cmb_localidad.Enabled = false;
            cmb_tipo_doc.Enabled = true;
            cmb_cond_iva.Enabled = false;
            cmd_tipo_cons.Enabled = false;
            cmb_sexo.Enabled = false;
            dtp_fechaNac.Enabled = false;
            txt_celular.Enabled = false;
            txt_apellido.Enabled = false;
            txt_barrio.Enabled = false;
            txt_calle.Enabled = false;
            txt_calle_nro.Enabled = false;
            txt_cuit.Enabled = true;
            txt_depto.Enabled = false;
            txt_mail.Enabled = false;
            txt_nombre.Enabled = false;
            txt_nro_doc.Enabled = true;
            txt_piso.Enabled = false;
            txt_razon_social.Enabled = false;
            txt_telefono.Enabled = false;
            btn_verificar_existencia_empresa.Enabled = true;
            btn_verificar_existencia_persona.Enabled = true;
            txt_nro_doc.Focus();
            btn_guardar.Enabled = false;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (_estado == estados.nuevo && validarCampos() == true)
                {
                    Provincia pro = new Provincia
                    {
                        idProvincia = (int)cmb_provincia.SelectedValue,
                        Nombre = (string)cmb_provincia.SelectedItem.ToString()
                    };
                    Localidad loc = new Localidad()
                    {
                        codPostal = (int)cmb_localidad.SelectedValue,
                        Nombre = (string)cmb_localidad.SelectedItem.ToString(),
                        Provincia = pro

                    };
                    TipoConsumidor tc=new TipoConsumidor(){ idTipoConsumidor=(int)cmd_tipo_cons.SelectedValue };
                    CondicionIVA iva = new CondicionIVA() { idCondicionIVA = (int)cmb_cond_iva.SelectedValue };

                    string tele = "";
                    string cel = "";
                    int dto = 0;
                    int pis = 0;
                    int call = 0;
                    Char sexo='O';

                    if (!(txt_telefono.Text == "    -"))
                    {
                        tele = txt_telefono.Text;
                    }
                    if (!(txt_celular.Text == "    -"))
                    {
                        cel = txt_celular.Text;
                    }
                    if (!(txt_depto.Text == ""))
                    {
                        dto = Convert.ToInt32(txt_depto.Text);
                    }
                    if (!(txt_piso.Text == ""))
                    {
                        pis = Convert.ToInt32(txt_piso.Text);
                    }
                    if (!(txt_calle_nro.Text == ""))
                    {
                        call = Convert.ToInt32(txt_calle_nro.Text);
                    }
                    if (cmb_sexo.SelectedIndex == 1)
                    {
                        sexo='H';
                    }
                    else if (cmb_sexo.SelectedIndex == 2)
                    {
                        sexo='M';
                    }

                    gestor.datosPersonales(loc, txt_barrio.Text, txt_mail.Text, tele, dto, pis, call, txt_calle.Text, txt_razon_social.Text, txt_apellido.Text, txt_nombre.Text,cel,iva,tc,dtp_fechaNac.Value,sexo);

                    try
                    {
                        gestor.confirmar();
                        MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        limpiarCampos();
                        btn_guardar.Enabled = false;
                        
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                }
                else 
                {
                    if (_estado == estados.modificar && validarCampos() == true)
                    {
                        TipoDocumento tipo = new TipoDocumento()
                        {
                            IDTipoDoc = (int)cmb_tipo_doc.SelectedValue,
                            Nombre = (string)cmb_tipo_doc.SelectedText
                        };
                        Localidad loc=new Localidad()
                        {
                             codPostal=(int)cmb_localidad.SelectedValue
                        };
                        TipoConsumidor tc = new TipoConsumidor() { idTipoConsumidor = (int)cmd_tipo_cons.SelectedValue };
                        CondicionIVA iva = new CondicionIVA() { idCondicionIVA = (int)cmb_cond_iva.SelectedValue };

                        gestor.datosClienteIngresados(txt_cuit.Text, Convert.ToInt32(txt_nro_doc.Text), tipo);
                        gestor.codigoTomado(_persModificar.NroCliente);
                        string tele;
                        string cel;
                        int dto = 0;
                        int pis = 0;
                        int call = 0;
                        char sexo='O';

                        
                        tele = txt_telefono.Text;
                        cel = txt_celular.Text;
                        dto = Convert.ToInt32(txt_depto.Text);
                        pis = Convert.ToInt32(txt_piso.Text);
                        call = Convert.ToInt32(txt_calle_nro.Text);

                        if (cmb_sexo.SelectedIndex == 1)
                        {
                            sexo = 'H';
                        }
                        else if (cmb_sexo.SelectedIndex == 2)
                        {
                            sexo = 'M';
                        }

                        gestor.datosPersonales(loc, txt_barrio.Text, txt_mail.Text, tele, dto, pis, call, txt_calle.Text, txt_razon_social.Text, txt_apellido.Text, txt_nombre.Text,cel,iva,tc,dtp_fechaNac.Value,sexo);

                        try
                        {
                            gestor.modificacionConfirmada();
                            MessageBox.Show("Actualizado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            //limpiarCampos();
                            //btn_guardar.Enabled = false;
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
        private Boolean validarCampos()
        {
            if (txt_nro_doc.Text == "" && txt_nro_doc.Enabled == true)
            {
                MessageBox.Show("Complete el campo\"Nro Doc\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_nro_doc.Focus();
                return false;
            }
            if (txt_cuit.Text == "" && txt_cuit.Enabled == true)
            {
                MessageBox.Show("Complete el campo\"CUIT/CUIL\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_nro_doc.Focus();
                return false;

            }
            if (txt_nombre.Text == "" && txt_nombre.Enabled==true)
            {
                MessageBox.Show("Complete el campo\"Nombre\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_nombre.Focus();
                return false;
            }
            if (txt_apellido.Text == "" && txt_apellido.Enabled==true)
            {
                MessageBox.Show("Complete el campo\"Apellido\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_apellido.Focus();
                return false;
            }
            if (txt_razon_social.Text == "" && txt_razon_social.Enabled==true)
            {
                MessageBox.Show("Complete el campo\"Razon Social\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_razon_social.Focus();
                return false;
            }

            if (!(txt_mail.Text == "N/D") && !(txt_mail.Text == ""))
            {
                if (IsValidEmail() == false)
                {
                    MessageBox.Show("Formato de Email Invalido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    txt_mail.Focus();
                    return false;
                } 
            }
            if (cmb_localidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Localidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                cmb_localidad.Focus();
                cmb_localidad.Show();
                return false;
            }
            if (dtp_fechaNac.Value.Date>DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la actual", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                dtp_fechaNac.Focus();
                return false;
            }

            return true;
        }
        private bool IsValidEmail()
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(txt_mail.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void txt_nro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private void txt_calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }

        //private void Gestion_de_Clientes_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyValue == 112)
        //    {
        //        string ruta = System.IO.Directory.GetCurrentDirectory().ToString();
        //        System.Diagnostics.Process.Start(ruta + "\\Ayuda_Gestion_Clientes.chm");
        //    }
        //}

    }
}
