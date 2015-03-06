using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Prestamo
    {
        public int IdPrestamo{get;set;}
        public int IdLineaCredito { get; set; }
        public int IdVenta { get; set; }
        public float Capital_prestado{get;set;}
        public DateTime Fec_desembolso{get;set;}
        public int Plazo_nrouotas{get;set;}
        public float tea{get;set;}
        public float tem{get;set;}
        public string Estado { get; set; }
    }
}
