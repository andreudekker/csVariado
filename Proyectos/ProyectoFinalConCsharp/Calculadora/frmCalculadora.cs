using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {

        Calculos misCalculos = new Calculos();
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("9");
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("0");
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar(".");
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            misCalculos.suma(txtDisplay.Text);
        }
 
        private void btnResta_Click(object sender, EventArgs e)
        {
            misCalculos.resta(txtDisplay.Text);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            misCalculos.multiplicar(txtDisplay.Text);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            misCalculos.dividir(txtDisplay.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e) // resultado
        {
            txtDisplay.Text = "" + misCalculos.resultado(txtDisplay.Text);
        }

        private void btnTripleCero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = misCalculos.concatenar("000");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            misCalculos.clear();
            txtDisplay.Text = "0";
        }
    }
}
