using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADVenta
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Venta Entidad(IDataReader lector_entidad)
        {
            var entidad = new Venta();
            entidad.IdVenta = Convert.ToInt32(lector_entidad["IdVenta"]);
            entidad.IdCliente = Convert.ToInt32(lector_entidad["IdCliente"]);
            entidad.IdEmpleado = Convert.ToInt32(lector_entidad["IdEmpleado"]);
            entidad.IdEmpresa = Convert.ToInt32(lector_entidad["IdEmpresa"]);
            entidad.Tipo_venta = Convert.ToString(lector_entidad["Tipo_venta"]);
            entidad.Fecha = Convert.ToDateTime(lector_entidad["Fecha"]);
            entidad.Nro_venta= Convert.ToInt32(lector_entidad["Nro_venta"]);
            entidad.Estado = Convert.ToString(lector_entidad["Estado"]);
            entidad.Pago_a_cuenta = Convert.ToSingle(lector_entidad["Pago_a_cuenta"]);
            entidad.Total = Convert.ToSingle(lector_entidad["Total"]);
            
            return entidad;
        }
        public static List<Venta> ListaEntidades(Venta e, DateTime fec_ini, DateTime fec_fin)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Venta>();
                var consulta = "Select IdVenta,IdCliente,IdEmpleado,IdEmpresa,Tipo_venta,Fecha,Nro_venta,Estado,Pago_a_cuenta,Total from Ventas where Tipo like @tip and Fecha>=fecini and Fecha<=fecfin and Estado = @est";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@tip", e.Tipo_venta);
                cmd.Parameters.AddWithValue("@fecini", fec_ini);
                cmd.Parameters.AddWithValue("@fecfin", fec_fin);
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
        public static bool Agregar(Venta e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Ventas values(@idcli,@idempl,@idempr,@tip,@fec,@nro,@est,@pagcue,@tot)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idcli", e.IdCliente);
                cmd.Parameters.AddWithValue("@idempl", e.IdEmpleado);
                cmd.Parameters.AddWithValue("@idempr", e.IdEmpresa);
                cmd.Parameters.AddWithValue("@tip", e.Tipo_venta);
                cmd.Parameters.AddWithValue("@fec", e.Fecha);
                cmd.Parameters.AddWithValue("@nro", e.Nro_venta);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                cmd.Parameters.AddWithValue("@pagcue", e.Pago_a_cuenta);
                cmd.Parameters.AddWithValue("@tot", e.Total);
                cn.Open();
                var r1 = Convert.ToBoolean(cmd.ExecuteNonQuery());
                consulta = "select isnull(max(IdVenta),0) from Ventas";
                cmd = new SqlCommand(consulta, cn);
                var maxid = Convert.ToInt32(cmd.ExecuteScalar());
                consulta = "insert into DetalleVentas values(@idven,@idpro,@can,@nroser,@venbru,@des,@valven,@igv,@com)";
                
                foreach (DetalleVentas lista in e.ListaDetalle)
                {
                    cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@idven", maxid);
                    cmd.Parameters.AddWithValue("@can", lista.Cantidad);
                    cmd.Parameters.AddWithValue("@idpro", lista.IdProducto);
                    cmd.Parameters.AddWithValue("@nroser", lista.NroSerie);
                    cmd.Parameters.AddWithValue("@venbru", lista.Venta_bruta);
                    cmd.Parameters.AddWithValue("@des", lista.Descuento);
                    cmd.Parameters.AddWithValue("@valven", lista.Valor_venta);
                    cmd.Parameters.AddWithValue("@igv", lista.igv);
                    cmd.Parameters.AddWithValue("@com", lista.Comision);
                    
                    r1 = r1 && Convert.ToBoolean(cmd.ExecuteNonQuery());
                }
                return r1;
            }
        }
        public static bool Actualizar(Venta e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Ventas set IdCliente=@idcli,IdEmpleado=@idempl,IdEmpresa=@idempr,Tipo_venta=@tip,Fecha=@fec,Nro_venta=@nroven,Estado=@est,Total=@tot where IdVenta=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idcli", e.IdCliente);
                cmd.Parameters.AddWithValue("@idempl", e.IdEmpleado);
                cmd.Parameters.AddWithValue("@idempr", e.IdEmpresa);
                cmd.Parameters.AddWithValue("@tip", e.Tipo_venta);
                cmd.Parameters.AddWithValue("@fec", e.Fecha);
                cmd.Parameters.AddWithValue("@nro", e.Nro_venta);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                cmd.Parameters.AddWithValue("@id", e.IdVenta);
                cmd.Parameters.AddWithValue("@tot", e.Total);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Cobrar(Venta e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Ventas set Estado=@est where IdVenta=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                cmd.Parameters.AddWithValue("@id", e.IdVenta);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Venta e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdVenta),0) from Ventas where IdVenta=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdVenta);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
        public static string ObtenerNro()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdVenta),0) from Ventas";
                var cmd = new SqlCommand(consulta, cn);
                cn.Open();
                var nro_registros=Convert.ToInt32(cmd.ExecuteScalar());
                var nro_venta=0;
                consulta = "select nro_venta from ventas where idventa=(select max(idventa) from ventas)";
                cmd=new SqlCommand(consulta,cn);
                if (nro_registros>0)
                {
                    nro_venta = Convert.ToInt32(cmd.ExecuteScalar());
                }
                nro_venta++;
                return Convert.ToString(nro_venta);
            }

        }
        public static float TotalVenta(DateTime fec_ini, DateTime fec_fin)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                // realizando consulta directa
                var consulta = "select isnull(sum(Total),0) from Ventas where Fecha>=@fecini and Fecha <=@fecfin and estado like '1' + '%'";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@fecini", fec_ini);
                cmd.Parameters.AddWithValue("@fecfin", fec_fin);
                cn.Open();
                return Convert.ToSingle(cmd.ExecuteScalar());
            }
        }
        public static int ObtenerUltimoID()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select max(IdVenta) from Ventas";
                var cmd = new SqlCommand(consulta, cn);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public static float ObtenerCapital(Venta e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select ISNULL( total,0) from Ventas where IdVenta=@idven";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idven", e.IdVenta);
                cn.Open();
                return Convert.ToSingle(cmd.ExecuteScalar());
            }
        }
        public static int ObtenerIDPrestamo(Venta e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "spS_ObtenerIDPrestamo";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nro_preven", e.Nro_venta);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        

    }
}
