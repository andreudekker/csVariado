using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPago2 : DevComponents.DotNetBar.Office2007Form
    {
        public static string res = "no";
        public FrmPago2()
        {
            InitializeComponent();
        }

        private void FrmPago2_Load(object sender, EventArgs e)
        {
            tbxTotal.Text = FrmPagoCuotas.debe. ToString("0.00");
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (tbxBillete.Text.Trim().Length > 0)
            {
                //FrmPagoCuotas.debe = conver tbxTotal.Text.Trim();
                //var aux = new Venta();
                //aux.Nro_venta = FrmCaja.aux.Nro_venta;
                //var id = NListarVenta.ObtenerIDVenta(aux);
                //var aux2 = new Venta();
                //aux2.IdVenta = id;
                //aux2.Estado = "1";
                //aca se cambia el estado de la venta de preventa a 1
                //if (NVenta.Cobrar(aux2))
                //{
                //    MessageBox.Show("Cobro efectuado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    //ImprimirBoleta();
                //    Close();
                
                if (Convert.ToSingle( tbxBillete.Text.Trim()) >Convert.ToSingle( tbxTotal.Text))
                {
                    FrmPagoCuotas.paga_con = Convert.ToSingle(tbxBillete.Text.Trim());
                    res = "si";
                    Close();
                }
                //}
            }
        }

        private void tbxBillete_TextChanged(object sender, EventArgs e)
        {
            if (tbxBillete.Text.Trim().Length > 0)
            {
                var b = Convert.ToSingle(tbxBillete.Text);
                var d = b - FrmPagoCuotas.debe;
                tbxVuelto.Text = Convert.ToSingle(decimal.Round(Convert.ToDecimal(d), 2)).ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            res = "no";
        }
    }
}
