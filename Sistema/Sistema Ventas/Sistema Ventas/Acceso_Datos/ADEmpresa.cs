using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADEmpresa
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Empresa Entidad(IDataReader lector_entidad)
        {
            //creamos un objeto de la clase Empresa para obtener todas sus propiedades
            var entidad = new Empresa();
            //las convertimos a su tipo de datos correspondiente
            entidad.IdEmpresa = Convert.ToInt32(lector_entidad["IdEmpresa"]);
            entidad.Razon_social = Convert.ToString(lector_entidad["Razon_social"]);
            entidad.Direccion = Convert.ToString(lector_entidad["Direccion"]);
            entidad.Telefono=Convert.ToString(lector_entidad["Telefono"]);
            return entidad;
        }
        public static List<Empresa> ListaEntidades(Empresa e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Empresa>();
                var consulta = "Select * from Empresa where Razon_social like @raz +'%'";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@raz", e.Razon_social);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        public static bool Agregar(Empresa e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Empresa values(@raz,@dir,@tel)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@raz", e.Razon_social);
                cmd.Parameters.AddWithValue("@dir", e.Direccion);
                cmd.Parameters.AddWithValue("@tel", e.Telefono);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Empresa e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Empresa set Razon_social=@raz,Direccion=@dir,Telefono=@tel IdEmpresa=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@raz", e.Razon_social);
                cmd.Parameters.AddWithValue("@dir", e.Direccion);
                cmd.Parameters.AddWithValue("@tel", e.Telefono);
                cmd.Parameters.AddWithValue("@id", e.IdEmpresa);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static int Existe()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(*),0) from Empresa";
                var cmd = new SqlCommand(consulta, cn);
                //cmd.Parameters.AddWithValue("@id", e.IdEmpresa);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
    }
}
