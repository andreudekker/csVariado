using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pruebadegetsetydemas
{
    class Clase2 : Clase1
    {
        private string apellido;
         public Clase2(string apellido_ ,string nombre):base(nombre)
         {
             this.apellido = apellido_;
         }

         public override string ToString()
         {
             return string.Format("clase 2 {0}", apellido);
         }
    
    }
     
}
