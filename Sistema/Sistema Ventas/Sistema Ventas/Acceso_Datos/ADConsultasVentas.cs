using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADConsultasVentas
    {
        public static ConsultasVentas EntidadRanking(IDataReader lector_entidad)
        {
            var e = new ConsultasVentas();
            e.dni = Convert.ToString(lector_entidad["DNI"]);
            e.Vendedor = Convert.ToString(lector_entidad["Vendedor"]);
            e.ValorVentas = Convert.ToSingle(lector_entidad["Valor de ventas"]);
            e.cantidad = Convert.ToInt32(lector_entidad["Cantidad"]);
            return e;
        }
        public static ConsultasVentas Entidad_VentaDiaria(IDataReader lector_entidad)
        {
            var e = new ConsultasVentas();
            e.dni = Convert.ToString(lector_entidad["DNI"]);
            e.Vendedor = Convert.ToString(lector_entidad["Vendedor"]);
            e.cantidad = Convert.ToInt32(lector_entidad["Cantidad"]);
            e.ValorVentas = Convert.ToSingle(lector_entidad["Valor de ventas"]);
            
            return e;
        }
        public static ConsultasVentas Entidad_Simulador1(IDataReader lector_entidad)
        {
            var e = new ConsultasVentas();
            e.dni = Convert.ToString(lector_entidad["DNI"]);
            e.Vendedor = Convert.ToString(lector_entidad["Vendedor"]);
            e.Ultima_Venta = Convert.ToInt32(lector_entidad["Ultima venta"]);
            e.Tipo_venta = Convert.ToString(lector_entidad["Tipo_venta"]);
            e.DescuentoAcumulado= Convert.ToSingle(lector_entidad["Descuento acumulado"]);
            return e;
        }
        public static ConsultasVentas Entidad_Simulador2(IDataReader lector_entidad)
        {
            var e = new ConsultasVentas();
            e.TotalComision = Convert.ToSingle(lector_entidad["TotalComision"]);
            e.Proyeccion = Convert.ToSingle(lector_entidad["Proyeccion"]);
            return e;
        }
        #region Ranking

        public static List<ConsultasVentas> RankingVendedores(DateTime fec_ini, DateTime fec_fin)
        {

            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<ConsultasVentas>();
                var proc_almacenado = "spS_RankingVendedores";
                var cmd = new SqlCommand(proc_almacenado, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecini", fec_ini);
                cmd.Parameters.AddWithValue("@fecfin", fec_fin);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(EntidadRanking(dr));
                }
                return lista;
            }
        }
        public static float Totalventa_x_vendedor(DateTime fec_ini, DateTime fec_fin)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var proc_almacenado = "spS_TotalVenta_x_vendedor";
                var cmd = new SqlCommand(proc_almacenado, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecini", fec_ini);
                cmd.Parameters.AddWithValue("@fecfin", fec_fin);
                cn.Open();
                return Convert.ToSingle(cmd.ExecuteScalar());
            }
        }
        #endregion

        #region Ventadiaria

        
        public static List<ConsultasVentas> VentaDiaria(string tip, DateTime fec)
        {

            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<ConsultasVentas>();
                var proc_almacenado = "spS_Ventas_x_dia";
                var cmd = new SqlCommand(proc_almacenado, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fec", fec);
                cmd.Parameters.AddWithValue("@tipven", tip);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad_VentaDiaria(dr));
                }
                return lista;
            }
        }
        public static float TotalVentaDiaria_x_vendedor(string tip ,DateTime fec)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var proc_almacenado = "spS_TotalVentaDiaria_x_vendedor";
                var cmd = new SqlCommand(proc_almacenado, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fec", fec);
                cmd.Parameters.AddWithValue("@tipven", tip);
                cn.Open();
                return Convert.ToSingle(cmd.ExecuteScalar());
            }
        }
        #endregion

        #region Simulador de comisiones
        
        
        public static List<ConsultasVentas> SimuladorComisiones1(string dni)
        {

            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<ConsultasVentas>();
                var proc_almacenado = "spS_SimuladorComision1";
                var cmd = new SqlCommand(proc_almacenado, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad_Simulador1(dr));
                }
                return lista;
            }
        }
        #endregion
        public static List<ConsultasVentas> SimuladorComisiones2(string dni)
        {

            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<ConsultasVentas>();
                var proc_almacenado = "spS_SimuladorComision2";
                var cmd = new SqlCommand(proc_almacenado, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad_Simulador2(dr));
                }
                return lista;
            }
        }

    }
}
