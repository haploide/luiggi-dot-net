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
    public class SingletonNumeroClienteDAO
    {
        private static SingletonNumeroClienteDAO instancia;
        private int numeroCliente;

        private SingletonNumeroClienteDAO() { }


        public static SingletonNumeroClienteDAO GetInstacia()
        {

            if (instancia == null)
            {
                instancia = new SingletonNumeroClienteDAO();
            }
            return instancia;

        }
        public int getNumeroCliente()
        {
             Acceso ac = new Acceso();

          
            string sql = "SELECT MAX(nroCliente) AS nCli FROM Persona";
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
                    numeroCliente = Convert.ToInt32(dr["nCli"]);

                }
                else
                {
                    numeroCliente = 1;
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


            return ++numeroCliente ;

        
            

        }
        public void actualizarCodigoProducto()
        {
            numeroCliente ++;
        }
    }
}
