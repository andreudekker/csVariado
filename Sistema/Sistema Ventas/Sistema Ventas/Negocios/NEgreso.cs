using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NEgreso
    {
        public static bool Guardar(Egresos e)
        {
            return ADEgresos.Agregar(e);
            
        }
        public static List<Egresos> ListaEntidades(Egresos e,DateTime fec_ini,DateTime fec_fin)
        {
            return ADEgresos.ListaEntidades(e,fec_ini,fec_fin);
        }
        public static List<Egresos> CierreCaja2()
        {
            return ADEgresos.CierreCaja2();
        }
    }
}
