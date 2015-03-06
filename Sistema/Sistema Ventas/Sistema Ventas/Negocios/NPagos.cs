using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NPagos
    {
        
        public static bool Guardar(Pago e)
        {
            var p = new Prestamo();
            var plazo = ADPrestamo.ObtenerPlazo(p);
            
            if (ADPagos.Existe(e))
            {
                return ADPagos.Actualizar(e);
            }else
	        {
                return ADPagos.Agregar(e);
	        }
        }
        public static List<Pago> ListEntidades(Pago e)
        {
            return ADPagos.ListaEntidades(e);
        }
        public static bool ModficarPagos(Pago e)
        {
            return ADPagos.ModificarPagos(e);
        }
    }
}
