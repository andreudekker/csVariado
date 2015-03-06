using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLlenarCombos;
using LibLlenarGrids;

namespace SistemaDeFacturacionConLibrerias.Formularios
{
    public partial class Productos : Form
    {

        LlenarCombos llenarCombos = new LlenarCombos("Parametros.xml");
        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xms");
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            llenarGrids.SQL = "SELECT * FROM Producto";
            llenarGrids.LlenarGridWindows(dgvProductos);
        }
    }
}
