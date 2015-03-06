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
    public partial class FrmContrato : DevComponents.DotNetBar.Office2007Form
    {
        public static Boolean contrato = false;
        public static int idempleado;
        public static string empleado;
        public FrmContrato()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            idempleado=0;
            tbxEmpleado.Text = "";
            tbxNick.Text = "";
            tbxClave.Text="";
            tbxClave2.Text="";
            cbxCargo.Text = "";
            cbxTurno.Text = "";
        }
        private void FrmContrato_Load(object sender, EventArgs e)
        {
            if (FrmListaContratos.modif == true)
            {
                btnBuscarEmpleado.Enabled = false;
                tbxEmpleado.Text = FrmListaContratos.emp;
                dtpFechaInicio.Value = FrmListaContratos.con.Fec_ini;
                dtpFechaFin.Value = FrmListaContratos.con.Fec_fin;
                tbxNick.Text = FrmListaContratos.con.Nick;
                tbxClave.Text = FrmListaContratos.con.Clave;
                tbxClave2.Text = FrmListaContratos.con.Clave;
                cbxCargo.Text = FrmListaContratos.con.Cargo;
                cbxTurno.Text = FrmListaContratos.con.Turno;
            }
            else if (FrmListaContratos.nuevo == true)
            {
                btnBuscarEmpleado.Enabled = true;
            }
            
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            contrato = true;
            idempleado = 0;
            var f = new FrmBuscarEmpleado();
            f.ShowDialog();
            if (idempleado>0)
            {
                if (NCliente.ExisteContrato(idempleado))
                {
                    MessageBox.Show("El cliente ya tiene un contrato activo","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    tbxEmpleado.Text = empleado;
                }
                
            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            var aux = new Contrato();
            aux.IdEmpleado = idempleado;
            aux.Fec_ini = dtpFechaInicio.Value;
            aux.Fec_fin = dtpFechaFin.Value;
            aux.Nick = tbxNick.Text;
            aux.Clave = tbxClave2.Text;
            aux.Cargo = (string)cbxCargo.SelectedItem;
            aux.Turno = (string)cbxTurno.SelectedItem;
            aux.Estado = "1";

            if (tbxEmpleado.Text.Length>0 && tbxClave.Text.Length>0 && tbxClave2.Text.Length>0)
            {
                if (tbxClave.Text==tbxClave2.Text)
                {
                    if (FrmListaContratos.nuevo == true || FrmEmpleados.est==true)
                    {
                        if (NContrato.Guardar(aux))
                        {
                            MessageBox.Show("Datos registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                    }
                    else if (FrmListaContratos.modif == true)
                    {
                        aux.IdContrato = FrmListaContratos.con.IdContrato;
                        aux.IdEmpleado = FrmListaContratos.con.IdEmpleado;
                        if (NContrato.Guardar(aux))
                        {
                            MessageBox.Show("Datos actualizados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las claves deben der iguales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar();
                }
                
            }
            
            
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmContrato_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmListaContratos.modif = false;
        }
    }
}
