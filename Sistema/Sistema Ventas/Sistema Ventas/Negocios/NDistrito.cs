using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NDistrito
    {
        public static bool Guardar(Distrito e)
        {
            if (ADDistrito.Existe(e))
            {
                return ADDistrito.Actualizar(e);
            }
            else
            {
                return ADDistrito.Agregar(e);
            }
        }
        public static List<Distrito> ListaEntidades(Distrito e)
        {
            return ADDistrito.ListaEntidades(e);
        }
        public static List<Distrito> ListarDist(Distrito e)
        {
            return ADDistrito.ListarDist(e);
        }
    }
}
