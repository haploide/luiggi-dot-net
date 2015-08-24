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
    public  class DetallePedidoDAO
    {
        public static void finalizarDetalleDePedido(DateTime fecha, int idProd, SqlTransaction tran, SqlConnection con)
        {
            Acceso ac = new Acceso();

          
           

            string sql = "UPDATE [Luiggi].[dbo].[DetallePedido] SET [idEstado] = 4 WHERE idProducto = @idProd and idPedido in";
            sql += " (select idPedido from pedido where fechaNecesidad = @fecha)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idProd", idProd );
            cmd.Parameters.AddWithValue("@fecha", fecha);

            try
            {
               
               
                cmd.Connection = con;
                cmd.Transaction = tran;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                sql = "UPDATE Pedido SET [idEstado] = 2 where fechaNecesidad = @fecha and idPedido in";
                sql += " (select idPedido from DetallePedido WHERE idProducto = @idProd)";

                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                
            }
            catch (ArgumentException ex)
            {
                
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            catch (SqlException ex)
            {
                
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
               
            }
        }
        public static List<DetallePedido> getCantidadPedidaxProducto(DateTime fecha)
        {
            Acceso ac = new Acceso();
            List<DetallePedido> detalles = new List<DetallePedido>();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_buscar_cantidad_pedido_fecha");

            cmd.Parameters.AddWithValue("@fecha", fecha);

             try
            {
                conexion.Open();

                cmd.Connection = conexion;
             
                cmd.CommandType = CommandType.StoredProcedure ;

                SqlDataReader dr = cmd.ExecuteReader();
                
                DetallePedido d;
                Producto  p;
                UnidadMedida u;
                
                while (dr.Read())
                {
                  
                    

                    u = new UnidadMedida ();
                                     
                    u.Nombre = dr["Unidad"].ToString();

                    p = new Producto();

                 
                    p.Nombre = dr["nombre"].ToString();
                    p.Unidad = u;
                    p.idProducto = Convert.ToInt16(dr["idProducto"]);

                    d = new DetallePedido ();

                    d.cantidad = Convert.ToInt32(dr["cantidad"]);
                    d.producto  = p;
                  

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


            return detalles ;

        }
        public static void Delete(int idPedido, SqlConnection con, SqlTransaction tran)
        {
            Acceso ac = new Acceso();
            string sql = "DELETE FROM DetallePedido WHERE (idPedido = @idp)";
            SqlCommand cmd = new SqlCommand(sql, con,tran);
            cmd.Parameters.AddWithValue("@idp", idPedido );

            try
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
            }
        }
        public static void Insert(DetallePedido det, SqlConnection cn, SqlTransaction tran, int idPed)
        {
            Acceso ac = new Acceso();


            //SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_detalle_pedido_insert", cn);

            cmd.Parameters.AddWithValue("@idPedido", idPed);
            cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto );
            cmd.Parameters.AddWithValue("@cantidad", det.cantidad );
            cmd.Parameters.AddWithValue("@precio", det.precio );
            cmd.Parameters.AddWithValue("@cantidadReservada", det.cantidadReservada );
            cmd.Parameters.AddWithValue("@Estado", det.Estado.idEstado );
            cmd.Parameters.AddWithValue("@reservado", det.reservado );

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
        public static List<DetallePedido > GetDetalleXPedido(int ped)
        {
            Acceso ac = new Acceso();

            List<DetallePedido> detalles = new List<DetallePedido>();

            string sql = "SELECT * from CONSULTA_DETALLE_PEDIDO where idPedido = @ped";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@ped", ped);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                
                DetallePedido d;
                Producto  p;
                UnidadMedida u;
                Estado e;
                
                while (dr.Read())
                {


                    e = new Estado();
                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    u = new UnidadMedida ();

                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["UnidadMedida"].ToString();

                    p = new Producto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["nombre"].ToString();
                    p.Unidad = u;
                    p.idProducto = Convert.ToInt16(dr["idProducto"]);

                    d = new DetallePedido ();

                    d.cantidad = Convert.ToDouble(dr["cantidad"]);
                    d.producto  = p;
                    d.precio = Convert.ToDouble(dr["precio"]);
                    d.subTotal = Convert.ToDouble(dr["subTotal"]);
                    d.reservado = Convert.ToBoolean(dr["reservado"]);
                    d.Estado = e;
                   
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


            return detalles ;

        }
    }
}
