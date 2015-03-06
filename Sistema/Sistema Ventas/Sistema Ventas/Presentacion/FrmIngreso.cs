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
    public partial class FrmIngreso : DevComponents.DotNetBar.Office2007Form
    {
        public static int con=0,idempleado=0;
        public static string tipo = "",empleado="";
        public FrmIngreso()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //int con=1;
            var aux = new Contrato();
            aux.Nick=tbxxNick.Text.Trim();
            aux.Clave = tbxxClave.Text.Trim();
            if (NContrato.Ingreso(aux)>=1)
            {
                tipo = NContrato.TipoIngreso(aux);
                idempleado = NContrato.IdEmpleadoIngreso(aux);
                empleado = NContrato.EmpleadoIngreso(aux);
                var f = new FrmPrincipal();
                f.Show();
                Hide();
                
            }
            else
            {
                if (con<3)
                {
                    MessageBox.Show("Datos incorrectos, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con++;
                }
                else
                {
                    MessageBox.Show("Lo sentimos,Usted ha excedido el maximo numero de intentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
                
                
            }
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            //tbxxNick.Focus();
            if (NEmpresa.Existe()==0)
            {
                MessageBox.Show("Bienvenido al Sistema de ventas SAV, Usted, usuario nuevo debe ingresar los datos de la empresa con la que desea trabajar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var g = new FrmIngreso();
                g.Visible = false;
                var f = new FrmEmpresa();
                f.ShowDialog();
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"C:\\Program Files\Sistema de Ventas SAV\SAV\SAV\Manual de Usuario.pdf";
            proc.Start();
            proc.Close();
            
        }
    }
}
