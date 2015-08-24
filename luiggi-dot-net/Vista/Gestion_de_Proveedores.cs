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
    public partial class Gestion_de_Proveedores : Form
    {
        private Boolean verifico = false;
        private string CUIT;
        private estados estadoFormulario;
        private Persona persModificar;
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
        public Gestion_de_Proveedores()
        {
            InitializeComponent();
        }

        private void Gestion_de_Proveedores_Load(object sender, EventArgs e)
        {
            cargarCombos();
            if (estadoFormulario == estados.modificar && !(persModificar == null))
            {
                desbloquearCampos();
                cargarPersonaModificar(sender, e);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btn_verificar_existencia_empresa_Click(object sender, EventArgs e)
        {
            if (!(txt_cuit.Text == "") && !(txt_cuit.Text == "  -        -"))
            {
               
                try
                {
                    if (verificarExistenciaProveedor())
                    {
                        MessageBox.Show(this, "El Proveedor ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void desbloquearCampos()
        {
            txt_razon_social.Enabled = true;
            txt_apellido.Enabled = true;
            txt_barrio.Enabled = true;
            txt_calle.Enabled = true;
            txt_calle_nro.Enabled = true;
            txt_cuit.Enabled = true;
            txt_mail.Enabled = true;
            txt_nombre.Enabled = true;
            txt_telefono.Enabled = true;
            btn_guardar.Enabled = true;
            cmb_localidad.Enabled = true;
            cmb_provincia.Enabled = true;
           
        }
        private void limpiarCampos()
        {
            estadoFormulario = estados.nuevo;
            verifico = false;
            cmb_provincia.SelectedIndex = 0;
            cmb_localidad.DataSource = null;
            txt_apellido.Text = "";
            txt_barrio.Text = "";
            txt_calle.Text = "";
            txt_calle_nro.Text = "";
            txt_cuit.Text = "";
            txt_mail.Text = "";
            txt_nombre.Text = "";
            txt_razon_social.Text = "";
            txt_telefono.Text = "";
           
            bloquearCampos();
        }
        private void bloquearCampos()
        {
            cmb_provincia.Enabled = false;
            cmb_localidad.Enabled = false;
            txt_apellido.Enabled = false;
            txt_barrio.Enabled = false;
            txt_calle.Enabled = false;
            txt_calle_nro.Enabled = false;
            txt_cuit.Enabled = true;
            txt_mail.Enabled = false;
            txt_nombre.Enabled = false;
            txt_razon_social.Enabled = false;
            txt_telefono.Enabled = false;
            btn_verificar_existencia_empresa.Enabled = true;
            btn_guardar.Enabled = false;
            txt_cuit.Focus();

        }
        private void bloquearPersona()
        {
            
            btn_guardar.Enabled = true;
           
            txt_razon_social.Focus();
        }
        public Boolean verificarExistenciaProveedor()
        {
            Boolean resul = false;
            
            if (!(CUIT == String.Empty) )
            {
                try
                {
                    List<Persona> personas = PersonaDAO.GetAll();

                    foreach (Persona per in personas)
                    {
                        if (per.cuil.Equals(CUIT))
                        {
                            resul = true;
                        }
                    }
                }
                catch (ApplicationException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
            }


            return resul;
        }
        public void cargarCombos()
        {

            List<Provincia> prov = ProvinciaDAO.GetAll ();

            cmb_provincia.DataSource = prov;
            cmb_provincia.DisplayMember = "nombre";
            cmb_provincia.ValueMember = "idProvincia";

        }

        private void cmb_provincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int provincia = Convert.ToInt32(cmb_provincia.SelectedValue);

            List<Localidad> loc = LocalidadDAO.GetLocalidadXProvincia(provincia );
            cmb_localidad.DataSource = loc;
            cmb_localidad.DisplayMember = "nombre";
            cmb_localidad.ValueMember = "codPostal";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int nroProv  = SingletonNumeroProveedorDAO.GetInstacia().getNumeroCliente();
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
              
                string tele = "";
              
                int call = 0;
              

                if (!(txt_telefono.Text == "    -"))
                {
                    tele = txt_telefono.Text;
                }
                
                if (!(txt_calle_nro.Text == ""))
                {
                    call = Convert.ToInt32(txt_calle_nro.Text);
                }

                Persona per = new Persona()
                {
                   
                    cuil = txt_cuit.Text ,
                    Localidad = loc,
                    Barrio = txt_barrio.Text,
                    mail =  txt_mail.Text,
                    telefono = tele,
                    calle_nro = call,
                    RazonSocial = txt_razon_social.Text,
                    Apellido = txt_apellido.Text,
                    Nombre =  txt_nombre.Text,
                    calle =  txt_calle.Text,
                    NroProveedor = nroProv,
                    fechaNAc = DateTime.Now.Date,
                    Sexo ='O'
                
                    
                };
                try
                {
                    PersonaDAO.Insert(per);
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

                    Localidad loc = new Localidad()
                    {
                        codPostal = (int)cmb_localidad.SelectedValue
                    };


                   
                    string tele;
                    
                    int call = 0;
                    


                    tele = txt_telefono.Text;


                    call = Convert.ToInt32(txt_calle_nro.Text);
                    Persona per = new Persona()
                    {
                       
                        Localidad = loc,
                        Barrio = txt_barrio.Text,
                        mail = txt_mail.Text,
                        telefono = tele,
                        calle_nro = call,
                        RazonSocial = txt_razon_social.Text,
                        Apellido = txt_apellido.Text,
                        Nombre = txt_nombre.Text,
                        calle = txt_calle.Text,
                        cuil = txt_cuit.Text,
                        NroProveedor = _persModificar.NroProveedor 
                    };

                  
                    try
                    {
                        PersonaDAO.UpdateProveedor(per);
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
          
            if (txt_cuit.Text == "" && txt_cuit.Enabled == true)
            {
                MessageBox.Show("Complete el campo\"CUIT/CUIL\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_cuit .Focus();
                return false;

            }
            if (txt_nombre.Text == "" && txt_nombre.Enabled == true)
            {
                MessageBox.Show("Complete el campo\"Nombre\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_nombre.Focus();
                return false;
            }
            if (txt_apellido.Text == "" && txt_apellido.Enabled == true)
            {
                MessageBox.Show("Complete el campo\"Apellido\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_apellido.Focus();
                return false;
            }
            if (txt_razon_social.Text == "" && txt_razon_social.Enabled == true)
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
        private void cargarPersonaModificar(object sender, EventArgs e)
        {
            cmb_provincia.SelectedValue = persModificar.Localidad.Provincia.idProvincia;
            cmb_provincia_SelectionChangeCommitted(sender, e);
           
            txt_apellido.Text = persModificar.Apellido;
            txt_barrio.Text = persModificar.Barrio;
            txt_calle.Text = persModificar.calle;
            txt_calle_nro.Text = persModificar.calle_nro.ToString();
            txt_cuit.Text = persModificar.cuil.ToString();
          
            txt_mail.Text = persModificar.mail;
            txt_nombre.Text = persModificar.Nombre;
           
            txt_razon_social.Text = persModificar.RazonSocial;
            txt_telefono.Text = persModificar.telefono.ToString();
         
            cmb_localidad.SelectedValue = persModificar.Localidad.codPostal;

          
        }

    }
}
