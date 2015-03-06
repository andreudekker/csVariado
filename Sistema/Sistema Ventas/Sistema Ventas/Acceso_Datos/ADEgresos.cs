using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADEgresos
    {
        public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Egresos Entidad(IDataReader lector_entidad)
        {
            var entidad = new Egresos();
            entidad.IdEgreso = Convert.ToInt32(lector_entidad["IdEgresos"]);
            entidad.Fecha = Convert.ToDateTime(lector_entidad["Fecha"]);
            entidad.Monto = Convert.ToSingle(lector_entidad["Monto"]);
            entidad.Motivo = Convert.ToString(lector_entidad["Motivo"]);
            entidad.IdEmpleado = Convert.ToInt32(lector_entidad["IdEmpleado"]);
            return entidad;
        }
        public static Egresos Entidad2(IDataReader lector_entidad)
        {
            var entidad = new Egresos();
            entidad.Total = Convert.ToSingle(lector_entidad["Total"]);
            entidad.Motivo = Convert.ToString(lector_entidad["Motivo"]);
            
            return entidad;
        }
        public static List<Egresos> ListaEntidades(Egresos e, DateTime fec_ini, DateTime fec_fin)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Egresos>();
                var consulta = "Select * from Egresos where Fecha >= @fec_ini and Fecha <=fec_fin and Motivo like @mot";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@fecini", fec_ini);
                cmd.Parameters.AddWithValue("@fecfin", fec_fin);
                cmd.Parameters.AddWithValue("@mot", e.Motivo);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        public static bool Agregar(Egresos e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Egresos values(@idemp,@fec,@mon,@mot)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@fec", e.Fecha);
                cmd.Parameters.AddWithValue("@mon", e.Monto);
                cmd.Parameters.AddWithValue("@mot", e.Motivo);
                cmd.Parameters.AddWithValue("@idemp", e.IdEmpleado);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        //public static bool Actualizar(Egresos e)
        //{
        //    using (cn)
        //    {
        //        var consulta = "update Egresos set Fecha=@fec,Monto=@mon,Motivo=@mot,IdEmpleado=@idemp where IdEgresos=@id";
        //        var cmd = new SqlCommand(consulta, cn);
        //        cmd.Parameters.AddWithValue("@fec", e.Fecha);
        //        cmd.Parameters.AddWithValue("@mon", e.Monto);
        //        cmd.Parameters.AddWithValue("@mot", e.Motivo);
        //        cmd.Parameters.AddWithValue("@idemp", e.IdEmpleado);
        //        cmd.Parameters.AddWithValue("@id", e.IdEgresos);
        //        cn.Open();
        //        return Convert.ToBoolean(cmd.ExecuteNonQuery());
        //    }
        public static List<Egresos> CierreCaja2()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Egresos>();
                var consulta = "spS_CierreCaja2";
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
