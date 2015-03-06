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
    public partial class FrmCierreCaja : DevComponents.DotNetBar.Office2007Form
    {
        
        public FrmCierreCaja()
        {
            InitializeComponent();
        }

        private void FrmCierreCaja_Load(object sender, EventArgs e)
        {
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var lista = NCaja.CierreCaja();
            float total = 0,total2=0;

            tbxEmpleado.Text = FrmIngreso.empleado.ToString();
            foreach (var item in lista)
            {
                dataGridViewX1.Rows.Add(item.TotalVenta, item.Motivo);
                total += item.TotalVenta;
            }
            total = Convert.ToSingle(decimal.Round(Convert.ToDecimal(total), 2));
            tbxTotalIngresos.Text = total.ToString("0.00");
            //dgv 2
            var lista2=NEgreso.CierreCaja2();
            foreach (var item in lista2)
            {
                dataGridViewX2.Rows.Add(item.Total, item.Motivo);
                total2 += item.Total;
            }
            total2 = Convert.ToSingle(decimal.Round(Convert.ToDecimal(total2), 2));
            tbxTotalEgresos.Text = total2.ToString("0.00");
            ImprimirBoleta();
            
            
        }
        void ImprimirBoleta()
        {
           
            var doc = new Document(PageSize.A4, 30f, 20f, 50f, 20f);
            PdfWriter.GetInstance(doc, new FileStream("Cierre de Caja.pdf", FileMode.Create));

            //Creando la fuente para el encabezado
            var tipo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            var fuente = new iTextSharp.text.Font(tipo, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            //Creando la fuente para lo suguiente
            var tipo2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            var fuente2 = new iTextSharp.text.Font(tipo, 13, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            var separacion = new Paragraph("\n");

            var l1 = new Paragraph("****************************Cierre de caja********************************", fuente);
            l1.Alignment = Element.ALIGN_CENTER;
            var l2 = new Paragraph("Empleado = " + tbxEmpleado.Text,fuente);
            //var l3 = new Paragraph("Direccion= " + direccion + "                                                     Nro. transaccion: " + nro_tran, fuente);
            //var l4 = new Paragraph("R.U.C.= " + ruc + "                                                                  Fecha: " + DateTime.Now.ToShortDateString(), fuente);
            var l3 = new Paragraph("Total de ingresos = " + tbxTotalIngresos.Text,fuente);
            var l4= new Paragraph("Total de egresos = " + tbxTotalEgresos.Text,fuente);
            var l4_2 = new Paragraph("Total = " + (Convert.ToSingle(tbxTotalIngresos.Text) - Convert.ToSingle(tbxTotalEgresos.Text)).ToString("0.00"),fuente);
            var l5 = new Paragraph("....................        ", fuente);
            var l6 = new Paragraph("           Gerente               ");
            l3.Alignment = Element.ALIGN_RIGHT;
            l4.Alignment = Element.ALIGN_RIGHT;
            l4_2.Alignment = Element.ALIGN_RIGHT;
            l5.Alignment = Element.ALIGN_RIGHT;
            l6.Alignment = Element.ALIGN_RIGHT;
            var tabla = new PdfPTable(2);
            var tabla2 =new PdfPTable(2);
            var ancho = new[] { 50, 80};
            
            tabla.TotalWidth = 540;
            tabla.LockedWidth = true;
            tabla.SpacingAfter = 20f;
            tabla.SpacingBefore = 20f;
            tabla.SetWidths(ancho);
            tabla2.TotalWidth = 540;
            tabla2.LockedWidth = true;
            tabla2.SpacingAfter = 20f;
            tabla2.SpacingBefore = 20f;
            tabla2.SetWidths(ancho);
            tabla.AddCell("Monto");
            tabla.AddCell("Concepto");
            tabla2.AddCell("Monto");
            tabla2.AddCell("Concepto");
            doc.Open();

            doc.Add(l1);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(l2);
            
            
            foreach (DataGridViewRow item in dataGridViewX1.Rows)
            {
                tabla.AddCell(item.Cells[0].Value.ToString());
                tabla.AddCell(item.Cells[1].Value.ToString());
            }
            foreach (DataGridViewRow item in dataGridViewX2.Rows)
            {
                tabla2.AddCell(item.Cells[0].Value.ToString());
                tabla2.AddCell(item.Cells[1].Value.ToString());
            }
            doc.Add(tabla);
            doc.Add(l3);
            doc.Add(tabla2);
            doc.Add(l4);
            doc.Add(l4_2);
            doc.Add(separacion); doc.Add(separacion); doc.Add(separacion);
            doc.Add(l5);
            doc.Add(l6);
            doc.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
