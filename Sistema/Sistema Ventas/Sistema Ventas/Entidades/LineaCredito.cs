using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class LineaCredito
    {
        public int IdLinea_credito{get;set;}
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public int NroHijos { get; set; }
        public int TiempoResidencia { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string TipoVivienda { get; set; }
        public string FormaVida { get; set; }
        public string CentroTrabajo { get; set; }
        public string Profesion { get; set; }
        public int TiempoTrabajo { get; set; }
        public string TipoTrabajo { get; set; }
        public string DireccionTrabajo { get; set; }
        public string Urbanizacion { get; set; }
        public float Ingresos { get; set; }
        public string TelefonoTrabajo { get; set; }
        public float cme{ get; set; }
        public float cmedisponible { get; set; }
        public string DistritoTrabajo { get; set; }
        public string Estado { get; set; }
        public int IdVivienda { get; set; }
        public int IdVehiculo { get; set; }
        public int IdAval { get; set; }
        //public List<AprobacionLinea_Detalle> ListaDetalle { get; set; }
    }
}
