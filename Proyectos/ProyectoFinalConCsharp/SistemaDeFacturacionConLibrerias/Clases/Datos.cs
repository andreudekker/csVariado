using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;

namespace SistemaDeFacturacionConLibrerias.Clases
{
	class Datos
	{
		private  static string mensaje;
		private static ConexionBD conexion = new ConexionBD("Parametros.xml");
		
		public static string Mensaje { get { return mensaje; } }
		
		public static bool ValidarUsuario(string usuario, string clave)
		
		{
			if (conexion.AbrirConexion())
			{
				mensaje = conexion.Error;
				conexion.CerrarConexion();
				return false;
			}
			conexion.SQL = "SELECT (1) FROM Usuario WHERE Usuario = '" + usuario + "' AND Clave = '" + clave + "'";
			if (conexion.ConsultarValorUnico(false))
			{
				mensaje = conexion.Error;
				conexion.CerrarConexion();
				return false;
			}    

			if (conexion.ValorUnico==null)
			{
				 mensaje="Usuario Contraseña no valido";
				 conexion.CerrarConexion();
				return false;
			}

			conexion.CerrarConexion();
			return true;
		
		}
		
	
	
	 
	}
}
