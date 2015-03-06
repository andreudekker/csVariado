using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LayerControler.LayerBusqueda;

namespace Sistema_Farmaceutico
{
    public partial class frm_Busqueda : Form
    {
        DisableButton objDisableButton = new DisableButton();
        BusquedaControl objBusquedaControl = new BusquedaControl();
        DataTable tblResultado = new DataTable();
        frm_Venta frmVenta;
        frm_Usuario frmUsuario;

        public frm_Busqueda()
        {
            InitializeComponent();
        }

        public frm_Busqueda(frm_Venta pointer)
        {
            frmVenta = pointer;
            InitializeComponent();
        }

        public frm_Busqueda(frm_Usuario pointer)
        {
            frmUsuario = pointer;
            InitializeComponent();
        }

        private void frm_Busqueda_Load(object sender, EventArgs e)
        {
            if (frmVenta != null)
            {
                this.Text = "Seleccionar Producto";
                this.cboSelector.Enabled = false;
                this.cboSelector.SelectedIndex = 1;
                this.cboBusquedaPor.SelectedIndex = 0;
                deshablitarControles(txtBusqueda: true, btnBuscar: true);
            }
            else if (frmUsuario != null)
            {
                this.Text = "Seleccionar Usuario";
                this.cboSelector.Enabled = false;
                this.cboSelector.SelectedIndex = 3;
                this.cboBusquedaPor.SelectedIndex = 0;
                deshablitarControles(txtBusqueda: true, btnBuscar: true);
            }
            else
            {
                this.cboSelector.SelectedIndex = 0;
                this.cboBusquedaPor.SelectedIndex = 0;
                deshablitarControles();
                objDisableButton.DisableCloseButton(this.Handle.ToInt32());
            }
        }



        private void deshablitarControles(Boolean cboBusquedaPor = false, Boolean dtFInicial = false, Boolean dtFFinal = false, Boolean txtBusqueda = false, Boolean btnBuscar = false)
        {
            this.cboBusquedaPor.Enabled = cboBusquedaPor;
            this.dtFInicial.Enabled = dtFInicial;
            this.dtFFinal.Enabled = dtFFinal;
            this.txtBusqueda.Enabled = txtBusqueda;
            this.btnBuscar.Enabled = btnBuscar;
        }

        private void cboSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = this.cboSelector.SelectedIndex;
            objBusquedaControl.MySelector = i;
            switch (i)
            {
                case 0: // Item: Seleccione...
                    deshablitarControles();
                    break;
                case 1: // Item: Productos
                    deshablitarControles(txtBusqueda: true, btnBuscar: true);
                    this.txtBusqueda.Focus();
                    break;
                case 2: // Item: Ventas
                    deshablitarControles(cboBusquedaPor: true);
                    break;
                default: // Item: Usuarios
                    deshablitarControles(txtBusqueda: true, btnBuscar: true);
                    this.txtBusqueda.Focus();
                    break;
            }
        }

        private void cboBusquedaPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = this.cboBusquedaPor.SelectedIndex;
            objBusquedaControl.MyBusquedaPor = i;
            switch (i)
            {
                case 0:
                    deshablitarControles(cboBusquedaPor: true);
                    break;
                case 1:
                case 2:
                case 3:
                    deshablitarControles(cboBusquedaPor: true, txtBusqueda: true, btnBuscar: true);
                    this.txtBusqueda.Focus();
                    break;
                default:
                    deshablitarControles(cboBusquedaPor: true, dtFInicial: true, dtFFinal: true, btnBuscar: true);
                    this.dtFInicial.Focus();
                    break;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            tblResultado.Clear();
            tblResultado.Columns.Clear();
            objBusquedaControl.MyBusqueda = this.txtBusqueda.Text.Trim();
            this.dgvResultado.DataSource = objBusquedaControl.verificarBusqueda(tblResultado);
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmVenta != null)
            {
                int cantidad = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad del Producto", "Seleccionar Producto", "1"));
                if (cantidad <= Int32.Parse(this.dgvResultado.Rows[e.RowIndex].Cells[5].Value.ToString()))
                {
                    frmVenta.cargarProductosSeleccionados(this.dgvResultado.Rows[e.RowIndex].Cells[0].Value.ToString(), this.dgvResultado.Rows[e.RowIndex].Cells[1].Value.ToString(), this.dgvResultado.Rows[e.RowIndex].Cells[6].Value.ToString(), Double.Parse(this.dgvResultado.Rows[e.RowIndex].Cells[2].Value.ToString()), cantidad);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No hay suficientes produtos para agregar a la lista", "Seleccionar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


    }
}
