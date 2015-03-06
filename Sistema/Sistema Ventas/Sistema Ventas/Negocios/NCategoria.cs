using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acceso_Datos;
using Entidades;

namespace Negocios
{
    public class NCategoria
    {
        public static bool Guardar(Categoria e)
        {
            if (ADCategoria.Existe(e))
            {
                return ADCategoria.Actualizar(e);
            }
            else
            {
                return ADCategoria.Agregar(e);
            }
        }
        public static List<Categoria> ListaEntidades(Categoria e)
        {
            return ADCategoria.ListaEntidades(e);
        }
        public static List<Categoria> ListarCategorias()
        {
            return ADCategoria.ListarCategorias();
        }
        public static bool Duplicado(Categoria e)
        {
            return ADCategoria.Duplicado(e);
        }
    }
}
