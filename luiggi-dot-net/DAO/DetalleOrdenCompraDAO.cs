using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DAO
{
    public  class DetalleOrdenCompraDAO
    {
        public static void UpdateCantidadIngresadaReal(DetalleOrdenCompra  det, int idOrden, SqlConnection con, SqlTransaction tran)
        {
            Acceso ac = new Acceso();
                    
            string sql =("UPDATE [Luiggi].[dbo].[DetalleOrdenCompra] SET [cantidadRealIngresada] = @cantidadRealIngresada, [subtotal] = @cantidadRealIngresada * @precio   WHERE idProducto = @idProducto and idOrdenCompra = @idOrdenCompra");
            SqlCommand cmd = new SqlCommand(sql, con, tran);

            cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto);
            cmd.Parameters.AddWithValue("@cantidadRealIngresada", det.cantidadRealIngresada );
            cmd.Parameters.AddWithValue("@idOrdenCompra", idOrden);
            cmd.Parameters.AddWithValue("@precio", det.precio);

            try
            {
               

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                ProductoDAO.UpdateStockActualYDisponibleInsumosYMPIngresadas(det, con,tran);

            }
            catch (ArgumentException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
               
            }
        }
        public static List<DetalleOrdenCompra > GetDetalleXOrdenDeCompra(int oc)
        {
            Acceso ac = new Acceso();

            List<DetalleOrdenCompra> detalles = new List<DetalleOrdenCompra>();

            string sql = "SELECT * from CONSULTAR_DETALLE_ORDEN_COMPRA where idOrdenCompra = @oc";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@oc", oc);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                DetalleOrdenCompra d;
                Producto p;
                UnidadMedida u;
                OrdenDeCompra o;

                while (dr.Read())
                {
                    o = new OrdenDeCompra();
                    o.idOrdenCompra = Convert.ToInt32(dr["idOrdenCompra"]);

                   
                    u = new UnidadMedida();

                    u.IDUnidad = Convert.ToInt32(dr["idUnidadMedida"]);
                    u.Nombre = dr["Unidad"].ToString();

                    p = new Producto();

                    
                    p.Nombre = dr["nombre"].ToString();
                    p.Unidad = u;
                    p.idProducto = Convert.ToInt16(dr["idProducto"]);
                    p.StockDisponible = Convert.ToDouble(dr["stockDisponible"]);
                    p.StockRiesgo = Convert.ToDouble(dr["stockdeRiesgo"]);
                    p.StockActual = Convert.ToDouble(dr["stockactual"]);
                    p.StockReservado = Convert.ToDouble(dr["stockreservado"]);

                    d = new DetalleOrdenCompra();

                    d.cantidad = Convert.ToDouble(dr["cantidad"]);
                    d.producto = p;
                    d.precio = Convert.ToDouble(dr["precio"]);
                    d.subTotal = Convert.ToDouble(dr["subTotal"]);
                    d.cantidadRealIngresada = Convert.ToDouble(dr["cantidadRealIngresada"]);
                    d.ordenCompra = o;

                    detalles.Add(d);


                }

            }
            catch (InvalidOperationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }


            return detalles;

        }
        public static void Insert(DetalleOrdenCompra  det, SqlConnection cn, SqlTransaction tran, int idOrden)
        {
            Acceso ac = new Acceso();


            //SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_insertar_detalle_orden_compra", cn);

            cmd.Parameters.AddWithValue("@idOrdenCompra", idOrden);
            cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto);
            cmd.Parameters.AddWithValue("@cantidad", det.cantidad);
            cmd.Parameters.AddWithValue("@precio", det.precio);
            cmd.Parameters.AddWithValue("@subtotal", det.subTotal );
           

            try
            {
                cmd.Connection = cn;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();


            }
            catch (ArgumentException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD: " + ex.Message);
            }

        }
    }
}
