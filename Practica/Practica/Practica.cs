using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica
{
    class Practica
    {
        public string deColor { get; set; }
        public void OBJETO1()
        {
            int a = 1, b = 2, r;
            r = a + b;

            Console.WriteLine(r);

            Console.ReadLine();
        }
        public void OBJETO1(int z)
        {
            Console.WriteLine(" " + z);
            Console.ReadLine();
        }
        public void OBJETO1(int x, int y, int z)
        {
            string m = string.Format("{0} {1} {2}", x, y, z);
            Console.WriteLine(m);
            Console.ReadLine();
        }

        public void msos()
        {
            int t = 123324343;
            Console.WriteLine(t);
            Console.ReadLine();
        }


    }

    class Persona 
    {
        public string ojos { get; set; }
        public string nariz { get; set; }
        
    }
}


