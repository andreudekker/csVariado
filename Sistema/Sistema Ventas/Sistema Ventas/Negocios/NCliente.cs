using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NCliente
    {
        public static bool Guardar(Cliente e)
        {
            if (ADCliente.Existe(e))
            {
                return ADCliente.Actualizar(e);
            }
            else
            {
                return ADCliente.Agregar(e);
            }
        }
        public static List<Cliente> ListaEntidades(Cliente e)
        {
            return ADCliente.ListaEntidades(e);
        }
        public static int ObtenerId(string dni)
        {
            return ADCliente.ObtenerId(dni);
        }
        public static List<Cliente> ObtenerNombres(Cliente e)
        {
            return ADCliente.ObtenerNombrecompleto(e);
        }
        public static bool ExisteDNI(Cliente e)
        {
            return ADCliente.ExisteDNI(e);
        }
        public static bool ExisteNombres(Cliente e)
        {
            return ADCliente.ExisteNombres(e);
        }
        public static bool ExisteContrato(int id)
        {
            return ADCliente.ExisteContrato(id);
        }
        public static bool ExisteLinea(int id)
        {
            return ADCliente.ExisteLinea(id);
        }
    }
}
