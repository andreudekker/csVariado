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
    public partial class FrmProductos : DevComponents.DotNetBar.Office2007Form
    {
        public static int iddistrito;
        public FrmProductos()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            tbxMarca.Clear();
            tbxModelo.Clear();
            tbxPrecio.Clear();
            //tbxEstado.Clear();
            nudCantidad.Value = 0;
            //cbxDepartamento.SelectedIndex=0;
            //cbxProvincia.SelectedIndex = 0;
            //cbxDistrito.SelectedIndex = 0;
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            if (FrmListaProductos.modif == true)
            {
                tbxMarca.Text = FrmListaProductos.pro.Marca;
                tbxModelo.Text = FrmListaProductos.pro.Modelo;
                tbxPrecio.Text = FrmListaProductos.pro.Precio.ToString();
                //tbxEstado.Text = FrmListaProductos.pro.Estado;
                nudCantidad.Value = FrmListaProductos.pro.Stock;
            }
            cbxCategoria.DataSource = NCategoria.ListarCategorias();
            cbxCategoria.DisplayMember = "NombreCategoria";
            cbxCategoria.ValueMember = "IdCategoria";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            cbxCategoria.Enabled = true;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var aux = new Producto();
            aux.IdCategoria = Convert.ToInt32( cbxCategoria.SelectedValue);
            aux.Marca = tbxMarca.Text.Trim().ToUpper();
            aux.Modelo = tbxModelo.Text.ToUpper();
            aux.Precio = Convert.ToSingle( tbxPrecio.Text);
            aux.Stock = Convert.ToInt32( nudCantidad.Value);
            aux.Estado = "1";
            if (aux.Marca.Length > 0 && aux.Modelo.Length > 0 && aux.Estado.Length > 0 && aux.IdCategoria > 0)
            {

                if (FrmListaProductos.nuevo == true)
                {
                    if (NProducto.ExisteModelo(aux) == true)
                    {
                        MessageBox.Show("Ya existe un modelo como el que intenta ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else 
                    {
                        if (aux.Stock==0)
                        {
                            if (MessageBox.Show("¿Stock 0?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                            {
                                NProducto.Guardar(aux);
                                MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                                cbxCategoria.Enabled = false;
                            }
                        }
                        else
                        {
                            NProducto.Guardar(aux);
                            MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            cbxCategoria.Enabled = false;
                        }    
                        
                    }
                 }
                   
                
                else if (FrmListaProductos.modif)
                {
                    aux.IdProducto = FrmListaProductos.pro.IdProducto;
                    //MessageBox.Show(aux.IdProducto.ToString());
                    NProducto.Guardar(aux);
                    MessageBox.Show("Datos actualizados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    FrmListaProductos.modif = false;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Asegurese de ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            
        }

        private void FrmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmListaProductos.modif = false;
            FrmListaProductos.nuevo = false;
        }

        private void tbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("Introduzca solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
