using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NContrato
    {
        public static bool Guardar(Contrato e)
        {
            if (ADContrato.Existe(e))
            {
                return ADContrato.Actualizar(e);
            }
            else
            {
                return ADContrato.Agregar(e);
            }
        }
        public static List<Contrato> ListaEntidades(Contrato e)
        {
            return ADContrato.ListaEntidades(e);
        }
        public static int Ingreso(Contrato e)
        {
            return ADContrato.Login(e);
        }
        public static string TipoIngreso(Contrato e)
        {
            return ADContrato.TipoIngreso(e);
        }
        public static int IdEmpleadoIngreso(Contrato e)
        {
            return ADContrato.IdEmpleadoIngreso(e);
        }
        public static string EmpleadoIngreso(Contrato e)
        {
            return ADContrato.EmpleadoIngreso(e);
        }
    }
}
