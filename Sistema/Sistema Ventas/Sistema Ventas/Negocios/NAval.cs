using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NAval
    {
        public static bool Guardar(Aval e)
        {
            if (ADAval.Existe(e))
            {
                return ADAval.Actualizar(e);
            }
            else
            {
                return ADAval.Agregar(e);
            }
        }
        public static List<Aval> ListaEntidades(Aval e)
        {
            return ADAval.ListaEntidades(e);
        }
        public static bool ExisteDNI(Aval e)
        {
            return ADAval.ExisteDNI(e);
        }
        public static bool ExisteNombres(Aval e)
        {
            return ADAval.ExisteNombres(e);
        }
        public static int ObtenerUltimoID()
        {
            return ADAval.ObtenerUltimoID();
        }
    }
}
