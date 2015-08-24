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
    public  class SingletonNumeroProveedorDAO
    {
        private static SingletonNumeroProveedorDAO instancia;
        private int numeroProveedor;

        private SingletonNumeroProveedorDAO() { }


        public static SingletonNumeroProveedorDAO GetInstacia()
        {

            if (instancia == null)
            {
                instancia = new SingletonNumeroProveedorDAO();
            }
            return instancia;

        }
        public int getNumeroCliente()
        {
             Acceso ac = new Acceso();


             string sql = "SELECT MAX(nroProveedor) AS nCli FROM Persona";
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
                    numeroProveedor = Convert.ToInt32(dr["nCli"]);

                }
                else
                {
                    numeroProveedor = 1;
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


            return ++numeroProveedor;

        
            

        }
        public void actualizarCodigoProducto()
        {
            numeroProveedor++;
        }

    }
}
