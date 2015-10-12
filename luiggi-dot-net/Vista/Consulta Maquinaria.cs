using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using Entidades;

namespace Vista
{
    public partial class Consulta_Maquinaria : Form
    {
        private static Consulta_Maquinaria InstanciaFormulario = null;

        public Consulta_Maquinaria()
        {
            InitializeComponent();
        }

        public static Consulta_Maquinaria Instance()
        {
            if (InstanciaFormulario == null)
            {
                InstanciaFormulario = new Consulta_Maquinaria();
            }
            return InstanciaFormulario;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            InstanciaFormulario = null;
        }

        private void btn_aplicar_filtro_Click(object sender, EventArgs e)
        {
            Maquinaria maq = new Maquinaria();

            if (txt_nombre.Text != "")
            {
                maq.Nombre = txt_nombre.Text;
            }
            if (txt_descrip.Text != "")
            {
                maq.descripcion = txt_descrip.Text;
            }
            if (cmb_estado_maq.SelectedValue != (object)0)
            {
                maq.estado = new Estado() { idEstado = Convert.ToInt32(cmb_estado_maq.SelectedValue) };
            }
            if (cmb_tipo_maq.SelectedValue != (object)0)
            {
                maq.tipoMaquinaria=new TipoMaquinaria(){ idTipoMaquinaria=(int)cmb_tipo_maq.SelectedValue};
            }


            List<Maquinaria> maquinas = null;

            try
            {
                maquinas = MaquinariaDAO.GetByFiltro(maq);
            }
            catch (ApplicationException ex)
            {
                
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            cargarGrillaFiltrada(maquinas);
        }

        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Consulta_Maquinaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            iniciador.cantVentanasAbiertas--;

            if (iniciador.cantVentanasAbiertas == 0)
            {
                ((Menu_Principal)(MdiParent)).btn_impresiones.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_ventas.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_pedido.Visible = true;
            }
        }

        private void Consulta_Maquinaria_Load(object sender, EventArgs e)
        {
            ((Menu_Principal)(MdiParent)).btn_ventas.Visible = false;
            ((Menu_Principal)(MdiParent)).btn_impresiones.Visible = false;
            ((Menu_Principal)(MdiParent)).btn_pedido.Visible = false;
            iniciador.cantVentanasAbiertas++;

            cargarGrilla();
            cargarCombos();
            dgv_maquinas.ClearSelection();
        }

        private void cargarGrilla()
        {
            String opcion = "Sin Opción";
            try
            {
                List<Maquinaria> maquinarias = MaquinariaDAO.GetAll();

                dgv_maquinas.Rows.Clear();
                foreach (Maquinaria maq in maquinarias)
                {
                    switch (maq.estado.idEstado)
                    {

                        case 14:
                            opcion = "No disponible";
                            break;
                        case 16:
                            opcion = "Disponible";
                            break;
                        default:
                            opcion = "Sin Opción";
                            break;
                    }
                    dgv_maquinas.Rows.Add(maq.Nombre,maq.descripcion,maq.tipoMaquinaria.Nombre,maq.fechaAlta.ToShortDateString(),maq.estado.Nombre,maq.idMaquinaria,maq.tipoMaquinaria.idTipoMaquinaria,maq.estado.idEstado,opcion );
                }
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void cargarCombos()
        {

            List<Estado> estadosMaq = EstadoDAO.GetAllMaquinarias();
            estadosMaq.Add(new Estado { idEstado = 0, Nombre = "TODOS" });

            cmb_estado_maq.DataSource = estadosMaq;
            cmb_estado_maq.DisplayMember = "Nombre";
            cmb_estado_maq.ValueMember = "idEstado";
            cmb_estado_maq.SelectedValue = 0;


            List<TipoMaquinaria> tipoMaq = TipoMaquinariaDAO.GetAll();
            tipoMaq.Add(new TipoMaquinaria{ idTipoMaquinaria=0, Nombre="TODOS"});

            cmb_tipo_maq.DataSource = tipoMaq;
            cmb_tipo_maq.DisplayMember = "Nombre";
            cmb_tipo_maq.ValueMember = "idTipoMaquinaria";
            cmb_tipo_maq.SelectedValue = 0;

        }
        private void cargarGrillaFiltrada(List<Maquinaria> maquinas)
        {
            String opcion = "Sin Opción";
            if (maquinas != null && maquinas.Count > 0)
            {
                dgv_maquinas.Rows.Clear();
                foreach (Maquinaria maq in maquinas)
                {
                    switch (maq.estado.idEstado)
                    {

                        case 14:
                            opcion = "No disponible";
                            break;
                        case 16:
                            opcion = "Disponible";
                            break;
                        default:
                            opcion = "Sin Opción";
                            break;
                    }
                    dgv_maquinas.Rows.Add(maq.Nombre, maq.descripcion, maq.tipoMaquinaria.Nombre, maq.fechaAlta.ToShortDateString(), maq.estado.Nombre, maq.idMaquinaria, maq.tipoMaquinaria.idTipoMaquinaria, maq.estado.idEstado, opcion);
                }
            }
            else
            {
                MessageBox.Show("No se Encontraron Resultados", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            Gestion_de_Maquinaria gestMaq = new Gestion_de_Maquinaria();
            gestMaq._estado = estados.nuevo;
            gestMaq.ShowDialog();
            cargarGrilla();

        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {

            foreach (Control grupo in this.Controls)
            {
                if (grupo is GroupBox)
                {
                    foreach (Control cont in grupo.Controls)
                    {

                        if (cont is TextBox)
                        {
                            cont.Text = "";
                        }
                        if (cont is ComboBox)
                        {
                            ((ComboBox)cont).SelectedValue = 0;
                        }
                        if (cont is DateTimePicker)
                        {
                            ((DateTimePicker)cont).Value = DateTime.Now;
                        }
                    }
                }
            }
            cargarGrilla();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string maquinaSeleccionada = dgv_maquinas.Rows[dgv_maquinas.CurrentRow.Index].Cells["nombre"].Value.ToString();

            if (MessageBox.Show("Desea eliminar: " + maquinaSeleccionada, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                int idMaquina = (int)dgv_maquinas.Rows[dgv_maquinas.CurrentRow.Index].Cells["idMaquinaria"].Value;

                try
                {
                    MaquinariaDAO.Delete(idMaquina);
                    MessageBox.Show("Eliminación Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cargarGrilla();
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
            }


        }

        private void dgv_maquinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_maquinas .CurrentCell is DataGridViewButtonCell)
            {

                if ((int)dgv_maquinas.CurrentRow.Cells["idestado"].Value == 14)
                {
                    int idMaquinaria = (int)dgv_maquinas.CurrentRow.Cells["idmaquinaria"].Value;

                    try
                    {
                        MaquinariaDAO.UpdateEstado(idMaquinaria, 16);
                        MessageBox.Show("Maquina no Disponible", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    
                }
                if ((int)dgv_maquinas.CurrentRow.Cells["idestado"].Value == 16)
                {
                    int idMaquinaria = (int)dgv_maquinas.CurrentRow.Cells["idmaquinaria"].Value;


                    try
                    {
                        MaquinariaDAO.UpdateEstado(idMaquinaria, 14);
                        MessageBox.Show("Maquina Disponible", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    
                }
                cargarGrilla();
            }
        }

        private void dgv_maquinas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Gestion_de_Maquinaria gestion = new Gestion_de_Maquinaria();

            gestion._estado = estados.modificar;
            TipoMaquinaria tm = new TipoMaquinaria()
            {
                idTipoMaquinaria = (int)dgv_maquinas.Rows[dgv_maquinas.CurrentRow.Index].Cells["idTipo"].Value,
            };
            Maquinaria maq = new Maquinaria()
            {

                descripcion = (string)dgv_maquinas.Rows[dgv_maquinas.CurrentRow.Index].Cells["descripcion"].Value,
                tipoMaquinaria = tm,
                Nombre = (string)dgv_maquinas.Rows[dgv_maquinas.CurrentRow.Index].Cells["Nombre"].Value,

                fechaAlta = Convert.ToDateTime(dgv_maquinas.Rows[dgv_maquinas.CurrentRow.Index].Cells["fechaAlta"].Value),
                idMaquinaria = (int)dgv_maquinas.Rows[dgv_maquinas.CurrentRow.Index].Cells["idMaquinaria"].Value
            };

            gestion._maqModificar = maq;
            gestion._estado = estados.modificar;
            gestion.ShowDialog();
            cargarGrilla();
        }
    }
}
