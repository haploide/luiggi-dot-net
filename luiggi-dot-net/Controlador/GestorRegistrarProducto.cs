using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;

namespace Controlador
{
    public class GestorRegistrarProducto
    {
        private string nombreProducto;
        private int stockRiesgo;
        private double precio;
        private double precioMayorista;
        private double tiempo;
        private string descripcion;
        private int codProducto;
        private double cantProductos;
        private TipoMaquinaria  maquina;
        private Categoria categoria;
        private UnidadMedida unidad;
        private UnidadMedida unidadTiempo;
        private int codigo;
        private Byte[] foto;
        public void registroConfirmado()
        {
            try
            {
                crearProducto();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            
        }
        public void crearProducto()
        {
            buscarUltimoCodigo();
            Producto prod = new Producto()
            {
                CODProducto = codProducto,
                Nombre = nombreProducto,
                Categoria = categoria,
                Descripcion = descripcion,
                Unidad = unidad,
                StockRiesgo = stockRiesgo,
                precio = precio,
                precioMayorista= precioMayorista,
                tipoMaquina = maquina,
                tiempoProduccion = tiempo,
                foto = foto,
                UnidadTiempo = unidadTiempo,
                cantidadProductos = cantProductos 
            };
            try
            {
                ProductoDAO.Insert(prod);
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
                modificarProducto();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public void modificarProducto()
        {
            Producto prod = new Producto()
            {
                CODProducto = codigo,
                Nombre = nombreProducto,
                Categoria = categoria,
                Descripcion = descripcion,
                Unidad = unidad,
                StockRiesgo = stockRiesgo,
                precio = precio,
                precioMayorista = precioMayorista,
                tipoMaquina = maquina,
                tiempoProduccion = tiempo,
                foto = foto,
                UnidadTiempo = unidadTiempo,
                cantidadProductos = cantProductos 

            };
            try
            {
                ProductoDAO.Update(prod);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public void codigoTomado(int codi)
        {
            codigo = codi;
        }
        public void buscarUltimoCodigo()
        {
            codProducto = SingletonCodigoProductoDAO.GetInstacia().getCodigoProducto();
        }
        public void nuevoProducto()
        {
            nombreProducto="";
            stockRiesgo=0;
            precio=0;
            descripcion="";
            categoria=null;
            unidad=null;
            codProducto = 0;
            precioMayorista = 0;
            unidadTiempo = null;
            tiempo = 0;
            cantProductos = 0;
            

        }
        public void nombreProductoTomado(string nombre)
        {
            nombreProducto = nombre;
        }
        public void datosProductoTomado(string nombre, int stockr, double prec, string desc, Byte[] fo, double preM, double tiem, double cantidadProductos)
        {
            nombreProducto = nombre;
            stockRiesgo = stockr;
            precio = prec;
            descripcion = desc;
            foto = fo;
            precioMayorista = preM;
            tiempo = tiem;
            cantProductos = cantidadProductos;
           
        }
        public void categoriaSeleccionada(Categoria cat)
        {
            categoria = cat;
        }
        public void tipoMaquinariaSeleccionada(TipoMaquinaria  tm)
        {
            maquina  = tm;
        }
        public void UnidadTiempoSeleccionada(UnidadMedida  ut)
        {
            unidadTiempo  = ut;
        }
        
        public void unidadSeleccionada(UnidadMedida uni)
        {
            unidad = uni;
        }
        
        public Boolean verificarExistenciaProducto()
        {
            Boolean resul = false;
            try
            {
                List<Producto> productos = ProductoDAO.GetAll();

                foreach (Producto prod in productos)
                {
                    if (prod.Nombre.Equals(nombreProducto))
                    {
                        resul = true;
                    }
                }
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            

            return resul;
        }
        public List<Categoria> buscarCategorias()
        {
            return CategoriaDAO.GetAll();
        }
        public List<UnidadMedida> buscarUnidadDeMedida()
        {
            return UnidadMedidaDAO.GetAll();
        }
        public List<UnidadMedida> buscarUnidadDeTiempo()
        {
            return UnidadMedidaDAO.GetTiempo();
        }
    }
}
