using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NVenta
    {
        public static bool Guardar(Venta e)
        {
            if (ADVenta.Existe(e))
            {
                return ADVenta.Actualizar(e);
            }
            else
            {
                return ADVenta.Agregar(e);
            }
        }
        public static List<Venta> ListaEntidades(Venta e,DateTime fec_ini,DateTime fec_fin)
        {
            return ADVenta.ListaEntidades(e,fec_ini,fec_fin);
        }
        public static string ObtenerNro()
        {
            return ADVenta.ObtenerNro();
        }
        public static float TotalVenta(DateTime fec_ini,DateTime fec_fin)
        {
            return ADVenta.TotalVenta(fec_ini,fec_fin);
        }
        public static int ObtenerUltimoID()
        {
            return ADVenta.ObtenerUltimoID();
        }
        public static float ObtenerCapital(Venta e)
        {
            return ADVenta.ObtenerCapital(e);
        }
        public static bool Cobrar(Venta e)
        {
            return ADVenta.Cobrar(e);
        }
        public static int ObtenerIDPrestamo(Venta e)
        {
            return ADVenta.ObtenerIDPrestamo(e);
        }
    }
}
