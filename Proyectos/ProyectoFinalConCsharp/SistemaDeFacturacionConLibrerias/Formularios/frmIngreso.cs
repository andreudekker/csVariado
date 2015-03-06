using SistemaDeFacturacionConLibrerias.Clases;
using SistemaDeFacturacionConLibrerias.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeFacturacionConLibrerias
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            #region validacion de ingreso de datos no este vacio el texbox
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe Ingresar usuario");
                txtUsuario.Focus();
                return;
            }
            if (txtClave.Text == "")
            {
                MessageBox.Show("Debe Ingresar una clave");
                txtClave.Focus();
                return;
            }
            #endregion

            if (Datos.ValidarUsuario(txtUsuario.Text, txtClave.Text))
            {
                MessageBox.Show(Datos.Mensaje);
                txtUsuario.Focus();
                return;
            }
            this.Hide();
            frmPrincipal f = new frmPrincipal();
            f.Show();

        }
    }
}
