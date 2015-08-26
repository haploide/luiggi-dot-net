using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    public  class UsuarioDAO
    {
        public static Usuario  GetUsuario(string  login , string  pass)
        {
            Acceso ac = new Acceso();

            Usuario p = new Usuario();

            string sql = "SELECT * from usuarios where login = @login and password COLLATE Latin1_General_CS_AS  =  @pass ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@pass", pass);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                p.Login  = dr["login"].ToString();
                p.Nombre = dr["nombre"].ToString();
                p.idUsuario  = Convert.ToInt32(dr["idUsuario"]);


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


            return p;

        }
    }
}
