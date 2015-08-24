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
    public class ProvinciaDAO
    {
        public static List<Provincia> GetAll()
        {
            Acceso ac = new Acceso();

            List<Provincia> provincias = new List<Provincia>();

            string sql = "SELECT idProvincia, nombre FROM Provincia";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Provincia  p;

                while (dr.Read())
                {
                    p  = new Provincia();
                    p.idProvincia = Convert.ToInt32(dr["idProvincia"]);
                    p.Nombre = dr["nombre"].ToString();

                    provincias.Add(p);


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


            return provincias ;

        }
    }
}
