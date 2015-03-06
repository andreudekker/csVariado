using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;
namespace Acceso_Datos
{
    public class ADEmpleadoContratado
    {
        public static EmpleadoContratado Entidad(IDataReader lector_entidad)
        {
            var entidad = new EmpleadoContratado();
            entidad.IdContrato = Convert.ToInt32(lector_entidad["IdContrato"]);
            entidad.IdEmpleado = Convert.ToInt32(lector_entidad["IdEmpleado"]);
            entidad.dni = Convert.ToString(lector_entidad["dni"]);
            entidad.Empleado = Convert.ToString(lector_entidad["Empleado"]);
            entidad.Fec_ini = Convert.ToDateTime(lector_entidad["Fec_ini"]);
            entidad.Fec_fin = Convert.ToDateTime(lector_entidad["Fec_fin"]);
            entidad.Nick = Convert.ToString(lector_entidad["NIck"]);
            entidad.Clave = Convert.ToString(lector_entidad["Clave"]);
            entidad.Cargo = Convert.ToString(lector_entidad["Cargo"]);
            entidad.Turno = Convert.ToString(lector_entidad["Turno"]);
            entidad.Estado = Convert.ToString(lector_entidad["Estado"]);
            
            return entidad;
        }

        public static List<EmpleadoContratado> ListaEntidades(EmpleadoContratado e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<EmpleadoContratado>();
                var consulta = "spS_ListaEmpleadosContratados";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", e.dni);
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



        public static EmpleadoContratado Entidad2(IDataReader lector_entidad)
        {
            var entidad = new EmpleadoContratado();
            entidad.IdEmpleado = Convert.ToInt32(lector_entidad["IdEmpleado"]);
            entidad.Empleado = Convert.ToString(lector_entidad["Vendedor"]);
            return entidad;
        }

        public static List<EmpleadoContratado> ListaVendedores()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<EmpleadoContratado>();
                var consulta = "spS_ListarVendedores";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad2(dr));
                }
                return lista;
            }
        }
        public static List<EmpleadoContratado> ListaAlmaceneros()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<EmpleadoContratado>();
                var consulta = "spS_ListarAlmaceneros";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad2(dr));
                }
                return lista;
            }
        }
    }
}
