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
    public partial class FrmCategorias : DevComponents.DotNetBar.Office2007Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
        void Limpiar() 
        {
            tbxcat.Clear();
            tbxdescr.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //var tam = new FrmCategorias();
            //tam.Width = 380;
            //tam.Height = 380;
            //var ejec = new Size();
            tbxcat.Focus();
            Limpiar();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            if (FrmListaCategorias.modif == true)
            {
                tbxcat.Text = FrmListaCategorias.cat.NombreCategoria;
                tbxdescr.Text = FrmListaCategorias.cat.Descripcion;
                
            }
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var aux=new Categoria();
            //MessageBox.Show(tbxcat.Text);
            aux.NombreCategoria = tbxcat.Text;
            aux.Descripcion = tbxdescr.Text;
            if (tbxcat.Text.Length > 0 && tbxdescr.Text.Length > 0)
            {

                if (FrmListaCategorias.nuevo == true)
                {
                    
                    if (NCategoria.Duplicado(aux) == true)
                    {
                        MessageBox.Show("Ya existe un modelo como el que intenta ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        NCategoria.Guardar(aux);
                        MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        
                    }
                }


                else if (FrmListaCategorias.modif)
                {
                    aux.IdCategoria = FrmListaCategorias.cat.IdCategoria;
                    //MessageBox.Show(aux.IdCategoria.ToString());
                    NCategoria.Guardar(aux);
                    MessageBox.Show("Datos actualizados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    FrmListaCategorias.modif = false;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Asegurese de ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void FrmCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmListaCategorias.nuevo = false;
            FrmListaCategorias.modif = false;
        }
        }

    }

