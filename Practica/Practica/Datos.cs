using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Practica
{
    public class Datos
    {   
        public virtual int mns(int a, int b)
        {
           int r=a+b;
           Console.WriteLine(r);
           return r;
        }
       
    }
    public class Datos2 : Datos
    {         
        public override int mns(int a, int b)
        {
            int r = a * b;
            Console.WriteLine(r);
            return r;
        }

        public void listas()
        {
            List<string> item = new List<string>();
            item.Add("palabras1<listas>");
            item.Add("palabras2<listas>");
            item.Add("palabras3<listas>");
            foreach (string m in item)
            {
                Console.WriteLine(m);
                Console.ReadLine();
            }
            
            //string itemd = string.Join(",", item.ToArray()); // tambien es valido para hacer la busqueda
            //Console.WriteLine(itemd);
            Console.ReadLine();
                     
        }

        public void matriz()
        {
            ArrayList inventario = new ArrayList();
            inventario.Add("frase1 <arraylist>".ToString());
            inventario.Add("frase2 <arraylist>");
            inventario.Add("frase3 <arraylist>");
            foreach (var i in inventario)
            {
                Console.WriteLine(i);
            }
           
            Console.ReadLine();
        }
    
    }

        
    
}
