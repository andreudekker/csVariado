using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funciones
{
     public class Celular
    {
        public string modelo { get; set; }
        public string Marca { get; set; }            
     }

     public class Motorola 
     {
         public string dueño { get; set; }
         public Celular motivo;
     }
   
    
}
