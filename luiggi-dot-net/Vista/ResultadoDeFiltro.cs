using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class ResultadoDeFiltro : Form
    {
        private List<Persona> resultado;


        public List<Persona> _resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }


        public ResultadoDeFiltro()
        {
            InitializeComponent();
        }

        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ResultadoDeFiltro_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            dgv_clientes.ClearSelection();
        }
        private void cargarGrilla()
        {
            try
            {
                

                dgv_clientes.Rows.Clear();
                foreach (Persona per in resultado )
                {
                    dgv_clientes.Rows.Add(per.NroCliente, per.Apellido, per.Nombre, per.RazonSocial, per.cuil, per.TipoDoc.Nombre, per.NroDoc, per.calle, per.calle_nro, per.piso, per.depto, per.Barrio, per.Localidad.Nombre, per.Localidad.Provincia.Nombre, per.mail, per.telefono, per.TipoDoc.IDTipoDoc, per.Localidad.Provincia.idProvincia, per.Localidad.codPostal, per.condicionIVA.idCondicionIVA, per.tipoConsumidor.idTipoConsumidor, per.tefefonoCelular, per.fechaNAc, per.Sexo, per.idPersona );
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Provincia prov = new Provincia()
            {
                idProvincia = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idprovincia"].Value

            };
            Localidad loc = new Localidad()
            {
                codPostal = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idlocalidad"].Value,
                Provincia = prov
            };
            TipoDocumento tipo = new TipoDocumento()
            {
                IDTipoDoc = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idtipo"].Value
            };
            CondicionIVA condicio = new CondicionIVA() { idCondicionIVA = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idCondicion"].Value };
            TipoConsumidor tipoCons = new TipoConsumidor() { idTipoConsumidor = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idConsumidor"].Value };
            Persona pers = new Persona()
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
                fechaNAc = Convert.ToDateTime(dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["fecha"].Value),
                idPersona = (int)dgv_clientes.Rows[dgv_clientes.CurrentRow.Index].Cells["idPersona"].Value

            };

            Vista.iniciador.per = pers;

            Close();
            Dispose();
                 
        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            Gestion_de_Clientes gestCli = new Gestion_de_Clientes();
            gestCli._estado = estados.nuevo;
            gestCli.ShowDialog();
            Close();
            Dispose();
        }
        
  
 
        
    }
}
