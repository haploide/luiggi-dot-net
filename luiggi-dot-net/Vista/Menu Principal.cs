﻿using System;
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

            if (Seguridad.usuario != null)
            {
                statusStrip.Items["usuario"].Text = "Usuario: "+Seguridad.usuario.Nombre;
            }

            toolTip.SetToolTip(btn_pedido, "Nuevo Pedido");
            toolTip.SetToolTip(btn_ventas, "Venta Directa");
            

        }

        private void gestionProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("gestion producto"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Consultas_Producto consProd = Consultas_Producto.Instance();
                consProd.MdiParent = this;
                consProd.Show();
            
            
        }

        private void gestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("Gestion Cliente"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Consultas_Cliente consCli = Consultas_Cliente.Instance();
                consCli.MdiParent = this;
                consCli.Show();
            
                       
        }

        private void gestionDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!Seguridad.GetAutorizacion("Gestion pedido"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Consulta_de_Pedidos consPed =Consulta_de_Pedidos.Instance();
                consPed.MdiParent = this;
                consPed.Show();
            
        }

        private void gestionDeEstructuraDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("gestion estructura"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Gestionar_Estructura_Productos Estr = Gestionar_Estructura_Productos.Instance();
                Estr.MdiParent = this;
                Estr.Show();
            
        }

        private void gestionDePlanesDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("gestion plan produccion"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            } 
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Consulta_Planes_Produccion planes = Consulta_Planes_Produccion.Instance();
                planes.MdiParent = this;
                planes.Show();
            
        }

        private void gestionDeOrdenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("gestion orden trabajo"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                ConsultarOrdenTrabajo Ordenes = ConsultarOrdenTrabajo.Instance();
                Ordenes.MdiParent = this;
                Ordenes.Show();
            
            
        }

        private void gestionDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("gestion proveedor"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Consulta_Proveedor consProv = Consulta_Proveedor.Instance();
                consProv.MdiParent = this;
                consProv.Show();
            
        }

        private void gestionProductoPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("Gestion Producctos por Proveedor"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Gestion_Producto_X_Proveedor consProdProv = Gestion_Producto_X_Proveedor.Instance();
                consProdProv.MdiParent = this;
                consProdProv.Show();
            
        }

        private void gestionarComprasDeMateriaPrimaEInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("gestion compra"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Consultar_Orden_de_Compra consOrCom = Consultar_Orden_de_Compra.Instance();
                consOrCom.MdiParent = this;
                consOrCom.Show();
            
        }

        private void registrarCobroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("gestion cobro"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Gestion_de_Facturas facturas = Gestion_de_Facturas.Instance();
                facturas.MdiParent = this;
                facturas.Show();
            


        }

        private void gestionDePagoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("gestion pago"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Gestion_de_Pago_a_Proveedores ordenesCompra = Gestion_de_Pago_a_Proveedores.Instance();
                ordenesCompra.MdiParent = this;
                ordenesCompra.Show();
            
        }

        private void informeDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("informe compra"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            Emitir_Informe_de_Stock stock = new Emitir_Informe_de_Stock();
            stock.ShowDialog();

        }

        private void ventaDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("Venta Directa"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
                return;
            }

            Gestion_Venta_Directa ventaDirecta = new Gestion_Venta_Directa();
            ventaDirecta.ShowDialog();
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventaDirectaToolStripMenuItem_Click(sender, e);
        }

        private void directaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
            try
            {
                System.Diagnostics.Process.Start(helpProviderMenu.HelpNamespace);
            }
            catch (Win32Exception ex)
            {
                
                MessageBox.Show("No se encontro archivo de ayuda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            }
        }

        private void gestiónDeMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("gestion maquinaria"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Consulta_Maquinaria gestMaquina = Consulta_Maquinaria.Instance();
                gestMaquina.MdiParent = this;
                gestMaquina.Show();
            
        }

        private void informeDeVentasPorProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            informeDeVentasPorProductoToolStripMenuItem_Click(sender, e);
        }

        private void informeDeVentasPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("informe venta"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            Emitir_Informe_de_Venta_por_Producto ventas = new Emitir_Informe_de_Venta_por_Producto();
            ventas.ShowDialog();
        }

        private void gestiónDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("gestion empleado"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
                //btn_ventas.Visible = false;
                //btn_impresiones.Visible = false;
                //btn_pedido.Visible = false;
                //iniciador.cantVentanasAbiertas++;

                Consulta_Empleado gestEmpleado = Consulta_Empleado.Instance();
                gestEmpleado.MdiParent = this;
                gestEmpleado.Show();
            
        }

        private void informeDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("informe venta"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            Emitir_Informe_de_Ventas infVentas = new Emitir_Informe_de_Ventas();
            infVentas.ShowDialog();
        }

        private void informeDeVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            informeDeVentasToolStripMenuItem_Click(sender, e);
        }

        private void informeOrdenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("informe produccion"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
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
            if (!Seguridad.GetAutorizacion("informe compra"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            EmitirInformeOrdenCompra infCompras = new EmitirInformeOrdenCompra();
            infCompras.ShowDialog();

        }

        private void informeDeOrdenesDeCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            informeDeOrdenesDeCompraToolStripMenuItem_Click(sender, e);
        }


        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("Presupuesto"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            Gestion_presupuesto presup = new Gestion_presupuesto();
            presup.ShowDialog();
        }


        private void informeDesviacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("informe produccion"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
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

        private void listadosEInformesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("informe Venta"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void listadosEInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            if (!Seguridad.GetAutorizacion("Gestion pedido"))
            {
                MessageBox.Show("No está autorizado a visualizar este formulario", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            Gestion_de_Pedidos gestPedido = new Gestion_de_Pedidos();
            gestPedido._estado = estados.nuevo;
            gestPedido.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }
            Seguridad.usuario = null;
            Inicio_Sesion login = new Inicio_Sesion();
            if (Seguridad.usuario == null)
            {
                statusStrip.Items["usuario"].Text = "Usuario: " ;
            }
            login.ShowDialog(this);
            if (Seguridad.usuario != null)
            {
                statusStrip.Items["usuario"].Text = "Usuario: " + Seguridad.usuario.Nombre;
            }
           
        }

        private void informeDeProductosPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informeDeProductosPorProveedorToolStripMenuItem1_Click(sender, e);
        }

        private void informeDeProductosPorProveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmitirInformeProductoXProveedor infProdProv = new EmitirInformeProductoXProveedor();
            infProdProv.ShowDialog();
        }
      
    }
}
