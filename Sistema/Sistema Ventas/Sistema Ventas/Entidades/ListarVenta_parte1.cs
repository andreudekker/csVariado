using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ListarVenta_parte1
    {
        public string dni { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CodVendedor{ get; set; }
        public string Vendedor { get; set; }
        public string Tipo_venta { get; set; }

        public float Pago_a_cuenta { get; set; }
        public float Total { get; set; }
    }
}
