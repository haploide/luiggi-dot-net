using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;


namespace Controlador
{
    public  class GestorRegistrarCliente
    {
        private string CUIT;
        private TipoDocumento tipoDoc;
        private long nroDoc;
        private Localidad localidad;
        private string barrio;
        private string email;
        private string telefono;
        private String celular;
        private int dpto;
        private int pisoPer;
        private int nroCalle;
        private string razonSocial;
        private string apellido;
        private string nombre;
        private string calle;
        private int codCliente;
        private CondicionIVA condIva;
        private TipoConsumidor tipoCons;
        private DateTime fechaNac;
        private Char sexo;


        public void datosClienteIngresados(string cui, long nro, TipoDocumento tip)
        {
            CUIT = cui;
            tipoDoc = tip;
            nroDoc = nro;

        }
        public void datosPersonales(Localidad loc, string barr, string mail, string tel, int depar, int piso, int nro, string call, string razon, string ape, string nom, string cel, CondicionIVA iva, TipoConsumidor tipocon, DateTime fecha, Char sex)
        {
            localidad = loc;
            barrio = barr;
            email = mail;
            telefono = tel;
            dpto = depar;
            pisoPer = piso;
            nroCalle = nro;
            razonSocial = razon;
            apellido = ape;
            nombre = nom;
            calle = call;
            celular = cel;
            condIva = iva;
            tipoCons = tipocon;
            fechaNac = fecha;
            sexo = sex;
        }
        public void confirmar()
        {
            try
            {
                crearCliente();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public void modificacionConfirmada()
        {
            try
            {
                modificarCliente();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public void codigoTomado(int cod)
        {
            codCliente = cod;
        }
        public void nuevoCliente()
        {
            
        }
        public void crearCliente()
        {
            buscarUltimoNroCliente();
            Persona per = new Persona()
            {
                NroCliente = codCliente,
                cuil=CUIT,
                TipoDoc=tipoDoc,
                NroDoc=nroDoc,
                Localidad=localidad,
                Barrio=barrio,
                mail=email,
                telefono=telefono,
                depto=dpto,
                piso=pisoPer,
                calle_nro=nroCalle,
                RazonSocial=razonSocial,
                Apellido=apellido,
                Nombre=nombre,
                calle=calle,
                condicionIVA=condIva,
                tipoConsumidor=tipoCons,
                tefefonoCelular=celular,
                fechaNAc=fechaNac,
                Sexo=sexo

            };
            try
            {
                PersonaDAO.Insert(per);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public void modificarCliente()
        {
            Persona per = new Persona()
            {
                NroCliente = codCliente,
                Localidad = localidad,
                Barrio = barrio,
                mail = email,
                TipoDoc=tipoDoc,
                telefono = telefono,
                depto = dpto,
                piso = pisoPer,
                calle_nro = nroCalle,
                RazonSocial = razonSocial,
                Apellido = apellido,
                Nombre = nombre,
                calle = calle,
                NroDoc=nroDoc,
                cuil=CUIT,
                condicionIVA=condIva,
                tipoConsumidor=tipoCons,
                tefefonoCelular=celular,
                fechaNAc=fechaNac,
                Sexo=sexo
            };
            try
            {
                PersonaDAO.Update(per);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public void buscarUltimoNroCliente()
        {
            codCliente = SingletonNumeroClienteDAO.GetInstacia().getNumeroCliente();
        }
        public Boolean verificarExistenciaCliente()
        {
            Boolean resul = false;
            if (!(nroDoc==0) && CUIT==String.Empty)
	        {
	        	try
                {
                    List<Persona> personas = PersonaDAO.GetAll();

                    foreach (Persona per in personas)
                    {
                            if (per.NroDoc.Equals(nroDoc)&&per.TipoDoc.IDTipoDoc.Equals(tipoDoc.IDTipoDoc))
                            {
                                 resul = true;
                    }
                    }
                }
                catch (ApplicationException ex)
                {
                    throw new ApplicationException(ex.Message);
                } 
	        }
            if (!(CUIT == String.Empty) && nroDoc == 0)
            {
                try
                {
                    List<Persona> personas = PersonaDAO.GetAll();

                    foreach (Persona per in personas)
                    {
                        if (per.cuil.Equals(CUIT))
                        {
                            resul = true;
                        }
                    }
                }
                catch (ApplicationException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
            }


            return resul;
        }
        public List<TipoDocumento > buscarTipoDoc()
        {
            return TipoDocumentoDAO.GetAll();
        }
        public List<Provincia > buscarProvincias()
        {
            return ProvinciaDAO.GetAll();
        }
        public List<Localidad> buscarLocalidades(int pro)
        {
            return LocalidadDAO.GetLocalidadXProvincia(pro);
        }
    }
}
