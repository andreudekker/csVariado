using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Acceso_Datos;

namespace Negocios
{
    public class NVehiculo
    {
        public static bool Guardar(Vehiculo e)
        {
            if (ADVehiculo.Existe(e))
            {
                return ADVehiculo.Actualizar(e);
            }
            else
            {
                return ADVehiculo.Agregar(e);
            }
        }
        public static List<Vehiculo> ListaEntidades(Vehiculo e)
        {
            return ADVehiculo.ListaEntidades(e);
        }
        public static int ObtenerUltimoID()
        {
            return ADVehiculo.ObtenerUltimoID();
        }
    }
}
