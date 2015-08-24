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
    public class SingletonCodigoProductoDAO
    {
        private static SingletonCodigoProductoDAO instancia;
        private int codigoProducto;

        private SingletonCodigoProductoDAO() { }


        public static SingletonCodigoProductoDAO GetInstacia()
        {

            if (instancia == null)
            {
                instancia = new SingletonCodigoProductoDAO();
            }
            return instancia;

        }
        public int getCodigoProducto()
        {
             Acceso ac = new Acceso();

          
            string sql = "SELECT MAX(codProducto) AS cod FROM Producto";
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
                   codigoProducto = Convert.ToInt32(dr["cod"]);
                  
                }
                else
                {
                    codigoProducto = 1;
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


            return ++codigoProducto;

        
            

        }
        public void actualizarCodigoProducto()
        {
            codigoProducto++;
        }
    }
}
