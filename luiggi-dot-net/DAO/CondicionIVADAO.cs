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
    public  class CondicionIVADAO
    {
        public static List<CondicionIVA > GetAll()
        {
            Acceso ac = new Acceso();


            List<CondicionIVA> condIVA = new List<CondicionIVA>();

            string sql = "SELECT idCondicionIVA, nombre FROM CondicionIVA";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                CondicionIVA c;

                while (dr.Read())
                {
                    c = new CondicionIVA();

                    c.idCondicionIVA = Convert.ToInt32(dr["idCondicionIVA"]);
                    c.Nombre = dr["nombre"].ToString();


                    condIVA.Add(c);


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


            return condIVA;

        }
    }
}
