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
   
   
    public  class OrdenDeCompraDAO
    {
        public static  DataTable GetAllEmitir(int idOrden)
        {
            Acceso ac = new Acceso();

            DataTable orden = new DataTable();

            string sql = "SELECT EMITIR_ORDEN_DE_COMPRA.* FROM EMITIR_ORDEN_DE_COMPRA  where idOrden = @idOrden ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idOrden", idOrden);

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                orden.Load(cmd.ExecuteReader());

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


            return orden;

        }
        public static void UpdateEstadoOrdenCompra(OrdenDeCompra  ord)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());


            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[OrdenDeCompra] SET [idEstado] = @idEstado, [montoReal] = @montoReal WHERE idOrden = @idOrden", conexion);


            cmd.Parameters.AddWithValue("@idOrden", ord.idOrdenCompra );
            cmd.Parameters.AddWithValue("@idEstado", ord.estado.idEstado );
            cmd.Parameters.AddWithValue("@montoReal", ord.montoReal );
           

            try
            {
                conexion.Open();

                cmd.Connection = conexion;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                
                foreach (DetalleOrdenCompra det in ord.detalleOrdenCompra)
                {

                    DetalleOrdenCompraDAO.UpdateCantidadIngresadaReal(det, ord.idOrdenCompra, conexion, tran);

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
            finally
            {
                conexion.Close();
            }
        }
        public static void UpdateOrdenCompraPagada(int idord)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[OrdenDeCompra] SET [idEstado] = 33 , [fechaPago] = @fechaPago   WHERE idOrden = @idOrden", conexion);

            cmd.Parameters.AddWithValue("@fechaPago", DateTime.Now.Date );
            cmd.Parameters.AddWithValue("@idOrden", idord);
         
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
        public static List<OrdenDeCompra > GetByFiltros(double? montoDesde, double? mostoHasta, string nom, string ape, string raSoc, int? cuit, DateTime? fdesde, DateTime? fhasta)
        {
            Acceso ac = new Acceso();

            List<OrdenDeCompra> ordenCompra = new List<OrdenDeCompra>();

            string sql = "SELECT * from CONSULTAR_ORDEN_COMPRA where 1=1";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
                       
           
            if (montoDesde.HasValue)
            {
                sql += " and monto >= @montoDesde";
                cmd.Parameters.AddWithValue("@montoDesde", montoDesde);

            }
            if (mostoHasta.HasValue)
            {
                sql += " and monto <= @mostoHasta";
                cmd.Parameters.AddWithValue("@mostoHasta", mostoHasta);

            }
            if (!string.IsNullOrEmpty(ape))
            {
                sql += " and apellido like @apellido";
                cmd.Parameters.AddWithValue("@apellido", ape + "%");
            }
            if (!string.IsNullOrEmpty(nom))
            {
                sql += " and nombre like @nombre";
                cmd.Parameters.AddWithValue("@nombre", nom + "%");
            }
            if (!string.IsNullOrEmpty(raSoc))
            {
                sql += " and razonSocial like @raSoc";
                cmd.Parameters.AddWithValue("@raSoc", raSoc + "%");
            }
            if (cuit.HasValue)
            {
                sql += " and CUIT = @cuit";
                cmd.Parameters.AddWithValue("@cuit", cuit);

            }
            if (fdesde.HasValue)
            {
                sql += " and fechaOrden >= @fdesde";
                cmd.Parameters.AddWithValue("@fdesde", fdesde.Value);
            }
            if (fhasta.HasValue)
            {
                sql += " and fechaOrden <= @fhasta";
                cmd.Parameters.AddWithValue("@fhasta", fhasta.Value);
            }
         

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Persona c;
                OrdenDeCompra o;
                Estado e;

                while (dr.Read())
                {
                    e = new Estado();
                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre =  dr["estado"].ToString();
                    c = new Persona();

                    c.idPersona = Convert.ToInt32(dr["idProveedor"]);
                    c.RazonSocial = dr["razonSocial"].ToString();
                    c.Nombre = dr["nombre"].ToString();
                    c.Apellido = dr["apellido"].ToString();
                    c.cuil = dr["CUIT"].ToString();
                    c.calle = dr["calle"].ToString();
                    c.calle_nro = Convert.ToInt32(dr["nro"]);
                    c.mail = dr["email"].ToString();
                    c.telefono = dr["telefonocontacto"].ToString();
                    o = new OrdenDeCompra();
                    o.idOrdenCompra = Convert.ToInt32(dr["idOrden"]);
                    o.fechaOrden = Convert.ToDateTime(dr["fechaOrden"]);
                    o.proveedor = c;
                    o.monto = Convert.ToDouble(dr["monto"]);
                    o.fechaRemito = Convert.ToDateTime(dr["fechaRemito"]);
                    o.estado = e;
                    o.fechaPago =  Convert.ToDateTime(dr["fechaPago"]);
                    ordenCompra.Add(o);

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


            return ordenCompra;

        }
        public static List<OrdenDeCompra > GetAll()
        {
            Acceso ac = new Acceso();

            List<OrdenDeCompra> ordenCompra = new List<OrdenDeCompra>();

            string sql = "SELECT * from CONSULTAR_ORDEN_COMPRA order by fechaOrden desc";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

              
                Persona c;
                OrdenDeCompra o;
                Estado e;
                while (dr.Read())
                {
                    e = new Estado();
                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["estado"].ToString();
                    c = new Persona();

                    c.idPersona = Convert.ToInt32(dr["idProveedor"]);
                    c.RazonSocial = dr["razonSocial"].ToString();
                    c.Nombre = dr["nombre"].ToString();
                    c.Apellido = dr["apellido"].ToString();
                    c.cuil = dr["CUIT"].ToString();
                    c.calle = dr["calle"].ToString();
                    c.calle_nro = Convert.ToInt32(dr["nro"]);
                    c.mail = dr["email"].ToString();
                    c.telefono = dr["telefonocontacto"].ToString();
                    o = new OrdenDeCompra();
                    o.idOrdenCompra = Convert.ToInt32(dr["idOrden"]);
                    o.fechaOrden = Convert.ToDateTime(dr["fechaOrden"]);
                    o.proveedor = c;
                    o.monto = Convert.ToDouble(dr["monto"]);
                    o.fechaRemito = Convert.ToDateTime(dr["fechaRemito"]);
                    o.estado = e;
                    o.fechaPago = Convert.ToDateTime(dr["fechaPago"]);
                    ordenCompra.Add(o);

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


            return ordenCompra;

        }
        public static List<OrdenDeCompra> GetAllOrdenCompraIngresada()
        {
            Acceso ac = new Acceso();

            List<OrdenDeCompra> ordenCompra = new List<OrdenDeCompra>();

            string sql = "SELECT * from CONSULTAR_ORDEN_COMPRAR_INGRESADA";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();


                Persona c;
                OrdenDeCompra o;
                Estado e;
                while (dr.Read())
                {
                    e = new Estado();
                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["estado"].ToString();
                    c = new Persona();

                    c.idPersona = Convert.ToInt32(dr["idProveedor"]);
                    c.RazonSocial = dr["razonSocial"].ToString();
                    c.Nombre = dr["nombre"].ToString();
                    c.Apellido = dr["apellido"].ToString();
                    c.cuil = dr["CUIT"].ToString();
                    c.calle = dr["calle"].ToString();
                    c.calle_nro = Convert.ToInt32(dr["nro"]);
                    c.mail = dr["email"].ToString();
                    c.telefono = dr["telefonocontacto"].ToString();
                    o = new OrdenDeCompra();
                    o.idOrdenCompra = Convert.ToInt32(dr["idOrden"]);
                    o.fechaOrden = Convert.ToDateTime(dr["fechaOrden"]);
                    o.proveedor = c;
                    o.monto = Convert.ToDouble(dr["monto"]);
                    o.fechaRemito = Convert.ToDateTime(dr["fechaRemito"]);
                    o.estado = e;
                    o.montoReal = Convert.ToDouble(dr["montototalreal"]);
                    o.fechaPago = Convert.ToDateTime(dr["fechaPago"]);
                    ordenCompra.Add(o);

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


            return ordenCompra;

        }
        public static int Insert(OrdenDeCompra  ord)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("ps_insertar_orden_de_compra", conexion);

            cmd.Parameters.AddWithValue("@fechaOrden", ord.fechaOrden );
            cmd.Parameters.AddWithValue("@idProveedor", ord.proveedor.idPersona );
            cmd.Parameters.AddWithValue("@monto", ord.monto );
            //cmd.Parameters.AddWithValue("@fechaRemito", ord.fechaRemito );
          


            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();

                SqlCommand cmdIdentity = new SqlCommand("select @@Identity", conexion, tran);
                ord.idOrdenCompra  = Convert.ToInt32((cmdIdentity.ExecuteScalar()));

                foreach (DetalleOrdenCompra  detPed in ord.detalleOrdenCompra )
                {
                    DetalleOrdenCompraDAO.Insert(detPed, conexion, tran, ord.idOrdenCompra);
                }
                tran.Commit();
                return ord.idOrdenCompra;

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

    }
}