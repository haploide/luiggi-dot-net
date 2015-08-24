using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;

namespace Controlador
{
    public class GestorDeFiltros
    {
        public static List<Persona> filtrarCliente(Persona per)
        {
            try
            {
                return PersonaDAO.GetByFiltro(per);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
