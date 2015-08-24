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
    public partial class GestionPlanMaestroProduccion : Form
    {
        private estados estadoFormulario;
        private PlanMaestroProduccion planModificar;
        private List<DetallePlanProduccion> desreservar;

        public estados _estado
        {
            get { return estadoFormulario; }
            set { estadoFormulario = value; }
        }
        public PlanMaestroProduccion _planModificar
        {
            get { return planModificar; }
            set { planModificar = value; }
        }
        public GestionPlanMaestroProduccion()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (contarfilas()>0 && _estado!=estados.guardado)
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
        private void GestionPlanMaestroProduccion_Load(object sender, EventArgs e)
        {
            cargarGrillaProductos();
            if (estadoFormulario == estados.nuevo)
            {
                //habilitar();
                dtp_fecha_inicio.Enabled = true;
            }
            if (estadoFormulario == estados.modificar)
            {
                cargarModificacion();
                habilitar();
                btn_guardar.Enabled = true;
            }
            
            
        }
        public void cargarGrillaProductos()
        {
            try
            {
                List<Producto> productos = ProductoDAO.GetPeductosFinales();
                
                dgv_productos_finales.Rows.Clear();
                foreach (Producto prod in productos)
                {
                    int fila=dgv_productos_finales.Rows.Add(prod.CODProducto, prod.Nombre, prod.Descripcion, prod.Unidad.Nombre, prod.StockRiesgo*2,prod.StockRiesgo, prod.StockActual, prod.StockDisponible, prod.StockReservado, prod.idProducto);
                    if(prod.StockDisponible<=prod.StockRiesgo)
                    {
                        dgv_productos_finales.Rows[fila].DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void dtp_fecha_inicio_ValueChanged(object sender, EventArgs e)
        {

            limpiarGrillas();
            if (dtp_fecha_inicio.Value.Date < dtp_creacion_plan.Value.Date)
            {
                //MessageBox.Show("La fecha de inicio del plan no puede ser anterior a la actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                dtp_fecha_inicio.Value =dtp_fecha_inicio.Value.AddDays(7); ;
                dtp_fecha_final.Value = dtp_fecha_inicio.Value.AddDays(6);
                //deshabilitar();
                dtp_fecha_inicio.Focus();
                
                }
            else
            {
                dtp_fecha_final.Value = dtp_fecha_inicio.Value;
            }

            int result = DayOfWeek.Sunday-dtp_fecha_inicio.Value.DayOfWeek;
            dtp_fecha_inicio.Value = dtp_fecha_inicio.Value.AddDays(result);
            dtp_fecha_final.Value = dtp_fecha_inicio.Value.AddDays(6);
            limpiarGrillas();
            cargarPestanias(); 
            foreach (TabPage tab in tab_dias.TabPages)
            {
                
                List<DetallePedido> pedidos = new List<DetallePedido>();
                foreach (Control contl in tab.Controls)
                {
                    if (contl is DateTimePicker)
                    {
                        try
                        {
                            pedidos = DetallePedidoDAO.getCantidadPedidaxProducto(((DateTimePicker)contl).Value.Date);
                            if (pedidos.Count > 0)
                            {
                                btn_guardar.Enabled = true;
                            }
                        }
                        catch (ApplicationException ex)
                        {
                            
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
 
                    }
                    
                }
                foreach (Control contl in tab.Controls)
                {
                    
                    if (contl is DataGridView)
                    {

                        foreach (DetallePedido ped in pedidos)
                        {
                            ((DataGridView)contl).Rows.Add(ped.producto.idProducto, ped.producto.Nombre, null, 0, ped.cantidad, ped.cantidad, ped.producto.Unidad.Nombre);
                        }
                    }
                }
            }


        }
        private void dtp_fecha_final_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_fecha_final.Value.Date < dtp_fecha_inicio.Value.Date)
            {
               // MessageBox.Show("La fecha de finalizacion del plan no puede ser anterior a la de inicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                dtp_fecha_final.Value = dtp_fecha_inicio.Value;
                deshabilitar();
                dtp_fecha_final.Focus();
            }
            else
            {
                habilitar();
            }
        }
        private void habilitar()
        {
            tab_dias.Enabled = true;
            dgv_productos_finales.Enabled = true;
            dgv_detalle_lunes.Enabled = true;
            dgv_detalle_martes.Enabled = true;
            dgv_detalle_miercoles.Enabled = true;
            dgv_detalle_jueves.Enabled = true;
            dgv_detalle_viernes.Enabled = true;
            dgv_detalle_sabado.Enabled = true;
            dgv_detalle_domingo.Enabled = true;
            txt_cantidad.Enabled = true;
            btn_agregar.Enabled = true;
            btn_quitar.Enabled = true;
            if (_estado == estados.nuevo)
            {
                dtp_fecha_inicio.Enabled = true;
            }
            
        }
        private void deshabilitar()
        {
            tab_dias.Enabled = false;
            dgv_productos_finales.Enabled = false;
            dgv_detalle_lunes.Enabled = false;
            dgv_detalle_martes.Enabled = false;
            dgv_detalle_miercoles.Enabled = false;
            dgv_detalle_jueves.Enabled = false;
            dgv_detalle_viernes.Enabled = false;
            dgv_detalle_sabado.Enabled = false;
            dgv_detalle_domingo.Enabled = false;
            txt_cantidad.Enabled = false;
            btn_agregar.Enabled = false;
            btn_quitar.Enabled = false;
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            foreach (Control contrl in tab_dias.SelectedTab.Controls)
            {
                if (contrl is DataGridView)
                {
                    cargarAGrilla((DataGridView)contrl);
                }
            }
        }
        private void cargarAGrilla(DataGridView grilla)
        {
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("Complete el campo cantidad ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
            else
            {
                Boolean result = false;
                int compararProducto = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["idProducto"].Value;



                for (int c = 0; c < grilla.RowCount; c++)
                {
                    if (compararProducto == (int)grilla.Rows[c].Cells[0].Value)
                    {
                        result = true;
                    }


                }

                if (result == false)
                {
                    int idPro = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["idProducto"].Value;
                    //int cod = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["cod"].Value;
                    string nom = (string)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["nombreproducto"].Value;
                    string uni = (string)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["unidad"].Value;
                    double stockDisponible = (double)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["stockActual"].Value;
                    double stockriesgo = (double)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["stcokRiesgo"].Value;
                    double can = Convert.ToDouble(txt_cantidad.Text); ;

                    if (stockDisponible < stockriesgo && can < stockriesgo)
                    {
                        can = stockriesgo;
                    }
                    

                    int pedidos = 0;
                    DateTime fecha=new DateTime();
                   

                    foreach (Control ctrl in grilla.Parent.Controls)
                    {
                        if(ctrl is DateTimePicker)
                        {
                            fecha = ((DateTimePicker)ctrl).Value.Date;
                        }
                    }
                    try
                    {
                        //pedidos = ProductoDAO.BuscarProductoPedidoSinReservaParaFecha(idPro, fecha);
                    }
                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                    grilla.Rows.Add(idPro, nom, fechaProduccion, can, pedidos, can + pedidos, uni, "Asignar Pedidos");



                    txt_cantidad.Text = "";
                    btn_quitar.Enabled = true;
                    btn_guardar.Enabled = true;

                }
                else
                {
                    if (MessageBox.Show("Ya se cargó el producto, ¿Desea Modificar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        int index = (int)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["idProducto"].Value;

                        for (int c = 0; c < grilla.RowCount; c++)
                        {
                            if ((int)grilla.Rows[c].Cells[0].Value == index)
                            {
                                double stockDisponible = (double)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["stockActual"].Value;
                                double stockriesgo = (double)dgv_productos_finales.Rows[dgv_productos_finales.CurrentRow.Index].Cells["stcokRiesgo"].Value;
                                double canplan = Convert.ToDouble(txt_cantidad.Text);
                                int canpedido = Convert.ToInt32(grilla.Rows[c].Cells[4].Value);
                                if (stockDisponible < stockriesgo && canplan < stockriesgo)
                                {
                                    canplan = stockriesgo;
                                }
                                grilla.Rows[c].Cells[3].Value = canplan;
                                grilla.Rows[c].Cells[5].Value = canplan+canpedido;

                            }
                        }

                        txt_cantidad.Text = "";
                    }

                }
            }
        }
        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
            if (e.KeyChar == 13)
            {
                btn_agregar_Click(sender,e);
            }
        }
        private void btn_quitar_Click(object sender, EventArgs e)
        {
            int acumulador = 0;
            foreach (Control contrl in tab_dias.SelectedTab.Controls)
            {
                if (contrl is DataGridView)
                {
                    quitarDeGrilla((DataGridView)contrl);
                }
            }
            for (int c = 0; c < tab_dias.TabCount - 1; c++)
            {
                foreach (Control contrl in tab_dias.TabPages[c].Controls)
                {
                    if (contrl is DataGridView)
                    {
                        acumulador = acumulador + ((DataGridView)contrl).Rows.Count;
                    }
                }
            }
            if (acumulador == 0)
            {
                btn_guardar.Enabled = false;
            }

        }
        private void quitarDeGrilla(DataGridView grilla)
        {
            if (Convert.ToInt32(grilla.CurrentRow.Cells[4].Value) == 0)
            {
                if (grilla.Rows.Count > 0)
                {
                    grilla.Rows.Remove(grilla.CurrentRow);

                }
            }
            else
            {
                grilla.CurrentRow.Cells[3].Value = 0;
                grilla.CurrentRow.Cells[5].Value = grilla.CurrentRow.Cells[4].Value;
            }

            
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            
        }
        private void limpiar()
        {
            txt_cantidad.Text = "";
            txt_observaciones.Text = "";
            dtp_creacion_plan.Value = DateTime.Now;
            dtp_fecha_inicio.Value = dtp_creacion_plan.Value;
            //dtp_fecha_final.Value = dtp_creacion_plan.Value.AddDays(6);
            
            foreach (TabPage tab in tab_dias.TabPages)
            {
                foreach (Control contl in tab.Controls)
                {
                    if (contl is DataGridView)
                    {
                        ((DataGridView)contl).Rows.Clear();
                    }
                    
                }
            }
            cargarPestanias();
            btn_guardar.Enabled = false;
            _estado = estados.nuevo;
            deshabilitar();
            dtp_fecha_inicio.Focus();

        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
                    if (estadoFormulario == estados.nuevo)
                    {
                        if (PlanMaestroProduccionDAO.verificarExistenciaPlanParaPeriodo(dtp_fecha_inicio.Value.Date, dtp_fecha_final.Value.Date)==false)
                        {
                            PlanMaestroProduccion plan = new PlanMaestroProduccion()
                                            {
                                                detallePlan = crearDetalle(),
                                                fechaCreacion = dtp_creacion_plan.Value.Date,
                                                fechaInicio = dtp_fecha_inicio.Value.Date,
                                                fechaFin = dtp_fecha_final.Value.Date,
                                                observaciones = txt_observaciones.Text,
                                                estado = new Estado() { idEstado = 17 }

                                            };

                            try
                            {
                                List<Producto> productosConPocaMP = new List<Producto>();
                                PlanMaestroProduccionDAO.Insert(plan, productosConPocaMP);
                                ////////////// MOSTRAR LOS PRODUCTOS CON BAJO STOCK
                                if (productosConPocaMP.Count > 0)
                                {
                                    string mensaje = "";
                                    List<Producto> prodConPocoStock = new List<Producto>();
                                    Boolean MPRepetida = false;
                                    foreach (Producto Prod in productosConPocaMP)
                                    {
                                        foreach (Producto P in prodConPocoStock)
                                        {
                                            if (P.idProducto == Prod.idProducto)
                                            {
                                                MPRepetida = true;
                                                break;
                                            }
                                        }
                                        if (MPRepetida == false)
                                        {
                                            mensaje += Environment.NewLine + Prod.Nombre.ToString();
                                            prodConPocoStock.Add(Prod);
                                        }

                                    }
                                    MessageBox.Show("Los siguientes productos estan con bajo stock: " + mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                /////////////////////////////////////////////////////////////
                                
                                MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                limpiar();
                                _estado = estados.guardado;

                            }
                            catch (ApplicationException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ya Existe un Plan Para ese Periodo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                        }
                    }
                    else
                    {
                        PlanMaestroProduccion plan = new PlanMaestroProduccion()
                        {
                            IDPlanProduccion = planModificar.IDPlanProduccion,
                            detallePlan = crearDetalle(),
                            fechaCreacion = dtp_creacion_plan.Value.Date,
                            fechaInicio = dtp_fecha_inicio.Value.Date,
                            fechaFin = dtp_fecha_final.Value.Date,
                            observaciones = txt_observaciones.Text,
                            estado = new Estado() { idEstado = 17 }

                        };
                        if (estadoFormulario == estados.modificar)
                        {
                            try
                            {
                                List<Producto> productosConPocaMP = new List<Producto>();
                                PlanMaestroProduccionDAO.Update(plan,desreservar, productosConPocaMP);
                                ////////////// MOSTRAR LOS PRODUCTOS CON BAJO STOCK
                                if (productosConPocaMP.Count > 0)
                                {
                                    string mensaje = "";
                                    List<Producto> prodConPocoStock = new List<Producto>();
                                    Boolean MPRepetida = false;
                                    foreach (Producto Prod in productosConPocaMP)
                                    {
                                        foreach (Producto P in prodConPocoStock)
                                        {
                                            if (P.idProducto == Prod.idProducto)
                                            {
                                                MPRepetida = true;
                                                break;
                                            }
                                        }
                                        if (MPRepetida == false)
                                        {
                                            mensaje += Environment.NewLine + Prod.Nombre.ToString();
                                            prodConPocoStock.Add(Prod);
                                        }

                                    }
                                    MessageBox.Show("Los siguientes productos estan con bajo stock: " + mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                /////////////////////////////////////////////////////////////
                                MessageBox.Show("Registrado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                limpiar();
                                _estado = estados.guardado;
                                dtp_fecha_inicio.Enabled = true;
                                
                            }
                            catch (ApplicationException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }

                        }
                    }


                
            }
        public void cargarModificacion()
        {
            PlanMaestroProduccion plan = PlanMaestroProduccionDAO.GetById(planModificar.IDPlanProduccion);

            dtp_creacion_plan.Value = plan.fechaCreacion;
            dtp_fecha_inicio.Value = plan.fechaInicio;
            dtp_fecha_final.Value = plan.fechaFin;
            txt_observaciones.Text = plan.observaciones;

            cargarGrillaDetalle(planModificar.IDPlanProduccion);

        }
        private void cargarGrillaDetalle(int plan)
        {
            try
            {
                List<DetallePlanProduccion> detPlan = DetallePlanProduccionDAO.GetDetalleXPlan(plan);
                desreservar = detPlan;
                limpiarGrillas();
                foreach (DetallePlanProduccion detP in detPlan)
                {
                    //dgv_detalle_lunes.Rows.Add(detP.producto.idProducto, detP.producto.Nombre, detP.cantidad, detP.producto.Unidad.Nombre);
                    
                    foreach (Control cont in tab_dias.TabPages[((int)detP.fechaProduccion.DayOfWeek)].Controls)
                    {
                        if (cont is DataGridView)
                        {
                            cargarGrillaEnTab(detP, (DataGridView)cont);
                        }
                    }
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }
        private void limpiarGrillas()
        {
            foreach (TabPage tab in tab_dias.TabPages)
            {
                foreach (Control ctrl in tab.Controls)
                {
                    if (ctrl is DataGridView)
                    {
                        ((DataGridView)ctrl).Rows.Clear();
                    }
                }
            }
        }
        private void cargarGrillaEnTab(DetallePlanProduccion detP, DataGridView grilla)
        {
            grilla.Rows.Add(detP.producto.idProducto, detP.producto.Nombre, detP.fechaProduccion, detP.cantidadPLan, detP.cantidadPedido, detP.cantidadPLan+detP.cantidadPedido, detP.producto.Unidad.Nombre, "Asignar Pedidos");
        }
        private void cargarPestanias()
        {
            tab_dias.TabPages["domingo"].Text = "Domingo " + dtp_fecha_inicio.Value.Day + "/" + dtp_fecha_inicio.Value.Month;
            dtp_domingo.Value = dtp_fecha_inicio.Value;
            tab_dias.TabPages["lunes"].Text = "Lunes " + dtp_fecha_inicio.Value.AddDays(1).Day + "/" + dtp_fecha_inicio.Value.AddDays(1).Month;
            dtp_lunes.Value = dtp_fecha_inicio.Value.AddDays(1);
            tab_dias.TabPages["martes"].Text = "Martes " + dtp_fecha_inicio.Value.AddDays(2).Day + "/" + dtp_fecha_inicio.Value.AddDays(2).Month;
            dtp_martes.Value=dtp_fecha_inicio.Value.AddDays(2);
            tab_dias.TabPages["miercoles"].Text = "Miercoles " + dtp_fecha_inicio.Value.AddDays(3).Day + "/" + dtp_fecha_inicio.Value.AddDays(3).Month;
            dtp_miercoles.Value=dtp_fecha_inicio.Value.AddDays(3);
            tab_dias.TabPages["jueves"].Text = "Jueves " + dtp_fecha_inicio.Value.AddDays(4).Day + "/" + dtp_fecha_inicio.Value.AddDays(4).Month;
            dtp_jueves.Value=dtp_fecha_inicio.Value.AddDays(4);
            tab_dias.TabPages["viernes"].Text = "Viernes " + dtp_fecha_inicio.Value.AddDays(5).Day + "/" + dtp_fecha_inicio.Value.AddDays(5).Month;
            dtp_viernes.Value=dtp_fecha_inicio.Value.AddDays(5);
            tab_dias.TabPages["sabado"].Text = "Sabado " + dtp_fecha_inicio.Value.AddDays(6).Day + "/" + dtp_fecha_inicio.Value.AddDays(6).Month;
            dtp_sabado.Value = dtp_fecha_inicio.Value.AddDays(6);
            tab_dias.Enabled = true;
            txt_cantidad.Enabled = true;
            
        }
        public void cargarCantidadDePedidosGenerico(int id, DateTimePicker dtp)
        {
            
                //int id = Convert.ToInt32(((DataGridView)sender).CurrentRow.Cells[0].Value);
                //int cantPlanificada = Convert.ToInt32(((DataGridView)sender).CurrentRow.Cells[3].Value);
                //DateTime fecha = dtp.Value.Date;
                //int? resul = null;

                //DataGridViewRow fila = ((DataGridView)sender).CurrentRow;

                //try
                //{
                //    resul = 
                //}
                //catch (ApplicationException ex)
                //{
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //}

                //if (resul != null)
                //{
                //    fila.Cells[4].Value = resul;
                //    fila.Cells[5].Value = resul + cantPlanificada;

                //}


            

        }
        
        private List<DetallePlanProduccion> crearDetalle()
        {
            List<DetallePlanProduccion> detalle = new List<DetallePlanProduccion>();


            foreach (TabPage tab in tab_dias.TabPages)
            {
                foreach (Control ctrl in tab.Controls)
                {
                    
                    if (ctrl is DataGridView)
                    {
                        
                        for (int c = 0; c < ((DataGridView)ctrl).RowCount; c++)
                        {
                            DetallePlanProduccion de = new DetallePlanProduccion();
                            Producto p = new Producto();
                            p.idProducto = (int)((DataGridView)ctrl).Rows[c].Cells[0].Value;
                            de.cantidadPLan = Convert.ToInt32(((DataGridView)ctrl).Rows[c].Cells[3].Value);
                            de.cantidadPedido = Convert.ToInt32(((DataGridView)ctrl).Rows[c].Cells[4].Value);
                            de.producto = p;


                            foreach (Control con in ctrl.Parent.Controls)
                            {
                                if (con is DateTimePicker)
                                {
                                    de.fechaProduccion = ((DateTimePicker)con).Value.Date;
                                } 
                            }
                            detalle.Add(de);
                        }
                        
                    }
                    
                    
                } 
            }

            return detalle;
        }

        private void dgv_productos_finales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_unidad.Text = dgv_productos_finales.CurrentRow.Cells["unidad"].Value.ToString();
            txt_cantidad.Text = dgv_productos_finales.CurrentRow.Cells["cantidadSugerida"].Value.ToString();
            tp_mesajes.Show("Cantidad Sugerida", txt_cantidad);
        }

        private int contarfilas()
        {
            int cantidad = 0;
            foreach (TabPage tab in tab_dias.TabPages)
            {
                foreach (Control ctrl in tab.Controls)
                {
                    if (ctrl is DataGridView)
                    {
                        cantidad += ((DataGridView)ctrl).Rows.Count;
                    }
                }
            }
            return cantidad;
        }

        

        

        
        
            
        
    }
}
