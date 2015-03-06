using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Movimiento
    {
        public int IdMovimiento{ get; set; }
        public int IdEmpleado { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }

        public List<DetalleMovimiento> ListaMovimiento { get; set; }
    }
}
