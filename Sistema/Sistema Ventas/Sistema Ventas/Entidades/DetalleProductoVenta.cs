using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleProductoVenta
    {
        public int IdProducto { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public float Descuento { get; set; }
        public float IGV { get; set; }
        public float ValorVenta { get; set; }
        public int stock { get; set; }
    }
}
