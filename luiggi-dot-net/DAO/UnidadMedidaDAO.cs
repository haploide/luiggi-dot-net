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
    public class UnidadMedidaDAO
    {
        public static List<UnidadMedida > GetAll()
        {
            Acceso ac = new Acceso();

            List<UnidadMedida> unidades = new List<UnidadMedida>();

            string sql = "SELECT idUnidad, nombre FROM UnidadMedida  where descripcion <> ' '";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                UnidadMedida u;

                while (dr.Read())
                {
                    u = new UnidadMedida();

                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["nombre"].ToString();
                   

                    unidades.Add(u);


                }

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


            return unidades ;

        }
        public static List<UnidadMedida> GetTiempo()
        {
            Acceso ac = new Acceso();

            List<UnidadMedida> unidades = new List<UnidadMedida>();

            string sql = "SELECT idUnidad, nombre FROM UnidadMedida where descripcion = ' '";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                UnidadMedida u;

                while (dr.Read())
                {
                    u = new UnidadMedida();

                    u.IDUnidad = Convert.ToInt32(dr["idUnidad"]);
                    u.Nombre = dr["nombre"].ToString();


                    unidades.Add(u);


                }

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


            return unidades;

        }
    }
}
