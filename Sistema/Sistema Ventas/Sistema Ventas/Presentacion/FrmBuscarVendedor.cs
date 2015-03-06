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
    public partial class FrmBuscarVendedor : DevComponents.DotNetBar.Office2007Form
    {
        
        public FrmBuscarVendedor()
        {
            InitializeComponent();
        }

        private void FrmBuscarVendedor_Load(object sender, EventArgs e)
        {
            var aux = new EmpleadoContratado();
            aux.dni = tbxDNI.Text.Trim();
            aux.Cargo = "Vendedor";
            aux.Estado = "Activo";
            foreach (var item in NEmpladoContratado.ListaEntidades(aux))
            {
                dgvListaEmpleados.Rows.Add(item.IdContrato, item.IdEmpleado, item.Empleado, item.dni,  item.Cargo,  item.Estado);
            }
        }

        private void dgvListaEmpleados_DoubleClick(object sender, EventArgs e)
        {
            if (dgvListaEmpleados.Rows.Count>0)
            {
                //FrmVentas. emp=new Empleado();
                var f = dgvListaEmpleados.CurrentRow;
                FrmVentas.emp.IdEmpleado = (int)f.Cells[1].Value;
                FrmVentas.emp.dni = (string)f.Cells[2].Value;
                FrmVentas.emp.Nombres = (string)f.Cells[3].Value;
                Close();
            }
        }
    }
}
