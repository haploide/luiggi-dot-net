using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;

namespace Controlador
{
    public class GestorEstructuraProducto
    {
        int idProductoPadre = 0;
        int idProductoHijo = 0;
        double cantidad = 0;
        List<DetalleProducto> detalle = new List<DetalleProducto>();
        public static List<Producto> buscarProductos()
        {
            try
            {
                return EstructuraProductoDAO.GetAll();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static List<Producto> buscarProductosAAgregar()
        {
            try
            {
                return EstructuraProductoDAO.GetAllProdAAgregar();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static List<DetalleProducto> buscarProductosDetalle(int id)
        {
            try
            {
                return EstructuraProductoDAO.GetAll(id);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static List<Producto> buscarProductosSinEstructura()
        {
            try
            {
                return EstructuraProductoDAO.GetAllSinEstructura();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static List<Producto> buscarProductosConEstructura()
        {
            try
            {
                return EstructuraProductoDAO.GetAllConEstructura();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }

        public void tomarDetalleProductos(List<DetalleProducto> detalleProducto)
        {
            detalle = detalleProducto;
        }
        public void tomarIdProductoPadre(int ProductoPadre)
        {
            idProductoPadre = ProductoPadre;
        }
        public void nuevaEstructura()
        {
            
            try
            {
                EstructuraProductoDAO.Insert(detalle);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public void modificacionConfirmada()
        {
            try
            {
                modificarEstructura();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public void eliminacionConfirmada()
        {
            try
            {
                eliminarEstructura();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public void modificarEstructura()
        {
            List<DetalleProducto> detProducto = new List<DetalleProducto>();
            detProducto = detalle;
            try
            {
                EstructuraProductoDAO.Update(detProducto, idProductoPadre);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }

        public void eliminarEstructura()
        {
            
            try
            {
                EstructuraProductoDAO.Delete(idProductoPadre);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
    }
}
