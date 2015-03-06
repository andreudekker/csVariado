using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Caja
    {
        public int IdCaja{get;set;}
        public int IdVenta { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha{get;set;}
        public float Monto {get;set;}
        public string Motivo {get;set;}
        public float TotalVenta { get; set; }
    }
}
