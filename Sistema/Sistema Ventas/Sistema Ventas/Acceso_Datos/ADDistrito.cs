using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADDistrito
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Distrito Entidad(IDataReader lector_entidad)
        {
            var entidad = new Distrito();
            entidad.IdDistrito = Convert.ToInt32(lector_entidad["IdDistrito"]);
            entidad.NombreDistrito = Convert.ToString(lector_entidad["NombreDistrito"]);
            entidad.IdProvincia= Convert.ToInt32(lector_entidad["IdProvincia"]);
            return entidad;
        }
        public static Distrito Entidad2(IDataReader lector_entidad)
        {
            var entidad = new Distrito();
            entidad.IdDistrito = Convert.ToInt32(lector_entidad["IdDistrito"]);
            entidad.NombreDistrito = Convert.ToString(lector_entidad["NombreDistrito"]);
            return entidad;
        }
        public static List<Distrito> ListaEntidades(Distrito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Distrito>();
                var consulta = "select * from Distrito";
                var cmd = new SqlCommand(consulta, cn);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;

            }
        }
        public static List<Distrito> ListarDist(Distrito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Distrito>();
                var consulta = "select IdDistrito,NombreDistrito from Distrito where IdProvincia=@idpro";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("idpro", e.IdProvincia);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad2(dr));
                }
                return lista;

            }
        }
        public static bool Agregar(Distrito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var entidad = new Distrito();
                var consulta = "insert into Distrito values(@nom,@idprov)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", entidad.NombreDistrito);
                cmd.Parameters.AddWithValue("@idprov", entidad.IdProvincia);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Distrito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var entidad = new Distrito();
                var consulta = "update Distrito set NombreDistrito=@nom,IdProvincia=@idprov where IdDistrito=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", entidad.NombreDistrito);
                cmd.Parameters.AddWithValue("@idprov", entidad.IdProvincia);
                cmd.Parameters.AddWithValue("@id", entidad.IdDistrito);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Distrito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdDistrito),0) from Distrito where IdDistrito=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdDistrito);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
        
    }
}
