using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NEmpleado
    {
        public static bool Guardar(Empleado e)
        {
            if (ADEmpleado.Existe(e))
            {
                return ADEmpleado.Actualizar(e);
            }
            //else if (ADEmpleado.ExisteDNI(e))
            //{
            //    return ADEmpleado.ExisteDNI(e);
            //}
            //else if (ADEmpleado.ExisteNombres(e))
            //{
            //    return ADEmpleado.ExisteNombres(e);
            //}
            else
            {
                return ADEmpleado.Agregar(e);
            }
        }
        public static List<Empleado> ListaEntidades(Empleado e)
        {
            return ADEmpleado.ListaEntidades(e);
        }
        public static bool ExisteDNI(Empleado e)
        {
            return ADEmpleado.ExisteDNI(e);
        }
        public static bool ExisteNombres(Empleado e)
        {
            return ADEmpleado.ExisteNombres(e);
        }
    }
}
