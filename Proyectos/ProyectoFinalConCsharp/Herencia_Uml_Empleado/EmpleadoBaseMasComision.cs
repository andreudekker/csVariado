using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Uml_Empleado
{
    class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        private double salariosemanal;
         public EmpleadoBaseMasComision(string cedula, string nombres, string apellidos,double tarifaComision,double ventasBrutas,double salarioSemanal)
             :base(cedula,nombres,apellidos,tarifaComision,ventasBrutas)
         {
             this.salarioSemanal = salarioSemanal;
         }

      public double salarioSemanal
         {
             get { return salariosemanal; }
             set { salariosemanal = value; }
         }

      public override double Ingresos()
      {
          return base.Ingresos() +salarioSemanal;
      }     public override string ToString()
        
            {
            
                return  string.Format("Empleado con base: {0}", base.ToString(),Ingresos());
        
             }
        



    }
}
