using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba2
{
    class Program 
    {
        static void Main(string[] args)
        {
            var cd = new ClaseDos(2);
            cd.Mensaje();
            cd.Mensaje2();
            cd.Numero();
            Console.ReadLine();
        }
    }
}
