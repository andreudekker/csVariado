using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LayerControler.Validar;
using LayerControler.LayerUsuario;

namespace Sistema_Farmaceutico
{
    public partial class frm_Usuario : Form
    {

        // Cargar clase para desactivar Boton Cerrar
        DisableButton ObjDisableButton = new DisableButton();

        UsuarioControl objUsuarioControl = new UsuarioControl();
        frm_Principal frmPrincipal;
        DataTable tblUsuarios = new DataTable();
        Boolean guardar = false;

        public frm_Usuario(frm_Principal frm)
        {
            InitializeComponent();
            frmPrincipal = frm;
            // cargar eventos
            //frm.Salir += new frm_Principal.Enviar(delegate(string t) { salir(t); });
            frm.Salir += new frm_Principal.Enviar(btn_Salir);
            frm.Cancelar += new frm_Principal.Enviar(btn_Cancelar);
            frm.Nuevo += new frm_Principal.Enviar(btn_Nuevo);
            frm.Guardar += new frm_Principal.Enviar(btn_Guardar);
            frm.Buscar += new frm_Principal.Enviar(btn_Buscar);
            frm.Eliminar += new frm_Principal.Enviar(btn_Eliminar);
            frm.Modificar += new frm_Principal.Enviar(btn_Modificar);
        }

        #region Diseño textBox
      
        private void txtNom_Enter(object sender, EventArgs e)
        {
            txtNom.BackColor = Color.LemonChiffon;
            txtNom.ForeColor = Color.Black;
            txtNom.SelectAll();
        }


        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.LemonChiffon;
            txtPass.ForeColor = Color.Black;
            txtPass.SelectAll();
        }

        private void cboNivel_Enter(object sender, EventArgs e)
        {
            cboNivel.BackColor = Color.LemonChiffon;
            cboNivel.ForeColor = Color.Black;
            cboNivel.SelectAll();
        }

        private void cboStatus_Enter(object sender, EventArgs e)
        {
            cboStatus.BackColor = Color.LemonChiffon;
            cboStatus.ForeColor = Color.Black;
            cboStatus.SelectAll();
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            txtNom.BackColor = Color.Linen;
        }


        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.Linen;
        }

        private void cboNivel_Leave(object sender, EventArgs e)
        {
            cboNivel.BackColor = Color.Linen;
        }

        private void cboStatus_Leave(object sender, EventArgs e)
        {
            cboStatus.BackColor = Color.Linen;
        }

       

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }

        private void txtNomUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }

        private void txtUsu_Enter(object sender, EventArgs e)
        {
            txtUsu.BackColor = Color.LemonChiffon;
            txtUsu.ForeColor = Color.Black;
            txtUsu.SelectAll();
        }

        private void txtUsu_Leave(object sender, EventArgs e)
        {
            txtUsu.BackColor = Color.Linen;
        }
        private void txtNomUser_Enter(object sender, EventArgs e)
        {
            txtNomUser.SelectAll();
            txtNomUser.BackColor = Color.LemonChiffon;
            txtNomUser.ForeColor = Color.Black;

        }

        private void txtNomUser_Leave(object sender, EventArgs e)
        {
            txtNomUser.BackColor = Color.LemonChiffon;
        }

        private void txtNomUser_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }
     
       
	#endregion

        #region Validacion Con Error Provider

        //Validar Cajas de texto
        private void validarErrorProviderCajas(TextBox caja ,String mens)
        {
            if (caja.Text == "")
            {
                this.errorProvider1.SetError(caja, mens);
                caja.Focus();
            }
            else
            {
                this.errorProvider1.SetError(caja,null );
                //txtUsu.Focus();
            }
        }


        //Validar combos
        private void validarErrorProviderCombos(ComboBox combo, String mens)
        {
            if (combo.Text == "")
            {
                this.errorProvider1.SetError(combo, mens);
                combo.Focus();
            }
            else
            {
                this.errorProvider1.SetError(combo, null);
            }
        }

        private void txtNom_Validated(object sender, EventArgs e)
        {
            validarErrorProviderCajas(txtNom, "El Nombre es obligatorio");
        }

        private void txtUsu_Validated(object sender, EventArgs e)
        {
            validarErrorProviderCajas(txtUsu, "Cuenta de usuario es obligatorio");
        }

        private void txtPass_Validated(object sender, EventArgs e)
        {
            validarErrorProviderCajas(txtPass, "Password es obligatorio");
        }

        private void cboNivel_Validated(object sender, EventArgs e)
        {
            validarErrorProviderCombos(cboNivel, "Seleccione nivel es obligatorio");
        }

        private void cboStatus_Validated(object sender, EventArgs e)
        {
            validarErrorProviderCombos(cboStatus, "Seleccione estado es obligatorio");
        }
        #endregion

        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(txtId, "Codigo Usuario");
            this.toolTip1.SetToolTip(txtNom, "Nombre Usuario");
            this.toolTip1.SetToolTip(txtUsu, "Cuenta Usuario");
            this.toolTip1.SetToolTip(txtPass, "Password Usuario");
            this.toolTip1.SetToolTip(cboNivel, "Seleccione Nivel");
            this.toolTip1.SetToolTip(cboStatus, "Seleccione Estado");
            this.toolTip1.SetToolTip(groupBox6, "Datos Usuario");
            this.toolTip1.SetToolTip(groupBox5, "Buscar Usuario");
            this.toolTip1.SetToolTip(txtNomUser, "Ingrese Nombre Usuario");
            this.toolTip1.SetToolTip(this.dataGridView1, "Seleccione un de los Usuario");
            ObjDisableButton.DisableCloseButton(this.Handle.ToInt32());
            // Seleccion por defecto de las Listas
            cboNivel.SelectedIndex = 0;
            cboStatus.SelectedIndex = 1;
            groupBox6.Visible = true;
            groupBox5.Visible = false;
            Deshabilitar_Controles();
        }

        //Metodo Nuevo
        public void btn_Nuevo(String mensaje)
        {
            if (mensaje == "Usuario")
            {
                Cargar_ID();
                
                Habilitar_Controles();
                groupBox6.Visible = true;
                groupBox5.Visible = false;
                Limpiar_Form();
                txtNom.Focus();
                guardar = false;
            }
        }

        //Metodo Guardar Y actualizar
        public void btn_Guardar(String mensaje)
        {
            if (mensaje == "Usuario")
            {
                if (guardar==false)
                {
                    try
                    {
                        if (!String.Empty.Equals(txtNom.Text) && !String.Empty.Equals(txtUsu.Text) && !String.Empty.Equals(txtPass.Text))
                        {
                            objUsuarioControl.setNombre(this.txtNom.Text.Trim());
                            objUsuarioControl.setNomUser(this.txtUsu.Text.Trim());
                            objUsuarioControl.setPassUser(this.txtPass.Text.Trim());
                            objUsuarioControl.setNivel(Byte.Parse(this.cboNivel.SelectedIndex.ToString()));
                            objUsuarioControl.setEstado(Byte.Parse(this.cboStatus.SelectedIndex.ToString()));
                            objUsuarioControl.Guardar_Nuevo_Usuario();
                            MessageBox.Show("Registro guardado correctamente.", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Deshabilitar_Controles();
                            Limpiar_Form();
                            guardar = false;
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar los datos correctamente.\nTodos los datos son abligatorios.", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else if (guardar == true)
                {
                    try
                    {
                        if (!String.Empty.Equals(txtNom.Text) && !String.Empty.Equals(txtUsu.Text) && !String.Empty.Equals(txtPass.Text))
                        {
                            objUsuarioControl.setId(int.Parse(txtId.Text).ToString());
                            objUsuarioControl.setNombre(this.txtNom.Text);
                            objUsuarioControl.setNomUser(this.txtUsu.Text);
                            objUsuarioControl.setPassUser(this.txtPass.Text);
                            objUsuarioControl.setNivel(Byte.Parse(this.cboNivel.SelectedIndex.ToString()));
                            objUsuarioControl.setEstado(Byte.Parse(this.cboStatus.SelectedIndex.ToString()));
                            objUsuarioControl.Modificar_Usuario();
                            MessageBox.Show("Registro Actualizado correctamente.", "Actualizar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Deshabilitar_Controles();
                            Limpiar_Form();
                            guardar = false;
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar los datos correctamente.\nTodos los datos son abligatorios.", "Actualizar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        //Metodo Editar
        public void btn_Modificar(String mensaje)
        {
            if (mensaje == "Usuario")
            {
                if (guardar == true)
                {
                    Habilitar_Controles();
                    txtNom.Focus();
                    guardar = true;
                    cboStatus.Enabled = false;
                }
            }
        }

       
        //Metodo Buscar
        public void btn_Buscar(String mensaje)
        {
            if (mensaje == "Usuario")
            {
                Deshabilitar_Controles();
                Limpiar_Form();
                tblUsuarios.Clear();
                objUsuarioControl.setNombre(txtNomUser.Text);
                objUsuarioControl.Buscar_Usuario(tblUsuarios);
                groupBox6.Visible = false;
                groupBox5.Visible = true;
                txtNomUser.Focus();
                guardar = true;
            }
        }

        //Metodo Eliminar
        public void btn_Eliminar(String mensaje)
        {
            if (mensaje == "Usuario")
            {
                if (guardar==true)
                {
                    try
                    {
                        objUsuarioControl.setId(Int32.Parse(this.txtId.Text.Trim()).ToString());
                        objUsuarioControl.Eliminar_Usuario();
                        MessageBox.Show("Registro eliminado correctamente.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Deshabilitar_Controles();
                        txtId.Text = "0000";
                        Limpiar_Form();
                        guardar = false;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        //Metodo Cancelar
        public void btn_Cancelar(String mensaje)
        {
            if (mensaje == "Usuario")
            {
                groupBox6.Visible = true;
                groupBox5.Visible = false;
                Deshabilitar_Controles();
                Limpiar_Form();
                guardar = false;
            }
        }

        //Metodo Salir
        public void btn_Salir(String mensaje)
        {
            if (mensaje == "Usuario")
            {
                frmPrincipal.Salir -= new frm_Principal.Enviar(btn_Salir);
                frmPrincipal.Cancelar -= new frm_Principal.Enviar(btn_Cancelar);
                frmPrincipal.Nuevo -= new frm_Principal.Enviar(btn_Nuevo);
                frmPrincipal.Guardar -= new frm_Principal.Enviar(btn_Guardar);
                frmPrincipal.Buscar -= new frm_Principal.Enviar(btn_Buscar);
                frmPrincipal.Eliminar -= new frm_Principal.Enviar(btn_Eliminar);
                frmPrincipal.Modificar -= new frm_Principal.Enviar(btn_Modificar);
                this.Close();
            }
        }

       
        //Cargar id nuevo
        private void Cargar_ID() {
            try
            {
                int id = objUsuarioControl.Cargar_ID_Nuevo_Usuario();
                txtId.Text = string.Format("{0:0000}", id);
             }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //Limpiar Controles
        private void Limpiar_Form() {
            txtNom.Clear();
            txtUsu.Clear();
            txtPass.Clear();
            cboNivel.SelectedIndex = 0;
            cboStatus.SelectedIndex = 1;
          }
        //Deshabilitar Controles
        private void Deshabilitar_Controles() {
            txtNom.Enabled = false;
            txtUsu.Enabled = false;
            txtPass.Enabled = false;
            cboNivel.Enabled = false;
            cboStatus.Enabled = false;
        }

        //Hailitar Controles
        private void Habilitar_Controles()
        {
            txtNom.Enabled = true;
            txtUsu.Enabled = true;
            txtPass.Enabled = true;
            cboNivel.Enabled = true;
            cboStatus.Enabled = true;
        }

        //Evento changed de caja de texto para filtrar
        private void txtNomUser_TextChanged(object sender, EventArgs e)
        {
            // Buscar Usuarios
            tblUsuarios.Clear();
            objUsuarioControl.setNomUser(this.txtNomUser.Text.Trim());
            dataGridView1.DataSource = objUsuarioControl.Buscar_Usuario(tblUsuarios);
        }

        //Obtener el index de la fila selecionada de Datagridview
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Deshabilitar_Controles();
            Limpiar_Form();
            Seleccionar_Usuario(e.RowIndex);
            groupBox6.Visible = true;
            groupBox5.Visible = false;
            cboStatus.Enabled = false;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void Seleccionar_Usuario(int RowIndex) {
            this.txtId.Text = string.Format("{0:0000}", Int32.Parse(this.dataGridView1.Rows[RowIndex].Cells[0].Value.ToString()));
            this.txtNom.Text = this.dataGridView1.Rows[RowIndex].Cells[1].Value.ToString();
            this.txtUsu.Text = this.dataGridView1.Rows[RowIndex].Cells[2].Value.ToString();
            this.txtPass.Text = objUsuarioControl.Desencriptar(this.dataGridView1.Rows[RowIndex].Cells[3].Value.ToString());
            this.cboNivel.SelectedIndex = Int32.Parse(this.dataGridView1.Rows[RowIndex].Cells[4].Value.ToString());
            this.cboStatus.SelectedIndex = Int32.Parse(this.dataGridView1.Rows[RowIndex].Cells[5].Value.ToString());
        }

       
        
    }
}
