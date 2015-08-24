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
    public  class TipoMaquinariaDAO
    {
        public static List<TipoMaquinaria > GetAll()
        {
            Acceso ac = new Acceso();

            List<TipoMaquinaria> maquinarias = new List<TipoMaquinaria>();

            string sql = "SELECT idTipoMaquinaria, nombre FROM TipoMaquinaria";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                TipoMaquinaria m;

                while (dr.Read())
                {
                    m = new TipoMaquinaria();

                    m.idTipoMaquinaria = Convert.ToInt32(dr["idTipoMaquinaria"]);
                    m.Nombre = dr["nombre"].ToString();


                    maquinarias.Add(m);


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


            return maquinarias;

        }
    }
}
