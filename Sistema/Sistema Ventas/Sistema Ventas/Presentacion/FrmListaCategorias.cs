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
    public partial class FrmListaCategorias : DevComponents.DotNetBar.Office2007Form
    {
        public static bool nuevo = false;
        public static bool modif = false;
        public static Categoria cat = null;
        public FrmListaCategorias()
        {
            InitializeComponent();
        }
        private void VerDatos()
        {

            var aux = new Categoria();
            aux.NombreCategoria = tbxfiltro.Text;
            var lista = NCategoria.ListaEntidades(aux);
            dgvListaCategorias.Rows.Clear();
            foreach (var item in lista)
            {
                dgvListaCategorias.Rows.Add(item.IdCategoria, item.NombreCategoria, item.Descripcion);
            }
        }
        private void FrmListaCategorias_Load(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void tbxfiltro_TextChanged(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
            if (dgvListaCategorias.RowCount > 0)
            {
                if (dgvListaCategorias.SelectedRows.Count > 0)
                {
                    cat = new Categoria();
                    cat.IdCategoria = (int)dgvListaCategorias.CurrentRow.Cells[0].Value;
                    cat.NombreCategoria = (string)dgvListaCategorias.CurrentRow.Cells[1].Value;
                    cat.Descripcion = (string)dgvListaCategorias.CurrentRow.Cells[2].Value;
                    btnModificar.Enabled = true;
                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            var f = new FrmCategorias();
            f.ShowDialog();
            VerDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListaCategorias.CurrentRow.Selected == false)
            {
                MessageBox.Show("Seleccione un registro", "Aviso");
            }
            else if (dgvListaCategorias.CurrentRow.Selected == true)
            {
                modif = true;
                var f = new FrmCategorias();
                f.ShowDialog();
                VerDatos();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaCategorias_DoubleClick(object sender, EventArgs e)
        {
            if (dgvListaCategorias.RowCount > 0)
            {
                if (dgvListaCategorias.SelectedRows.Count > 0)
                {
                    cat.IdCategoria = (int)dgvListaCategorias.CurrentRow.Cells[0].Value;
                    cat.NombreCategoria = (string)dgvListaCategorias.CurrentRow.Cells[1].Value;
                    cat.Descripcion = (string)dgvListaCategorias.CurrentRow.Cells[2].Value;
                    btnModificar.Enabled = true;
                    modif = true;
                    var f = new FrmCategorias();
                    f.ShowDialog();
                    VerDatos();
                }

            }
        }
    }
}
