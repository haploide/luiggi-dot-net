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
    public class LocalidadDAO
    {
        public static List<Localidad> GetLocalidadXProvincia( int prov)
        {
            Acceso ac = new Acceso();

            List<Localidad> Localidades = new List<Localidad>();

            string sql = "SELECT codPostal, nombre, idProv FROM Localidad where idProv = @prov ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@prov", prov);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Localidad  l;
                Provincia p;
                while (dr.Read())
                {
                    l  = new Localidad ();
                    p = new Provincia();
                    l.codPostal = Convert.ToInt32(dr["codPostal"]);
                    l.Nombre = dr["nombre"].ToString();
                    p.idProvincia = Convert.ToInt32(dr["idProv"]);
                    l.Provincia = p;
                   
                    
                    Localidades.Add(l);


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


            return Localidades ;

        }
    }
}
