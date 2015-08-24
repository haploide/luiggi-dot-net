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
    public  class TipoDocumentoDAO
    {
        public static List<TipoDocumento> GetAll()
        {
            Acceso ac = new Acceso();

            List<TipoDocumento> tiposDoc = new List<TipoDocumento>();

            string sql = "SELECT idTipo, nombre, descripcion FROM TipoDocumento";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                TipoDocumento td;

                while (dr.Read())
                {
                    td  = new TipoDocumento();
                    td.IDTipoDoc = Convert.ToInt32(dr["idTipo"]);
                    td.Nombre = dr["nombre"].ToString();
                    td.Descripcion = dr["descripcion"].ToString();
                   
                    tiposDoc.Add(td);


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


            return tiposDoc;

        }
    }
}
