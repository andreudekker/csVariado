using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; // generar
using System.Windows.Forms;  // toca sacarla de references

namespace LibParametros
{
    public class Parametros
    {
        #region Atributos
        private string servidor;
        private string baseDatos;
        private string usuario;
        private string clave;
        private bool seguridadIntegrada;
        private string archivoParametros;
        private string cadenaConexion;
        private string error;
        private XmlDocument xml = new XmlDocument();
        private XmlNode nodo;
        #endregion

        #region Constructor
        public Parametros()
        {
           servidor="";
           baseDatos="";
           usuario="";
           clave="";
          seguridadIntegrada=true;
          archivoParametros="";
          cadenaConexion="";
          error="";
        }
        #endregion

        #region Propiedades
        public string CadenaConexion //solo para  consulta 
        {
            get { return cadenaConexion;}
        }
        public string Error
        {
            get { return error; }
        }
#endregion

        #region metodos Publicos
        public bool generarCadenaConexion(string nombreArchivoParametros)
        {
           archivoParametros = Application.StartupPath + "//" + nombreArchivoParametros;
            try
            {
                xml.Load(archivoParametros);
                nodo=xml.SelectSingleNode("//Servidor");
                servidor = nodo.InnerText;
                nodo = xml.SelectSingleNode("//BaseDatos");
                baseDatos = nodo.InnerText;
                nodo = xml.SelectSingleNode("//Usuario");
                usuario = nodo.InnerText;
                nodo = xml.SelectSingleNode("//Clave");
                clave = nodo.InnerText;
                nodo = xml.SelectSingleNode("//SeguridadIntegrada");
                seguridadIntegrada=Convert.ToBoolean(nodo.InnerText);
                if (seguridadIntegrada)// autenticacion windows
                {
                    cadenaConexion = "Data Source="+servidor+";Initial Catalog="+baseDatos+";Integrated Security=True";
                }
                else // autenticacion SQl
                {
                    cadenaConexion = "Data Source=" + servidor 
                        + ";Initial Catalog=" + baseDatos  
                        +";User Id="+usuario
                        +";Password="+clave+
                        ";Integrated Security=False";
                }
                     xml = null;
                    return true;

            }
            catch (Exception ex)
            {
                error = ex.Message;
                xml = null;
                return false;
               
            }
        }
        #endregion
    }
}
