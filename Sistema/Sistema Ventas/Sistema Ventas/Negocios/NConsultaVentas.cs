using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NConsultaVentas
    {
        public static List<ConsultasVentas> RankingVendedores(DateTime fec_ini,DateTime fec_fin)
        {
            return ADConsultasVentas.RankingVendedores(fec_ini,fec_fin);
        }
        public static List<ConsultasVentas> RankingVendedores(string tipo, DateTime fec)
        {
            return ADConsultasVentas.VentaDiaria(tipo, fec);
        }
        public static List<ConsultasVentas> SimuladorComisiones(string DNI)
        {
            return ADConsultasVentas.SimuladorComisiones1(DNI);
        }
        public static List<ConsultasVentas> SimuladorComisiones2(string DNI)
        {
            return ADConsultasVentas.SimuladorComisiones2(DNI);
        }
    }
}
