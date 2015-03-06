using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba2
{
    class ClaseDos: ClasePrincipal
    {
        private int numeroZ;
        public ClaseDos(int numeroz)
        {
            this.numeroZ = numeroz;
        }
        
        public override int Numero()
        {
            numeroZ = 4;
            Console.WriteLine("{0}", numeroZ);
            return this.numeroZ;
        }
        
        public override void Mensaje()
        {
            Console.WriteLine("Hola");
        }



         new public  void Mensaje2()
        {
        //    //base.Mensaje2();// para llamar al metodo principal si es necesario:
        Console.WriteLine("vacio");
         
        }
    }
}
