using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionwinformConBd_Final
{
	class  Datos
	{
		private SqlConnection cn;
		private void Conectar()
		{
			try
			{
				cn = new SqlConnection("@Data Source=.;Initial Catalog=Facturacion;Integrated Security=True");
				cn.Open();
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error de conexion a la base de datos {0}" + ex.ToString(),"Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		  private void desconectar()
		  {
		   try
			{
			   cn.Close();
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error base de datos {0}" + ex.ToString(),"Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
				   
		  }
		public bool existeProducto(string IDProducto) 
		{

			int aux=0;
			try 
			{	        
					Conectar();
						SqlCommand cmd= new SqlCommand("select(1) from producto where IDProducto=' "+IDProducto+" ' ",cn);
						aux= Convert.ToInt32(cmd.ExecuteScalar());
						desconectar();
	
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error de conexion a la base de datos {0}" + ex.ToString(),"Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return aux == 1;
		}
		
		
		}
	}

