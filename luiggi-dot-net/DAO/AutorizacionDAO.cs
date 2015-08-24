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
    public class AutorizacionDAO
    {
        public static bool   GetAutorizacionPorUsuario(int idUsuario , string permiso)
        {
            Acceso ac = new Acceso();

            bool  a = false ;

            string sql = "select * from Autorizaciones a join Permisos p on a.idpermiso = p.idpermiso where a.idusuario = @idUsuario and p.permiso = @permiso ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@permiso", permiso);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                a = dr.HasRows;

                //a.idUsuario = Convert.ToInt32(dr["idUsuario"]);
                //a.idPermiso= Convert.ToInt32(dr["idpermiso"]);
              


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


            return a;

        }
    }
}
