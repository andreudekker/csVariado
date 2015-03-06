using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empleado
    {
        public int IdEmpleado {get;set;}
        public string dni {get;set;}
        public string Nombres {get;set;}
        public string Apellidos{get;set;}
        public DateTime Fec_nacimiento {get;set;}
        public string Estado_civil{get;set;}
        public string Celular {get;set;}
        public string Correo_electronico{get;set;}
        public string Direccion {get;set;}
        public int IdDistrito { get; set; }
    }
}
