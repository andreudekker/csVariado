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
    public partial class FrmListaEmpleados : DevComponents.DotNetBar.Office2007Form
    {
        //public static int idemp,iddis;
        //public static string dni,nom, ape, est_civ, cel, cor_ele, dir;
        //public static DateTime fec_nac;
        public static bool nuevo= false;
        public static bool modif = false;
        public static Empleado emp = null;
        public FrmListaEmpleados()
        {
            InitializeComponent();
        }
        private void VerDatos()
        {
            var dni = tbxDNI.Text.Trim();
            var nom = tbxNom.Text;
            var ape = tbxApe.Text;
            var aux = new Empleado();
            aux.dni = dni;
            aux.Nombres = nom;
            aux.Apellidos = ape;
            var lista = NEmpleado.ListaEntidades(aux);
            dgvListaEmpleados.Rows.Clear();
            foreach (var item in lista)
            {
                dgvListaEmpleados.Rows.Add(item.IdEmpleado, item.Nombres, item.Apellidos, item.dni, item.Fec_nacimiento, item.Estado_civil, item.Celular, item.Correo_electronico, item.Direccion, item.IdDistrito);
                
            }
        }
        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            VerDatos();
        }

       private void tbxDNI_TextChanged(object sender, EventArgs e)
        {
            VerDatos();
        }

       private void dataGridView1_Click(object sender, EventArgs e)
       {
           if (dgvListaEmpleados.RowCount>0)
           {
               if (dgvListaEmpleados.SelectedRows.Count>0)
               {
                   emp = new Empleado();
                   emp.IdEmpleado = (int)dgvListaEmpleados.CurrentRow.Cells[0].Value;
                   emp.dni = (string)dgvListaEmpleados.CurrentRow.Cells[3].Value;
                   emp.Nombres = (string)dgvListaEmpleados.CurrentRow.Cells[1].Value;
                   emp.Apellidos = (string)dgvListaEmpleados.CurrentRow.Cells[2].Value;
                   emp.Fec_nacimiento = (DateTime)dgvListaEmpleados.CurrentRow.Cells[4].Value;
                   emp.Estado_civil = (string)dgvListaEmpleados.CurrentRow.Cells[5].Value;
                   emp.Celular = (string)dgvListaEmpleados.CurrentRow.Cells[6].Value;
                   emp.Correo_electronico = (string)dgvListaEmpleados.CurrentRow.Cells[7].Value;
                   emp.Direccion = (string)dgvListaEmpleados.CurrentRow.Cells[8].Value;
                   emp.IdDistrito = (int)dgvListaEmpleados.CurrentRow.Cells[9].Value;
                   btnModificar.Enabled = true;
               }
                
           }
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
               var f = new FrmEmpleados();
               f.ShowDialog();
               VerDatos();
           }
       }

       private void btnGuardar_Click(object sender, EventArgs e)
       {
           var f = new FrmEmpleados();
           f.ShowDialog();
       }

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }

       private void btnNuevo_Click(object sender, EventArgs e)
       {
           nuevo = true;
           var f = new FrmEmpleados();
           f.ShowDialog();
           VerDatos();
       }

       private void btnSalir_Click(object sender, EventArgs e)
       {
           Close();
       }

       private void dgvListaEmpleados_DoubleClick(object sender, EventArgs e)
       {
           if (dgvListaEmpleados.RowCount > 0)
           {
               if (dgvListaEmpleados.SelectedRows.Count > 0)
               {
                   emp.IdEmpleado = (int)dgvListaEmpleados.CurrentRow.Cells[0].Value;
                   emp.dni = (string)dgvListaEmpleados.CurrentRow.Cells[3].Value;
                   emp.Nombres = (string)dgvListaEmpleados.CurrentRow.Cells[1].Value;
                   emp.Apellidos = (string)dgvListaEmpleados.CurrentRow.Cells[2].Value;
                   emp.Fec_nacimiento = (DateTime)dgvListaEmpleados.CurrentRow.Cells[4].Value;
                   emp.Estado_civil = (string)dgvListaEmpleados.CurrentRow.Cells[5].Value;
                   emp.Celular = (string)dgvListaEmpleados.CurrentRow.Cells[6].Value;
                   emp.Correo_electronico = (string)dgvListaEmpleados.CurrentRow.Cells[7].Value;
                   emp.Direccion = (string)dgvListaEmpleados.CurrentRow.Cells[8].Value;
                   emp.IdDistrito = (int)dgvListaEmpleados.CurrentRow.Cells[9].Value;
                   btnModificar.Enabled = true;
                   modif = true;
                   var f = new FrmEmpleados();
                   f.ShowDialog();
               }

           }
       }
    }
}
