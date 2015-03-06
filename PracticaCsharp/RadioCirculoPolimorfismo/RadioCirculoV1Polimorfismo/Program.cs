using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadioCirculoV1
{
    class Program
    {
        static void Main(string[] args)
        {

           
       


            Radio r = new Radio();
             r.radioResultado(); //Sin Parametros
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine(" Funcion con parametros:/t Mi resultado es:" + "" + r.radioResultado(3));  //Con Parametros
            Console.ReadLine();
            
        }
        class Radio
        {

            public void radioResultado() // funcion sin parametros
            { 
            Console.WriteLine("ingrese radio");
            double r = int.Parse(Console.ReadLine());
              r = 3.14159 * r * r;
            Console.WriteLine("El resultado es:"+r);
            }
           

            public double radioResultado(double r) // funcion con parametros//
            {

                double a = 3.14159 * r * r;
                
                return a;
            
            }
        
        }
    
    }
}
