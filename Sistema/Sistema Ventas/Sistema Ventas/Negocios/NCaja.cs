using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NCaja
    {
        public static bool Guardar(Caja e)
        {
            return ADCaja.Agregar(e);

        }
        public static List<Caja> ListaEntidades(Caja e, DateTime fec_ini, DateTime fec_fin)
        {
            return ADCaja.ListaEntidades(e, fec_ini, fec_fin);
        }
        public static List<Caja> CierreCaja()
        {
            return ADCaja.CierreCaja();
        }
    }
}
