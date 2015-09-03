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
    public class OrdenDeTrabajoDAO
    {
        public static void Update(OrdenDeTrabajo ot, SqlConnection cn, SqlTransaction trans)
        {
            Acceso ac = new Acceso();
            

            string sql="UPDATE [Luiggi].[dbo].[OrdenTrabajo] SET [idOTPadre] = @idPadre WHERE fechaCreacion = @fechaCreacion and idPlan = @idPlan  and idProducto =  @idProducto and idProdIntermedio is Not Null";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idPadre", ot.idOrdenTrabajo);
            cmd.Parameters.AddWithValue("@fechaCreacion", ot.fechaCreacion );
            cmd.Parameters.AddWithValue("@idPlan", ot.idPlan );
            cmd.Parameters.AddWithValue("@idProducto", ot.producto.idProducto );



            try
            {
                cmd.Connection = cn;
                cmd.Transaction = trans;
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
            
        }
        public static void finalizarOTPadre(OrdenDeTrabajo ot, double canPed, double canPlan, List<DetalleProducto> tabla )
        {
            Acceso ac = new Acceso();

            SqlConnection cn = new SqlConnection(ac.getCadenaConexion());
            SqlTransaction tran=null;

            string sql = "UPDATE [Luiggi].[dbo].[OrdenTrabajo] SET [idEstado] = 20, [cantidadProducidaReal]= @cantreal, [observaciones] = @observaciones WHERE idOrdenTrabajo =  @idOrdenTrabajo ";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idOrdenTrabajo", ot.idOrdenTrabajo);
            cmd.Parameters.AddWithValue("@cantreal", ot.cantidadReal);
            cmd.Parameters.AddWithValue("@observaciones", ot.observaciones );

            try
            {
                cn.Open();
                tran = cn.BeginTransaction();
                cmd.Connection = cn;
                cmd.Transaction = tran;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                ProductoDAO.UpdateStockReservadoYDisponibleOTFinalizada(ot.producto.idProducto, canPlan, canPed, cn, tran);

                foreach (DetalleProducto det in tabla)
                {
                    ProductoDAO.UpdateStockReservadoYDisponibleMatiaPrimaOTfinalizada(det.idProducto, det.cantidad, det.cantidadProductos, cn, tran);
                }
                
                DetallePedidoDAO.finalizarDetalleDePedido(ot.fechaCreacion, ot.producto.idProducto, tran, cn);

                tran.Commit();

            }
            catch (ArgumentException ex)
            {
                tran.Rollback();
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public static void finalizarOTHija(OrdenDeTrabajo ot, List<DetalleProducto> tabla)
        {
            Acceso ac = new Acceso();

            SqlConnection cn = new SqlConnection(ac.getCadenaConexion());
            SqlTransaction tran = null;

            string sql = "UPDATE [Luiggi].[dbo].[OrdenTrabajo] SET [idEstado] = 20, [cantidadProducidaReal]= @cantreal, [observaciones] = @observaciones WHERE idOrdenTrabajo =  @idOrdenTrabajo ";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idOrdenTrabajo", ot.idOrdenTrabajo);
            cmd.Parameters.AddWithValue("@cantreal",ot.cantidadReal);
            cmd.Parameters.AddWithValue("@observaciones", ot.observaciones);

            try
            {
                cn.Open();
                tran = cn.BeginTransaction();
                cmd.Connection = cn;
                cmd.Transaction = tran;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //ACTUALIZAR EL STOCK DE PROD INTERMEDIOS
                if (ot.cantidad >= ot.cantidadReal)
                {
                    sql = "Update Producto set stockActual = stockActual + @cantreal, stockReservado = stockReservado + @cantreal where idProducto = @idProducto";
                    cmd.CommandText = sql;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idProducto", ot.producto.idProducto);
                    cmd.Parameters.AddWithValue("@cantreal", ot.cantidadReal);
                    cmd.ExecuteNonQuery();
                }
                if (ot.cantidad < ot.cantidadReal)
                {
                    sql = "Update Producto set stockActual = stockActual + @cantreal, stockReservado = stockReservado + @cant, stockDisponible = stockDisponible + @cantreal - @cant where idProducto = @idProducto";
                    cmd.CommandText = sql;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idProducto", ot.producto.idProducto);
                    cmd.Parameters.AddWithValue("@cantreal", ot.cantidadReal);
                    cmd.Parameters.AddWithValue("@cant", ot.cantidad);
                    cmd.ExecuteNonQuery();
                }
                ////////////////////////////////////////////
                //ACTUALIZAR EL STOCK DE INSUMOS
                foreach (DetalleProducto det in tabla)
                {
                    ProductoDAO.UpdateStockReservadoYDisponibleMatiaPrimaOTfinalizada(det.idProducto, det.cantidad, det.cantidadProductos, cn, tran);
                }
                //////////////////////////////////////


                tran.Commit();

            }
            catch (ArgumentException ex)
            {
                tran.Rollback();
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public static void InsertHijo(OrdenDeTrabajo  OT, SqlTransaction tran, SqlConnection con, int idPadre)
        {
   
            SqlCommand cmd = new SqlCommand("sp_insert_OT", con);

            cmd.Parameters.AddWithValue("@fechaPlan", OT.fechaPlan );
            cmd.Parameters.AddWithValue("@idPlan", OT.idPlan );
            cmd.Parameters.AddWithValue("@idProducto", OT.producto.idProducto );
            cmd.Parameters.AddWithValue("@horaInicio", OT.horaInicio );
            cmd.Parameters.AddWithValue("@horaFin", OT.horaFin );
            cmd.Parameters.AddWithValue("@idOTPadre", idPadre );
            cmd.Parameters.AddWithValue("@idEstado", OT.estado.idEstado );
            cmd.Parameters.AddWithValue("@idProductoIntermedio", OT.productoIntermedio.idProducto );
            cmd.Parameters.AddWithValue("@fechaCreacion", OT.fechaCreacion );
            cmd.Parameters.AddWithValue("@idMaquinaria", OT.maquinaria.idMaquinaria );
            cmd.Parameters.AddWithValue("@idEmpleado", OT.empleado.idEmpleado );
            cmd.Parameters.AddWithValue("@cantidad", OT.cantidad);

            try
            {

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
            finally
            {
                
            }
        }
        public static void InsertPadre(OrdenDeTrabajo OT, List<OrdenDeTrabajo> hijas)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_insert_OT", conexion);

            cmd.Parameters.AddWithValue("@fechaPlan", OT.fechaPlan);
            cmd.Parameters.AddWithValue("@idPlan", OT.idPlan);
            cmd.Parameters.AddWithValue("@idProducto", OT.producto.idProducto);
            cmd.Parameters.AddWithValue("@horaInicio", OT.horaInicio);
            cmd.Parameters.AddWithValue("@horaFin", OT.horaFin);
            //cmd.Parameters.AddWithValue("@idOTPadre", OT.idOrdenTrabajoPadre );
            cmd.Parameters.AddWithValue("@idEstado", OT.estado.idEstado);
            //cmd.Parameters.AddWithValue("@idProductoIntermedio", OT.productoIntermedio.idProducto);
            cmd.Parameters.AddWithValue("@fechaCreacion", OT.fechaCreacion);
            cmd.Parameters.AddWithValue("@idMaquinaria", OT.maquinaria.idMaquinaria);
            cmd.Parameters.AddWithValue("@idEmpleado", OT.empleado.idEmpleado);
            cmd.Parameters.AddWithValue("@cantidad", OT.cantidad);


            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();

                SqlCommand cmdIdentity = new SqlCommand("select @@Identity", conexion, tran);

                OT.idOrdenTrabajo = Convert.ToInt32((cmdIdentity.ExecuteScalar()));


                foreach (OrdenDeTrabajo hija in hijas)
                {
                    InsertHijo(hija, tran, conexion, OT.idOrdenTrabajo);
                }
                //Update(OT,conexion,tran);

                tran.Commit();
            }
            catch (ArgumentException ex)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    tran.Rollback();
                }
                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    tran.Rollback();
                }
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public static List<OrdenDeTrabajo > GetAllOTHija(int idProd, DateTime fecha, int idPlan)
        {
            Acceso ac = new Acceso();

            List<OrdenDeTrabajo> ordenes = new List<OrdenDeTrabajo>();

            string sql = "SELECT * from CONSULTAR_OT_HIJA where fechaCreacion = @fecha and idPlan = @idPlan and idProducto = @idProd ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@idPlan", idPlan);
            cmd.Parameters.AddWithValue("@idProd", idProd);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Producto p;
                Producto pi;
                //Categoria c;
                UnidadMedida u;
                Maquinaria m;
                Estado e;
                OrdenDeTrabajo ot;
                Empleado em;
                while (dr.Read())
                {
                    em = new Empleado();
                    em.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    em.Nombre = dr["nombre"].ToString();
                    em.Apellido = dr["apellido"].ToString();
                    
                    e = new Estado();
                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["estado"].ToString();
                    
                    m = new Maquinaria();
                    m.idMaquinaria  = Convert.ToInt32(dr["idMaquinaria"]);
                    m.Nombre = dr["maquinaria"].ToString();
                    
                    u = new UnidadMedida();
                    u.Nombre = dr["unidad"].ToString();
                                       
                    pi = new Producto();
                    pi.idProducto = Convert.ToInt32(dr["idProdIntermedio"]);
                    pi.Nombre = dr["nombreHijo"].ToString();
                    //pi.Categoria = c;
                    pi.Unidad = u;
                 
                  
                    ot = new OrdenDeTrabajo();
                    
                    ot.idOrdenTrabajo = Convert.ToInt32(dr["idOrdenTrabajo"]);
                    ot.idOrdenTrabajoPadre = Convert.ToInt32(dr["idOTPadre"]);
                    //ot.fechaPlan = Convert.ToDateTime(dr["fechaPlan"]);
                    ot.horaInicio = Convert.ToDateTime(dr["horaInicio"]);
                    ot.horaFin = Convert.ToDateTime(dr["horaFin"]);
                    ot.fechaCreacion = Convert.ToDateTime(dr["fechaCreacion"]);
                    ot.estado = e;
                    ot.empleado = em;
                    ot.maquinaria = m;
                    
                    ot.productoIntermedio = pi;
                    ot.cantidad = Convert.ToDouble (dr["cantidad"]);
                    ot.cantidadReal = Convert.ToDouble(dr["cantReal"]);

                    ordenes.Add(ot);


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


            return ordenes;

        }
        public static DataTable  GetAllEmitir(int idProd, DateTime fecha, int idPlan)
        {
            Acceso ac = new Acceso();

            DataTable ordenes = new DataTable();

            string sql = "SELECT * from EMITIR_ORDEN_TRABAJO_INTERMEDIAS e where e.fechaCreacion = @fecha and e.idPlan = @idPlan and e.idProducto = @idProd ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@idPlan", idPlan);
            cmd.Parameters.AddWithValue("@idProd", idProd);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
          
                ordenes.Load(cmd.ExecuteReader());
  
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


            return ordenes;

        }
        public static DataTable GetAllEmitirFinal(int idProd, DateTime fecha, int idPlan)
        {
            Acceso ac = new Acceso();

            DataTable ordenes = new DataTable();

            string sql = "SELECT * from EMITIR_ORDEN_TRABAJO_FINALES e where e.fechaCreacion = @fecha and e.idPlan = @idPlan and e.idProdIntermedio = @idProd ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@idPlan", idPlan);
            cmd.Parameters.AddWithValue("@idProd", idProd);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                ordenes.Load(cmd.ExecuteReader());

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


            return ordenes;

        }
        public static List<OrdenDeTrabajo> GetAllOTPadre()
        {
            Acceso ac = new Acceso();

            List<OrdenDeTrabajo> ordenes = new List<OrdenDeTrabajo>();

            string sql = "SELECT * from CONSULTAR_OT_Padre";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Producto p;
              
                UnidadMedida u;
                Maquinaria m;
                Estado e;
                OrdenDeTrabajo ot;
                Empleado em;
                while (dr.Read())
                {
                    em = new Empleado();
                    em.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    em.Nombre = dr["empleado"].ToString();
                    em.Apellido = dr["apellido"].ToString();

                    e = new Estado();
                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["estado"].ToString();

                    m = new Maquinaria();
                    m.idMaquinaria = Convert.ToInt32(dr["idMaquinaria"]);
                    m.Nombre = dr["maquinaria"].ToString();

                    u = new UnidadMedida();

                    u.Nombre = dr["unidad"].ToString();



                    //c = new Categoria();
                    ////c.IDCategoria = Convert.ToInt32(dr["idCategoria"]);
                    //c.Nombre = dr["categoria"].ToString();


                    p = new Producto();
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                    p.Nombre = dr["producto"].ToString();
                    //p.Categoria = c;
                    p.Unidad = u;

              
                    ot = new OrdenDeTrabajo();

                    ot.idOrdenTrabajo = Convert.ToInt32(dr["idOrdenTrabajo"]);
                    ot.idPlan = Convert.ToInt32(dr["idPlan"]);
                    ot.fechaPlan = Convert.ToDateTime(dr["fechaPlan"]);
                    ot.horaInicio = Convert.ToDateTime(dr["horaInicio"]);
                    ot.horaFin = Convert.ToDateTime(dr["horaFin"]);
                    ot.fechaCreacion = Convert.ToDateTime(dr["fechaCreacion"]);
                    ot.estado = e;
                    ot.empleado = em;
                    ot.maquinaria = m;
                    ot.producto = p;
                    ot.cantidadReal = Convert.ToDouble(dr["cantReal"]);
                    ot.cantidad = Convert.ToDouble(dr["cantidad"]);
                    ordenes.Add(ot);


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


            return ordenes;

        }
        public static DataTable GetByFiltrosInforme()
        {
            Acceso ac = new Acceso();

            DataTable ordenes = new DataTable();

            string sql = "SELECT OrdenTrabajo.idOrdenTrabajo, OrdenTrabajo.fechaCreacion, OrdenTrabajo.observaciones, OrdenTrabajo.horaInicio, OrdenTrabajo.horaFin, OrdenTrabajo.horaInicioReal,";
            sql += " OrdenTrabajo.horaFinReal, ISNULL(Producto.nombre, '') AS nombreIntermedio, p1.nombre AS nombreFinal, ISNULL(UnidadMedida.nombre, '') AS unidadIntermedio,";
            sql += " u1.nombre AS unidadFinal, OrdenTrabajo.cantidad, OrdenTrabajo.cantidadProducidaReal";
            sql += " FROM Estado INNER JOIN OrdenTrabajo INNER JOIN UnidadMedida AS u1 INNER JOIN";
            sql += " Producto AS p1 ON u1.idUnidad = p1.idUnidadMedida ON OrdenTrabajo.idProducto = p1.idProducto ON Estado.idEstado = OrdenTrabajo.idEstado LEFT OUTER JOIN";
            sql += " Producto INNER JOIN UnidadMedida ON Producto.idUnidadMedida = UnidadMedida.idUnidad ON OrdenTrabajo.idProdIntermedio = Producto.idProducto";
            sql += " WHERE (Estado.idEstado = 20)";

            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            //if (cat != null)
            //{
            //    sql += " and idCategoria = @cat";
            //    cmd.Parameters.AddWithValue("@cat", cat);
            //}
            //if (uni != null)
            //{
            //    sql += " and idUnidad = @uni";
            //    cmd.Parameters.AddWithValue("@uni", uni);
            //}
            //if (stockBajo == true)
            //{
            //    sql += " and stockDisponible<=(stockDeRiesgo*1.5)";
            //}

            sql += " Order By nombreIntermedio asc, nombreFinal asc";

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                ordenes.Load(cmd.ExecuteReader());



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


            return ordenes;

        }

    }
}
