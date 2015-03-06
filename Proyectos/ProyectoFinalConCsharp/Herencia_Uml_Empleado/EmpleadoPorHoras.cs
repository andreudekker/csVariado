using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Uml_Empleado
{
    class EmpleadoPorHoras : Empleado
    {

        private double numeroHorasTrabajadas;
        private double valorHora;


         public EmpleadoPorHoras(string cedula, string nombres, string apellidos, double salarioSemanal,double  numeroHorasTrabajadas,double valorHora):base(cedula,nombres,apellidos)
         {
             this.numeroHorasTrabajadas = numeroHorasTrabajadas;
             this.valorHora = valorHora;
         }

         public double NumeroHorasTrabajadas
        {
            get { return numeroHorasTrabajadas; }
            set { numeroHorasTrabajadas = value; }
        }

         public double ValorHora
         {
             get { return valorHora; }
             set { valorHora = value; }
         }

     
        public override double Ingresos()
        {
            if (numeroHorasTrabajadas <= 40) return valorHora * numeroHorasTrabajadas;
            else return 40 * valorHora + (numeroHorasTrabajadas - 40) * valorHora * 1.5;

        }
            public override string ToString()
        
            {
            
                return  string.Format("Empleado por horas: {0}\n\t"
                                                 + "Ingresos...:${1,10:N0}",
                                                base.ToString(),Ingresos());
        
             }
        
        }
    }

