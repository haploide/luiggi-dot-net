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
     public class DetallePlanProduccionDAO
    {
         public static void Delete(int idPlan, SqlConnection con, SqlTransaction tran)
         {
             Acceso ac = new Acceso();


             deletePlanXPedido(idPlan,con,tran);

             string sql = "DELETE FROM DetallePlanProduccion WHERE (idPlan = @idp)";

             
             SqlCommand cmd = new SqlCommand(sql, con,tran);

             cmd.Parameters.AddWithValue("@idp", idPlan);

             try
             {
                 

                 
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
         public static void deletePlanXPedido(int idPlan, SqlConnection con, SqlTransaction tran)
         {
             string sql = "DELETE FROM PlanProduccionXPedido WHERE (idPlan = @idp)";
             SqlCommand cmd = new SqlCommand(sql, con,tran);
             cmd.Parameters.AddWithValue("@idp", idPlan);
             try
             {
                 cmd.CommandType = CommandType.Text;
                 cmd.ExecuteNonQuery();
             }
             catch (SqlException ex)
             {
                 throw new ApplicationException("Error en BD: " + ex.Message);
             }
         }
         public static void deletePlanXPedidoXidPedido(int idPedido, SqlConnection con, SqlTransaction tran)
         {
             string sql = "DELETE FROM PlanProduccionXPedido WHERE (idPedido = @idPedido)";
             SqlCommand cmd = new SqlCommand(sql, con, tran);
             cmd.Parameters.AddWithValue("@idPedido", idPedido);
             try
             {
                 cmd.CommandType = CommandType.Text;
                 cmd.ExecuteNonQuery();
             }
             catch (SqlException ex)
             {
                 throw new ApplicationException("Error en BD: " + ex.Message);
             }
         }
         public static void Insert(DetallePlanProduccion  det, SqlConnection cn, SqlTransaction tran, int idPlan)
         {
             Acceso ac = new Acceso();

                      
             SqlCommand cmd = new SqlCommand("sp_detalle_planProduccion_insert", cn, tran);

             cmd.Parameters.AddWithValue("@idPlan", idPlan);
             cmd.Parameters.AddWithValue("@fechaProduccion", det.fechaProduccion);
             cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto);
             cmd.Parameters.AddWithValue("@cantidadPlan", det.cantidadPLan);
             cmd.Parameters.AddWithValue("@cantidadPedido", det.cantidadPedido);

             try
             {
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.ExecuteNonQuery();
                 cmd.Dispose();

                 List<int> ids = obtenerPedidosRelacionadosConPlan(det.fechaProduccion, det.producto.idProducto, cn, tran);
                 foreach(int id in ids)
                 {
                     cmd = new SqlCommand("sp_PlanProduccionXPedido_insert", cn);

                     cmd.Parameters.AddWithValue("@idPedido", id);
                     cmd.Parameters.AddWithValue("@fechaProduccion", det.fechaProduccion);
                     cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto);
                     cmd.Parameters.AddWithValue("@idPlan", idPlan);

                     cmd.Connection = cn;
                     cmd.Transaction = tran;
                     cmd.CommandType = CommandType.StoredProcedure;
                     cmd.ExecuteNonQuery();
                 }


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
         public static List<DetallePlanProduccion > GetDetalleXPlan(int plan)
         {
             Acceso ac = new Acceso();

             List<DetallePlanProduccion> detalles = new List<DetallePlanProduccion>();

             string sql = "SELECT * from CONSULTA_DETALLE_PLAN_PRODUCCION where idPlan = @plan";
             SqlCommand cmd = new SqlCommand();
             cmd.Parameters.AddWithValue("@plan", plan );
             SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

             try
             {
                 conexion.Open();

                 cmd.Connection = conexion;
                 cmd.CommandText = sql;
                 cmd.CommandType = CommandType.Text;

                 SqlDataReader dr = cmd.ExecuteReader();

                 DetallePlanProduccion  d;
                 Producto p;
                 UnidadMedida u;
                 Categoria c;

                 while (dr.Read())
                 {

                     u = new UnidadMedida();

                     u.IDUnidad = Convert.ToInt32(dr["idUnidadMedida"]);
                     u.Nombre = dr["unidad"].ToString();

                     p = new Producto();

                     p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                     p.Nombre = dr["nombre"].ToString();
                     p.Unidad = u;
                     p.idProducto = Convert.ToInt16(dr["idProducto"]);

                     d = new DetallePlanProduccion ();

                     d.cantidadPLan = Convert.ToInt32(dr["cantidadPLan"]);
                     d.cantidadPedido = Convert.ToInt32(dr["cantidadPedido"]);
                     d.fechaProduccion = Convert.ToDateTime(dr["fechaProduccion"]);
                     d.producto = p;
                     

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
         public static List<int> obtenerPedidosRelacionadosConPlan(DateTime fechaNecesidad, int idProducto, SqlConnection cn, SqlTransaction tran)
         {
             string sql = "SELECT Pedido.idPedido";
             sql += " FROM Producto INNER JOIN";
             sql += " DetallePedido ON Producto.idProducto = DetallePedido.idProducto INNER JOIN";
             sql += " Pedido ON DetallePedido.idPedido = Pedido.idPedido";
             sql += " WHERE (Pedido.fechaNecesidad = @fecha) AND (DetallePedido.idProducto = @idProducto) AND (DetallePedido.reservado = 0)";

             SqlCommand cmd = new SqlCommand();
             cmd.Parameters.AddWithValue("@fecha", fechaNecesidad);
             cmd.Parameters.AddWithValue("@idProducto", idProducto);
             List<int> ids=new List<int>();

             try
             {
                 cmd.Connection = cn;
                 cmd.Transaction = tran;
                 cmd.CommandText = sql;
                 cmd.CommandType = CommandType.Text;
                 SqlDataReader dr = cmd.ExecuteReader();


                 while (dr.Read())
                 {
                     ids.Add(Convert.ToInt32(dr["idPedido"]));
                 }
                 dr.Close();

             }
             catch (SqlException ex)
             {
                 throw new ApplicationException("Error en BD: " + ex.Message);
             }

             return ids;
         }
         public static DataTable GetDetallePlanXProducto(int idProd, DateTime fecha, SqlConnection con, SqlTransaction tran)
         {
             DataTable detalles = new DataTable();
             string sql = "SELECT * from CONSULTA_DETALLE_PLAN_PRODUCCION where idproducto = @idProd and fechaproduccion = @fecha";
             SqlCommand cmd = new SqlCommand();
             cmd.Parameters.AddWithValue("@idProd", idProd);
             cmd.Parameters.AddWithValue("@fecha", fecha.Date);
             try
             {
                 cmd.Connection = con;
                 cmd.Transaction = tran;
                 cmd.CommandText = sql;
                 cmd.CommandType = CommandType.Text;
                 detalles.Load(cmd.ExecuteReader());

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
             }
             return detalles;
         }
         public static void ActualizarDetallePlan(int idProd, double cantidad, DateTime fecha, SqlConnection con, SqlTransaction trans)
         {
             Acceso ac = new Acceso();

             string sql = "UPDATE DetallePlanProduccion SET cantidadPedido = (cantidadPedido + @cantidad) where idProducto = @idProd and fechaProduccion = @fecha";
             SqlCommand cmd = new SqlCommand();
             cmd.Parameters.AddWithValue("@idProd", idProd);
             cmd.Parameters.AddWithValue("@cantidad", cantidad);
             cmd.Parameters.AddWithValue("@fecha", fecha.Date);
             try
             {
                 cmd.Connection = con;
                 cmd.Transaction = trans;
                 cmd.CommandText = sql;
                 cmd.CommandType = CommandType.Text;
                 cmd.ExecuteNonQuery();



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
                 
             }

         }
         public static void insertarPlanProduccionXPedido(int idPedido, int idProducto, int idPlan, DateTime fechaProduccion,SqlTransaction trans, SqlConnection con)
         {
             Acceso ac = new Acceso();
             SqlCommand cmd;
             cmd = new SqlCommand("sp_PlanProduccionXPedido_insert", con,trans);
             cmd.Parameters.AddWithValue("@idPedido", idPedido);
             cmd.Parameters.AddWithValue("@idProducto", idProducto);
             cmd.Parameters.AddWithValue("@idPlan", idPlan);
             cmd.Parameters.AddWithValue("@fechaProduccion", fechaProduccion);
             
             try
             {
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.ExecuteNonQuery();
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
                 
             }

         }
         public static DetallePlanProduccion GetDetallePlanXProductoParaOT(int idProd, DateTime fecha)
         {
             Acceso ac = new Acceso();

             DetallePlanProduccion d;

             string sql = "SELECT * from CONSULTA_DETALLE_PLAN_PRODUCCION where idproducto = @idProd and fechaproduccion = @fecha";
             SqlCommand cmd = new SqlCommand();
             cmd.Parameters.AddWithValue("@idProd", idProd);
             cmd.Parameters.AddWithValue("@fecha", fecha);
             SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

             try
             {
                 conexion.Open();

                 cmd.Connection = conexion;
                 cmd.CommandText = sql;
                 cmd.CommandType = CommandType.Text;

                 SqlDataReader dr = cmd.ExecuteReader();
                
                
                 Producto p;



                     dr.Read();
                  
                     p = new Producto();
                     p.Nombre = dr["nombre"].ToString();
                     p.idProducto = Convert.ToInt16(dr["idProducto"]);

                     d = new DetallePlanProduccion();
                     d.idPlan = Convert.ToInt32(dr["idPlan"]);
                     d.cantidadPLan = Convert.ToInt32(dr["cantidadPLan"]);
                     d.cantidadPedido = Convert.ToInt32(dr["cantidadPedido"]);
                     d.fechaProduccion = Convert.ToDateTime(dr["fechaProduccion"]);
                     d.producto = p;


                    


                 
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


             return d;

         }
         public static Double GetCantidadPedidosParaOT(int idProd, DateTime fecha)
         {
             Acceso ac = new Acceso();

             double result = 0;

             string sql = "SELECT DetallePlanProduccion.cantidadPedido AS cantidad ";
             sql += " FROM DetallePlanProduccion INNER JOIN Producto ON DetallePlanProduccion.idProducto = Producto.idProducto INNER JOIN UnidadMedida ON Producto.idUnidadMedida = UnidadMedida.idUnidad ";
             sql += " WHERE (DetallePlanProduccion.fechaProduccion = @fecha) AND (DetallePlanProduccion.idProducto = @idProd) ";
             SqlCommand cmd = new SqlCommand();
             cmd.Parameters.AddWithValue("@idProd", idProd);
             cmd.Parameters.AddWithValue("@fecha", fecha);
             SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

             try
             {
                 conexion.Open();

                 cmd.Connection = conexion;
                 cmd.CommandText = sql;
                 cmd.CommandType = CommandType.Text;

                 SqlDataReader dr = cmd.ExecuteReader();



                 dr.Read();


                 result = Convert.ToDouble(dr["cantidad"]);

             }
             catch (SqlException ex)
             {
                 throw new ApplicationException("Error en BD: " + ex.Message);
             }
             finally
             {
                 conexion.Close();
             }


             return result;

         }
    }
}
