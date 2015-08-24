using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;

namespace Controlador
{
   public  class GestorConsultaPedido
    {
       public List<Estado > buscarEstado()
       {
           try
           {
               return EstadoDAO.GetAllPedidos ();
           }
           catch (ApplicationException ex)
           {
               throw new ApplicationException(ex.Message);
           }

       }
       public List<TipoDocumento> buscarTipoDoc()
       {
           return TipoDocumentoDAO.GetAll();
       }
       public static List<Pedido> buscarPedidosFiltrados(int est, int tipDoc, int? nroDoc, double? montoDesde, double? mostoHasta, string nom, string ape, string raSoc, int? cuit, DateTime? fdesde, DateTime? fhasta)
       {
           try
           {
               return PedidoDAO.GetByFiltros(est, tipDoc, nroDoc, montoDesde, mostoHasta, nom, ape, raSoc, cuit, fdesde, fhasta);
           }
           catch (ApplicationException ex)
           {
               throw new ApplicationException(ex.Message);
           }

       }
       public static List<Pedido > buscarPedidos()
       {
           try
           {
               return PedidoDAO.GetAll();
           }
           catch (ApplicationException ex)
           {
               throw new ApplicationException(ex.Message);
           }

       }
       public static List<DetallePedido > buscarDetallePedido(int ped)
       {
           
           try
           {
               return DetallePedidoDAO.GetDetalleXPedido(ped);
           }
           catch (ApplicationException ex)
           {
               throw new ApplicationException(ex.Message);
           }

       }

    }
}
