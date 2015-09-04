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
    public  class PedidoDAO
    {
        public static void Update(Pedido ped, List<DetallePedido> tablaAModificar, List<Producto> productosConPocaMP)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;

            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Pedido] SET [fechaNecesidad] = @fechaNecesidad, [direccion] = @direccion, [idEstado] = @idEstado  WHERE idPedido = @idPedido", conexion);

            cmd.Parameters.AddWithValue("@idPedido", ped.idPedido );
            cmd.Parameters.AddWithValue("@fechaNecesidad", ped.fechaNecesidad);
            cmd.Parameters.AddWithValue("@direccion",ped.dirEntraga);
            cmd.Parameters.AddWithValue("@idEstado", ped.estado.idEstado);
           


            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                cmd.CommandType = CommandType.Text;
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
                //SqlCommand cmdIdentity = new SqlCommand("select @@Identity", conexion, tran);
                //ped.idPedido = Convert.ToInt32((cmdIdentity.ExecuteScalar()));
                foreach (DetallePedido detP in tablaAModificar)
                {
                    if (detP.reservado == true)
                    {
                        ProductoDAO.UpdateStockReservadoYDisponibleEliminado(detP.producto.idProducto, detP.cantidad, conexion, tran);
                    }
                    else
                    {
                        renovarStock(detP, conexion, tran, ped, productosConPocaMP);
                    }
                }
                DetallePedidoDAO.Delete(ped.idPedido, conexion, tran);
                
                foreach (DetallePedido detPed in ped.detallePedido)
                {
                    //detPed.pedido.idPedido = ped.idPedido;
                    DetallePedidoDAO.Insert(detPed, conexion, tran, ped.idPedido);
                    if (detPed.reservado == true)
                    {
                        ProductoDAO.UpdateStockReservadoYDisponible(detPed, conexion, tran);
                    }
                    if (detPed.reservado == false)
                    {
                        actualizarStock(detPed, conexion, tran, ped, productosConPocaMP);
                    }
                }
                tran.Commit();


            }
            catch (ArgumentException ex)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    tran.Rollback();
                }
                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    tran.Rollback();
                }
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {

                conexion.Close();
            }
        }
        public static int Insert(Pedido ped, List<Producto> productosConPocaMP)
        {
            Acceso ac = new Acceso();
            SqlTransaction tran = null;
            
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("sp_Pedido_insert", conexion);

            cmd.Parameters.AddWithValue("@idCliente", ped.cliente.idPersona );
            cmd.Parameters.AddWithValue("@idEstado", ped.estado.idEstado );
            cmd.Parameters.AddWithValue("@fechaPedido", ped.fechaPedido );
            cmd.Parameters.AddWithValue("@fechaNecesidad", ped.fechaNecesidad );
            cmd.Parameters.AddWithValue("@nroPedido", ped.nroPedido );
            cmd.Parameters.AddWithValue("@direccion", ped.dirEntraga);
            

            try
            {
                conexion.Open();
                tran = conexion.BeginTransaction();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();

                SqlCommand cmdIdentity = new SqlCommand("select @@Identity", conexion, tran);
                ped.idPedido = Convert.ToInt32((cmdIdentity.ExecuteScalar()));

                foreach (DetallePedido detPed in ped.detallePedido )
                {
                    //detPed.pedido.idPedido = ped.idPedido;
                    DetallePedidoDAO.Insert(detPed, conexion, tran, ped.idPedido);
                    if (detPed.reservado == true)
                    {
                        ProductoDAO.UpdateStockReservadoYDisponible(detPed, conexion, tran);
                    }
                    if (detPed.reservado == false)
                    {
                        actualizarStock(detPed, conexion, tran, ped,productosConPocaMP);
                    }

                }
                tran.Commit();
                return ped.idPedido;
               
            }
            catch (ArgumentException ex)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    tran.Rollback();
                }
                throw new ApplicationException(ex.Message);
            }
            catch (SqlException ex)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    tran.Rollback();
                } 
                throw new ApplicationException("Error en BD: " + ex.Message);
            }
            finally
            {
               
                conexion.Close();
            }
        }
        public static void actualizarStock(DetallePedido detPedido, SqlConnection con, SqlTransaction trans, Pedido pedido, List<Producto> productosConPocaMP)
        {
            DataTable ProductosIntermedio;
            DataTable MateriaPrima;
            DataTable DetallePlan;
            int idProductoFinal = 0;
            int idProductoIntermedio = 0;
            double cantidad = 0;

            idProductoFinal = detPedido.producto.idProducto;//OBTENEMOS EL ID DEL PRODUCTO FINAL
            cantidad = detPedido.cantidad;//OBTENEMOS LA CANTIDAD DE PRODUCTOS
            if (ProductoDAO.verificarProductoPlanificado(pedido.fechaNecesidad.Date, idProductoFinal, con,trans) == true)//PREGUNTAMOS SI PARA ESE PRODUCTO YA HAY UN DETALLE DEL PLAN PARA ESA FECHA Y ES TRUE
            {
                DetallePlan = DetallePlanProduccionDAO.GetDetallePlanXProducto(idProductoFinal, pedido.fechaNecesidad.Date,con, trans);//OBTENEMOS LOS DATOS DEL DETALLE DEL PLAN

                actualizarDetallePlanYPedidoXPlan(DetallePlan, pedido.idPedido, con, trans, cantidad);

                MateriaPrima = ProductoDAO.GetMateriaPrima(idProductoFinal,trans,con);//CARGAMOS EN LA TABLA LOS DATOS DE LAS MATERIAS PRIMAS
                DataTable MateriaPrimaXIntermedio = new DataTable();
                ProductosIntermedio = ProductoDAO.GetProductoIntermedio(idProductoFinal,con,trans);//CARGAMOS EN LA TABLA LOS DATOS DE LOS PRODUCTOS INTERMEDIO

                obtenerMateriasPrimas(MateriaPrima, MateriaPrimaXIntermedio, ProductosIntermedio, cantidad, idProductoFinal, con, trans, productosConPocaMP);
            }
            else
            {
                if (ProductoDAO.verificarPlanSinProducto(pedido.fechaNecesidad.Date, idProductoFinal, con, trans) == true)//PREGUNTAMOS SI PARA ESE PRODUCTO YA HAY UN DETALLE DEL PLAN PARA ESA FECHA Y ES TRUE
                {
                    Producto prodNuevo = new Producto();
                    prodNuevo.idProducto = idProductoFinal;
                    DetallePlanProduccion detallePlanProduccion = new DetallePlanProduccion()
                    {
                        fechaProduccion = pedido.fechaNecesidad,
                        idPlan = PlanMaestroProduccionDAO.obtenerIdPlan(pedido.fechaNecesidad.Date),
                        cantidadPLan = 0,
                        producto = prodNuevo,
                        cantidadPedido = double.Parse(cantidad.ToString())
                    };

                    cargarNuevoDetallePlanYPedidoXPlan(detallePlanProduccion, con, trans, pedido);

                    MateriaPrima = ProductoDAO.GetMateriaPrima(idProductoFinal,trans,con);//CARGAMOS EN LA TABLA LOS DATOS DE LAS MATERIAS PRIMAS
                    DataTable MateriaPrimaXIntermedio = new DataTable();
                    ProductosIntermedio = ProductoDAO.GetProductoIntermedio(idProductoFinal,con,trans);//CARGAMOS EN LA TABLA LOS DATOS DE LOS PRODUCTOS INTERMEDIO

                    obtenerMateriasPrimas(MateriaPrima, MateriaPrimaXIntermedio, ProductosIntermedio, cantidad, idProductoFinal, con, trans, productosConPocaMP);
                }
            }    

        }
        public static void renovarStock(DetallePedido detPedido, SqlConnection con, SqlTransaction trans, Pedido pedido, List<Producto> productosConPocaMP)
        {
            DataTable ProductosIntermedio;
            DataTable MateriaPrima;
            DataTable DetallePlan;
            int idProductoFinal = 0;
            int idProductoIntermedio = 0;
            double cantidad = 0;

            idProductoFinal = detPedido.producto.idProducto;//OBTENEMOS EL ID DEL PRODUCTO FINAL
            cantidad = detPedido.cantidad;//OBTENEMOS LA CANTIDAD DE PRODUCTOS
            if (ProductoDAO.verificarProductoPlanificado(pedido.fechaNecesidad.Date, idProductoFinal, con, trans) == true)//PREGUNTAMOS SI PARA ESE PRODUCTO YA HAY UN DETALLE DEL PLAN PARA ESA FECHA Y ES TRUE
            {
                DetallePlan = DetallePlanProduccionDAO.GetDetallePlanXProducto(idProductoFinal, pedido.fechaNecesidad.Date, con,trans);//OBTENEMOS LOS DATOS DEL DETALLE DEL PLAN

                renovarDetallePlanYPedidoXPlan(DetallePlan, pedido.idPedido, con, trans, cantidad);

                MateriaPrima = ProductoDAO.GetMateriaPrima(idProductoFinal, trans, con);//CARGAMOS EN LA TABLA LOS DATOS DE LAS MATERIAS PRIMAS
                DataTable MateriaPrimaXIntermedio = new DataTable();
                ProductosIntermedio = ProductoDAO.GetProductoIntermedio(idProductoFinal, con, trans);//CARGAMOS EN LA TABLA LOS DATOS DE LOS PRODUCTOS INTERMEDIO

                renovarMateriasPrimas(MateriaPrima, MateriaPrimaXIntermedio, ProductosIntermedio, cantidad, idProductoFinal, con, trans, productosConPocaMP);
            }
            //else
            //{
            //    if (ProductoDAO.verificarPlanSinProducto(pedido.fechaNecesidad.Date, idProductoFinal, con, trans) == true)//PREGUNTAMOS SI PARA ESE PRODUCTO YA HAY UN DETALLE DEL PLAN PARA ESA FECHA Y ES TRUE
            //    {
            //        Producto prodNuevo = new Producto();
            //        prodNuevo.idProducto = idProductoFinal;
            //        DetallePlanProduccion detallePlanProduccion = new DetallePlanProduccion()
            //        {
            //            fechaProduccion = pedido.fechaNecesidad,
            //            idPlan = PlanMaestroProduccionDAO.obtenerIdPlan(pedido.fechaNecesidad.Date),
            //            cantidadPLan = 0,
            //            producto = prodNuevo,
            //            cantidadPedido = double.Parse(cantidad.ToString())
            //        };

            //        cargarNuevoDetallePlanYPedidoXPlan(detallePlanProduccion, con, trans, pedido);

            //        MateriaPrima = ProductoDAO.GetMateriaPrima(idProductoFinal, trans, con);//CARGAMOS EN LA TABLA LOS DATOS DE LAS MATERIAS PRIMAS
            //        DataTable MateriaPrimaXIntermedio = new DataTable();
            //        ProductosIntermedio = ProductoDAO.GetProductoIntermedio(idProductoFinal, con, trans);//CARGAMOS EN LA TABLA LOS DATOS DE LOS PRODUCTOS INTERMEDIO

            //        obtenerMateriasPrimas(MateriaPrima, MateriaPrimaXIntermedio, ProductosIntermedio, cantidad, idProductoFinal, con, trans);
            //    }
            //}

        }
        public static void cargarNuevoDetallePlanYPedidoXPlan(DetallePlanProduccion detallePlanProd, SqlConnection con, SqlTransaction trans, Pedido ped)
        {
            DetallePlanProduccionDAO.Insert(detallePlanProd, con, trans, detallePlanProd.idPlan);//ACTUALIZAMOS LA CANTIDAD DE PRODUCTOS EN PEDIDO EN EL DETALLE PLAN PRODUCCION
            //DetallePlanProduccionDAO.insertarPlanProduccionXPedido(ped.idPedido, detallePlanProd.producto.idProducto, detallePlanProd.idPlan, detallePlanProd.fechaProduccion.Date,trans,con);

        }
        public static void obtenerMateriasPrimas(DataTable MateriaPrima, DataTable MateriaPrimaXIntermedio, DataTable ProductosIntermedio, double cantidad, int idProducto, SqlConnection con, SqlTransaction trans, List<Producto> ProductosConPocaMP)
        {
            for (int k = 0; k < MateriaPrima.Rows.Count; k++)
            {
                MateriaPrima.Rows[k]["cantidad"] = double.Parse(MateriaPrima.Rows[k]["cantidad"].ToString()) * cantidad;
            }
            for (int f = 0; f < ProductosIntermedio.Rows.Count; f++)//RECORREMOS LA TABLA DE PRODUCTOS INTERMEDIOS
            {
                if (ProductosIntermedio.Rows.Count != 0)
                {
                    double cantidadIntermedios = cantidad * double.Parse(ProductosIntermedio.Rows[f]["cantidad"].ToString());

                    MateriaPrimaXIntermedio = ProductoDAO.GetMateriaPrima(int.Parse(ProductosIntermedio.Rows[f]["idProductohijo"].ToString()),trans,con);//CARGAMOS EN LA TABLA LOS DATOS DE LAS MATERIAS PRIMAS DE LOS PRODUCTOS INTERMEDIOS
                    for (int j = 0; j < MateriaPrimaXIntermedio.Rows.Count; j++)
                    {
                        MateriaPrimaXIntermedio.Rows[j]["cantidad"] = double.Parse(MateriaPrimaXIntermedio.Rows[j]["cantidad"].ToString()) * cantidadIntermedios;
                    }
                }
            }
            MateriaPrima.Merge(MateriaPrimaXIntermedio, true);// YA TENEMOS DENTRO DE  LA TABLA MATERIA PRIMA TODOS LOS PRODUCTOS INSUMOS O MP QUE SE NECESITAN PARA UN PRODUCTO DEL PEDIDO QUE NO ESTE RESERVADO
            List<Producto> ProductosMP = new List<Producto>();
            for (int k = 0; k < MateriaPrima.Rows.Count; k++)
            {
                int idProdMP = 0;
                double cantidadMP = 0;
                idProdMP = int.Parse(MateriaPrima.Rows[k]["idProductohijo"].ToString());
                cantidadMP = double.Parse(MateriaPrima.Rows[k]["cantidad"].ToString());
                ProductoDAO.actualizarStockMateriasPrimas(idProdMP, cantidadMP, con, trans);
                ProductosMP = ProductoDAO.GetPeductosMPeInsumos(con, trans);
                foreach (Producto prod in ProductosMP)
                {
                    if (prod.idProducto == idProdMP)
                    {
                        if (prod.StockDisponible <= prod.StockRiesgo)
                        {
                            ProductosConPocaMP.Add(prod);
                        }
                        break;
                    }
                }
            }
        }
        public static void renovarMateriasPrimas(DataTable MateriaPrima, DataTable MateriaPrimaXIntermedio, DataTable ProductosIntermedio, double cantidad, int idProducto, SqlConnection con, SqlTransaction trans, List<Producto> productosConPocaMP)
        {
            for (int k = 0; k < MateriaPrima.Rows.Count; k++)
            {
                MateriaPrima.Rows[k]["cantidad"] = double.Parse(MateriaPrima.Rows[k]["cantidad"].ToString()) * cantidad;
            }
            for (int f = 0; f < ProductosIntermedio.Rows.Count; f++)//RECORREMOS LA TABLA DE PRODUCTOS INTERMEDIOS
            {
                if (ProductosIntermedio.Rows.Count != 0)
                {
                    double cantidadIntermedios = cantidad * double.Parse(ProductosIntermedio.Rows[f]["cantidad"].ToString());

                    MateriaPrimaXIntermedio = ProductoDAO.GetMateriaPrima(int.Parse(ProductosIntermedio.Rows[f]["idProductohijo"].ToString()), trans, con);//CARGAMOS EN LA TABLA LOS DATOS DE LAS MATERIAS PRIMAS DE LOS PRODUCTOS INTERMEDIOS
                    for (int j = 0; j < MateriaPrimaXIntermedio.Rows.Count; j++)
                    {
                        MateriaPrimaXIntermedio.Rows[j]["cantidad"] = double.Parse(MateriaPrimaXIntermedio.Rows[j]["cantidad"].ToString()) * cantidadIntermedios;
                    }
                }
            }
            MateriaPrima.Merge(MateriaPrimaXIntermedio, true);// YA TENEMOS DENTRO DE  LA TABLA MATERIA PRIMA TODOS LOS PRODUCTOS INSUMOS O MP QUE SE NECESITAN PARA UN PRODUCTO DEL PEDIDO QUE NO ESTE RESERVADO
            for (int k = 0; k < MateriaPrima.Rows.Count; k++)
            {
                int idProdMP = 0;
                double cantidadMP = 0;
                idProdMP = int.Parse(MateriaPrima.Rows[k]["idProductohijo"].ToString());
                cantidadMP = double.Parse(MateriaPrima.Rows[k]["cantidad"].ToString());
                ProductoDAO.actualizarStockMateriasPrimas(idProdMP, cantidadMP * -1, con, trans);
            }
        }
        public static void actualizarDetallePlanYPedidoXPlan(DataTable DetallePlan, int idPedido, SqlConnection con, SqlTransaction trans, double cantidad)
        {
            DetallePlanProduccionDAO.ActualizarDetallePlan(int.Parse(DetallePlan.Rows[0]["idProducto"].ToString()), cantidad, DateTime.Parse(DetallePlan.Rows[0]["fechaproduccion"].ToString()), con, trans);//ACTUALIZAMOS LA CANTIDAD DE PRODUCTOS EN PEDIDO EN EL DETALLE PLAN PRODUCCION
            DetallePlanProduccionDAO.insertarPlanProduccionXPedido(idPedido, int.Parse(DetallePlan.Rows[0]["idProducto"].ToString()), int.Parse(DetallePlan.Rows[0]["idPlan"].ToString()), DateTime.Parse(DetallePlan.Rows[0]["fechaProduccion"].ToString()),trans,con);
        }
        public static void renovarDetallePlanYPedidoXPlan(DataTable DetallePlan, int idPedido, SqlConnection con, SqlTransaction trans, double cantidad)
        {
            DetallePlanProduccionDAO.ActualizarDetallePlan(int.Parse(DetallePlan.Rows[0]["idProducto"].ToString()), cantidad * -1, DateTime.Parse(DetallePlan.Rows[0]["fechaproduccion"].ToString()), con, trans);//ACTUALIZAMOS LA CANTIDAD DE PRODUCTOS EN PEDIDO EN EL DETALLE PLAN PRODUCCION
            DetallePlanProduccionDAO.deletePlanXPedidoXidPedido(idPedido, con, trans);
        }
        public static List<Pedido> GetByFiltros(int est, int tipDoc, int? nroDoc, double? montoDesde, double? mostoHasta, string nom, string ape, string raSoc, int? cuit, DateTime? fdesde, DateTime? fhasta)
        {
            Acceso ac = new Acceso();

            List<Pedido> pedidos = new List<Pedido>();

            string sql = "SELECT * from CONSULTA_PEDIDOS where 1=1";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            if (est != -1 && est != 0)
            {
                sql += " and idEstado = @est";
                cmd.Parameters.AddWithValue("@est", est);
            }
            if (tipDoc != -1 && tipDoc != 0)
            {
                sql += " and idTipoDoc = @tipDoc";
                cmd.Parameters.AddWithValue("@tipDoc", tipDoc);
            }
            if (nroDoc.HasValue)
            {
                sql += " and nroDocumento = @nroDoc";
                cmd.Parameters.AddWithValue("@nroDoc", nroDoc);

            }
            if (montoDesde.HasValue)
            {
                sql += " and total >= @montoDesde";
                cmd.Parameters.AddWithValue("@montoDesde", montoDesde);

            }
            if (mostoHasta.HasValue)
            {
                sql += " and total <= @mostoHasta";
                cmd.Parameters.AddWithValue("@mostoHasta", mostoHasta);

            }
            if (!string.IsNullOrEmpty(ape))
            {
                sql += " and apellido = @apellido";
                cmd.Parameters.AddWithValue("@apellido", ape);
            }
            if (!string.IsNullOrEmpty(nom))
            {
                sql += " and nombre = @nombre";
                cmd.Parameters.AddWithValue("@nombre", nom);
            }
            if (!string.IsNullOrEmpty(raSoc))
            {
                sql += " and razonSocial = @raSoc";
                cmd.Parameters.AddWithValue("@raSoc", raSoc);
            }
            if (cuit.HasValue)
            {
                sql += " and CUIT = @cuit";
                cmd.Parameters.AddWithValue("@cuit", cuit);

            }
            if (fdesde.HasValue)
            {
                sql += " and fechaNecesidad >= @fdesde";
                cmd.Parameters.AddWithValue("@fdesde", fdesde.Value);
            }
            if (fhasta.HasValue)
            {
                sql += " and fechaNecesidad <= @fhasta";
                cmd.Parameters.AddWithValue("@fhasta", fhasta.Value);
            }

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Pedido p;
                Estado e;
                Persona c;
                TipoDocumento t;

                while (dr.Read())
                {
                    c = new Persona();
                    t = new TipoDocumento();

                    t.IDTipoDoc = Convert.ToInt32(dr["idTipoDoc"]);

                    c.RazonSocial = dr["razonSocial"].ToString();
                    c.Nombre = dr["nombre"].ToString();
                    c.Apellido = dr["apellido"].ToString();
                    c.cuil = dr["CUIT"].ToString();
                    c.NroDoc = Convert.ToInt32(dr["nroDocumento"]);
                    c.TipoDoc = t;



                    e = new Estado();

                    e.idEstado = Convert.ToInt32(dr["idEstado"]);
                    e.Nombre = dr["estado"].ToString();


                    p = new Pedido();

                    p.idPedido = Convert.ToInt32(dr["idPedido"]);
                    p.fechaNecesidad = Convert.ToDateTime(dr["fechaNecesidad"]);
                    p.fechaPedido = Convert.ToDateTime(dr["fechaPedido"]);
                    p.montoTotal = Convert.ToDouble(dr["total"]);
                    p.nroPedido = Convert.ToInt32(dr["nroPedido"]);
                    p.dirEntraga = dr["direccion"].ToString();
                    p.estado = e;
                    p.cliente = c;

                    pedidos.Add(p);


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


            return pedidos;

        }
        public static List<Pedido> GetAll()
        {
            Acceso ac = new Acceso();

            List<Pedido> pedidos = new List<Pedido>();

            string sql = "SELECT * from CONSULTA_PEDIDOS ORDER BY idPedido DESC";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Pedido  p;
                Estado  e;
                Persona c;
                TipoDocumento t;

                while (dr.Read())
                {
                    c = new Persona();
                    t = new TipoDocumento();

                    t.IDTipoDoc = Convert.ToInt32(dr["idTipoDoc"]);

                    c.RazonSocial = dr["razonSocial"].ToString();
                    c.Nombre  = dr["nombre"].ToString();
                    c.Apellido  = dr["apellido"].ToString();
                    c.cuil = dr["CUIT"].ToString();
                    c.NroDoc = Convert.ToInt32(dr["nroDocumento"]);
                    c.TipoDoc = t;

                    
                    
                    e  = new Estado ();

                   e.idEstado  = Convert.ToInt32(dr["idEstado"]);
                   e.Nombre  = dr["estado"].ToString();
                    

                    p = new Pedido();

                    p.idPedido  = Convert.ToInt32(dr["idPedido"]);
                    p.fechaNecesidad  = Convert.ToDateTime(dr ["fechaNecesidad"]);
                    p.fechaPedido  = Convert.ToDateTime(dr["fechaPedido"]);
                    p.montoTotal = Convert.ToDouble(dr["total"]);
                    p.nroPedido = Convert.ToInt32(dr["nroPedido"]);
                    p.dirEntraga=dr["direccion"].ToString();
                    p.estado = e;
                    p.cliente = c;
                    
                    pedidos.Add(p);


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


            return pedidos;

        }
        public static Pedido GetById(int id)
        {
            Acceso ac = new Acceso();

            Pedido p  = new Pedido();
            
            SqlCommand cmd = new SqlCommand();
            string sql = "SELECT * from CONSULTA_PEDIDOS where idPedido=@id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            try
            {
                conexion.Open();

                cmd.Connection = conexion;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();


                CondicionIVA ci;
                Persona c;
                TipoDocumento t;

                while (dr.Read())
                {
                    ci = new CondicionIVA();
                    ci.idCondicionIVA = Convert.ToInt32(dr["iva"]);
                    c = new Persona();
                    t = new TipoDocumento();

                    t.IDTipoDoc = Convert.ToInt32(dr["idTipoDoc"]);
                    c.idPersona = Convert.ToInt32(dr["idPersona"]);
                    c.RazonSocial = dr["razonSocial"].ToString();
                    c.Nombre = dr["nombre"].ToString();
                    c.Apellido = dr["apellido"].ToString();
                    c.cuil = dr["CUIT"].ToString();
                    c.NroDoc = Convert.ToInt32(dr["nroDocumento"]);
                    c.tefefonoCelular = dr["telefonoCelular"].ToString();
                    c.condicionIVA = ci ;
                    c.TipoDoc=t;
   

                    p.idPedido = Convert.ToInt32(dr["idPedido"]);
                    p.fechaNecesidad = Convert.ToDateTime(dr["fechaNecesidad"]);
                    p.fechaPedido = Convert.ToDateTime(dr["fechaPedido"]);
                    p.montoTotal = Convert.ToDouble(dr["total"]);
                    p.nroPedido = Convert.ToInt32(dr["nroPedido"]);
                    p.dirEntraga = dr["direccion"].ToString();
                    p.cliente = c;

                    


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


            return p;

        }
        public static void UpdateEstados(int idPedido, int idEstado)
        {
            Acceso ac = new Acceso();
            
            SqlConnection conexion = new SqlConnection(ac.getCadenaConexion());

            SqlCommand cmd = new SqlCommand("UPDATE [Luiggi].[dbo].[Pedido] SET [idEstado] = @idEstado WHERE idPedido = @idPedido", conexion);

            cmd.Parameters.AddWithValue("@idPedido", idPedido);
            cmd.Parameters.AddWithValue("@idEstado", idEstado);
            

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
    }
}
