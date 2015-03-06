using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ListarEstadoCuenta2
    {
        public int IdPago { get; set; }
        public int IdPrestamo { get; set; }
        public int Nro{ get; set; }
        public DateTime Fec_vencimiento{ get; set; }
        public float Total { get; set; }
        public float Debe { get; set; }
        public string Fec_Pago { get; set; }
    }
}
