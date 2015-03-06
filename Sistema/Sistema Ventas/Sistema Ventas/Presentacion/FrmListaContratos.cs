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
    public partial class FrmListaContratos : DevComponents.DotNetBar.Office2007Form
    {
        public static bool nuevo = false;
        public static bool modif = false;
        public static Contrato con = null;
        public static string emp;
        public FrmListaContratos()
        {
            InitializeComponent();
        }

        private void FrmListaContratos_Load(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void VerDatos()
        {
            var aux = new EmpleadoContratado();
            aux.dni = tbxDNI.Text.Trim();
            aux.Cargo = tbxCargo.Text.Trim();
            aux.Estado = "1";
            dgvListaEmpleados.Rows.Clear();
            foreach (var item in NEmpladoContratado.ListaEntidades(aux))
            {
                dgvListaEmpleados.Rows.Add(item.IdContrato, item.IdEmpleado, item.Empleado, item.dni, item.Fec_ini, item.Fec_fin, item.Nick, item.Clave, item.Cargo, item.Turno, item.Estado);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            var f = new FrmContrato();
            f.ShowDialog();
            VerDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListaEmpleados.CurrentRow.Selected == false)
            {
                MessageBox.Show("Seleccione un registro", "Aviso");
            }
            else if (dgvListaEmpleados.CurrentRow.Selected == true)
            {
                modif = true;
                var f = new FrmContrato();
                f.ShowDialog();
                VerDatos();
            }
        }

        private void dgvListaEmpleados_Click(object sender, EventArgs e)
        {
            if (dgvListaEmpleados.SelectedRows.Count > 0)
            {
                con = new Contrato();
                con.IdContrato = (int)dgvListaEmpleados.CurrentRow.Cells[0].Value;
                con.IdEmpleado = (int)dgvListaEmpleados.CurrentRow.Cells[1].Value;
                emp = (string)dgvListaEmpleados.CurrentRow.Cells[3].Value;
                con.Fec_ini = (DateTime)dgvListaEmpleados.CurrentRow.Cells[4].Value;
                con.Fec_fin = (DateTime)dgvListaEmpleados.CurrentRow.Cells[5].Value;
                con.Nick= (string)dgvListaEmpleados.CurrentRow.Cells[6].Value;
                con.Clave = (string)dgvListaEmpleados.CurrentRow.Cells[7].Value;
                con.Cargo = (string)dgvListaEmpleados.CurrentRow.Cells[8].Value;
                con.Turno = (string)dgvListaEmpleados.CurrentRow.Cells[9].Value;
                con.Estado = (string)dgvListaEmpleados.CurrentRow.Cells[10].Value;
                btnModificar.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxDNI_TextChanged(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void dgvListaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
        }

    }
}
