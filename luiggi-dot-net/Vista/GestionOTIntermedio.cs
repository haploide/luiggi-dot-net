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
    public partial class GestionOTIntermedio : Form
    {

        private estados estadoFormulario;
        private Producto prodInt;
        private DetallePlanProduccion infoPlan;
        private List<OrdenDeTrabajo> ordenesHijas;

        public estados _estado
        {
            get { return estadoFormulario; }
            set { estadoFormulario = value; }
        }
        public Producto _prodInt
        {
            get { return prodInt; }
            set { prodInt = value; }
        }
        public DetallePlanProduccion _infoPlan
        {
            get { return infoPlan; }
            set { infoPlan = value; }
        }
        public List<OrdenDeTrabajo> _ordenesHijas
        {
            get { return ordenesHijas; }
            set { ordenesHijas = value; }
        }
        public GestionOTIntermedio()
        {
            InitializeComponent();
        }
        private void GestionOTIntermedio_Load(object sender, EventArgs e)
        {
            iniciador.otHija = null;
            cargarProductoYGrilla();
            
            habilitar();
            dtp_creacion_OT.Enabled = false;
        }
        public void cargaCombos()
        {
            if (txt_inicio.Text != "  :" && txt_fin.Text != "  :")
            {
                try
                {
                    List<Maquinaria> maq = MaquinariaDAO.GetAllDisponibles(prodInt.idProducto, dtp_creacion_OT.Value.Date, Convert.ToDateTime(txt_inicio.Text), Convert.ToDateTime(txt_fin.Text));
                    maq.Add(new Maquinaria() { idMaquinaria = -1, Nombre = "<<Seleccione>>" });

                    foreach (OrdenDeTrabajo ot in ordenesHijas)
                    {
                        if ((ot.horaInicio >= Convert.ToDateTime(txt_inicio.Text) && ot.horaInicio <= Convert.ToDateTime(txt_fin.Text)) || (ot.horaFin >= Convert.ToDateTime(txt_inicio.Text) && ot.horaFin <= Convert.ToDateTime(txt_fin.Text)))
                        {
                            Maquinaria aux = null;
                            foreach (Maquinaria ma in maq)
                            {
                                if (ma.idMaquinaria == ot.maquinaria.idMaquinaria)
                                {
                                    aux = ma;

                                }
                            }
                            if (aux != null)
                            {
                                maq.Remove(aux);
                            }


                        }
                    }


                    cmb_maquinaria.DataSource = maq;
                    cmb_maquinaria.DisplayMember = "nombre";
                    cmb_maquinaria.ValueMember = "idMaquinaria";
                    cmb_maquinaria.SelectedValue = -1;

                    List<Empleado> empl = EmpleadoDAO.GetAllDisponible(dtp_creacion_OT.Value.Date, Convert.ToDateTime(txt_inicio.Text), Convert.ToDateTime(txt_fin.Text));

                    empl.Add(new Empleado() { idEmpleado = -1, Nombre = "<<Seleccione>>" });

                    foreach (OrdenDeTrabajo ot in ordenesHijas)
                    {
                        if ((ot.horaInicio >= Convert.ToDateTime(txt_inicio.Text) && ot.horaInicio <= Convert.ToDateTime(txt_fin.Text)) || (ot.horaFin >= Convert.ToDateTime(txt_inicio.Text) && ot.horaFin <= Convert.ToDateTime(txt_fin.Text)))
                        {
                            Empleado aux = null;
                            foreach (Empleado em in empl)
                            {
                                if (em.idEmpleado == ot.empleado.idEmpleado)
                                {
                                    aux = em;

                                }
                            }
                            if (aux != null)
                            {
                                empl.Remove(aux);
                            }

                                                        
                        }
                    }



                    cmb_empleado.DataSource = empl;
                    cmb_empleado.DisplayMember = "nombre";
                    cmb_empleado.ValueMember = "idEmpleado";
                    cmb_empleado.SelectedValue = -1;
                }
                catch (FormatException ex)
                {

                    MessageBox.Show("Error en el formato de las horas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                
                cmb_empleado.Enabled = true;
                cmb_maquinaria.Enabled = true;

            }
            else
            {
                MessageBox.Show("Complete las 2 Horas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void habilitar()
        {
            //cmb_empleado.Enabled = true;
            //cmb_maquinaria.Enabled = true;
            txt_inicio.Enabled = true;
            //txt_fin.Enabled = true;
            txt_inicio.Focus();
        }
        private void bloquear()
        {
            cmb_empleado.Enabled = false;
            cmb_maquinaria.Enabled = false;
            txt_inicio.Enabled = false;
            txt_fin.Enabled = false;
        }
        private void cargarProductoYGrilla()
        {
            txt_Producto.Text = prodInt.Nombre;
            lbl_cant.Text = prodInt.cantidadProductos.ToString();
            lbl_unidad.Text = prodInt.Unidad.Nombre;
            try
            {

                List<DetalleProducto> dp = EstructuraProductoDAO.GetAll(prodInt.idProducto);
                int c = 0;
                dgv_estructuraOT.Rows.Clear();
                
                foreach (DetalleProducto prod in dp)
                {
                    //dgv_estructuraOT.Rows.Add(prod.Nombre, prod.tiempoProduccion);

                    dgv_estructuraOT.Rows.Add();
                    dgv_estructuraOT.Rows[c].Cells["idPro"].Value = prod.idProducto;
                    dgv_estructuraOT.Rows[c].Cells["producto"].Value = prod.Nombre;
                    if (prodInt.Unidad.Nombre == "Unidad")
                    {
                        dgv_estructuraOT.Rows[c].Cells["cantidad"].Value = prod.cantidad * Convert.ToDouble(lbl_cant.Text);
                    }
                    else
                    {
                        dgv_estructuraOT.Rows[c].Cells["cantidad"].Value = (prod.cantidad * Convert.ToDouble(lbl_cant.Text));
                    }
                    dgv_estructuraOT.Rows[c].Cells["categoria"].Value = prod.Categoria.Nombre;
                    dgv_estructuraOT.Rows[c].Cells["unidad"].Value = prod.Unidad.Nombre;




                    c += 1;
                }


            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }
        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        private termino validarDatos()
        {
            if (txt_inicio.Text == "  :")
            {
                errores.SetError(txt_inicio,"Complete la hora de Inicio");
                return termino.rechazado;
            }
            if (txt_fin.Text == "  :")
            {
                errores.SetError(txt_fin, "Complete la hora de Fin");
                return termino.rechazado;
            }
            if ((int)cmb_empleado.SelectedValue == -1)
            {
                errores.SetError(cmb_empleado, "Seleccione un Empleado");
                return termino.rechazado;
            }
            if ((int)cmb_maquinaria.SelectedValue == -1)
            {
                errores.SetError(cmb_maquinaria, "Seleccione una Maquinaria");
                return termino.rechazado;
            }


            return termino.aprobado;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (_estado == estados.nuevo && validarDatos() == termino.aprobado)
            {
                OrdenDeTrabajo orden = new OrdenDeTrabajo();
                
                    orden.fechaPlan = infoPlan.fechaProduccion;
                    orden.estado = new Estado() { idEstado = 19 };
                    orden.idPlan = infoPlan.idPlan;
                    orden.producto=new Producto(){idProducto=infoPlan.producto.idProducto};
                    orden.horaInicio = Convert.ToDateTime(txt_inicio.Text);
                    orden.horaFin = Convert.ToDateTime(txt_fin.Text);
                    orden.productoIntermedio = new Producto() { idProducto = prodInt.idProducto };
                    orden.maquinaria = new Maquinaria() { idMaquinaria = (int)cmb_maquinaria.SelectedValue, Nombre = ((Maquinaria)cmb_maquinaria.SelectedItem).Nombre};
                    orden.empleado = new Empleado() { idEmpleado = (int)cmb_empleado.SelectedValue, Nombre = ((Empleado)cmb_empleado.SelectedItem).Nombre };
                    orden.fechaCreacion=dtp_creacion_OT.Value.Date;
                    orden.cantidad = (float)Convert.ToDouble(lbl_cant.Text);

                
                
                iniciador.otHija = orden;
                       
                MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                _estado = estados.guardado;
                Close();
                Dispose();
            }
            else
            {
               
            }

                
                
            
        }
        private void lbl_cant_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cargar_combos_Click(object sender, EventArgs e)
        {
            DateTime desde = new DateTime();

            if (txt_inicio.Text != "  :")
            {
                try
                {
                    desde = Convert.ToDateTime(txt_inicio.Text);

                    txt_fin.Text = (desde.AddMinutes(prodInt.tiempoProduccion)).ToShortTimeString();
                    cargaCombos();
                }
                catch (FormatException ex)
                {
                    
                    MessageBox.Show("Formato de hora incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txt_inicio.Text = "";
                    txt_inicio.Focus();
                }
            }else
            {
                MessageBox.Show("Complete la hora de Inicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txt_inicio.Focus();
            }
        }
    }
}
