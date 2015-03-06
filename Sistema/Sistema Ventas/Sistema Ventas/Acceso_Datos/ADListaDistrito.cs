using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Acceso_Datos
{
    public class ADListaDistrito
    {
        public static ListaDistritos Entidad(IDataReader lector)
        {
            var e = new ListaDistritos();
            e.NombreDistrito = Convert.ToString(lector["NombreDistrito"]);
            e.NombreProvincia = Convert.ToString(lector["NombreProvincia"]);
            e.NombreDepartamento = Convert.ToString(lector["NombreDepartamento"]);
            return e;
        }
        public static ListaDistritos Entidad2(IDataReader lector)
        {
            var e = new ListaDistritos();
            e.IdDistrito = Convert.ToInt32(lector["IdDistrito"]);
            e.IdProvincia = Convert.ToInt32(lector["IdProvincia"]);
            e.IdDepartamento = Convert.ToInt32(lector["IdDepartamento"]);
            return e;
        }
        public static List<ListaDistritos> ListaEntidades(ListaDistritos e)
        {
            var lista = new List<ListaDistritos>();
            var cn = new SqlConnection(Conexion.Cadena);
            cn.Open();
            var cmd = new SqlCommand("spS_BuscarDistrito", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@nomdistri", SqlDbType.NVarChar,30));
            cmd.Parameters["@nomdistri"].Value = e.NombreDistrito;
            //cmd.Parameters.AddWithValue("@nomdistri", e.NombreDistrito);
            
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(Entidad(dr));
            }
            return lista;
            
        }
        public static int ObtenerId(string nom)
        {
            var cn = new SqlConnection(Conexion.Cadena);
            cn.Open();
            var cmd = new SqlCommand("Select IdDistrito from Distrito where NombreDistrito=@nom", cn);
            cmd.Parameters.AddWithValue("@nom", nom);
            return Convert.ToInt32( cmd.ExecuteScalar());
        }
        public static int FiltrarIdDepartamento(int id)
        {
            //var lista = new List<ListaDistritos>();
            var cn = new SqlConnection(Conexion.Cadena);
            cn.Open();
            var cmd = new SqlCommand("spS_FiltrarIdDepartamento", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);

            return Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static int FiltrarIdProvincia(int id)
        {
            //var lista = new List<ListaDistritos>();
            var cn = new SqlConnection(Conexion.Cadena);
            cn.Open();
            var cmd = new SqlCommand("spS_FiltrarIdProvincia", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            return Convert.ToInt32(cmd.ExecuteScalar());

        }
            
    }
}
