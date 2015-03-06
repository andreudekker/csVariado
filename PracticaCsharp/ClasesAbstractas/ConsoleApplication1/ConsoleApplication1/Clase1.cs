using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Clase1 : SuperClase
	{
		private int num;
		public Clase1() { }
		
        public Clase1(int numero_)
		{
			this.num = numero_;
		}
		public override int numeroP()
		{
			return num + num;
		}
		

	   

	public int Num_
	{
		get { return num;}
		set { num = value;}
	}
	
		
		public override string ToString()
		{
			return String.Format("el numero es" + num);
		}
	
	}
}
