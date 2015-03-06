using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Funciones
{
	class Program
	{
 
		static void Main(string[] args)
		{
			funciones f = new funciones();
			//f.Multiplicar();
			//f.Multiplicar(9, 9);
			//f.Validacion();
			//f.ComparacionNumeros();
			f.mensaje("mmmm","");
			
			Celular c = new Celular();
			c.modelo = "nokia";
			c.Marca = "taz";
			Console.WriteLine(c.modelo);

			Motorola m = new Motorola();
			m.motivo = c;
			m.dueño = "andres";
			Console.WriteLine(m.motivo.modelo = "dePrueba");
			Console.WriteLine(m.dueño);
			Console.ReadLine();
			

			  
		}

		class funciones
		{

			public void Multiplicar()
			{
				for (int i = 0; i <=10; i++)
				{
					Console.WriteLine("Tabla:"+i);

					for (int j = 0; j <=10; j++)

					{
						int r=i*j;
						
						Console.WriteLine("" + i + "*" + j + "=" + r + "");
						Console.ReadLine();
					}
				}
			}

				public int Multiplicar(int i , int j)
				{
					int r = i * j;
					Console.WriteLine(r);
					Console.ReadLine();
					return r;
				}

				public void Validacion()
				{
					int numero = 1;

					while (numero<=10)
					{
						
						if (numero == 2)
							{
								Console.WriteLine("MENSAJE VALIDADO_");
								Console.ReadLine();
							   
							}
						
						Console.WriteLine("Mensaje en While"+numero);
						Console.ReadLine();
						
						numero++;
					}

						   
				 }
				public void ComparacionNumeros()
				{
					int numero1 = 1;
					int numero2 = 3;
					while (numero1 <= numero2)
					{
						
						Console.WriteLine("hola"+numero1);
						Console.ReadLine();
						numero1++;
					}
					
				}

			  
				public string mensaje(string m, string m2)
				{
					 m2 = "oo";
					 m2= string.Format("es:{0}",m2);
					
					 return m + m2;
				}

		
		
		}
	}
}
