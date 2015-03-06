using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADMovimiento
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Movimiento Entidad(IDataReader lector_entidad)
        {
            var entidad = new Movimiento();
            entidad.IdMovimiento = Convert.ToInt32(lector_entidad["IdMovimiento"]);
            entidad.Tipo = Convert.ToString(lector_entidad["Tipo"]);
            entidad.Fecha = Convert.ToDateTime(lector_entidad["Fecha"]);
            entidad.IdEmpleado = Convert.ToInt32(lector_entidad["IdEmpleado"]);
            return entidad;
        }
        public static List<Movimiento> ListaEntidades(Movimiento e,DateTime fec_ini,DateTime fec_fin)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Movimiento>();
                var consulta = "Select * from Movimiento where Tipo like @tip and Fecha>=fecini and Fecha<=fecfin";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@tip", e.Tipo);
                cmd.Parameters.AddWithValue("@fecini", fec_ini);
                cmd.Parameters.AddWithValue("@fecfin", fec_fin);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        public static bool Agregar(Movimiento e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Movimiento values(@idemp,@tip,@fec)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@tip", e.Tipo);
                cmd.Parameters.AddWithValue("@fec", e.Fecha);
                cmd.Parameters.AddWithValue("@idemp", e.IdEmpleado);
                cn.Open();
                //almacenamos el valor de retorno en r1
                var r1= Convert.ToBoolean(cmd.ExecuteNonQuery());
                //escribimos una consulta mapara saber el ultimo registro ingresado
                consulta = "select isnull(max(IdMovimiento),0) from Movimiento";
                cmd = new SqlCommand(consulta, cn);
                var maxid = Convert.ToInt32(cmd.ExecuteScalar());
                //Ahora agregamos el registro en detalle
                consulta = "insert into DetalleMovimiento values(@idmov,@idpro,@can,@nro_ser)";
                
                foreach (var lista in e.ListaMovimiento)
                {
                    cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@idmov", maxid);
                    cmd.Parameters.AddWithValue("@idpro", lista.IdProducto);
                    cmd.Parameters.AddWithValue("@can", lista.Cantidad);
                    cmd.Parameters.AddWithValue("@nro_ser", lista.NroSerie);
                    r1 = r1 && Convert.ToBoolean(cmd.ExecuteNonQuery());
                }
                return r1;
            }
        }
        public static bool Actualizar(Movimiento e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Movimiento set Tipo=@tip,fecha=@fec,IdEmpleado=@idemp where IdMovimiento=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@tip", e.Tipo);
                cmd.Parameters.AddWithValue("@fec", e.Fecha);
                cmd.Parameters.AddWithValue("@idemp", e.IdEmpleado);
                cmd.Parameters.AddWithValue("@id", e.IdMovimiento);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Movimiento e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdMovimiento),0) from Movimiento where IdMovimiento=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdMovimiento);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
    }
}
