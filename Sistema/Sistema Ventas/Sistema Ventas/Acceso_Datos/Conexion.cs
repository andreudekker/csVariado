using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acceso_Datos
{
    public class Conexion
    {
        static string cadena = @"Data Source=.\SQLEXPRESS;Initial Catalog=DBSAV;Integrated Security=True";
         public static string Cadena { get { return cadena; } }
    }
}
