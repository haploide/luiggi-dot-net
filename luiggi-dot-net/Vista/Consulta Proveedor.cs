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
    public partial class Consulta_Proveedor : Form
    {

        public Consulta_Proveedor()
        {
            InitializeComponent();
        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            Gestion_de_Proveedores gestProv = new Gestion_de_Proveedores();
            gestProv._estado = estados.nuevo;
            gestProv.ShowDialog();
            cargarGrilla();
        }

        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Consulta_Proveedor_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            try
            {
                List<Persona> personas = PersonaDAO.GetAll();

                dgv_proveedores.Rows.Clear();
                foreach (Persona per in personas)
                {
                    if (per.NroProveedor != 0)
                    {

                        dgv_proveedores.Rows.Add(per.NroProveedor ,per.RazonSocial, per.cuil, per.Apellido, per.Nombre, per.calle, per.calle_nro,  per.Barrio, per.Localidad.Nombre, per.Localidad.Provincia.Nombre, per.mail, per.telefono, per.Localidad.Provincia.idProvincia, per.Localidad.codPostal);
                    }
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void dgv_proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Gestion_de_Proveedores gestion = new Gestion_de_Proveedores();

            gestion._estado = estados.modificar;

            Provincia prov = new Provincia()
            {
                idProvincia = (int)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["idprovincia"].Value

            };
            Localidad loc = new Localidad()
            {
                codPostal = (int)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["idlocalidad"].Value,
                Provincia = prov
            };
          
           
            Persona per = new Persona()
            {
                Localidad = loc,
                NroProveedor = (int)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["nroProv"].Value,
                Apellido = (string)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["apellido"].Value,
                Barrio = (string)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["barrio"].Value,
                calle = (string)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["calle"].Value,
                calle_nro = (int)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["calleNro"].Value,
                cuil = (string)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["cuit"].Value,
                mail = (string)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["mail"].Value,
                Nombre = (string)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["Nombre"].Value,
                telefono = (string)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["telefono"].Value,
                RazonSocial = (string)dgv_proveedores.Rows[dgv_proveedores.CurrentRow.Index].Cells["raSocial"].Value,
  
            };

            gestion._persModificar = per;
            gestion._estado = estados.modificar;
            gestion.ShowDialog();
            cargarGrilla();

        }

        private void btn_aplicar_filtro_empresa_Click(object sender, EventArgs e)
        {
             Persona per = new Persona();
           
            if (txt_apellido.Text != "")
            {
                per.Apellido = txt_apellido.Text;
            }
            if (txt_nombre.Text != "")
            {
                per.Nombre = txt_nombre.Text;
            }
          
            if (txt_razon_social.Text != "")
            {
                per.RazonSocial = txt_razon_social.Text;
            }

            if (txt_cuit.Text != "  -        -")
            {
                per.cuil = txt_cuit.Text;
            }

            //TipoDocumento tip = new TipoDocumento() { IDTipoDoc = 0 };

            //per.TipoDoc = tip;

            List<Persona> resul = null;
            try
            {
                resul = PersonaDAO.GetByFiltroProveedor (per);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            cargarGrillaFiltrada(resul);
        
        }
        private void cargarGrillaFiltrada(List<Persona> personas)
        {



            if (personas == null || personas.Count > 0)
            {
                dgv_proveedores.Rows.Clear();
                foreach (Persona per in personas)
                {
                    if (per.NroProveedor != 0)
                    {

                        dgv_proveedores.Rows.Add(per.NroProveedor, per.RazonSocial, per.cuil, per.Apellido, per.Nombre, per.calle, per.calle_nro, per.Barrio, per.Localidad.Nombre, per.Localidad.Provincia.Nombre, per.mail, per.telefono, per.Localidad.Provincia.idProvincia, per.Localidad.codPostal);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se Encontraron Resultados", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }



        }

        private void Consulta_Proveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            iniciador.cantVentanasAbiertas--;

            if (iniciador.cantVentanasAbiertas == 0)
            {
                ((Menu_Principal)(MdiParent)).btn_impresiones.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_ventas.Visible = true;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }

        private void Consulta_Proveedor_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
