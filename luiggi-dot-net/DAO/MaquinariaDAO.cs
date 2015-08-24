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
    public  class MaquinariaDAO
    {
        public static void Update(Maquinaria  maq)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_update_maquinaria", conexion);


            if (!(maq.Nombre == "N/D") && !(maq.Nombre == ""))
            {
                cmd.Parameters.AddWithValue("@nombre", maq.Nombre);
            }

            if (!(maq.descripcion == "N/D") && !(maq.descripcion == ""))
            {
                cmd.Parameters.AddWithValue("@descripcion", maq.descripcion);
            }

            cmd.Parameters.AddWithValue("@idTipo", maq.tipoMaquinaria.idTipoMaquinaria);
            //cmd.Parameters.AddWithValue("@fechaAlta", maq.fechaAlta .Date);

            cmd.Parameters.AddWithValue("@idMaquinaria", maq.idMaquinaria );


            try
            {
                conexion.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

            }
            catch (ArgumentException ex)
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
        }
        public static void Insert(Maquinaria  maq)
        {
            Acceso ac = new Acceso();


            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_insert_maquinaria", conexion);

            if (!(maq.Nombre == ""))
            {
                cmd.Parameters.AddWithValue("@nombre", maq.Nombre);
            }

            if (!(maq.descripcion  == ""))
            {
                cmd.Parameters.AddWithValue("@descripcion", maq.descripcion );
            }
                        
            cmd.Parameters.AddWithValue("@fechaAlta", maq.fechaAlta .Date);
            cmd.Parameters.AddWithValue("@idTipo", maq.tipoMaquinaria.idTipoMaquinaria);
                     
            try
            {
                conexion.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

            }
            catch (ArgumentException ex)
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
        }
        public static void UpdateEstado(int idMaq, int idestado)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Maquinaria]SET [idEstado] = @idEstado WHERE idMaquinaria = @idMaquinaria ", conexion);

            cmd.Parameters.AddWithValue("@idEstado", idestado);
            cmd.Parameters.AddWithValue("@idMaquinaria", idMaq);

            try
            {
                conexion.Open();

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (ArgumentException ex)
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
        }
        public static List<Maquinaria> GetAll()
        {
            Acceso ac = new Acceso();

            List<Maquinaria> maquinarias = new List<Maquinaria>();

            string sql = "SELECT * FROM CONSULTAR_MAQUINARIA";
            //string sql = "SELECT Maquinaria.idMaquinaria, Maquinaria.nombre, Maquinaria.descripcion, Maquinaria.idTipo, Maquinaria.fechaAlta, ";
            //sql += " Maquinaria.idEstado, TipoMaquinaria.nombre AS tipoMaquinaria, Estado.nombre AS estado FROM Estado INNER JOIN Maquinaria ON Estado.idEstado = Maquinaria.idEstado INNER JOIN";
            //sql+= " TipoMaquinaria ON Maquinaria.idTipo = TipoMaquinaria.idTipoMaquinaria";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Maquinaria m;
                Estado e;
                TipoMaquinaria tm;
                while (dr.Read())
                {
                    m = new Maquinaria();
                    e = new Estado();
                    tm = new TipoMaquinaria();

                    tm.idTipoMaquinaria = Convert.ToInt32(dr["idTipo"]);
                    tm.Nombre = dr["tipoMaquinaria"].ToString();
                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["estado"].ToString();

                    m.idMaquinaria = Convert.ToInt32(dr["idMaquinaria"]);
                    m.Nombre = dr["nombre"].ToString();
                    m.descripcion = dr["descripcion"].ToString();
                    m.fechaAlta = Convert.ToDateTime(dr["fechaAlta"]);
                    m.estado = e;
                    m.tipoMaquinaria = tm;
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
        public static List<Maquinaria> GetAllDisponibles(int id, DateTime fecha, DateTime hi, DateTime hf)
        {
            Acceso ac = new Acceso();

            List<Maquinaria> maquinarias = new List<Maquinaria>();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_maquinaria_disponible", conexion);
           
            cmd.Parameters.AddWithValue("@idProd", id);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@hi", hi );
            cmd.Parameters.AddWithValue("@hf", hf);
            
            try
            {
                conexion.Open();

                cmd.Connection = conexion;
               
                cmd.CommandType = CommandType.StoredProcedure ;

                SqlDataReader dr = cmd.ExecuteReader();

                Maquinaria m;
              
                while (dr.Read())
                {
                    m = new Maquinaria();
                   

                    m.idMaquinaria = Convert.ToInt32(dr["idMaquinaria"]);
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
        public static List<Maquinaria> GetByFiltro(Maquinaria maq)
        {
            Acceso ac = new Acceso();

            List<Maquinaria> maquinas = new List<Maquinaria>();
            SqlCommand cmd = new SqlCommand();

            string sql = "select * from CONSULTAR_MAQUINARIA";
            sql += " where 1=1";


            if (maq.Nombre != null)
            {
                sql += " and nombre LIKE @nombre";
                cmd.Parameters.AddWithValue("@nombre", "%" + maq.Nombre + "%");
            }

            if (maq.descripcion != null)
            {
                sql += " and descripcion Like @descrip";
                cmd.Parameters.AddWithValue("@descrip", "%" + maq.descripcion + "%");
            }
            if (maq.estado.idEstado != 0)
            {
                sql += " and idEstado=@estado";
                cmd.Parameters.AddWithValue("@estado", maq.estado.idEstado);
            }
            if (maq.tipoMaquinaria.idTipoMaquinaria != 0)
            {
                sql += " and idTipo=@tipo";
                cmd.Parameters.AddWithValue("@tipo", maq.tipoMaquinaria.idTipoMaquinaria);
            }

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                Maquinaria maqu;
                Estado est;
                TipoMaquinaria tipo;

                while (dr.Read())
                {

                    est = new Estado();

                    est.idEstado = Convert.ToInt32(dr["idEstado"]);
                    est.Nombre = dr["estado"].ToString();

                    tipo = new TipoMaquinaria();
                    tipo.idTipoMaquinaria = Convert.ToInt32(dr["idTipo"]);
                    tipo.Nombre = dr["tipoMaquinaria"].ToString();

                    maqu = new Maquinaria();
                    maqu.estado = est;
                    maqu.tipoMaquinaria = tipo;
                    maqu.Nombre = dr["nombre"].ToString();
                    maqu.idMaquinaria = Convert.ToInt32(dr["idMaquinaria"]);
                    maqu.fechaAlta = Convert.ToDateTime(dr["fechaAlta"]);
                    maqu.descripcion = dr["descripcion"].ToString();


                    maquinas.Add(maqu);
                }

            }
            catch (SqlException ex)
            {

                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return maquinas;

        }
        public static void Delete(int idMaquina)
        {
            Acceso ac = new Acceso();

            string sql = "Delete from Maquinaria where idMaquinaria=@idMaquina";

            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            cmd.Parameters.AddWithValue("@idMaquina", idMaquina);

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;


                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
