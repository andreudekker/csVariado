using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class NVivienda
    {
        public static bool Guardar(Vivienda e)
        {
            if (ADVivienda.Existe(e))
            {
                return ADVivienda.Actualizar(e);
            }
            else
            {
                return ADVivienda.Agregar(e);
            }
        }
        public static List<Vivienda> ListaEntidades(Vivienda e)
        {
            return ADVivienda.ListaEntidades(e);
        }
        public static int ObtenerUltimoID()
        {
            return ADVivienda.ObtenerUltimoID();
        }
    }
}
