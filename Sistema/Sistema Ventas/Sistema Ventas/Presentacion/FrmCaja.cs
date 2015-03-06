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
    public partial class FrmCaja : DevComponents.DotNetBar.Office2007Form
    {
        public static string direccion="",ruc="",dni="",cod_vendedor="",nro_tran="",cliente="",total="";
        public static string cli;
        public static int idcli, nro=0,idventaglobal;
        public static Venta aux=null;
        public static float inicial = 0,totalventa;
        public FrmCaja()
        {
            InitializeComponent();
        }

        private void tbxPreventa_KeyDown(object sender, KeyEventArgs e)
        {
            limpiar();
            totalventa = 0;
            if (e.KeyCode==Keys.Enter)
            {
                if (tbxPreventa.Text.Length>0)
                {
                    
                    aux = new Venta();
                    aux.Nro_venta = Convert.ToInt32(tbxPreventa.Text.Trim());
                    nro_tran = aux.Nro_venta.ToString();
                    var lista1 = NListarVenta.ListaEntidades(aux);
                    dgvCarrito.Rows.Clear();
                    //if (lista1.Count>0)
                    //{
                    foreach (var item in lista1)
                    {
                        idcli = item.IdCliente;
                        tbxTipoVenta.Text = item.Tipo_venta;
                        tbxEmpleado.Text = item.Vendedor;
                        tbxCliente.Text = item.Cliente;
                        dni = item.dni;
                        direccion = item.Direccion;
                        cod_vendedor = item.CodVendedor;
                        //TBXtOTALvENTA.Text = item.Total.ToString();
                        if (tbxTipoVenta.Text.Trim() == "Credito")
                        {
                            label17.Visible = true;
                            tbxInicial.Visible = true;
                            tbxInicial.Text = item.Pago_a_cuenta.ToString("0.00");
                            inicial = Convert.ToSingle(tbxInicial.Text);
                            cliente = tbxCliente.Text;
                            //total = tbxInicial.Text.Trim();
                        }
                        else
                        {
                            label17.Visible = false;
                            tbxInicial.Visible = false;
                        }
                    }

                    aux.IdVenta = NListarVenta.ObtenerIDVenta(aux);
                    idventaglobal = NListarVenta.ObtenerIDVenta(aux);
                    //MessageBox.Show(aux.IdVenta.ToString());
                    var lista2 = NListarVenta.ListaEntidades2(aux);
                    foreach (var item in lista2)
                    {
                        dgvCarrito.Rows.Add(item.Marca, item.Modelo, item.Precio, item.Cantidad, item.Descuento, item.IGV, item.ValorVenta, item.Stock);
                    }
                    foreach (DataGridViewRow item in dgvCarrito.Rows)
                    {
                        totalventa += Convert.ToSingle(item.Cells[6].Value);
                    }
                    TBXtOTALvENTA.Text = totalventa.ToString("0.00");
                    if (TBXtOTALvENTA.Text.Length > 0)
                    {
                        aux.Total = Convert.ToSingle(TBXtOTALvENTA.Text.Trim());
                    }
                    if (tbxCliente.Text.Length > 0)
	                {
                        btnCobrar.Enabled = true;
                    }
                    else
                    {
                        btnCobrar.Enabled = false;
                    }     
                    
                }
                
                //}
                
                
            }
            
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            var caj = new Caja();
            caj.IdVenta = idventaglobal;
            //MessageBox.Show(idventaglobal.ToString());
            caj.IdEmpleado = FrmIngreso.idempleado;
            caj.Motivo = "Venta";
            caj.Monto = totalventa;
            caj.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (tbxTipoVenta.Text.Trim()=="Contado")
            {
                var f = new FrmPago();
                f.ShowDialog();
                if (FrmPago.res == "si")
                {
                    ImprimirBoleta();
                   
                    if (NCaja.Guardar(caj))
                    {
                        MessageBox.Show("Ingreso a caja registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                ImprimirBoleta();
                if (inicial>0)
                {
                    var c = new FrmPagoInicial();
                    c.ShowDialog();
                    cli = tbxCliente.Text;
                    if (FrmPagoInicial.res == "si")
                    {
                        
                        caj.Monto = inicial;
                        caj.Motivo = "Pago a cuenta - inicial";

                        var f = new FrmPagoCredito();
                        f.ShowDialog();
                        //var f = new FrmListaEmpleados();
                        //f.MdiParent = this;
                        //f.Show();
                        if (FrmPagoCredito.res.Trim()=="si")
                        {
                            if (NCaja.Guardar(caj))
                            {
                                MessageBox.Show("Ingreso a caja registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("EL ingreso a caja no se registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    
                }
                else
                {
                    var f = new FrmPagoCredito();
                    f.ShowDialog();
                    //ImprimirBoleta();
                }
                
                
            }
            
        }
        void limpiar()
        {
            //tbxPreventa.Text = "";
            tbxEmpleado.Text = "";
            tbxCliente.Text = "";
            tbxTipoVenta.Text = "";
            dgvCarrito.Rows.Clear();
            TBXtOTALvENTA.Text = "0.00";

        }

        private void tbxPreventa_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {

        }
        void ImprimirBoleta()
        {
            nro = 0;
            //btnCobrar.Enabled = true;
            var doc = new Document(PageSize.A4, 30f, 20f, 50f, 20f);
            PdfWriter.GetInstance(doc, new FileStream("Boleta.pdf", FileMode.Create));

            //Creando la fuente para el encabezado
            var tipo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            var fuente = new iTextSharp.text.Font(tipo, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            //Creando la fuente para lo suguiente
            var tipo2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            var fuente2 = new iTextSharp.text.Font(tipo, 13, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            var separacion = new Paragraph("\n");

            var l1 = new Paragraph("Boleta de venta", fuente);
            l1.Alignment = Element.ALIGN_CENTER;
            var l2 = new Paragraph("Cliente = " + tbxCliente.Text);
            var l3 = new Paragraph("Direccion= " + direccion + "                                                     Nro. transaccion: " + nro_tran, fuente);
            var l4 = new Paragraph("R.U.C.= " + ruc + "                                                                  Fecha: " + DateTime.Now.ToShortDateString(), fuente);
            var l5 = new Paragraph("DNI= " + dni + "                                                      " + "Cod. vendedor= " + cod_vendedor, fuente);
            var l6 = new Paragraph("Total: " + TBXtOTALvENTA.Text);
            l6.Alignment = Element.ALIGN_RIGHT;
            var tabla = new PdfPTable(4);
            var ancho = new[] { 30, 100, 100, 50 };
            tabla.TotalWidth = 540;
            tabla.LockedWidth = true;
            tabla.SpacingAfter = 20f;
            tabla.SpacingBefore = 20f;
            tabla.SetWidths(ancho);
            tabla.AddCell("Nro");
            tabla.AddCell("Modelo");
            tabla.AddCell("Marca");
            tabla.AddCell("Precio");
            doc.Open();

            doc.Add(l1);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(separacion);
            doc.Add(l2);
            doc.Add(l3);
            doc.Add(l4);
            doc.Add(l5);
            foreach (DataGridViewRow item in dgvCarrito.Rows)
            {
                nro++;
                tabla.AddCell(nro.ToString());
                tabla.AddCell(item.Cells[1].Value.ToString());
                tabla.AddCell(item.Cells[0].Value.ToString());
                tabla.AddCell(item.Cells[6].Value.ToString());
                //tabla.AddCell(item.Cells[3].Value.ToString());

                //tabla.AddCell(item.Cells[5].Value.ToString());
            }
            doc.Add(tabla);
            doc.Add(separacion); doc.Add(separacion); doc.Add(separacion);
            doc.Add(l6);
            doc.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            tbxPreventa.Text = "";
            btnCobrar.Enabled = false;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxPreventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                e.Handled = true;
                MessageBox.Show("Intrduzca solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
