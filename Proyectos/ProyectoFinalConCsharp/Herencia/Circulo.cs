using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Circulo: Figura
    {
        private double _radio;
       
        public Circulo(double Radio)
        {
            _radio = Radio;
        }

        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un circulo...");     
        }

        public override double Area()
        {
            return Math.PI * _radio * _radio;
        }
        
    }
}
