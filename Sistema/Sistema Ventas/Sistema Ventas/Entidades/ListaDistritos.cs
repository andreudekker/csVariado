using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ListaDistritos
    {
        public int IdDistrito { get; set; }
        public string NombreDistrito { get; set; }
        public string NombreProvincia { get; set; }
        public string NombreDepartamento { get; set; }
        public int IdProvincia { get; set; }
        public int IdDepartamento { get; set; }
    }
}
