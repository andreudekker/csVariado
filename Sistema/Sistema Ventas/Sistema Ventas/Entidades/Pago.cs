using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Pago
    {
         public int IdPago {get;set;}
         public int IdPrestamo { get; set; } 
         public int Nro {get;set;}
         public DateTime Fec_vencimiento{get;set;}
         public float Capital{get;set;}
         public float Interes{get;set;}
         public float Cuota{get;set;}
         public float Desgravamen{get;set;}
         public float itf {get;set;}
         public float Total{get;set;}
         public float Debe {get;set;}
         public string Fec_pago{get;set;}
         
    }
}
