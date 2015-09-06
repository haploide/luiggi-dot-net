using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;

namespace Vista
{
    public partial class Emitir_Factura : Form
    {

        
        public Emitir_Factura()
        {
            InitializeComponent();
        }

        private void Emitir_Factura_Load(object sender, EventArgs e)
        {
            FacturaBindingSource.DataSource = FacturaDAO.GetAllEmitir(iniciador.idFactura);
            this.reportViewer1.RefreshReport();
        }
    }
}
