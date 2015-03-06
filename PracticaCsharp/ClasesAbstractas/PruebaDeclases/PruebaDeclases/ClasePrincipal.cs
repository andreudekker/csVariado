using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaDeclases
{
    public  abstract  class Figura
    {
        //public abstract void dibujar(); // miembros Abstractos es la firma de la clase abstract
        public virtual void dibujar() {
            Console.WriteLine("Dibujando X figura");
        }// en este metodo virtual puede tener parametros:

        public abstract double area();
    }

}
