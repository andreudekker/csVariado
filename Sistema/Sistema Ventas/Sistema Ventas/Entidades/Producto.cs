using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        public int IdProducto{get;set;}
        public int IdCategoria { get; set; }
        public string Marca { get; set; }
        public string Modelo{get;set;}
        public float Precio{get;set;}
        public int Stock {get;set;}
        public string Estado{get;set;}
        
    }
}
