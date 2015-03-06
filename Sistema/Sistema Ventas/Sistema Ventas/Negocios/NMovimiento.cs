using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NMovimiento
    {
        public static bool Guardar(Movimiento e)
        {
            if (ADMovimiento.Existe(e))
            {
                return ADMovimiento.Actualizar(e);
            }
            else
            {
                return ADMovimiento.Agregar(e);
            }
        }
        public static List<Movimiento> ListaEntidades(Movimiento e,DateTime fec_ini,DateTime fec_fin)
        {
            return ADMovimiento.ListaEntidades(e,fec_ini,fec_fin);
        }
    }
}
