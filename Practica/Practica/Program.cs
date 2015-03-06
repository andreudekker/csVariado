using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Datos d = new Datos();            
            d.mns(5,5); 
            Console.ReadLine();

            Datos2 d2 = new Datos2();
            d2.mns(5,5);
            d2.listas();
            d2.matriz();
            
            
            Console.ReadLine();


           



        }


    }
}

