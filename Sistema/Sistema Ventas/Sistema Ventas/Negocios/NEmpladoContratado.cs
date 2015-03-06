using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;
namespace Negocios
{
    public class NEmpladoContratado
    {
        public static List<EmpleadoContratado> ListaEntidades(EmpleadoContratado e)
        {
            return ADEmpleadoContratado.ListaEntidades(e);
        }
        public static List<EmpleadoContratado> ListaVendedores()
        {
            return ADEmpleadoContratado.ListaVendedores();
        }
        public static List<EmpleadoContratado> ListaAlmaceneros()
        {
            return ADEmpleadoContratado.ListaAlmaceneros();
        }
    }
}
