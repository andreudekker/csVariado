using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADDepartamento
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Departamento Entidad(IDataReader lector_entidad)
        {
            var entidad = new Departamento();
            entidad.IdDepartamento = Convert.ToInt32(lector_entidad["IdDepartamento"]);
            entidad.NombreDepartamento = Convert.ToString(lector_entidad["NombreDepartamento"]);
            entidad.NombreCapitalDep = Convert.ToString(lector_entidad["NombreCapitalDep"]);
            return entidad;
        }
        public static Departamento Entidad2(IDataReader lector_entidad)
        {
            var entidad = new Departamento();
            entidad.IdDepartamento = Convert.ToInt32(lector_entidad["IdDepartamento"]);
            entidad.NombreDepartamento = Convert.ToString(lector_entidad["NombreDepartamento"]);
            return entidad;
        }
        public static List<Departamento> ListaEntidades(Departamento e)
        {
            var cn=new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista=new List<Departamento>();
                var consulta = "select * from Departamento";
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
        public static List<Departamento> ListarDpto()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Departamento>();
                var consulta = "select IdDepartamento,NombreDepartamento from Departamento";
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
        //public static bool Agregar(Departamento e)
        //{
        //    using (cn)
        //    {
        //        var entidad = new Departamento();
        //        var consulta = "insert into Departamento values(@nom,@cap)";
        //        var cmd = new SqlCommand(consulta, cn);
        //        cmd.Parameters.AddWithValue("@nom", entidad.NombreDepartamento);
        //        cmd.Parameters.AddWithValue("@cap", entidad.NombreCapitalDep);
        //        cn.Open();
        //        return Convert.ToBoolean(cmd.ExecuteNonQuery());
        //    }
        //}
        //public static bool Actualizar(Departamento e)
        //{
        //    using (cn)
        //    {
        //        var entidad = new Departamento();
        //        var consulta = "update Departamento set NombreDepartamento=@nom,NombreCapitalDep=@cap where IdDepartamento=@id";
        //        var cmd = new SqlCommand(consulta, cn);
        //        cmd.Parameters.AddWithValue("@nom", entidad.NombreDepartamento);
        //        cmd.Parameters.AddWithValue("@cap", entidad.NombreCapitalDep);
        //        cmd.Parameters.AddWithValue("@id", entidad.IdDepartamento);
        //        cn.Open();
        //        return Convert.ToBoolean(cmd.ExecuteNonQuery());
        //    }
        //}
    }
}
