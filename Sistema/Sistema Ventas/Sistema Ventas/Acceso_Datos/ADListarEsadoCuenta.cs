using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADListarEsadoCuenta
    {
        public static ListarEstadoCuenta1 Entidad(IDataReader lector_entidad)
        {
            var entidad = new ListarEstadoCuenta1();
            entidad.Cliente = Convert.ToString(lector_entidad["Cliente"]);
            entidad.DNI = Convert.ToString(lector_entidad["DNI"]);
            entidad.Direccion = Convert.ToString(lector_entidad["Direccion"]);
            entidad.cme= Convert.ToSingle(lector_entidad["CME"]);
            entidad.cmedisponible = Convert.ToSingle(lector_entidad["CMEdisponible"]);
            entidad.Vendedor = Convert.ToString(lector_entidad["Vendedor"]);
            entidad.DNI_vendedor= Convert.ToString(lector_entidad["DNI_Vendedor"]);
            
            return entidad;
        }
        public static List<ListarEstadoCuenta1> ListaEntidades(string dni)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<ListarEstadoCuenta1>();
                var consulta = "spS_ListarEstadoCuenta1";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        public static ListarEstadoCuenta2 Entidad2(IDataReader lector_entidad)
        {
            var entidad = new ListarEstadoCuenta2();
            entidad.IdPago = Convert.ToInt32(lector_entidad["IdPago"]);
            entidad.IdPrestamo= Convert.ToInt32(lector_entidad["IdPrestamo"]);
            entidad.Nro = Convert.ToInt32(lector_entidad["Nro"]);
            entidad.Fec_vencimiento= Convert.ToDateTime(lector_entidad["Fec_vencimiento"]);
            entidad.Total = Convert.ToSingle(lector_entidad["Total"]);
            entidad.Debe= Convert.ToSingle(lector_entidad["Debe"]);
            entidad.Fec_Pago = Convert.ToString(lector_entidad["Fec_pago"]);

            return entidad;
        }
        public static List<ListarEstadoCuenta2> ListaEntidades2(int id)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<ListarEstadoCuenta2>();
                var consulta = "spS_ListarEstadoCuenta2";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad2(dr));
                }
                return lista;
            }
        }
        public static List<ListarEstadoCuenta2> ListaEntidades3(int id)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<ListarEstadoCuenta2>();
                var consulta = "spS_ListarEstadoCuenta3";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
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
