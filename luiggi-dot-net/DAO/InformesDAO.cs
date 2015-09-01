using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace DAO
{
    public class InformesDAO
    {
        public static DataTable GetInformeVentasProducto(DateTime desde, DateTime hasta)
        {

            Acceso ac = new Acceso();

            DataTable result = new DataTable();

            
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand("sp_Emitir_Informe_Venta_Producto", conexion);

            cmd.Parameters.AddWithValue("@fechaDesde", desde);
            cmd.Parameters.AddWithValue("@fechaHasta", hasta);

            try
            {
                conexion.Open();

                
                cmd.CommandType = CommandType.StoredProcedure;

                result.Load(cmd.ExecuteReader());

            }
            catch (InvalidOperationException ex)
            {

                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD:" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return result;
        }
        public static DataTable GetInformeVentas(DateTime desde, DateTime hasta)
        {

            Acceso ac = new Acceso();

            DataTable result = new DataTable();


            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand("sp_Emitir_Informe_Venta_Periodo_Mensual", conexion);

            cmd.Parameters.AddWithValue("@fechaDesde", desde);
            cmd.Parameters.AddWithValue("@fechaHasta", hasta);

            try
            {
                conexion.Open();


                cmd.CommandType = CommandType.StoredProcedure;

                result.Load(cmd.ExecuteReader());

            }
            catch (InvalidOperationException ex)
            {

                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD:" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return result;
        }
        public static DataTable GetInformeProductos()
        {
            Acceso ac = new Acceso();

            DataTable result = new DataTable();


            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand();

            String sql = "SELECT Producto.idProducto, Producto.nombre, Producto.descripcion, UnidadMedida.nombre AS unidad, Producto.precio, Producto.foto ";
            sql += " FROM Producto INNER JOIN UnidadMedida ON Producto.idUnidadMedida = UnidadMedida.idUnidad INNER JOIN Categoria ON Producto.idCategoria = Categoria.idCategoria";
            sql += " WHERE (Producto.idCategoria = 1)";

            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                result.Load(cmd.ExecuteReader());

            }
            catch (InvalidOperationException ex)
            {

                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD:" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return result;
        }
        public static DataTable GetInformeOrdenesCompra(DateTime? desde, DateTime? hasta)
        {
            Acceso ac = new Acceso();

            DataTable result = new DataTable();


            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand();

            

            String sql = " SELECT idOrden, fechaOrden, idProveedor, razonSocial, cantidad, cantidadRealIngresada, nombre, unidad, @fechaDesde as desde, @fechaHasta as hasta";
            sql += " FROM EMITIR_INFORME_ORDEN_DE_COMPRA WHERE 1=1";

            if (desde != null)
            {
                sql += " and fechaOrden between @fechaDesde and @fechaHasta";
                cmd.Parameters.AddWithValue("@fechaDesde", desde);
                cmd.Parameters.AddWithValue("@fechaHasta", hasta);

            }
            else
            {
                cmd.Parameters.AddWithValue("@fechaDesde", "01/01/1900");
                cmd.Parameters.AddWithValue("@fechaHasta", "01/01/1900");
            }
            
            
    

            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                result.Load(cmd.ExecuteReader());

            }
            catch (InvalidOperationException ex)
            {

                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD:" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return result;
        }
        public static DataTable GetInformeDesviacionOrdenesTrabajo(int año)
        {
            Acceso ac = new Acceso();

            DataTable result = new DataTable();


            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand();



            String sql = " SELECT o.idProducto, p.nombre, MONTH(o.fechaCreacion) AS mes, SUM(o.cantidad) AS \"CantidadPlanificada\", SUM(o.cantidadProducidaReal) AS \"CantidadProducida\", @año as año ";
            sql += " FROM OrdenTrabajo AS o INNER JOIN Producto AS p ON o.idProducto = p.idProducto";
            sql += " WHERE (YEAR(o.fechaCreacion) = @año)";
            sql += " GROUP BY o.idProducto, MONTH(o.fechaCreacion), p.nombre";

            cmd.Parameters.AddWithValue("@año",año);
                 

            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                result.Load(cmd.ExecuteReader());

            }
            catch (InvalidOperationException ex)
            {

                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD:" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return result;
        }

    }
}
