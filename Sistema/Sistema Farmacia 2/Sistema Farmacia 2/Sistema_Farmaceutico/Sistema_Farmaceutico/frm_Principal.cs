using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WPFTaskbarNotifier;
using WPFTaskbarNotifierExample;
using System.Media;

using System.Reflection;
using Microsoft.VisualBasic;

using LayerControler.LayerUsuario;

namespace Sistema_Farmaceutico
{
    public partial class frm_Principal : Form
    {
        public delegate void Enviar(String mensaje);
        public event Enviar Nuevo;
        public event Enviar Guardar;
        public event Enviar Buscar;
        public event Enviar Eliminar;
        public event Enviar Modificar;
        public event Enviar Cancelar;
        public event Enviar Salir;

        UsuarioControl objControlUsuario = new UsuarioControl();
        EffectWindow objEffectWindow = new EffectWindow();

        public int idUsuario;
        public int idFarmacia;

        Form frm_acceso;


        #region WindowTaskBarNotifier

        private WPFTaskbarNotifierExample.ExampleTaskbarNotifier taskbarNotifier;
        public WPFTaskbarNotifierExample.ExampleTaskbarNotifier TaskbarNotifier
        {
            get { return this.taskbarNotifier; }
        }

        #endregion

        public frm_Principal(string usuario, Form frm, string Farmacia)
        {
            this.taskbarNotifier = new WPFTaskbarNotifierExample.ExampleTaskbarNotifier();
            this.taskbarNotifier.Topmost = true;
            this.taskbarNotifier.IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(taskbarNotifier_IsVisibleChanged);
            InitializeComponent();
            // cargar IDs
            idUsuario = objControlUsuario.buscarID(true, usuario);
            idFarmacia = objControlUsuario.buscarID(false, Farmacia);
            frm_acceso = frm;
            toolStripFarmacia.Text = "Farmacia: " + Farmacia;
            toolStripUsuario.Text = "Usuario: " + usuario;
            objControlUsuario.setNomUser(usuario);
            toolStripNivel.Text = "Nivel: " + objControlUsuario.Cargar_Nivel_Usuario();
            toolStripFecha.Text = DateTime.Now.Date.ToLongDateString();
            timer1.Start();
            objControlUsuario = null;
            this.BackgroundImage = Sistema_Farmaceutico.Properties.Resources.fondo;
        }

        public frm_Principal() {
            InitializeComponent();
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Assembly asm = Assembly.GetExecutingAssembly();
        //    Bitmap imagenFondo = new Bitmap(asm.GetManifestResourceStream("fondo.jpeg"));
        //    e.Graphics.DrawImage(imagenFondo, this.ClientRectangle, new Rectangle(0, 0, imagenFondo.Width, imagenFondo.Height), GraphicsUnit.Pixel);
        //}

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Venta frmVenta = new frm_Venta(this);
            Verificar_Instancia_Form(frmVenta);
        }


        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar Sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_acceso.Show();
                this.Dispose();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Usuario frmUsuario = new frm_Usuario(this);
            Verificar_Instancia_Form(frmUsuario);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicacion? \nEsta accion cerrara la sesion actual.", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                frm_acceso.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripHora.Text = DateTime.Now.Date.ToShortDateString();
        }


        public String Vincular_Accion()
        {
            Form child = this.ActiveMdiChild;
            return child.Text;
        }

        #region Eventos de la Botonera

        private void tstNuevo_Click(object sender, EventArgs e)
        {
            if (Nuevo != null)
            {
                this.Nuevo(Vincular_Accion());
            }
            else { Mensaje_Error_Accion(); }
        }

        private void tstGuardar_Click(object sender, EventArgs e)
        {
            if (Guardar != null)
            {
                this.Guardar(Vincular_Accion());
            }
            else { Mensaje_Error_Accion(); }
        }

        private void tstBuscar_Click(object sender, EventArgs e)
        {
            if (Buscar != null)
            {
                this.Buscar(Vincular_Accion());
            }
            else { Mensaje_Error_Accion(); }
        }

        private void tstEliminar_Click(object sender, EventArgs e)
        {
            if (Eliminar != null)
            {
                this.Eliminar(Vincular_Accion());
            }
            else { Mensaje_Error_Accion(); }
        }

        private void tstModificar_Click(object sender, EventArgs e)
        {
            if (Modificar != null)
            {
                this.Modificar(Vincular_Accion());
            }
            else { Mensaje_Error_Accion(); }
        }

        private void tstCancelar_Click(object sender, EventArgs e)
        {
            if (Cancelar != null)
            {
                this.Cancelar(Vincular_Accion());
            }
            else { Mensaje_Error_Accion(); }
        }

        private void tstSalir_Click(object sender, EventArgs e)
        {
            if (Salir != null)
            {
                this.Salir(Vincular_Accion());
            }
            else { Mensaje_Error_Accion(); }
        }

        #endregion

        private void Verificar_Instancia_Form(Form frm)
        {
            bool IsFormLoaded = false;
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                // Crear una instancia temporal de un formulario hijo.
                Form tempChild = (Form)this.MdiChildren[x];
                if (tempChild.Name == frm.Name)
                {
                    if (tempChild.WindowState == FormWindowState.Minimized)
                    {
                        tempChild.WindowState = FormWindowState.Normal;
                        Mostrar_Ventana(tempChild);
                    }
                    else
                    {
                        tempChild.BringToFront();
                        Mostrar_Ventana(tempChild);
                    }
                    // Existe una instancia de la clase frm.
                    IsFormLoaded = true;
                }
                // Interrumpimos el bucle.
                if (IsFormLoaded == true) break;
            }
            // Si NO existe una instancia, se crea una nueva instancia.
            if (IsFormLoaded == false)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Mostrar_Ventana(Form tempChild)
        {
            tempChild.Location = new Point(((Screen.PrimaryScreen.WorkingArea.Width / 2) - (tempChild.Size.Width / 2)), ((Screen.PrimaryScreen.WorkingArea.Height - 120) / 2) - (tempChild.Size.Height / 2));
            SystemSounds.Beep.Play();
            objEffectWindow.Activar_Parpadeo(tempChild);
        }

        private void Mensaje_Error_Accion()
        {
            MessageBox.Show("No se ha encontrado ninguna ventana activa! \nAsegurece de que haya una ventana interna activa para vincular la accion correspondiente.", "Accion de vinculacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frm_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.N) // Tecla N
            {
                if (Salir != null)
                {
                    Nuevo(Vincular_Accion());
                }
            }

            if (e.Control && e.Alt && e.KeyCode == Keys.G) // Tecla G
            {
                if (Guardar != null)
                {
                    Guardar(Vincular_Accion());
                }
            }

            if (e.Control && e.Alt && e.KeyCode == Keys.B) // Tecla B
            {
                if (Buscar != null)
                {
                    Buscar(Vincular_Accion());
                }
            }

            if (e.Control && e.Alt && e.KeyCode == Keys.E) // Tecla E
            {
                if (Eliminar != null)
                {
                    Eliminar(Vincular_Accion());
                }
            }

            if (e.Control && e.Alt && e.KeyCode == Keys.M) // Tecla M
            {
                if (Modificar != null)
                {
                    Modificar(Vincular_Accion());
                }
            }

            if (e.Control && e.Alt && e.KeyCode == Keys.C) // Tecla C
            {
                if (Cancelar != null)
                {
                    Cancelar(Vincular_Accion());
                }
            }

            if (e.Control && e.Alt && e.KeyCode == Keys.S) // Tecla S
            {
                if (Salir != null)
                {
                    Salir(Vincular_Accion());
                }
            }
        }

        private void frm_Principal_MdiChildActivate(object sender, EventArgs e)
        {
            try
            {
                this.toolStripProceso.Text = "Proceso: " + this.ActiveMdiChild.Text;
            }
            catch (NullReferenceException)
            {
                this.toolStripProceso.Text = "Proceso: ";
            }
        }

        void taskbarNotifier_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            this.taskbarNotifier.NotifyContent = null;
            this.taskbarNotifier.IsVisibleChanged -= new System.Windows.DependencyPropertyChangedEventHandler(taskbarNotifier_IsVisibleChanged);
        }

        

        private void registrarMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Medicamentos frm = new frm_Medicamentos(this);
            Verificar_Instancia_Form(frm);
        }

        private void medicamentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            WPFTaskbarNotifierExample.NotifyObject taskbar = new WPFTaskbarNotifierExample.NotifyObject("", "Hola ke tal");
            this.taskbarNotifier.NotifyContent.Add(taskbar);
            this.taskbarNotifier.StayOpenMilliseconds = 5000;
            this.taskbarNotifier.Show();
            this.taskbarNotifier.Notify();
            SystemSounds.Beep.Play();
            //frm_Busqueda v = new frm_Busqueda();
            //v.MdiParent = this;
            //v.Show();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
