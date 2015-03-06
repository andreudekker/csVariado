using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionwinformConBd_Final
{
    class Utilidades
    {
        public static bool isNumeric(string texto)
        {
            texto = texto.Trim();
            double num;
            bool isNum=Double.TryParse(texto, out num);
            return isNum;
        }


    }
}
