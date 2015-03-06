using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Uml_Empleado
{
     abstract class Empleado
    {

         /// <summary>
         /// Atributos
         /// </summary>
         private string cedula;
         private string nombres;
         private string apellidos;
         
         public Empleado(string cedula, string nombres, string apellidos)
         {
             this.cedula = cedula;
             this.nombres = nombres;
             this.apellidos = apellidos;
         }

         public string Cedula
         {
             get { return cedula; }
             set { cedula = value; }
         }
    
         public string Nombres
         {
             get { return nombres; }
             set { nombres = value; }
         }
  
         public string Apellidos
         {
             get { return apellidos; }
             set { apellidos = value; }
         }

         public abstract double Ingresos();
       
         public override string ToString()
         {
             return string.Format ("{0}  {1}\n\t"
                                 + "Cedula.....: {2}",
                                 Nombres,Apellidos,Cedula );
         }
          
         



    }
}
