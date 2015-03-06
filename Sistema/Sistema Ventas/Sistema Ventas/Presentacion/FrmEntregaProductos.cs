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
    public partial class FrmEntregaProductos : DevComponents.DotNetBar.Office2007Form
    {

        public FrmEntregaProductos()
        {
            InitializeComponent();
        }

        private void FrmEntregaProductos_Load(object sender, EventArgs e)
        {
            cbxVendedor.DataSource = NEmpladoContratado.ListaAlmaceneros();
            cbxVendedor.DisplayMember = "Empleado";
            cbxVendedor.ValueMember = "idEmpleado";
           //aca hay q modificar el nro serie de detalle venta y 
            //modificar el stosk de almacen
            //b grbar en movimieno
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                MessageBox.Show("filtrado");
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            var aux = new Movimiento();
            if (cbxVendedor.Text.Trim()=="")
            {
                MessageBox.Show("No hay almaceneros, Asegurese de inscribir personal de logistica para realizar esta operacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            aux.IdEmpleado = Convert.ToInt32(cbxVendedor.SelectedValue);
            aux.Tipo = "Descarga";
            aux.Fecha = DateTime.Now;
            var aux0 = new Producto();
            aux0.Modelo = textBox2.Text.Trim();
            var aux2 = new DetalleMovimiento();
            aux2.IdProducto = NProducto.ObtenerIdProducto(aux0);
            //MessageBox.Show("idpro" + " " + aux2.IdProducto.ToString());
            if (textBox1.Text.Length > 0)
            {
                //MessageBox.Show("idpro" + " " + aux2.IdProducto.ToString());
                var lista = new List<DetalleMovimiento>();
                aux2.Cantidad = 1;
                aux2.NroSerie = textBox1.Text.Trim();
                lista.Add(aux2);
                aux.ListaMovimiento = lista;
                var pro = new Producto();
                pro.Modelo = textBox2.Text.Trim();
                var stock = NProducto.ObtenerStock(pro);
                //MessageBox.Show(stock.ToString());
                var nuevostock = stock - 1;
                var pro2 = new Producto();
                pro2.Modelo = pro.Modelo;
                pro2.Stock = nuevostock;
                if (NMovimiento.Guardar(aux))
                {
                    //MessageBox.Show("Movimiento hecho", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                //MessageBox.Show(pro2.Modelo.ToString());
                //MessageBox.Show(pro2.Stock.ToString());
                if (NProducto.ModificarStock(pro2))
                {
                    MessageBox.Show("Descarga hecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (true)
                    {
                        
                    }
                }

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
