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
using DevComponents.DotNetBar.Controls;
namespace Presentacion
{
    public partial class FrmLineaCredito : DevComponents.DotNetBar.Office2007Form
    {
        public static bool credito = false;
        public static Cliente cli = null;
        public static Empleado emp = null;
        public static Vivienda viv=null;
        public static float valor_aval;
        public FrmLineaCredito()
        {
            InitializeComponent();
        }

        private void FrmLineaCredito_Load(object sender, EventArgs e)
        {
            HabilitarGroupBoxAval(false);
            HabilitarGroupBoxVivienda(false);
            HabilitarGroupBoxVehiculo(false);
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
            CargarListaVendedores();
            groupBox1.Enabled = true;
            //groupBoxVivienda.Enabled = true;
        }

        private void CargarListaVendedores()
        {
            cbxVendedor.DataSource = NEmpladoContratado.ListaVendedores();
            cbxVendedor.DisplayMember = "Empleado";
            cbxVendedor.ValueMember = "idEmpleado";

            emp = new Empleado();
            var id = Convert.ToInt32(cbxVendedor.SelectedValue);
            emp.IdEmpleado = id;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            credito = true;
            cli = new Cliente();
            var f = new FrmBuscarCliente();
            f.ShowDialog();

            if (cli.IdCliente > 0)
            {
                if (NCliente.ExisteLinea(cli.IdCliente))
                {
                    MessageBox.Show("El cliente ya tiene una linea de credito aciva","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    tbxxCliente.Text = cli.Nombres;
                }
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var aux = new LineaCredito();
            if (tbxIngresos.Text.Length<=0)
            {

            }
            else
            {
                aux.IdCliente = cli.IdCliente;
                aux.IdEmpleado = Convert.ToInt32(cbxVendedor.SelectedValue);
                //MessageBox.Show(Convert.ToInt32(cbxVendedor.SelectedValue).ToString());
                aux.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                aux.NroHijos = (int)nudnro_hijos.Value;
                aux.TiempoResidencia = Convert.ToInt32(nudTiempoRes1.Value);
                aux.Edad = Convert.ToInt32(nudEdad.Value);
                aux.Telefono = tbxTelefono1.Text;
                aux.TipoVivienda = cbxTipoVivienda.Text;
                aux.FormaVida = "A";
                aux.CentroTrabajo = tbxCentroTrabajo.Text;
                aux.Profesion = tbxOcupacion.Text;
                aux.TiempoTrabajo = Convert.ToInt32(nudTiempoLabor.Value);
                aux.Estado = "Aprobado";
                if (cbxTipoDoc.Text == "Boleta" && aux.TiempoTrabajo > 3)
                {
                    aux.TipoTrabajo = "Dependiente Formal";
                }
                else if (cbxTipoDoc.Text == "Recibo por honorarios" && aux.TiempoTrabajo > 6)
                {
                    aux.TipoTrabajo = "Dependiente informal";
                }
                else if (cbxTipoDoc.Text == "Dueño de negocio")
                {
                    aux.TipoTrabajo = "Independiente informal";
                }
                else
                {
                    aux.TipoTrabajo = "No trabaja";
                    aux.Estado = "Desaprobado";
                }
                aux.DireccionTrabajo = tbxDireccionLabor.Text;
                aux.Urbanizacion = tbxUrbanizacion.Text.ToUpper();
                aux.Ingresos = float.Parse(tbxIngresos.Text.Trim());
                aux.TelefonoTrabajo = tbxTelefonoLabor.Text;
                var cme = NLinea_credito.ObtenerCME(aux);
                //var cme = 200.00f;
                
                aux.cmedisponible = cme;
                aux.cme = cme;
                aux.DistritoTrabajo = tbxDistrito.Text;



                if (ckxVivienda.Checked == true)
                {
                    var viv = new Vivienda();
                    viv.NroTitulo = tbxnrotitulo.Text.Trim();
                    viv.Superficie = tbxSuperficie.Text.Trim();
                    viv.Telefono = tbxTelefono2.Text.Trim();
                    viv.Situacion = "";
                    viv.Valuacion = float.Parse(tbxValuacionPropiedad.Text.Trim());
                    NVivienda.Guardar(viv);
                    aux.IdVivienda = NVivienda.ObtenerUltimoID();
                }
                else
                {
                    aux.IdVivienda = 0;
                }
                if (ckxVehiculo.Checked == true)
                {
                    var vehi = new Vehiculo();
                    vehi.Marca = tbxMarca.Text;
                    vehi.Modelo = tbxModelo.Text;
                    vehi.NroTarjeta = tbxNroTarjeta.Text;
                    vehi.Tipo = cbxTipoVehiculo.Text.Trim();
                    vehi.Valuacion = float.Parse(tbxValuacionVehiculo.Text.Trim());
                    NVehiculo.Guardar(vehi);
                    aux.IdVehiculo = NVehiculo.ObtenerUltimoID();
                }
                else
                {
                    aux.IdVehiculo = 0;
                }
                if (ckxAval.Checked == true)
                {
                    var ava = new Aval();
                    ava.dni = tbxDNI.Text.Trim();
                    ava.Nombres = tbxNombres.Text.Trim();
                    ava.Apellidos = tbxApellidos.Text.Trim();
                    ava.Fec_nacimiento = DateTime.Parse(dtpFecNacimientoAval.Value.ToShortDateString());
                    ava.Estado_civil = EstadoCivil();
                    ava.Direccion = tbxDireccionAval.Text.ToUpper();
                    ava.Distrito = tbxDistrito.Text;
                    ava.NroTitulo = tbxNroTituloAval.Text.Trim();
                    NAval.Guardar(ava);
                    aux.IdAval = NAval.ObtenerUltimoID();
                    
                }
                else
                {
                    aux.IdAval = 0;
                }
                if (cbxTipoVivienda.Text.Trim() == "A")
                {
                    if (MessageBox.Show("Desea aprobar la linea de credito como cliente Premiun(Por valuaciones de vivienda)", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ckxVivienda.Checked = true;
                        tbxnrotitulo.Focus();
                        if (tbxValuacionPropiedad.Text.Length>0)
                        {
                            cme = Convert.ToSingle(tbxValuacionPropiedad.Text) * 0.01f;
                            if (NLinea_credito.Guardar(aux))
                            {
                                MessageBox.Show("Linea de credito aprobada,CME aprobada: " + cme.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbxCME.Text = cme.ToString();
                                btnAceptar.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        if (NLinea_credito.Guardar(aux))
                        {
                            MessageBox.Show("Linea de credito aprobada,CME aprobada: " + cme.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxCME.Text = cme.ToString();
                            btnAceptar.Enabled = false;
                        }
                    }
                }
                else
                {
                    if (NLinea_credito.Guardar(aux))
                    {
                        MessageBox.Show("Linea de credito aprobada,CME aprobada: " + cme.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxCME.Text = cme.ToString();
                        btnAceptar.Enabled = false;
                    }
                }
                
            }
            
            
           

        }
        private string EstadoCivil()
        {
            string est = "";
            if (rbnSoltero.Checked == true) { est = "Soltero"; }
            if (rbnCasado.Checked == true) { est = "Casado"; }
            if (rbnViudo.Checked == true) { est = "Viudo"; }
            if (rbnDivorciado.Checked == true) { est = "Divorciado"; }
            return est.Trim();

        }

        private void ckxAval_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxAval.Checked == true) { groupBoxAval.Enabled = true; HabilitarGroupBoxAval(true); } else { groupBoxAval.Enabled = false; HabilitarGroupBoxAval(false); }
        }

        private void ckxVivienda_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxVivienda.Checked == true) { groupBoxVivienda.Enabled = true; HabilitarGroupBoxVivienda(true); } else { groupBoxVivienda.Enabled = false; HabilitarGroupBoxVivienda(false); }
        }
        private void ckxVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxVehiculo.Checked == true) { groupBoxVehiculo.Enabled = true; HabilitarGroupBoxVehiculo(true); } else { groupBoxVehiculo.Enabled = false; HabilitarGroupBoxVehiculo(false); }
        }
        private void HabilitarGroupBoxAval(bool hab = false)
        {
            if (hab == true)
            {
                foreach (Control item in groupBoxAval.Controls)
                {
                    if (item is TextBoxX || item is TextBox)
                    {
                        item.BackColor = SystemColors.Window;
                    }

                }
            }
            else
            {
                foreach (Control item in groupBoxAval.Controls)
                {
                    if (item is TextBoxX || item is TextBox)
                    {
                        item.BackColor = Color.CadetBlue;
                    }

                }
            }

        }
        private void HabilitarGroupBoxVivienda(bool hab = false)
        {
            if (hab == true)
            {
                foreach (Control item in groupBoxVivienda.Controls)
                {
                    if (item is TextBoxX || item is TextBox)
                    {
                        item.BackColor = SystemColors.Window;
                    }

                }
            }
            else
            {
                foreach (Control item in groupBoxVivienda.Controls)
                {
                    if (item is TextBoxX || item is TextBox)
                    {
                        item.BackColor = Color.CadetBlue;
                    }

                }
            }

        }
        private void HabilitarGroupBoxVehiculo(bool hab = false)
        {
            if (hab == true)
            {
                foreach (Control item in groupBoxVehiculo.Controls)
                {
                    if (item is TextBoxX || item is TextBox)
                    {
                        item.BackColor = SystemColors.Window;
                    }

                }
            }
            else
            {
                foreach (Control item in groupBoxVehiculo.Controls)
                {
                    if (item is TextBoxX || item is TextBox)
                    {
                        item.BackColor = Color.CadetBlue;
                    }

                }
            }

        }

        private void cbxTipoVivienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("Introduzca solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbxTelefonoLabor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("Introduzca solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbxValuacionPropiedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("Introduzca solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
