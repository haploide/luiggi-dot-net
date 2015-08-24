using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;

namespace Controlador
{
    public  class GestorConsultarCliente
    {
        int nroCliente; 
        public void nroClienteTomado(int nroCli)
        {
            nroCliente = nroCli;
        }
        public List<TipoDocumento> buscarTipoDoc()
        {
            return TipoDocumentoDAO.GetAll();
        }
        public List<Provincia> buscarProvincias()
        {
            return ProvinciaDAO.GetAll();
        }
        public static List<Persona> buscarPersonas()
        {
            try
            {
                return PersonaDAO.GetAll();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public void eliminacionConfirmada()
        {
            try
            {
                PersonaDAO.Delete(nroCliente);
            }
            catch(ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
