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
    public partial class FrmPago : DevComponents.DotNetBar.Office2007Form
    {
        public static string res = "no";
        public static int nro = 0;
        public FrmPago()
        {
            InitializeComponent();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (tbxBillete.Text.Trim().Length > 0)
            {

                var aux = new Venta();
                aux.Nro_venta = FrmCaja.aux.Nro_venta;
                var id = NListarVenta.ObtenerIDVenta(aux);
                var aux2 = new Venta();
                aux2.IdVenta = id;
                aux2.Estado = "1";
                //aca se cambia el estado de la venta de preventa a 1
                if (Convert.ToSingle(tbxBillete.Text.Trim()) > Convert.ToSingle(tbxTotal.Text))
                {
                    if (NVenta.Cobrar(aux2))
                    {
                        MessageBox.Show("Cobro efectuado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ImprimirBoleta();
                        Close();
                        res = "si";
                    }
                }
            }
            
            
        }

        //private static void ImprimirBoleta()
        //{
        //    nro = 0;
        //    //btnCobrar.Enabled = true;
        //    var doc = new Document(PageSize.A4, 30f, 20f, 50f, 20f);
        //    PdfWriter.GetInstance(doc, new FileStream("Boleta.pdf", FileMode.Create));

        //    //Creando la fuente para el encabezado
        //    var tipo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        //    var fuente = new iTextSharp.text.Font(tipo, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        //    //Creando la fuente para lo suguiente
        //    var tipo2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
        //    var fuente2 = new iTextSharp.text.Font(tipo, 13, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

        //    var separacion = new Paragraph("\n");

        //    var l1 = new Paragraph("Boleta de venta", fuente);
        //    l1.Alignment = Element.ALIGN_CENTER;
        //    var l2 = new Paragraph("Cliente = " + tbxCliente.Text);
        //    var l3 = new Paragraph("Direccion= " + direccion + "                                                     Nro. transaccion: " + nro_tran, fuente);
        //    var l4 = new Paragraph("R.U.C.= " + ruc + "                                                                  Fecha: " + DateTime.Now.ToShortDateString(), fuente);
        //    var l5 = new Paragraph("DNI= " + dni + "                                                      " + "Cod. vendedor= " + cod_vendedor, fuente);
        //    var l6 = new Paragraph("Total: " + TBXtOTALvENTA.Text);
        //    l6.Alignment = Element.ALIGN_RIGHT;
        //    var tabla = new PdfPTable(4);
        //    var ancho = new[] { 30, 100, 100, 50 };
        //    tabla.TotalWidth = 540;
        //    tabla.LockedWidth = true;
        //    tabla.SpacingAfter = 20f;
        //    tabla.SpacingBefore = 20f;
        //    tabla.SetWidths(ancho);
        //    tabla.AddCell("Nro");
        //    tabla.AddCell("Modelo");
        //    tabla.AddCell("Marca");
        //    tabla.AddCell("Precio");
        //    doc.Open();

        //    doc.Add(l1);
        //    doc.Add(separacion);
        //    doc.Add(separacion);
        //    doc.Add(separacion);
        //    doc.Add(l2);
        //    doc.Add(l3);
        //    doc.Add(l4);
        //    doc.Add(l5);
        //    foreach (DataGridViewRow item in dgvCarrito.Rows)
        //    {
        //        nro++;
        //        tabla.AddCell(nro.ToString());
        //        tabla.AddCell(item.Cells[1].Value.ToString());
        //        tabla.AddCell(item.Cells[0].Value.ToString());
        //        tabla.AddCell(item.Cells[6].Value.ToString());
        //        //tabla.AddCell(item.Cells[3].Value.ToString());

        //        //tabla.AddCell(item.Cells[5].Value.ToString());
        //    }
        //    doc.Add(tabla);
        //    doc.Add(separacion); doc.Add(separacion); doc.Add(separacion);
        //    doc.Add(l6);
        //    doc.Close();
        //}

        private void tbxBillete_TextChanged(object sender, EventArgs e)
        {
            if (tbxBillete.Text.Trim().Length > 0)
            {
                var b = Convert.ToSingle(tbxBillete.Text);
                var d = b - FrmCaja.aux.Total;
                tbxVuelto.Text = Convert.ToSingle(decimal.Round(Convert.ToDecimal( d),2)).ToString();
            }
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            tbxTotal.Text = FrmCaja.aux.Total.ToString("0.00");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
