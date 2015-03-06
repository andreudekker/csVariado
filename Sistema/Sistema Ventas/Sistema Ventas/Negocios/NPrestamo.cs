using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NPrestamo
    {
        public static bool Guardar(Prestamo e)
        {
            if (ADPrestamo.Existe(e))
            {
                return ADPrestamo.Actualizar(e);
            }
            else
            {
                return ADPrestamo.Agregar(e);
            }
        }
        public static List<Prestamo> ListaEntidades(Prestamo e, DateTime fec_ini, DateTime fec_fin)
        {
            return ADPrestamo.ListaEntidades(e, fec_ini, fec_fin);
        }
        public static int ObtenerPlazo(Prestamo e)
        {
            return ADPrestamo.ObtenerPlazo(e);

        }
        public static float ObtenerTEM(Prestamo e)
        {
            return ADPrestamo.ObtenerTEM(e);
        }
        public static int ObtenerIdPrestamo(string dni)
        {
            return ADPrestamo.ObtenerIdPrestamo(dni);
        }
        public static List<Prestamo> ListarPrestamos(string dni)
        {
            return ADPrestamo.ListaPrestamos(dni);
        }
        public static bool ModificarEstadoPrestamo(Prestamo e)
        {
            return ADPrestamo.ModificarEstadoPrestamo(e);
        }
        public static int FiltrarIdVenta(int idpres)
        {
            return ADPrestamo.FlitarIdVenta(idpres);
        }
        
        
    }
}
