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
    public partial class FrmBuscarProductos : DevComponents.DotNetBar.Office2007Form
    {

        
        public FrmBuscarProductos()
        {
            InitializeComponent();
        }

        private void FrmListaProductosParaVenta_Load(object sender, EventArgs e)
        {

            //verdatos();
        }

        private void verdatos()
        {
            var aux = new Producto();
            aux.Marca = tbxMarca.Text;
            aux.Modelo = tbxModelo.Text;
            aux.IdCategoria = FrmVentas.idcategoria;
            var lista = NProducto.ListaEntidades(aux);
            dgvListaProductos.Rows.Clear();
            foreach (var fila in lista)
            {
                dgvListaProductos.Rows.Add(fila.IdProducto, fila.IdCategoria, fila.Marca, fila.Modelo, fila.Precio, fila.Stock, "wa");
            }
        }

        private void dgvListaProductos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvListaProductos.Rows.Count>0)
            {
                //pro = new Producto();
                FrmVentas. pro.IdProducto = (int)dgvListaProductos.CurrentRow.Cells[0].Value;
                FrmVentas.pro.Marca = (string)dgvListaProductos.CurrentRow.Cells[2].Value;
                FrmVentas.pro.Modelo = (string)dgvListaProductos.CurrentRow.Cells[3].Value;
                FrmVentas.pro.Precio = (float)dgvListaProductos.CurrentRow.Cells[4].Value;
                FrmVentas.pro.stock = (int)dgvListaProductos.CurrentRow.Cells[5].Value;
                Close();
            }
            
        }

        private void tbxModelo_KeyDown(object sender, KeyEventArgs e)
        {
            verdatos();
        }
    }
}
