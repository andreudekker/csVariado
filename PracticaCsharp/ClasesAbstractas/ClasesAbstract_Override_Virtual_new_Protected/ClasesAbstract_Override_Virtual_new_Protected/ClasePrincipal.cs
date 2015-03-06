using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba2
{
   public abstract class ClasePrincipal
    {

       public string nombre { get; set; }
       public abstract void Mensaje();
       public abstract int Numero();
       public virtual void Mensaje2()
       {
           Console.WriteLine("mensaje22222");
       }
    }
}
