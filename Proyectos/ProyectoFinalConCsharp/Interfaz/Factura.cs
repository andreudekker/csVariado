using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class Factura :PorPagar
    {


        private string codigo;
        private string descripcion;
        private double cantidad;
        private double precio;

        public Factura(string codigo, string descripcion, double cantidad, double precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
           
        }

        
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

     

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        
        
        
        

        public double ObtenerMontoPago()
        {
            return cantidad * precio;
        }

        public override string ToString()
        {
            return string.Format("Factura: {0}\n\t"
                                        + "Descripcion..............{1}\n\t"
                                        + "Descripcion..............{2,10:N0}\n\t"
                                        + "Descripcion..............{3,10 :N0}\n\t"
                                        + "Descripcion..............{4,10:N0}\n\t",
                                        codigo, descripcion, precio, cantidad, ObtenerMontoPago());
                                        
                                      
        }
    }
}
