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
    public partial class FrmPagoCuotas : DevComponents.DotNetBar.Office2007Form
    {
        public static float debe = 0,paga_con,total;
        public int idpres;
        public FrmPagoCuotas()
        {
            InitializeComponent();
        }

        private void FrmPagoCuotas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = tbxDNIa_buscar.Text.Trim();
            if (dni.Length == 0 || dni.Length < 8)
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
                    tbxDireccion.Text = item.Direccion;
                }
                foreach (var item in lista2)
                {
                    dgvPrestamos.Rows.Add(item.IdPrestamo,item.Capital_prestado,item.Fec_desembolso,item.Plazo_nrouotas,item.Estado);
                }
                if (tbxCliente.Text.Length>0)
                {
                    buttonX1.Enabled = true;
                }
                
            }
        }

        private void dataGridViewX2_Click(object sender, EventArgs e)
        {
            VerDatos2();
        }

        private void VerDatos2()
        {
            if (dgvPrestamos.RowCount > 0)
            {

                idpres = (int)dgvPrestamos.CurrentRow.Cells[0].Value;
                //MessageBox.Show(id.ToString());
                var lista = NEstadoCuenta.ListaEntidades2(idpres);
                dgvPagos.Rows.Clear();
                foreach (var item in lista)
                {
                    dgvPagos.Rows.Add(false, item.IdPago, item.IdPrestamo, item.Nro, item.Fec_vencimiento, item.Total, item.Debe, item.Fec_Pago);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var filas = new List<DataGridViewRow>();
            foreach(DataGridViewRow fila  in dgvPagos.Rows)
            {
                DataGridViewCheckBoxCell celda = fila.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(celda.Value))
                {
                    filas.Add(fila);
                    debe +=Convert.ToSingle( fila.Cells[6].Value);
                }
            }
                var f = new FrmPago2();
                f.ShowDialog();
                
                if (FrmPago2.res.Trim() == "si")
                {

                    foreach (DataGridViewRow fila in filas)
                    {
                        //debe += Convert.ToSingle(fila.Cells[4].Value);
                        var pagos = new Pago();
                        pagos.Debe = 0;
                        pagos.Fec_pago = DateTime.Now.ToShortDateString();
                        pagos.IdPago = (int)fila.Cells[1].Value;
                        NPagos.ModficarPagos(pagos);
                    }
                    var caj = new Caja();
                    caj.IdVenta = NPrestamo.FiltrarIdVenta(idpres);
                    caj.IdEmpleado = FrmIngreso.idempleado;
                    caj.Monto = debe;
                    caj.Motivo = "Pago de cuotas";
                    caj.Fecha = Convert.ToDateTime( DateTime.Now.ToShortDateString());
                    NCaja.Guardar(caj);
                    MessageBox.Show("Cobro realizado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VerDatos2();
                    ImprimirBoleta();
                    buttonX1.Enabled = false;
                    Limpiar();
                }

                
                
            
            
        }

        private void Limpiar()
        {
            tbxDNIa_buscar.Text = "";
            tbxCliente.Text = "";
            tbxDireccion.Text = "";
            dgvPrestamos.Rows.Clear();
            dgvPagos.Rows.Clear();
            debe = 0;
        }

        private void ImprimirBoleta()
        {
            var doc = new Document(PageSize.A4, 30f, 20f, 50f, 20f);
            PdfWriter.GetInstance(doc, new FileStream("Estado de cuenta.pdf", FileMode.Create));

            //Creando la fuente para el encabezado
            var tipo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            var fuente = new iTextSharp.text.Font(tipo, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            //Creando la fuente para lo suguiente
            var tipo2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            var fuente2 = new iTextSharp.text.Font(tipo, 13, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            var separacion = new Paragraph("\n");

            var l1 = new Paragraph("VOUCHER DE PAGO*****", fuente);
            var l1_1 = new Paragraph("**************************", fuente);
            l1.Alignment = Element.ALIGN_CENTER;
            //var l1_2 = new Paragraph("        Nro. prestamo: " + tbxNro_prestamo.Text.Trim(), fuente);
            var l2 = new Paragraph("Cliente: " + tbxCliente.Text, fuente);
            var l3 = new Paragraph("Dni: " + tbxDNIa_buscar.Text , fuente);
            var l4 = new Paragraph("Direccion: " + tbxDireccion.Text, fuente);
            var l5 = new Paragraph("Paga con: " + paga_con.ToString("0.00") , fuente);
            var l6 = new Paragraph("           _____________" , fuente);
            var l7 = new Paragraph("Total: " + debe.ToString("0.00"),fuente);
            //l6.Alignment = Element.ALIGN_RIGHT;
            //var tabla = new PdfPTable(5);
            //var ancho = new[] { 30, 100, 70, 70, 100 };
            //tabla.TotalWidth = 540;
            //tabla.LockedWidth = true;
            //tabla.SpacingAfter = 20f;
            //tabla.SpacingBefore = 20f;
            //tabla.SetWidths(ancho);

            //tabla.AddCell("Nro");
            //tabla.AddCell("Vencto.");
            //tabla.AddCell("Cuota");
            //tabla.AddCell("Debe");
            //tabla.AddCell("FecPago");
            doc.Open();

            doc.Add(l1);
            doc.Add(l1_1);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(l2);
            doc.Add(l3);
            doc.Add(l4);
            doc.Add(l5);
            //foreach (DataGridViewRow item in dgvPagos.Rows)
            //{

            //    tabla.AddCell(item.Cells[2].Value.ToString());
            //    tabla.AddCell(item.Cells[3].Value.ToString());
            //    tabla.AddCell(item.Cells[4].Value.ToString());
            //    tabla.AddCell(item.Cells[5].Value.ToString());
            //    tabla.AddCell(item.Cells[6].Value.ToString());
            //}
            //doc.Add(tabla);
            doc.Add(l6);
            doc.Close();
        }
        
    }
}
