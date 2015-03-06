using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Acceso_Datos
{
    public class ADVehiculo
    {
        public static Vehiculo Entidad(IDataReader lector_entidad)
        {
            //creamos un objeto de la clase Cliente para obtener todas sus propiedades
            var entidad = new Vehiculo();
            entidad.IdVehiculo = Convert.ToInt32(lector_entidad["IdVehiculo"]);
            entidad.Marca = Convert.ToString(lector_entidad["Marca"]);
            entidad.Modelo = Convert.ToString(lector_entidad["Modelo"]);
            entidad.NroTarjeta = Convert.ToString(lector_entidad["NroTarjeta"]);
            entidad.Tipo = Convert.ToString(lector_entidad["Tipo"]);
            entidad.Valuacion = Convert.ToSingle(lector_entidad["Valuacion"]);

            return entidad;
        }
        public static List<Vehiculo> ListaEntidades(Vehiculo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Vehiculo>();
                //Consulta sql
                var consulta = "Select [IdVehiculo],[Marca],[Modelo],[NroTarjeta],[Tipo],[Valuacion] from Vehiculo ";
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
        public static bool Agregar(Vehiculo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Vehiculo values(@mar,@mod,@nro_tar,@tip,@val)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@sup", e.Marca);
                cmd.Parameters.AddWithValue("@tel", e.Modelo);
                cmd.Parameters.AddWithValue("@sit", e.NroTarjeta);
                cmd.Parameters.AddWithValue("@tie_res", e.Tipo);
                cmd.Parameters.AddWithValue("@val", e.Valuacion);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Vehiculo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Vehiculos set Marca=@sup,Modelo =@tel,NroTarjeta=@ape,Tipo=@tie_res,Valuacion=@val where IdVehiculo=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@sup", e.Marca);
                cmd.Parameters.AddWithValue("@tel", e.Modelo);
                cmd.Parameters.AddWithValue("@sit", e.NroTarjeta);
                cmd.Parameters.AddWithValue("@tie_res", e.Tipo);
                cmd.Parameters.AddWithValue("@val", e.Valuacion);
                cmd.Parameters.AddWithValue("@id", e.IdVehiculo);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Existe(Vehiculo e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdVehiculo),0) from Vehiculo where IdVehiculo=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdVehiculo);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
        public static int ObtenerUltimoID()
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select MAX(IdVehiculo) from Vehiculo";
                var cmd = new SqlCommand(consulta, cn);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
