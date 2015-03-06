using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalUNO
{
 class Datos
    {
        private  SqlConnection cn ;

        private  void Conectar()
        {
            try
            {
                cn = new SqlConnection(@"Data Source=.;Initial Catalog=Facturacion;Integrated Security=True");
                cn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error En la conexion a la bd: {0}" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private  void Desconectar()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error De Desconexion en la  bd: {0}" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public  bool existeProducto(string IDproducto)
        {
            int aux = 0;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("SELECT (1) FROM Producto WHERE IDProducto = ' '' +IDProducto+'' ' ", cn);
                aux = Convert.ToInt32(cmd.ExecuteScalar());
                Desconectar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error De Desconexion en la  bd: {0}" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return aux == 1;

        }



    }
}
