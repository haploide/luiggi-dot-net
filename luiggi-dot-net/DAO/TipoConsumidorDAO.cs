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
    public  class TipoConsumidorDAO
    {
        public static List<TipoConsumidor > GetAll()
        {
            Acceso ac = new Acceso();

            List<TipoConsumidor> tiCons = new List<TipoConsumidor>();

            string sql = "SELECT idTipoConsumidor, nombre FROM TipoConsumidor";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                TipoConsumidor tc;

                while (dr.Read())
                {
                    tc  = new TipoConsumidor();

                    tc.idTipoConsumidor = Convert.ToInt32(dr["idTipoConsumidor"]);
                    tc.Nombre = dr["nombre"].ToString();


                    tiCons.Add(tc);
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


            return tiCons;

        }
    }
}
