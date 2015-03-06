using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NDepartamento
    {
        //public static bool Guardar(Cliente e)
        //{
        //    if (ADCliente.Existe(e))
        //    {
        //        return ADCliente.Actualizar(e);
        //    }
        //    else
        //    {
        //        return ADCliente.Agregar(e);
        //    }
        //}
        public static List<Departamento> ListaEntidades(Departamento e)
        {
            return ADDepartamento.ListaEntidades(e);
        }
        public static List<Departamento> ListarDept()
        {
            return ADDepartamento.ListarDpto();
        }
    }
}
