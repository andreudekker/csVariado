using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class NEstadoCuenta
    {
        public static List<ListarEstadoCuenta1> ListaEntidades(string dni)
        {
            return ADListarEsadoCuenta.ListaEntidades(dni);
        }
        public static List<ListarEstadoCuenta2> ListaEntidades2(int id)
        {
            return ADListarEsadoCuenta.ListaEntidades2(id);
        }
        public static List<ListarEstadoCuenta2> ListaEntidades3(int id)
        {
            return ADListarEsadoCuenta.ListaEntidades3(id);
        }
    }
}
