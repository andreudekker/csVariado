using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADPagos
    {
        public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Pago Entidad(IDataReader lector_entidad)
        {
            var entidad = new Pago();
            entidad.IdPago = Convert.ToInt32(lector_entidad["IdPagos"]);
            entidad.Nro = Convert.ToInt32(lector_entidad["Nro"]);
            entidad.Fec_vencimiento = Convert.ToDateTime(lector_entidad["Fec_vencimiento"]);
            entidad.Interes = Convert.ToSingle(lector_entidad["Capital"]);
            entidad.Cuota = Convert.ToSingle(lector_entidad["Cuota"]);
            entidad.Desgravamen = Convert.ToSingle(lector_entidad["Desgravamen"]);
            entidad.itf = Convert.ToSingle(lector_entidad["ITF"]);
            entidad.Total = Convert.ToSingle(lector_entidad["Total"]);
            entidad.Debe = Convert.ToSingle(lector_entidad["Debe"]);
            entidad.Fec_pago = Convert.ToString(lector_entidad["Fec_pago"]);
            entidad.IdPrestamo = Convert.ToInt32(lector_entidad["IdPrestamo"]);
            return entidad;
        }
        public static List<Pago> ListaEntidades(Pago e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Pago>();
                var consulta = "Select * from Pagos where IdPrestamo=@idpre";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idpre", e.IdPrestamo);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        //public static float Capital_prestado()
        //{ 
        //    float capital=0;
        //    var consulta = "spS_ObtenerCapital";
        //    var cmd = new SqlCommand(consulta, cn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    return capital;
        //}
        //var valor_cuota = capital*((TEM*(Math.Pow( ((1+TEM)),plazo))) / ((Math.Pow(1 + TEM, plazo)) - 1));
        //        consulta = "Insert into Pagos values (@idpres,@nro,@fecven,@cap,@int,@cuo,@des,@itf,@tot,@deb,@fecpag)";
        //        cmd = new SqlCommand(consulta, cn);
        //        var interes=capital*TEM;
        //        var capital_x_mes = valor_cuota - interes;
        //        var p=new Pago();
        //        for (int i = 1; i <=plazo ; i++)
        //        {
        //            DateTime fec_vencimiento =fecha.AddMonths(i);
        //            cmd.Parameters.AddWithValue("@idpres", maxid);
        //            cmd.Parameters.AddWithValue("@nro", i++);
        //            cmd.Parameters.AddWithValue("@fecven",fec_vencimiento);
        //            cmd.Parameters.AddWithValue("@cap", capital_x_mes);
        //            cmd.Parameters.AddWithValue("@int", fec_vencimiento);
        //            cmd.Parameters.AddWithValue("@cuo", valor_cuota);
        //            cmd.Parameters.AddWithValue("@des",p.Desgravamen);
        //            cmd.Parameters.AddWithValue("@itf", p.itf);
        //            cmd.Parameters.AddWithValue("@tot", valor_cuota+p.Desgravamen+p.itf);
        //            cmd.Parameters.AddWithValue("@deb", valor_cuota + p.Desgravamen + p.itf);
        //            cmd.Parameters.AddWithValue("@fecpag", "");
        //        }
        public static bool Agregar(Pago e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Pagos values(@idpre,@nro,@fecven,@cap,@int,@cuo,@des,@itf,@tot,@deb,@fecpag)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idpre", e.IdPrestamo);
                cmd.Parameters.AddWithValue("@nro", e.Nro);
                cmd.Parameters.AddWithValue("@fecven", e.Fec_vencimiento);
                cmd.Parameters.AddWithValue("@cap", e.Capital);
                cmd.Parameters.AddWithValue("@int", e.Interes);
                cmd.Parameters.AddWithValue("@cuo", e.Cuota);
                cmd.Parameters.AddWithValue("@des", e.Desgravamen);
                cmd.Parameters.AddWithValue("@itf", e.itf);
                cmd.Parameters.AddWithValue("@tot", e.Total);
                cmd.Parameters.AddWithValue("@deb", e.Debe);
                cmd.Parameters.AddWithValue("@fecpag", e.Fec_pago);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
        }
        public static bool Actualizar(Pago e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Pagos set Nro=@cap,Fec_desembolso=@fec,Plazo_nrocuotas=@pla,Tea=@tea, TEM=@tem,IdLinea_credito=@idlin,IdVenta=@idven where IPagos=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nro", e.Nro);
                cmd.Parameters.AddWithValue("@fecven", e.Fec_vencimiento);
                cmd.Parameters.AddWithValue("@cap", e.Capital);
                cmd.Parameters.AddWithValue("@int", e.Interes);
                cmd.Parameters.AddWithValue("@cuo", e.Cuota);
                cmd.Parameters.AddWithValue("@des", e.Desgravamen);
                cmd.Parameters.AddWithValue("@itf", e.itf);
                cmd.Parameters.AddWithValue("@tot", e.Total);
                cmd.Parameters.AddWithValue("@deb", e.Debe);
                cmd.Parameters.AddWithValue("@fecpag", e.Fec_pago);
                cmd.Parameters.AddWithValue("@idpre", e.IdPrestamo);
                cmd.Parameters.AddWithValue("@id", e.IdPago);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }

        }
        public static bool Existe(Pago e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdPago),0) from Pagos where IdPago=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@id", e.IdPago);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
        public static bool ModificarPagos(Pago e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Pagos set Debe=@debe, Fec_pago=@fec where IdPago=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@debe", e.Debe);
                cmd.Parameters.AddWithValue("@fec", e.Fec_pago);
                cmd.Parameters.AddWithValue("@id", e.IdPago);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }

        }
    }
}

