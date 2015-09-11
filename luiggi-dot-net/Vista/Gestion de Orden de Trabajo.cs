using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Entidades;
using DAO;
using System.Windows.Forms;

namespace Vista
{
    public partial class Gestion_de_orden_de_Trabajo : Form
    {
        private List<OrdenDeTrabajo> ordenhija = new List<OrdenDeTrabajo>();
        private estados estadoFormulario;
        public OrdenDeTrabajo ordenModificar;
        public DetallePlanProduccion infoPlan;
        public Boolean bloquear = false;


        public estados _estado
        {
            get { return estadoFormulario; }
            set { estadoFormulario = value; }
        }
        public OrdenDeTrabajo _ordenModificar
        {
            get { return ordenModificar; }
            set { ordenModificar = value; }
        }
        public Gestion_de_orden_de_Trabajo()
        {
                  InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Gestion_de_orden_de_Trabajo_Load(object sender, EventArgs e)
        {
            cargaCombo();
        }
        public void cargaCombo()
        {
            List<Producto> prod = ProductoDAO.GetByFiltrosOT(dtp_creacion_OT.Value.Date );
            prod.Add(new Producto { idProducto  = 0, Nombre = "SELECCIONE" });

            cmb_productos.DataSource = prod;
            cmb_productos.DisplayMember = "nombre";
            cmb_productos.ValueMember = "idProducto";
            cmb_productos.SelectedValue = 0;

            
        }
        public void cargaCombos()
        {
            if (txt_inicio.Text != "  :" && txt_fin.Text != "  :")
            {
                try
                {
                    List<Maquinaria> maq = MaquinariaDAO.GetAllDisponibles((int)cmb_productos.SelectedValue, dtp_creacion_OT.Value.Date, Convert.ToDateTime(txt_inicio.Text), Convert.ToDateTime(txt_fin.Text));
                    maq.Add(new Maquinaria() { idMaquinaria = -1, Nombre = "<<Seleccione>>" });

                    cmb_maquinaria.DataSource = maq;
                    cmb_maquinaria.DisplayMember = "nombre";
                    cmb_maquinaria.ValueMember = "idMaquinaria";
                    cmb_maquinaria.SelectedValue = -1;

                    List<Empleado> empl = EmpleadoDAO.GetAllDisponible(dtp_creacion_OT.Value.Date, Convert.ToDateTime(txt_inicio.Text), Convert.ToDateTime(txt_fin.Text));

                    empl.Add(new Empleado() { idEmpleado = -1, Nombre = "<<Seleccione>>" });
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
        private void btn_salir_consulta_Click(object sender, EventArgs e)
        {
            if (ordenhija.Count > 0 && _estado != estados.guardado)
            {
                if (MessageBox.Show("¿Desea Salir sin Guardar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Close();
                    Dispose();
                }
            }
            else
            {
                Close();
                Dispose();
            }
           
        }
        private void cmb_productos_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if ((int)cmb_productos.SelectedValue!=0)
            {
                int idProducto = Convert.ToInt32(cmb_productos.SelectedValue);
                Producto p = new Producto();
                infoPlan = new DetallePlanProduccion();
                infoPlan = DetallePlanProduccionDAO.GetDetallePlanXProductoParaOT((int)cmb_productos.SelectedValue, dtp_creacion_OT.Value.Date);

                p = ProductoDAO.GetByIdProd(idProducto, dtp_creacion_OT.Value.Date);
                lbl_cant.Text = p.cantidadAProd.ToString();
                lbl_unidad.Text = p.Unidad.Nombre;
                lbl_tiempo.Text = ((Convert.ToDouble(lbl_cant.Text) * p.tiempoProduccion) / p.cantidadProductos).ToString();
                List<DetalleProducto> dp = new List<DetalleProducto>();

                try
                {
                    dp = EstructuraProductoDAO.GetAll(idProducto);
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                cargarGrillaDetalleProducto(dp); 
            }
        }
        private void cargarGrillaDetalleProducto(List<DetalleProducto> dp )
        {
            
            try
            {
                int c = 0;
                    dgv_estructuraOT.Rows.Clear();
                    dgv_estructuraOT.Columns["horaFin"].DefaultCellStyle.Format = "HH:mm";
                   
                foreach (DetalleProducto prod in dp)
                    {
                        //dgv_estructuraOT.Rows.Add(prod.Nombre, prod.tiempoProduccion);
                        
                        dgv_estructuraOT.Rows.Add();
                        dgv_estructuraOT.Rows[c].Cells["idPro"].Value = prod.idProducto;
                        dgv_estructuraOT.Rows[c].Cells["producto"].Value = prod.Nombre;
                        if (prod.Categoria.IDCategoria == 2)
                        {

                            
                            if (lbl_unidad.Text == "g")
                            {
                                dgv_estructuraOT.Rows[c].Cells["duracion"].Value = (((prod.cantidad) * Convert.ToDouble(lbl_cant.Text)) * prod.tiempoProduccion / prod.cantidadProductos) + 10;//(cantida del label * cantidad de la estructura)*duracion hombres/cantidad productos
                                dgv_estructuraOT.Rows[c].Cells["cantidad"].Value = (prod.cantidad * Convert.ToDouble(lbl_cant.Text)); //(cantida del label * cantidad de la estructura)
                            }
                            else
                            {
                                dgv_estructuraOT.Rows[c].Cells["duracion"].Value = ((prod.cantidad * Convert.ToDouble(lbl_cant.Text)) * prod.tiempoProduccion / prod.cantidadProductos) + 10;//(cantida del label * cantidad de la estructura)*duracion hombres/cantidad productos
                                dgv_estructuraOT.Rows[c].Cells["cantidad"].Value = prod.cantidad * Convert.ToDouble(lbl_cant.Text);
                            }
                            dgv_estructuraOT.Rows[c].Cells["tiempo"].Value = prod.UnidadTiempo.Nombre;
                            dgv_estructuraOT.Rows[c].Cells["Estado"].Value = 0;

                            
                            if (_estado == estados.nuevo)
                            {
                                dgv_estructuraOT.Rows[c].DefaultCellStyle.BackColor = Color.LightSalmon;
                            }
                            
                        }
                        else 
                        {
                            dgv_estructuraOT.Rows[c].Cells["duracion"].Value = "N/D";
                            if (lbl_unidad.Text == "g")
                            {
                                dgv_estructuraOT.Rows[c].Cells["cantidad"].Value = (prod.cantidad * Convert.ToDouble(lbl_cant.Text));
                            }
                            else
                            {
                                dgv_estructuraOT.Rows[c].Cells["cantidad"].Value = prod.cantidad * Convert.ToDouble(lbl_cant.Text);
                            }
                            dgv_estructuraOT.Rows[c].Cells["tiempo"].Value = "N/D";
                            dgv_estructuraOT.Rows[c].Cells["Estado"].Value = 1;
 
                        }
                        
                        dgv_estructuraOT.Rows[c].Cells["categoria"].Value = prod.Categoria.Nombre;
                        dgv_estructuraOT.Rows[c].Cells["idCategoria"].Value = prod.Categoria.IDCategoria;
                       
                        dgv_estructuraOT.Rows[c].Cells["unidad"].Value = prod.Unidad.Nombre ;

                       
                        //dgv_estructuraOT.Rows[c].Cells["horaInicio"].Value = "__:__";
                        //dgv_estructuraOT.Rows[c].Cells["horaFin"].Value = "__:__";
                        //dgv_estructuraOT.Rows[c].Cells["maquinaria"].Value = 

                        
                        c = c + 1;
                    }

                
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void dgv_estructuraOT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((int)dgv_estructuraOT.CurrentRow.Cells["idCategoria"].Value == 2 && (int)dgv_estructuraOT.CurrentRow.Cells["Estado"].Value == 0)
            {
                GestionOTIntermedio gestion = new GestionOTIntermedio();
                Producto pro = new Producto();
                pro.Nombre = dgv_estructuraOT.CurrentRow.Cells["Producto"].Value.ToString();
                pro.idProducto = (int)dgv_estructuraOT.CurrentRow.Cells["idPro"].Value;
                pro.cantidadProductos = (double)dgv_estructuraOT.CurrentRow.Cells["cantidad"].Value;
                pro.Unidad = new UnidadMedida() { Nombre = dgv_estructuraOT.CurrentRow.Cells["unidad"].Value.ToString() };
                pro.tiempoProduccion = (double)dgv_estructuraOT.CurrentRow.Cells["duracion"].Value;
                DataGridViewRow fila = dgv_estructuraOT.CurrentRow;

                gestion._infoPlan = infoPlan;
                gestion._ordenesHijas = ordenhija;
                gestion._prodInt = pro;
                gestion.ShowDialog();

                
                if (gestion._estado==estados.guardado)
                {
                    fila.DefaultCellStyle.BackColor = Color.LightGreen;
                    fila.Cells["Estado"].Value = 1;
                }
                
                if (iniciador.otHija!=null)
                {
                    ordenhija.Add(iniciador.otHija); 
                }
                verificarEstados();
            }
        }
        private void verificarEstados()
        {
            Boolean listo = true;

            foreach (DataGridViewRow fila in dgv_estructuraOT.Rows)
            {
                if ((int)fila.Cells["Estado"].Value == 0)
                {
                    listo = false;
                    
                }
            }


            if (listo == true)
            {
                obtenerHoraInicioOTPadre();
                txt_inicio.Enabled = true;
                txt_inicio.Focus();
                btn_cargar_combos.Enabled = true;
                bloquear = true;
                btn_guardar.Enabled = true;
                cmb_productos.Enabled = false;

            }
        }
        public void obtenerHoraInicioOTPadre() 
        {
            DateTime aux= new DateTime();
            Boolean esPrimero = true;
            foreach (OrdenDeTrabajo ot in ordenhija)
            {
                if (esPrimero == true)
                {
                    aux = ot.horaFin;
                    esPrimero = false;
                }
                else
                {
                    if (ot.horaFin >= aux)
                    {
                        aux = ot.horaFin;
                    }
                }

            }
            txt_inicio.Text = aux.AddMinutes(10).ToShortTimeString();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (_estado == estados.nuevo && validarDatos() == termino.aprobado)
            {
                OrdenDeTrabajo orden = new OrdenDeTrabajo()
                {
                    fechaPlan = infoPlan.fechaProduccion,
                    estado = new Estado() { idEstado = 19 },
                    idPlan = infoPlan.idPlan,
                    producto = new Producto() { idProducto = infoPlan.producto.idProducto },
                    horaInicio = Convert.ToDateTime(txt_inicio.Text),
                    horaFin = Convert.ToDateTime(txt_fin.Text),
                    maquinaria = new Maquinaria() { idMaquinaria = (int)cmb_maquinaria.SelectedValue },
                    empleado = new Empleado() { idEmpleado = (int)cmb_empleado.SelectedValue },
                    fechaCreacion = dtp_creacion_OT.Value.Date,
                    cantidad=(float)Convert.ToDouble(lbl_cant.Text),
                    

                };
                try
                {
                    OrdenDeTrabajoDAO.InsertPadre(orden, ordenhija);
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    
                }

                MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                
                bloquear = false;
                btn_guardar.Enabled = false;
                btn_cargar_combos.Enabled = false;
                txt_inicio.Enabled = false;
                limpiar();
                _estado = estados.guardado;
            }
            else
            {

            }

            btn_salir_consulta_Click(sender, e);
            
        }
        private void Gestion_de_orden_de_Trabajo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private termino validarDatos()
        {
            if (txt_inicio.Text == "  :")
            {
                errores.SetError(txt_inicio, "Complete la hora de Inicio");
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
        private void btn_cargar_combos_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde = new DateTime();
                DateTime hasta = new DateTime();
                desde = Convert.ToDateTime(txt_inicio.Text);
                hasta = desde.AddMinutes(Convert.ToDouble(lbl_tiempo.Text));
                txt_fin.Text = hasta.TimeOfDay.ToString();

                cargaCombos();
            }
            catch (Exception ex)
            {
                
                
            }
        }
        private void limpiar()
        {
            cmb_productos.SelectedValue = 0;
            cmb_productos.Enabled = true;
            cmb_maquinaria.SelectedValue = 0;
            cmb_maquinaria.Enabled = false;
            cmb_empleado.SelectedValue = 0;
            cmb_empleado .Enabled = false;

            txt_fin.Text = "";
            txt_inicio.Text = "";

            lbl_cant.Text = "0";
            lbl_unidad.Text = "";

            cargaCombo();
            dgv_estructuraOT.Rows.Clear();
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            _estado = estados.nuevo;
        }
        private void cmb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            limpiar();
            

        }

        
    }
}
