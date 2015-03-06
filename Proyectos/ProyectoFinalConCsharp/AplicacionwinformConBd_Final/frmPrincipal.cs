using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionwinformConBd_Final
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // salir de la aplicacion
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos f = new frmProductos();
            f.MdiParent = this;
            f.Show();
        }

    
    }
}
