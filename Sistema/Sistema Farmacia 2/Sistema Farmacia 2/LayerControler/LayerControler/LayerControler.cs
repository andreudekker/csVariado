using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using LayerDB;
using LayerEncriptation;
using System.Windows.Forms;
using System.Data;



namespace LayerControler
{
    //layer validar
    namespace Validar
    {
        #region CLASE VALIDAR
        public class validar
        {
            //Validar cajas solo Numeros
            public static void validarSoloNumero(KeyPressEventArgs pE)
            {
                if(char.IsDigit(pE.KeyChar))
                {
                    pE.Handled=false;
                }
                else if(char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (char.IsPunctuation(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else
                {
                    pE.Handled = true;
                }
            }

            //Validar cajas solo Letras
            public static void validarSoloLetras(KeyPressEventArgs pE)
            {
                if (char.IsLetter(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if(char.IsSeparator(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else
                {
                    pE.Handled = true;
                }
            }
        }
        #endregion
    }
       
    //Layer Usuario
    namespace LayerUsuario
    {
        public class Usuario
        {
            //DECLARACION DE VARIABLES
            private String id;
            private String nombre;
            private String nomUser;
            private String passUser;
            private Byte nivel;
            private Byte estado;

            //METODO SET
            #region METODO SET
            public void setId(String miId)
            {
                id = miId;
            }

            public void setNombre(String miNombre)
            {
                nombre = miNombre;
            }

            public void setNomUser(String miNomUser)
            {
                nomUser = miNomUser;
            }

            public void setPassUser(String miPasUser)
            {
                passUser = miPasUser;
            }

            public void setNivel(Byte miNivel)
            {
                nivel = miNivel;
            }

            public void setEstado(Byte miEstado)
            {
                estado = miEstado;
            }
            #endregion

            //METODO GET
            #region METODO GET
            public String getId()
            {
                return id;
            }

            public String getNombre()
            {
                return nombre;
            }

            public String getNomUser()
            {
                return nomUser;
            }

            public String getPassUser()
            {
                return passUser;
            }

            public Byte getNivel()
            {
                return nivel;
            }

            public Byte getEstado()
            {
                return estado;
            }
            #endregion

            // CONSTRUCTOR
            #region Constructor
            public Usuario()
            {
            }

            public Usuario(String pNombre, String pUsuario, String pPassword, Byte pNivel, Byte pEstado)
            {
                this.nombre = pNombre;
                this.nomUser = pUsuario;
                this.passUser = pPassword;
                this.nivel = pNivel;
                this.estado = pEstado;
            }
            #endregion
        }

        public class UsuarioControl : Usuario
        {
            DB ObjDB = new DB();
            Usuario ObjUsuario = new Usuario();
            Encriptation objEncriptation = new Encriptation();

            public int Iniciar_Sesion()
            {
                if (!String.Empty.Equals((base.getNomUser())))
                {
                    ArrayList lista = ObjDB.Listar_SQL("select pass, estado from usuarios where usuario='" + base.getNomUser() + "'");
                    if (lista.Count >= 1)
                    {
                        if (!Int32.Parse(lista[1].ToString()).Equals(0))
                        {
                            if (objEncriptation.Desencriptar(lista[0].ToString()) == base.getPassUser()) { return 1; } // contrase;a y usuario correctos
                            else { return 2; } // usuario correcto y contrase;a incorrecta
                        }
                        else { return 3; } // Cuenta deshabilitada
                    }
                    else
                    {
                        return 0; // usuario incorrecto
                    }
                }
                else { return 0; }
            }

            public string Cargar_Nivel_Usuario()
            {
                string nivel = null;
                ArrayList lista = ObjDB.Listar_SQL("select nivel from usuarios where usuario='" + base.getNomUser() + "'");
                if (lista.Count >= 1)
                {
                    if (Int32.Parse(lista[0].ToString()) == 0) { nivel = "Colaborador"; }
                    if (Int32.Parse(lista[0].ToString()) == 1) { nivel = "Administrador"; }
                }
                return nivel;
            }

            public int Cargar_ID_Nuevo_Usuario()
            {
                int idUsuario = 0;
                ArrayList lista = ObjDB.Listar_SQL("Select MAX(id) from usuarios");
                if (lista.Count >= 1)
                {
                    idUsuario = Int32.Parse(lista[0].ToString()) + 1;
                }
                return idUsuario;
            }

            public ArrayList cargarListaFarmacia() {
                string sql = "SELECT * FROM Farmacia";
                ArrayList lista = ObjDB.Listar_SQL(sql);
                if(lista.Count > 0)
                    return lista;
                return null;
            }

            public int buscarID(Boolean tipo, string buscar)
            {
                // tipo => True = usuario
                // tipo => False = farmacia
                string sql = tipo
                    ? sql = "select id from Usuarios where usuario='" + buscar + "';"
                    : sql = "select id from Farmacia where nombre='" + buscar + "';";
                ArrayList lista = ObjDB.Listar_SQL(sql);
                if (lista.Count > 0)
                    return Int32.Parse(lista[0].ToString());
                return 0;
            }

            public void Guardar_Nuevo_Usuario()
            {
                base.setPassUser(objEncriptation.Encriptar(base.getPassUser()));
                string sql = "insert into usuarios values('" + base.getNombre() + "','" + base.getNomUser() + "','" + base.getPassUser() + "'," + base.getNivel() + "," + base.getEstado() + ");";
                ObjDB.Ejecutar_SQL(sql);
            }

            public DataTable Buscar_Usuario(DataTable datatable)
            {
                string sql = "select * from usuarios where usuario LIKE '%" + base.getNomUser() + "%'";
                return ObjDB.SelectRows(datatable, sql);
            }

            public void Eliminar_Usuario()
            {
                string sql = "update usuarios set estado=0 where id=" + base.getId() + ";";
                ObjDB.Ejecutar_SQL(sql);
            }

            public void Modificar_Usuario()
            {
                base.setPassUser(objEncriptation.Encriptar(base.getPassUser()));
                string sql = "update usuarios set nombres='" + base.getNombre() + "', usuario='" + base.getNomUser() + "', pass='" + base.getPassUser() + "',  nivel=" + base.getNivel() + ", estado=" + base.getEstado() + " where id=" + base.getId() + ";";
                ObjDB.Ejecutar_SQL(sql);
            }

            public string Desencriptar(string cadena)
            {
                return objEncriptation.Desencriptar(cadena);
            }
        }
    }

    //Layer Medicamentos
    namespace LayerMedicamentos
    {
        #region CLASE MEDICAMENTOS
        public class Medicamentos
        {
            private int id;
            private String NombreMedicamento;
            private Double precioVenta;
            private Double precioCompra;
            private DateTime fechaCaducidad;
            private int existencia;
            private String descripcion;
            private String especificaciones;
            private DateTime fechaIngreso;
            private int idCategoria;
            private int estado;

            //Contructor
            #region //Construcctor
            public Medicamentos()
            {
            }
            public Medicamentos(int miId, String miNombreMedicamento, Double miPrecioVenta, Double miPrecioCompra,
                DateTime miFechaCaducidad, int miExistencia, String miDescripcion, String miExpesificaciones,
                DateTime miFechaIngreso, int miIdCategoria, int miEstado)
            {
                this.id = miId;
                this.NombreMedicamento = miNombreMedicamento;
                this.precioVenta = miPrecioVenta;
                this.precioCompra = miPrecioCompra;
                this.fechaCaducidad = miFechaCaducidad;
                this.existencia = miExistencia;
                this.descripcion = miDescripcion;
                this.especificaciones = miExpesificaciones;
                this.fechaIngreso = miFechaIngreso;
                this.idCategoria = miIdCategoria;
                this.estado = miEstado;
            }
            #endregion

            //Metodos Set
            #region //Metodos SET
            public void setId(int miId)
            {
                this.id = miId;
            }

            public void setNombreMedicamento(String miNombreMedicamento)
            {
                this.NombreMedicamento = miNombreMedicamento;
            }

            public void setPrecioVenta(Double miPrecioVenta)
            {
                this.precioVenta = miPrecioVenta;
            }

            public void setPrecioCompra(Double miPrecioCompra)
            {
                this.precioCompra = miPrecioCompra;
            }

            public void setFechaCaducidad(DateTime miFechaCaducidad)
            {
                this.fechaCaducidad = miFechaCaducidad;
            }

            public void setExistencia(int miExistencia)
            {
                this.existencia = miExistencia;
            }

            public void setDescripcion(String miDescripcion)
            {
                this.descripcion = miDescripcion;
            }

            public void setEspecificaciones(String miEspecificaciones)
            {
                this.especificaciones = miEspecificaciones;
            }

            public void setFechaIngreso(DateTime miFechaIngreso)
            {
                this.fechaIngreso = miFechaIngreso;
            }

            public void setIdCategoria(int miIdCategoria)
            {
                this.idCategoria = miIdCategoria;
            }

            public void setEstado(int miEstado)
            {
                this.estado = miEstado;
            }
            #endregion

            //Metodos get
            #region //Metodos Get
            public int getId()
            {
                return this.id;
            }

            public String getNombreMedicamento()
            {
                return this.NombreMedicamento;
            }

            public Double getPrecioVenta()
            {
                return this.precioVenta;
            }

            public Double getPrecioCompra()
            {
                return this.precioCompra;
            }

            public DateTime getFechaCaducidad()
            {
                return this.fechaCaducidad;
            }

            public int getExistencia()
            {
                return this.existencia;
            }

            public String getDescripcion()
            {
                return this.descripcion;
            }

            public String getEspecificaciones()
            {
                return this.especificaciones;
            }

            public DateTime getFechaIngreso()
            {
                return this.fechaIngreso;
            }

            public int getIdCategoria()
            {
                return this.idCategoria;
            }

            public int getEstado()
            {
                return this.estado;
            }

            #endregion
        }

        #endregion

        #region CLASE CONTROL MEDICAMENTOS
         public class medicamentosControler : Medicamentos
         {
                DB ObjDB = new DB();

                //Metodo cargar nuevo id Medicamento
                public int cargarNuevo_IdMedicamento()
                {
                    int idmed = 0;
                    ArrayList lista = ObjDB.Listar_SQL("SELECT MAX(id) FROM Productos");
                    if (lista.Count >= 1)
                    {
                        idmed = Int32.Parse(lista[0].ToString()) + 1;
                    }
                    return idmed;
                }

                //Metodo guardar nuevo Medicamento
                public void guardar_NuevoMedicamento()
                {
                    String sql = "INSERT INTO Productos VALUES('" + base.getNombreMedicamento() + "','" + base.getPrecioVenta()+ "','" + 
                        base.getPrecioCompra() + "',CONVERT(DATETIME,'" + string.Format("{0:dd/MM/yyyy}", base.getFechaCaducidad()) + "',103),'" + base.getExistencia() + "','" +
                        base.getDescripcion() + "','" + base.getEspecificaciones() + "',CONVERT(DATETIME,'" + string.Format("{0:dd/MM/yyyy}", base.getFechaIngreso()) + "',103),'" +
                        base.getIdCategoria() + "','" + base.getEstado() + "');";
                    ObjDB.Ejecutar_SQL(sql);
                }


                //Metodo modificar Medicamentos
                public void Actualizar_Medicamento()
                {
                    String sql = "UPDATE Productos SET nombre_producto='" + base.getNombreMedicamento() + "', precio_venta='" + base.getPrecioVenta() + "', precio_compra='" +
                        base.getPrecioCompra() + "', caducidad=" + "CONVERT(DATETIME,'" + string.Format("{0:dd/MM/yyyy}", base.getFechaCaducidad()) + "',103)" + ", existencia='" + base.getExistencia() + "', descripcion='" +
                        base.getDescripcion() + "', especificaciones='" + base.getEspecificaciones() + "', fecha_ingreso=" + "CONVERT(DATETIME,'" + string.Format("{0:dd/MM/yyyy}", base.getFechaIngreso()) + "',103)" + ", id_categoria='" +
                        base.getIdCategoria() + "', estado='" + base.getEstado() + "' WHERE id='" + base.getId() + "';";
                    ObjDB.Ejecutar_SQL(sql);
                }


                //Metodo eliminar Medicamento
                public void Eliminar_Medicamento()
                {
                    String sql = "UPDATE Productos SET estado='0' WHERE id='" + base.getId() + "'";
                    ObjDB.Ejecutar_SQL(sql);
                }

                //Metodo eliminar Medicamentos eliminados
                public void Eliminar_MedicamentoEliminados()
                {
                    String sql = "DELETE Productos  WHERE id='" + base.getId() + "'";
                    ObjDB.Ejecutar_SQL(sql);
                }

                //Metodo listar Medicamentos
                public DataTable listarMedicamentos(DataTable tabla)
                {
                    string sql = "select * from productos WHERE estado='1' and nombre_producto LIKE '%" + base.getNombreMedicamento() + "%'";
                    return ObjDB.SelectRows(tabla, sql);
                }

                //Metodo listar Medicamentos Eliminados
                public DataTable listarMedicamentos_Eliminados(DataTable tabla)
                {
                    string sql = "select * from productos WHERE estado='0'";
                    return ObjDB.SelectRows(tabla, sql);
                }


            }
            #endregion

     }

    //Layer Busqueda 
    namespace LayerBusqueda
    {

        public class Busqueda
        {

            private int selector;
            private int busquedaPor;
            private string busqueda;
            private DateTime fechaInicial;
            private DateTime fechaFinal;

            public int MySelector
            {
                get { return selector; }
                set { selector = value; }
            }

            public int MyBusquedaPor
            {
                get { return busquedaPor; }
                set { busquedaPor = value; }
            }

            public string MyBusqueda
            {
                get { return busqueda; }
                set { busqueda = value; }
            }

            public DateTime MyFechaInicial
            {
                get { return fechaInicial; }
                set { fechaInicial = value; }
            }

            public DateTime MyFechaFinal
            {
                get { return fechaFinal; }
                set { fechaFinal = value; }
            }
        }

        public class BusquedaControl : Busqueda
        {

            DB objDB = new DB();

            public DataTable buscarProductos(DataTable datatable)
            {
                string sql = "select * from Productos where nombre_producto LIKE '" + base.MyBusqueda.ToString() + "%';";
                return objDB.SelectRows(datatable, sql);
            }

            public DataTable buscarUsuario(DataTable datatable)
            {
                string sql = "select * from usuarios where usuario LIKE '" + base.MyBusqueda.ToString() + "%'";
                return objDB.SelectRows(datatable, sql);
            }

            public DataTable verificarBusqueda(DataTable datatable)
            {
                switch (base.MySelector)
                {
                    case 0:
                        break;
                    case 1:
                        return buscarProductos(datatable);
                    case 2:
                        break;
                    case 3:
                        return buscarUsuario(datatable);
                }
                return null;
            }

        }
    }

    //Layer Venta
    namespace LayerVenta
    {
        #region CLASE VENTAS
        public class venta : detalleVentas
        {
           private int id;
           private String serie;
           private DateTime fecha;
           private int tipo;
           private int idUser;
           private int idcli;
           private int idFarmacia;
           private decimal subtTotal;
           private decimal igv;
           private decimal des;
           private decimal total;
           private int estado;
           

           //Metodos set
           #region //Metodos set
           public void setId(int miId)
           {
               this.id = miId;
           }

           public void setSerie(String miSerie)
           {
               this.serie = miSerie;
           }

           public void setFecha(DateTime miFecha)
           {
               this.fecha = miFecha;
           }

           public void setTipo(int miTipo)
           {
               this.tipo = miTipo;
           }

           public void setIdUser(int midUser)
           {
               this.idUser = midUser;
           }

           public void setIdcli(int miIdcli)
           {
               this.idcli = miIdcli;
           }

           public void setIdFarmacia(int miIdFarmacia)
           {
               this.idFarmacia = miIdFarmacia;
           }
          
           public void setSubTotal(decimal miSubTotal)
           {
               this.subtTotal = miSubTotal;
           }
           public void setIgv(decimal miIgv)
           {
               this.igv = miIgv;
           }

           public void setDesc(Decimal miDesc)
           {
               this.des = miDesc;
           }

           public void setTotal(decimal miTotal)
           {
               this.total= miTotal;
           }
           public void setEstado(int miEstado)
           {
               this.estado = miEstado;
           }
           #endregion

           //metodos get
           #region Metodo get
           public int getId()
           {
               return id;
           }

           public String getSerie()
           {
               return this.serie;
           }
           public DateTime getFecha()
           {
               return fecha;
           }
           public int getTipo()
           {
               return this.tipo;
           }
           public int getIdUser()
           {
               return this.idUser;
           }
           public int getIdcli()
           {
               return this.idcli;
           }

           public int getIdFarmacia()
           {
               return this.idFarmacia;
           }
          
           public decimal getSubttotal()
           {
               return this.subtTotal;
           }

           public decimal getDesc()
           {
               return this.des;
           }
           public decimal getIgv()
           {
               return this.igv;
           }
           public decimal getTotal()
           {
               return this.total;
           }
           public int getEstado()
           {
               return this.estado;
           }

           #endregion

        }
        #endregion

        #region CLASE DETALLE VENTAS
        public class detalleVentas
        {
            private String serieDV;
            private int idProducto;
            private String descripcion;
            private decimal precio;
            private int cantidad;
            private decimal totalDV;
            private int estadoDV;

            //Metodos Set
            #region Metodos set
            public void setserieDV(String miserieDV)
            {
                this.serieDV = miserieDV;
            }

            public void setIdProducto(int miIdProducto)
            {
                this.idProducto = miIdProducto;
            }

            public void setDescripcion(String miDescripcion)
            {
                this.descripcion = miDescripcion;
            }

            public void setPrecio(Decimal miPrecio)
            {
                this.precio = miPrecio;
            }

            public void setCantidad(int miCant)
            {
                this.cantidad = miCant;
            }

            public void setTotalDV(Decimal miTotalDV)
            {
                this.totalDV = miTotalDV;
            }

            public void setEstadoDV(int miEstadoDV)
            {
                this.estadoDV = miEstadoDV;
            }
            #endregion

            //Metodos Get
            #region Metodos Get
            public String getSerieDV()
            {
                return this.serieDV; 
            }

            public int getIdProducto()
            {
                return this.idProducto;
            }

            public String getDescripcion()
            {
                return descripcion;
            }

            public Decimal getPrecio()
            {
                return this.precio;
            }

            public int getCantidad()
            {
                return this.cantidad;
            }

            public Decimal getTotalDV()
            {
                return this.totalDV;
            }

            public int getEstadoDV()
            {
                return this.estadoDV;
            }
            #endregion

        }
        #endregion

        #region CLASE CONTROL VENTAS
        public class ventaControler : venta
        {
            DB ObjDB = new DB();

            //Metodo cargar nuevo id Ventas
            public string cargarNuevo_IdVenta()
            {
                String idVent = "";
                ArrayList lista = ObjDB.Listar_SQL("SELECT MAX(serie) FROM ventas");
                if (lista.Count > 0 || lista != null)
                    idVent = (lista[0].ToString());
                else
                    idVent = "00000";
                return idVent;
            }

            public int buscarIDCliente(string nombreCliente) {
                int id = 0;
                ArrayList lista = ObjDB.Listar_SQL("SELECT id FROM Clientes where nombres='" + nombreCliente + "';");
                if (lista.Count > 0)
                    id = Int32.Parse(lista[0].ToString());
                return id;
            }

            public int getCantidadProducto(int idProducto)
            {
                int id = 0;
                ArrayList lista = ObjDB.Listar_SQL("SELECT existencia FROM Productos where id='" + idProducto + "';");
                if (lista.Count > 0)
                    id = Int32.Parse(lista[0].ToString());
                return id;
            }

            public int setCantidadProducto(int idProducto, int cantidad)
            {
                int id = 0;
                ArrayList lista = ObjDB.Listar_SQL("UPDATE Productos set existencia='" + cantidad + "' where id='" + idProducto + "';");
                if (lista.Count > 0)
                    id = Int32.Parse(lista[0].ToString());
                return id;
            }

            //Metodo Guardar Detalle VENTA
            public void guardar_NuevaDetalleVenta()
            {
                String sql = "INSERT INTO DetalleVenta(serie,idProducto,descripcion,precio,cantidad,total) VALUES('" + 
                    base.getSerieDV() + "','" + base.getIdProducto() + "','" + base.getDescripcion() + "','" +
                    base.getPrecio() + "','" + base.getCantidad() + "','" + base.getTotalDV() + "')";
                ObjDB.Ejecutar_SQL(sql);
            }
        
            //Metodo guardar nuevo Venta
            public void guardar_NuevoVenta()
            {
                String sql = "INSERT INTO Ventas(serie,idUsuario,idFarmacia,fecha,tipo,subtotal,descuento,igv,total) VALUES('" +
                    base.getSerie() + "','" + base.getIdUser() + "','" + base.getIdFarmacia() + "',GETDATE(),'" + 
                    base.getTipo() + "','" + base.getSubttotal() + "','" + base.getDesc() + "','" + base.getIgv() +
                    "','" + base.getTotal() + "');";
                ObjDB.Ejecutar_SQL(sql);
            }

            //Metodo eliminar Detalle Venta
            public void Eliminar_DetalleVenta()
            {
                String sql = "UPDATE  DetalleVenta SET estado='0' WHERE serie='" + base.getSerieDV() + "'";
                ObjDB.Ejecutar_SQL(sql);
            }

            

            //Metodo eliminar Ventas
            public void Eliminar_Venta()
            { 
                String sql = "UPDATE ventas SET estado='0' WHERE serie='" + base.getSerie() + "'";
                ObjDB.Ejecutar_SQL(sql);
            }

            //Metodo elilimar Ventas eliminadas
            public void Eliminar_Venta_Eliminada()
            {
                String sql = "DELETE ventas WHERE serie='"+base.getSerie()+"'";
                ObjDB.Ejecutar_SQL(sql);
            }

            //Metodo eliminar detalle venta eliminada
            public void Eliminar_Detalle_Venta_Eliminada()
            {
                String sql = "DELETE DetalleVenta WHERE serie='" + base.getSerieDV() + "'";
                ObjDB.Ejecutar_SQL(sql);
            }
            //Metodo listar Ventas
            public DataTable listarVentas(DataTable tabla)
            {
                string sql = "select * from Ventas WHERE estado='1' and serie LIKE '%" + base.getSerie() + "%'";
                return ObjDB.SelectRows(tabla, sql);
            }

            //Metodo listar Detalle ventas
            public DataTable listarDetalleVentas(DataTable tabla)
            {
                string sql = "select * from DetalleVenta WHERE estado='0'";
                return ObjDB.SelectRows(tabla, sql);
            }
            
        }
        #endregion
    }
   }
    
