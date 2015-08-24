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

namespace Vista
{
    public partial class Consultas_Cliente : Form
    {
        private GestorConsultarCliente  gestor;
        public Consultas_Cliente()
        {
            InitializeComponent();
        }

        private void Consultas_Cliente_Load(object sender, EventArgs e)
        {
            gestor = new GestorConsultarCliente();
            //habilitarPantalla();
            cargarCombos();
            cargarGrilla();
            
        }
        private void cargarGrilla()
        {
            try
            {
                List<Persona> personas = GestorConsultarCliente.buscarPersonas();

                dgv_clientes.Rows.Clear();
                foreach (Persona per in personas)
                {
                    if (per.NroCliente != 0)
                    {
                        dgv_clientes.Rows.Add(per.NroCliente, per.Apellido, per.Nombre, per.RazonSocial, per.cuil, per.TipoDoc.Nombre, per.NroDoc, per.calle, per.calle_nro, per.piso, per.depto, per.Barrio, per.Localidad.Nombre, per.Localidad.Provincia.Nombre, per.mail, per.telefono, per.TipoDoc.IDTipoDoc, per.Localidad.Provincia.idProvincia, per.Localidad.codPostal, per.condicionIVA.idCondicionIVA, per.tipoConsumidor.idTipoConsumidor, per.tefefonoCelular, per.fechaNAc, per.Sexo); 
                    }
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }
        private void cargarGrillaFiltrada(List<Persona> personas)
        {



            if (personas==null || personas.Count > 0)
            {
                dgv_clientes.Rows.Clear();
                foreach (Persona per in personas)
                {
                    dgv_clientes.Rows.Add(per.NroCliente, per.Apellido, per.Nombre, per.RazonSocial, per.cuil, per.TipoDoc.Nombre, per.NroDoc, per.calle, per.calle_nro, per.piso, per.depto, per.Barrio, per.Localidad.Nombre, per.Localidad.Provincia.Nombre, per.mail, per.telefono, per.TipoDoc.IDTipoDoc, per.Localidad.Provincia.idProvincia, per.Localidad.codPostal, per.condicionIVA.idCondicionIVA, per.tipoConsumidor.idTipoConsumidor, per.tefefonoCelular, per.fechaNAc, per.Sexo);
                }
            }
            else
            {
                MessageBox.Show("No se Encontraron Resultados", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            

        }
        public void cargarCombos()
        {
            List<TipoDocumento> tipDoc = gestor.buscarTipoDoc();
            tipDoc.Add( new TipoDocumento {IDTipoDoc=0,Nombre="TODOS"});

            cmb_tipo_doc.DataSource = tipDoc;
            cmb_tipo_doc.DisplayMember = "nombre";
            cmb_tipo_doc.ValueMember = "IDTipoDoc";
            cmb_tipo_doc.SelectedValue =0;
        }
        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            Gestion_de_Clientes gestCli = new Gestion_de_Clientes ();
            gestCli._estado = estados.nuevo;
            gestCli.ShowDialog();
            cargarGrilla();
        }
        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            //((Menu_Principal)(MdiParent)).btn_impresiones.Visible = true;
            //((Menu_Principal)(MdiParent)).btn_ventas.Visible = true;

            this.Close();
            this.Dispose();
            
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string clienteSeleccionado;

            if (!(dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["Nombre"].Value == "N/D") && !((string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["apellido"].Value == "N/D"))
            {

                clienteSeleccionado = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["Nombre"].Value + " " + (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["apellido"].Value;
            }
            else
            {
                clienteSeleccionado = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["raSocial"].Value;

            }
            if (MessageBox.Show("Desea eliminar el Cliente: " + clienteSeleccionado, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                int nroCli = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["nroCli"].Value;
                gestor.nroClienteTomado(nroCli);
                try
                {
                    gestor.eliminacionConfirmada();
                    MessageBox.Show("Cliente eliminado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cargarGrilla();
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
            }
        }
        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Gestion_de_Clientes gestion = new Gestion_de_Clientes();

            gestion._estado = estados.modificar;

            Provincia prov = new Provincia()
            {
                idProvincia = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idprovincia"].Value

            };
            Localidad loc = new Localidad()
            {
                codPostal = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idlocalidad"].Value,
                Provincia=prov
            };
            TipoDocumento tipo = new TipoDocumento()
            {
                IDTipoDoc = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idtipo"].Value
            };
            CondicionIVA condicio = new CondicionIVA() { idCondicionIVA=(int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idCondicion"].Value };
            TipoConsumidor tipoCons = new TipoConsumidor() { idTipoConsumidor=(int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idConsumidor"].Value };
            Persona per = new Persona()
            {
                Localidad = loc,
                TipoDoc = tipo,
                Apellido = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["apellido"].Value,
                Barrio = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["barrio"].Value,
                calle = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["calle"].Value,
                calle_nro = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["calleNro"].Value,
                cuil = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["cuit"].Value,
                depto = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["depto"].Value,
                mail = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["mail"].Value,
                Nombre = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["Nombre"].Value,
                telefono = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["telefono"].Value,
                RazonSocial = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["raSocial"].Value,
                NroCliente = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["nroCli"].Value,
                NroDoc = (long)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["nroDoc"].Value,
                piso = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["piso"].Value,
                condicionIVA = condicio,
                tipoConsumidor = tipoCons,
                tefefonoCelular = (string)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["celular"].Value,
                Sexo = (Char)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["sexo"].Value,
                fechaNAc = Convert.ToDateTime(dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["fecha"].Value)

            };

            gestion._persModificar = per;
            gestion._estado = estados.modificar;
            gestion.ShowDialog();
            cargarGrilla();

        }
        //private void btn_aplicar_filtro_persona_Click(object sender, EventArgs e)
        //{
            

        //    Persona per = new Persona();
            
        //    if(txt_apellido.Text!="")
        //    {
        //        per.Apellido = txt_apellido.Text;
        //    }
        //    if (txt_nombre.Text != "")
        //    {
        //        per.Nombre = txt_nombre.Text;
        //    }
        //    if (txt_nro_doc.Text != "")
        //    {
        //        per.NroDoc = Convert.ToInt32(txt_nro_doc.Text);
        //    }
        //    per.TipoDoc = new TipoDocumento() { IDTipoDoc = (int)cmb_tipo_doc.SelectedValue };

        //    List<Persona> resul=null;
        //    try
        //    {
        //        resul = GestorDeFiltros.filtrarCliente(per);
        //    }
        //    catch(ApplicationException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //    }
        //    cargarGrillaFiltrada(resul);
            
        //}
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control grupo in this.Controls)
            {
                if (grupo is GroupBox)
                {
                    foreach (Control cont  in grupo.Controls)
                    {
                        
                        if (cont is TextBox)
                        {
                            cont.Text = "";
                        }
                        if (cont is ComboBox)
                        {
                            ((ComboBox)cont).SelectedValue = 0;
                        } 
                    }
                } 
            }
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
            if (txt_nro_doc.Text != "")
            {
                per.NroDoc = Convert.ToInt64(txt_nro_doc.Text);
            }
            per.TipoDoc = new TipoDocumento() { IDTipoDoc = (int)cmb_tipo_doc.SelectedValue };
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
                resul = GestorDeFiltros.filtrarCliente(per);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            cargarGrillaFiltrada(resul);
        }
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private void txt_nro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private void txt_razon_social_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }

        private void Consultas_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            iniciador.cantVentanasAbiertas--;

            if (iniciador.cantVentanasAbiertas==0)
            {
                ((Menu_Principal)(MdiParent)).btn_impresiones.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_ventas.Visible = true; 
            }

        }

        private void btn_aplicar_filtro_persona_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

     
       
    }
}
