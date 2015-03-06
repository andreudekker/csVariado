using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class EmpleadoAsalariado: Empleado
    {
        private double salarioSemanal;
        
        public EmpleadoAsalariado(string cedula, string nombres, string apellidos, double salarioSemanal):base(cedula,nombres,apellidos)
         {
                    this.salarioSemanal = salarioSemanal;
         }

        public double SalarioSemanal
        {
            get { return salarioSemanal; }
            set { salarioSemanal = value; }
        }

        //public override double Ingresos()  //se elimina ya que esta el metdo punto pago
        //{
        //    return salarioSemanal;
        //}

        public override string ToString()
        {
            return  string.Format("Empleado asalariado: {0}\n\t"
                                             + "Ingresos...:${1,10:N0}",
                                            base.ToString(),ObtenerMontoPago()); // se implementa monto pago
        
        }



        public override double ObtenerMontoPago()
        {
            return salarioSemanal;
        }
    }
}
