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
    public partial class FrmEstadoCuenta : DevComponents.DotNetBar.Office2007Form
    {
        public FrmEstadoCuenta()
        {
            InitializeComponent();
        }

        private void FrmEstadoCuenta_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = tbxDNIa_buscar.Text.Trim();
            if (dni.Length==0 || dni.Length<8)
            {
                MessageBox.Show("El dni debe tener 8 digitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var lista1 = NEstadoCuenta.ListaEntidades(dni);
                var lista2 = NPrestamo.ListarPrestamos(dni);
                foreach (var item in lista1)
                {
                    tbxCliente.Text = item.Cliente;
                    tbxDNICliente.Text = item.DNI;
                    tbxCME.Text = item.cme.ToString("0.00");
                    TBXcmeDisponible.Text = item.cmedisponible.ToString("0.00");
                    tbxDireccion.Text = item.Direccion;
                    tbxVendedor.Text = item.Vendedor;
                    tbxDNIVendedor.Text = item.DNI_vendedor;
                }
                foreach (var item in lista2)
                {
                    dgvPrestamos.Rows.Add(item.IdPrestamo, item.Capital_prestado, item.Fec_desembolso.ToShortDateString(), item.Plazo_nrouotas, item.Estado);
                }
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPrestamos_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count==1)
            {
                int id = (int)dgvPrestamos.CurrentRow.Cells[0].Value;
                var lista = NEstadoCuenta.ListaEntidades3(id);
                dgvPagos.Rows.Clear();
                foreach (var item in lista)
                {
                    dgvPagos.Rows.Add(item.IdPago, item.IdPrestamo, item.Nro, item.Fec_vencimiento.ToShortDateString(), item.Total, item.Debe, item.Fec_Pago);
                }
                
                foreach (DataGridViewRow item in dgvPagos.Rows)
	            {
                    //MessageBox.Show(item.Cells[4].Value.ToString());
                    //MessageBox.Show(item.Cells[5].Value.ToString());
                    if ((item.Cells[4].Value.ToString().Trim() == item.Cells[5].Value.ToString().Trim()))
                    {
                        item.Cells[7].Value = "-";
                    }
                    else
                    {
                        var fec_ven = Convert.ToDateTime(item.Cells[3].Value);
                        var dias = (Convert.ToDateTime(DateTime.Now.ToShortDateString()) - fec_ven).Days;
                        item.Cells[7].Value = Convert.ToInt32(dias);
                    }
                    
	            }
        //        For Each f As DataGridViewRow In LectoresDataGridView.Rows
        //    idl = f.Cells(0).Value
        //    can = LectoresTableAdapter.Cantidad(idl) 'obtenemos la cantidad de prestamos de cada lector
        //    f.Cells(5).Value = can
        //Next
            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //nro = 0;
            //btnCobrar.Enabled = true;
            var doc = new Document(PageSize.A4, 30f, 20f, 50f, 20f);
            PdfWriter.GetInstance(doc, new FileStream("Estado de cuenta.pdf", FileMode.Create));

            //Creando la fuente para el encabezado
            var tipo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            var fuente = new iTextSharp.text.Font(tipo, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            //Creando la fuente para lo suguiente
            var tipo2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            var fuente2 = new iTextSharp.text.Font(tipo, 13, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            var separacion = new Paragraph("\n");

            var l1 = new Paragraph("Estado de cuenta", fuente);
            l1.Alignment = Element.ALIGN_CENTER;
            //var l1_2 = new Paragraph("        Nro. prestamo: " + tbxNro_prestamo.Text.Trim(), fuente);
            var l2 = new Paragraph("Cliente: " + tbxCliente.Text,fuente);
            var l3 = new Paragraph("Dni: " + tbxDNICliente.Text+ "                        Direccion: " + tbxDireccion.Text, fuente);
            
            var l4 = new Paragraph("Vendedor: " + tbxVendedor.Text, fuente);
            var l5 = new Paragraph("CME:              " + tbxCME.Text + "                 CME disponible" + TBXcmeDisponible.Text,fuente );
            //l6.Alignment = Element.ALIGN_RIGHT;
            var tabla = new PdfPTable(6);
            var ancho = new[] { 30, 100, 70, 70, 100 ,50};
            tabla.TotalWidth = 540;
            tabla.LockedWidth = true;
            tabla.SpacingAfter = 20f;
            tabla.SpacingBefore = 20f;
            tabla.SetWidths(ancho);

            tabla.AddCell("Nro");
            tabla.AddCell("Vencto.");
            tabla.AddCell("Cuota");
            tabla.AddCell("Debe");
            tabla.AddCell("FecPago");
            tabla.AddCell("Dias_Mora");
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
            foreach (DataGridViewRow item in dgvPagos.Rows)
            {

                tabla.AddCell(item.Cells[2].Value.ToString());
                tabla.AddCell(item.Cells[3].Value.ToString());
                tabla.AddCell(item.Cells[4].Value.ToString());
                tabla.AddCell(item.Cells[5].Value.ToString());
                tabla.AddCell(item.Cells[6].Value.ToString());
                tabla.AddCell(item.Cells[7].Value.ToString());
                
                
                
            }
            doc.Add(tabla);
            //doc.Add(l6);
            doc.Close();
        }
    }
}
