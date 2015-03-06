using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Uml_Empleado
{
    class EmpleadoPorComision: Empleado

    {
        private double tarifaComision;
        private double ventasBrutas;

         public EmpleadoPorComision(string cedula, string nombres, string apellidos,double tarifaComision,double ventasBrutas)
             :base(cedula,nombres,apellidos)
         {
             this.tarifaComision = tarifaComision;
             this.ventasBrutas = ventasBrutas;
         }

         public double TarifaComision
         {
             get { return tarifaComision; }
             set { tarifaComision = value; }
         }

         public double VentasBrutas
         {
             get { return ventasBrutas; }
             set { ventasBrutas = value; }
         }


         public override double Ingresos()
         {
             return ventasBrutas * tarifaComision;
         }
        
        public override string ToString()
         {

             return string.Format("Empleado por Comision: {0}\n\t"
                                              + "Ingresos...:${1,10:N0}",
                                             base.ToString(), Ingresos());

         }

        
    }
}
