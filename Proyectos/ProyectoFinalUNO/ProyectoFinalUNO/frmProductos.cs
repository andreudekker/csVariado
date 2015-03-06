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
using LibParametros;


namespace ProyectoFinalUNO
{
	public partial class frmProductos : Form
	{
		
	
		
		public frmProductos()
		{
			InitializeComponent();
		}

        SqlConnection cs = new SqlConnection();
		SqlDataAdapter dap = new SqlDataAdapter();
		BindingSource bs = new BindingSource();
		DataSet ds = new DataSet();

		private void frmProductos_Load(object sender, EventArgs e)
		{
			Parametros parametros = new Parametros();
			if (!parametros.GenerarCadenaConexion("Parametros.xml"))
			{
				MessageBox.Show(parametros.Error);
				Application.Exit();
			}
			cs.ConnectionString = parametros.CadenaConexion;

			dap.SelectCommand = new SqlCommand("SELECT * FROM producto", cs);
			ds.Clear();
			dap.Fill(ds);
			dgvProductos.DataSource = ds.Tables[0];
			bs.DataSource = ds.Tables[0];
			txtIdProducto.DataBindings.Add(new Binding("Text", bs, "IDProducto"));
			txtDescripcion.DataBindings.Add(new Binding("Text", bs, "Descripcion"));
			txtPrecio.DataBindings.Add(new Binding("Text", bs, "Precio"));
			txtStock.DataBindings.Add(new Binding("Text", bs, "Stock"));
			txtNotas.DataBindings.Add(new Binding("Text", bs, "Notas"));
			dgUpdate();
		}

		private void tbtPrimero_Click(object sender, EventArgs e)
		{
			bs.MoveFirst();
			dgUpdate();
		}

		private void tbtAnterior_Click(object sender, EventArgs e)
		{
			bs.MovePrevious();
			dgUpdate();
		}

		private void tbtSiguiente_Click(object sender, EventArgs e)
		{
			bs.MoveNext();
			dgUpdate();
		}

		private void tbtUltimo_Click(object sender, EventArgs e)
		{
			bs.MoveLast();
			dgUpdate();
		}

		private void dgUpdate()
		{
			dgvProductos.ClearSelection();
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
			if (txtIdProducto.Text=="")
			{
				MessageBox.Show("Debe Ingresar Un ID de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}

			Datos misDatos = new Datos();
			if(misDatos.existeProducto(txtIdProducto.Text))
			{
				 MessageBox.Show("Este Producto ya existe en la Bd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}

			if (txtDescripcion.Text =="")
			{
				 MessageBox.Show("Este Ingresar Descripcion al producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				 txtIdProducto.Focus();
				 return;
			}

			if (txtPrecio.Text == "")
			{
				MessageBox.Show("Este Ingresar Precio ","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}


			if ( !Utilidades.isNumeric(txtPrecio.Text))
			{
				MessageBox.Show("Este Ingresar un valor en el PRECIO para el produco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPrecio.Text = "";
				txtPrecio.Focus();
				return;
			}


			if (txtStock.Text == "")
			{
				MessageBox.Show("Este Ingresar  un Stock inicial","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}
			if (!Utilidades.isNumeric(txtStock.Text))
			{
				MessageBox.Show("Este Ingresar un valor en el  Numerico para el STOCK producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtStock.Text = "";
				txtStock.Focus();
				return;
			}



				dap.SelectCommand = new SqlCommand("INSERT INTO Producto VALUES(@IDProducto,@Descripcion,@Precio,@Stock,@Notas)", cs);
				dap.InsertCommand.Parameters.Add("@IDProducto", SqlDbType.VarChar).Value = txtIdProducto.Text;
				dap.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
				dap.InsertCommand.Parameters.Add("@Precio", SqlDbType.Money).Value = txtPrecio.Text;
				dap.InsertCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = txtStock.Text;
				dap.InsertCommand.Parameters.Add("@Notas", SqlDbType.Text).Value = txtNotas.Text;



			cs.Open();
			dap.InsertCommand.ExecuteNonQuery();
			cs.Close();

			ds.Clear();
			dap.Fill(ds);

			dgUpdate();


		}

		private void tbtGuardar_Click(object sender, EventArgs e)
		{
			if (txtIdProducto.Text == "")
			{
				MessageBox.Show("Debe Ingresar Un ID de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}

			Datos misDatos = new Datos();
			if (!misDatos.existeProducto(txtIdProducto.Text))
			{
				MessageBox.Show("Este Producto no existe en la Bd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}

			if (txtDescripcion.Text == "")
			{
				MessageBox.Show("Este Ingresar Descripcion al producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}

			if (txtPrecio.Text == "")
			{
				MessageBox.Show("Este Ingresar Precio ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}


			if (!Utilidades.isNumeric(txtPrecio.Text))
			{
				MessageBox.Show("Este Ingresar un valor en el PRECIO para el produco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPrecio.Text = "";
				txtPrecio.Focus();
				return;
			}


			if (txtStock.Text == "")
			{
				MessageBox.Show("Este Ingresar  un Stock inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}
			if (!Utilidades.isNumeric(txtStock.Text))
			{
				MessageBox.Show("Este Ingresar un valor en el  Numerico para el STOCK producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtStock.Text = "";
				txtStock.Focus();
				return;
			}


			dap.UpdateCommand = new SqlCommand("UPDATE producto SET Descripcion= @Descripcion,Precio=@Precio,"
																			+"Stock=@Stock,Notas=@Notas WHERE IDproducto=@IDProducto", cs);
		   
			
			dap.UpdateCommand.Parameters.Add("@IDProducto", SqlDbType.VarChar).Value = txtIdProducto.Text;
			dap.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
			dap.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Money).Value = txtPrecio.Text;
			dap.UpdateCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = txtStock.Text;
			dap.UpdateCommand.Parameters.Add("@Notas", SqlDbType.Text).Value = txtNotas.Text;



			cs.Open();
			dap.UpdateCommand.ExecuteNonQuery();
			cs.Close();

			ds.Clear();
			dap.Fill(ds);

			dgUpdate();
		}

		private void tbtEliminar_Click(object sender, EventArgs e)
		{


			if (txtIdProducto.Text == "")
			{
				MessageBox.Show("Debe Ingresar Un ID de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}

			Datos misDatos = new Datos();
			if (!misDatos.existeProducto(txtIdProducto.Text))
			{
				MessageBox.Show("Este Producto no existe en la Bd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}

			if (txtDescripcion.Text == "")
			{
				MessageBox.Show("Este Ingresar Descripcion al producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtIdProducto.Focus();
				return;
			}
			
			DialogResult dr = MessageBox.Show("Esta seguro de borrar el registro", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr ==DialogResult.No)
			{
				txtIdProducto.Focus();
				return;
			}

			dap.DeleteCommand = new SqlCommand("DELETE FROM producto WHERE IDProducto=@IDProducto", cs);
			dap.DeleteCommand.Parameters.Add("@IDProducto", SqlDbType.VarChar).Value = txtIdProducto.Text;

			cs.Open();
			dap.DeleteCommand.ExecuteNonQuery();
			cs.Close();

			ds.Clear();
			dap.Fill(ds);

			dgUpdate();

		}


	}
}
