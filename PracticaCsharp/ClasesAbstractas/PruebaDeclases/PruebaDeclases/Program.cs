using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaDeclases
{
    class Program
    {
        static void Main(string[] args)
        {
            var cuadrado = new Cuadrado(4.0);
            cuadrado.dibujar();
            Console.WriteLine("El area del cuadrado es: {0}",cuadrado.area());
            Console.ReadLine();
            
            var circulo = new Circulo(2.5);
            circulo.dibujar();
            Console.WriteLine("El area del circulo es: {0}",circulo.area());
            Console.ReadLine();


        }
    }
} 
