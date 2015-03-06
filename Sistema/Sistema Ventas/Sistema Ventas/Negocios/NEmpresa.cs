using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NEmpresa
    {
        public static bool Guardar(Empresa e)
        {
              return ADEmpresa.Agregar(e);
            
        }
        public static List<Empresa> ListaEntidades(Empresa e)
        {
            return ADEmpresa.ListaEntidades(e);
        }
        public static int Existe()
        {
            return ADEmpresa.Existe();
        }
    }
}
