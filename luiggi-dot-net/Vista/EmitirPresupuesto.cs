using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Controlador;
using DAO;


namespace Vista
{
    public partial class EmitirPresupuesto : Form
    {
        private DataTable cargarPresupuesto; 
        public EmitirPresupuesto()
        {
            InitializeComponent();
        }
        public DataTable _cargarPresupuesto
        {
            get { return cargarPresupuesto; }
            set { cargarPresupuesto = value; }
        }

        private void EmitirPresupuesto_Load(object sender, EventArgs e)
        {
           
            PresupuestoBindingSource.DataSource = cargarPresupuesto;
            this.reportViewer1.RefreshReport();
        }

        
    }
}
