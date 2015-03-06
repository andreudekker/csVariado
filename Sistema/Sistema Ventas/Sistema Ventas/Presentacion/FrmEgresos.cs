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
    public partial class FrmEgresos : DevComponents.DotNetBar.Office2007Form
    {
        public FrmEgresos()
        {
            InitializeComponent();
        }

        private void FrmEgresos_Load(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            var egre = new Egresos();
            if (tbxMonto.Text.Length>0 && tbxMotivo.Text.Length>0)
            {
                egre.IdEmpleado = FrmIngreso.idempleado;
                egre.Monto = Convert.ToSingle(tbxMonto.Text);
                egre.Motivo = tbxMotivo.Text;
                egre.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                if (MessageBox.Show("¿Guardar datos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (NEgreso.Guardar(egre))
                    {
                        MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Asegurese de ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
