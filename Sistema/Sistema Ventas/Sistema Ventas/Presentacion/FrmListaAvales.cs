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
    public partial class FrmListaAvales : DevComponents.DotNetBar.Office2007Form
    {
        public static bool nuevo = false;
        public static bool modif = false;
        public static Aval aval = null;
        public FrmListaAvales()
        {
            InitializeComponent();
        }
        private void VerDatos()
        {
            var dni = tbxDNI.Text.Trim();
            var nom = tbxNom.Text;
            var ape = tbxApe.Text;
            var aux = new Aval();
            aux.dni = dni;
            aux.Nombres = nom;
            aux.Apellidos = ape;
            var lista = NAval.ListaEntidades(aux);
            dgvListaAvales.Rows.Clear();
            foreach (var item in lista)
            {
                dgvListaAvales.Rows.Add(item.IdAval, item.Nombres, item.Apellidos, item.dni, item.Fec_nacimiento, item.Estado_civil, item.Direccion, item.Distrito);

            }
        }
        private void FrmListaAvales_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dgvListaAvales.RowCount > 0)
            {
                if (dgvListaAvales.SelectedRows.Count > 0)
                {
                    aval = new Aval();
                    aval.IdAval = (int)dgvListaAvales.CurrentRow.Cells[0].Value;
                    aval.dni = (string)dgvListaAvales.CurrentRow.Cells[3].Value;
                    aval.Nombres = (string)dgvListaAvales.CurrentRow.Cells[1].Value;
                    aval.Apellidos = (string)dgvListaAvales.CurrentRow.Cells[2].Value;
                    aval.Fec_nacimiento = (DateTime)dgvListaAvales.CurrentRow.Cells[4].Value;
                    aval.Estado_civil = (string)dgvListaAvales.CurrentRow.Cells[5].Value;
                    aval.Direccion = (string)dgvListaAvales.CurrentRow.Cells[6].Value;
                    aval.Distrito = (string)dgvListaAvales.CurrentRow.Cells[7].Value;
                    btnModificar.Enabled = true;
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
       {
          
           if (dgvListaAvales.CurrentRow.Selected == false)
           {
               MessageBox.Show("Seleccione un registro", "Aviso");
           }
           else if (dgvListaAvales.CurrentRow.Selected == true)
           {
               modif = true;
               var f = new FrmAval();
               f.ShowDialog();
               VerDatos();
           }
       }

       private void btnGuardar_Click(object sender, EventArgs e)
       {
           var f = new FrmAval();
           f.ShowDialog();
       }

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }

       private void btnNuevo_Click(object sender, EventArgs e)
       {
           nuevo = true;
           var f = new FrmAval();
           f.ShowDialog();
           VerDatos();
       }

       private void btnSalir_Click(object sender, EventArgs e)
       {
           Close();
       }

       private void dgvListaAvals_DoubleClick(object sender, EventArgs e)
       {
           if (dgvListaAvales.RowCount > 0)
           {
               if (dgvListaAvales.SelectedRows.Count > 0)
               {
                   aval.IdAval = (int)dgvListaAvales.CurrentRow.Cells[0].Value;
                   aval.dni = (string)dgvListaAvales.CurrentRow.Cells[3].Value;
                   aval.Nombres = (string)dgvListaAvales.CurrentRow.Cells[1].Value;
                   aval.Apellidos = (string)dgvListaAvales.CurrentRow.Cells[2].Value;
                   aval.Fec_nacimiento = (DateTime)dgvListaAvales.CurrentRow.Cells[4].Value;
                   aval.Estado_civil = (string)dgvListaAvales.CurrentRow.Cells[5].Value;
                   aval.Direccion = (string)dgvListaAvales.CurrentRow.Cells[8].Value;
                   aval.Distrito = (string)dgvListaAvales.CurrentRow.Cells[9].Value;
                   
               }

           }
           btnModificar.Enabled = true;
           modif = true;
           var f = new FrmAval();
           f.ShowDialog();
       }
    }
}
