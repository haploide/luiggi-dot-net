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
    public  class SingletonNumeroPedidoDAO
    {
        private static SingletonNumeroPedidoDAO instancia;
        private int numeroPedido;

        private SingletonNumeroPedidoDAO() { }


        public static SingletonNumeroPedidoDAO GetInstacia()
        {

            if (instancia == null)
            {
                instancia = new SingletonNumeroPedidoDAO();
            }
            return instancia;

        }
        public int getNumeroPedido()
        {
             Acceso ac = new Acceso();

          
            string sql = "SELECT MAX(nroPedido) AS nPedido FROM Pedido";
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
                   numeroPedido = Convert.ToInt32(dr["nPedido"]);
                  
                }
                else
                {
                    numeroPedido = 1;
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


            return ++numeroPedido;

        
            

        }
        public void actualizarCodigoProducto()
        {
            numeroPedido++;
        }
    }
}
