using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_DesarrollodeSoftware1
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("1010","Juan","Lopez",200000,new DateTime(2001,4,12));
            Empleado empleado2 = new Empleado("1010", "pedro", "Lopez", 550000, new DateTime(2001, 3, 12));
            Empleado empleado3 = new Empleado("1010", "Julian", "Lopez", 245000, new DateTime(2001, 6, 12));
            Empleado empleado4 = new Empleado("1010", "Natalia", "Lopez", 256000, new DateTime(2001, 7, 12));
            Empleado empleado5 = new Empleado("1010", "Celia", "Lopez", 204500, new DateTime(2001, 9, 12));
            
            
            Empleado empleado6 = new Empleado();
            empleado6.IDEmpleado = "6006";
            empleado6.Nombres = "Ruben";
            empleado6.Apellidos = "Baldes";
            empleado6.Salario = 200000;
            empleado6.FechaContrato = new DateTime(1999, 10, 4);

            Empleado[] empleados = new Empleado[6];  //mostrar los objetos
            empleados[0] = empleado1;
            empleados[1 ]= empleado2;
            empleados[2] = empleado3;
            empleados[3] = empleado4;
            empleados[4] = empleado5;
            empleados[5] = empleado6;
           
            //mostrar empleados
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.ToString());
            }


            //incrementar salario
            Console.WriteLine("::::::::::::Empleado sin el aumento::::::::::::");
            foreach (var empleado in empleados)
            {
                empleado.Salario = (long)(empleado.Salario * 1.25); //cast por el tipo de datos
            }

            foreach (var empleado in empleados)
            {
                empleado.Salario = (long)(empleado.Salario * 1.25); //cast por el tipo de datos
            }
            Console.ReadLine();
            Console.WriteLine("::::::::::::Empleado con el aumento::::::::::::");
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.ToString()); //cast por el tipo de datos
            }
            Console.ReadLine();
        }
    }
}
