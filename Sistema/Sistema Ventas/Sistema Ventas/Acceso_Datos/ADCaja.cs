using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADCaja
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Caja Entidad(IDataReader lector_entidad)
        {
            var entidad = new Caja();
            entidad.IdCaja = Convert.ToInt32(lector_entidad["IdCaja"]);
            entidad.Fecha = Convert.ToDateTime(lector_entidad["Fecha"]);
            entidad.Monto = Convert.ToSingle(lector_entidad["Monto"]);
            entidad.Motivo = Convert.ToString(lector_entidad["Motivo"]);
            entidad.IdVenta = Convert.ToInt32(lector_entidad["IdVenta"]);
            entidad.IdEmpleado = Convert.ToInt32(lector_entidad["IdEmpleado"]);
            return entidad;
        }
        public static Caja Entidad2(IDataReader lector_entidad)
        {
            var entidad = new Caja();
            
            entidad.TotalVenta = Convert.ToSingle(lector_entidad[0]);
            entidad.Motivo = Convert.ToString(lector_entidad["Motivo"]);
            
            return entidad;
        }
        public static List<Caja> ListaEntidades(Caja e,DateTime fec_ini,DateTime fec_fin)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Caja>();
                var consulta = "Select Fecha,Monto,Motivo,IdVenta,IdEmpleado from Caja where Fecha >= @fec_ini and Fecha <=fec_fin and Motivo like @mot";
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
        public static bool Agregar(Caja e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Caja values(@idven,@idemp,@fec,@mon,@mot)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@fec", e.Fecha);
                cmd.Parameters.AddWithValue("@idven", e.IdVenta);
                cmd.Parameters.AddWithValue("@idemp", e.IdEmpleado);
                cmd.Parameters.AddWithValue("@mon", e.Monto);
                cmd.Parameters.AddWithValue("@mot", e.Motivo);
                cn.Open();
                var r1= Convert.ToBoolean(cmd.ExecuteNonQuery());
                //consulta = "select isnull(max(IdCaja),0) from Caja";
                //cmd = new SqlCommand(consulta, cn);
                //var maxid = Convert.ToInt32(cmd.ExecuteScalar());
                //consulta = "Update Ventas set Estado='Efectuado' where IdVenta=@id";
                //cmd=new SqlCommand(consulta,cn);
                //cmd.Parameters.AddWithValue("@id",maxid);
                //r1 = r1 && Convert.ToBoolean(cmd.ExecuteNonQuery());
                return r1;
                //Por q no cerramos la conexion?
            }
        }
        //public static bool Actualizar(Caja e)
        //{
        //    using (cn)
        //    {
        //        var consulta = "update Caja set Fecha=@fec,Monto=@mon,Motivo=@mot,IdEmpleado=@idemp where IdCaja=@id";
        //        var cmd = new SqlCommand(consulta, cn);
        //        cmd.Parameters.AddWithValue("@fec", e.Fecha);
        //        cmd.Parameters.AddWithValue("@mon", e.Monto);
        //        cmd.Parameters.AddWithValue("@mot", e.Motivo);
        //        cmd.Parameters.AddWithValue("@idemp", e.IdEmpleado);
        //        cmd.Parameters.AddWithValue("@id", e.IdCaja);
        //        cn.Open();
        //        return Convert.ToBoolean(cmd.ExecuteNonQuery());
        //    }
        //}
        public static List<Caja> CierreCaja()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Caja>();
                var consulta = "spS_CierreCaja";
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

