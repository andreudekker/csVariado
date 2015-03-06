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
    public partial class FrmListaProductos : DevComponents.DotNetBar.Office2007Form
    {
        public static bool nuevo = false;
        public static bool modif = false;
        public static Producto pro = null;
        public FrmListaProductos()
        {
            InitializeComponent();
        }
        private void VerDatos()
        {
            var mar = tbxMarca.Text;
            var mod = tbxModelo.Text.Trim();
            var aux = new Producto();
            aux.Marca = mar;
            aux.Modelo=mod;
            var lista = NProducto.ListaEntidades(aux);
            dgvListaProductos.Rows.Clear();
            foreach (var item in lista)
            {
                dgvListaProductos.Rows.Add(item.IdProducto, item.IdCategoria, item.Marca, item.Modelo, item.Precio, item.Stock, item.Estado);

            }
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            nuevo = true;
            var f = new FrmProductos();
            f.ShowDialog();
            VerDatos();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
            if (dgvListaProductos.RowCount > 0)
            {
                if (dgvListaProductos.SelectedRows.Count > 0)
                {
                    pro = new Producto();
                    pro.IdProducto = (int)dgvListaProductos.CurrentRow.Cells[0].Value;
                    pro.IdCategoria = (int)dgvListaProductos.CurrentRow.Cells[1].Value;
                    pro.Marca = (string)dgvListaProductos.CurrentRow.Cells[2].Value;
                    pro.Modelo = (string)dgvListaProductos.CurrentRow.Cells[3].Value;
                    pro.Precio = (float)dgvListaProductos.CurrentRow.Cells[4].Value;
                    pro.Stock= (int)dgvListaProductos.CurrentRow.Cells[5].Value;
                    pro.Estado = (string)dgvListaProductos.CurrentRow.Cells[6].Value;
                    btnModificar.Enabled = true;
                }

            }
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            if (dgvListaProductos.CurrentRow.Selected == false)
            {
                MessageBox.Show("Seleccione un registro", "Aviso");
            }
            else if (dgvListaProductos.CurrentRow.Selected == true)
            {
                modif = true;
                var f = new FrmProductos();
                f.ShowDialog();
                VerDatos();
            }
        }

        private void dataGridViewX1_DoubleClick(object sender, EventArgs e)
        {
            if (dgvListaProductos.RowCount > 0)
            {
                if (dgvListaProductos.SelectedRows.Count > 0)
                {
                    pro.IdProducto = (int)dgvListaProductos.CurrentRow.Cells[0].Value;
                    pro.IdCategoria = (int)dgvListaProductos.CurrentRow.Cells[1].Value;
                    pro.Marca = (string)dgvListaProductos.CurrentRow.Cells[2].Value;
                    pro.Modelo = (string)dgvListaProductos.CurrentRow.Cells[3].Value;
                    pro.Precio = (float)dgvListaProductos.CurrentRow.Cells[4].Value;
                    pro.Stock = (int)dgvListaProductos.CurrentRow.Cells[5].Value;
                    pro.Estado = (string)dgvListaProductos.CurrentRow.Cells[6].Value;
                    btnModificar.Enabled = true;
                    modif = true;
                    var f = new FrmProductos();
                    f.ShowDialog();
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            var aux = new Producto();
            //aux.IdProducto=
        }
    }
}
