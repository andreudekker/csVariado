using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADProducto
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Producto Entidad(IDataReader lector_entidad)
        {
            //creamos un objeto de la clase Producto para obtener todas sus propiedades
            var entidad = new Producto();
            //las convertimos a su tipo de datos correspondiente
            entidad.IdProducto = Convert.ToInt32(lector_entidad["IdProducto"]);
            entidad.Marca = Convert.ToString(lector_entidad["Marca"]);
            entidad.Modelo = Convert.ToString(lector_entidad["Modelo"]);
            entidad.Precio = Convert.ToSingle(lector_entidad["Precio"]);
            entidad.Stock = Convert.ToInt32(lector_entidad["Stock"]);
            entidad.Estado = Convert.ToString(lector_entidad["Estado"]);
            entidad.IdCategoria = Convert.ToInt32(lector_entidad["IdCategoria"]);
            return entidad;
        }
        public static List<Producto> ListaEntidades(Producto e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Producto>();
                var consulta = "Select * from Productos where Marca like @mar +'%' and Modelo like @mod +'%'";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@mar", e.Marca);
                cmd.Parameters.AddWithValue("@mod", e.Modelo);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        public static bool Agregar(Producto e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Productos values(@idcat,@mar,@mod,@pre,@stock,@est)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idcat", e.IdCategoria);
                cmd.Parameters.AddWithValue("@mar", e.Marca);
                cmd.Parameters.AddWithValue("@mod", e.Modelo);
                cmd.Parameters.AddWithValue("@pre", e.Precio);
                cmd.Parameters.AddWithValue("@stock", e.Stock);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Producto e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Productos set Marca=@mar, Modelo=@mod,Precio=@pre,Stock=@stock,Estado=@est,IdCategoria=@idcat where IdProducto=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@mar", e.Marca);
                cmd.Parameters.AddWithValue("@mod", e.Modelo);
                cmd.Parameters.AddWithValue("@pre", e.Precio);
                cmd.Parameters.AddWithValue("@stock", e.Stock);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                cmd.Parameters.AddWithValue("@idcat", e.IdCategoria);
                cmd.Parameters.AddWithValue("@id", e.IdProducto);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Producto e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdProducto),0) from Productos where IdProducto=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdProducto);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
        public static int ObtenerIdProducto(Producto e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(IdProducto,0) from Productos where Modelo like @mod";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@mod", e.Modelo);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public static int ObtenerStock(Producto e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select stock from Productos where Modelo like @mod";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@mod", e.Modelo);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public static bool ModificarStock(Producto e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Productos set Stock=@stock where modelo=@mod";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@stock", e.Stock);
                cmd.Parameters.AddWithValue("@mod", e.Modelo);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }

        }
        public static bool ExisteModelo(Producto e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdProducto),0) from Productos where Modelo=@mod";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@mod", e.Modelo);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
    }
}
