using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class FrmAvisoLineaCredito : DevComponents.DotNetBar.Office2007Form
    {
        public FrmAvisoLineaCredito()
        {
            InitializeComponent();
        }

        private void FrmAvisoLineaCredito_Load(object sender, EventArgs e)
        {
            var idcli = FrmVentas.cli.IdCliente;
            var aux = new LineaCredito();
            aux.IdCliente = idcli;
            foreach (var item in NLinea_credito.ListadoFiltroLinCredito(aux))
	        {
                aux.IdLinea_credito = item.IdLinea_credito;
                label3.Text = Convert.ToString( item.cme);
                label4.Text = Convert.ToString( item.cmedisponible);
	        }
        }

        private void FrmAvisoLineaCredito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Hide();
            }
        }
    }
}
