using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetalleMovimiento
    {
        public int IdMovimiento { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public string NroSerie { get; set; }
    }
}
