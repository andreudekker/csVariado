using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaDeclases
{
    class Circulo : Figura
    {
        public override void dibujar()
        {
            Console.WriteLine("Dibujando Circulo");
        }

        private double _radio;
        public Circulo(double radio)
        {
            this._radio = radio;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(this._radio, 2);
        }
    }
}
