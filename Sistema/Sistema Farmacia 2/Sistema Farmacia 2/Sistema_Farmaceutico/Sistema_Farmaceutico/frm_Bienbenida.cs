using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Farmaceutico
{
    public partial class Bienbenida : Form
    {
        public Bienbenida()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (this.progressBar1.Value == 100)
            {
                this.Opacity -= 0.07;
            }
            if (this.Opacity == 0.0)
            {
                this.Hide();
                frm_Acceso frm = new frm_Acceso();
                frm.Show();
                this.timer1.Enabled = false;
            }
            if (this.progressBar1.Value == 0 || this.progressBar1.Value == 20 || progressBar1.Value == 40 || progressBar1.Value == 60 || progressBar1.Value == 80)
            {
                label1.Text = "Cargando...";
            }
            else if (this.progressBar1.Value == 10 || this.progressBar1.Value == 30 || progressBar1.Value == 50 || progressBar1.Value == 70 || progressBar1.Value == 90)
            {
                label1.Text = "Bienvenido...";
            }
            else if (progressBar1.Value == 99)
            {
                label1.Text = "Proceso Terminado...";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
