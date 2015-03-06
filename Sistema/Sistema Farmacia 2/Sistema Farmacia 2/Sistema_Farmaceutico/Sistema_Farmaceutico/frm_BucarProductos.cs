using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LayerControler.LayerMedicamentos;

namespace Sistema_Farmaceutico
{
    public partial class frm_BucarProductos : Form
    {
        
        public frm_BucarProductos(frm_Venta frm)
        {
            InitializeComponent();
          
        }
        DataTable tabla = new DataTable();
        medicamentosControler control = new medicamentosControler();
       

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selcionarFila(e.RowIndex);
        }
 
        private void selcionarFila(int RowIndex){
      
            MessageBox.Show("index"+RowIndex.ToString(),"Advertencia");
            String nom = Convert.ToString(this.dataGridView1.Rows[RowIndex].Cells[1].Value.ToString());
            //frm.id = Convert.ToString(String.Format("{0:0000}", Int32.Parse(this.dataGridView1.Rows[RowIndex].Cells[0].Value.ToString())));
            //v.txtNomF.Text = nom;
            //v.des= this.dataGridView1.Rows[RowIndex].Cells[6].Value.ToString();
            //v.pre= this.dataGridView1.Rows[RowIndex].Cells[2].Value.ToString();

        }

        private void cargar()
        {
            tabla.Clear();
            control.setNombreMedicamento(textBox1.Text);
            dataGridView1.DataSource = control.listarMedicamentos(tabla);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargar();
        }

        private void frm_BucarProductos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 d = dataGridView1.CurrentRow.Index;
            selcionarFila(d);
            this.Dispose();
        }
    }
}
