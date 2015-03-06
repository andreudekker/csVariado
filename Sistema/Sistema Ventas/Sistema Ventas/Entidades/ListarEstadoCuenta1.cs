using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ListarEstadoCuenta1
    {
        public string Cliente { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public float cme { get; set; }
        public float cmedisponible { get; set; }
        public string Vendedor { get; set; }
        public string DNI_vendedor { get; set; }
        public DateTime Fecha { get; set; }
        public int NroCuotas { get; set; }
    }
}
