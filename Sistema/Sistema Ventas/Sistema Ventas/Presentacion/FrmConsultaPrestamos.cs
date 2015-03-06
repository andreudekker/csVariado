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
    public partial class FrmConsultaPrestamos : DevComponents.DotNetBar.Office2007Form
    {
        public static int idpres;
        public FrmConsultaPrestamos()
        {
            InitializeComponent();
        }

        private void FrmConsultaPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void tbxDNI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                buttonX1.PerformClick();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var dni = tbxDNI.Text.Trim();
            idpres = NPrestamo.ObtenerIdPrestamo(dni);
            var aux = new Pago();
            aux.IdPrestamo = idpres;
            foreach (var item in NPagos.ListEntidades(aux))
            {
                dataGridViewX1.Rows.Add(item.IdPago, item.IdPrestamo, item.Nro, item.Fec_vencimiento, item.Capital, item.Interes, item.Cuota, item.Desgravamen, item.itf, item.Total, item.Debe, item.Fec_pago);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
