using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ConsultasVentas
    {
        public string dni { get; set; }
        public string Vendedor{ get; set; }
        public float ValorVentas{ get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo_venta { get; set; }
        public int cantidad { get; set; }
        public float Ultima_Venta { get; set; }
        public float TotalComision { get; set; }
        public float Proyeccion { get; set; }
        public float DescuentoAcumulado { get; set; }
    }
}
