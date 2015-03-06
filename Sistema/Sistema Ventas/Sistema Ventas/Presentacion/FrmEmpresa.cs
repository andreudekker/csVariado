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
    public partial class FrmEmpresa : DevComponents.DotNetBar.Office2007Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            if (tbxraz.Text.Length>0 && tbxDireccion.Text.Length>0 && tbxTelefono.Text.Length>0)
            {
                var emp = new Empresa();
                emp.Razon_social = tbxraz.Text.Trim().ToUpper();
                emp.Direccion = tbxDireccion.Text.Trim().ToUpper();
                emp.Telefono = tbxTelefono.Text.Trim().ToUpper();
                if (NEmpresa.Guardar(emp))
                {
                    MessageBox.Show("Empresa registrada correctamente correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var g = new FrmIngreso();
                    g.Show();
                    Hide();
                }
            }
        }

        private void tbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)  || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("Introduzca solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
