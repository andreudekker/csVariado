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
    public partial class FrmPrestamos : DevComponents.DotNetBar.Office2007Form
    {
        public static float inicial = 0;
        public static bool est = false;
        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            
            var aux = new Prestamo();
            var ven = new Venta();
            aux.IdVenta = NVenta.ObtenerUltimoID();
            ven.IdVenta = aux.IdVenta;
            tbxCapital.Text =  NVenta.ObtenerCapital(ven).ToString("0.00");
            tbxInicial.Text = FrmVentas.inicial.ToString();
            if (FrmVentas.tipo.Trim() == "Cash 8 partes") { tbxTea.Text = "9,6"; nudNroCuotas.Maximum = 7; }
            else if (FrmVentas.tipo.Trim() == "Normal") { tbxTea.Text = "95,6"; ;nudNroCuotas.Maximum = 24; }
            else if (FrmVentas.tipo == "Creditecnológico") { tbxTea.Text = "45,6"; nudNroCuotas.Maximum = 18; }
            else if (FrmVentas.tipo.Trim() == "Cash 4 partes") { tbxTea.Text = "9,6"; nudNroCuotas.Maximum = 3; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var aux = new Prestamo();
            
            var ven=new Venta();
            var lin=new LineaCredito();
            lin.IdCliente=FrmVentas.cli.IdCliente;
            MessageBox.Show(lin.IdCliente.ToString());
            aux.IdLineaCredito = NLinea_credito.FiltrarLinCredito(lin);
            MessageBox.Show(aux.IdLineaCredito.ToString());
            aux.IdVenta = NVenta.ObtenerUltimoID();
            
            ven.IdVenta = aux.IdVenta;
            aux.Capital_prestado=NVenta.ObtenerCapital(ven);
            aux.Fec_desembolso = Convert.ToDateTime( DateTime.Now.ToShortDateString());
            aux.Plazo_nrouotas = Convert.ToInt32( nudNroCuotas.Value);
            aux.tea = Convert.ToSingle(tbxTea.Text.Trim());
            aux.tem = Convert.ToSingle(Math.Pow((1 + aux.tea / 100), 0.083333f) - 1f);
            aux.Estado = "pre-prestamo";
            //MessageBox.Show("idcliente" + lin.IdCliente.ToString());
            var cme_dis=NLinea_credito.FiltrarCME(lin);
            //MessageBox.Show (cme.ToString());
            
            if (Convert.ToSingle( tbxCuotaMensual.Text.Trim())>cme_dis)
            {
                MessageBox.Show("La CME del cliente no aplica a la cuota mensual","Aviso");
            }
            else
            {
                if (NPrestamo.Guardar(aux))
                {
                    MessageBox.Show("Prestamo guardado");
                    est = true;
                    Close();
                }
                else
                {
                    est = false;
                }
            }
            
        }

        private void nudNroCuotas_ValueChanged(object sender, EventArgs e)
        {

            float tea=Convert.ToSingle( tbxTea.Text.Trim());
            float captital=Convert.ToSingle(tbxCapital.Text.Trim());
            int nrocuotas=Convert.ToInt32( nudNroCuotas.Value);
            float tem=Convert.ToSingle( Math.Pow((1+tea/100),0.083333f) - 1f);
            inicial = 0;
            if (tbxInicial.Text.Length>0)
            {
                inicial = Convert.ToSingle(tbxInicial.Text.Trim());
            } 
            
            var cuota = (captital) * (tem * Math.Pow((1 + tem), nrocuotas)) / (Math.Pow((1 + tem), nrocuotas) - 1f);
            tbxCuotaMensual.Text = decimal.Round( Convert.ToDecimal (cuota),2).ToString();
            tbxFechaPrimeraCuota.Text = DateTime.Now.AddMonths(1).ToShortDateString();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            est = false;
        }
    }
}
