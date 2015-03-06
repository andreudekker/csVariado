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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Presentacion
{
    public partial class FrmPagoCredito : DevComponents.DotNetBar.Office2007Form
    {
        public static string direccion = "", ruc = "", dni = "", cod_vendedor = "", nro_tran = "";
        public static string cli,res="";
        public static int nro = 0,idpres=0;
        public static float totalcapital = 0, interestotal = 0, desg, itf, totaltotal,totacuota;
        public FrmPagoCredito()
        {
            InitializeComponent();
        }

        private void FrmPagoCredito_Load(object sender, EventArgs e)
        {
            
            var nroven = FrmCaja.aux.Nro_venta;//bien

            var pres = new Prestamo();
            var ven = new Venta();
            ven.Nro_venta = nroven;
            ven.IdVenta = FrmCaja.aux.IdVenta;
            //MessageBox.Show("nroven" + ven.Nro_venta);
            idpres = NVenta.ObtenerIDPrestamo(ven);
            if (idpres.ToString()=="0")
            {
                MessageBox.Show("El cliente no tiene un prestamo","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Question);
                Close();
            }
            else
            {
                pres.IdPrestamo = idpres;
                var cap = NVenta.ObtenerCapital(ven);
                var nro_cuotas = NPrestamo.ObtenerPlazo(pres);
                var tem = Convert.ToSingle(NPrestamo.ObtenerTEM(pres));
                //MessageBox.Show(tem.ToString());
                var cuota = cap * (tem * Math.Pow((1 + tem), nro_cuotas)) / (Math.Pow((1 + tem), nro_cuotas) - 1f);
                //MessageBox.Show(cuota.ToString());
                float cuota_red = Convert.ToSingle(decimal.Round(Convert.ToDecimal(cuota), 2));

                tbxNro_prestamo.Text = idpres.ToString();
                tbxCliente.Text = FrmCaja.cli;
                tbxCapital.Text = cap.ToString();
                tbxFecDesembolso.Text = DateTime.Now.AddMonths(1).ToShortDateString();
                tbxPlazo.Text = nro_cuotas.ToString();
                for (int i = 1; i < nro_cuotas + 1; i++)
                {
                    //MessageBox.Show(tem.ToString());
                    var interes_mes = Convert.ToSingle(decimal.Round(Convert.ToDecimal(cap * tem), 2));
                    var total=Convert.ToSingle( decimal.Round( Convert.ToDecimal(cuota_red + 0.05),2));
                    var capital =Convert.ToSingle( decimal.Round( Convert.ToDecimal( cuota_red - interes_mes),2));
                    dataGridViewX1.Rows.Add(i, DateTime.Now.AddMonths(i).ToShortDateString(), capital,Convert.ToSingle( interes_mes.ToString("0.00")), cuota_red, 0.04, 0.01, total,total ,"");
                    cap = cap - capital;
                }
                tbxcapitaltotal.Text = tbxCapital.Text.Trim();
                foreach (DataGridViewRow fila in dataGridViewX1.Rows)
                {
                    totalcapital += (float)fila.Cells[2].Value;
                    interestotal += (float)fila.Cells[3].Value;
                    desg += Convert.ToSingle( fila.Cells[5].Value);
                    itf += Convert.ToSingle( fila.Cells[6].Value);
                    totacuota += Convert.ToSingle(fila.Cells[4].Value);
                    totaltotal += Convert.ToSingle( decimal.Round(Convert.ToDecimal( fila.Cells[7].Value),2));
                }
                tbxinterestotal.Text =  Convert.ToSingle( decimal.Round(Convert.ToDecimal(interestotal),2)).ToString();
                tbxtotaldesgr.Text =  Convert.ToSingle( decimal.Round(Convert.ToDecimal(desg),2)).ToString();
                tbxtotalitf.Text = Convert.ToSingle( decimal.Round(Convert.ToDecimal (itf),2)).ToString();
                tbxtotalcuota.Text =  Convert.ToSingle( decimal.Round(Convert.ToDecimal(totacuota),2)).ToString();
                tbxtotaltotal.Text =  Convert.ToSingle( decimal.Round(Convert.ToDecimal(totaltotal),2)).ToString();
                

                //var pres = new Prestamo();
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            nro = 0;
            //btnCobrar.Enabled = true;
            var doc = new Document(PageSize.A4, 30f, 20f, 50f, 20f);
            PdfWriter.GetInstance(doc, new FileStream("Cronograma.pdf", FileMode.Create));

            //Creando la fuente para el encabezado
            var tipo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            var fuente = new iTextSharp.text.Font(tipo, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            //Creando la fuente para lo suguiente
            var tipo2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            var fuente2 = new iTextSharp.text.Font(tipo, 13, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            var separacion = new Paragraph("\n");

            var l1 = new Paragraph("Cronograma de pagos", fuente);
            l1.Alignment = Element.ALIGN_CENTER;
            var l1_2 = new Paragraph("        Nro. prestamo: "+tbxNro_prestamo.Text.Trim(), fuente);
            var l2 = new Paragraph("       Cliente: " + tbxCliente.Text);
            var l3 = new Paragraph("        Capital: " + tbxCapital.Text , fuente);
            var l4 = new Paragraph("        Fec. desembolso: " + tbxFecDesembolso.Text , fuente);
            var l5 = new Paragraph("        Plazo: " + tbxPlazo.Text, fuente);
            var l6 = new Paragraph("           Totales:              " + tbxcapitaltotal.Text + "      " + tbxinterestotal.Text + "          " + tbxtotalcuota.Text.Trim() +"        "+ tbxtotaldesgr.Text + "            " + tbxtotalitf.Text  + "            " + tbxtotaltotal.Text.Trim());
            //l6.Alignment = Element.ALIGN_RIGHT;
            var tabla = new PdfPTable(8);
            var ancho = new[] { 30, 100, 70, 70,70,70,70,100 };
            tabla.TotalWidth = 540;
            tabla.LockedWidth = true;
            tabla.SpacingAfter = 20f;
            tabla.SpacingBefore = 20f;
            tabla.SetWidths(ancho);
            
            tabla.AddCell("Nro");
            tabla.AddCell("Vencto.");
            tabla.AddCell("Capital");
            tabla.AddCell("Interes");
            tabla.AddCell("Cuota");
            tabla.AddCell("Desgravamen");
            tabla.AddCell("ITF");
            tabla.AddCell("Total");
            doc.Open();

            doc.Add(l1);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(l2);
            doc.Add(l3);
            doc.Add(l4);
            doc.Add(l5);
            foreach (DataGridViewRow item in dataGridViewX1.Rows)
            {
                
                tabla.AddCell(item.Cells[0].Value.ToString());
                tabla.AddCell(item.Cells[1].Value.ToString());
                tabla.AddCell(item.Cells[2].Value.ToString());
                tabla.AddCell(item.Cells[3].Value.ToString());
                tabla.AddCell(item.Cells[4].Value.ToString());
                tabla.AddCell(item.Cells[5].Value.ToString());
                tabla.AddCell(item.Cells[6].Value.ToString());
                tabla.AddCell(item.Cells[7].Value.ToString());
            }
            doc.Add(tabla);
            doc.Add(l6);
            doc.Close();
            buttonX4.Enabled = true;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            float cuota=0;
            int nrocuo = Convert.ToInt32(tbxPlazo.Text.Trim());
            for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
            {
                var aux = new Pago();
                var f=dataGridViewX1.Rows[i];
                aux.IdPrestamo = idpres;
                aux.Nro = (int) f.Cells[0].Value;
                aux.Fec_vencimiento = Convert.ToDateTime( Convert.ToDateTime( f.Cells[1].Value).ToShortDateString());
                aux.Capital=(float) f.Cells[2].Value;
                aux.Interes= (float)f.Cells[3].Value;
                aux.Cuota = (float)f.Cells[4].Value;
                aux.Desgravamen = Convert.ToSingle( f.Cells[5].Value);
                aux.itf = Convert.ToSingle( f.Cells[6].Value);
                aux.Total = Convert.ToSingle(f.Cells[7].Value);
                aux.Debe =Convert.ToSingle( f.Cells[8].Value);
                //MessageBox.Show(f.Cells[9].Value.ToString());
                aux.Fec_pago = f.Cells[9].Value.ToString();
                cuota = aux.Total;
                if (NPagos.Guardar(aux))
                {
                    
                }
                
            }
            MessageBox.Show("Cronograma de pagos guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            res = "si";
            var lin = new LineaCredito();
            lin.IdCliente = FrmCaja.idcli;
            lin.cme = cuota;
            var pres = new Prestamo();
            pres.IdPrestamo = idpres;
            pres.Estado = "Deuda";
            
            try
            {
                NLinea_credito.ModificarCMEDisponible(lin);
            }
            catch (Exception)
            {
                
                throw;
            }
            NPrestamo.ModificarEstadoPrestamo(pres);
            buttonX4.Enabled = false;
            //MessageBox.Show("Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
