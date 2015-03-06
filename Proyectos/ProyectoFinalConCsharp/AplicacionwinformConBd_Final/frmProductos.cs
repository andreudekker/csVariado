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
using LibParametros; // libreria Creada
using LibConexionBD;

namespace AplicacionwinformConBd_Final
{
    public partial class frmProductos : Form
    {
       	
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter dap = new SqlDataAdapter(); //realiza querys a bd
        BindingSource bs = new BindingSource();//cuadros texto con campos bd
        DataSet ds = new DataSet(); // trael la tabla a memoriaConjunto de registro
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

             Parametros parametros = new Parametros();
             if (parametros.generarCadenaConexion("Parametros1.xml")) // de la LibXml
             {
                 MessageBox.Show(parametros.Error);
                 Application.Exit();
             }
             cn.ConnectionString = parametros.CadenaConexion;
            
                
                dap.SelectCommand= new SqlCommand("select * FROM producto",cn);
            ds.Clear();
            dap.Fill(ds);
            dgvProductos.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
            txtIdProducto.DataBindings.Add(new  Binding("Text",bs,"IDProducto"));
            txtDescripcion.DataBindings.Add(new Binding("Text", bs, "Descripcion"));
            txtPrecio.DataBindings.Add(new Binding("Text", bs, "Precio"));
            txtStock.DataBindings.Add(new Binding("Text", bs, "Stock"));
            txtNotas.DataBindings.Add(new Binding("Text", bs, "Notas"));
            dgvUpdate();
        }

        private void tbtPrimero_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            dgvUpdate();
        }

        private void tbtAnterior_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            dgvUpdate();
        }

        private void tbtSiguiente_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            dgvUpdate();
        }

        private void tbtUltimo_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            dgvUpdate();
        }
        private void dgvUpdate()
        {
            dgvProductos.ClearSelection(); //desmarca lo del usuario
            dgvProductos.Rows[bs.Position].Selected = true;

        }

        private void tbtLimpiar_Click(object sender, EventArgs e)
        {
            txtIdProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtNotas.Text = "";
            txtIdProducto.Focus();
        }

        private void tbtNuevo_Click(object sender, EventArgs e)
        {

            if (txtIdProducto.Text==" ")
            {
                MessageBox.Show("Debe ingresar un id de producto", "Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdProducto.Focus();
                return;
            }
            Datos misDatos = new Datos();
            if (misDatos.existeProducto(txtIdProducto.Text))
            {
                MessageBox.Show("El producto ya existe en la bd", "Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdProducto.Focus();
                return;
            }

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar undescripcion de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return;
                
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar unpreciode producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Focus();
                return;

            }
            if (Utilidades.isNumeric(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar uvalor en el precio para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Focus();
                return;

            }
            if (txtStock.Text == "")
            {
                MessageBox.Show("Debe ingresar un Stock  producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStock.Focus();
                return;

            }

            if (Utilidades.isNumeric(txtStock.Text))
            {
                MessageBox.Show("Debe ingresar un Stock  producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStock.Focus();
                return;

            }


            dap.InsertCommand= new SqlCommand("Insert Into producto values(@IDProducto,@Descripcion,@Precio,@Stock,@Notas",cn);
            dap.InsertCommand.Parameters.Add("@IDProducto", SqlDbType.VarChar).Value = txtIdProducto.Text;
            dap.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
            dap.InsertCommand.Parameters.Add("@Precio", SqlDbType.Money).Value = txtPrecio.Text;
            dap.InsertCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = txtStock.Text;
            //dap.InsertCommand.Parameters.Add("@Notas", SqlDbType.Text).Value = txtNotas.Text; // revisar No funciona
            
            cn.Open();

            dap.InsertCommand.ExecuteNonQuery();/// revisar
            cn.Close();
            
            ds.Clear();
            dap.Fill(ds);
            dgvUpdate();

        }

        private void tbtGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == " ")
            {
                MessageBox.Show("Debe ingresar un id de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdProducto.Focus();
                return;
            }
            Datos misDatos = new Datos();
            if (!misDatos.existeProducto(txtIdProducto.Text))
            {
                MessageBox.Show("El producto ya existe en la bd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdProducto.Focus();
                return;
            }

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar undescripcion de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return;

            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar unpreciode producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Focus();
                return;

            }
            if (Utilidades.isNumeric(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar uvalor en el precio para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Focus();
                return;

            }
            if (txtStock.Text == "")
            {
                MessageBox.Show("Debe ingresar un Stock  producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStock.Focus();
                return;

            }

            if (Utilidades.isNumeric(txtStock.Text))
            {
                MessageBox.Show("Debe ingresar un Stock  producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStock.Focus();
                return;

            }

            dap.UpdateCommand = new SqlCommand("update Producto set descripcion=@Descripcion,Precio=@Precio,Stock=@Stock,Notas=@Notas WHERE IDProducto=@IDProducto ", cn);

            
            dap.UpdateCommand.Parameters.Add("@IDProducto", SqlDbType.VarChar).Value = txtIdProducto.Text;
            dap.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
            dap.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Money).Value = txtPrecio.Text;
            dap.UpdateCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = txtStock.Text;
            //dap.InsertCommand.Parameters.Add("@Notas", SqlDbType.Text).Value = txtNotas.Text; // revisar No funciona

            cn.Open();

            dap.UpdateCommand.ExecuteNonQuery();
            cn.Close();

            ds.Clear();
            dap.Fill(ds);
            dgvUpdate();
        }

        private void tbtEliminar_Click(object sender, EventArgs e)
        {

            if (txtIdProducto.Text == " ")
            {
                MessageBox.Show("Debe ingresar un id de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdProducto.Focus();
                return;
            }
            Datos misDatos = new Datos();
            if (!misDatos.existeProducto(txtIdProducto.Text))
            {
                MessageBox.Show("El producto ya existe en la bd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdProducto.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Esta seguro de borrar el registro", "Confirmacion",MessageBoxButtons.YesNo, 
                                                                   MessageBoxIcon.Question);
            if (dr==DialogResult.No)
            {
                txtIdProducto.Focus();
                return;
            }
            dap.DeleteCommand = new SqlCommand("Delete FROM Producto WHERE IDProducto=@IDproducto");

            cn.Open();

            dap.DeleteCommand.ExecuteNonQuery();
            cn.Close();

            ds.Clear();
            dap.Fill(ds);
            dgvUpdate();
        }

    
    }
}
