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
    public  class ProductoXProveedorDAO
    {
        public static List <ProductoXProveedor > GetByIdProd(int idProv)
        {
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            List <ProductoXProveedor >  productos = new List <ProductoXProveedor > ();
            SqlCommand cmd = new SqlCommand();
            string sql = "Select * From CONSULTAR_PRODUCTOS_X_PROVEEDOR where idProveedor = @idProv";
            cmd.Parameters.AddWithValue("@idProv", idProv);
            Persona pr;
            Producto p;
            UnidadMedida u;
            ProductoXProveedor pp;
            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text ;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    pr = new Persona();
                    pr.Apellido = dr["apellido"].ToString();
                    pr.Nombre = dr["nombreRepresentante"].ToString();
                    pr.telefono = dr["telefonoContacto"].ToString();
                    pr.mail=  dr["email"].ToString();
                    pp = new ProductoXProveedor();
                    //u.IDUnidad = Convert.ToInt32(dr["idunidad"]);
                    u = new UnidadMedida();
                    p = new Producto();
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                    p.Unidad = new UnidadMedida() { Nombre = dr["unidad"].ToString() };
                    p.Nombre = dr["nombre"].ToString() ;
                    p.Descripcion = dr["descripcion"].ToString();
                    p.StockActual = Convert.ToDouble(dr["stockActual"]);
                    p.StockDisponible  = Convert.ToDouble(dr["stockDisponible"]);
                    p.StockReservado = Convert.ToDouble(dr["StockReservado"]);
                    p.StockRiesgo = Convert.ToDouble(dr["StockdeRiesgo"]);
                   
                    
                    pp.producto = p;
                    pp.fechaPrecio = Convert.ToDateTime (dr["fecha"]);
                    pp.precioProveedor = Convert.ToDouble(dr["precio"]);
                    pp.proveedor = pr;
                    productos.Add(pp);

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

        public static Boolean sePuedeInsertar(int idPers, int idProd)
        {
            DataTable tabla = new DataTable();
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand();
            string sql = "Select * from CONSULTAR_PRODUCTOS_X_PROVEEDOR where idProveedor = @idPers and idProducto = @idProd";
            cmd.Parameters.AddWithValue("@idPers", idPers);
            cmd.Parameters.AddWithValue("@idProd", idProd);
            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                return !dr.HasRows;
                
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
        }

        public static List<ProductoXProveedor> buscarProductosXProveedor()
        {
            Acceso ac = new Acceso();

            List<ProductoXProveedor> productos = new List<ProductoXProveedor>();

            string sql = "SELECT idProveedor, idProducto, fecha, precio, nombre, descripcion, stockDisponible, stockDeRiesgo, stockActual, stockReservado, unidad, idUnidad, razonSocial, CUIT, nombreRepresentante, apellido, email, telefonoContacto, idCategoria from CONSULTAR_PRODUCTOS_X_PROVEEDOR order by nombre asc";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Producto prod;
                Persona prov;
                Categoria c;
                UnidadMedida u;
                ProductoXProveedor PPP;

                while (dr.Read())
                {
                    u = new UnidadMedida();
                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["unidad"].ToString();

                    prod = new Producto();

                    prod.idProducto = Convert.ToInt32(dr["idProducto"]);
                    prod.Nombre = dr["nombre"].ToString();
                    prod.Descripcion = dr["descripcion"].ToString();
                    prod.Unidad = u;
                    prod.StockRiesgo = Convert.ToInt32(dr["stockDeRiesgo"]);
                    prod.StockDisponible = Convert.ToInt32(dr["stockDisponible"]);
                    prod.StockActual = Convert.ToInt32(dr["stockActual"]);
                    prod.StockReservado = Convert.ToInt32(dr["stockReservado"]);

                    prov = new Persona();

                    prov.NroProveedor = Convert.ToInt32(dr["idProveedor"]);
                    prov.RazonSocial = dr["razonSocial"].ToString();
                    prov.cuil = dr["CUIT"].ToString();
                    prov.Nombre = dr["nombreRepresentante"].ToString();
                    prov.Apellido = dr["apellido"].ToString();
                    prov.mail = dr["email"].ToString();
                    prov.telefono = dr["telefonoContacto"].ToString();
                    //prov.idPersona = Convert.ToInt32(dr["idPersona"]);

                    PPP = new ProductoXProveedor();

                    PPP.fechaPrecio = Convert.ToDateTime(dr["fecha"]);
                    PPP.precioProveedor = Convert.ToDouble(dr["precio"]);
                    PPP.producto = prod;
                    PPP.proveedor = prov;

                    productos.Add(PPP);
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
        public static void Insert(ProductoXProveedor prodXProv)
        {
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("Insert into ProductoXProveedor (idProveedor,idProducto,fecha,precio) values (@idPers,@idProd,@fecha,@precio)", conexion);

            cmd.Parameters.AddWithValue("@idPers", prodXProv.proveedor.idPersona);
            cmd.Parameters.AddWithValue("@idProd", prodXProv.producto.idProducto);
            cmd.Parameters.AddWithValue("@fecha", prodXProv.fechaPrecio.Date);
            cmd.Parameters.AddWithValue("@precio", prodXProv.precioProveedor);

            try
            {
                conexion.Open();

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
        public static void Delete(ProductoXProveedor prodXProv)
        {
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("DELETE ProductoXProveedor WHERE idProveedor = @idPers and idProducto = @idProd and fecha = @fecha", conexion);

            cmd.Parameters.AddWithValue("@idPers", prodXProv.proveedor.idPersona);
            cmd.Parameters.AddWithValue("@idProd", prodXProv.producto.idProducto);
            cmd.Parameters.AddWithValue("@fecha", prodXProv.fechaPrecio.Date);

            try
            {
                conexion.Open();

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

        public static void Update(ProductoXProveedor prodXProv, ProductoXProveedor prodXProvViejo)
        {
            Acceso ac = new Acceso();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("Update ProductoXProveedor SET idProveedor = @idPers ,idProducto = @idProd, fecha = @fecha, precio = @precio Where idProveedor = @idPers2 and idProducto = @idProd2 and fecha = @fecha2", conexion);

            cmd.Parameters.AddWithValue("@idPers", prodXProv.proveedor.idPersona);
            cmd.Parameters.AddWithValue("@idProd", prodXProv.producto.idProducto);
            cmd.Parameters.AddWithValue("@fecha", prodXProv.fechaPrecio.Date);
            cmd.Parameters.AddWithValue("@precio", prodXProv.precioProveedor);
            cmd.Parameters.AddWithValue("@idPers2", prodXProvViejo.proveedor.idPersona);
            cmd.Parameters.AddWithValue("@idProd2", prodXProvViejo.producto.idProducto);
            cmd.Parameters.AddWithValue("@fecha2", prodXProvViejo.fechaPrecio.Date);

            try
            {
                conexion.Open();

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
    }
}
