using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Aval
    {
        public int IdAval {get;set;}
        public string dni {get;set;} 
        public string Nombres {get;set;}
        public string Apellidos{get;set;}
        public DateTime Fec_nacimiento {get;set;}
        public string Estado_civil {get;set;}
        public string Direccion {get;set;}
        public string Distrito { get; set; }
        public string NroTitulo{ get; set; }
    }
}
