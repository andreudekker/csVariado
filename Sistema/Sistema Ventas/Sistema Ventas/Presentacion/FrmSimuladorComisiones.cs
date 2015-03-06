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
    public partial class FrmSimuladorComisiones : DevComponents.DotNetBar.Office2007Form
    {
        public FrmSimuladorComisiones()
        {
            InitializeComponent();
        }

        private void FrmSimuladorComisiones_Load(object sender, EventArgs e)
        {
            tbxDNI.Focus();
        }

        private void tbxDNI_TextChanged(object sender, EventArgs e)
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
            string dni = tbxDNI.Text.Trim();
            if (dni.Length<8)
            {
                MessageBox.Show("El dni debe tener 8 digitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(dni.Length==8)
            {
                foreach (var item in NConsultaVentas.SimuladorComisiones(dni))
                {
                    tbxVendedor.Text = item.Vendedor;
                    tbxUltimaVenta.Text = item.Ultima_Venta.ToString(("0.00"));
                    tbxtipo.Text = item.Tipo_venta.Trim();
                    tbxDesc.Text = item.DescuentoAcumulado.ToString("0.00");

                }
                foreach (var item in NConsultaVentas.SimuladorComisiones2(dni))
                {

                    tbxComision.Text = item.TotalComision.ToString("0.00");
                    tbxProyeccion.Text = item.Proyeccion.ToString("0.00");
                }
            }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
