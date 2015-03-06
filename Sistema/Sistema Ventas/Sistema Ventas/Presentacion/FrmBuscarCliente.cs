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
    public partial class FrmBuscarCliente : DevComponents.DotNetBar.Office2007Form
    {
        
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void VerDatos()
        {
            var aux = new Cliente();
            aux.dni = tbxDNI.Text.Trim();
            aux.Nombres = tbxNom.Text.Trim();
            aux.Apellidos = "";
            dgvListaClientes.Rows.Clear();
            foreach (var item in NCliente.ListaEntidades(aux))
            {
                dgvListaClientes.Rows.Add(item.IdCliente, item.Nombres + " " + item.Apellidos, item.dni, item.Tipo_persona, item.Razon_social, item.ruc, item.Fec_nacimiento, item.Estado_civil, item.Direccion, item.IdDistrito);
            }
        }

        private void dgvListaClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvListaClientes.Rows.Count>0)
            {
                
                if (FrmLineaCredito.credito==true)
                {
                    var f = dgvListaClientes.CurrentRow;
                    FrmLineaCredito.cli.IdCliente = (int)f.Cells[0].Value;
                    FrmLineaCredito.cli.Nombres = (string)f.Cells[1].Value;
                    FrmLineaCredito.cli.dni = (string)f.Cells[2].Value;
                    FrmLineaCredito.credito = false;
                    Close();
                }
                
            }
        }

        private void tbxDNI_TextChanged(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
