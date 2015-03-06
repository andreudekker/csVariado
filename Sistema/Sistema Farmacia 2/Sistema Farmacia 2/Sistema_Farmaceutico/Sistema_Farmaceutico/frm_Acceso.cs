using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LayerControler.LayerUsuario;

using System.Collections;
using System.Data.SqlClient;

namespace Sistema_Farmaceutico
{
    public partial class frm_Acceso : Form
    {
        UsuarioControl objControlUsuario;

        public frm_Acceso()
        {
            InitializeComponent();
            objControlUsuario = new UsuarioControl();
        }

        #region Diseño de los textbox
        private void txtUser_Leave(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.Linen;
            txtUser.ForeColor = Color.Black;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.Linen;
            txtPass.ForeColor = Color.Black;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.LemonChiffon;
            txtUser.ForeColor = Color.Black;
            txtUser.SelectAll();
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.LemonChiffon;
            txtPass.ForeColor = Color.Black;
            txtPass.SelectAll();
        }
        #endregion 

        #region Evento Load
        private void frm_Acceso_Load(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(txtUser, "Ingrese Usuario");
            this.toolTip1.SetToolTip(txtPass, "Ingrese Password");
            this.toolTip1.SetToolTip(button1, "Iniciar Sesion");
            this.toolTip1.SetToolTip(button2, "Salir de Aplicacion");
            this.groupBox1.Visible = true;
            progressBar1.Visible = true;
            label3.Visible = true;
            groupBox1.Visible = false;
            timer1.Start();
            listarFamacias();
        }
        #endregion

        #region Salir del sistema
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void iniciarSesion()
        {
            if (!string.Empty.Equals(this.txtUser.Text) && !string.Empty.Equals(this.txtPass.Text))
            {
                objControlUsuario.setNomUser(this.txtUser.Text.Trim());
                objControlUsuario.setPassUser(this.txtPass.Text.Trim());
                int estado = objControlUsuario.Iniciar_Sesion();
                switch (estado)
                {
                    case 0:
                        MessageBox.Show("El usuario ingresado no es correcto.", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Actualizar_Contador();
                        break;
                    case 1:
                        Anular_Contador();
                        // objControlUsuario = null; // liberamos el objeto de la memoria
                        frm_Principal ventana = new frm_Principal(this.txtUser.Text.Trim(), this,this.comboBox1.SelectedItem.ToString());
                        ventana.Show();
                        this.Hide();
                        Limpiar_Form();
                        break;
                    case 2:
                        MessageBox.Show("La contraseña ingresada no es correcta.", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Actualizar_Contador();
                        break;
                    case 3:
                        MessageBox.Show("La cuenta '" + this.txtUser.Text.Trim() + "' esta deshabilitado. ", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
                Verificar_Contador();
            }
            else
            {
                MessageBox.Show("Ingrese sus datos de usuario correctamente.", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void listarFamacias(){
            ArrayList lista = objControlUsuario.cargarListaFarmacia();
            if (lista != null)
                for (int i = 1; i < lista.Count; i += 3)
                    this.comboBox1.Items.Add(lista[i].ToString());
            this.comboBox1.SelectedIndex = 0;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            iniciarSesion();
        }

        private void Actualizar_Contador() {
            lblContador.Text = (Int32.Parse(lblContador.Text) + 1).ToString();
            lblInformacion.Text = "Intentos Fallidos: " + lblContador.Text;
            lblInformacion.Visible = true;
        }

        private void Anular_Contador() {
            lblContador.Text = "0";
            lblInformacion.Visible = false;
        }

        private void Verificar_Contador()
        {
            if (Int32.Parse(lblContador.Text) == 3)
            {
                MessageBox.Show("Alcanzo el limite de intentos fallidos permitidos.", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
        }

        private void Limpiar_Form()
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void frm_Acceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicacion?", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(20);
            if (this.progressBar1.Value == 100)
            {
                this.Opacity -= 0.07;
            }
            if (this.Opacity == 0.0)
            {
               this.timer1.Enabled = false;
               this.groupBox2.Visible = false;
               progressBar1.Visible = false;
               label3.Visible = false;
               this.Opacity = 100;
               groupBox1.Visible = true;
            }
            if (this.progressBar1.Value == 0 || this.progressBar1.Value == 20 || progressBar1.Value == 40 || progressBar1.Value == 60 || progressBar1.Value == 80)
            {
                label3.Text = "Cargando...";
            }
            else if (this.progressBar1.Value == 10 || this.progressBar1.Value == 30 || progressBar1.Value == 50 || progressBar1.Value == 70 || progressBar1.Value == 90)
            {
                label3.Text = "Bienvenido...";
            }
            else if (progressBar1.Value == 97)
            {
                label3.Text = "Proceso Terminado...";
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                iniciarSesion();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      }
}
