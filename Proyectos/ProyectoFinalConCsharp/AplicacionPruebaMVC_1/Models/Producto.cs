using System;
using System.Collections.Generic;
using System.Data.Entity; // agregar este Using
using System.Linq;
using System.Web;

namespace AplicacionPruebaMVC_1.Models
{
    public class Producto
    {
        public int Codproducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Notas { get; set; }
    }

    public class ProductoDBContext :DbContext  // Using
    {
        public  DbSet<Producto> Producto { get; set; }
    }

}