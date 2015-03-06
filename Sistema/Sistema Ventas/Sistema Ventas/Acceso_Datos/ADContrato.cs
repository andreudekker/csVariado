using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADContrato
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Contrato Entidad(IDataReader lector_entidad)
        {
            var entidad = new Contrato();
            entidad.IdContrato = Convert.ToInt32(lector_entidad["IdContrato"]);
            entidad.Fec_ini = Convert.ToDateTime(lector_entidad["Fec_ini"]);
            entidad.Fec_fin = Convert.ToDateTime(lector_entidad["Fec_fin"]);
            entidad.Nick = Convert.ToString(lector_entidad["NIck"]);
            entidad.Clave = Convert.ToString(lector_entidad["Clave"]);
            entidad.Cargo = Convert.ToString(lector_entidad["Cargo"]);
            entidad.Turno = Convert.ToString(lector_entidad["Turno"]);
            entidad.Estado = Convert.ToString(lector_entidad["Estado"]);
            entidad.IdEmpleado = Convert.ToInt32(lector_entidad["IdEmpleado"]);
            return entidad;
        }
        public static List<Contrato> ListaEntidades(Contrato e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Contrato>();
                var consulta = "Select * from Contrato where Cargo like @car and Estado like @est";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@car", e.Cargo);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        public static bool Agregar(Contrato e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Contrato values(@idemp,@fecini,@fecfin,@nic,@cla,@car,@tur,@est)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idemp", e.IdEmpleado);
                cmd.Parameters.AddWithValue("@fecini", e.Fec_ini);
                cmd.Parameters.AddWithValue("@fecfin", e.Fec_fin);
                cmd.Parameters.AddWithValue("@nic", e.Nick);
                cmd.Parameters.AddWithValue("@cla", e.Clave);
                cmd.Parameters.AddWithValue("@car", e.Cargo);
                cmd.Parameters.AddWithValue("@tur", e.Turno);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Contrato e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Contrato set Fec_ini=@fecini,Fec_fin=@fecfin,Nick=@nic,Clave=@cla,Cargo=@car,Turno=@tur,Estado=@est ,IdEmpleado=@idemp where IdContrato=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@fecini", e.Fec_ini);
                cmd.Parameters.AddWithValue("@fecfin", e.Fec_fin);
                cmd.Parameters.AddWithValue("@nic", e.Nick);
                cmd.Parameters.AddWithValue("@cla", e.Clave);
                cmd.Parameters.AddWithValue("@car", e.Cargo);
                cmd.Parameters.AddWithValue("@tur", e.Turno);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                cmd.Parameters.AddWithValue("@idemp", e.IdEmpleado);
                cmd.Parameters.AddWithValue("@id", e.IdContrato);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Contrato e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdContrato),0) from Contrato where IdContrato=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@id", e.IdContrato);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
        public static int Login(Contrato e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "spS_Ingresar";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nick", e.Nick);
                cmd.Parameters.AddWithValue("@cla", e.Clave);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public static string TipoIngreso(Contrato e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "spS_TipoIngreso";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nick", e.Nick);
                cmd.Parameters.AddWithValue("@cla", e.Clave);
                cn.Open();
                return Convert.ToString(cmd.ExecuteScalar());
            }

        }
        public static int IdEmpleadoIngreso(Contrato e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "spS_IdEmpleadoIngreso";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nick", e.Nick);
                cmd.Parameters.AddWithValue("@cla", e.Clave);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public static string EmpleadoIngreso(Contrato e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = @"SELECT  dbo.Empleados.Nombres+' '+ dbo.Empleados.Apellidos
                                FROM         dbo.Empleados INNER JOIN
                                dbo.Contrato ON dbo.Empleados.IdEmpleado = dbo.Contrato.IdEmpleado
                                where Contrato.nick=@nick";
                var cmd = new SqlCommand(consulta, cn);
                
                cmd.Parameters.AddWithValue("@nick", e.Nick);
                cn.Open();
                return Convert.ToString(cmd.ExecuteScalar());
            }

        }
    }
}
