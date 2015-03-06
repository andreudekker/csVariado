using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p
{
    class Program
    {
        static void Main(string[] args)
        {
            //En un almacén se hace un 20% de descuento a los clientes cuya compra supere los
            //S/.1000 ¿ Cual será la cantidad que pagara una persona por su compra?


                  

                    PorcentajeDescuento p = new PorcentajeDescuento();
                    //p.porcentajeDescuento();
                    p.porcentajeDescuento(2000, 20);
                    Console.ReadLine();
        
                }
                  
            }
    }

