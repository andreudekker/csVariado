using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace Presentacion
{
    public partial class FrmListaClientes : DevComponents.DotNetBar.Office2007Form
    {
        //public static int idcli, iddis;
        ////public static string dni, nom, ape,tip,raz,ruc, est_civ, dir;
        //public static DateTime fec_nac;
        public static bool nuevo = false;
        public static bool modif = false;
        public static Cliente c = null;
        public FrmListaClientes()
        {
            InitializeComponent();
        }
        private void VerDatos()
        {
            var dni = tbxDNI.Text.Trim();
            var nom = tbxNom.Text;
            var ape = tbxApe.Text;
            var aux = new Cliente();
            aux.dni = dni;
            aux.Nombres = nom;
            aux.Apellidos = ape;
            var lista = NCliente.ListaEntidades(aux);
            dgvListaClientes.Rows.Clear();
            foreach (var item in lista)
            {
                dgvListaClientes.Rows.Add(item.IdCliente, item.Nombres, item.Apellidos, item.dni,item.Tipo_persona,item.Razon_social,item.ruc, item.Fec_nacimiento, item.Estado_civil, item.Direccion, item.IdDistrito);

            }
        }
        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void tbxDNI_TextChanged(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dgvListaClientes.RowCount>0)
            {
                if (dgvListaClientes.SelectedRows.Count>0)
                {
                    if (FrmVentas.venta == true)
                    {
                        //FrmVentas. cli = new Cliente();
                        var f = dgvListaClientes.CurrentRow;
                        FrmVentas.cli.IdCliente = (int)f.Cells[0].Value;
                        FrmVentas.cli.Nombres = (string)f.Cells[1].Value;
                        FrmVentas.cli.Apellidos = (string)f.Cells[2].Value;
                        FrmVentas.venta = false;
                        Close();
                    }
                    c = new Cliente();
                    c.IdCliente = (int)dgvListaClientes.CurrentRow.Cells[0].Value;
                    c.dni = (string)dgvListaClientes.CurrentRow.Cells[3].Value;
                    c.Nombres = (string)dgvListaClientes.CurrentRow.Cells[1].Value;
                    c.Apellidos = (string)dgvListaClientes.CurrentRow.Cells[2].Value;
                    c.Tipo_persona = (string)dgvListaClientes.CurrentRow.Cells[4].Value;
                    c.Razon_social = (string)dgvListaClientes.CurrentRow.Cells[5].Value;
                    c.ruc = (string)dgvListaClientes.CurrentRow.Cells[6].Value;
                    c.Fec_nacimiento = (DateTime)dgvListaClientes.CurrentRow.Cells[7].Value;
                    c.Estado_civil = (string)dgvListaClientes.CurrentRow.Cells[8].Value;
                    c.Direccion = (string)dgvListaClientes.CurrentRow.Cells[9].Value;
                    c.IdDistrito = (int)dgvListaClientes.CurrentRow.Cells[10].Value;
                    btnModificar.Enabled = true;
                }
                
            }
            
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListaClientes.RowCount>0)
            {
                if (dgvListaClientes.CurrentRow.Selected == false)
                {
                    MessageBox.Show("Seleccione un registro", "Aviso");
                }
                else if (dgvListaClientes.CurrentRow.Selected == true)
                {
                    modif = true;
                    var f = new FrmClientes();
                    f.ShowDialog();
                    VerDatos();
                }
            }
            else
            {
                MessageBox.Show("No existe cientes", "Aviso");
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var f = new FrmClientes();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            var f = new FrmClientes();
            f.ShowDialog();
            VerDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {

        }

    }
}
