using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Acceso_Datos;
namespace Negocios
{
    public class NProvincia
    {
        public static bool Guardar(Provincia e)
        {
            return ADProvincia.Agregar(e);
            
        }
        public static List<Provincia> ListaEntidades(Provincia e)
        {
            return ADProvincia.ListaEntidades(e);
        }
        public static List<Provincia> ListarProv(Provincia e)
        {
            return ADProvincia.ListarProv(e);
        }

    }
}
