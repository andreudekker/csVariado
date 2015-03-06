using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAbstractas
{
    class Cuadrado :Figura
    {

        public override double Area()
        {
            return Math.Pow(this._lado, 2);
        }
        
        
        
        private double _lado;
        public Cuadrado(double lado)
        {
            this._lado = lado;
        }
        


        public override void Dibujar()
        {
            Console.WriteLine("Dibujando Cuadrado");

        }

       
    }
}
