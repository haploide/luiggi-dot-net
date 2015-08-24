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
    public  class DetalleFacturaDAO
    {
        public static void Insert(DetalleFactura  det, SqlConnection cn, SqlTransaction tran, int idFac)
        {
            Acceso ac = new Acceso();


            //SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_Insertar_detalle_factura", cn);

            cmd.Parameters.AddWithValue("@idFactura", idFac);
            if ( det.producto != null )
            {
                cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto); 
            }
            if ( det.detPedido != null   )
            {
                cmd.Parameters.AddWithValue("@idPedido", det.detPedido.pedido.idPedido); 
            }
            cmd.Parameters.AddWithValue("@subtotal", det.subTotal ); // es el precio
            cmd.Parameters.AddWithValue("@cantidad", det.cantidad);
            if (det.detPedido != null)
            {
                cmd.Parameters.AddWithValue("@idProductoPedido", det.detPedido.producto.idProducto); 
            }
            cmd.Parameters.AddWithValue("@iva", det.iva );
            try
            {
                cmd.Connection = cn;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                //if (det.producto != null)
                //{
                //    ProductoDAO.UpdateStockActualYDisponible(det, cn, tran);
                //}
                
                if (det.detPedido != null)
                {
                    ProductoDAO.UpdateStockReservadoYActualdePedidoEntregado(det.detPedido, det.detPedido.pedido.idPedido, 7);
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
        public static List<DetalleFactura> GetDetalleFactura(int idFactura)
        {
            Acceso ac = new Acceso();

            List<DetalleFactura> detalles = new List<DetalleFactura>();

            string sql = "SELECT * from CONSULTAR_DETALLE_FACTURA where idFactura = @id";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@id", idFactura);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                DetalleFactura detalle;
                Producto producto;
                Producto productoPedido;
                UnidadMedida unidad;
                UnidadMedida unidadPedido;

                while (dr.Read())
                {
                    unidad = new UnidadMedida();
                    unidadPedido = new UnidadMedida();
                    
                    unidad.Nombre = dr["unidadProducto"].ToString();
                    unidadPedido.Nombre = dr["unidadProdPedido"].ToString();

                    producto = new Producto();
                    productoPedido = new Producto();
                                        
                    producto.Unidad = unidad;
                    producto.Nombre = dr["nombreProd"].ToString();
                    producto.idProducto = Convert.ToInt32(dr["idProducto"]);

                    productoPedido.Unidad = unidadPedido;
                    productoPedido.Nombre = dr["nombreProdPedido"].ToString();
                    productoPedido.idProducto = Convert.ToInt32(dr["idProductoPedido"]);

                    
                    detalle = new DetalleFactura();

                    detalle.cantidad = Convert.ToDouble(dr["cantidad"]);
                    detalle.producto = producto;
                    detalle.detPedido = new DetallePedido() { producto = productoPedido };
                    detalle.subTotal = Convert.ToDouble(dr["subtotal"]);
                    detalle.iva = Convert.ToDouble(dr["iva"]);
                    detalle.idDetalle = Convert.ToInt32(dr["idDetalleFactura"]);
                    


                    detalles.Add(detalle);
                    
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
        public static void InsertDetalleFacturaDirecta(DetalleFactura det, SqlConnection cn, SqlTransaction tran, int idFac)
        {
            Acceso ac = new Acceso();
            //SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand("sp_Insertar_detalle_factura", cn);
            cmd.Parameters.AddWithValue("@idFactura", idFac);
            if (det.producto != null)
            {
                cmd.Parameters.AddWithValue("@idProducto", det.producto.idProducto);
            }
            //if (det.detPedido.pedido.idPedido != null)
            //{
            //    cmd.Parameters.AddWithValue("@idPedido", det.detPedido.pedido.idPedido);
            //}
            cmd.Parameters.AddWithValue("@subtotal", det.subTotal); // es el precio
            cmd.Parameters.AddWithValue("@cantidad", det.cantidad);
            //if (det.detPedido.producto.idProducto != null)
            //{
            //    cmd.Parameters.AddWithValue("@idProductoPedido", det.detPedido.producto.idProducto);
            //}
            cmd.Parameters.AddWithValue("@iva", det.iva);
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
