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
    public partial class FrmClientes : DevComponents.DotNetBar.Office2007Form
    {
         public static int iddistrito;
        public static List<string> lista = new List<string>();
        public FrmClientes()
        {
            InitializeComponent();
        }
        private void Limpiar() {
            tbxDNI.Clear();
            tbxNombres.Clear();
            tbxApellidos.Clear();
            tbxNum_TP.Clear();
            cbxTipo.Text = "";
            tbxRaz_Soc.Clear();
            tbxRuc.Clear();
            tbxNum_TP.Clear();
            tbxDireccion.Clear();
            dtpFecNacimiento.Value = DateTime.Now;
            //cbxDepartamento.SelectedIndex = 0;
            //cbxProvincia.SelectedIndex = 0;
            //cbxDistrito.SelectedIndex = 0;
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cbxDepartamento.DataSource = NDepartamento.ListarDept();
            cbxDepartamento.DisplayMember = "NombreDepartamento";
            cbxDepartamento.ValueMember = "IdDepartamento";
            if (FrmListaClientes.modif==true)
            {
                tbxDNI.Text = FrmListaClientes.c.dni;
                tbxNombres.Text = FrmListaClientes.c.Nombres;
                tbxApellidos.Text = FrmListaClientes.c.Apellidos;
                dtpFecNacimiento.Value = FrmListaClientes.c.Fec_nacimiento;
                var est_civ = FrmListaClientes.c.Estado_civil;
                if (est_civ=="Soltero"){cbxSoltero.Checked = true;}
                if (est_civ == "Casado") { cbxCasado.Checked = true; }
                if (est_civ == "Viudo") { cbxViudo.Checked = true; }
                if (est_civ == "Divorciado") { cbxDivorciado.Checked = true; }
                cbxTipo.Text = FrmListaClientes.c.Tipo_persona;
                if (cbxTipo.Text=="Natural") { tbxNum_TP.Text="1";}else{ tbxNum_TP.Text = "2";}
                tbxRaz_Soc.Text = FrmListaClientes.c.Razon_social;
                tbxRuc.Text = FrmListaClientes.c.ruc;
                tbxDireccion.Text = FrmListaClientes.c.Direccion;
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
            
            //try
            //{
                var aux = new Cliente();
                aux.dni = tbxDNI.Text.Trim();
                aux.Nombres = tbxNombres.Text.ToUpper();
                aux.Apellidos = tbxApellidos.Text.ToUpper();
                aux.Fec_nacimiento = Convert.ToDateTime(dtpFecNacimiento.Value.ToShortDateString());
                aux.Estado_civil = EstadoCivil().ToUpper();
                aux.Tipo_persona = cbxTipo.Text.ToUpper();
                aux.Razon_social = tbxRaz_Soc.Text.ToUpper();
                aux.ruc = tbxRuc.Text.Trim();
                aux.Direccion = tbxDireccion.Text.ToUpper();
                aux.IdDistrito = iddistrito;
            
                if (aux.Nombres.Length>0 && aux.Apellidos.Length>0 && aux.dni.Length>0 && aux.IdDistrito>0)
                {
                    if (tbxDNI.Text.Trim().Length!=8)
                    {
                        MessageBox.Show("El numero de DNI que intenta ingresar debe tener 8 digitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (FrmListaClientes.nuevo == true)
                        {
                            if (NCliente.ExisteDNI(aux) == true)
                            {
                                MessageBox.Show("Ya existe un registro con el DNI que intenta ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else if (NCliente.ExisteNombres(aux) == true && NCliente.ExisteDNI(aux) == false)
                            {
                                if (MessageBox.Show("Esta seguro de agregar estos registros con nombres ya existentes?", "Advertencia", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                                {
                                    NCliente.Guardar(aux);
                                    MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                }
                            }
                            else if (NCliente.ExisteNombres(aux) == false && NCliente.ExisteDNI(aux) == false)
                            {
                                NCliente.Guardar(aux);
                                MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                            }



                        }
                        else if (FrmListaClientes.modif)
                        {
                            aux.IdCliente = FrmListaClientes.c.IdCliente;
                            NCliente.Guardar(aux);
                            MessageBox.Show("Datos actualizados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            FrmListaClientes.modif = false;
                            Close();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Asegurese de ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //NCliente.Guardar(aux);
                //MessageBox.Show(NCliente.ExisteDNI(aux).ToString());
                //MessageBox.Show(NCliente.ExisteNombres(aux).ToString());
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Ha ocurrido un error en la grabacion de datos","Aviso");
            //}
            
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

        private void FrmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmListaClientes.modif = false;
            FrmListaClientes.nuevo = false;
        }

        private void tbxNum_TP_TextChanged(object sender, EventArgs e)
        {
            string num= tbxNum_TP.Text.Trim();
            if (num=="1")
            {
                cbxTipo.SelectedItem = "Natural";
                Ocultar(true);
            }
            else if(num=="2")
            {
                cbxTipo.SelectedItem = "Juridico";
                Ocultar(false);
            }else
	        {
                cbxTipo.SelectedItem = "";
                Ocultar(true);
	        }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            cbxProvincia.Enabled = false;
            cbxDistrito.Enabled = false;
        }

        
        public bool validar_texto(string texto){
                 try{
                        Convert.ToString(texto);
                         return true;
                  }catch{
                           return false;
                    }
        }
        void Ocultar(Boolean hab){
            label12.Visible = !hab;
            label5.Visible = !hab;
            tbxRaz_Soc.Visible =  !hab;
            tbxRuc.Visible = !hab;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
