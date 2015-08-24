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
    public  class EstadoDAO
    {
        public static List<Estado > GetAll()
        {
            Acceso ac = new Acceso();

            List<Estado> estados = new List<Estado>();

            string sql = "SELECT idEstado, nombre, idAmbito FROM Estado";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Estado e;

                while (dr.Read())
                {
                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["nombre"].ToString();
                    e.idAmbito = Convert.ToInt32(dr["idAmbito"]);

                    estados.Add(e);


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


            return estados;

        }
        public static List<Estado> GetAllPedidos()
        {
            Acceso ac = new Acceso();

            List<Estado> estados = new List<Estado>();

            string sql = "SELECT idEstado, nombre, idAmbito FROM Estado where idAmbito = 1";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Estado e;

                while (dr.Read())
                {
                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["nombre"].ToString();
                    e.idAmbito = Convert.ToInt32(dr["idAmbito"]);

                    estados.Add(e);


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


            return estados;

        }
        public static List<Estado> GetAllFactura()
        {
            Acceso ac = new Acceso();

            List<Estado> estados = new List<Estado>();

            string sql = "SELECT idEstado, nombre, idAmbito FROM Estado where idAmbito = 9";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Estado e;

                while (dr.Read())
                {
                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["nombre"].ToString();
                    e.idAmbito = Convert.ToInt32(dr["idAmbito"]);

                    estados.Add(e);


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


            return estados;

        }
        public static List<Estado> GetAllEmpleado()
        {
            Acceso ac = new Acceso();

            List<Estado> estados = new List<Estado>();

            string sql = "SELECT idEstado, nombre, idAmbito FROM Estado where idAmbito = 2";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Estado e;

                while (dr.Read())
                {
                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["nombre"].ToString();
                    e.idAmbito = Convert.ToInt32(dr["idAmbito"]);

                    estados.Add(e);


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


            return estados;

        }
        public static List<Estado> GetAllMaquinarias()
        {
            Acceso ac = new Acceso();

            List<Estado> estados = new List<Estado>();

            string sql = "SELECT idEstado, nombre, idAmbito FROM Estado where idAmbito = 3";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Estado e;

                while (dr.Read())
                {
                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["nombre"].ToString();
                    e.idAmbito = Convert.ToInt32(dr["idAmbito"]);

                    estados.Add(e);


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


            return estados;

        }
        public static List<Estado> GetAllPlan()
        {
            Acceso ac = new Acceso();

            List<Estado> estados = new List<Estado>();

            string sql = "SELECT idEstado, nombre, idAmbito FROM Estado where idAmbito = 4";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Estado e;

                while (dr.Read())
                {
                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["nombre"].ToString();
                    e.idAmbito = Convert.ToInt32(dr["idAmbito"]);

                    estados.Add(e);


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


            return estados;

        }
        public static List<Estado> GetAllXAmbito(int ambito)
        {
            Acceso ac = new Acceso();

            List<Estado> estados = new List<Estado>();

            string sql = "SELECT idEstado, nombre, idAmbito FROM Estado where idAmbito = @ambito";
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@ambito", ambito);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Estado e;

                while (dr.Read())
                {
                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["nombre"].ToString();
                    e.idAmbito = Convert.ToInt32(dr["idAmbito"]);

                    estados.Add(e);


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


            return estados;

        }

    }
}
