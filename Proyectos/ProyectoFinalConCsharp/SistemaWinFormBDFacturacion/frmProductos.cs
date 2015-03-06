using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SistemaWinFormBDFacturacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=Facturacion;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        BindingSource bs = new BindingSource(); 
        DataSet ds = new DataSet();

       
        

        private void frmProductos_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("usp_mDatos", cn);
          
            ds.Clear();
            da.Fill(ds);
            dgvProductos.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
            txtIdProducto.DataBindings.Add(new Binding("Text",bs,"IDProducto"));
            txtDescripcion.DataBindings.Add(new Binding("Text", bs, "Descripcion"));
            txtPrecio.DataBindings.Add(new Binding("Text", bs, "Precio"));
            txtStock.DataBindings.Add(new Binding("Text", bs, "Stock"));
            txtNotas.DataBindings.Add(new Binding("Text", bs, "Notas"));

            llenarComboBoxIva();
            llenarComboBoxCategorias();      
            dgActualizarDataGrid();

        }
      
        
        #region BotonesPrincipales
        private void tstPrimerRegistro_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            dgActualizarDataGrid();
        }

        private void tstAnterior_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            dgActualizarDataGrid();
        }

        private void tstSiguiente_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            dgActualizarDataGrid();
        }

        private void tstUltimo_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            dgActualizarDataGrid();
        }
        #endregion


        #region Crud

        private void tstNuevo_Click(object sender, EventArgs e)
        {

            da.InsertCommand = new SqlCommand("usp_Idatos", cn);


            SqlParameter paramIDProductos = new SqlParameter("@IDProductos", SqlDbType.VarChar);
            paramIDProductos.Direction = ParameterDirection.Output;
            da.InsertCommand.Parameters.Add(paramIDProductos);




            da.InsertCommand.Parameters.Add("@IDProductos", SqlDbType.VarChar).Value = txtIdProducto.Text;
         
            da.InsertCommand.Parameters.Add("@Descripcion",SqlDbType.VarChar).Value= txtDescripcion.Text;
            da.InsertCommand.Parameters.Add("@Precio", SqlDbType.Money).Value=txtPrecio.Text;
            da.InsertCommand.Parameters.Add("@Stock",SqlDbType.Int).Value= txtStock.Text;
            da.InsertCommand.Parameters.Add("@Notas",SqlDbType.Text).Value= txtNotas.Text;
            da.InsertCommand.Parameters.Add("@Categorias", SqlDbType.Int).Value = cboCategorias.SelectedValue;
            da.InsertCommand.Parameters.Add("@IVA", SqlDbType.Int).Value = cboIva.SelectedValue;
            
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
            ds.Clear();
            da.Fill(ds);
            dgActualizarDataGrid();


        }

        private void tstGuardar_Click(object sender, EventArgs e)
        {

        }

        private void tstBorrar_Click(object sender, EventArgs e)
        {

        }

#endregion

      

        #region Funciones LLenarCombo y Actualizargrid limpiar Txt
        public void llenarComboBoxCategorias()
        {




            SqlCommand cmd = new SqlCommand("usp_Mcategorias", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            cboCategorias.ValueMember = "Descripcion";
            cboCategorias.DataSource = dt;  

         
            //DataSet ds = new DataSet();
            //SqlDataAdapter dap = new SqlDataAdapter("usp_Mcategorias", cn);
        
            //dap.Fill(ds, "Departamento");
            //cboCategorias.DataSource = ds.Tables[0].DefaultView;       
            //cboCategorias.ValueMember = "Descripcion";
            
            
        
        }

        public void llenarComboBoxIva()
        {

            SqlCommand cmd = new SqlCommand("usp_MIva", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            cboIva.ValueMember = "Descripcion";
            cboIva.DataSource = dt;  
            
        
        }

        private void dgActualizarDataGrid()
        {
            dgvProductos.ClearSelection();
            dgvProductos.Rows[bs.Position].Selected = true;
            dgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void tstLimpiar_Click(object sender, EventArgs e)
        {
            txtIdProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtNotas.Text = "";
            txtIdProducto.Focus();

        }

#endregion
      
    
    }
}
