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
    public partial class Gestion_de_Maquinaria : Form
    {
        private estados estadoFormulario;
        private Maquinaria maqModificar;
        public Maquinaria _maqModificar
        {
            get { return maqModificar; }
            set { maqModificar = value; }
        }

        private estados estado;

        public estados _estado
        {
            get { return estadoFormulario; }
            set { estadoFormulario = value; }
        }


        public Gestion_de_Maquinaria()
        {
            InitializeComponent();
        }

        private void Gestion_de_Maquinaria_Load(object sender, EventArgs e)
        {
            cargarCombos();
            if (estadoFormulario == estados.modificar && !(maqModificar == null))
            {

                cargarMaquinariaModificar(sender, e);

                desbloquearCampos();
            }
            
        }
        private void cargarMaquinariaModificar(object sender, EventArgs e)
        {

            txt_descripcion.Text = maqModificar.descripcion;

            txt_nombre.Text = maqModificar.Nombre;

            cmb_tipo_maq.SelectedValue = maqModificar.tipoMaquinaria.idTipoMaquinaria; 
            dtp_fechaAlta.Value = maqModificar.fechaAlta;



        }
        private void cargarCombos()
        {

            List<TipoMaquinaria> tipoMaq = TipoMaquinariaDAO.GetAll();
            //tipoMaq.Add(new TipoMaquinaria { idTipoMaquinaria = 0, Nombre = "SELECCIONE" });

            cmb_tipo_maq.DataSource = tipoMaq;
            cmb_tipo_maq.DisplayMember = "Nombre";
            cmb_tipo_maq.ValueMember = "idTipoMaquinaria";
            //cmb_tipo_maq.SelectedValue = 0;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private Boolean validarCampos()
        {

            if (txt_nombre.Text == "" && txt_nombre.Enabled == true)
            {
                MessageBox.Show("Complete el campo\"Nombre\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_nombre.Focus();
                return false;
            }
            //if (txt_descripcion.Text == "" && txt_descripcion.Enabled == true)
            //{
            //    MessageBox.Show("Complete el campo\"Apellido\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //    txt_apellido.Focus();
            //    return false;
            //}

            return true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (_estado == estados.nuevo && validarCampos() == true)
            {
                Maquinaria maq = new Maquinaria();
                TipoMaquinaria tm = new TipoMaquinaria();
                tm.idTipoMaquinaria = Convert.ToInt32(cmb_tipo_maq.SelectedValue ); 
                maq.Nombre = txt_nombre.Text;
                maq.descripcion = txt_descripcion.Text;
                maq.fechaAlta = dtp_fechaAlta.Value;
                maq.tipoMaquinaria = tm;
               

                try
                {
                    MaquinariaDAO .Insert(maq);
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
                    if (txt_nombre.Text != maqModificar.Nombre)
                    {
                        string nombreMaquina = txt_nombre.Text;
                        try
                        {
                            if (verificarExistenciaMaquinaria(nombreMaquina))
                            {
                                MessageBox.Show(this, "La Maquinaria ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    Maquinaria maq = new Maquinaria();
                    TipoMaquinaria tm = new TipoMaquinaria();
                    tm.idTipoMaquinaria = Convert.ToInt32(cmb_tipo_maq.SelectedValue);
                    maq.Nombre = txt_nombre.Text;
                    maq.descripcion = txt_descripcion.Text;
                    maq.fechaAlta = dtp_fechaAlta.Value;
                    maq.tipoMaquinaria = tm;
                    maq.idMaquinaria = maqModificar.idMaquinaria;

                    try
                    {
                        MaquinariaDAO.Update(maq);
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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btn_verificar_existencia_Click(object sender, EventArgs e)
        {
            if (!txt_nombre.Text.Equals(""))
            {

                string nombreMaquina = txt_nombre.Text;

                try
                {
                    if (verificarExistenciaMaquinaria(nombreMaquina))
                    {
                        MessageBox.Show(this, "La Maquinaria ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
        public void desbloquearCampos()
        {
            btn_guardar.Enabled = true;
            txt_descripcion.Enabled = true;
            cmb_tipo_maq.Enabled = true;
            //dtp_fechaAlta.Enabled = true;
            txt_descripcion.Focus();
        }
        public Boolean verificarExistenciaMaquinaria(string nombreMaquina)
        {
            Boolean resul = false;
            try
            {
                List<Maquinaria> maquinas = MaquinariaDAO.GetAll();

                foreach (Maquinaria maq in maquinas)
                {
                    if (maq.Nombre.Equals(nombreMaquina))
                    {
                        resul = true;
                    }
                }
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }


            return resul;
        }
        private void limpiarCampos()
        {
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
         
            cmb_tipo_maq.SelectedIndex = 0;
          
         
        }
    }
}
