using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADPrestamo
    {
        public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Prestamo Entidad(IDataReader lector_entidad)
        {
            var entidad = new Prestamo();
            entidad.IdPrestamo = Convert.ToInt32(lector_entidad["IdPrestamo"]);
            entidad.IdLineaCredito = Convert.ToInt32(lector_entidad["IdLinea_credito"]);
            entidad.IdVenta = Convert.ToInt32(lector_entidad["IdVenta"]);
            entidad.Capital_prestado= Convert.ToSingle(lector_entidad["Capital_prestado"]);
            entidad.Fec_desembolso= Convert.ToDateTime(lector_entidad["Fec_desembolso"]);
            entidad.Plazo_nrouotas= Convert.ToInt32(lector_entidad["Plazo_nrocuotas"]);
            entidad.tea = Convert.ToSingle(lector_entidad["TEA"]);
            entidad.tem = Convert.ToSingle(lector_entidad["TEM"]);
            entidad.Estado = Convert.ToString(lector_entidad["Estado"]);
            return entidad;
        }
        public static Prestamo Entidad2(IDataReader lector_entidad)
        {
            var entidad = new Prestamo();
            entidad.IdPrestamo = Convert.ToInt32(lector_entidad["IdPrestamo"]);
            entidad.Capital_prestado = Convert.ToSingle(lector_entidad["Capital_prestado"]);
            entidad.Fec_desembolso = Convert.ToDateTime(lector_entidad["Fec_desembolso"]);
            entidad.Plazo_nrouotas = Convert.ToInt32(lector_entidad["Plazo_nrocuotas"]);
            entidad.Estado = Convert.ToString(lector_entidad["Estado"]);
            return entidad;
        }
        public static List<Prestamo> ListaEntidades(Prestamo e, DateTime fec_ini, DateTime fec_fin)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Prestamo>();
                var consulta = "Select * from Prestamos where IdLinea_credito=@idlin and Fec_desembolso>=@fecini and Fec_desembolso<=@fecfin";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@fecini", fec_ini);
                cmd.Parameters.AddWithValue("@fecfin", fec_fin);
                cmd.Parameters.AddWithValue("@idlin", e.IdLineaCredito);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        
        //public static int ObtenerId(Prestamo e)
        //{
        //    var obtenerid = "Select IdPrestamo from Prestamos where Dni=@dni";
        //}
        public static float ObtenerCapital(Prestamo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            var obtenercapital = "Select Capital_prestado from Prestamos where IdPrestamo=@id";
            var cmd = new SqlCommand(obtenercapital, cn);
            cn.Open();
            cmd.Parameters.AddWithValue("id", e.IdPrestamo);
            return Convert.ToSingle(cmd.ExecuteScalar()); 
        }
        public static int ObtenerPlazo(Prestamo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            var obtenerplazo = "Select Plazo_nrocuotas from Prestamos where IdPrestamo=@id";
            var cmd = new SqlCommand(obtenerplazo, cn);
            cn.Open();
            cmd.Parameters.AddWithValue("id", e.IdPrestamo);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static float ObtenerTEM(Prestamo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);

            var obtenertem = "Select TEM from Prestamos where IdPrestamo=@id";
            var cmd = new SqlCommand(obtenertem, cn);
            cn.Open();
            cmd.Parameters.AddWithValue("id", e.IdPrestamo);
            return Convert.ToSingle(cmd.ExecuteScalar());
        }
        public static DateTime ObtenerFecha(Prestamo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            var obtenerfecha = "Select Fec_desembolso from Prestamos where IdPrestamo=@id";
            var cmd = new SqlCommand(obtenerfecha, cn);
            cn.Open();
            cmd.Parameters.AddWithValue("id", e.IdPrestamo);
            return Convert.ToDateTime(cmd.ExecuteScalar());

        }
        public static bool Agregar(Prestamo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Prestamos values(@idlin,@idven,@cap,@fec,@pla,@tea,@tem,@est)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idlin", e.IdLineaCredito);
                cmd.Parameters.AddWithValue("@idven", e.IdVenta);
                cmd.Parameters.AddWithValue("@cap", e.Capital_prestado);
                cmd.Parameters.AddWithValue("@fec", e.Fec_desembolso);
                cmd.Parameters.AddWithValue("@pla", e.Plazo_nrouotas);
                cmd.Parameters.AddWithValue("@tea", e.tea);
                cmd.Parameters.AddWithValue("@tem", e.tem);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
                
            }
        }
        public static bool Actualizar(Prestamo e)

        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                //dynamic e;
                var consulta = "update Prestamos set IdLinea_credito=@idlin,IdVenta=@idven,Capital_prestado=@cap,Fec_desembolso=@fec,Plazo_nrocuotas=@pla,Tea=@tea, TEM=@tem where IdPrestamo=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@cap", e.Capital_prestado);
                cmd.Parameters.AddWithValue("@fec", e.Fec_desembolso);
                cmd.Parameters.AddWithValue("@pla", e.Plazo_nrouotas);
                cmd.Parameters.AddWithValue("@tea", e.tea);
                cmd.Parameters.AddWithValue("@tem", e.tem);
                cmd.Parameters.AddWithValue("@idlin", e.IdLineaCredito);
                cmd.Parameters.AddWithValue("@idven", e.IdVenta);
                cmd.Parameters.AddWithValue("@id", e.IdPrestamo);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Prestamo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdPrestamo),0) from Prestamos where IdPrestamo=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdPrestamo);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
        public static int ObtenerIdPrestamo(string dni)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "spS_BuscarIdPrestamo";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public static List<Prestamo> ListaPrestamos(string dni)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Prestamo>();
                var consulta = "spS_ListarPrestamos";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad2(dr));
                }
                return lista;
            }
        }
        public static bool ModificarEstadoPrestamo(Prestamo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Prestamos set estado=@est where idprestamo=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                cmd.Parameters.AddWithValue("@id", e.IdPrestamo);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }

        }
        public static int FlitarIdVenta(int idpres)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = @"SELECT     dbo.Ventas.IdVenta
                                FROM         dbo.Prestamos INNER JOIN
                                dbo.Ventas ON dbo.Prestamos.IdVenta = dbo.Ventas.IdVenta
                                where idprestamo=@id";
                var cmd = new SqlCommand(consulta, cn);
                
                cmd.Parameters.AddWithValue("@id", idpres);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        

        
    }
}
