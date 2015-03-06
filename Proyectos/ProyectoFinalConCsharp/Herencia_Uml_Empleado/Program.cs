using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Uml_Empleado
{
	class Program
	{
		static void Main(string[] args)
		{
			EmpleadoAsalariado ea = new EmpleadoAsalariado("23234", "Bo", "Marley", 1023514);
			EmpleadoPorHoras eph=new EmpleadoPorHoras("23434","Juan","Santos",48000,48,3000);
			EmpleadoPorComision epc = new EmpleadoPorComision("23432", "paula", "santos", 20, 934857);
			EmpleadoBaseMasComision ebmc = new EmpleadoBaseMasComision("23432", "paula", "santos", 20, 934857,5000000);

			Empleado[] empleado= new Empleado[4]; //recorre la clase principal
			empleado[0]=ea;
			empleado[1]=eph;
			empleado[2]=epc;
			empleado[3]=ebmc;

			foreach (Empleado empleado2 in empleado)
			{
				Console.WriteLine(empleado2);
			}

			
			
            //Console.WriteLine(ea);
            //Console.WriteLine(eph);
            //Console.WriteLine(epc);
            //Console.WriteLine(ebmc);
			
			Console.ReadLine();
			
		}
	}
}
