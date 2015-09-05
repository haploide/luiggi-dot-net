using System;
using System.Drawing;
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
    public class ProductoDAO
    {
        public static int BuscarProductoPedidoSinReservaParaFecha(int id, DateTime fecha)
        {
            int resul= 0;
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_buscar_productos_pedidos_sin_reserva", conexion);

            cmd.Parameters.AddWithValue("@idProducto", id);
            cmd.Parameters.AddWithValue("@fecha", fecha);

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                if (dr.HasRows)
                {
                    resul = Convert.ToInt32(dr["cantidad"]); 
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

            return resul;
            
        }
        public static void UpdateStockReservadoYDisponibleOTFinalizada(int id, Double cantPlanificada, Double cantPedidos, SqlConnection con, SqlTransaction tran)
        {
            Acceso ac = new Acceso();
            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Producto] SET [stockDisponible] = stockDisponible + @cantidadPlanificada, [stockReservado] = stockReservado + @cantidadPedidos, [stockActual]  = stockActual + @cantidadPlanificada + @cantidadPedidos WHERE idProducto = @idProducto", con);
            cmd.Parameters.AddWithValue("@idProducto", id);
            cmd.Parameters.AddWithValue("@cantidadPlanificada", cantPlanificada);
            cmd.Parameters.AddWithValue("@cantidadPedidos", cantPedidos);
            
            try
            {

                cmd.Transaction = tran;
                cmd.CommandType = CommandType.Text;
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
        public static void UpdateStockReservadoYDisponibleEliminado(int id, Double  cant, SqlConnection con, SqlTransaction tran)
        {
            Acceso ac = new Acceso();
            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Producto] SET [stockDisponible] = stockDisponible + @cantidad, [stockReservado] = stockReservado - @cantidad  WHERE idProducto = @idProducto", con);
            cmd.Parameters.AddWithValue("@idProducto", id );
            cmd.Parameters.AddWithValue("@cantidad", cant);
            try
            {
                
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.Text;
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
        public static void UpdateStockReservadoYDisponibleMatiaPrimaOTfinalizada(int idProducto, Double cantReal, Double cantPlan, SqlConnection con, SqlTransaction tran)
        {
            //DESRESERVO LO RESERVADO DE ACUERDO A LO PLANIFICADO
            Acceso ac = new Acceso();
            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Producto] SET  [stockDisponible] = stockDisponible + @cantidadPlan, [stockReservado] = stockReservado - @cantidadPlan  WHERE idProducto = @idProducto", con);
            cmd.Parameters.AddWithValue("@idProducto", idProducto);
            cmd.Parameters.AddWithValue("@cantidadPlan", cantPlan);
            try
            {

                cmd.Transaction = tran;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                ////////////////////////

                // DESCUENTO LA CANTIDAD REAL DE LAS MP
                cmd.CommandText = "UPDATE [Luiggi].[dbo].[Producto] SET  [stockActual] = stockActual - @cantidadReal, [stockDisponible] = stockDisponible - @cantidadReal  WHERE idProducto = @idProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.Parameters.AddWithValue("@cantidadReal", cantReal);

                cmd.ExecuteNonQuery();
                /////////////////////////
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
        public static void UpdateStockActualYDisponible(DetalleFactura det, SqlConnection cn, SqlTransaction tran)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Producto] SET [stockDisponible] = stockDisponible - @cantidad,  [stockActual] = stockActual - @cantidad  WHERE idProducto = @idProducto", conexion);


            cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto);
            cmd.Parameters.AddWithValue("@cantidad", det.cantidad);

            try
            {
                conexion.Open();
                cmd.Connection = cn;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.Text;
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
                conexion.Close();
            }
        }
        public static void UpdateStockActualYDisponibleInsumosYMPIngresadas(DetalleOrdenCompra  det, SqlConnection cn, SqlTransaction tran)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Producto] SET [stockDisponible] = stockDisponible + @cantidad,  [stockActual] = stockActual + @cantidad  WHERE idProducto = @idProducto", conexion);


            cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto);
            if (det.producto.Unidad.Descripcion == "g")
                cmd.Parameters.AddWithValue("@cantidad", det.cantidadRealIngresada * 1000 );
            else
                cmd.Parameters.AddWithValue("@cantidad", det.cantidadRealIngresada);

            try
            {
                conexion.Open();
                cmd.Connection = cn;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.Text;
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
                conexion.Close();
            }
        }

        public static void UpdateStockReservadoYDisponible(DetallePedido det, SqlConnection cn, SqlTransaction tran)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Producto] SET [stockDisponible] = stockDisponible - @cantidad, [stockReservado] = stockReservado + @cantidad  WHERE idProducto = @idProducto", conexion);

            
            cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto );
            cmd.Parameters.AddWithValue("@cantidad",det.cantidad );
           
            try
            {
                conexion.Open();
                cmd.Connection = cn;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.Text;
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
                conexion.Close();
            }
        }
        public static void UpdateStockReservadoYActualdePedidoEntregado(DetallePedido det, int idPedido, int estadoHasta)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlTransaction tran=null;
            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Producto] SET [stockActual] = stockActual - @cantidad, [stockReservado] = stockReservado - @cantidad  WHERE idProducto = @idProducto", conexion);


            cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto);
            cmd.Parameters.AddWithValue("@cantidad", det.cantidad);

            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                PedidoDAO.UpdateEstados(idPedido, estadoHasta);


                tran.Commit();
            }
            catch (ArgumentException ex)
            {
                tran.Rollback();
                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public static void UpdateStockDisponibleYActualdeVentaDirecta(DetallePedido det)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Producto] SET [stockActual] = stockActual - @cantidad, [stockDisponible] = stockDisponible - @cantidad  WHERE idProducto = @idProducto", conexion);


            cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto);
            cmd.Parameters.AddWithValue("@cantidad", det.cantidad);

            try
            {
                conexion.Open();

                cmd.Connection = conexion;

                cmd.CommandType = CommandType.Text;
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
                conexion.Close();
            }
        }
        public static void Update(Producto prod)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_producto_update", conexion);

            cmd.Parameters.AddWithValue("@categoriaProd", prod.Categoria.IDCategoria);
            cmd.Parameters.AddWithValue("@descripcionProd", prod.Descripcion);
            cmd.Parameters.AddWithValue("@unidadProd", prod.Unidad.IDUnidad);
            cmd.Parameters.AddWithValue("@stockDeRiesgoProd", prod.StockRiesgo);
            cmd.Parameters.AddWithValue("@precioProd", prod.precio);
            cmd.Parameters.AddWithValue("@codProducto", prod.CODProducto);
            cmd.Parameters.AddWithValue("@fotoProd", prod.foto);
            cmd.Parameters.AddWithValue("@nombre", prod.Nombre );
            cmd.Parameters.AddWithValue("@idTipoMaquinaria", prod.tipoMaquina.idTipoMaquinaria );
            cmd.Parameters.AddWithValue("@tiempoProduccion", prod.tiempoProduccion );
            cmd.Parameters.AddWithValue("@precioMayorista", prod.precioMayorista );
            cmd.Parameters.AddWithValue("@idUnidadTiempo", prod.UnidadTiempo.IDUnidad);
            cmd.Parameters.AddWithValue("@cantidadProductos", prod.cantidadProductos);
          
            try
            {
                conexion.Open();

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
                conexion.Close();
            }
        }
        public static void Insert(Producto prod)
        {
            Acceso ac = new Acceso();

            
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_producto_insert", conexion);

            cmd.Parameters.AddWithValue("@codProducto", prod.CODProducto);
            cmd.Parameters.AddWithValue("@nombreProd", prod.Nombre);
            cmd.Parameters.AddWithValue("@categoriaProd", prod.Categoria.IDCategoria);
            cmd.Parameters.AddWithValue("@descripcionProd", prod.Descripcion);
            cmd.Parameters.AddWithValue("@unidadProd", prod.Unidad.IDUnidad);
            cmd.Parameters.AddWithValue("@stockDeRiesgoProd", prod.StockRiesgo);
            cmd.Parameters.AddWithValue("@precioProd", prod.precio);
            cmd.Parameters.AddWithValue("@fotoProd", prod.foto );
            cmd.Parameters.AddWithValue("@idTipoMaquinaria", prod.tipoMaquina.idTipoMaquinaria);
            cmd.Parameters.AddWithValue("@tiempoProduccion", prod.tiempoProduccion);
            cmd.Parameters.AddWithValue("@precioMayorista", prod.precioMayorista);
            cmd.Parameters.AddWithValue("@idUnidadTiempo", prod.UnidadTiempo.IDUnidad );
            cmd.Parameters.AddWithValue("@cantidadProductos", prod.cantidadProductos);
          
            try
            {
                conexion.Open();
                
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
                conexion.Close();
            }
        }
        public static void Delete(int codProducto)
        {
            Acceso ac = new Acceso();

            string sql = "DELETE FROM Producto WHERE (codProducto = @codigo)";
            
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand(sql, conexion);

            cmd.Parameters.AddWithValue("@codigo",codProducto);

            try
            {
                conexion.Open();

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
                conexion.Close();
            }
        }
        public static List<Producto> GetAll()
        {
            Acceso ac = new Acceso();

            List<Producto> productos = new List<Producto>();

            string sql = "SELECT codProducto, nombre, descripcion, precio, categoria, unidad, stockDisponible, stockDeRiesgo, stockReservado, stockActual, idCategoria, descCat, idUnidad, descUni, foto, idTipoMaquinaria, tiempoProduccion, tipoMaquinaria, precioMayorista, idUnidadTiempo, cantidadProductos from CONSULTA_PRODUCTOS order by categoria asc, nombre asc";
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
                Categoria c;
                UnidadMedida u;
                TipoMaquinaria t;
                UnidadMedida ut;
                while (dr.Read())
                {
                    ut = new UnidadMedida();
                    ut.IDUnidad = Convert.ToInt32(dr["idUnidadTiempo"]);

                    t = new TipoMaquinaria();
                    t.idTipoMaquinaria = Convert.ToInt32(dr["idTipoMaquinaria"]);
                    t.Nombre = dr["tipoMaquinaria"].ToString();
                    u = new UnidadMedida();
                    
                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["unidad"].ToString();
                    u.Descripcion = dr["descUni"].ToString();


                    c = new Categoria();
                    c.IDCategoria = Convert.ToInt32(dr["idCategoria"]);
                    c.Nombre = dr["categoria"].ToString();
                    c.Descripcion = dr["descCat"].ToString();
                    
                    p = new Producto();
                    
                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["nombre"].ToString();
                    p.Categoria = c;
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Unidad = u;
                    p.StockRiesgo = Convert.ToInt32(dr["stockDeRiesgo"]);
                    p.StockDisponible = Convert.ToInt32(dr["stockDisponible"]);
                    p.StockActual = Convert.ToInt32(dr["stockActual"]);
                    p.StockReservado = Convert.ToInt32(dr["stockReservado"]);
                    p.precio = Convert.ToDouble(dr["precio"]);
                    p.foto = (Byte [])(dr["foto"]);
                    p.tiempoProduccion = Convert.ToDouble(dr["tiempoProduccion"]);
                    p.precioMayorista = Convert.ToDouble(dr["precioMayorista"]);
                    p.UnidadTiempo = ut;
                    p.tipoMaquina = t;
                    if (dr["cantidadProductos"] != DBNull.Value)
                    {
                        p.cantidadProductos = Convert.ToDouble(dr["cantidadProductos"]);
                    }
                    else
                    {
                        p.cantidadProductos = 0;
                    }
                    
                    productos.Add(p);


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


            return  productos;

        }
        public static List<Producto> GetPeductosFinales()
        {
            Acceso ac = new Acceso();

            List<Producto> productos = new List<Producto>();

            string sql = "SELECT DISTINCT c.codProducto, c.nombre, c.descripcion, c.precio, c.categoria, c.unidad, c.stockDisponible, c.stockDeRiesgo, c.stockReservado, c.stockActual,  c.idCategoria, c.descCat, c.idUnidad, c.descUni, c.idProducto, c.foto from CONSULTA_PRODUCTOS c INNER JOIN DetalleProducto d ON c.idProducto = d.idProducto where c.idCategoria = 1 order by nombre asc";
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
                Categoria c;
                UnidadMedida u;

                while (dr.Read())
                {
                    u = new UnidadMedida();

                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["unidad"].ToString();
                    u.Descripcion = dr["descUni"].ToString();


                    c = new Categoria();
                    c.IDCategoria = Convert.ToInt32(dr["idCategoria"]);
                    c.Nombre = dr["categoria"].ToString();
                    c.Descripcion = dr["descCat"].ToString();

                    p = new Producto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["nombre"].ToString();
                    p.Categoria = c;
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Unidad = u;
                    p.StockRiesgo = Convert.ToInt32(dr["stockDeRiesgo"]);
                    p.StockDisponible = Convert.ToInt32(dr["stockDisponible"]);
                    p.StockActual = Convert.ToInt32(dr["stockActual"]);
                    p.StockReservado = Convert.ToInt32(dr["stockReservado"]);
                   
                    p.precio = Convert.ToDouble(dr["precio"]);
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                   // p.foto = (Byte[])(dr["foto"]);

                    productos.Add(p);


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


            return productos;

        }
        public static List<Producto> GetPeductosMPeInsumos()
        {
            Acceso ac = new Acceso();

            List<Producto> productos = new List<Producto>();

            string sql = "SELECT DISTINCT codProducto, nombre, descripcion, precio, categoria, unidad, stockDisponible, stockDeRiesgo, stockReservado, stockActual,  idCategoria, descCat, idUnidad, descUni, idProducto, foto from CONSULTA_PRODUCTOS where (idCategoria = 3 or idCategoria = 4)";
            sql += " and not Upper(nombre)='AGUA' order by nombre asc";
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
                Categoria c;
                UnidadMedida u;

                while (dr.Read())
                {
                    u = new UnidadMedida();

                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["unidad"].ToString();
                    u.Descripcion = dr["descUni"].ToString();


                    c = new Categoria();
                    c.IDCategoria = Convert.ToInt32(dr["idCategoria"]);
                    c.Nombre = dr["categoria"].ToString();
                    c.Descripcion = dr["descCat"].ToString();

                    p = new Producto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["nombre"].ToString();
                    p.Categoria = c;
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Unidad = u;
                    p.StockRiesgo = Convert.ToInt32(dr["stockDeRiesgo"]);
                    p.StockDisponible = Convert.ToInt32(dr["stockDisponible"]);
                    p.StockActual = Convert.ToInt32(dr["stockActual"]);
                    p.StockReservado = Convert.ToInt32(dr["stockReservado"]);
                   
                    p.precio = Convert.ToDouble(dr["precio"]);
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                   // p.foto = (Byte[])(dr["foto"]);

                    productos.Add(p);


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


            return productos;

        }
        public static List<Producto> GetPeductosMPeInsumos(SqlConnection con, SqlTransaction trans)
        {
            List<Producto> productos = new List<Producto>();
            string sql = "SELECT DISTINCT codProducto, nombre, descripcion, precio, categoria, unidad, stockDisponible, stockDeRiesgo, stockReservado, stockActual,  idCategoria, descCat, idUnidad, descUni, idProducto, foto from CONSULTA_PRODUCTOS where idCategoria = 3 or idCategoria = 4";
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.Transaction = trans;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                Producto p;
                Categoria c;
                UnidadMedida u;
                
                while (dr.Read())
                {
                    u = new UnidadMedida();

                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["unidad"].ToString();
                    u.Descripcion = dr["descUni"].ToString();


                    c = new Categoria();
                    c.IDCategoria = Convert.ToInt32(dr["idCategoria"]);
                    c.Nombre = dr["categoria"].ToString();
                    c.Descripcion = dr["descCat"].ToString();

                    p = new Producto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["nombre"].ToString();
                    p.Categoria = c;
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Unidad = u;
                    p.StockRiesgo = Convert.ToInt32(dr["stockDeRiesgo"]);
                    p.StockDisponible = Convert.ToInt32(dr["stockDisponible"]);
                    p.StockActual = Convert.ToInt32(dr["stockActual"]);
                    p.StockReservado = Convert.ToInt32(dr["stockReservado"]);
                   
                    p.precio = Convert.ToDouble(dr["precio"]);
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                   // p.foto = (Byte[])(dr["foto"]);
                    productos.Add(p);
                }
                dr.Close();

            }
            catch (InvalidOperationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            return productos;
        }

        public static List<Producto> GetByFiltros(int cat, int uni, double? desde, double? hasta)
        {
            Acceso ac = new Acceso();

            List<Producto> productos = new List<Producto>();

            string sql = "SELECT codProducto, nombre, descripcion, precio, categoria, unidad, stockDeRiesgo, idCategoria, descCat, idUnidad, descUni, foto, idTipoMaquinaria, tiempoProduccion, tipoMaquinaria, precioMayorista, idUnidadTiempo, cantidadProductos  from CONSULTA_PRODUCTOS where 1=1";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            if (cat != -1 && cat != 0)
            {
                sql += " and idCategoria = @cat";
                cmd.Parameters.AddWithValue("@cat", cat);
            }
            if (uni != -1 && uni != 0 )
            {
                sql += " and idUnidad = @uni";
                cmd.Parameters.AddWithValue("@uni", uni);
            }
            if (desde.HasValue)
            {
                sql += " and precio >= @desde";
                cmd.Parameters.AddWithValue("@desde", desde);
 
            }
            if (hasta.HasValue)
            {
                sql += " and precio <= @hasta";
                cmd.Parameters.AddWithValue("@hasta", hasta );
 
            }

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Producto p;
                Categoria c;
                UnidadMedida u;
                TipoMaquinaria t;
                UnidadMedida ut;
                while (dr.Read())
                {
                    ut = new UnidadMedida();
                    ut.IDUnidad = Convert.ToInt32(dr["idUnidadTiempo"]);

                    t = new TipoMaquinaria();
                    t.idTipoMaquinaria = Convert.ToInt32(dr["idTipoMaquinaria"]);
                    t.Nombre = dr["tipoMaquinaria"].ToString();
                    u = new UnidadMedida();

                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["unidad"].ToString();
                    u.Descripcion = dr["descUni"].ToString();


                    c = new Categoria();
                    c.IDCategoria = Convert.ToInt32(dr["idCategoria"]);
                    c.Nombre = dr["categoria"].ToString();
                    c.Descripcion = dr["descCat"].ToString();

                    p = new Producto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["nombre"].ToString();
                    p.Categoria = c;
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Unidad = u;
                    p.StockRiesgo = Convert.ToInt32(dr["stockDeRiesgo"]);
                    p.precio = Convert.ToDouble(dr["precio"]);
                    p.foto = (Byte[])(dr["foto"]);
                    p.tiempoProduccion = Convert.ToDouble(dr["tiempoProduccion"]);
                    p.precioMayorista = Convert.ToDouble(dr["precioMayorista"]);
                    p.UnidadTiempo = ut;
                    p.tipoMaquina = t;
                    
                    if (dr["cantidadProductos"] != DBNull.Value)
                    {
                        p.cantidadProductos = Convert.ToDouble(dr["cantidadProductos"]);
                    }
                    else
                    {
                        p.cantidadProductos = 0;
                    }
                    productos.Add(p);

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


            return productos;

        }
        public static DataTable GetByFiltrosInforme(int? cat, int? uni, Boolean stockBajo)
        {
            Acceso ac = new Acceso();

            DataTable productos = new DataTable();

            string sql = "SELECT codProducto, nombre, descripcion, precio, categoria, unidad, stockDeRiesgo, idCategoria, descCat, idUnidad, descUni, foto, idTipoMaquinaria, tiempoProduccion, tipoMaquinaria, precioMayorista, idUnidadTiempo, cantidadProductos, stockDisponible, stockActual, stockReservado  from CONSULTA_PRODUCTOS where 1=1";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            if (cat != null)
            {
                sql += " and idCategoria = @cat";
                cmd.Parameters.AddWithValue("@cat", cat);
            }
            if (uni != null)
            {
                sql += " and idUnidad = @uni";
                cmd.Parameters.AddWithValue("@uni", uni);
            }
            if (stockBajo == true)
            {
                sql += " and stockDisponible<=(stockDeRiesgo*1.5)";
            }

            sql += " and not Upper(nombre)='AGUA'";
            sql += " Order By nombre asc";

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                 productos.Load(cmd.ExecuteReader());

                

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


            return productos;

        }
        public static Producto GetByIdProd(int idProd, DateTime fecha)
        {
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            Producto productos = new Producto();
            SqlCommand cmd = new SqlCommand();
            string sql = "sp_cantidad_productos";
            cmd.Parameters.AddWithValue("@idProd", idProd);
            cmd.Parameters.AddWithValue("@fecha", fecha );
            Producto p = new Producto();
                    
            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure ;

                SqlDataReader dr = cmd.ExecuteReader();
             
                while (dr.Read())
                {
                 
                   
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                    p.Unidad = new UnidadMedida() { Nombre = dr["nombre"].ToString() };
                    p.cantidadAProd = Convert.ToDouble(dr["cantidad"]);
                    p.tiempoProduccion = Convert.ToDouble(dr["tiempoProduccion"]);
                    p.cantidadProductos = Convert.ToDouble(dr["cantidadProductos"]);
                   
  
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
        public static List<Producto> GetByFiltrosOT(DateTime fecha)
        {
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            List<Producto> productos = new List<Producto>();
            SqlCommand cmd = new SqlCommand();
            string sql = "sp_producto_sin_orden";
            cmd.Parameters.AddWithValue("@fecha", fecha);


            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                Producto p;

                while (dr.Read())
                {

                    p = new Producto();
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                    p.Nombre = dr["nombre"].ToString();

                    productos.Add(p);


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


            return productos;

        }
        public static float getStockDisponible(int idProd)
        {
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            Producto productos = new Producto();
            SqlCommand cmd = new SqlCommand();
            string sql = "Select stockDisponible From CONSULTA_PRODUCTOS where idProducto = @idProd";
            cmd.Parameters.AddWithValue("@idProd", idProd);

            float stockDisp = 0;

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();



                while (dr.Read())
                {


                    stockDisp = float.Parse(dr["stockDisponible"].ToString());

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


            return stockDisp;
        }
        public static Boolean verificarProductoPlanificado(DateTime fechaNecesidad, int idProducto, SqlConnection con, SqlTransaction tran)
        {
            Boolean resul=false;
            string sql = "SELECT DetallePlanProduccion.idProducto";
            sql += " FROM Producto INNER JOIN";
            sql += " DetallePlanProduccion ON Producto.idProducto = DetallePlanProduccion.idProducto INNER JOIN";
            sql += " PlanMaestroProduccion ON DetallePlanProduccion.idPlan = PlanMaestroProduccion.idPlanProduccion";
            sql += " WHERE (DetallePlanProduccion.fechaProduccion = @fecha) AND (DetallePlanProduccion.idProducto = @id)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@fecha",fechaNecesidad);
            cmd.Parameters.AddWithValue("@id",idProducto);
            try
            {
                cmd.Connection = con;
                cmd.Transaction = tran;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                resul = dr.HasRows;
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
            }

            return resul;
        }
        public static Boolean verificarProductoPlanificado(DateTime fechaNecesidad, int idProducto)
        {
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            Boolean resul = false;
            string sql = "SELECT DetallePlanProduccion.idProducto";
            sql += " FROM Producto INNER JOIN";
            sql += " DetallePlanProduccion ON Producto.idProducto = DetallePlanProduccion.idProducto INNER JOIN";
            sql += " PlanMaestroProduccion ON DetallePlanProduccion.idPlan = PlanMaestroProduccion.idPlanProduccion";
            sql += " WHERE (DetallePlanProduccion.fechaProduccion = @fecha) AND (DetallePlanProduccion.idProducto = @id)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@fecha", fechaNecesidad);
            cmd.Parameters.AddWithValue("@id", idProducto);
            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                resul = dr.HasRows;
                dr.Close();
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
        public static Boolean verificarPlanSinProducto(DateTime fechaNecesidad, int idProducto, SqlConnection con, SqlTransaction trans)
        {
            Boolean resul = false;
            string sql = "SELECT * FROM Producto INNER JOIN DetallePlanProduccion";
            sql += " ON Producto.idProducto = DetallePlanProduccion.idProducto INNER JOIN PlanMaestroProduccion";
            sql += " ON DetallePlanProduccion.idPlan = PlanMaestroProduccion.idPlanProduccion";
            sql += " WHERE (PlanMaestroProduccion.fechaInicio <= @fecha AND PlanMaestroProduccion.fechaFin >= @fecha) AND NOT EXISTS";
            sql += " (Select 1 From DetallePlanProduccion as DP1 where DP1.fechaProduccion = ";
            sql += " DetallePlanProduccion.fechaProduccion AND DP1.idProducto = @id)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@fecha", fechaNecesidad);
            cmd.Parameters.AddWithValue("@id", idProducto);
            try
            {
                cmd.Connection = con;
                cmd.Transaction = trans;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                resul = dr.HasRows;
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
                
            }

            return resul;
        }
        public static DataTable GetMateriaPrima(int idProd, SqlTransaction tran, SqlConnection conec)
        {
            

            DataTable productos = new DataTable();

            string sql = "SELECT idProducto,idProductohijo, nombrehijo,  cantidad, tiempoproduccion, cantidadproductos FROM CALCULAR_ESTRUCTURA WHERE idProducto = @idProd and idcathijo in (3,4)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idProd", idProd);
            

            try
            {
                //conexion.Open();
                cmd.Connection = conec;
                cmd.Transaction = tran;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
               

                productos.Load(cmd.ExecuteReader());

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
                //conexion.Close();
            }


            return productos;

        }
        public static DataTable  GetProductoIntermedio(int idProd, SqlConnection con, SqlTransaction tran)
        {
           

            DataTable productosInt = new DataTable();

            string sql = "SELECT idProducto,idProductohijo, nombrehijo,  cantidad, tiempoproduccion, cantidadproductos FROM CALCULAR_ESTRUCTURA WHERE idProducto = @idProd and idcathijo in (2)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idProd", idProd);
           

            try
            {
                
                cmd.Connection = con;
                cmd.Transaction = tran;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                productosInt.Load(cmd.ExecuteReader());

               
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


            return productosInt;

        }

        public static Boolean MPConPocoStock(int prod, SqlConnection con, SqlTransaction trans)
        {
            Boolean hayPocoStock = false;


            return hayPocoStock;
        }
        public static void actualizarStockMateriasPrimas(int idMateriaPrima, double cantidad, SqlConnection con, SqlTransaction trans)
        {
            

            string sql = "UPDATE Producto SET stockDisponible = (stockDisponible - @cantidad), stockReservado = (stockReservado + @cantidad) where idProducto = @idMateriaPrima";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idMateriaPrima", idMateriaPrima);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);

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
        public static void sumarStockMateriasPrimas(int idMateriaPrima, double cantidad)
        {
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            string sql = "UPDATE Producto SET stockDisponible = (stockDisponible + @cantidad), stockActual = (stockActual + @cantidad) where idProducto = @idMateriaPrima";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idMateriaPrima", idMateriaPrima);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);

            try
            {

                conexion.Open();
                cmd.Connection = conexion;
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

        public static void sumarStockMateriasPrimas(object p, double p_2)
        {
            throw new NotImplementedException();
        }
    }
}
