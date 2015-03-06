using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibConexionBD; // se llama a ala libreria

namespace PruebaLibreriasWinform
{
    public partial class Form1 : Form
    {

        ConexionBD miconexion = new ConexionBD("Parametros.xml");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {

            if (miconexion.AbrirConexion())
            {
                MessageBox.Show("ud es un Berraco");
            }
            else
            {
                MessageBox.Show("hay juemama,ocurrio un error" + miconexion.Error);
            }
            miconexion.CerrarConexion();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!miconexion.AbrirConexion())
            {
                MessageBox.Show("hay juemama,ocurrio un error" + miconexion.Error);
            }

                miconexion.SQL="SELECT COUNT(*) from producto";
                
            if (miconexion.ConsultarValorUnico(false)) // si ejecuta un storeProcedure
                {
                    MessageBox.Show("Hay" + miconexion.ValorUnico + "productos");
                    return;
                }
            else
            {
                MessageBox.Show("hay juemama,ocurrio un error" + miconexion.Error);
            }
            miconexion.CerrarConexion();
        }
    }
}
