using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        public int IdCliente {get;set;}
        public string dni {get;set;}
        public string Tipo_persona { get; set; }
        public string Nombres {get;set;}
        public string Apellidos{get;set;}
        public string Razon_social{get;set;}
        public string ruc{get;set;}
        public DateTime Fec_nacimiento {get;set;}
        public string Estado_civil{get;set;}
        public string Direccion { get; set; }
        public int IdDistrito { get; set; }
    }
}
