using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADLineaCredito
    {
        //public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static LineaCredito Entidad(IDataReader lector_entidad)
        {
            var entidad = new LineaCredito();
            entidad.IdLinea_credito = Convert.ToInt32(lector_entidad["IdLinea_credito"]);
            entidad.IdCliente = Convert.ToInt32(lector_entidad["IdCliente"]);
            entidad.IdEmpleado = Convert.ToInt32(lector_entidad["IdEmpleado"]);
            entidad.Fecha = Convert.ToDateTime(lector_entidad["Fecha"]);
            entidad.NroHijos = Convert.ToInt32(lector_entidad["NroHijos"]);
            entidad.TiempoResidencia = Convert.ToInt32( lector_entidad["TiempoResidencia"]);
            entidad.Edad = Convert.ToInt32(lector_entidad["Edad"]);
            entidad.Telefono = Convert.ToString(lector_entidad["Telefono"]);
            entidad.TipoVivienda = Convert.ToString(lector_entidad["TipoVivienda"]);
            //entidad.TipoVehiculo = Convert.ToString(lector_entidad["TipoVehiculo"]);
            entidad.FormaVida = Convert.ToString(lector_entidad["FormaVida"]);
            entidad.CentroTrabajo = Convert.ToString(lector_entidad["CentroTrabajo"]);
            entidad.Profesion = Convert.ToString(lector_entidad["Profesion"]);
            entidad.TiempoTrabajo = Convert.ToInt32(lector_entidad["TiempoTrabajo"]);
            entidad.TipoTrabajo = Convert.ToString(lector_entidad["TipoTrabajo"]);
            entidad.DireccionTrabajo = Convert.ToString(lector_entidad["DireccionTrabajo"]);
            entidad.Urbanizacion = Convert.ToString(lector_entidad["Urbanizacion"]);
            entidad.Ingresos = Convert.ToSingle(lector_entidad["Ingresos"]);
            entidad.TelefonoTrabajo= Convert.ToString(lector_entidad["TelefonoTrabajo"]);
            entidad.cme = Convert.ToSingle(lector_entidad["CME"]);
            entidad.cmedisponible = Convert.ToSingle(lector_entidad["CMEdisponible"]);
            entidad.DistritoTrabajo = Convert.ToString(lector_entidad["DistritoTrabajo"]);
            entidad.Estado = Convert.ToString(lector_entidad["Estado"]);
            entidad.IdVivienda = Convert.ToInt32(lector_entidad["IdVivienda"]);
            entidad.IdVehiculo = Convert.ToInt32(lector_entidad["IdVehiculo"]);
            entidad.IdAval = Convert.ToInt32(lector_entidad["IdAval"]);
            
            return entidad;
        }
        public static LineaCredito Entidad2(IDataReader lector_entidad)
        {
            var entidad = new LineaCredito();
            entidad.IdLinea_credito = Convert.ToInt32(lector_entidad["IdLinea_credito"]);
            entidad.cme = Convert.ToSingle(lector_entidad["CME"]);
            entidad.cmedisponible = Convert.ToSingle(lector_entidad["CMEdisponible"]);
            return entidad;
        }
        public static List<LineaCredito> ListaEntidades(LineaCredito e, DateTime fec_ini, DateTime fec_fin)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<LineaCredito>();
                var consulta = "Select * from LineaCredito";
                var cmd = new SqlCommand(consulta, cn); cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        public static bool Agregar(LineaCredito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into LineaCredito values(@idcli,@idemp,@fec,@nrohij,@tieres,@edad,@tel,@tipviv,@forvid,@centra,@prof,@tie_tra,@tip_tra,@dirtra,@urb,@ing,@teltra,@cme,@cmedis,@distra,@est,@idviv,@idvehi,@idaval)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idcli", e.IdCliente);
                cmd.Parameters.AddWithValue("@idemp", e.IdEmpleado);
                cmd.Parameters.AddWithValue("@fec", e.Fecha);
                cmd.Parameters.AddWithValue("@nrohij", e.NroHijos);
                cmd.Parameters.AddWithValue("@tieres", e.TiempoResidencia);
                cmd.Parameters.AddWithValue("@edad", e.Edad);
                cmd.Parameters.AddWithValue("@tel", e.Telefono);
                cmd.Parameters.AddWithValue("@tipviv", e.TipoVivienda);
                cmd.Parameters.AddWithValue("@forvid", e.FormaVida);
                cmd.Parameters.AddWithValue("@tie_tra", e.TiempoTrabajo);
                cmd.Parameters.AddWithValue("@tip_tra", e.TipoTrabajo);
                cmd.Parameters.AddWithValue("@centra", e.CentroTrabajo);
                cmd.Parameters.AddWithValue("@prof", e.Profesion);
                cmd.Parameters.AddWithValue("@dirtra", e.DireccionTrabajo);
                cmd.Parameters.AddWithValue("@urb", e.Urbanizacion);
                cmd.Parameters.AddWithValue("@ing", e.Ingresos);
                cmd.Parameters.AddWithValue("@teltra", e.TelefonoTrabajo);
                cmd.Parameters.AddWithValue("@cme", e.cme);
                cmd.Parameters.AddWithValue("@cmedis", e.cmedisponible);
                cmd.Parameters.AddWithValue("@distra", e.DistritoTrabajo);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                if (e.IdVivienda > 0){ cmd.Parameters.AddWithValue("@idviv", e.IdVivienda);}
                else {cmd.Parameters.AddWithValue("@idviv", DBNull.Value); }

                if (e.IdVehiculo > 0){cmd.Parameters.AddWithValue("@idvehi", e.IdVehiculo);}
                else {cmd.Parameters.AddWithValue("@idvehi", DBNull.Value);}

                if (e.IdAval> 0){cmd.Parameters.AddWithValue("@idaval", e.IdAval);}
                else {cmd.Parameters.AddWithValue("@idaval", DBNull.Value);}
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
                //consulta = "select isnull(max(IdLinea_credito),0) from LineaCredito";
                //cmd = new SqlCommand(consulta, cn);
                //var maxid = Convert.ToInt32(cmd.ExecuteScalar());
                //consulta = "insert into AprobacionLinea_Detalle values(@idmov,@idpro,@can)";
                //cmd = new SqlCommand(consulta, cn);
                //cmd.Parameters.AddWithValue("@idlin", maxid);
                //foreach (var lista in e.ListaDetalle)
                //{
                //    cmd.Parameters.AddWithValue("@idemp", lista.IdEmpleado);
                //    r1 = r1 && Convert.ToBoolean(cmd.ExecuteNonQuery());
                //}
                //return r1;
            }
        }
        //La evaluacion del credito lo hago en la capa de datos?
        public static bool Actualizar(LineaCredito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update LineaCredito set IdCliente=@idcli,IdEmpleado=@idemp,Fecha=@fec,NroHijos=@nrohij,TiempoResidencia=@tieres,Edad=@edad,Telefono=@tel,TipoVivienda=@tipviv,CentraTrabajo=@centra,Profesion=@prof,TiempoTrabajo=@tie_tra,TipoTrabajo=@tip_tra,DireccionTrabajo=@dirtra,Urbanizacion=@urb,Ingresos=@ing,TelefonoTrabajo=teltra,CME=@cme,CMEdisponible=@cmedis,DistritoTrabajo=@distra,Estado=@est,IdVivienda=@idviv,IdVehiculo=@idvehi,IdAval=@idaval where IdLinea_credito=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@idcli", e.IdCliente);
                cmd.Parameters.AddWithValue("@idemp", e.IdEmpleado);
                cmd.Parameters.AddWithValue("@fec", e.Fecha);
                cmd.Parameters.AddWithValue("@nrohij", e.NroHijos);
                cmd.Parameters.AddWithValue("@tieres", e.TiempoResidencia);
                cmd.Parameters.AddWithValue("@edad", e.Edad);
                cmd.Parameters.AddWithValue("@tel", e.Telefono);
                cmd.Parameters.AddWithValue("@tipviv", e.TipoVivienda);
                cmd.Parameters.AddWithValue("@forvid", e.FormaVida);
                cmd.Parameters.AddWithValue("@centra", e.CentroTrabajo);
                cmd.Parameters.AddWithValue("@tie_tra", e.TiempoTrabajo);
                cmd.Parameters.AddWithValue("@prof", e.Profesion);
                cmd.Parameters.AddWithValue("@tip_tra", e.TipoTrabajo);
                cmd.Parameters.AddWithValue("@dirtra", e.DireccionTrabajo);
                cmd.Parameters.AddWithValue("@urb", e.Urbanizacion);
                cmd.Parameters.AddWithValue("@ing", e.Ingresos);
                cmd.Parameters.AddWithValue("@teltra", e.TelefonoTrabajo);
                cmd.Parameters.AddWithValue("@cme", e.cme);
                cmd.Parameters.AddWithValue("@cmedis", e.cmedisponible);
                cmd.Parameters.AddWithValue("@distra", e.DistritoTrabajo);
                cmd.Parameters.AddWithValue("@est", e.Estado);
                cmd.Parameters.AddWithValue("@idviv", e.IdVivienda);
                cmd.Parameters.AddWithValue("@idvehi", e.IdVehiculo);
                cmd.Parameters.AddWithValue("@idaval", e.IdAval);
                cmd.Parameters.AddWithValue("@id", e.IdLinea_credito);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(LineaCredito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdLinea_credito),0) from LineaCredito where IdLinea_credito=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdLinea_credito);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
        public static string AprobarCredito_Labor(LineaCredito e) 
        {
            string estado="";
            int punt_tipo_trab=0, punt_tiempo_res=0, punt_tiempo_trab=0,punt_tipo_viv=0,punt_forma_vida=0,puntaje_total;
            if (e.Edad>=18)
            {
                if (e.TipoTrabajo == "A") { punt_tipo_trab = 4; }
                if (e.TipoTrabajo == "B") { punt_tipo_trab = 2; }
                if (e.TipoTrabajo == "C") { punt_tipo_trab = 1; }

                if (Convert.ToInt32(e.TiempoTrabajo) <= 12) { punt_tiempo_trab = 1; }
                if (Convert.ToInt32(e.TiempoTrabajo) > 12 && Convert.ToInt32(e.TiempoTrabajo) <= 24) { punt_tiempo_trab = 2; }
                if (Convert.ToInt32(e.TiempoTrabajo) > 24) { punt_tiempo_trab = 4; }

                if (Convert.ToInt32(e.TiempoResidencia) <= 12) { punt_tiempo_res = 1; }
                if (Convert.ToInt32(e.TiempoResidencia) > 12 && Convert.ToInt32(e.TiempoResidencia) <= 24) { punt_tiempo_res = 2; }
                if (Convert.ToInt32(e.TiempoResidencia) > 24) { punt_tiempo_res = 4; }

                if (e.TipoVivienda == "A") { punt_tipo_viv = 4; }
                if (e.TipoVivienda == "B") { punt_tipo_viv = 2; }
                if (e.TipoVivienda == "C") { punt_tipo_viv = 1; }

                if (e.FormaVida == "A") { punt_forma_vida = 4; }
                if (e.FormaVida == "B") { punt_forma_vida = 2; }
                if (e.FormaVida == "C") { punt_forma_vida = 1; }

                puntaje_total = punt_tiempo_res + punt_tiempo_trab + punt_tipo_trab + punt_tipo_viv + punt_forma_vida;

                if (puntaje_total > 10) { if (e.Edad >= 29 ) estado = "Aprobado"; }
                else if (puntaje_total <= 10) { if (e.Edad < 18 || e.Edad < 70)if ((e.Edad < 29)) estado = "Denegado"; }
            }
            else
            {
                estado="Denegado";
            }
            
            
            return estado;
        }
        
        public static float CalcularCME(LineaCredito e)
        {
            float cme=0f;
            e.Ingresos = e.Ingresos - e.NroHijos * 0.05f * e.Ingresos;
            cme = e.Ingresos * 0.2f;
            return cme;
        }
        public static int FiltrarLinCredito(LineaCredito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "Select idlinea_credito from LineaCredito where idcliente=@id";
                var cmd = new SqlCommand(consulta, cn); cn.Open();
                cmd.Parameters.AddWithValue("@id", e.IdCliente);
                return Convert.ToInt32( cmd.ExecuteScalar());
                
            }
        }
        public static List<LineaCredito> ListadoFiltroLinCredito(LineaCredito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<LineaCredito>();
                var consulta = "Select idlinea_credito,cme,cmedisponible from LineaCredito where idcliente=@id";
                var cmd = new SqlCommand(consulta, cn); cn.Open();
                cmd.Parameters.AddWithValue("@id", e.IdCliente);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad2(dr));
                }
                return lista;
            }
        }
        public static float ObtenerCME(LineaCredito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "Select cmedisponible from LineaCredito where idcliente=@id";
                var cmd = new SqlCommand(consulta, cn); cn.Open();
                cmd.Parameters.AddWithValue("@id", e.IdCliente);
                ;
                return Convert.ToSingle(cmd.ExecuteScalar());
            }
        }
        public static bool ModfificarCMEDisponible(LineaCredito e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update LineaCredito set CMEdisponible=CMEdisponible-@cme where idcliente=@id";
                var cmd = new SqlCommand(consulta, cn); cn.Open();
                cmd.Parameters.AddWithValue("@cme", e.cme);
                cmd.Parameters.AddWithValue("@id", e.IdCliente);
                ;
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        
    }
}
