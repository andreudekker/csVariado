using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_DesarrollodeSoftware1
{
    class Empleado
    {

        /// <summary>
        /// Atributos privados de la clase
        /// </summary>
        private string _IDEmpleado;
        private string _Nombres;
        private string _Apellidos;
        private long _Salario;
        private DateTime _FechaContrato;
        //Constructor
        public Empleado(string IDEmpelado, string Nombres, string Apellidos, long Salario, DateTime FechaContrato)
        {
            _IDEmpleado = IDEmpelado;
            _Nombres = Nombres;
            _Apellidos = Apellidos;
            _Salario = Salario;
            _FechaContrato = FechaContrato;

        }

        public Empleado()
        {

        }
        //Propiedades
        public string IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }

        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }

        }
        public long Salario
        {
            get { return _Salario; }
            set { _Salario = value; }
        }
        public DateTime FechaContrato
        {
            get { return _FechaContrato; }
            set { _FechaContrato = value; }
        }

        //metodo to String
        public override string ToString()
        {
            return "ID Empleado:" + _IDEmpleado + "\n"
                        + "\tNombres" + _Nombres + "\n"
                        + "\tNombres" + _Apellidos + "\n"
                        + "\tNombres" + _Salario + "\n"
                         + "\tNombres" + _FechaContrato.ToShortDateString() + "\n"; // la fecha en formato corto
        }

    }
}

