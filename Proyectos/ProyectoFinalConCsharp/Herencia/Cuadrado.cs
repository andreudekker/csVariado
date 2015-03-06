using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Cuadrado : Figura
    {
        private double _lado;
        public Cuadrado(double lado)
        {
            _lado = lado;
        }
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un cuadrado");
        }
        public override double Area()
        {
            return _lado * _lado;
        }
    
    
    }
}
