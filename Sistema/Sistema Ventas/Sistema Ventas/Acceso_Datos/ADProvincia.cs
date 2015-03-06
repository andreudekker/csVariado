using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADProvincia
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Provincia Entidad(IDataReader lector_entidad)
        {
            //creamos un objeto de la clase Cliente para obtener todas sus propiedades
            var entidad = new Provincia();
            //las convertimos a su tipo de datos correspondiente
            entidad.IdProvincia = Convert.ToInt32(lector_entidad["IdProvincia"]);
            entidad.NombreProvincia = Convert.ToString(lector_entidad["NombreProvincia"]);
            entidad.NombreCapitalProv = Convert.ToString(lector_entidad["NombreCapitalProv"]);
            entidad.IdDepartamento = Convert.ToInt32(lector_entidad["IdDepartamento"]);
            return entidad;
        }
        public static Provincia Entidad2(IDataReader lector_entidad)
        {
            var entidad = new Provincia();
            entidad.IdProvincia = Convert.ToInt32(lector_entidad["IdProvincia"]);
            entidad.NombreProvincia = Convert.ToString(lector_entidad["NombreProvincia"]);
            return entidad;
        }
        public static List<Provincia> ListaEntidades(Provincia e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Provincia>();
                var consulta = "select * from Provincia";
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
        public static List<Provincia> ListarProv(Provincia e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Provincia>();
                var consulta = "select IdProvincia,NombreProvincia from Provincia where IdDepartamento =@iddep";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("iddep", e.IdDepartamento);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad2(dr));
                }
                return lista;

            }
        }
        public static bool Agregar(Provincia e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var entidad = new Provincia();
                var consulta = "insert into Provincia values(@nom,@cap,@iddep)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", entidad.NombreProvincia);
                cmd.Parameters.AddWithValue("@cap", entidad.NombreCapitalProv);
                cmd.Parameters.AddWithValue("@iddep", entidad.IdDepartamento);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Provincia e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var entidad = new Provincia();
                var consulta = "update Provincia set NombreProvincia=@nom,NombreCapitalProv=@cap,IdDepartamento=@iddep where IdProvincia=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", entidad.NombreProvincia);
                cmd.Parameters.AddWithValue("@cap", entidad.NombreCapitalProv);
                cmd.Parameters.AddWithValue("@iddep", entidad.IdDepartamento);
                cmd.Parameters.AddWithValue("@id", entidad.IdProvincia);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Provincia e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdProvincia),0) from Provincia where IdProvincia=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdProvincia);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
    }
}
