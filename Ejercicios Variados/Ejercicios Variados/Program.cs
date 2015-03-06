using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ejercicios_Variados
{
	class Program
	{
		struct Simple
		{
			public int Position;
			public bool Exists;
			public double LastValue;
		};
		
		static void Main(string[] args)
		{
			Simple s;
			s.Position = 1;
			s.Exists = false;
			s.LastValue = 5.5;
			Console.WriteLine(s.LastValue);
			Console.ReadLine();
			
			
			



		}
			
		  
		#region ejemplosGeneralesmatrices
			//int[,] numbers = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };  //2  Dimensiones
			//int[,] numbers = new int[2, 2] { { 234, 123 }, { 456, 678 } };   // 2 Dimensiones.
			//foreach (int i in numbers)
			//{
			//    Console.Write("{0} ", i);
			//    Console.ReadLine();
			//}
			//int []numero = new int[5] {223,334,466,789,111};  // matrix de 5x5 unidimensional
			//string[] letras = new string[3] { "a", "b","Colombia" }; // matriz de 3 x3 unidimensional
  

			//for (int i = 0; i < numero.Length; i++) // recorrido matriz con un for "unidimensional"
			//{
			//    Console.WriteLine("{0} {1} {2} {3} {4}", numero[0], numero[1], numero[2], numero[3], numero[4]);
			//    Console.ReadLine();
			//}
			//for (int i = 0; i < letras.Length; i++) // recorrido con un for "Unidimensional";
			//{
			//    Console.WriteLine("{0} {1} {2}",letras[0],letras[1],letras[2]);
			//    Console.ReadLine();
			//}

			//foreach (var nu in numero)  // recorrido con un foreach matriz "Unidimensional"
			//{
			//    Console.WriteLine("{0}",nu);
			//    Console.ReadLine();
			//}
			//foreach (var le in letras) // recorrido con un foreach matriz "Unidimensional"
			//{
			//    Console.WriteLine("{0}", le);
			//    Console.ReadLine();
			//}
			// declare multidimension array (two dimensions)
			#endregion
			#region recorrerArrays 2 Dimensiones
			//int[,]pares = new int[2,3]{{2,3,5},{4,8,9}};
			////Console.WriteLine("{0} {1} {2}", pares[0,0], pares[0,1], pares[0,2]);

			//for (int i = 0; i < 1; i++)
			//{
			//    for (int j = 0; j < 1; j++)
			//    {
			//        //Console.WriteLine("{0} {1} {2}", pares[0, 0], pares[0, 1], pares[0, 2]); // dejo en la condicion 1 para 
			//        //Console.WriteLine("{0} {1} {2}", pares[1, 0], pares[1, 1], pares[1, 2]); // que se repita 1 vez y muestre
			//        //Console.WriteLine("{0} ", pares[i, j]); // En el for en la condicion hasta cuando dejo 2,3
					
			//    }
				   
				  
			//}
			//Console.ReadLine();
			#endregion
			#region Arrays
			//int cantidad = 0;
			//int n = 0;
			//float suma = 0.0f;
			//float promedio = 0.0f;
			//float minima= 10.0f;
			//float maxima=0.0f;
			//Console.WriteLine("Cantidad de alumnos");
			//cantidad= int.Parse(Console.ReadLine());
			//float[] calif = new float[cantidad];
			//for ( n = 0; n < cantidad; n++)
			//{
			//    Console.WriteLine("Dame la calificacion");
			//    int cali =int.Parse(Console.ReadLine());
			//    calif[n] = Convert.ToSingle(cali);
			//}
			//for ( n = 0; n < cantidad; n++)
			//{
			//    suma += calif[n];
			//}
			//promedio = suma / cantidad;
			//for ( n = 0; n < cantidad; n++)
			//{
			//    if (calif[n]<minima)
			//    {
			//        minima = calif[n];
			//    }
			//}
			//for ( n = 0; n < cantidad; n++)
			//{
			//    if (calif[n]>maxima)
			//    {
			//        maxima = calif[n];
			//    }
			//    Console.WriteLine("El promedio es:{0}", promedio);
			//    Console.WriteLine("minima {0}", minima);
			//    Console.WriteLine("maxima {0}",maxima);
			//    Console.ReadLine();
			//}
			#endregion

			#region parametros por referencia
			//int numero = 5;
			//int numero2 = 7;
			//Console.WriteLine(" antes {0} {1}",numero,numero2);
			//Console.ReadLine();
			// Cambio(ref numero,ref numero2);
			//Console.WriteLine("despues {0} {1}", numero,numero2);
			//Console.ReadLine();
#endregion

			#region asignacionDeFunciones
			//suma(); //funcion que solo ejecuta codigo

			//string pepito = mensaje();
			//int a = 0;
			//int b = 98;
			//suma(a, b);
			#endregion

			#region while
			//        int numero = 5;
	//        while (numero <= 10)
	//{
			  
	//            Console.WriteLine("{0}",numero);
	//            numero--;
	//            Console.ReadLine();

			   
	//}
	//        Console.WriteLine("{0}", numero);
			//        Console.ReadLine();

			#endregion

			#region do while
			//float pies = 0.0f; // Cantidad de pies
			//    float pulgadas = 0.0f; // Cantidad de pulgadas
			//    float centimetros = 0.0f; // Resultado en centímetros
			//    string respuesta = ""; // Respuesta para otro cálculo
			//    string valor = "";
			
			
//            do
//{

					//Console.WriteLine("Cuántos pies:");
					//valor = Console.ReadLine();
					//pies = Convert.ToSingle(valor);

					//Console.WriteLine("Cuántas pulgadas:");
					//valor = Console.ReadLine();
					//pulgadas = Convert.ToSingle(valor);

					//centimetros = ((pies * 12) + pulgadas) * 2.54f;

					//Console.WriteLine("Son {0} centímetros", centimetros);

					//Console.WriteLine("Deseas hacer otra conversión(si/no)?");
					//respuesta = Console.ReadLine();
					//            } while (respuesta=="si");

			#endregion

			#region Factorial
			//int factorial =1;
			//int f = 0;
			//Console.WriteLine("Numero factorial");
			//f = Convert.ToInt32(Console.ReadLine());
			//for (int n = f; n >= 1 ; n--)
			//{
			//    factorial*=n;
			//    Console.WriteLine("Es: {0} {1}",n,factorial);
			//    Console.ReadLine();
			  //}   
#endregion         
	  
		
			#region pendiente para hacer
			//int numero = 5;
			//Console.WriteLine("{0}",numero);
			//numero++;
			//Console.WriteLine("{0}",numero);
			//numero--;
			//Console.WriteLine("{0}",numero++);
			//Console.WriteLine("{0}",numero);
			//Console.WriteLine("{0}",++numero);
			//Console.WriteLine("{0}",numero);
			//Console.ReadLine();
			#endregion


			#region if con switch
			//int opcion = 0;
			//int r=0, a=0, b=0;
			
			//Console.WriteLine("1.Suma,2.Resta,3.Division,4.Multiplicacion");
			//Console.WriteLine("Escoje una opcion de 1 a 4");
			//opcion = opcion + Convert.ToInt32(Console.ReadLine());
			//if (opcion <= 4)
			//{
			//    Console.WriteLine("Numero a");
			//    a = a + Convert.ToInt32(Console.ReadLine());
			//    Console.WriteLine("Numero b");
			//    b = b + Convert.ToInt32(Console.ReadLine());

			//}
		
			//switch (opcion)
			//{
			//    case 1:
			//        r = a + b;
			//        Console.WriteLine("el resultado suma es:"+r);
			//        Console.ReadLine();
			//        break;
			//    case 2:
			//        r = a - b;
			//        Console.WriteLine("el resultado  resta es:"+r);
			//        Console.ReadLine();
			//        break;
			//    case 3:
			//        r = a / b;
			//        Console.WriteLine("el resultado division es:"+r);
			//        Console.ReadLine();
			//        break;
			//    case 4:
			//        r = a * b;
			//        Console.WriteLine("el resultado multiplicacion es:"+r);
			//        Console.ReadLine();
			//        break;
			//    default:
			//        Console.WriteLine("Opcion no valida");
			//        Console.ReadLine();
			//        break;
			//}
#endregion
			
			#region Condicionales Con if y booleanos
			//int edad = 0;
			//bool permiso;
			//Console.WriteLine("edad");
			//edad = edad + Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("permiso true/false");
			//permiso = Convert.ToBoolean(Console.ReadLine());
			//if (edad >= 18 || (edad>15 && permiso == true))
			//{
			//    Console.WriteLine("ok");
			//    Console.ReadLine();
			//}
			//else
			//{
			//    Console.WriteLine("Denegado");
			//    Console.ReadLine();
			//}

			#endregion

			#region OperacionesAritmeticas
			//public void operacionesaritmeticas()
			//{
			//    float a = 0.0f;
			//    float b = 0.0f;
			//    float r = 00f;
			//    int opcion = 0;
			//    Console.WriteLine("Menu");
			//    Console.WriteLine("1.Suma");
			//    Console.WriteLine("Resta");
			//    Console.WriteLine("Multiplicacion");
			//    Console.WriteLine("Division");
			//    Console.WriteLine("Cual es su opcion");
			//    opcion = opcion + Convert.ToInt32(Console.ReadLine());
			//    Console.WriteLine("Numero a");
			//    a = a + Convert.ToInt32(Console.ReadLine());
			//    Console.WriteLine("Numero b");
			//    b = b + Convert.ToInt32(Console.ReadLine());
			//    if (opcion == 1)
			//    {
			//        r = a + b;
			//        Console.WriteLine("El resultado de la suma es:" + r);
			//        Console.ReadLine();
			//    }

			//    else if (opcion == 2)
			//    {
			//        r = a - b;
			//        Console.WriteLine("El resultado de la suma es:" + r);
			//        Console.ReadLine();

			//    }
			//    else if (opcion == 3 && b != 0)
			//    {
			//        r = a * b;
			//        Console.WriteLine("El resultado de la suma es:" + r);
			//        Console.ReadLine();
			//    }
			//    else if (opcion == 4)
			//    {
			//        r = a / b;
			//        Console.WriteLine("El resultado de la suma es:" + r);
			//        Console.ReadLine();
			//    }
			//}
			#endregion
		}

		#region FuncionQueSoloEjecutaCodigo
		//static void suma()  Funcion que solo Ejecuta Codigo
		//{
		//    int a, b, c;
		//    Console.WriteLine("Digite a:");
		//    a = Convert.ToInt16(Console.ReadLine());
		//    Console.WriteLine("Digite b:");
		//    b = Convert.ToInt16(Console.ReadLine());
		//    c = a + b;
		//    Console.WriteLine("Es {0}", c);
		//    Console.ReadLine();
		//}
		#endregion
		#region ConValoresReturn
		//static string mensaje() 
		//{
		//    string m = "hola";
		//    Console.WriteLine("{0}", m);
		//    Console.ReadLine();
		//    return m;
		//}
		#endregion

		#region suma
		//static int suma(int a, int b)
		//{
		//    int c;
		//    c = a + b;
		//    Console.WriteLine("Es {0}", c);
		//    Console.ReadLine();

		//    return c;

		//}
		#endregion
		#region porReferencia
		//static void Cambio(ref int numero, ref int numero2)
		//{
		//      numero=17;
		//      numero2 = 23;

		//}
		#endregion



	}

