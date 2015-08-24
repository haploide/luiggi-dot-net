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
    public partial class Gestion_de_Empleado : Form
    {
       
        public Empleado empModificar;
        private estados estadoFormulario;
        public Gestion_de_Empleado()
        {
            InitializeComponent();
        }
        public estados _estado
        {
            get { return estadoFormulario; }
            set { estadoFormulario = value; }
        }

        private void Gestion_de_Empleado_Load(object sender, EventArgs e)
        {
            if (estadoFormulario == estados.modificar && !(empModificar == null))
            {
               
                cargarEmpleadoModificar(sender, e);
               

            }
        }
        private void cargarEmpleadoModificar(object sender, EventArgs e)
        {

            txt_apellido.Text = empModificar.Apellido;

            txt_nombre.Text = empModificar.Nombre;

            txt_telefono.Text = empModificar.telefono.ToString();


            dtp_fechaNac.Value = empModificar.fechaNac;



        }
        public Empleado  _empModificar
        {
            get { return empModificar; }
            set { empModificar = value; }
        }
        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

       
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (_estado == estados.nuevo && validarCampos() == true)
            {
                Empleado emp = new Empleado();
                
                if (!(txt_telefono.Text == "    -"))
                {
                    emp.telefono  = txt_telefono.Text;
                }
                emp.Nombre = txt_nombre.Text;
                emp.Apellido  = txt_apellido.Text;
                emp.fechaAlta  = dtp_fechaAlta.Value ;
                emp.fechaNac = dtp_fechaNac.Value;

             
                try
                {
                    EmpleadoDAO.Insert(emp );
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
                    Empleado emp = new Empleado();

                    if (!(txt_telefono.Text == "    -"))
                    {
                        emp.telefono = txt_telefono.Text;
                    }
                    emp.Nombre = txt_nombre.Text;
                    emp.Apellido = txt_apellido.Text;
                    emp.fechaAlta = dtp_fechaAlta.Value;
                    emp.fechaNac = dtp_fechaNac.Value;
                    emp.idEmpleado = _empModificar.idEmpleado;
             

                  
                    try
                    {
                        EmpleadoDAO.Update (emp);
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

            return true;
        }
        private void limpiarCampos()
        {
            //estadoFormulario = estados.nuevo;
            //verifico = false;
          
            
            txt_apellido.Text = "";
           
            txt_nombre.Text = "";
           
            txt_telefono.Text = "";
          
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
       
    }
}
