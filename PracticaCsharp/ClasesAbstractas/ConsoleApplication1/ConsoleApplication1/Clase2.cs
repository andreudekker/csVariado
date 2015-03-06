using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Clase2:Clase1
    { 
        private int num2;
        public Clase2(int num2_ , int num): base (num)
        {
            this.num2 = num2_;
        }
        public override int numeroP()
        {
            return num2 + Num_;
        }
        public override string ToString()
        {
            return string.Format("la clase2"+num2+Num_);
        }
    }
}
