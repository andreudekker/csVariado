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
    public partial class FrmAval : DevComponents.DotNetBar.Office2007Form
    {
        public FrmAval()
        {
            InitializeComponent();
        }

        private void FrmAval_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar(){
            tbxDNI.Clear();
            tbxNombres.Clear();
            tbxApellidos.Clear();
            tbxDireccion.Clear();
            dtpFecNacimiento.Value = DateTime.Now;
        }
        private string EstadoCivil()
        {
            string est = "";
            if (cbxSoltero.Checked == true) { est = "Soltero"; }
            if (cbxCasado.Checked == true) { est = "Casado"; }
            if (cbxViudo.Checked == true) { est = "Viudo"; }
            if (cbxDivorciado.Checked == true) { est = "Divorciado"; }
            return est;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            tbxDNI.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var aux = new Aval();
            aux.dni = tbxDNI.Text.Trim();
            aux.Nombres = tbxNombres.Text.ToUpper();
            aux.Apellidos = tbxApellidos.Text.ToUpper();
            aux.Fec_nacimiento = Convert.ToDateTime(dtpFecNacimiento.Value.ToShortDateString());
            aux.Estado_civil = EstadoCivil().ToUpper();
            aux.Direccion = tbxDireccion.Text.ToUpper();
            aux.Distrito = tbxDistrito.Text.ToUpper();
            if (aux.Nombres.Length > 0 && aux.Apellidos.Length > 0 && aux.dni.Length > 0 )
            {

                if (FrmListaEmpleados.nuevo == true)
                {
                    if (NAval.ExisteDNI(aux) == true)
                    {
                        MessageBox.Show("Ya existe un registro con el DNI que intenta ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (NAval.ExisteNombres(aux) == true && NAval.ExisteDNI(aux) == false)
                    {
                        if (MessageBox.Show("Esta seguro de agregar estos registros con nombres ya existentes?", "Advertencia", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                        {
                            NAval.Guardar(aux);
                            MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                    }
                    else if (NAval.ExisteNombres(aux) == false & NAval.ExisteDNI(aux) == false)
                    {
                        NAval.Guardar(aux);
                        MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }



                }
                else if (FrmListaAvales.modif)
                {
                    aux.IdAval= FrmListaEmpleados.emp.IdEmpleado;
                    MessageBox.Show(aux.IdAval.ToString());
                    NAval.Guardar(aux);
                    MessageBox.Show("Datos actualizados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    FrmListaEmpleados.modif = false;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Asegurese de ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            
            
        }
    }
}
