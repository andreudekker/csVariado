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
    public partial class FrmBuscarEmpleado : DevComponents.DotNetBar.Office2007Form
    {
        public FrmBuscarEmpleado()
        {
            InitializeComponent();
        }

      

        private void dgvListaEmpleados_DoubleClick(object sender, EventArgs e)
        {
            if (FrmContrato.contrato==true)
            {
                FrmContrato.idempleado = (int)dgvListaEmpleados.CurrentRow.Cells[0].Value;
                FrmContrato.empleado = dgvListaEmpleados.CurrentRow.Cells[1].Value + " " + dgvListaEmpleados.CurrentRow.Cells[2].Value;
                Close();
            }
        }

        private void FrmBuscarEmpleado_Load(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void VerDatos()
        {
            if (FrmVentas.venta)
            {
                dgvListaEmpleados.Columns[3].Visible = false;
                dgvListaEmpleados.Columns[4].Visible = false;
                dgvListaEmpleados.Columns[5].Visible = false;
                dgvListaEmpleados.Columns[6].Visible = false;
                dgvListaEmpleados.Columns[7].Visible = false;
                dgvListaEmpleados.Columns[8].Visible = false;
            }
            var dni = tbxDNI.Text.Trim();
            var nom = tbxNom.Text;
            var aux = new Empleado();
            aux.dni = dni;
            aux.Nombres = nom;
            aux.Apellidos = tbxApe.Text;
            var lista = NEmpleado.ListaEntidades(aux);
            dgvListaEmpleados.Rows.Clear();
            foreach (var item in lista)
            {
                dgvListaEmpleados.Rows.Add(item.IdEmpleado, item.Nombres, item.Apellidos, item.dni, item.Fec_nacimiento, item.Estado_civil, item.Celular, item.Correo_electronico, item.Direccion, item.IdDistrito);
            }
        }

        private void tbxDNI_Click(object sender, EventArgs e)
        {
            VerDatos();
        }

    }
}
