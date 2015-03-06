using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAbstractas
{
    class Circulo :Figura
    {

        public override double Area()
        {
            return Math.PI * Math.Pow(this._radio, 2);
        }
              
        private double _radio;
        public Circulo (double radio)
	    {
            this._radio = radio;
	    }

        public override void Dibujar()
        {
            Console.WriteLine("Dibujando Circulo");
        }

        
    }
}
