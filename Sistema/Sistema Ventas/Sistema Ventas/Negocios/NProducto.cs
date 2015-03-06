using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NProducto
    {
        public static bool Guardar(Producto e)
        {
            if (ADProducto.Existe(e))
            {
                return ADProducto.Actualizar(e);
            }
            else
            {
                return ADProducto.Agregar(e);
            }
        }
        public static List<Producto> ListaEntidades(Producto e)
        {
            return ADProducto.ListaEntidades(e);
        }
        public static int ObtenerIdProducto(Producto e)
        {
            return ADProducto.ObtenerIdProducto(e);
        }
        public static int ObtenerStock(Producto e)
        {
            return ADProducto.ObtenerStock(e);
        }
        public static bool ModificarStock(Producto e)
        {
            return ADProducto.ModificarStock(e);
        }
        public static bool ExisteModelo(Producto e)
        {
            return ADProducto.ExisteModelo(e);
        }
    }
}
