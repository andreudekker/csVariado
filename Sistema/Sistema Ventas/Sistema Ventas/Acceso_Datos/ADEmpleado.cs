using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADEmpleado
    {
        public static SqlConnection cn = new SqlConnection(Conexion.Cadena);
        public static Empleado Entidad(IDataReader lector_entidad)
        {
            //creamos un objeto de la clase Cliente para obtener todas sus propiedades
            var entidad = new Empleado();
            entidad.IdEmpleado = Convert.ToInt32(lector_entidad["IdEmpleado"]);
            entidad.dni = Convert.ToString(lector_entidad["dni"]);
            entidad.Nombres = Convert.ToString(lector_entidad["Nombres"]);
            entidad.Apellidos = Convert.ToString(lector_entidad["Apellidos"]);
            entidad.Fec_nacimiento = Convert.ToDateTime(lector_entidad["Fec_nacimiento"]);
            entidad.Estado_civil = Convert.ToString(lector_entidad["Estado_civil"]);
            entidad.Celular = Convert.ToString(lector_entidad["Celular"]);
            entidad.Correo_electronico = Convert.ToString(lector_entidad["Correo_electronico"]);
            entidad.Direccion = Convert.ToString(lector_entidad["Direccion"]);
            entidad.IdDistrito = Convert.ToInt32(lector_entidad["IdDistrito"]);
            return entidad;
        }
        public static List<Empleado> ListaEntidades(Empleado e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Empleado>();
                //Consulta sql
                var consulta = "Select [IdEmpleado],[DNI],[Nombres],[Apellidos],[Fec_nacimiento],[Estado_civil],[Celular],[Correo_electronico],[Direccion],[IdDistrito] from Empleados where Nombres like @nom + '%' and Apellidos like @ape +'%' and  DNI like @dni+'%'";
                //Ejecuta a consulta y lo almacena en la variable cmd
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cmd.Parameters.AddWithValue("@nom", e.Nombres);
                cmd.Parameters.AddWithValue("@ape", e.Apellidos);
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
        public static bool Agregar(Empleado e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Empleados values(@dni,@nom,@ape,@fecnam,@estciv,@cel,@corelec,@dir,@iddis)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cmd.Parameters.AddWithValue("@nom", e.Nombres);
                cmd.Parameters.AddWithValue("@ape", e.Apellidos);
                cmd.Parameters.AddWithValue("@fecnam", e.Fec_nacimiento);
                cmd.Parameters.AddWithValue("@estciv", e.Estado_civil);
                cmd.Parameters.AddWithValue("@cel",e.Celular );
                cmd.Parameters.AddWithValue("@corelec", e.Correo_electronico);
                cmd.Parameters.AddWithValue("@dir", e.Direccion);
                cmd.Parameters.AddWithValue("@iddis", e.IdDistrito);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Empleado e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "update Empleados set DNI=@dni,Nombres =@nom,Apellidos=@ape,Fec_nacimiento=@fecnam,Estado_civil=@estciv,Celular=@cel,Correo_electronico=@corelec,Direccion=@dir,IdDistrito=@iddis where IdEmpleado=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cmd.Parameters.AddWithValue("@nom", e.Nombres);
                cmd.Parameters.AddWithValue("@ape", e.Apellidos);
                cmd.Parameters.AddWithValue("@fecnam", e.Fec_nacimiento);
                cmd.Parameters.AddWithValue("@estciv", e.Estado_civil);
                cmd.Parameters.AddWithValue("@cel", e.Celular);
                cmd.Parameters.AddWithValue("@corelec", e.Correo_electronico);
                cmd.Parameters.AddWithValue("@dir", e.Direccion);
                cmd.Parameters.AddWithValue("@iddis", e.IdDistrito);
                cmd.Parameters.AddWithValue("@id", e.IdEmpleado);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        //public static bool DarBaja(Empleado e)
        //{
        //    var cn = new SqlConnection(Conexion.Cadena);
        //    using (cn)
        //    {
        //        var consulta = "update Empleados set estado=@est where IdEmpleado=@id";
        //        var cmd = new SqlCommand(consulta, cn);
        //        cmd.Parameters.AddWithValue("@dni", e.dni);
        //        cmd.Parameters.AddWithValue("@nom", e.Nombres);
        //        cmd.Parameters.AddWithValue("@ape", e.Apellidos);
        //        cmd.Parameters.AddWithValue("@fecnam", e.Fec_nacimiento);
        //        cmd.Parameters.AddWithValue("@estciv", e.Estado_civil);
        //        cmd.Parameters.AddWithValue("@cel", e.Celular);
        //        cmd.Parameters.AddWithValue("@corelec", e.Correo_electronico);
        //        cmd.Parameters.AddWithValue("@dir", e.Direccion);
        //        cmd.Parameters.AddWithValue("@iddis", e.IdDistrito);
        //        cmd.Parameters.AddWithValue("@id", e.IdEmpleado);
        //        cn.Open();
        //        return Convert.ToBoolean(cmd.ExecuteNonQuery());
        //    }
        //}
        public static bool Existe(Empleado e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdEmpleado),0) from Empleados where IdEmpleado=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdEmpleado);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
        public static bool ExisteNombres(Empleado e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdEmpleado),0) from Empleados where Nombres=@nom and Apellidos=@ape";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", e.Nombres);
                cmd.Parameters.AddWithValue("@ape", e.Apellidos);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
        public static bool ExisteDNI(Empleado e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdEmpleado),0) from Empleados where DNI=@dni";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }

        public DataTable SimuladorComision(Empleado e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                //var lista = new List<Venta>();
                DataTable ranking = new DataTable("Ventas");
                var cmd = new SqlCommand("spS_SimuladorComision", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("dni", e.dni);
                cn.Open();
                SqlDataAdapter lista = new SqlDataAdapter(cmd);
                lista.Fill(ranking);
                return ranking;
                //var dr = cmd.ExecuteReader();
                //while (dr.Read())
                //{
                //    lista.Add(RankingVendedores(dr,e));
                //}

            }
        }
       
    }
}
