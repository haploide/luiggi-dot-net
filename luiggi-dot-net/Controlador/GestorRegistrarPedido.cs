using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;


namespace Controlador
{
    
    public class GestorRegistrarPedido
    {

        private Persona cliente;
        private DateTime necesidad;
        private List<DetallePedido> detalle;
        private DateTime fechaPedido;
        private int numeroPedido;
        private int idPedido;
        private string direEntrega;
        private int idEstado;


        public void nuevoProducto()
        {
            cliente=null;
            necesidad=DateTime.Now;
            detalle=null;
            fechaPedido = DateTime.Now;
            numeroPedido=0;
            direEntrega = "";
        }
        public List<Producto> buscarProductosFinales()
        {
            return ProductoDAO.GetPeductosFinales();

         }
        public Persona buscarClientePersona(int idT , int nro )
        {

            return PersonaDAO.GetClientePersona( idT,  nro);
          
        }
        public List<TipoDocumento> buscarTipoDoc()
        {
            return TipoDocumentoDAO.GetAll();
        }
        public Persona buscarClienteEmpresa(int cuit)
        {

            return PersonaDAO.GetClienteEmpresa(cuit);

        }
        public void clienteSeleccionado(Persona per)
        {

            cliente = per;
        }
        public void fechaDeNecesidadTomada(DateTime fecha)
        {
            necesidad = fecha;
        }
        public void dirEntregaTomada(string dir)
        {
            direEntrega = dir;
        }
        public void estado(int idest)
        {
            idEstado = idest;
        }
        public void tomarProductosSeleccionados(List<DetallePedido> productos)
        {
            detalle = productos;
        }
        public int confirmacionTomada(List<Producto> productosConPocaMP)
        {
            tomarFechaYHoraActual();
            try
            {
                return crearPedido(productosConPocaMP);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public void modificacionConfirmada(List<DetallePedido> tablaAModificar, List<Producto> productosConPocaMP)
        {
            try
            {
                modificarPedido(tablaAModificar, productosConPocaMP);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public void tomarFechaYHoraActual()
        {
            fechaPedido = DateTime.Now.Date;
        }
        public int crearPedido(List<Producto> productosConPocaMP)
        {
            numeroPedido = buscarUltimoNroPedido();

            Estado esta=new Estado()
            {
                idEstado=idEstado,
            };
            Pedido ped = new Pedido()
            {
                cliente=cliente,
                detallePedido = detalle,
                fechaNecesidad = necesidad,
                fechaPedido = fechaPedido,
                nroPedido = numeroPedido,
                estado=esta,
                dirEntraga=direEntrega
                
                                 
            };
            try
            {
                return PedidoDAO.Insert(ped, productosConPocaMP);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public void modificarPedido(List<DetallePedido> tablaAModificar, List<Producto> productosConPocaMP)
        {
            Pedido ped = new Pedido();

            ped.idPedido = idPedido;
            ped.fechaNecesidad = necesidad;
            ped.detallePedido = detalle;
            ped.dirEntraga = direEntrega;
            ped.estado = new Estado() { idEstado = idEstado };
            try
            {
                PedidoDAO.Update(ped, tablaAModificar, productosConPocaMP);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            
        }
        public int buscarUltimoNroPedido()
        {
            return SingletonNumeroPedidoDAO.GetInstacia().getNumeroPedido();
        }
        public void pedidoModificar(int id)
        {
            idPedido = id;
        }
        public Pedido buscarPedido()
        {
            return PedidoDAO.GetById(idPedido);
        }
    }
}
