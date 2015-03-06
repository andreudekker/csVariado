using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cuadrado = new Cuadrado(4.0);
            cuadrado.Dibujar();
            Console.WriteLine("El area del cuadrado es{0}",cuadrado.Area());
            Console.ReadLine();
        }
    }
}
