using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUNO
{
    class Utilidades
    {

        public static bool isNumeric(string Texto)
        {
            Texto = Texto.Trim();
            double num;
            bool isNum = double.TryParse(Texto, out num);
            return isNum;
        }
        
    
    
    }
}
