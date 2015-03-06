using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class ADListarVenta_parte1
    {
        public static ListarVenta_parte1 Entidad(IDataReader lector_entidad)
        {
            var entidad = new ListarVenta_parte1();
            entidad.dni = Convert.ToString(lector_entidad["DNI"]);
            entidad.IdCliente = Convert.ToInt32(lector_entidad["IdCliente"]);
            entidad.Cliente = Convert.ToString(lector_entidad["Cliente"]);
            entidad.Direccion = Convert.ToString(lector_entidad["Direccion"]);
            entidad.CodVendedor = Convert.ToString(lector_entidad["Cod. Vendedor"]);
            entidad.Vendedor = Convert.ToString(lector_entidad["Vendedor"]);
            entidad.Tipo_venta = Convert.ToString(lector_entidad["Tipo_venta"]);
            entidad.Pago_a_cuenta = Convert.ToSingle(lector_entidad["Pago_a_cuenta"]);
            entidad.Total = Convert.ToSingle(lector_entidad["Total"]); 
            return entidad;
        }
        public static List<ListarVenta_parte1> ListaEntidades(Venta e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<ListarVenta_parte1>();
                var consulta = "spS_ListarVenta_parte1";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nro_preven", e.Nro_venta);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad(dr));
                }
                return lista;
            }
        }
        public static int ObtenerIDVenta(Venta e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var consulta = "select idventa from Ventas where Nro_venta=@nro_preven  ";
                var cmd = new SqlCommand(consulta, cn);
                cn.Open();cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nro_preven", e.Nro_venta);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public static ListarVenta_parte2 Entidad2(IDataReader lector_entidad)
        {
            var entidad = new ListarVenta_parte2();
            entidad.Marca= Convert.ToString(lector_entidad["Marca"]);
            entidad.Modelo= Convert.ToString(lector_entidad["Modelo"]);
            entidad.Precio = Convert.ToSingle(lector_entidad["Precio"]);
            entidad.Cantidad = Convert.ToInt32(lector_entidad["Cantidad"]);
            entidad.Descuento= Convert.ToSingle(lector_entidad["Descuento"]);
            entidad.IGV = Convert.ToSingle(lector_entidad["IGV"]);
            entidad.ValorVenta= Convert.ToSingle(lector_entidad["Valor_venta"]);

            return entidad;
        }
        public static List<ListarVenta_parte2> ListaEntidades2(Venta e)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            using (cn)
            {
                var lista = new List<ListarVenta_parte2>();
                var consulta = "spS_ListarVenta_parte2";
                var cmd = new SqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", e.IdVenta);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Entidad2(dr));
                }
                return lista;
            }
        }

    }
}
