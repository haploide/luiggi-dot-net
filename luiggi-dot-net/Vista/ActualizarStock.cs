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

    public partial class ActualizarStock : Form
    {
        OrdenDeTrabajo orden = new OrdenDeTrabajo();
        double cantidadPedido;
        double cantidadPlan;
        public ActualizarStock(OrdenDeTrabajo OT)
        {
            
            InitializeComponent();
            orden = OT;
            btn_Actualizar.Visible = true;
            btn_Actualizar_OTPadre.Visible = false;
        }
        public ActualizarStock(OrdenDeTrabajo OT, double cantPed, double cantPlan)
        {
            
            InitializeComponent();
            orden = OT;
            cantidadPedido = cantPed;
            cantidadPlan = cantPlan;
            btn_Actualizar_OTPadre.Visible = true;
            btn_Actualizar.Visible = false;
        }
        

        private void ActualizarStock_Load(object sender, EventArgs e)
        {
            lbl_producto.Text = orden.producto.Nombre;
            lbl_unidad.Text = orden.producto.Unidad.Nombre;
            
            txt_cantidad_real.Text = orden.cantidad.ToString();
            txt_cantidad_real.Focus();
            if (btn_Actualizar.Visible == true)
            {
                cargarGrilla();
            }
            if (btn_Actualizar_OTPadre.Visible == true)
            {
                cargarGrillaOTPadre();
            }
        }
        private void cargarGrilla()
        {
            List<DetalleProducto> detalle = EstructuraProductoDAO.GetAll(orden.producto.idProducto);

            foreach (DetalleProducto det in detalle)
            {
                double cant = det.cantidad * orden.cantidad;
                DGV_detalle_Productos.Rows.Add(det.idProducto, det.Nombre, cant,cant, det.Unidad.Nombre);
                //ProductoDAO.UpdateStockReservadoYDisponibleMatiaPrimaOTfinalizada(det.idProducto, cant, cn, tran);
            }
            DGV_detalle_Productos.Columns["cantidadReal"].ReadOnly = false;
            
        }
        private void cargarGrillaOTPadre()
        {
            List<DetalleProducto> detalle = EstructuraProductoDAO.GetAll(orden.producto.idProducto);

            foreach (DetalleProducto det in detalle)
            {
                double cant = det.cantidad * orden.cantidad;
                DGV_detalle_Productos.Rows.Add(det.idProducto, det.Nombre, cant, cant, det.Unidad.Nombre);
                //ProductoDAO.UpdateStockReservadoYDisponibleMatiaPrimaOTfinalizada(det.idProducto, cant, cn, tran);
            }
            DGV_detalle_Productos.Columns["cantidadReal"].ReadOnly = false;

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cantidad_real.Text == "")
                {
                    MessageBox.Show("Complete el campo\"Cantidad real producida\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txt_cantidad_real.Focus();
                    return;
                }

                List<DetalleProducto> productos = new List<DetalleProducto>();
                for (int i = 0; i < DGV_detalle_Productos.RowCount; i++)
                {
                    DetalleProducto p = new DetalleProducto();
                    p.idProducto = int.Parse(DGV_detalle_Productos.Rows[i].Cells["nroProducto"].Value.ToString());
                    p.cantidad = double.Parse(DGV_detalle_Productos.Rows[i].Cells["cantidadReal"].Value.ToString());
                    p.cantidadProductos = double.Parse(DGV_detalle_Productos.Rows[i].Cells["cantidadPlanificada"].Value.ToString());
                    productos.Add(p);
                }
                orden.cantidadReal = double.Parse(txt_cantidad_real.Text);
                OrdenDeTrabajoDAO.finalizarOTHija(orden, productos);
                Estado est = new Estado();
                est.Nombre = "LISTO";
                orden.estado = est;
                Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Ingrese solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_cantidad_real_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validarDouble(e, txt_cantidad_real.Text + e.KeyChar) == false)
            {
                e.KeyChar = (char)Keys.Clear;
                return;
            }
        }
        private Boolean validarDouble(KeyPressEventArgs e, string texto)
        {
            String datos = "0123456789,";
            Boolean result = false;
            double numero;

            try
            {
                if (datos.IndexOf(e.KeyChar) != -1)
                {
                    if (double.TryParse(texto, out numero))
                    {
                        result = true;
                    }
                }
                if (e.KeyChar == '\b')
                {
                    result = true;
                }
            }
            catch (FormatException ex)
            {

                result = false;
            }


            return result;
        }

        private void btn_Actualizar_OTPadre_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cantidad_real.Text == "")
                {
                    MessageBox.Show("Complete el campo\"Cantidad real producida\" antes de confirmar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txt_cantidad_real.Focus();
                    return;
                }

                List<DetalleProducto> productos = new List<DetalleProducto>();
                for (int i = 0; i < DGV_detalle_Productos.RowCount; i++)
                {
                    DetalleProducto p = new DetalleProducto();
                    p.idProducto = int.Parse(DGV_detalle_Productos.Rows[i].Cells["nroProducto"].Value.ToString());
                    p.cantidad = double.Parse(DGV_detalle_Productos.Rows[i].Cells["cantidadReal"].Value.ToString());
                    p.cantidadProductos = double.Parse(DGV_detalle_Productos.Rows[i].Cells["cantidadPlanificada"].Value.ToString());
                    productos.Add(p);
                }
                orden.cantidadReal = double.Parse(txt_cantidad_real.Text);
                cantidadPlan = orden.cantidadReal - cantidadPedido;
                OrdenDeTrabajoDAO.finalizarOTPadre(orden, cantidadPedido, cantidadPlan, productos);
                Estado est = new Estado();
                est.Nombre = "LISTO";
                orden.estado = est;
                Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Ingrese solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
            

        }
    }
}
