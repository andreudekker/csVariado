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
    public partial class FrmPrincipal : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public static int cont;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ribbonBar5.Visible = false;
            if (FrmIngreso.tipo.Trim()=="Vendedor")
            {
                //buttonItem19.Enabled = false;
                //buttonItem22.Enabled = false;
                //buttonItem23.Enabled = false;
                //buttonItem24.Enabled = false;
                //buttonItem25.Enabled = false;
                ribbonTabItem5.Visible = false;
                ribbonTabItem4.Visible = false;
                ribbonTabItem6.Visible = false;
                ribbonBar3.Visible = false;
            }
            else if (FrmIngreso.tipo.Trim()=="Cajero")
            {
                ribbonTabItem1.Visible = false;
                ribbonTabItem2.Visible = false;
                ribbonTabItem5.Visible = false;
                ribbonBar3.Visible = false;
            }
            else if (FrmIngreso.tipo.Trim()=="Almacen")
            {
                ribbonTabItem1.Visible = false;
                ribbonTabItem2.Visible = false;
                ribbonTabItem4.Visible = false;
                ribbonTabItem5.Visible = false;
                ribbonTabItem6.Visible = false;
                ribbonBar3.Visible = false;
            }
            else if (FrmIngreso.tipo.Trim()=="Agentecrediticio")
            {
                ribbonTabItem1.Visible = false;
                ribbonTabItem4.Visible = false;
                ribbonTabItem6.Visible = false;
                ribbonBar3.Visible = false;
            }
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            var f = new FrmListaEmpleados();
            f.MdiParent = this;
            f.Show();
            //cont = cont + 1;
            //if (cont < 2)
            //{
            //    //About ab = new About();
            //    f.WindowState = FormWindowState.Normal;
            //    f.Show();
            //    cont += 1;
            //}   
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            //var f = new FrmListaEmpleados();
            ////var g = new FrmPrincipal();
            //f.IsMdiContainer = this;
            //f.Show();
            //var f=new FrmPrincipal();
            var f = new FrmListaClientes();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            var f = new FrmListaContratos();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            var f = new FrmVentas();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            var f = new FrmLineaCredito();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            var f = new FrmCaja();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            var f = new FrmRankingVendedores();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem25_Click(object sender, EventArgs e)
        {
            var f = new FrmSimuladorComisiones();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem15_Click_1(object sender, EventArgs e)
        {
            var f = new FrmEntregaProductos();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem27_Click(object sender, EventArgs e)
        {
            var f = new FrmIngresoProductos();
            f.MdiParent = this;
            f.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            var f = new FrmEstadoCuenta();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            var f = new FrmEstadoCuenta();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem29_Click(object sender, EventArgs e)
        {
            var f = new FrmPagoCuotas();
            f.MdiParent = this;
            f.Show();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonItem30_Click(object sender, EventArgs e)
        {
            var f = new FrmListaProductos();
            f.MdiParent = this;
            f.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult res=MessageBox.Show("Esta seguro que desea salir del sistema", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (res == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else
            //{

            //}
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            var f = new FrmListaCategorias();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            var f = new FrmEgresos();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem28_Click(object sender, EventArgs e)
        {
            var f = new FrmCierreCaja();
            f.MdiParent = this;
            f.Show();
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
