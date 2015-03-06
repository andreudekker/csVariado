using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class NListarVenta
    {
        public static List<ListarVenta_parte1> ListaEntidades(Venta e)
        {
            return ADListarVenta_parte1.ListaEntidades(e);
        }
        public static List<ListarVenta_parte2> ListaEntidades2(Venta e)
        {
            return ADListarVenta_parte1.ListaEntidades2(e);
        }
        public static int ObtenerIDVenta(Venta e)
        {
            return ADListarVenta_parte1.ObtenerIDVenta(e);
        }
    }
}
