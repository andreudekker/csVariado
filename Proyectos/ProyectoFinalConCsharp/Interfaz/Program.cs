using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura("00001", "llantas", 4, 17500);
            Factura f2 = new Factura("00001", "aguardiente antioqueño", 7, 36000);
            EmpleadoAsalariado e1 = new EmpleadoAsalariado("2131", "nemi", "sanin", 78450);
            EmpleadoAsalariado e2 = new EmpleadoAsalariado("212231", "rufino", "delsocorro", 78450);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.ReadLine();
        }
    }
}
