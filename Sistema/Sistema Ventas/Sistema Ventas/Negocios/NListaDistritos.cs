using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NListaDistritos
    {
        public static List<ListaDistritos> ListaEntidades(ListaDistritos e)
        {
            return ADListaDistrito.ListaEntidades(e);
        }
        public static int ObtenerId(string nom)
        {
            return ADListaDistrito.ObtenerId(nom);
        }
        public static int FiltrarIdDepartamento(int id)
        {
            return ADListaDistrito.FiltrarIdDepartamento(id);
        }
        public static int FiltrarIdProvincia(int id)
        {
            return ADListaDistrito.FiltrarIdProvincia(id);
        }
    }
}
