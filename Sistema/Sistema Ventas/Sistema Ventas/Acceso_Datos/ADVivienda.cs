using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;
namespace Acceso_Datos
{
    public class ADVivienda
    {
        public static Vivienda Entidad(IDataReader lector_entidad)
        {
            //creamos un objeto de la clase Cliente para obtener todas sus propiedades
            var entidad = new Vivienda();
            entidad.IdVivienda = Convert.ToInt32(lector_entidad["IdVivienda"]);
            entidad.NroTitulo = Convert.ToString(lector_entidad["NroTitulo"]);
            entidad.Superficie = Convert.ToString(lector_entidad["Superficie"]);
            entidad.Telefono = Convert.ToString(lector_entidad["Telefono"]);
            entidad.Situacion = Convert.ToString(lector_entidad["Situacion"]);
            entidad.Valuacion = Convert.ToSingle(lector_entidad["Valuacion"]);
            
            return entidad;
        }
        public static List<Vivienda> ListaEntidades(Vivienda e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Vivienda>();
                //Consulta sql
                var consulta = "Select [IdVivienda],[NroTitulo],[Superficie],[Telefono],[Situacion],[Valuacion] from Vivienda ";
                //Ejecuta a consulta y lo almacena en la variable cmd
                var cmd = new SqlCommand(consulta, cn);
                cn.Open();
                //toda la informacion se almacena en dr
                //va a ejecutar la consulta para leer todos los registros
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        public static bool Agregar(Vivienda e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Vivienda values(@sup,@tel,@sit,@val,@nro_tit)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nro_tit", e.NroTitulo);
                cmd.Parameters.AddWithValue("@sup", e.Superficie);
                cmd.Parameters.AddWithValue("@tel", e.Telefono);
                cmd.Parameters.AddWithValue("@sit", e.Situacion);
                cmd.Parameters.AddWithValue("@val", e.Valuacion);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Vivienda e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Viviendas set Superficie=@sup,Telefono =@tel,Situacion=@ape,TiempoRes=@tie_res,Valuacion=@val where IdVivienda=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@sup", e.Superficie);
                cmd.Parameters.AddWithValue("@tel", e.Telefono);
                cmd.Parameters.AddWithValue("@sit", e.Situacion);
                cmd.Parameters.AddWithValue("@val", e.Valuacion);
                cmd.Parameters.AddWithValue("@id", e.IdVivienda);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Vivienda e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdVivienda),0) from Vivienda where IdVivienda=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdVivienda);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
        public static int ObtenerUltimoID()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select MAX(IdVivienda) from Vivienda";
                var cmd = new SqlCommand(consulta, cn);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
