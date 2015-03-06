using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionPruebaMVC_2.Models
{
    public class Productos
    {
        public int CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Notas { get; set; }
    }

    public class ProductosDBContext:
    {
    
    
    }
}