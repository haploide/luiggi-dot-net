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
    public  class PlanMaestroProduccionDAO
    {
        public static void Update(PlanMaestroProduccion ped, List<DetallePlanProduccion> desreservar,List<Producto> productosConPocaMP)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[PlanMaestroProduccion] SET [fechaInicio] = @fechaInicio, [fechaFin] = @fechaFin, [observaciones] = @observaciones  WHERE idPlanProduccion = @idPlanProduccion", conexion);

            cmd.Parameters.AddWithValue("@fechaInicio", ped.fechaInicio );
            cmd.Parameters.AddWithValue("@fechaFin", ped.fechaFin );
            cmd.Parameters.AddWithValue("@observaciones", ped.observaciones );
            cmd.Parameters.AddWithValue("@idPlanProduccion", ped.IDPlanProduccion);



            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                cmd.CommandType = CommandType.Text;
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                //SqlCommand cmdIdentity = new SqlCommand("select @@Identity", conexion, tran);
                //ped.idPedido = Convert.ToInt32((cmdIdentity.ExecuteScalar()));
                 DetallePlanProduccionDAO.Delete(ped.IDPlanProduccion,conexion,tran );
                
                foreach(DetallePlanProduccion det in desreservar)
                {
                    det.cantidadPedido = det.cantidadPedido * -1;
                    det.cantidadPLan = det.cantidadPLan * -1;

                    actualizarStock(det, conexion, tran, ped,productosConPocaMP);
                }


                foreach (DetallePlanProduccion  detPed in ped.detallePlan )
                {
                    //detPed.pedido.idPedido = ped.idPedido;
                    DetallePlanProduccionDAO.Insert(detPed, conexion, tran, ped.IDPlanProduccion);
                    actualizarStock(detPed, conexion, tran, ped, productosConPocaMP);
                }
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
        public static void Insert(PlanMaestroProduccion plan, List<Producto> productosConPocaMP)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_PlanProduccion_insert", conexion);

            cmd.Parameters.AddWithValue("@fechaCreacion", plan.fechaCreacion );
            cmd.Parameters.AddWithValue("@fechaInicio", plan.fechaInicio );
            cmd.Parameters.AddWithValue("@fechaFin", plan.fechaFin );
            cmd.Parameters.AddWithValue("@idEstado", plan.estado.idEstado );
            cmd.Parameters.AddWithValue("@observaciones", plan.observaciones );
          


            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                SqlCommand cmdIdentity = new SqlCommand("select @@Identity", conexion, tran);
                plan.IDPlanProduccion  = Convert.ToInt32((cmdIdentity.ExecuteScalar()));
                
                foreach (DetallePlanProduccion  detPlan in plan.detallePlan)
                {
                    //detPed.pedido.idPedido = ped.idPedido;
                    
                    DetallePlanProduccionDAO.Insert(detPlan, conexion, tran, plan.IDPlanProduccion);

                    actualizarStock(detPlan, conexion, tran, plan,productosConPocaMP);
                }
                
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
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {

                conexion.Close();
            }
        }
        public static void actualizarStock(DetallePlanProduccion detPlan, SqlConnection con, SqlTransaction trans, PlanMaestroProduccion plan, List<Producto> ProductosConPocaMP)
        {
            DataTable ProductosIntermedio;
            DataTable MateriaPrima;
            
            int idProductoFinal = 0;
            
            double cantidad = 0;

            idProductoFinal = detPlan.producto.idProducto;//OBTENEMOS EL ID DEL PRODUCTO FINAL
            cantidad = detPlan.cantidadPedido + detPlan.cantidadPLan;//OBTENEMOS LA CANTIDAD DE PRODUCTOS
            

            MateriaPrima = ProductoDAO.GetMateriaPrima(idProductoFinal,trans,con);//CARGAMOS EN LA TABLA LOS DATOS DE LAS MATERIAS PRIMAS
            DataTable MateriaPrimaXIntermedio = new DataTable();
            ProductosIntermedio = ProductoDAO.GetProductoIntermedio(idProductoFinal,con,trans);//CARGAMOS EN LA TABLA LOS DATOS DE LOS PRODUCTOS INTERMEDIO

            obtenerMateriasPrimas(MateriaPrima, MateriaPrimaXIntermedio, ProductosIntermedio, cantidad, idProductoFinal, con, trans,ProductosConPocaMP);
            
        }
        public static void obtenerMateriasPrimas(DataTable MateriaPrima, DataTable MateriaPrimaXIntermedio, DataTable ProductosIntermedio, double cantidad, int idProducto, SqlConnection con, SqlTransaction trans, List<Producto> ProductosConPocaMP)
        {
            for (int k = 0; k < MateriaPrima.Rows.Count; k++)
            {
                MateriaPrima.Rows[k]["cantidad"] = double.Parse(MateriaPrima.Rows[k]["cantidad"].ToString()) * cantidad;
            }
            for (int f = 0; f < ProductosIntermedio.Rows.Count; f++)//RECORREMOS LA TABLA DE PRODUCTOS INTERMEDIOS
            {
                if (ProductosIntermedio.Rows.Count != 0)
                {
                    double cantidadIntermedios = cantidad * double.Parse(ProductosIntermedio.Rows[f]["cantidad"].ToString());

                    MateriaPrimaXIntermedio = ProductoDAO.GetMateriaPrima(int.Parse(ProductosIntermedio.Rows[f]["idProductohijo"].ToString()),trans,con);//CARGAMOS EN LA TABLA LOS DATOS DE LAS MATERIAS PRIMAS DE LOS PRODUCTOS INTERMEDIOS
                    for (int j = 0; j < MateriaPrimaXIntermedio.Rows.Count; j++)
                    {
                        MateriaPrimaXIntermedio.Rows[j]["cantidad"] = double.Parse(MateriaPrimaXIntermedio.Rows[j]["cantidad"].ToString()) * cantidadIntermedios;
                    }
                    MateriaPrima.Merge(MateriaPrimaXIntermedio, true);// YA TENEMOS DENTRO DE  LA TABLA MATERIA PRIMA TODOS LOS PRODUCTOS INSUMOS O MP QUE SE NECESITAN PARA UN PRODUCTO DEL PEDIDO QUE NO ESTE RESERVADO
                    
                }
            }
            
            for (int k = 0; k < MateriaPrima.Rows.Count; k++)
            {
                int idProdMP = 0;
                double cantidadMP = 0;
                idProdMP = int.Parse(MateriaPrima.Rows[k]["idProductohijo"].ToString());
                cantidadMP = double.Parse(MateriaPrima.Rows[k]["cantidad"].ToString());
                ProductoDAO.actualizarStockMateriasPrimas(idProdMP, cantidadMP, con, trans);
            }
            if (cantidad >= 0)
            {
                List<Producto> ProductosMP = ProductoDAO.GetPeductosMPeInsumos(con, trans);
                for (int k = 0; k < MateriaPrima.Rows.Count; k++)
                {
                    foreach (Producto prod in ProductosMP)
                    {
                        if (prod.idProducto == int.Parse(MateriaPrima.Rows[k]["idProductohijo"].ToString()))
                        {
                            if (prod.StockDisponible <= prod.StockRiesgo)
                            {
                                ProductosConPocaMP.Add(prod);
                            }
                            break;
                        }
                    }
                }
            }
        }
        public static List<PlanMaestroProduccion > GetAll()
        {
            Acceso ac = new Acceso();

            List<PlanMaestroProduccion> planes = new List<PlanMaestroProduccion>();

            string sql = "SELECT * from CONSULTA_PLAN_PRODUCCION order by idPlanProduccion desc";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                PlanMaestroProduccion p;
               
                Estado e;
               

                while (dr.Read())
                {
                    p = new PlanMaestroProduccion();
                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["nombre"].ToString();

                    p.IDPlanProduccion = Convert.ToInt32(dr["idPlanProduccion"]);
                    p.fechaCreacion = Convert.ToDateTime(dr["fechaCreacion"]);
                    p.fechaInicio = Convert.ToDateTime(dr["fechaInicio"]);
                    p.fechaFin = Convert.ToDateTime(dr["fechaFin"]);
                    p.observaciones = dr["observaciones"].ToString();
                    p.fechaCancelacion = Convert.ToDateTime(dr["fechaCancelacion"]);
                    p.motivoCancelacion  = dr["motivoCancelacion"].ToString();
                    p.estado = e;
                   
                    planes.Add(p);

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


            return planes;

        }
        public static PlanMaestroProduccion  GetById(int id)
        {
            Acceso ac = new Acceso();

            PlanMaestroProduccion p = new PlanMaestroProduccion();

            SqlCommand cmd = new SqlCommand();
            string sql = "SELECT * from CONSULTA_PLAN_PRODUCCION where idPlanProduccion = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
         
                Estado e;
                
                while (dr.Read())
                {
                    p = new PlanMaestroProduccion();
                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["nombre"].ToString();

                    p.IDPlanProduccion = Convert.ToInt32(dr["idPlanProduccion"]);
                    p.fechaCreacion = Convert.ToDateTime(dr["fechaCreacion"]);
                    p.fechaInicio = Convert.ToDateTime(dr["fechaInicio"]);
                    p.fechaFin = Convert.ToDateTime(dr["fechaFin"]);
                    p.observaciones = dr["observaciones"].ToString();
                    p.fechaCancelacion = Convert.ToDateTime(dr["fechaCancelacion"]);
                    p.motivoCancelacion = dr["motivoCancelacion"].ToString();
                    p.estado = e;

                   
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


            return p;

        }
        public static List<PlanMaestroProduccion> GetByFiltros(int est, DateTime? fInicioDesde, DateTime? fFinHasta)
        {
            Acceso ac = new Acceso();

            List<PlanMaestroProduccion> planes = new List<PlanMaestroProduccion>();

            string sql = "SELECT * from CONSULTA_PLAN_PRODUCCION where 1=1";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            if (est != -1 && est != 0)
            {
                sql += " and idEstado = @est";
                cmd.Parameters.AddWithValue("@est", est);
            }


            if (fInicioDesde.HasValue)
            {
                sql += " and fechaInicio >= @fInicioDesde";
                cmd.Parameters.AddWithValue("@fInicioDesde", fInicioDesde.Value);
            }
            //if (fInicioHasta.HasValue)
            //{
            //    sql += " and fechaInicio <= @fInicioHasta";
            //    cmd.Parameters.AddWithValue("@fInicioHasta", fInicioHasta.Value);
            //}

            //if (fFinDesde.HasValue)
            //{
            //    sql += " and fechaFin >= @fFinDesde";
            //    cmd.Parameters.AddWithValue("@fFinDesde", fFinDesde.Value);
            //}
            if (fFinHasta.HasValue)
            {
                sql += " and fechaFin <= @fFinHasta";
                cmd.Parameters.AddWithValue("@fFinHasta", fFinHasta.Value);
            }


            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                PlanMaestroProduccion p;

                Estado e;


                while (dr.Read())
                {
                    p = new PlanMaestroProduccion();
                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["nombre"].ToString();

                    p.IDPlanProduccion = Convert.ToInt32(dr["idPlanProduccion"]);
                    p.fechaCreacion = Convert.ToDateTime(dr["fechaCreacion"]);
                    p.fechaInicio = Convert.ToDateTime(dr["fechaInicio"]);
                    p.fechaFin = Convert.ToDateTime(dr["fechaFin"]);
                    p.observaciones = dr["observaciones"].ToString();
                    p.fechaCancelacion = Convert.ToDateTime(dr["fechaCancelacion"]);
                    p.motivoCancelacion = dr["motivoCancelacion"].ToString();
                    p.estado = e;

                    planes.Add(p);

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


            return planes;

        }
        public static Boolean verificarExistenciaPlanParaPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            Boolean resul=false;

            string sql = "SELECT idPlanProduccion";
            sql += " FROM PlanMaestroProduccion";
            sql += " WHERE (fechaInicio = @fechaInicio) AND (fechaFin = @fechaFin)";
            
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@fechaInicio",fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin",fechaFin);

            try
            {

                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                resul = dr.HasRows;



            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return resul;
        }
        public static int obtenerIdPlan(DateTime fecha)
        {
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            int idPlan = 0;

            string sql = "SELECT idPlanProduccion";
            sql += " FROM PlanMaestroProduccion";
            sql += " WHERE (fechaInicio <= @fecha) AND (fechaFin >= @fecha)";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@fecha", fecha);
            try
            {

                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    idPlan = Convert.ToInt32(dr["idPlanProduccion"]);
                }

            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return idPlan;
        }
        public static void actualizarEstado()
        {
            Acceso ac = new Acceso();
            

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            string sql = "UPDATE [Luiggi].[dbo].[PlanMaestroProduccion] SET idEstado = 24 WHERE [fechaFin] < Cast(Convert(varchar(10),getdate(),103) as datetime) and idEstado <> 24";
            sql+=" UPDATE [Luiggi].[dbo].[PlanMaestroProduccion] SET idEstado = 18 WHERE [fechaFin] > Cast(Convert(varchar(10),getdate(),103) as datetime) and [fechaInicio] < Cast(Convert(varchar(10),getdate(),103) as datetime) and idEstado <> 18 ";

            SqlCommand cmd = new SqlCommand(sql, conexion);

            
            try
            {
                conexion.Open();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                
            }
            
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {

                conexion.Close();
            }
        }
        
    }
}
