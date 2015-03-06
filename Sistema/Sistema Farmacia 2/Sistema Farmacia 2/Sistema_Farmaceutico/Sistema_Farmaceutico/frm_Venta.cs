using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LayerControler.LayerVenta;
namespace Sistema_Farmaceutico
{
    public partial class frm_Venta : Form
    {
        // Cargar clase para desactivar Boton Cerrar
        DisableButton ObjDisableButton = new DisableButton();
        ventaControler objventaControler = new ventaControler();
        frm_Principal frmPrincipal;
        DataTable tabla = new DataTable();
        Boolean guardar = false;

        public frm_Venta(frm_Principal frm)
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
            this.lblFecha.Text = DateTime.Now.ToShortDateString();
            deshabilitarControles();
        }


        //Metodo nuevo
        public void btnNuevo(String mesaje)
        {
            if (mesaje == "Ventas")
            {
                limpiarFormulario();
                habilitarControles();
                Cargar_ID();
                this.txtCliente.Focus();
                guardar = false;
            }
        }

        private void habilitarControles()
        {
            this.txtCliente.Enabled = true;
            this.txtDireccion.Enabled = true;
            this.txtRuc.Enabled = true;
            this.txtProd.Enabled = true;
            this.cboTipo.Enabled = true;
            this.btnBuscarProducto.Enabled = true;
        }

        private void deshabilitarControles()
        {
            this.txtCliente.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtRuc.Enabled = false;
            this.txtProd.Enabled = false;
            this.cboTipo.Enabled = false;
            this.btnBuscarProducto.Enabled = false;
            this.btnImprimir.Enabled = false;
        }

        private void limpiarFormulario()
        {
            this.txtCliente.Clear();
            this.txtDireccion.Clear();
            this.txtRuc.Clear();
            this.txtProd.Clear();
            this.cboTipo.SelectedIndex = 0;
            this.txtSubTotal.Clear();
            this.txtIgv.Clear();
            this.txtTotalAPagar.Clear();
        }

        //Metodo btnGuardar
        public void btnGuardar(String mesaje)
        {
            if (mesaje == "Ventas")
            {
                if (guardar == false)
                {
                    //try
                    //{
                        if (this.dgvItems.Rows.Count > 0)
                        {
                            string serie = objventaControler.cargarNuevo_IdVenta();
                            if (string.Empty.Equals(serie))
                                serie = "00000";
                            serie = String.Format("{0:00000}", Int32.Parse(serie) + 1);
                            objventaControler.setSerie(serie.Trim());
                            objventaControler.setIdUser(frmPrincipal.idUsuario);
                            if (this.txtCliente.Text.Length > 0)
                            {
                                int idCli = objventaControler.buscarIDCliente(this.txtCliente.Text.Trim());
                                if (idCli != 0)
                                    objventaControler.setIdcli(idCli);
                                else
                                {
                                    MessageBox.Show("El cliente ingresado es incorrecto o no se encuentra registrado", "Cliente Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                            }
                            //else objventaControler.setIdcli(0);
                            objventaControler.setIdFarmacia(frmPrincipal.idFarmacia);
                            objventaControler.setFecha(DateTime.Now);
                            objventaControler.setTipo(this.cboTipo.SelectedIndex);
                            objventaControler.setSubTotal(Decimal.Parse(this.txtSubTotal.Text));
                            objventaControler.setDesc(0);
                            objventaControler.setIgv(Decimal.Parse(this.txtIgv.Text));
                            objventaControler.setTotal(Decimal.Parse(this.txtTotalAPagar.Text));
                            objventaControler.guardar_NuevoVenta();
                            for (int i = 0; i < this.dgvItems.Rows.Count; i++)
                            {
                                objventaControler.setserieDV(serie.Trim());
                                int idProducto = Int32.Parse(this.dgvItems.Rows[i].Cells[1].Value.ToString());
                                objventaControler.setIdProducto(idProducto);
                                objventaControler.setDescripcion(this.dgvItems.Rows[i].Cells[3].Value.ToString());
                                objventaControler.setPrecio(Decimal.Parse(this.dgvItems.Rows[i].Cells[4].Value.ToString()));
                                objventaControler.setCantidad(Int32.Parse(this.dgvItems.Rows[i].Cells[5].Value.ToString()));
                                objventaControler.setTotalDV(Decimal.Parse(this.dgvItems.Rows[i].Cells[6].Value.ToString()));
                                int cantidad = objventaControler.getCantidadProducto(idProducto) - Int32.Parse(this.dgvItems.Rows[i].Cells[5].Value.ToString());
                                objventaControler.setCantidadProducto(idProducto, cantidad);
                                objventaControler.guardar_NuevaDetalleVenta();
                            }
                            MessageBox.Show("Venta: " + serie + " registrado correctamente.", "Venta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarFormulario();
                            deshabilitarControles();
                            this.dgvItems.Rows.Clear();
                        }
                        else {
                            MessageBox.Show("No hay ningun producto para generar una venta.", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        //if (txtNombre.Text != "")
                        //{
                        //    objMedControl.guardar_NuevoMedicamento();
                        //    MessageBox.Show("Registro guardado correctamente.", "Guardar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //    limpiarFormulario();
                        //    desHabilitarControles();
                        //    guardar = false;
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Debe ingresar los datos correctamente.\nTodos los datos son abligatorios.", "Guardar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //}
                    //}
                    //catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else if (guardar == true)
                {
                    try
                    {
                        //objMedControl.setId(int.Parse(txtIdM.Text));
                        //objMedControl.setNombreMedicamento(txtNombre.Text);
                        //objMedControl.setPrecioVenta(double.Parse(txtPrecioVenta.Text));
                        //objMedControl.setPrecioCompra(double.Parse(txtPrecioCompra.Text));
                        //objMedControl.setExistencia(int.Parse(txtexistencia.Text));
                        //objMedControl.setFechaCaducidad(Convert.ToDateTime(dtpFechaCaducidad.Value));
                        //objMedControl.setDescripcion(rtbDescripcion.Text);
                        //objMedControl.setEspecificaciones(rtbEspecificaciones.Text);
                        //objMedControl.setFechaIngreso(Convert.ToDateTime(dtpFechaIngreso.Value));
                        //objMedControl.setIdCategoria(int.Parse(cboCategoria.SelectedIndex.ToString()));
                        //objMedControl.setEstado(int.Parse(cboEstado.SelectedIndex.ToString()));

                        //if (txtNombre.Text != "")
                        //{
                        //    //objMedControl.Actualizar_Medicamento();
                        //    MessageBox.Show("Registro Actualizado correctamente.", "Actualizar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //    //limpiarFormulario();
                        //    //desHabilitarControles();
                        //    guardar = false;
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Debe ingresar los datos correctamente.\nTodos los datos son abligatorios.", "Actualizar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //}
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

            }
        }


        //Metodo Modificar
        public void btnActualizar(String mesaje)
        {
            if (mesaje == "Ventas")
            {
                if (guardar == true)
                {

                }
            }
        }


        //Metodo Buscar
        public void btnBuscar(String mesaje)
        {
            if (mesaje == "Ventas")
            {

                guardar = true;

            }
        }

        //Metodo btnEliminar
        public void btnEliminar(String mesaje)
        {
            if (mesaje == "Ventas")
            {
                if (guardar == true)
                {

                    MessageBox.Show("Registro Eliminado correctamente.", "Eliminar Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpiarFormulario();
                    //desHabilitarControles();
                    guardar = false;
                }
            }
        }

        //Metodo btnCancelar
        public void btnCancelar(String mesaje)
        {
            if (mesaje == "Ventas")
            {
                //limpiarFormulario();
                //desHabilitarControles();
                guardar = false;
            }
        }

        //Metodo btnSalir
        public void btnSalir(String mesaje)
        {
            if (mesaje == "Ventas")
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
                string id = objventaControler.cargarNuevo_IdVenta();
                if (string.Empty.Equals(id))
                    id = "00000";
                if (this.cboTipo.SelectedIndex == 0)
                    this.lblTipo.Text = "B" + String.Format("{0:00000}", Int32.Parse(id) + 1);
                else
                    this.lblTipo.Text = "F" + String.Format("{0:00000}", Int32.Parse(id) + 1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frm_Venta_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(774, 122);
            //gbxFactura.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Busqueda frm = new frm_Busqueda(this);
            frm.ShowDialog();
        }

        public void cargarProductosSeleccionados(String idProducto, String nombreProducto, String descripcionProducto, Double precioUnitario, int cantidad)
        {
            this.dgvItems.Rows.Add(this.dgvItems.Rows.Count + 1, idProducto, nombreProducto, descripcionProducto, precioUnitario, cantidad.ToString(), string.Format("{0:00.00}", cantidad * precioUnitario));
            this.txtProd.Text = nombreProducto;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            procesarImporte();
            this.lblItems.Text = "Items: " + this.dgvItems.Rows.Count.ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            procesarImporte();
            actualiarIndiceItem();
            this.lblItems.Text = "Items: " + this.dgvItems.Rows.Count.ToString();
        }

        private void procesarImporte()
        {
            Double subtotal = 0;
            for (int i = 0; i < this.dgvItems.Rows.Count; i++)
            {
                subtotal += Double.Parse(this.dgvItems.Rows[i].Cells[6].Value.ToString());
            }
            this.txtSubTotal.Text = string.Format("{0:00.00}", subtotal);
            this.txtIgv.Text = string.Format("{0:00.00}", subtotal * 0.18);
            this.txtTotalAPagar.Text = string.Format("{0:00.00}", subtotal + Double.Parse(this.txtIgv.Text));
        }

        private void actualiarIndiceItem()
        {
            for (int i = 0; i < this.dgvItems.Rows.Count; i++)
                this.dgvItems.Rows[i].Cells[0].Value = i + 1;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { this.dgvItems.Rows.RemoveAt(this.dgvItems.CurrentRow.Index); }
            catch (NullReferenceException) { MessageBox.Show("No se ha encontrado ningun item", "Eliminar Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void cboTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int i = this.cboTipo.SelectedIndex;
            switch (i)
            {
                case 0:
                    this.groupBox3.Text = "BOLETA";
                    Cargar_ID();
                    break;
                case 1:
                    this.groupBox3.Text = "FACTURA";
                    Cargar_ID();
                    break;
            }
        }
    }
}
