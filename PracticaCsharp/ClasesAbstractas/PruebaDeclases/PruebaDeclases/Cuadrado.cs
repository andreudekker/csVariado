using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaDeclases
{
    class Cuadrado : Figura
    {

        //public override void dibujar()
        //{
        //    Console.WriteLine("Dibujando Cuadrado");
        //}
        private double _lado;
        public Cuadrado(double lado)
        {
            this._lado = lado;
        }

        public new void dibujar()
        {
            base.dibujar();
            Console.WriteLine("Dibujando Cuadrado... en new ");
            //base.dibujar(); // Hace referencia de la clase base (metodo miembro propiedad)
        }
        //public override void dibujar()
        //{
        //    base.dibujar();
        //    Console.WriteLine("Dibujando Cuadrado...");
        //    //base.dibujar(); // Hace referencia de la clase base (metodo miembro propiedad)
        //}


        public override double area()
        {
            return Math.Pow(this._lado, 2);
        }
    }
}
