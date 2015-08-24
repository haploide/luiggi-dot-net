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
    public partial class EmitirOrdenDeCompra : Form
    {
        private int idOrden;



        public int _idOrden
        {
            get { return idOrden; }
            set { idOrden = value; }
        }
        public EmitirOrdenDeCompra()
        {
            InitializeComponent();
        }

        private void EmitirOrdenDeCompra_Load(object sender, EventArgs e)
        {
            OrdenDeCompraBindingSource.DataSource = OrdenDeCompraDAO.GetAllEmitir(idOrden);

            this.reportViewer1.RefreshReport();
        }
    }
}
