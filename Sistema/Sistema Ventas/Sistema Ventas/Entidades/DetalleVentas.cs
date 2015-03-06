using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleVentas
    {
        public int IdVenta{ get; set; }
        public int IdProducto { get; set; }
        public int Cantidad{ get; set; }
        public string NroSerie{ get; set; }
        public float Venta_bruta { get; set; }
        public float Descuento { get; set; }
        public float Valor_venta { get; set; }
        public float igv { get; set; }
        public float Comision { get; set; }
        
        
    }
}
