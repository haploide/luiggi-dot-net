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
    public class FacturaDAO
    {
        public static int getUltimoNumeroFactura()
        {
            Acceso ac = new Acceso();

            int nroFactura; 
            string sql = "SELECT MAX(idFactura) AS cod FROM Factura";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    nroFactura = Convert.ToInt32(dr["cod"]);

                }
                else
                {
                    nroFactura = 1;
                }

            }
            catch (InvalidCastException ex)
            {
                return 1;
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


            return ++nroFactura;

        }
        public static int Insert(Factura fac, List<DetalleFactura> detalleAgregado)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_Insertar_factura", conexion);

            cmd.Parameters.AddWithValue("@fecha", fac.fechaCreacion );
            cmd.Parameters.AddWithValue("@idEstado", fac.estado.idEstado);
            cmd.Parameters.AddWithValue("@idCliente", fac.cliente.idPersona );
            cmd.Parameters.AddWithValue("@idPedido", fac.pedido.idPedido );
            cmd.Parameters.AddWithValue("@importe", fac.importeTotal );
            cmd.Parameters.AddWithValue("@fechaPago", fac.fechaCreacion);
            cmd.Parameters.AddWithValue("@tipoFactura", fac.tipoFactura );
            cmd.Parameters.AddWithValue("@numeroFactura", fac.numeroFactura );
            cmd.Parameters.AddWithValue("@totalIVA", fac.totalIVA );
            cmd.Parameters.AddWithValue("@montoSinImpuesto", fac.montoSinImpuesto );

            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();

                SqlCommand cmdIdentity = new SqlCommand("select @@Identity", conexion, tran);
                fac.idFactura  = Convert.ToInt32((cmdIdentity.ExecuteScalar()));

                foreach (DetalleFactura  detfac in fac.detalleFactura )
                {
                    //detPed.pedido.idPedido = ped.idPedido;
                    DetalleFacturaDAO.Insert(detfac, conexion, tran, fac.idFactura);
                    
                }
                if (detalleAgregado!=null)
                {
                    foreach (DetalleFactura detagre in detalleAgregado)//descontar los agregados
                    {

                        ProductoDAO.UpdateStockActualYDisponible(detagre, conexion, tran);

                    } 
                }
                tran.Commit();
                return fac.idFactura ;

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
        public static int InsertFacturaDirecta(Factura fac)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_Insertar_factura", conexion);

            cmd.Parameters.AddWithValue("@fecha", fac.fechaCreacion);
            cmd.Parameters.AddWithValue("@idEstado", fac.estado.idEstado);
            cmd.Parameters.AddWithValue("@idCliente", fac.cliente.idPersona);
            //cmd.Parameters.AddWithValue("@idPedido", fac.pedido.idPedido);
            cmd.Parameters.AddWithValue("@importe", fac.importeTotal);
            //cmd.Parameters.AddWithValue("@fechaPago", fac.fechaPago );
            cmd.Parameters.AddWithValue("@tipoFactura", fac.tipoFactura);
            //cmd.Parameters.AddWithValue("@numeroFactura", fac.numeroFactura);
            cmd.Parameters.AddWithValue("@totalIVA", fac.totalIVA);
            //cmd.Parameters.AddWithValue("@montoSinImpuesto", fac.montoSinImpuesto);
            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();

                SqlCommand cmdIdentity = new SqlCommand("select @@Identity", conexion, tran);
                fac.idFactura = Convert.ToInt32((cmdIdentity.ExecuteScalar()));

                foreach (DetalleFactura detfac in fac.detalleFactura)
                {
                    //detPed.pedido.idPedido = ped.idPedido;
                    DetalleFacturaDAO.InsertDetalleFacturaDirecta(detfac, conexion, tran, fac.idFactura);
                    ProductoDAO.UpdateStockActualYDisponible(detfac, conexion, tran);
                }
                tran.Commit();
                return fac.idFactura;

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
        public static DataTable GetAllEmitir(int idFactura)
        {
            Acceso ac = new Acceso();

            DataTable factura = new DataTable();

            string sql = "SELECT EMITIR_FACTURA.* FROM EMITIR_FACTURA  where idFactura=@idFactura ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idFactura", idFactura);
            
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                factura.Load(cmd.ExecuteReader());

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


            return factura;

        }
        public static List<Factura> GetAll()
        {
            Acceso ac = new Acceso();

            List<Factura> facturas = new List<Factura>();

            string sql = "SELECT * from CONSULTAR_FACTURA order by fecha desc";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Factura factura;
                Estado estado;
                Persona cliente;
                

                while (dr.Read())
                {
                    cliente = new Persona();

                    cliente.RazonSocial = dr["razonSocial"].ToString();
                    cliente.Nombre = dr["nombre"].ToString();
                    cliente.Apellido = dr["apellido"].ToString();


                    estado = new Estado();

                    estado.idEstado = Convert.ToInt32(dr["idEstado"]);
                    estado.Nombre = dr["estado"].ToString();

                    factura = new Factura();

                    factura.cliente = cliente;
                    factura.estado = estado;
                    factura.fechaCreacion = Convert.ToDateTime(dr["fecha"]);
                    factura.fechaPago = Convert.ToDateTime(dr["fechaPago"]);
                    factura.idFactura = Convert.ToInt32(dr["idFactura"]);
                    factura.importeTotal = Convert.ToDouble(dr["importe"]);
                    factura.tipoFactura = Convert.ToChar(dr["tipoFactura"].ToString());
                    factura.totalIVA = Convert.ToDouble(dr["totalIVA"]);

                    facturas.Add(factura);

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


            return facturas;

        }
        public static List<Factura> GetByFiltros(int est, int tipDoc, int? nroDoc, double? montoDesde, double? mostoHasta, string nom, string ape, string raSoc, int? cuit, DateTime? fdesde,DateTime? fhasta, char tipoFac, int index)
        {
            Acceso ac = new Acceso();

            List<Factura> facturas = new List<Factura>();

            string sql = "SELECT * from CONSULTAR_FACTURA where 1=1";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            if (est != -1 && est != 0)
            {
                sql += " and idEstado = @est";
                cmd.Parameters.AddWithValue("@est", est);
            }
            if (tipDoc != -1 && tipDoc != 0)
            {
                sql += " and idTipoDoc = @tipDoc";
                cmd.Parameters.AddWithValue("@tipDoc", tipDoc);
            }
            if (nroDoc.HasValue)
            {
                sql += " and nroDocumento = @nroDoc";
                cmd.Parameters.AddWithValue("@nroDoc", nroDoc);

            }
            if (montoDesde.HasValue)
            {
                sql += " and total >= @montoDesde";
                cmd.Parameters.AddWithValue("@montoDesde", montoDesde);

            }
            if (mostoHasta.HasValue)
            {
                sql += " and total <= @mostoHasta";
                cmd.Parameters.AddWithValue("@mostoHasta", mostoHasta);

            }
            if (!string.IsNullOrEmpty(ape))
            {
                sql += " and apellido like @apellido";
                cmd.Parameters.AddWithValue("@apellido", ape+"%");
            }
            if (!string.IsNullOrEmpty(nom))
            {
                sql += " and nombre like @nombre";
                cmd.Parameters.AddWithValue("@nombre", nom+"%");
            }
            if (!string.IsNullOrEmpty(raSoc))
            {
                sql += " and razonSocial like @raSoc";
                cmd.Parameters.AddWithValue("@raSoc", raSoc+"%");
            }
            if (cuit.HasValue)
            {
                sql += " and CUIT = @cuit";
                cmd.Parameters.AddWithValue("@cuit", cuit);

            }
            if (fdesde.HasValue)
            {
                sql += " and fechaNecesidad >= @fdesde";
                cmd.Parameters.AddWithValue("@fdesde", fdesde.Value);
            }
            if (fhasta.HasValue)
            {
                sql += " and fechaNecesidad <= @fhasta";
                cmd.Parameters.AddWithValue("@fhasta", fhasta.Value);
            }
            if (index != 3)
            {
                sql += " and tipoFactura = @tipo";
                cmd.Parameters.AddWithValue("@tipo", tipoFac);
            }

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Factura factura;
                Estado estado;
                Persona cliente;
                

                while (dr.Read())
                {
                    cliente = new Persona();

                    cliente.RazonSocial = dr["razonSocial"].ToString();
                    cliente.Nombre = dr["nombre"].ToString();
                    cliente.Apellido = dr["apellido"].ToString();


                    estado = new Estado();

                    estado.idEstado = Convert.ToInt32(dr["idEstado"]);
                    estado.Nombre = dr["estado"].ToString();

                    factura = new Factura();

                    factura.cliente = cliente;
                    factura.estado = estado;
                    factura.fechaCreacion = Convert.ToDateTime(dr["fecha"]);
                    factura.fechaPago = Convert.ToDateTime(dr["fechaPago"]);
                    factura.idFactura = Convert.ToInt32(dr["idFactura"]);
                    factura.importeTotal = Convert.ToDouble(dr["importe"]);
                    factura.tipoFactura = Convert.ToChar(dr["tipoFactura"].ToString());
                    factura.totalIVA = Convert.ToDouble(dr["totalIVA"]);

                    facturas.Add(factura);

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


            return facturas;

        }
        public static Boolean GetFacturasPagadas(int idPedido)
        {
            Acceso ac = new Acceso();

            List<Factura> facturas = new List<Factura>();

            string sql = "SELECT * from CONSULTAR_FACTURA where idPedido=@pedido and idEstado=28";
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@pedido", idPedido);

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                return dr.Read();

                
                

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
        public static void UpdateEstado(int idFactura, int idEstado, DateTime fechaPago)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Factura] SET [idEstado] = @idEstado, [fechaPago] = @fechaPago WHERE idFactura = @idFctura", conexion);

            cmd.Parameters.AddWithValue("@idFctura", idFactura);
            cmd.Parameters.AddWithValue("@idEstado", idEstado);
            cmd.Parameters.AddWithValue("@fechaPago", fechaPago);


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
