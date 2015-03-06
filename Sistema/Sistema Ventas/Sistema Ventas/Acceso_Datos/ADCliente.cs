using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADCliente
    {
        //public static SqlConnection cn =new SqlConnection(Conexion.Cadena);
        public static Cliente Entidad(IDataReader lector_entidad)
        {
            //creamos un objeto de la clase Cliente para obtener todas sus propiedades
            var entidad = new Cliente();
            //las convertimos a su tipo de datos correspondiente
            entidad.IdCliente=Convert.ToInt32(lector_entidad["IdCliente"]) ;
            entidad.dni = Convert.ToString(lector_entidad["dni"]);
            entidad.Tipo_persona = Convert.ToString(lector_entidad["Tipo_persona"]);
            entidad.Nombres = Convert.ToString(lector_entidad["Nombres"]);
            entidad.Apellidos = Convert.ToString(lector_entidad["Apellidos"]);
            entidad.Razon_social = Convert.ToString(lector_entidad["Razon_social"]);
            entidad.ruc = Convert.ToString(lector_entidad["ruc"]);
            entidad.Fec_nacimiento = Convert.ToDateTime(lector_entidad["Fec_nacimiento"]);
            entidad.Estado_civil = Convert.ToString(lector_entidad["Estado_civil"]);
            entidad.Direccion = Convert.ToString(lector_entidad["Direccion"]);
            entidad.IdDistrito = Convert.ToInt32(lector_entidad["IdDistrito"]);
            return entidad;
        }
        public static List<Cliente> ListaEntidades(Cliente e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista=new List<Cliente>();
                //Consulta sql
                var consulta = "Select [IdCliente],[DNI],[Tipo_persona],[Nombres],[Apellidos],[Razon_social],[RUC],[Fec_nacimiento],[Estado_civil],[Direccion],[IdDistrito] from Clientes where Nombres like @nom + '%' and Apellidos like @ape +'%' and  DNI like @dni + '%'";
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
        public static bool Agregar(Cliente e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "insert into Clientes values(@dni,@tip,@nom,@ape,@raz,@ruc,@fecnam,@estciv,@dir,@iddis)";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cmd.Parameters.AddWithValue("@tip", e.Tipo_persona);
                cmd.Parameters.AddWithValue("@nom", e.Nombres);
                cmd.Parameters.AddWithValue("@ape", e.Apellidos);
                cmd.Parameters.AddWithValue("@raz", e.Razon_social);
                cmd.Parameters.AddWithValue("@ruc", e.ruc);
                cmd.Parameters.AddWithValue("@fecnam", e.Fec_nacimiento);
                cmd.Parameters.AddWithValue("@estciv", e.Estado_civil);
                cmd.Parameters.AddWithValue("@dir", e.Direccion);
                cmd.Parameters.AddWithValue("@iddis", e.IdDistrito);
                
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }
        public static bool Actualizar(Cliente e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using(cn)
	        {
		        var consulta="update Clientes set DNI=@dni,Tipo_persona=@tip,Nombres=@nom,Apellidos=@ape,Razon_social=@raz,RUC=@ruc,Fec_nacimiento=@fecnam,Estado_civil=@estciv,Direccion=@dir,IdDistrito=@iddis where IdCliente=@id";
                var cmd=new SqlCommand(consulta,cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cmd.Parameters.AddWithValue("@tip", e.Tipo_persona);
                cmd.Parameters.AddWithValue("@nom", e.Nombres);
                cmd.Parameters.AddWithValue("@ape", e.Apellidos);
                cmd.Parameters.AddWithValue("@raz", e.Razon_social);
                cmd.Parameters.AddWithValue("@ruc", e.ruc);
                cmd.Parameters.AddWithValue("@fecnam", e.Fec_nacimiento);
                cmd.Parameters.AddWithValue("@estciv", e.Estado_civil);
                cmd.Parameters.AddWithValue("@dir", e.Direccion);
                cmd.Parameters.AddWithValue("@iddis", e.IdDistrito);
                cmd.Parameters.AddWithValue("@id", e.IdCliente);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
	        }
        }
        public static bool Existe(Cliente e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using(cn)
	        {
                var consulta = "select isnull(count(IdCliente),0) from Clientes where IdCliente=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("id", e.IdCliente);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
	        }
            
        }
        //public static DataTable EstadoCuenta(Cliente e)
        //{
        //    using (cn)
        //    {
        //        DataTable estadocuenta = new DataTable("Ventas");
        //        var cmd = new SqlCommand("spS_EstadoCuenta", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@dni", e.dni);
        //        cn.Open();
        //        var lista = new SqlDataAdapter(cmd);
        //        lista.Fill(estadocuenta);
        //        return estadocuenta;
        //    }
        //}
        public static Cliente NombreCompleto(IDataReader lector)
        {
            var e = new Cliente();
            e.Nombres = Convert.ToString(lector["Nombres"]);
            e.Apellidos = Convert.ToString(lector["Apellidos"]);
            return e;
        }
        public static List<Cliente> ObtenerNombrecompleto(Cliente e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<Cliente>();
                var cmd = new SqlCommand("Select Nombres +' '+Apellidos from Clientes where DNI=@dni",cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(NombreCompleto(dr));
                }
                return lista;
            }
        }
        public static int ObtenerId(string dni)
        { 
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var cmd = new SqlCommand("select ISNULL(MAX( IdCliente),0)  from Clientes where DNI like @dni",cn);
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public static bool ExisteNombres(Cliente e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdCliente),0) from Clientes where Nombres=@nom and Apellidos=@ape";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nom", e.Nombres);
                cmd.Parameters.AddWithValue("@ape", e.Apellidos);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
        public static bool ExisteDNI(Cliente e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select isnull(count(IdCliente),0) from Clientes where DNI=@dni";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@dni", e.dni);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
        public static bool ExisteContrato(int id)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = @"select isnull(count(IdContrato),0) 
                                FROM         dbo.Contrato INNER JOIN
                                dbo.Empleados ON dbo.Contrato.IdEmpleado = dbo.Empleados.IdEmpleado
                                where empleados.idempleado=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
        public static bool ExisteLinea(int id)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = @"SELECT    isnull( dbo.LineaCredito.IdLinea_credito,0)
                                FROM         dbo.LineaCredito INNER JOIN
                                dbo.Clientes ON dbo.LineaCredito.IdCliente = dbo.Clientes.IdCliente
                                where clientes.idcliente=@id";
                var cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }

        
    }
}
