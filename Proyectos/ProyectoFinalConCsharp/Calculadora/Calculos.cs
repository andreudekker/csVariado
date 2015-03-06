using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculos
    {
        private string _cadena;
        private double _resultado;
        private bool _suma;
        private bool _resta;
        private bool _division;
        private bool _multiplicacion;

        public Calculos() 
        {
            _cadena = "";
        }

        private void apagaBanderas()
        {
            _suma = false;
            _resta = false;
            _multiplicacion = false;
            _division = false;

        }
        public string concatenar(string cadena)
        {
            _cadena += cadena;
             return  _cadena;
        }

        public void suma(string cadena)
        {
            _resultado = Convert.ToDouble(cadena); 
            _suma = true;
            _cadena = "";
        }
   
        public void resta(string cadena)
        {
            _resultado = Convert.ToDouble(cadena);
            _resta = true;
            _cadena = "";
        }
        public void multiplicar(string cadena)
        {
            _resultado = Convert.ToDouble(cadena);
            _multiplicacion = true;
            _cadena = "";
        }
        public void dividir(string cadena)
        {
            _resultado = Convert.ToDouble(cadena);
            _division = true;
            _cadena = "";
        }
        public double resultado(string numero)
        {
            if (_suma  )
            {
                _resultado +=Convert.ToDouble(numero);

            }
            else if (_resta)
            {
                _resultado -= Convert.ToDouble(numero);
            }
            else if (_multiplicacion)
            {
                _resultado *= Convert.ToDouble(numero);
            }
            else if (_division)
            {
                _resultado /= Convert.ToDouble(numero);
            }
            
           
            apagaBanderas();
            return _resultado;
        }
        public void clear()
        {
            _resultado = 0;
            _cadena = "";
            apagaBanderas();
        }

    }
}
