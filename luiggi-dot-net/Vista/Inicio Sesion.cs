using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using DAO;
namespace Vista
{
    public partial class Inicio_Sesion : Form
    {
        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            try
            {
                Seguridad.usuario = UsuarioDAO.GetUsuario(txt_usuario.Text, txt_pass.Text);

                 this.Close();
            }
            catch (Exception)
            {
               lbl_error.Text= "Error de inicio de sesion "  ;
            }            
        }
    }
}
