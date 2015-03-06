using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADAval
    {
        public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Aval Entidad(IDataReader lector_entidad)
        {
            //creamos un objeto de la clase Aval para obtener todas sus propiedades
            var entidad = new Aval();
            //las convertimos a su tipo de datos correspondiente
            entidad.IdAval = Convert.ToInt32(lector_entidad["IdAval"]);
            entidad.dni = Convert.ToString(lector_entidad["dni"]);
            entidad.Nombres = Convert.ToString(lector_entidad["Nombres"]);
            entidad.Apellidos = Convert.ToString(lector_entidad["Apellidos"]);
            entidad.Fec_nacimiento = Convert.ToDateTime(lector_entidad["Fec_nacimiento"]);
            entidad.Estado_civil = Convert.ToString(lector_entidad["Estado_civil"]);
            entidad.Direccion = Convert.ToString(lector_entidad["Direccion"]);
            entidad.Distrito = Convert.ToString(lector_entidad["Distrito"]);
            entidad.NroTitulo = Convert.ToString(lector_entidad["NroTitulo"]);
            return entidad;
        }
        public static List<Aval> ListaEntidades(Aval e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Aval>();
                var consulta = "Select * from Aval where DNI like @dni";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
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
        public static bool Agregar(Aval e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Aval values(@dni,@nom,@ape,@fecnam,@estciv,@dir,@dis,@nro_tit)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cmd.Parameters.AddWithValue("@nom", e.Nombres);
                cmd.Parameters.AddWithValue("@ape", e.Apellidos);
                cmd.Parameters.AddWithValue("@fecnam", e.Fec_nacimiento);
                cmd.Parameters.AddWithValue("@estciv", e.Estado_civil);
                cmd.Parameters.AddWithValue("@dir", e.Direccion);
                cmd.Parameters.AddWithValue("@dis", e.Distrito);
                cmd.Parameters.AddWithValue("@nro_tit", e.NroTitulo);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Aval e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Aval set DNI=@dni,Nombres=@nom,Apellidos=@ape,Fec_nacimiento=@fecnam,Estado_civil=@estciv,Direccion=@dir,Distrito=@dis,NroTitulo=@nro_tit where IdAval=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cmd.Parameters.AddWithValue("@nom", e.Nombres);
                cmd.Parameters.AddWithValue("@ape", e.Apellidos);
                cmd.Parameters.AddWithValue("@fecnam", e.Fec_nacimiento);
                cmd.Parameters.AddWithValue("@estciv", e.Estado_civil);
                cmd.Parameters.AddWithValue("@dir", e.Direccion);
                cmd.Parameters.AddWithValue("@dis", e.Distrito);
                cmd.Parameters.AddWithValue("@idaval", e.IdAval);
                cmd.Parameters.AddWithValue("@nro_tit", e.NroTitulo);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Aval e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdAval),0) from Aval where IdAval=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdAval);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }
        public static bool ExisteNombres(Aval e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdAval),0) from Aval where Nombres=@nom and Apellidos=@ape";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", e.Nombres);
                cmd.Parameters.AddWithValue("@ape", e.Apellidos);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
        public static bool ExisteDNI(Aval e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdAval),0) from Aval where DNI=@dni";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
        public static int ObtenerUltimoID()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select MAX(IdAval) from Aval";
                var cmd = new SqlCommand(consulta, cn);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
