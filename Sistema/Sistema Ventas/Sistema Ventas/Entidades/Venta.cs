using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Venta
    {
         public int IdVenta{get;set;}
         public int IdCliente { get; set; }
         public int IdEmpleado { get; set; }
         public int IdEmpresa { get; set; }
         public string Tipo_venta {get;set;}
         public DateTime Fecha {get;set;}
         public int Nro_venta {get;set;}
         public string Estado { get; set; }
         public float Pago_a_cuenta { get; set; }
         public float Total { get; set; }
         public List<DetalleVentas> ListaDetalle { get; set; }
         
    }
}
