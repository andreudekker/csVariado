using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LayerDB
{
   public class CadenaDB
    {
       String cadenaConexion = "Server=CARLBRADLEY\\AUTODESKVAULT;Database=DB_Farmacia;User id=sa; pwd=123";
        public String CadenaConexion()
        {
            return cadenaConexion;
        }
    }
}
