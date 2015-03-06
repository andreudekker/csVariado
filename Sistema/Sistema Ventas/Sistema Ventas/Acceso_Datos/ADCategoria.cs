using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADCategoria
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Categoria Entidad(IDataReader lector_entidad)
        {
            //creamos un objeto de la clase Categoria para obtener todas sus propiedades
            var entidad = new Categoria();
            //las convertimos a su tipo de datos correspondiente
            entidad.IdCategoria = Convert.ToInt32(lector_entidad["IdCategoria"]);
            entidad.NombreCategoria = Convert.ToString(lector_entidad["NomCategoria"]);
            entidad.Descripcion = Convert.ToString(lector_entidad["Descripcion"]);
            return entidad;
        }
        public static Categoria Entidad2(IDataReader lector_entidad)
        {
            var entidad = new Categoria();
            entidad.IdCategoria = Convert.ToInt32(lector_entidad["IdCategoria"]);
            entidad.NombreCategoria = Convert.ToString(lector_entidad["NomCategoria"]);
            return entidad;
        }
        public static List<Categoria> ListaEntidades(Categoria e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Categoria>();
                //Consulta sql
                var consulta = "Select * from Categoria where NomCategoria like @nom +'%'";
                //Ejecuta a consulta y lo almacena en la variable cmd
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", e.NombreCategoria);
                cn.Open();
                //toda la informacion se almacena en dr
                //va a ejecutar la consulta para leer todos los registros
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        public static List<Categoria> ListarCategorias()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Categoria>();
                var consulta = "Select IdCategoria,NomCategoria from Categoria";
                var cmd = new SqlCommand(consulta, cn);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad2(dr));
                }
                return lista;
            }
        }
        public static bool Agregar(Categoria e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Categoria values(@nom,@des)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", e.NombreCategoria);
                cmd.Parameters.AddWithValue("@des", e.Descripcion);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Categoria e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Categoria set NomCategoria=@nom,Descripcion=@des where IdCategoria=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", e.NombreCategoria);
                cmd.Parameters.AddWithValue("@des", e.Descripcion);
                cmd.Parameters.AddWithValue("@id", e.IdCategoria);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Categoria e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdCategoria),0) from Categoria where IdCategoria=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@id", e.IdCategoria);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
        public static bool Duplicado(Categoria e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdCategoria),0) from Categoria where NomCategoria=@nom";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", e.NombreCategoria);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
    }
}
