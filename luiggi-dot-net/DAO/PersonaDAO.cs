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
    public class PersonaDAO
    {
        public static void Update(Persona per)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_persona_update", conexion);


            if (!(per.Nombre == "N/D") && !(per.Nombre == ""))
            {
                cmd.Parameters.AddWithValue("@nombre", per.Nombre);
            }
            if (!(per.RazonSocial == "N/D") && !(per.RazonSocial == ""))
            {
                cmd.Parameters.AddWithValue("@razonSocial", per.RazonSocial);
            }
            if (!(per.Apellido == "N/D")&&!(per.Apellido == ""))
            {
                cmd.Parameters.AddWithValue("@apellido", per.Apellido);
            }
            if (!(per.cuil ==string.Empty))
            {
                cmd.Parameters.AddWithValue("@CUIT", per.cuil);
            }
            if (!(per.NroDoc == 1) && !(per.NroDoc == 0))
            {
                cmd.Parameters.AddWithValue("@idTipoDoc", per.TipoDoc.IDTipoDoc);
            }
            if (!(per.NroDoc == 1) && !(per.NroDoc == 0))
            {
                cmd.Parameters.AddWithValue("@nroDocumento", per.NroDoc);
            }
            if (!(per.calle == "N/D") && !(per.calle == ""))
            {
                cmd.Parameters.AddWithValue("@calle", per.calle);
            }
            if (!(per.calle_nro == 0))
            {
                cmd.Parameters.AddWithValue("@nro", per.calle_nro);
            }
            if (!(per.piso == 0))
            {
                cmd.Parameters.AddWithValue("@piso", per.piso);
            }
            if (!(per.depto == 0))
            {
                cmd.Parameters.AddWithValue("@depto", per.depto);
            }
            if (!(per.Barrio == "N/D") && !(per.Barrio == ""))
            {
                cmd.Parameters.AddWithValue("@barrio", per.Barrio);
            }
            if (!(per.telefono == String.Empty))
            {
                cmd.Parameters.AddWithValue("@telefonoContacto", per.telefono);
            }
            if (!(per.tefefonoCelular == String.Empty))
            {
                cmd.Parameters.AddWithValue("@telefonoCelular", per.tefefonoCelular);
            }
            if (!(per.mail == "N/D")&&!(per.mail == ""))
            {
                cmd.Parameters.AddWithValue("@email", per.mail);
            }
            cmd.Parameters.AddWithValue("@codPostal", per.Localidad.codPostal);
            cmd.Parameters.AddWithValue("@nroCliente", per.NroCliente);
            cmd.Parameters.AddWithValue("@idCondIVA", per.condicionIVA.idCondicionIVA);
            cmd.Parameters.AddWithValue("@idTipoConsumidor", per.tipoConsumidor.idTipoConsumidor);
            cmd.Parameters.AddWithValue("@sexo", per.Sexo);
            cmd.Parameters.AddWithValue("@fechaNac", per.fechaNAc);
            //cmd.Parameters.AddWithValue("@nroProveedor", per.NroProveedor);
            
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
        public static void UpdateProveedor(Persona per)
        {
            Acceso ac = new Acceso();

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_proveedor_update", conexion);


            if (!(per.Nombre == "N/D") && !(per.Nombre == ""))
            {
                cmd.Parameters.AddWithValue("@nombre", per.Nombre);
            }
            if (!(per.RazonSocial == "N/D") && !(per.RazonSocial == ""))
            {
                cmd.Parameters.AddWithValue("@razonSocial", per.RazonSocial);
            }
            if (!(per.Apellido == "N/D") && !(per.Apellido == ""))
            {
                cmd.Parameters.AddWithValue("@apellido", per.Apellido);
            }
            if (!(per.cuil == string.Empty))
            {
                cmd.Parameters.AddWithValue("@CUIT", per.cuil);
            }
           
            if (!(per.calle == "N/D") && !(per.calle == ""))
            {
                cmd.Parameters.AddWithValue("@calle", per.calle);
            }
            if (!(per.calle_nro == 0))
            {
                cmd.Parameters.AddWithValue("@nro", per.calle_nro);
            }
          
            if (!(per.Barrio == "N/D") && !(per.Barrio == ""))
            {
                cmd.Parameters.AddWithValue("@barrio", per.Barrio);
            }
            if (!(per.telefono == String.Empty))
            {
                cmd.Parameters.AddWithValue("@telefonoContacto", per.telefono);
            }
          
            if (!(per.mail == "N/D") && !(per.mail == ""))
            {
                cmd.Parameters.AddWithValue("@email", per.mail);
            }
            cmd.Parameters.AddWithValue("@codPostal", per.Localidad.codPostal);
            cmd.Parameters.AddWithValue("@nroProveedor", per.NroProveedor );
           

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
        public static void Insert(Persona per)
        {
            Acceso ac = new Acceso();


            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_persona_insert", conexion);

            if (!(per.Nombre == ""))
            {
                cmd.Parameters.AddWithValue("@nombre", per.Nombre);
            }
            if(!(per.RazonSocial==""))
            {
                cmd.Parameters.AddWithValue("@razonSocial", per.RazonSocial );
            }

            if (!(per.Apellido==""))
            {
                cmd.Parameters.AddWithValue("@apellido", per.Apellido); 
            }
            if (!(per.cuil == "1 -        -"))
            {
                cmd.Parameters.AddWithValue("@CUIT", per.cuil);
            }
            if (!(per.NroDoc == 0))
            {
                cmd.Parameters.AddWithValue("@idTipoDoc", per.TipoDoc.IDTipoDoc);
            }
            if (!(per.NroDoc == 0))
            {
                cmd.Parameters.AddWithValue("@nroDocumento", per.NroDoc);
            }
            if (!(per.calle == ""))
            {
                cmd.Parameters.AddWithValue("@calle", per.calle);
            }
            if (!(per.calle_nro == 0))
            {
                cmd.Parameters.AddWithValue("@nro", per.calle_nro);
            }
            if (!(per.piso == 0))
            {
                cmd.Parameters.AddWithValue("@piso", per.piso);
            }
            
            if (!(per.depto == 0))
            {
                cmd.Parameters.AddWithValue("@depto", per.depto);
            }
            if (!(per.Barrio == ""))
            {
                cmd.Parameters.AddWithValue("@barrio", per.Barrio);
            }
            if (!(per.telefono == ""))
            {
                cmd.Parameters.AddWithValue("@telefonoContacto", per.telefono);
            }
            if (!(per.tefefonoCelular == ""))
            {
                cmd.Parameters.AddWithValue("@telefonoCelular", per.tefefonoCelular);
            }
            if (!(per.mail == ""))
            {
                cmd.Parameters.AddWithValue("@email", per.mail);
            }
            if (!(per.NroCliente == 0))
            {
                cmd.Parameters.AddWithValue("@nroCliente", per.NroCliente);
            }
            if (!(per.NroProveedor == 0))
            {
                cmd.Parameters.AddWithValue("@nroProveedor", per.NroProveedor);
            }
            if (!(per.fechaNAc.Date == DateTime.Now.Date))
            {
                cmd.Parameters.AddWithValue("@fechaNac", per.fechaNAc.Date);
            }

            cmd.Parameters.AddWithValue("@codPostal", per.Localidad.codPostal);
            cmd.Parameters.AddWithValue("@sexo", per.Sexo);
            
            

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
        public static void Delete(int idPersona)
        {
            Acceso ac = new Acceso();

            string sql = "DELETE FROM Persona WHERE (nroCliente = @codigo)";

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());
            SqlCommand cmd = new SqlCommand(sql, conexion);

            cmd.Parameters.AddWithValue("@codigo", idPersona);

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
        public static List<Persona> GetAll()
        {
            Acceso ac = new Acceso();

            List<Persona> personas = new List<Persona>();

            string sql = "SELECT * from CONSULTA_CLIENTES";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                Provincia pr;
                Persona p;
                TipoDocumento td;
                Localidad l;
                TipoConsumidor tc;
                CondicionIVA iva;

                while (dr.Read())
                {
                    pr = new Provincia();

                    pr.idProvincia = Convert.ToInt32(dr["idProvincia"]);
                    pr.Nombre = dr["provincia"].ToString();
                   
                    l = new Localidad ();

                    l.codPostal  = Convert.ToInt32(dr["codPostal"]);
                    l.Nombre  = dr["localidad"].ToString();
                    l.Provincia  = pr;

                    td  = new TipoDocumento ();

                    td.IDTipoDoc = Convert.ToInt32(dr["idTipo"]);
                    td.Nombre = dr["tipoDocumento"].ToString();
                    td.Descripcion = dr["descripcion"].ToString();

                    tc = new TipoConsumidor();
                    tc.idTipoConsumidor = Convert.ToInt32(dr["idTipoConsumidor"]);

                    iva = new CondicionIVA();
                    iva.idCondicionIVA = Convert.ToInt32(dr["idCondicionIVA"]);

                    p = new Persona ();

                    p.Apellido = dr["apellido"].ToString();
                    p.Barrio = dr["barrio"].ToString();
                    p.calle = dr["calle"].ToString();
                    p.calle_nro = Convert.ToInt32(dr["nro"]);
                    p.cuil =  dr["CUIT"].ToString();
                    p.depto = Convert.ToInt32(dr["depto"]);
                    p.Localidad = l;
                    p.mail = dr["email"].ToString();
                    p.Nombre = dr["nombre"].ToString();
                    p.NroCliente = Convert.ToInt32(dr["nroCliente"]);
                    p.NroDoc = Convert.ToInt64(dr["nroDocumento"]);
                    p.NroProveedor = Convert.ToInt32(dr["nroProveedor"]);
                    p.piso = Convert.ToInt32(dr["piso"]);
                    p.RazonSocial = dr["razonSocial"].ToString();
                    p.telefono = dr["telefonoContacto"].ToString();
                    p.tefefonoCelular = dr["telefonoCelular"].ToString();
                    p.Sexo = Convert.ToChar(dr["sexo"]);
                    p.fechaNAc = Convert.ToDateTime(dr["fechaNac"]);
                    p.idPersona = Convert.ToInt32(dr["idPersona"]);
                    p.TipoDoc = td;
                    p.condicionIVA = iva;
                    p.tipoConsumidor = tc;
                  
                    personas.Add(p);


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


            return personas;

        }
        public static List<Persona> GetAllProveedores()
        {
            Acceso ac = new Acceso();

            List<Persona> personas = new List<Persona>();

            string sql = "SELECT * from CONSULTA_CLIENTES where nroProveedor != 0  ";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                Provincia pr;
                Persona p;
                TipoDocumento td;
                Localidad l;
                TipoConsumidor tc;
                CondicionIVA iva;

                while (dr.Read())
                {
                    pr = new Provincia();

                    pr.idProvincia = Convert.ToInt32(dr["idProvincia"]);
                    pr.Nombre = dr["provincia"].ToString();

                    l = new Localidad();

                    l.codPostal = Convert.ToInt32(dr["codPostal"]);
                    l.Nombre = dr["localidad"].ToString();
                    l.Provincia = pr;

                    td = new TipoDocumento();

                    td.IDTipoDoc = Convert.ToInt32(dr["idTipo"]);
                    td.Nombre = dr["tipoDocumento"].ToString();
                    td.Descripcion = dr["descripcion"].ToString();

                    tc = new TipoConsumidor();
                    tc.idTipoConsumidor = Convert.ToInt32(dr["idTipoConsumidor"]);

                    iva = new CondicionIVA();
                    iva.idCondicionIVA = Convert.ToInt32(dr["idCondicionIVA"]);

                    p = new Persona();

                    p.Apellido = dr["apellido"].ToString();
                    p.Barrio = dr["barrio"].ToString();
                    p.calle = dr["calle"].ToString();
                    p.calle_nro = Convert.ToInt32(dr["nro"]);
                    p.cuil = dr["CUIT"].ToString();
                    p.depto = Convert.ToInt32(dr["depto"]);
                    p.Localidad = l;
                    p.mail = dr["email"].ToString();
                    p.Nombre = dr["nombre"].ToString();
                    p.NroCliente = Convert.ToInt32(dr["nroCliente"]);
                    p.NroDoc = Convert.ToInt64(dr["nroDocumento"]);
                    p.NroProveedor = Convert.ToInt32(dr["nroProveedor"]);
                    p.piso = Convert.ToInt32(dr["piso"]);
                    p.RazonSocial = dr["razonSocial"].ToString();
                    p.telefono = dr["telefonoContacto"].ToString();
                    p.tefefonoCelular = dr["telefonoCelular"].ToString();
                    p.Sexo = Convert.ToChar(dr["sexo"]);
                    p.fechaNAc = Convert.ToDateTime(dr["fechaNac"]);
                    p.idPersona = Convert.ToInt32(dr["idPersona"]);
                    p.TipoDoc = td;
                    p.condicionIVA = iva;
                    p.tipoConsumidor = tc;

                    personas.Add(p);


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


            return personas;

        }
        public static List<Persona> GetByFiltro(Persona per)
        {
            Acceso ac = new Acceso();

            List<Persona> personas = new List<Persona>();
            SqlCommand cmd = new SqlCommand();

            string sql = "SELECT * from CONSULTA_CLIENTES";
            sql +=" where 1 = 1 and nroProveedor = 0 ";


            if ( per.Nombre != null)
            {
                sql += " and nombre LIKE @nombre";
                cmd.Parameters.AddWithValue("@nombre", "%"+per.Nombre+"%");
            }
            if (per.Apellido != null)
            {
                sql += " and apellido LIKE @apellido";
                cmd.Parameters.AddWithValue("@apellido", "%" + per.Apellido + "%");
            }
            if (per.RazonSocial != null)
            {
                sql += " and razonSocial LIKE @razon";
                cmd.Parameters.AddWithValue("@razon", "%" + per.RazonSocial + "%");
            }
            if (per.NroDoc!=0)
            {
                sql += " and nroDocumento=@nroDoc";
                cmd.Parameters.AddWithValue("@nroDoc", per.NroDoc);
            }
            if (per.cuil!=null)
            {
                sql += " and CUIT like @cuit";
                cmd.Parameters.AddWithValue("@cuit", per.cuil);
            }
            
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                Provincia pr;
                Persona p;
                TipoDocumento td;
                Localidad l;
                TipoConsumidor tc;
                CondicionIVA iva;

                while (dr.Read())
                {
                    pr = new Provincia();

                    pr.idProvincia = Convert.ToInt32(dr["idProvincia"]);
                    pr.Nombre = dr["provincia"].ToString();

                    l = new Localidad();

                    l.codPostal = Convert.ToInt32(dr["codPostal"]);
                    l.Nombre = dr["localidad"].ToString();
                    l.Provincia = pr;

                    td = new TipoDocumento();

                    td.IDTipoDoc = Convert.ToInt32(dr["idTipo"]);
                    td.Nombre = dr["tipoDocumento"].ToString();
                    td.Descripcion = dr["descripcion"].ToString();

                    tc = new TipoConsumidor();
                    tc.idTipoConsumidor = Convert.ToInt32(dr["idTipoConsumidor"]);

                    iva = new CondicionIVA();
                    iva.idCondicionIVA = Convert.ToInt32(dr["idCondicionIVA"]);

                    p = new Persona();

                    p.Apellido = dr["apellido"].ToString();
                    p.Barrio = dr["barrio"].ToString();
                    p.calle = dr["calle"].ToString();
                    p.calle_nro = Convert.ToInt32(dr["nro"]);
                    p.cuil = dr["CUIT"].ToString();
                    p.depto = Convert.ToInt32(dr["depto"]);
                    p.Localidad = l;
                    p.mail = dr["email"].ToString();
                    p.Nombre = dr["nombre"].ToString();
                    p.NroCliente = Convert.ToInt32(dr["nroCliente"]);
                    p.NroDoc = Convert.ToInt32(dr["nroDocumento"]);
                    p.NroProveedor = Convert.ToInt32(dr["nroProveedor"]);
                    p.piso = Convert.ToInt32(dr["piso"]);
                    p.RazonSocial = dr["razonSocial"].ToString();
                    p.telefono = dr["telefonoContacto"].ToString();
                    p.TipoDoc = td;
                    p.tefefonoCelular = dr["telefonoCelular"].ToString();
                    p.condicionIVA = iva;
                    p.tipoConsumidor = tc;
                    p.Sexo = Convert.ToChar(dr["sexo"]);
                    p.fechaNAc = Convert.ToDateTime(dr["fechaNac"]);
                    p.idPersona = Convert.ToInt32(dr["idPersona"]);
                    personas.Add(p);


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


            return personas;

        }
        public static List<Persona> GetByFiltroProveedor(Persona per)
        {
            Acceso ac = new Acceso();

            List<Persona> personas = new List<Persona>();
            SqlCommand cmd = new SqlCommand();

            string sql = "SELECT * from CONSULTA_CLIENTES";
            sql += " where 1 = 1 and nroCliente = 0 ";


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
            if (per.RazonSocial != null)
            {
                sql += " and razonSocial LIKE @razon";
                cmd.Parameters.AddWithValue("@razon", "%" + per.RazonSocial + "%");
            }
           
            if (per.cuil != null)
            {
                sql += " and CUIT like @cuit";
                cmd.Parameters.AddWithValue("@cuit", per.cuil);
            }
            

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                Provincia pr;
                Persona p;
                TipoDocumento td;
                Localidad l;
                TipoConsumidor tc;
                CondicionIVA iva;

                while (dr.Read())
                {
                    pr = new Provincia();

                    pr.idProvincia = Convert.ToInt32(dr["idProvincia"]);
                    pr.Nombre = dr["provincia"].ToString();

                    l = new Localidad();

                    l.codPostal = Convert.ToInt32(dr["codPostal"]);
                    l.Nombre = dr["localidad"].ToString();
                    l.Provincia = pr;

                    td = new TipoDocumento();

                    td.IDTipoDoc = Convert.ToInt32(dr["idTipo"]);
                    td.Nombre = dr["tipoDocumento"].ToString();
                    td.Descripcion = dr["descripcion"].ToString();

                    tc = new TipoConsumidor();
                    tc.idTipoConsumidor = Convert.ToInt32(dr["idTipoConsumidor"]);

                    iva = new CondicionIVA();
                    iva.idCondicionIVA = Convert.ToInt32(dr["idCondicionIVA"]);

                    p = new Persona();

                    p.Apellido = dr["apellido"].ToString();
                    p.Barrio = dr["barrio"].ToString();
                    p.calle = dr["calle"].ToString();
                    p.calle_nro = Convert.ToInt32(dr["nro"]);
                    p.cuil = dr["CUIT"].ToString();
                    p.depto = Convert.ToInt32(dr["depto"]);
                    p.Localidad = l;
                    p.mail = dr["email"].ToString();
                    p.Nombre = dr["nombre"].ToString();
                    p.NroCliente = Convert.ToInt32(dr["nroCliente"]);
                    p.NroDoc = Convert.ToInt32(dr["nroDocumento"]);
                    p.NroProveedor = Convert.ToInt32(dr["nroProveedor"]);
                    p.piso = Convert.ToInt32(dr["piso"]);
                    p.RazonSocial = dr["razonSocial"].ToString();
                    p.telefono = dr["telefonoContacto"].ToString();
                    p.TipoDoc = td;
                    p.tefefonoCelular = dr["telefonoCelular"].ToString();
                    p.condicionIVA = iva;
                    p.tipoConsumidor = tc;
                    p.Sexo = Convert.ToChar(dr["sexo"]);
                    p.fechaNAc = Convert.ToDateTime(dr["fechaNac"]);
                    p.idPersona = Convert.ToInt32(dr["idPersona"]);
                    personas.Add(p);


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


            return personas;

        }
        public static Persona GetClientePersona( int idT, int nro)
        {
            Acceso ac = new Acceso();

            Persona p = new Persona();

            string sql = "SELECT * from CONSULTA_CLIENTES where idTipoDoc =  @idT and nroDocumento = @nro";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@idT", idT);
            cmd.Parameters.AddWithValue("@nro", nro);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();




                
                 dr.Read();
               
                 p.Apellido = dr["apellido"].ToString();
                 p.Nombre = dr["nombre"].ToString();
                 p.idPersona  = Convert.ToInt32(dr["idPersona"]);
                 
   
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
        public static Persona GetClienteEmpresa(int cu)
        {
            Acceso ac = new Acceso();

            Persona p = new Persona();

            string sql = "SELECT * from CONSULTA_CLIENTES where CUIT = @cuil";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@cuil", cu );
            
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                
                dr.Read();
                p.RazonSocial  = dr["razonSocial"].ToString();
                
                p.idPersona = Convert.ToInt32(dr["idPersona"]);


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
