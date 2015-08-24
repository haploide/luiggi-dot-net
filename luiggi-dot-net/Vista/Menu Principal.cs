using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu_Principal : Form
    {
        Consultas_Cliente consCli = null;
        Consultas_Producto consProd = null;
        Consulta_de_Pedidos consPed = null;
        Gestionar_Estructura_Productos Estr = null;
        Consulta_Planes_Produccion planes = null;
        ConsultarOrdenTrabajo Ordenes = null;
        Consulta_Proveedor consProv = null;
        Gestion_Producto_X_Proveedor consProdProv = null;
        Consultar_Orden_de_Compra consOrCom = null;
        Gestion_de_Facturas facturas = null;
        Gestion_de_Pago_a_Proveedores ordenesCompra = null;
        Consulta_Maquinaria gestMaquina = null;
        Consulta_Empleado gestEmpleado = null;

        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            statusStrip.Items["ts_fecha"].Text = DateTime.Now.ToShortDateString();

            Inicio_Sesion login = new Inicio_Sesion();
            login.ShowDialog(this);
        }

        private void gestionProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (consProd == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                consProd = new Consultas_Producto();
                consProd.MdiParent = this;
                consProd.Show();
            }
            else
            {
                consProd.BringToFront();
            }
            
        }

        private void gestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (consCli == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                consCli = new Consultas_Cliente();
                consCli.MdiParent = this;
                consCli.Show();
            }
            else
            {
                consCli.BringToFront();
            }
                       
        }

        private void gestionDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("Consulta Pedido"))
            {
                MessageBox.Show("no tenes permiso forro.");
                return;
            }

            if (consPed == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                consPed = new Consulta_de_Pedidos();
                consPed.MdiParent = this;
                consPed.Show();
            }
            else
            {
            consPed. BringToFront();
            }
        }

        private void gestionDeEstructuraDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Estr == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                Estr = new Gestionar_Estructura_Productos();
                Estr.MdiParent = this;
                Estr.Show();
            }
            else
            {
                Estr.BringToFront();
            }
        }

        private void gestionDePlanesDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (planes ==null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                planes = new Consulta_Planes_Produccion();
                planes.MdiParent = this;
                planes.Show();
            }
            else
            {
                planes.BringToFront();
            }
        }

        private void gestionDeOrdenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Ordenes == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                Ordenes = new ConsultarOrdenTrabajo();
                Ordenes.MdiParent = this;
                Ordenes.Show();
            }
            else
            {
                Ordenes.BringToFront();
            }
        }

        private void gestionDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (consProv == null)
            //{
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                consProv = new Consulta_Proveedor();
                consProv.MdiParent = this;
                consProv.Show();
            //}
            //else
            //{
            //    consProv.BringToFront();
            //}
        }

        private void gestionProductoPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (consProdProv == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                consProdProv = new Gestion_Producto_X_Proveedor();
                consProdProv.MdiParent = this;
                consProdProv.Show();
            }
            else
            {
                consProdProv.BringToFront();
            }
        }

        private void gestionarComprasDeMateriaPrimaEInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (consOrCom == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                consOrCom = new Consultar_Orden_de_Compra();
                consOrCom.MdiParent = this;
                consOrCom.Show();
            }
            else
            {
                consOrCom.BringToFront();
            }
        }

        private void registrarCobroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (facturas == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                facturas = new Gestion_de_Facturas();
                facturas.MdiParent = this;
                facturas.Show();
            }
            else
            {
                facturas.BringToFront();
            }


        }

        private void gestionDePagoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ordenesCompra == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                ordenesCompra = new Gestion_de_Pago_a_Proveedores();
                ordenesCompra.MdiParent = this;
                ordenesCompra.Show();
            }
            else
            {
                ordenesCompra.BringToFront();
            }
        }

        private void informeDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emitir_Informe_de_Stock stock = new Emitir_Informe_de_Stock();
            stock.ShowDialog();

        }

        private void ventaDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Venta_Directa ventaDirecta = new Gestion_Venta_Directa();
            ventaDirecta.ShowDialog();
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            contextMenuStripVentas.Show();
            contextMenuStripVentas.SetBounds(((MouseEventArgs)e).Location.X+33, ((MouseEventArgs)e).Location.Y+70, 0, 0);
        }

        private void directaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventaDirectaToolStripMenuItem_Click(sender, e);
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_de_Pedidos gestPedido = new Gestion_de_Pedidos();
            gestPedido._estado = estados.nuevo;
            gestPedido.ShowDialog();
        }

        private void informeDeStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            informeDeStockToolStripMenuItem_Click(sender, e);
        }

        private void btn_impresiones_Click(object sender, EventArgs e)
        {
            contextMenuStripImpresiones.Show();
            contextMenuStripImpresiones.SetBounds(((MouseEventArgs)e).Location.X + 33, ((MouseEventArgs)e).Location.Y+140, 0, 0);
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(helpProviderMenu.HelpNamespace);
        }

        private void gestiónDeMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gestMaquina == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                gestMaquina = new Consulta_Maquinaria();
                gestMaquina.MdiParent = this;
                gestMaquina.Show();
            }
            else
            {
                gestMaquina.BringToFront();
            }
        }

        private void informeDeVentasPorProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            informeDeVentasPorProductoToolStripMenuItem_Click(sender, e);
        }

        private void informeDeVentasPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emitir_Informe_de_Venta_por_Producto ventas = new Emitir_Informe_de_Venta_por_Producto();
            ventas.ShowDialog();
        }

        private void gestiónDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gestEmpleado == null)
            {
                btn_ventas.Visible = false;
                btn_impresiones.Visible = false;
                iniciador.cantVentanasAbiertas++;

                gestEmpleado = new Consulta_Empleado();
                gestEmpleado.MdiParent = this;
                gestEmpleado.Show();
            }
            else
            {
                gestEmpleado.BringToFront();
            }
        }

        private void informeDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emitir_Informe_de_Ventas infVentas = new Emitir_Informe_de_Ventas();
            infVentas.ShowDialog();
        }

        private void informeDeVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            informeDeVentasToolStripMenuItem_Click(sender, e);
        }

        private void informeOrdenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmitirInformeOrdenTrabajo infOrdenTrabajo = new EmitirInformeOrdenTrabajo();
            infOrdenTrabajo.ShowDialog();
        }

        private void informeOrdenesDeTrabajoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            informeOrdenesDeTrabajoToolStripMenuItem_Click(sender, e);
        }

        private void informeDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emitir_Informe_Productos infProd = new Emitir_Informe_Productos();

            infProd.ShowDialog();
        }

        private void informeDeProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            informeDeProductosToolStripMenuItem_Click(sender, e);
        }

        private void informeDeOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmitirInformeOrdenCompra infCompras = new EmitirInformeOrdenCompra();
            infCompras.ShowDialog();

        }

        private void informeDeOrdenesDeCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            informeDeOrdenesDeCompraToolStripMenuItem_Click(sender, e);
        }


        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_presupuesto presup = new Gestion_presupuesto();
            presup.ShowDialog();
        }


        private void informeDesviacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmitirInformeDesviacionesOrdenTrabajo infDesv = new EmitirInformeDesviacionesOrdenTrabajo();
            infDesv.ShowDialog();
        }

        private void informeDesviaciónDeOrdenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informeDesviacionToolStripMenuItem_Click(sender, e);
        }

        private void presupuestoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            presupuestoToolStripMenuItem_Click(sender, e);
        }



        

       
    }
}
