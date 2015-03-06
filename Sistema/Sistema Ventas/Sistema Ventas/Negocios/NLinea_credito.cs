using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NLinea_credito
    {
        public static string AprobarCredito(LineaCredito e)
        {
            return ADLineaCredito.AprobarCredito_Labor(e);
        }
        public static bool Guardar(LineaCredito e)
        {
            
            if (ADLineaCredito.Existe(e))
            {
                return ADLineaCredito.Actualizar(e);
            }
            else
            {
                return ADLineaCredito.Agregar(e);
            }
            
        }
        public static float ObtenerCME(LineaCredito e)
        {
            return ADLineaCredito.CalcularCME(e);
        }
        public static List<LineaCredito> ListaEntidades(LineaCredito e,DateTime fec_ini,DateTime fec_fin)
        {
            return ADLineaCredito.ListaEntidades(e,fec_ini,fec_fin);
        }
        public static List<LineaCredito> ListadoFiltroLinCredito(LineaCredito e)
        {
            return ADLineaCredito.ListadoFiltroLinCredito(e);
        }
        public static int FiltrarLinCredito(LineaCredito e)
        {
            return ADLineaCredito.FiltrarLinCredito(e);
        }
        public static float FiltrarCME(LineaCredito e)
        {
            return ADLineaCredito.ObtenerCME(e);
        }
        public static bool ModificarCMEDisponible(LineaCredito e)
        {
            return ADLineaCredito.ModfificarCMEDisponible(e);
        }
    }
}
