using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocios;
namespace Presentacion
{
    public partial class FrmEmpleados : DevComponents.DotNetBar.Office2007Form
    {
        public static int iddistrito;
        public static Boolean est=false;
        public FrmEmpleados()
        {
            InitializeComponent();
        }
        private void Limpiar() {
            tbxDNI.Clear();
            tbxNombres.Clear();
            tbxApellidos.Clear();
            tbxCorreo.Clear();
            tbxDireccion.Clear();
            tbxCelular.Clear();
            dtpFecNacimiento.Value = DateTime.Now;
            //cbxDepartamento.SelectedIndex=0;
            //cbxProvincia.SelectedIndex = 0;
            //cbxDistrito.SelectedIndex = 0;
        }
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            cbxDepartamento.DataSource = NDepartamento.ListarDept();
            cbxDepartamento.DisplayMember = "NombreDepartamento";
            cbxDepartamento.ValueMember = "IdDepartamento";
            if (FrmListaEmpleados.modif==true)
            {
                tbxDNI.Text = FrmListaEmpleados.emp.dni;
                tbxNombres.Text = FrmListaEmpleados.emp.Nombres;
                tbxApellidos.Text = FrmListaEmpleados.emp.Apellidos;
                dtpFecNacimiento.Value = FrmListaEmpleados.emp.Fec_nacimiento;
                var est_civ = FrmListaEmpleados.emp.Estado_civil;
                if (est_civ.Trim()=="Soltero"){cbxSoltero.Checked = true;}
                if (est_civ.Trim() == "Casado") { cbxCasado.Checked = true; }
                if (est_civ.Trim() == "Viudo") { cbxViudo.Checked = true; }
                if (est_civ.Trim() == "Divorciado") { cbxDivorciado.Checked = true; }
                tbxCelular.Text = FrmListaEmpleados.emp.Celular;
                tbxCorreo.Text = FrmListaEmpleados.emp.Correo_electronico;
                tbxDireccion.Text = FrmListaEmpleados.emp.Direccion;
                cbxDistrito.Enabled = true;
                cbxProvincia.Enabled = true;

                cbxDepartamento.SelectedValue = NListaDistritos.FiltrarIdDepartamento(FrmListaClientes.c.IdDistrito);

                var aux = new Provincia();
                int seleccionado = Convert.ToInt32(cbxDepartamento.SelectedValue);
                aux.IdDepartamento = seleccionado;
                cbxProvincia.DataSource = NProvincia.ListarProv(aux);
                cbxProvincia.DisplayMember = "NombreProvincia";
                cbxProvincia.ValueMember = "IdProvincia";

                cbxProvincia.SelectedValue = NListaDistritos.FiltrarIdProvincia(FrmListaClientes.c.IdDistrito);

                var aux2 = new Distrito();
                int seleccionado2 = Convert.ToInt32(cbxProvincia.SelectedValue);
                aux2.IdProvincia = seleccionado2;
                cbxDistrito.DataSource = NDistrito.ListarDist(aux2);
                cbxDistrito.DisplayMember = "NombreDistrito";
                cbxDistrito.ValueMember = "IdDistrito";

                cbxDistrito.SelectedValue = FrmListaClientes.c.IdDistrito;
            }
            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
             var aux = new Empleado();
                aux.dni = tbxDNI.Text.Trim();
                aux.Nombres = tbxNombres.Text.ToUpper();
                aux.Apellidos = tbxApellidos.Text.ToUpper();
                aux.Fec_nacimiento = Convert.ToDateTime(dtpFecNacimiento.Value.ToShortDateString());
                aux.Estado_civil = EstadoCivil().ToUpper();
                aux.Celular = tbxCelular.Text.Trim().ToUpper();
                aux.Correo_electronico = tbxCorreo.Text.Trim();
                aux.Direccion = tbxDireccion.Text.ToUpper();
                aux.IdDistrito = iddistrito;
                
                if (aux.Nombres.Length>0 && aux.Apellidos.Length>0 && aux.dni.Length>0 && aux.IdDistrito>0)
                {
                    if (tbxDNI.Text.Trim().Length != 8)
                    {
                        MessageBox.Show("El numero de DNI que intenta ingresar debe tener 8 digitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (FrmListaEmpleados.nuevo == true)
                        {
                            if (NEmpleado.ExisteDNI(aux) == true)
                            {
                                MessageBox.Show("Ya existe un registro con el DNI que intenta ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else if (NEmpleado.ExisteNombres(aux) == true && NEmpleado.ExisteDNI(aux) == false)
                            {
                                if (MessageBox.Show("Esta seguro de agregar estos registros con nombres ya existentes?", "Advertencia", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                                {
                                    NEmpleado.Guardar(aux);
                                    MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    var pre=MessageBox.Show("¿Desea registrar el contrato del empleado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (pre==DialogResult.Yes)
                                    {
                                        est = true;
                                        Hide();
                                        var f = new FrmContrato();
                                        f.ShowDialog();
                                        
                                    }
                                    Limpiar();
                                }
                            }
                            else if (NEmpleado.ExisteNombres(aux) == false & NEmpleado.ExisteDNI(aux) == false)
                            {
                                NEmpleado.Guardar(aux);
                                MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                var pre = MessageBox.Show("¿Desea registrar el contrato del empleado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (pre == DialogResult.Yes)
                                {
                                    est = true;
                                    Hide();
                                    var f = new FrmContrato();
                                    f.ShowDialog();
                                }
                                Limpiar();
                            }



                        }
                        else if (FrmListaEmpleados.modif)
                        {
                            aux.IdEmpleado = FrmListaEmpleados.emp.IdEmpleado;
                            MessageBox.Show(aux.IdEmpleado.ToString());
                            NEmpleado.Guardar(aux);
                            MessageBox.Show("Datos actualizados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            FrmListaEmpleados.modif = false;
                            Close();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Asegurese de ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            
            
        }
        private string EstadoCivil()
        {
            string est="";
            if (cbxSoltero.Checked==true){est = "Soltero";}
            if (cbxCasado.Checked == true) { est = "Casado"; }
            if (cbxViudo.Checked==true){est="Viudo";}
            if (cbxDivorciado.Checked==true){est="Divorciado";}
            return est;
            
        }

        private void cbxDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var aux = new Provincia();
            int seleccionado = Convert.ToInt32( cbxDepartamento.SelectedValue) ;
            aux.IdDepartamento = seleccionado;
            //MessageBox.Show(aux.IdDepartamento.ToString());
            //cbxProvincia.Items.Clear();
            cbxProvincia.DataSource = NProvincia.ListarProv(aux);
            cbxProvincia.DisplayMember = "NombreProvincia";
            cbxProvincia.ValueMember = "IdProvincia";
            cbxProvincia.Enabled = true;
        }
        private void cbxProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var aux=new Distrito();
            int seleccionado = Convert.ToInt32 (cbxProvincia.SelectedValue);
            aux.IdProvincia = seleccionado;
            cbxDistrito.DataSource = NDistrito.ListarDist(aux);
            cbxDistrito.DisplayMember = "NombreDistrito";
            cbxDistrito.ValueMember = "IdDistrito";
            cbxDistrito.Enabled = true;
        }

        private void cbxDistrito_SelectionChangeCommitted(object sender, EventArgs e)
        {
            iddistrito = Convert.ToInt32(cbxDistrito.SelectedValue);
        }

        private void FrmEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmListaEmpleados.modif = false;
            FrmListaEmpleados.nuevo = false;
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            cbxProvincia.Enabled = false;
            cbxDistrito.Enabled = false;
        }

    }
}
