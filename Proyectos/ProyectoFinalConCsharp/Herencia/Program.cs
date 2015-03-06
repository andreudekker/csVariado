using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var  cuadrado = new Cuadrado(5.0);
            cuadrado.Dibujar();
            Console.WriteLine("El area Cuadrado es " + cuadrado.Area());
           
            var circulo = new Cuadrado(2.3);
            circulo.Dibujar();
            Console.WriteLine("El area Cuadrado es " + circulo.Area());

            Console.ReadLine();

        }
    }
}
