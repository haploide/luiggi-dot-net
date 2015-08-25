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
    public partial class Consulta_Empleado : Form
    {
        private static Consulta_Empleado InstanciaFormulario = null;

        public Consulta_Empleado()
        {
            InitializeComponent();
        }
        public static Consulta_Empleado Instance()
        {
            if (InstanciaFormulario == null)
            {
                InstanciaFormulario = new Consulta_Empleado();
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

        private void Consulta_Empleado_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            String opcion = "Sin Opción";
            try
            {
                List<Empleado> empleados = EmpleadoDAO.GetAll();

                dgv_empleados.Rows.Clear();
                foreach (Empleado emp in empleados)
                {
                    switch (emp.estado.idEstado)
                    {

                        case 11:
                            opcion = "No disponible";
                            break;
                        case 13:
                            opcion = "Disponible";
                            break;
                        default:
                            opcion = "Sin Opción";
                            break;
                    }
                    dgv_empleados.Rows.Add(emp.Apellido, emp.Nombre, emp.telefono,  emp.edad  , emp.fechaNac.ToShortDateString(), emp.fechaAlta.ToShortDateString(), emp.idEmpleado, emp.estado.Nombre,emp.estado.idEstado,opcion  );
                   
                   
                }
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void cargarGrillaFiltrada(List<Empleado> empleados)
        {
            String opcion = "Sin Opción";
            if (empleados != null && empleados.Count > 0)
            {
                dgv_empleados.Rows.Clear();
                foreach (Empleado emp in empleados)
                {
                    switch (emp.estado.idEstado)
                    {

                        case 11:
                            opcion = "No disponible";
                            break;
                        case 13:
                            opcion = "Disponible";
                            break;
                        default:
                            opcion = "Sin Opción";
                            break;
                    }
                    dgv_empleados.Rows.Add(emp.Apellido, emp.Nombre, emp.telefono, emp.edad, emp.fechaNac.ToShortDateString(), emp.fechaAlta.ToShortDateString(), emp.idEmpleado, emp.estado.Nombre, emp.estado.idEstado, opcion);
                   
                }
            }
            else
            {
                MessageBox.Show("No se Encontraron Resultados", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }

        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            Gestion_de_Empleado gestEmp = new Gestion_de_Empleado();
            gestEmp._estado = estados.nuevo;
            gestEmp.ShowDialog();
            cargarGrilla();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string empleadoselec = (string)dgv_empleados.Rows[dgv_empleados.CurrentRow.Index].Cells["Nombre"].Value + " " + (string)dgv_empleados.Rows[dgv_empleados.CurrentRow.Index].Cells["Apellido"].Value;
            if (MessageBox.Show("Desea eliminar el Empleado: " + empleadoselec, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                int idEmpleado = (int)dgv_empleados.Rows[dgv_empleados.CurrentRow.Index].Cells["idEmpleado"].Value;
               
                try
                {
                    EmpleadoDAO.Delete(idEmpleado);
                    MessageBox.Show("Empleado eliminado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cargarGrilla();
                   Consulta_Empleado_Load (sender, e);

                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
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
                    }
                }
            }
            cargarGrilla();
        }

        private void btn_aplicar_filtro_persona_Click(object sender, EventArgs e)
        {
             Empleado  per = new Empleado();
           
            if (txt_apellido.Text != "")
            {
                per.Apellido = txt_apellido.Text;
            }
            if (txt_nombre.Text != "")
            {
                per.Nombre = txt_nombre.Text;
            }
           
          
            List<Empleado> empleados = null;
            try
            {
                 empleados =  EmpleadoDAO.GetByFiltro(per);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            cargarGrillaFiltrada(empleados );
        }
      

        private void Consulta_Empleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            iniciador.cantVentanasAbiertas--;

            if (iniciador.cantVentanasAbiertas == 0)
            {
                ((Menu_Principal)(MdiParent)).btn_impresiones.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_ventas.Visible = true;
                ((Menu_Principal)(MdiParent)).btn_pedido.Visible = true;
            }
        }

        private void dgv_empleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Gestion_de_Empleado gestion = new Gestion_de_Empleado();

            gestion._estado = estados.modificar;

            Empleado emp = new Empleado()
            {

                Apellido = (string)dgv_empleados.Rows[dgv_empleados.CurrentRow.Index].Cells["apellido"].Value,

                Nombre = (string)dgv_empleados.Rows[dgv_empleados.CurrentRow.Index].Cells["Nombre"].Value,
                telefono = (string)dgv_empleados.Rows[dgv_empleados.CurrentRow.Index].Cells["telefono"].Value,
                fechaNac = Convert.ToDateTime(dgv_empleados.Rows[dgv_empleados.CurrentRow.Index].Cells["fechaNac"].Value),
                idEmpleado = (int)dgv_empleados.Rows[dgv_empleados.CurrentRow.Index].Cells["idEmpleado"].Value
            };

            gestion._empModificar = emp;
            gestion._estado = estados.modificar;
            gestion.ShowDialog();
            cargarGrilla();
        }

        private void dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_empleados.CurrentCell is DataGridViewButtonCell)
            {

                if ((int)dgv_empleados.CurrentRow.Cells["idestado"].Value == 11)
                {
                    int idEmpleado = (int)dgv_empleados.CurrentRow.Cells["idEmpleado"].Value;

                    try
                    {
                        EmpleadoDAO.UpdateEstado(idEmpleado, 13);
                        MessageBox.Show("Empleado no Disponible", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    //cargarGrilla();
                }
                if ((int)dgv_empleados.CurrentRow.Cells["idestado"].Value == 13)
                {
                    int idEmpleado = (int)dgv_empleados.CurrentRow.Cells["idEmpleado"].Value;

                    try
                    {
                        EmpleadoDAO.UpdateEstado(idEmpleado, 11);
                        MessageBox.Show("Empleado Disponible", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    //cargarGrilla();
                }
                cargarGrilla();
            }
        }
    }

}
