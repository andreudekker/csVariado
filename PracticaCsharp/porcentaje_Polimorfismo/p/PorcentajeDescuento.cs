using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p
{
    class PorcentajeDescuento
    {
        public int precio { get; set; }
        public int porcentaje { get; set; }
        public int total { get; set; }


        #region funcionsinparametros
        public void porcentajeDescuento()
        {

            Console.WriteLine("Nombre articulo");
            string articulo = Console.ReadLine();


            Console.WriteLine("Precio");
            precio = int.Parse(Console.ReadLine());
            
            if (precio > 1000)
            {
                
                porcentaje = precio * 20 / 100;
                
                total = precio - porcentaje;
                
                Console.WriteLine("El total a pagar es:" + total);
                Console.ReadLine();
                

            }
        }
        #endregion
        
        #region funcionconparametros
        public int porcentajeDescuento(int precio, int porcentaje)
        {

            if (precio>1000)
            {
                porcentaje = precio * 20 / 100;
                total = precio - porcentaje;
                Console.WriteLine("el valor es:"+ total);
            }

            return total;
        }
        #endregion


       

        }
        
    }

