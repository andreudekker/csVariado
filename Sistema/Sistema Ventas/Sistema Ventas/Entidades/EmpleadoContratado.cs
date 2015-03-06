using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EmpleadoContratado
    {
        public int IdContrato { get; set; }
        public int IdEmpleado { get; set; }
        public string dni { get; set; }
        public string Empleado { get; set; }
        public DateTime Fec_ini { get; set; }
        public DateTime Fec_fin { get; set; }
        public string Nick { get; set; }
        public string Clave { get; set; }
        public string Cargo { get; set; }
        public string Turno { get; set; }
        public string Estado { get; set; }
    }
}
