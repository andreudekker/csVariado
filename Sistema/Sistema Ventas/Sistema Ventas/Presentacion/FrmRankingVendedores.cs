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
    public partial class FrmRankingVendedores : DevComponents.DotNetBar.Office2007Form
    {
        public static float total = 0;
        public static DateTime fec_ini;
        public static DateTime fec_fin;
        public FrmRankingVendedores()
        {
            InitializeComponent();
        }

        private void FrmRankingVendedores_Load(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void VerDatos()
        {
            fec_ini = Convert.ToDateTime(dtpfec_ini.Value.ToShortDateString());
            fec_fin = Convert.ToDateTime(dtpfec_fin.Value.ToShortDateString());
            dgvLista.Rows.Clear();
            foreach (var item in NConsultaVentas.RankingVendedores(fec_ini, fec_fin))
            {
                dgvLista.Rows.Add(item.dni, item.Vendedor, item.ValorVentas, item.cantidad);
            }
            foreach (DataGridViewRow item in dgvLista.Rows)
            {
                total += Convert.ToSingle(item.Cells[2].Value);
            }
            tbxTotal.Text = total.ToString();
        }
           

        private void dtpfec_fin_ValueChanged(object sender, EventArgs e)
        {
            VerDatos();
            
        }
    }
}
