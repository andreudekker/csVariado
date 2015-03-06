using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase1 c1 = new Clase1(9);
            Clase2 c2 = new Clase2(7,1);
            Console.WriteLine(c1.numeroP());
            Console.WriteLine(c2.numeroP());
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
