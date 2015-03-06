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
    public partial class FrmPagoInicial : DevComponents.DotNetBar.Office2007Form
    {
        public static string res = "no";
        public static int nro = 0;
        public static float vuelto, billete;
        public FrmPagoInicial()
        {
            InitializeComponent();
        }

        private void FrmPagoInicial_Load(object sender, EventArgs e)
        {
            tbxTotal.Text = FrmCaja.inicial.ToString("0.00");
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
                //MessageBox.Show(billete.ToString());
                //MessageBox.Show(total.ToString());
                if (billete <Convert.ToSingle( FrmCaja.inicial))
                {
                    MessageBox.Show("Usted debe cancelar con una cantidad mayor a la inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (NVenta.Cobrar(aux2))
                    {
                        MessageBox.Show("Cobro efectuado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ImprimirBoletaInicial();
                        Close();
                        res = "si";
                    }
                }
                
            }
        }

        private void tbxBillete_TextChanged(object sender, EventArgs e)
        {
            if (tbxBillete.Text.Trim().Length > 0)
            {
                billete = Convert.ToSingle(tbxBillete.Text);
                vuelto= billete - Convert.ToSingle( FrmCaja.inicial);
                tbxVuelto.Text = vuelto .ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        void ImprimirBoletaInicial()
        {
            nro = 0;
            //btnCobrar.Enabled = true;
            var doc = new Document(PageSize.A4, 30f, 20f, 50f, 20f);
            PdfWriter.GetInstance(doc, new FileStream("Boleta2.pdf", FileMode.Create));

            //Creando la fuente para el encabezado
            var tipo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            var fuente = new iTextSharp.text.Font(tipo, 9, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            //Creando la fuente para lo suguiente
            var tipo2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            var fuente2 = new iTextSharp.text.Font(tipo, 13, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            var separacion = new Paragraph("\n");

            var l1 = new Paragraph("Boleta de venta", fuente);
            l1.Alignment = Element.ALIGN_CENTER;
            var l2 = new Paragraph("Cliente = " + FrmCaja.cliente,fuente);
            var l3 = new Paragraph("Direccion= " + FrmCaja. direccion , fuente);
            var l4 = new Paragraph("R.U.C.= " + FrmCaja. ruc , fuente);
            var l5 = new Paragraph("DNI= " + FrmCaja. dni , fuente);
            var l5_1 = new Paragraph("Fecha: " + DateTime.Now.ToShortDateString());
            var l6 = new Paragraph("Total: " + FrmCaja.inicial);
            //l6.Alignment = Element.ALIGN_RIGHT;
            //var tabla = new PdfPTable(4);
            //var ancho = new[] { 30, 100, 100, 50 };
            //tabla.TotalWidth = 540;
            //tabla.LockedWidth = true;
            //tabla.SpacingAfter = 20f;
            //tabla.SpacingBefore = 20f;
            //tabla.SetWidths(ancho);
            //tabla.AddCell("Nro");
            //tabla.AddCell("Modelo");
            //tabla.AddCell("Marca");
            //tabla.AddCell("Precio");
            doc.Open();

            doc.Add(l1);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(l2);
            doc.Add(l3);
            doc.Add(l4);
            doc.Add(l5);
            //foreach (DataGridViewRow item in dgvCarrito.Rows)
            //{
            //    nro++;
            //    tabla.AddCell(nro.ToString());
            //    tabla.AddCell(item.Cells[1].Value.ToString());
            //    tabla.AddCell(item.Cells[0].Value.ToString());
            //    tabla.AddCell(item.Cells[6].Value.ToString());
            //    //tabla.AddCell(item.Cells[3].Value.ToString());

            //    //tabla.AddCell(item.Cells[5].Value.ToString());
            //}
            //doc.Add(tabla);
            doc.Add(separacion); doc.Add(separacion);
            doc.Add(l6);
            doc.Close();
        }
    }
}
