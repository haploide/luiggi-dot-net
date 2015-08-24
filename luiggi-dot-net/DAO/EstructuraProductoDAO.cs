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
    public class EstructuraProductoDAO
    {
        public static List<Producto> GetAll()
        {
            Acceso ac = new Acceso();

            List<Producto> productos = new List<Producto>();

            string sql = "SELECT codProducto, nombre, descripcion, precio, categoria, unidad, stockDeRiesgo, idCategoria, descCat, idUnidad, descUni, idProducto, idTipoMaquinaria, tipoMaquinaria from CONSULTA_PRODUCTOS where idCategoria = 1 OR idCategoria = 2";
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
                TipoMaquinaria TM;

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

                    TM = new TipoMaquinaria();

                    TM.idTipoMaquinaria = Convert.ToInt32(dr["idTipoMaquinaria"].ToString());
                    TM.Nombre = dr["tipoMaquinaria"].ToString();

                    p = new Producto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["nombre"].ToString();
                    p.Categoria = c;
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Unidad = u;
                    p.StockRiesgo = Convert.ToInt32(dr["stockDeRiesgo"]);
                    p.precio = Convert.ToDouble(dr["precio"]);
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                    p.tipoMaquina = TM;

                    //p.foto = (Image)(dr["foto"]);

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
        public static List<DetalleProducto> GetAll(int id)
        {
            Acceso ac = new Acceso();

            List<DetalleProducto> productos = new List<DetalleProducto>();

            string sql = "SELECT idProducto, idProductoDetalle, ProductoDetalle, cantidad, Producto, idCategoria, categoria, descCategoria, idUnidad, unidad, descUnidad, codProducto, idUnidadTiempo, UnidadTiempo, descUnidadTiempo, cantidadProductos, tiempoProduccion, tipoMaquinaria, idTipoMaquinaria  from CONSULTA_ESTRUCTURA_PRODUCTOS where idProducto =" + id;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                DetalleProducto p;
                Categoria c;
                UnidadMedida u;
                UnidadMedida uT;
                TipoMaquinaria TM;

                while (dr.Read())
                {
                    u = new UnidadMedida();

                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["unidad"].ToString();
                    u.Descripcion = dr["descUnidad"].ToString();


                    c = new Categoria();
                    c.IDCategoria = Convert.ToInt32(dr["idCategoria"]);
                    c.Nombre = dr["categoria"].ToString();
                    c.Descripcion = dr["descCategoria"].ToString();

                    uT = new UnidadMedida();
                    uT.IDUnidad = Convert.ToInt32(dr["idUnidadTiempo"]);
                    uT.Nombre = dr["unidadTiempo"].ToString();
                    uT.Descripcion = dr["descUnidadTiempo"].ToString();

                    TM = new TipoMaquinaria();

                    TM.idTipoMaquinaria = Convert.ToInt32(dr["idTipoMaquinaria"].ToString());
                    TM.Nombre = dr["tipoMaquinaria"].ToString();

                    p = new DetalleProducto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["ProductoDetalle"].ToString();
                    p.Categoria = c;
                    p.Unidad = u;
                    p.cantidad = double.Parse(dr["cantidad"].ToString());
                    p.idProducto = Convert.ToInt32(dr["idProductoDetalle"]);
                    p.idProductoPadre = Convert.ToInt32(dr["idProducto"]);
                    p.tiempoProduccion = double.Parse(dr["tiempoProduccion"].ToString());
                    p.cantidadProductos = double.Parse(dr["cantidadProductos"].ToString());
                    p.UnidadTiempo = uT;
                    p.TipoMaquinaria = TM;
                    
                    
                    

                    //p.foto = (Image)(dr["foto"]);

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
        public static List<DetalleProducto> GetAllInsumosDeProductoFinal(int id,SqlTransaction tran, SqlConnection con)
        {
            Acceso ac = new Acceso();

            List<DetalleProducto> productos = new List<DetalleProducto>();

            string sql = "SELECT idProducto, idProductoDetalle, ProductoDetalle, cantidad, Producto, idCategoria, categoria, descCategoria, idUnidad, unidad, descUnidad, codProducto, idUnidadTiempo, UnidadTiempo, descUnidadTiempo, cantidadProductos, tiempoProduccion, tipoMaquinaria, idTipoMaquinaria  from CONSULTA_ESTRUCTURA_PRODUCTOS where idcategoria = 4 and idProducto =" + id ;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {

                cmd.Connection = con;
                cmd.Transaction  = tran;
                
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                DetalleProducto p;
                Categoria c;
                UnidadMedida u;
                UnidadMedida uT;
                TipoMaquinaria TM;

                while (dr.Read())
                {
                    u = new UnidadMedida();

                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["unidad"].ToString();
                    u.Descripcion = dr["descUnidad"].ToString();


                    c = new Categoria();
                    c.IDCategoria = Convert.ToInt32(dr["idCategoria"]);
                    c.Nombre = dr["categoria"].ToString();
                    c.Descripcion = dr["descCategoria"].ToString();

                    uT = new UnidadMedida();
                    uT.IDUnidad = Convert.ToInt32(dr["idUnidadTiempo"]);
                    uT.Nombre = dr["unidadTiempo"].ToString();
                    uT.Descripcion = dr["descUnidadTiempo"].ToString();

                    TM = new TipoMaquinaria();

                    TM.idTipoMaquinaria = Convert.ToInt32(dr["idTipoMaquinaria"].ToString());
                    TM.Nombre = dr["tipoMaquinaria"].ToString();

                    p = new DetalleProducto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["ProductoDetalle"].ToString();
                    p.Categoria = c;
                    p.Unidad = u;
                    p.cantidad = double.Parse(dr["cantidad"].ToString());
                    p.idProducto = Convert.ToInt32(dr["idProductoDetalle"]);
                    p.idProductoPadre = Convert.ToInt32(dr["idProducto"]);
                    p.tiempoProduccion = double.Parse(dr["tiempoProduccion"].ToString());
                    p.cantidadProductos = double.Parse(dr["cantidadProductos"].ToString());
                    p.UnidadTiempo = uT;
                    p.TipoMaquinaria = TM;




                    //p.foto = (Image)(dr["foto"]);
                    
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
            finally
            {
               
            }


            return productos;

        }
        public static List<Producto> GetAllSinEstructura()
        {
            Acceso ac = new Acceso();

            List<Producto> productos = new List<Producto>();

            string sql = "SELECT codProducto, nombre, descripcion, precio, categoria, unidad, stockDeRiesgo, idCategoria, descCat, idUnidad, descUni, idProducto, idTipoMaquinaria, tipoMaquinaria from CONSULTA_PRODUCTOS P where (idCategoria = 1 OR idCategoria = 2) AND NOT EXISTS (Select 1 From CONSULTA_ESTRUCTURA_PRODUCTOS C where C.idProducto = P.idProducto)";
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
                TipoMaquinaria TM;

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

                    TM = new TipoMaquinaria();

                    TM.idTipoMaquinaria = Convert.ToInt32(dr["idTipoMaquinaria"].ToString());
                    TM.Nombre = dr["tipoMaquinaria"].ToString();

                    p = new Producto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["nombre"].ToString();
                    p.Categoria = c;
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Unidad = u;
                    p.StockRiesgo = Convert.ToInt32(dr["stockDeRiesgo"]);
                    p.precio = Convert.ToDouble(dr["precio"]);
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                    p.tipoMaquina = TM;

                    //p.foto = (Image)(dr["foto"]);

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
        public static List<Producto> GetAllConEstructura()
        {
            Acceso ac = new Acceso();

            List<Producto> productos = new List<Producto>();

            string sql = "SELECT codProducto, nombre, descripcion, precio, categoria, unidad, stockDeRiesgo, idCategoria, descCat, idUnidad, descUni, idProducto, tipoMaquinaria, idTipoMaquinaria from CONSULTA_PRODUCTOS P where (idCategoria = 1 OR idCategoria = 2) AND EXISTS (Select 1 From CONSULTA_ESTRUCTURA_PRODUCTOS C where C.idProducto = P.idProducto)";
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
                TipoMaquinaria TM;

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

                    TM = new TipoMaquinaria();

                    TM.idTipoMaquinaria = Convert.ToInt32(dr["idTipoMaquinaria"].ToString());
                    TM.Nombre = dr["tipoMaquinaria"].ToString();

                    p = new Producto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["nombre"].ToString();
                    p.Categoria = c;
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Unidad = u;
                    p.StockRiesgo = Convert.ToInt32(dr["stockDeRiesgo"]);
                    p.precio = Convert.ToDouble(dr["precio"]);
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                    p.tipoMaquina = TM;

                    //p.foto = (Image)(dr["foto"]);

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
        public static List<Producto> GetAllProdAAgregar()
        {
            Acceso ac = new Acceso();

            List<Producto> productos = new List<Producto>();

            string sql = "SELECT codProducto, nombre, descripcion, precio, categoria, unidad, stockDeRiesgo, idCategoria, descCat, idUnidad, descUni, idProducto, cantidadProductos, tiempoProduccion, unidadTiempo, idUnidadTiempo, descUnidadTiempo, idTipoMaquinaria, tipoMaquinaria from CONSULTA_PRODUCTOS where idCategoria <> 1";
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
                UnidadMedida uT;
                TipoMaquinaria TM;

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

                   
                    uT = new UnidadMedida();

                    uT.IDUnidad = Convert.ToInt32(dr["idUnidadTiempo"]);
                    uT.Nombre = dr["unidadTiempo"].ToString();
                    uT.Descripcion = dr["descUnidadTiempo"].ToString();

                    TM = new TipoMaquinaria();

                    TM.idTipoMaquinaria = Convert.ToInt32(dr["idTipoMaquinaria"].ToString());
                    TM.Nombre = dr["tipoMaquinaria"].ToString();

                    p = new Producto();

                    p.CODProducto = Convert.ToInt32(dr["codProducto"]);
                    p.Nombre = dr["nombre"].ToString();
                    p.Categoria = c;
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Unidad = u;
                    p.StockRiesgo = Convert.ToInt32(dr["stockDeRiesgo"]);
                    p.precio = Convert.ToDouble(dr["precio"]);
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                    p.UnidadTiempo = uT;
                    p.cantidadProductos = double.Parse(dr["cantidadProductos"].ToString());
                    p.tiempoProduccion = double.Parse(dr["tiempoProduccion"].ToString());
                    p.tipoMaquina = TM;


                    //p.foto = (Image)(dr["foto"]);

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
        public static void Insert(List<DetalleProducto> detProd)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd;
            
            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                foreach (DetalleProducto detP in detProd)
                {
                    //detPed.pedido.idPedido = ped.idPedido;
                    EstructuraProductoDAO.Insert(detP, conexion, tran);
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
        public static void Update(List<DetalleProducto> detProd, int idProducto)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd;

            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                //SqlCommand cmdIdentity = new SqlCommand("select @@Identity", conexion, tran);
                //ped.idPedido = Convert.ToInt32((cmdIdentity.ExecuteScalar()));
                EstructuraProductoDAO.Delete(idProducto);

                foreach (DetalleProducto detPed in detProd)
                {
                    //detPed.pedido.idPedido = ped.idPedido;
                    EstructuraProductoDAO.Insert(detPed, conexion, tran);
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
        public static void Delete(int idProducto)
        {
            Acceso ac = new Acceso();

            string sql = "DELETE FROM DetalleProducto WHERE idProducto = " + idProducto;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand(sql, conexion);

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
        public static void Insert(DetalleProducto det, SqlConnection cn, SqlTransaction tran)
        {
            Acceso ac = new Acceso();


            //SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("Insert into DetalleProducto (idProducto, idProductoDetalle, cantidad) VALUES (@idprodpadre,@idprod,@cantida)", cn);

            cmd.Parameters.AddWithValue("@idprodpadre", det.idProductoPadre);
            cmd.Parameters.AddWithValue("@idprod", det.idProducto);
            cmd.Parameters.AddWithValue("@cantida", det.cantidad);
            
            try
            {
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

        }
    }
}
