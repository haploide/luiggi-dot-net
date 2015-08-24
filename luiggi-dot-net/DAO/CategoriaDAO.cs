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
    public  class CategoriaDAO
    {

        public static List<Categoria> GetAll()
        {
            Acceso ac = new Acceso();

            List<Categoria> categorias = new List<Categoria>();

            string sql = "SELECT idCategoria, nombre FROM Categoria";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();


                Categoria c;
 
                while (dr.Read())
                {

                   c = new Categoria();           
                   c.IDCategoria = Convert.ToInt32(dr["idCategoria"]);
                   c.Nombre = dr["nombre"].ToString();

                    categorias.Add(c);


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


            return categorias;

        }
    }
}
