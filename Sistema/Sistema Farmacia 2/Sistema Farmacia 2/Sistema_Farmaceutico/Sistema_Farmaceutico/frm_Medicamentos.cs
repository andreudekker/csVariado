using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LayerControler.LayerMedicamentos;
using LayerControler.Validar;
namespace Sistema_Farmaceutico
{
    public partial class frm_Medicamentos : Form
    {
        // Cargar clase para desactivar Boton Cerrar
        DisableButton ObjDisableButton = new DisableButton();
        medicamentosControler objMedControl = new medicamentosControler();
        frm_Principal frmPrincipal;
        DataTable tabla = new DataTable();
        Boolean guardar = false;

        public frm_Medicamentos(frm_Principal frm)
        {
            InitializeComponent();

            frmPrincipal = frm;
            // cargar eventos

            frm.Nuevo += new frm_Principal.Enviar(btnNuevo);
            frm.Guardar += new frm_Principal.Enviar(btnGuardar);
            frm.Buscar += new frm_Principal.Enviar(btnBuscar);
            frm.Eliminar += new frm_Principal.Enviar(btnEliminar);
            frm.Modificar += new frm_Principal.Enviar(btnActualizar);
            frm.Cancelar += new frm_Principal.Enviar(btnCancelar);
            frm.Salir += new frm_Principal.Enviar(btnSalir);
        }

        public frm_Medicamentos()
        {
            InitializeComponent();
        }

        //Metodo nuevo
        public void btnNuevo(String mesaje)
        {
            if (mesaje == "Medicamentos")
            {
                limpiarFormulario();
                habilitarControles();
                Cargar_ID();
                
                guardar = false;
                panel1.Visible = true;
                groupBox5.Visible = false;
                txtNombre.Focus();
            }
        }

        //Metodo btnGuardar
        public void btnGuardar(String mesaje)
        {
            if (mesaje == "Medicamentos")
            {
                if (guardar == false)
                {
                    try
                    {
                        objMedControl.setId(int.Parse(txtIdM.Text));
                        objMedControl.setNombreMedicamento(txtNombre.Text);
                        objMedControl.setPrecioVenta(double.Parse(txtPrecioVenta.Text));
                        objMedControl.setPrecioCompra(double.Parse(txtPrecioCompra.Text));
                        objMedControl.setExistencia(int.Parse(txtexistencia.Text));
                        objMedControl.setFechaCaducidad(dtpFechaCaducidad.Value);
                        objMedControl.setDescripcion(rtbDescripcion.Text);
                        objMedControl.setEspecificaciones(rtbEspecificaciones.Text);
                        objMedControl.setFechaIngreso(dtpFechaIngreso.Value);
                        objMedControl.setIdCategoria(int.Parse(cboCategoria.SelectedIndex.ToString()));
                        objMedControl.setEstado(int.Parse(cboEstado.SelectedIndex.ToString()));

                        if (txtNombre.Text != "")
                        {
                            objMedControl.guardar_NuevoMedicamento();
                            MessageBox.Show("Registro guardado correctamente.", "Guardar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                            desHabilitarControles();
                            limpiarFormulario();
                            guardar = false;
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar los datos correctamente.\nTodos los datos son abligatorios.", "Guardar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else if (guardar == true)
                {
                    try
                    {
                        objMedControl.setId(int.Parse(txtIdM.Text));
                        objMedControl.setNombreMedicamento(txtNombre.Text);
                        objMedControl.setPrecioVenta(double.Parse(txtPrecioVenta.Text));
                        objMedControl.setPrecioCompra(double.Parse(txtPrecioCompra.Text));
                        objMedControl.setExistencia(int.Parse(txtexistencia.Text));
                        objMedControl.setFechaCaducidad(Convert.ToDateTime(dtpFechaCaducidad.Value));
                        objMedControl.setDescripcion(rtbDescripcion.Text);
                        objMedControl.setEspecificaciones(rtbEspecificaciones.Text);
                        objMedControl.setFechaIngreso(Convert.ToDateTime(dtpFechaIngreso.Value));
                        objMedControl.setIdCategoria(int.Parse(cboCategoria.SelectedIndex.ToString()));
                        objMedControl.setEstado(int.Parse(cboEstado.SelectedIndex.ToString()));

                        if (txtNombre.Text != "")
                        {
                            objMedControl.Actualizar_Medicamento();
                            MessageBox.Show("Registro Actualizado correctamente.", "Actualizar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);                         
                            desHabilitarControles();
                            limpiarFormulario();
                            guardar = false;
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar los datos correctamente.\nTodos los datos son abligatorios.", "Actualizar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                
            }
        }


        //Metodo Modificar
        public void btnActualizar(String mesaje)
        {
            if (mesaje == "Medicamentos")
            {
                if (guardar == true)
                {
                    habilitarControles();
                    guardar = true;
                    txtNombre.Focus();
                    cboEstado.Enabled = false;
                }
            }
        }


        //Metodo Buscar
        public void btnBuscar(String mesaje)
        {
            if (mesaje == "Medicamentos")
            {
                if (guardar == false)
                {
                    desHabilitarControles();
                    limpiarFormulario();
                    tabla.Clear();
                    objMedControl.setNombreMedicamento(txtControl.Text);
                    dataGridView1.DataSource = objMedControl.listarMedicamentos(tabla);
                    this.Size = new Size(992, 544);
                    this.groupBox5.Visible = true;
                    this.panel1.Visible = false;
                    guardar = true;
                }
            }
        }

        //Metodo btnEliminar
        public void btnEliminar(String mesaje)
        {
            if (mesaje == "Medicamentos")
            {
                if(guardar==true){
                objMedControl.setId( int.Parse(txtIdM.Text));
                objMedControl.setEstado(int.Parse(cboEstado.SelectedIndex.ToString()));
                objMedControl.Eliminar_Medicamento();
                MessageBox.Show("Registro Eliminado correctamente.", "Eliminar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                desHabilitarControles();
                limpiarFormulario();
                guardar = false;
            }
            }
        }

        //Metodo btnCancelar
        public void btnCancelar(String mesaje)
        {
            if (mesaje == "Medicamentos")
            {
               desHabilitarControles();
               limpiarFormulario();
               panel1.Visible = true;
               groupBox5.Visible = false;
               guardar = false;
            }
        }

        //Metodo btnSalir
        public void btnSalir(String mesaje)
        {
            if (mesaje == "Medicamentos")
            {
                frmPrincipal.Nuevo -= new frm_Principal.Enviar(btnNuevo);
                frmPrincipal.Guardar -= new frm_Principal.Enviar(btnGuardar);
                frmPrincipal.Buscar -= new frm_Principal.Enviar(btnBuscar);
                frmPrincipal.Eliminar -= new frm_Principal.Enviar(btnEliminar);
                frmPrincipal.Modificar -= new frm_Principal.Enviar(btnActualizar);
                frmPrincipal.Cancelar -= new frm_Principal.Enviar(btnCancelar);
                frmPrincipal.Salir -= new frm_Principal.Enviar(btnSalir);
                this.Close();
            }
        }


        //Metodo Cargar id
        private void Cargar_ID()
        {
            try
            {
                int id = objMedControl.cargarNuevo_IdMedicamento();
                txtIdM.Text = string.Format("{0:0000}", id);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        //Metodo Limpiar controles
        public void limpiarFormulario()
        {
            txtIdM.Clear();
            txtNombre.Clear();
            txtPrecioVenta.Clear();
            txtPrecioCompra.Clear();
            txtexistencia.Clear();
            dtpFechaCaducidad.ResetText();
            rtbDescripcion.Clear();
            rtbEspecificaciones.Clear();
            dtpFechaIngreso.ResetText();
            cboCategoria.SelectedIndex = 0;
            cboEstado.Text = "Seleccione...";
            cboCategoria.Text = "Seleccione...";
            errorProvider1.Clear();
          
        }

        //Metodo HabilitarControles
        public void habilitarControles()
        {
            txtIdM.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecioVenta.Enabled = true;
            txtPrecioCompra.Enabled = true;
            txtexistencia.Enabled = true;
            dtpFechaCaducidad.Enabled = true;
            rtbDescripcion.Enabled = true;
            rtbEspecificaciones.Enabled = true;
            dtpFechaIngreso.Enabled = true;
            cboCategoria.Enabled = true;
            cboEstado.Enabled = true;
        }

        //Metodo Des-Habilitar Controles
        public void desHabilitarControles()
        {
            txtIdM.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecioVenta.Enabled = false;
            txtPrecioCompra.Enabled = false;
            txtexistencia.Enabled = false;
            dtpFechaCaducidad.Enabled = false;
            rtbDescripcion.Enabled = false;
            rtbEspecificaciones.Enabled = false;
            dtpFechaIngreso.Enabled = false;
            cboCategoria.Enabled = false;
            cboEstado.Enabled = false;
        }

        private void frm_Medicamentos_Load(object sender, EventArgs e)
        {
            ObjDisableButton.DisableCloseButton(this.Handle.ToInt32());
            desHabilitarControles();
            objMedControl.listarMedicamentos(tabla);
            this.Size=new Size(623, 505);
            this.panel1.Visible = true;
            this.groupBox5.Visible = false;
            cboEstado.Text = "Seleccione...";
            cboCategoria.Text = "Seleccione...";
            guardar = false;
            
        }

        private void txtControl_TextChanged(object sender, EventArgs e)
        {
            tabla.Clear();
            objMedControl.setNombreMedicamento(txtControl.Text);
            objMedControl.listarMedicamentos(tabla);
        }

        private void SeleccionarMedic(int RowIndex)
        {
            this.txtIdM.Text = string.Format("{0:0000}", Int32.Parse(this.dataGridView1.Rows[RowIndex].Cells[0].Value.ToString()));
            this.txtNombre.Text = this.dataGridView1.Rows[RowIndex].Cells[1].Value.ToString();
            this.txtPrecioVenta.Text = this.dataGridView1.Rows[RowIndex].Cells[2].Value.ToString();
            this.txtPrecioCompra.Text = this.dataGridView1.Rows[RowIndex].Cells[3].Value.ToString();
            String fechacad = this.dataGridView1.Rows[RowIndex].Cells[4].Value.ToString();
            this.dtpFechaCaducidad.Value = Convert.ToDateTime(fechacad).Date;
            this.txtexistencia.Text = this.dataGridView1.Rows[RowIndex].Cells[5].Value.ToString();
           
            this.rtbDescripcion.Text = this.dataGridView1.Rows[RowIndex].Cells[6].Value.ToString();
            this.rtbEspecificaciones.Text = this.dataGridView1.Rows[RowIndex].Cells[7].Value.ToString();
            String fechain = this.dataGridView1.Rows[RowIndex].Cells[8].Value.ToString();
            
            this.dtpFechaIngreso.Value = Convert.ToDateTime(fechain).Date;
            this.cboCategoria.SelectedIndex =int.Parse( this.dataGridView1.Rows[RowIndex].Cells[9].Value.ToString());
            this.cboEstado.SelectedIndex=int.Parse(this.dataGridView1.Rows[RowIndex].Cells[10].Value.ToString());
        }

        #region METODOS VALIDAR CONTROLES

        //validaciones cajas con errorprovider
        private void validarCaja(TextBox caja, String msg)
        {
            if (caja.Text == "")
            {
                this.errorProvider1.SetError(caja, msg);
                caja.Focus();
            }
            else
            {
                this.errorProvider1.SetError(caja, null);

            }
        }

        #endregion
     
        #region Validacion de controles
    //Valodar  combos con error provider
        private void validarCombo(ComboBox combo, String msg)
        {
            if (combo.Text == "")
            {
                this.errorProvider1.SetError(combo, msg);
                combo.Focus();
            }
            else
            {
                this.errorProvider1.SetError(combo,null);
            }
        }

        //validar richetexbox con errorprovider
        private void validarRichetexbox(RichTextBox riche, String msg)
        {
            if (riche.Text == "")
            {
                this.errorProvider1.SetError(riche, msg);
                riche.Focus();
            }
            else
            {
                this.errorProvider1.SetError(riche,null);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumero(e);
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumero(e);
        }

        private void txtexistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloNumero(e);
        }

        private void txtControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validarSoloLetras(e);
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            validarCaja(txtNombre, "Ingrese Nombre de Medicamento es Obligatorio");
        }

        private void txtPrecioVenta_Validated(object sender, EventArgs e)
        {
            validarCaja(txtPrecioVenta, "El Precio Venta es Obligatorio");
        }

        private void txtPrecioCompra_Validated(object sender, EventArgs e)
        {
            validarCaja(txtPrecioCompra, "El Precio Compra es Obligatorio");
        }

        private void txtexistencia_Validated(object sender, EventArgs e)
        {
            validarCaja(txtexistencia, "Ingrese Stock es Obligatorio");
        }

        private void rtbDescripcion_Validated(object sender, EventArgs e)
        {
            validarRichetexbox(rtbDescripcion,"La Descripción es Obligatorio ");
        }

        private void rtbEspecificaciones_Validated(object sender, EventArgs e)
        {
            validarRichetexbox(rtbEspecificaciones, "Ingrese algunas especificaciones");
        }

        private void cboCategoria_Validated(object sender, EventArgs e)
        {
            validarCombo(cboCategoria,"Selecione una Opcion");
        }

        private void cboEstado_Validating(object sender, CancelEventArgs e)
        {
            validarCombo(cboEstado, "Selecione una Opcion");
        }
        #endregion

        #region Diseño de los controles
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.LemonChiffon;
            txtNombre.SelectAll();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.Linen;
        }

        private void txtPrecioVenta_Enter(object sender, EventArgs e)
        {
            txtPrecioVenta.BackColor = Color.LemonChiffon;
            txtPrecioVenta.SelectAll();
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            txtPrecioVenta.BackColor = Color.Linen;
        }

        private void txtPrecioCompra_Enter(object sender, EventArgs e)
        {
            txtPrecioCompra.BackColor = Color.LemonChiffon;
            txtPrecioCompra.SelectAll();
        }

        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            txtPrecioCompra.BackColor = Color.Linen;
        }

        private void txtexistencia_Enter(object sender, EventArgs e)
        {
            txtexistencia.BackColor = Color.LemonChiffon;
            txtexistencia.SelectAll();
        }

        private void txtexistencia_Leave(object sender, EventArgs e)
        {
            txtexistencia.BackColor = Color.Linen;
        }

        private void rtbDescripcion_Enter(object sender, EventArgs e)
        {
            rtbDescripcion.BackColor = Color.LemonChiffon;
            rtbDescripcion.SelectAll();
        }

        private void rtbDescripcion_Leave(object sender, EventArgs e)
        {
            rtbDescripcion.BackColor = Color.Linen;
        }

        private void rtbEspecificaciones_Enter(object sender, EventArgs e)
        {
            rtbEspecificaciones.BackColor = Color.LemonChiffon;
            rtbEspecificaciones.SelectAll();
        }

        private void rtbEspecificaciones_Leave(object sender, EventArgs e)
        {
            rtbEspecificaciones.BackColor = Color.Linen;
        }

        private void cboCategoria_Enter(object sender, EventArgs e)
        {
            cboCategoria.BackColor = Color.LemonChiffon;
            cboCategoria.Text = "Seleccione...";
        }

        private void cboCategoria_Leave(object sender, EventArgs e)
        {
            cboCategoria.BackColor = Color.Linen;
        }

        private void cboEstado_Enter(object sender, EventArgs e)
        {
            cboEstado.BackColor = Color.LemonChiffon;
            cboEstado.Text = "Seleccione...";
        }
        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            desHabilitarControles();
            limpiarFormulario();
            SeleccionarMedic(e.RowIndex);
            panel1.Visible = true;
            groupBox5.Visible = false;
            this.Size = new Size(623, 505);
        }

    }
}
