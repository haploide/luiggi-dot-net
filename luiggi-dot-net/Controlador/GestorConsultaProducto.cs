using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;

namespace Controlador
{
    public class GestorConsultaProducto
    {
        private int codigoProducto;

        public static List<Producto> buscarProductos() 
        {
            try
            {
                return ProductoDAO.GetAll();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            
        }
        public static List<Producto> buscarProductosFiltrados(int cat, int uni, double? desde, double? hasta )
        {
            try
            {
                return ProductoDAO.GetByFiltros(cat, uni, desde , hasta );
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public List<Categoria> buscarCategorias()
        {
            try
            {
                return CategoriaDAO.GetAll();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            
        }
        public List<UnidadMedida> buscarUnidadDeMedida()
        {
            try
            {
                return UnidadMedidaDAO.GetAll();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            
        }
        public void codigoProductoTomado(int codigo)
        {
            codigoProducto = codigo;
        }
        public void eliminacionConfirmada()
        {
            try
            {
                ProductoDAO.Delete(codigoProducto);
            }
            catch(ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
