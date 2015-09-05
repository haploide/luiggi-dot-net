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
    public  class EmpleadoDAO
    {
        public static void UpdateEstado(int idEmpleado, int idestado)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Empleado]SET[idEstado] = @idEstado WHERE idempleado =  @idEmpleado", conexion);

            cmd.Parameters.AddWithValue("@idEstado", idestado);
            cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);

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
        public static void Update(Empleado  emp)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_update_empleado", conexion);


            if (!(emp.Nombre == "N/D") && !(emp.Nombre == ""))
            {
                cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
            }

            if (!(emp.Apellido == "N/D") && !(emp.Apellido == ""))
            {
                cmd.Parameters.AddWithValue("@apellido", emp.Apellido);
            }

            if (!(emp.telefono == String.Empty))
            {
                cmd.Parameters.AddWithValue("@tel", emp.telefono);
            }
            cmd.Parameters.AddWithValue("@fechaNac", emp.fechaNac.Date);


            cmd.Parameters.AddWithValue("@fechaAlt", emp.fechaAlta.Date);
          
            
            cmd.Parameters.AddWithValue("@idEmpleado", emp.idEmpleado );
           

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
        public static List<Empleado> GetAllDisponible(DateTime fecha, DateTime hi, DateTime hf)
        {
            Acceso ac = new Acceso();

            List<Empleado> empleados = new List<Empleado>();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_empleados_disponibles", conexion);


            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@hi", hi);
            cmd.Parameters.AddWithValue("@hf", hf);

            try
            {
                conexion.Open();

                cmd.Connection = conexion;

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                Empleado em;
              

                while (dr.Read())
                {
                    
                    em = new Empleado();
                  
                    em.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    em.Nombre = dr["nombre"].ToString();
                    em.Apellido = dr["apellido"].ToString();
               
                    empleados.Add(em);

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


            return empleados;
        }
        public static void Delete(int idEmp)
        {
            Acceso ac = new Acceso();

            string sql = "DELETE FROM Empleado WHERE (idEmpleado = @idEmp)";

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand(sql, conexion);

            cmd.Parameters.AddWithValue("@idEmp", idEmp);

            try
            {
                conexion.Open();

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
        public static void Insert(Empleado  emp)
        {
            Acceso ac = new Acceso();


            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_insert_empleado", conexion);

            if (!(emp.Nombre == ""))
            {
                cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
            }

            if (!(emp.Apellido == ""))
            {
                cmd.Parameters.AddWithValue("@apellido", emp.Apellido);
            }


            if (!(emp.telefono == ""))
            {
                cmd.Parameters.AddWithValue("@tel", emp.telefono);
            }

           
                cmd.Parameters.AddWithValue("@fechaNac", emp.fechaNac.Date);
            
           
                cmd.Parameters.AddWithValue("@fechaAlt", emp.fechaAlta.Date);
           
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
        public static List<Empleado > GetAll()
        {
            Acceso ac = new Acceso();

            List<Empleado> empleados = new List<Empleado>();

            string sql = "SELECT * FROM CONSULTAR_EMPLEADO order by apellido asc, nombre asc";
           
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Empleado em;
                Estado e;
               
                while (dr.Read())
                {
                    em  = new Empleado ();
                    e = new Estado();
                  

                  
                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["estado"].ToString();
                    em.estado = e;
                    em.Nombre = dr["nombre"].ToString();
                    em.Apellido = dr["apellido"].ToString();
                    em.fechaAlta = Convert.ToDateTime(dr["fechaAlta"]);
                    em.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    em.fechaNac = Convert.ToDateTime(dr["fechaNac"]);
                    em.telefono = dr["telefonoContacto"].ToString();
                    em.edad  = Convert.ToInt32(dr["edad"]);
                    empleados.Add(em );


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


            return empleados;

        }
        public static List<Empleado> GetByFiltro(Empleado per)
        {
            Acceso ac = new Acceso();

            List<Empleado> empleados = new List<Empleado>();
            SqlCommand cmd = new SqlCommand();

            string sql = "SELECT * from CONSULTAR_EMPLEADO  where 1=1";
           


            if (per.Nombre != null)
            {
                sql += " and nombre LIKE @nombre";
                cmd.Parameters.AddWithValue("@nombre", "%" + per.Nombre + "%");
            }
            if (per.Apellido != null)
            {
                sql += " and apellido LIKE @apellido";
                cmd.Parameters.AddWithValue("@apellido", "%" + per.Apellido + "%");
            }
            

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
               
                Empleado  em;
                Estado e;
               

                while (dr.Read())
                {
                   

                    em = new Empleado ();

                    em = new Empleado();
                    e = new Estado();



                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["estado"].ToString();
                    em.estado = e;
                    em.Nombre = dr["nombre"].ToString();
                    em.Apellido = dr["apellido"].ToString();
                    em.fechaAlta = Convert.ToDateTime(dr["fechaAlta"]);
                    em.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    em.fechaNac = Convert.ToDateTime(dr["fechaNac"]);
                    em.telefono = dr["telefonoContacto"].ToString();
                    em.edad = Convert.ToInt32(dr["edad"]);
                    empleados.Add(em);


                }

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


            return empleados;

        }

    }
}
