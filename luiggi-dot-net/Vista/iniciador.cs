using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;


namespace Vista
{
    public enum RegistrarPersona
    {
        cliente,
        proveedor
    }
    public enum estados
    {
        nuevo,
        modificar,
        guardado
    }
    public enum termino
    {
        aprobado,
        rechazado
    }
    public enum reporteOT
    {
        final,
        intermedio
    }
    public class iniciador
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu_Principal());
            //Application.Run(new Inicio_Sesion());
        }

        public static Persona per=null;
        public static OrdenDeTrabajo otHija = null;
        public static int idFactura = 0;
        public static List<DetalleFactura> detalle = null;
        public static int cantVentanasAbiertas = 0; 
    }
}
