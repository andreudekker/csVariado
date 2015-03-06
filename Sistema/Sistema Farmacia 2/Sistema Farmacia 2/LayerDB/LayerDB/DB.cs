using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace LayerDB
{
   public class DB
    {
        public SqlDataReader sqlDR;
        public string strConexion;
        public SqlCommand sql;

        private CadenaDB cadenaConexion;

        public DB()
        {
            cadenaConexion = new CadenaDB();
            strConexion = cadenaConexion.CadenaConexion();
        }

        public void Ejecutar_SQL(string query)
        {
            using (SqlConnection sqlConexion = new SqlConnection(strConexion))
            {
                sqlConexion.Open();
                sql = new SqlCommand(query, sqlConexion);
                sql.ExecuteNonQuery();
            }
        }

        public ArrayList Listar_SQL(string query)
        {
            ArrayList lista = new ArrayList();
            using (SqlConnection sqlConexion = new SqlConnection(strConexion))
            {
                sqlConexion.Open();
                int numColumnas;
                sql = new SqlCommand(query, sqlConexion);
                sqlDR = sql.ExecuteReader();
                if (sqlDR.HasRows)
                {
                    while (sqlDR.Read())
                    {
                        numColumnas = sqlDR.FieldCount;
                        for (int i = 0; i < numColumnas; i++)
                            lista.Add(sqlDR[i].ToString());
                    }
                    return lista;
                }
            }
            return lista;
        }

        public DataTable SelectRows(DataTable datatable, string query)
        { 
            using (SqlConnection sqlConexion = new SqlConnection(strConexion))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, sqlConexion);
                adapter.Fill(datatable);
                return datatable;
            }
        }
    }
}
