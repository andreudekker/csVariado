using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pruebadegetsetydemas
{
    class Clase1: SuperClase
    {
        private string nombre;
        public Clase1(string nombre_) 
        {
            this.nombre = nombre_;
        }
        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}",nombre);
        }
    
    }
}
