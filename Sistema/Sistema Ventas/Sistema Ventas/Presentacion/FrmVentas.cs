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
    public partial class FrmVentas : DevComponents.DotNetBar.Office2007Form
    {
        public static Boolean venta = false;
        public static int idvendedor, idcliente,idcategoria;
        public static Cliente cli = null;
        public static Empleado emp = null;
        public static DetalleProductoVenta pro;
        public static string tipo;
        public static float inicial,totalpre;
        //public static string empleado, cliente;
        float total = 0;
        public FrmVentas()
        {
            InitializeComponent();
        }
        void Limpiar()
        { 
            
                //habilitar(true);
                tbxPreventa.Text = "";

                tbxCliente.Text = "";
                cbxVendedor.Text = "";
                cbxCategoria.Text = "";
            //lisR = new ListaReservas();
            //con esto deberiamos poder guardar ventas sin la necesidad dce cerar reservas
            dgvCarrito.Rows.Clear();
            total = 0;
            tbxTotal.Text ="";
            tbxCliente.Clear();
            TBXtOTALvENTA.Text = "";
            idcliente = 0;
            idvendedor = 0;
            label21.Text = "";
            cbxTipoVenta.Text = "";
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
           

            

            TBXtOTALvENTA.Text = total.ToString("0.00");
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            venta = true;
            cli = new Cliente();
            var f = new FrmListaClientes();
            f.ShowDialog();
            
            if (cli.IdCliente > 0)
            {
                tbxCliente.Text = cli.Nombres+" "+cli.Apellidos;
                var lin = new LineaCredito();
                lin.IdCliente = cli.IdCliente;
                if ( NLinea_credito.FiltrarLinCredito(lin)>=1)
                {
                    //var g = new FrmAvisoLineaCredito();
                    //g.Show();
                    
                    var idcli = FrmVentas.cli.IdCliente;
                    var aux = new LineaCredito();
                    aux.IdCliente = idcli;
                    foreach (var item in NLinea_credito.ListadoFiltroLinCredito(aux))
                    {
                        //aux.IdLinea_credito = item.IdLinea_credito;
                        //label3.Text = Convert.ToString(item.cme);
                        //label4.Text = Convert.ToString(item.cmedisponible);
                        MessageBox.Show("*********Linea de credito aprobada**********" + "\n"+"\n" + "CME:     "+item.cme+"\n"+"CME disponible:     "+item.cmedisponible,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    
                }
            }
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            idcategoria = Convert.ToInt32( cbxCategoria.SelectedValue);
            pro = new DetalleProductoVenta();

            var f = new FrmBuscarProductos();
            f.ShowDialog();

            if (pro.IdProducto > 0)
            {
                tbxModeloProducto.Text = pro.Modelo;
                tbxPrecio1.Text = Convert.ToSingle( pro.Precio).ToString("0.00");
                nudCantidad.Value = 1;
                tbxDescuento_porcentaje.Text = "0";
                tbxDescuento.Text = "0.00";
                MessageBox.Show("***STOCK:*** " + pro.stock.ToString(),"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (tbxDescuento_porcentaje.Text.Length == 0)
                {
                    tbxDescuento.Clear();
                    tbxTotal.Clear();
                }
                else
                {

                    tbxDescuento.Text = ((float.Parse(tbxDescuento_porcentaje.Text) / 100f) * (float.Parse(tbxPrecio1.Text.Trim()) * Convert.ToInt32(nudCantidad.Value))).ToString("0.00");
                    if (tbxDescuento_porcentaje.Text.Length > 0)
                    {
                        tbxIGV.Text = ((float.Parse(tbxPrecio1.Text) * Convert.ToInt32(nudCantidad.Value) - float.Parse(tbxDescuento.Text.Trim())) * 0.18f).ToString("0.00").Trim();
                        tbxPrecio2.Text = ((float.Parse(tbxPrecio1.Text) * Convert.ToInt32(nudCantidad.Value) - float.Parse(tbxDescuento.Text.Trim()))).ToString("0.00");

                    }
                    if (tbxPrecio2.Text.Length > 0 && tbxDescuento.Text.Length > 0)
                    {
                        totalpre = (float.Parse(tbxPrecio2.Text) + float.Parse(tbxIGV.Text));
                        tbxTotal.Text = totalpre.ToString("0.00");
                    }


                }
                btnAgregar.Enabled = true;
            }
        }
        private void cbxTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoVenta.Text == "Credito")
            {
                label17.Visible = true;
                cbxCampaña.Visible = true;
                cbxCampaña.Items.Clear();
                cbxCampaña.Items.Add("");
                cbxCampaña.Items.Add("Cash 8 partes");
                cbxCampaña.Items.Add("Cash 4 partes");
                cbxCampaña.Items.Add("Normal");
                cbxCampaña.Items.Add("Creditecnológico");
                cbxCampaña.Enabled = true;
                tbxDescuento_porcentaje.ReadOnly = true;
                tbxDescuento.ReadOnly = true;
                textBox2.ReadOnly = false;
            }
            else
            {
                label17.Visible = false;
                cbxCampaña.Visible = false;
                textBox2.ReadOnly = true;
            }
        }
        private void tbxDescuento_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("waaa");
            if (tbxDescuento_porcentaje.Text.Length==0)
            {
                tbxDescuento.Text="0.00";
                tbxTotal.Text = totalpre.ToString() ;
            }
            else
            {
                tbxDescuento.Text = ((float.Parse(tbxDescuento_porcentaje.Text) / 100f) * (float.Parse(tbxPrecio1.Text.Trim()) * Convert.ToInt32(nudCantidad.Value))).ToString("0.00");
                if (tbxDescuento_porcentaje.Text.Length > 0)
                {
                    tbxIGV.Text = ((float.Parse(tbxPrecio1.Text) * Convert.ToInt32(nudCantidad.Value) - float.Parse(tbxDescuento.Text.Trim())) * 0.18f).ToString("0.00").Trim();
                    tbxPrecio2.Text = ((float.Parse(tbxPrecio1.Text) * Convert.ToInt32(nudCantidad.Value) - float.Parse(tbxDescuento.Text.Trim()))).ToString("0.00");

                }
                if (tbxPrecio2.Text.Length>0 && tbxDescuento.Text.Length>0)
                {
                    tbxTotal.Text = ((float.Parse(tbxPrecio2.Text) + float.Parse(tbxIGV.Text))).ToString("0.00");   
                }
                
                
            }

            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var aux = new Venta();
            var nropreventa = NVenta.ObtenerNro();
                if (cbxTipoVenta.Text=="")
                {
                    MessageBox.Show("Seleccione tipo de venta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (cbxVendedor.Text.Trim()=="")
                    {
                        MessageBox.Show("Ustes no puede registrar la venta, Esta operacion solo puede ser efectuada por un empleado contratado como vendedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (tbxCliente.Text.Length == 0)
                        {
                            MessageBox.Show("Busque al cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            if (dgvCarrito.RowCount == 0)
                            {
                                MessageBox.Show("Busque productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                aux.IdCliente = cli.IdCliente;
                                aux.IdEmpleado = emp.IdEmpleado;
                                aux.IdEmpresa = 1;
                                aux.Tipo_venta = cbxTipoVenta.Text;
                                aux.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                                aux.Nro_venta = int.Parse(nropreventa);
                                aux.Estado = "Preventa";
                                aux.Pago_a_cuenta = 0;
                                aux.Total = float.Parse(TBXtOTALvENTA.Text.Trim());
                                var lista = new List<DetalleVentas>();
                                foreach (DataGridViewRow item in dgvCarrito.Rows)
                                {
                                    var d = new DetalleVentas();
                                    d.IdProducto = (int)item.Cells[0].Value;
                                    d.Cantidad = (int)item.Cells[4].Value;

                                    d.Venta_bruta = (float)item.Cells[3].Value;
                                    d.Descuento = (Single)item.Cells[6].Value;
                                    d.igv = (Single)item.Cells[7].Value;
                                    d.Valor_venta = (Single)item.Cells[8].Value;
                                    d.Comision = (float)item.Cells[5].Value;
                                    d.NroSerie = "";
                                    lista.Add(d);
                                }
                                aux.ListaDetalle = lista;
                                if (cbxTipoVenta.Text.Trim() == "Contado")
                                {

                                    tbxDescuento.ReadOnly = true;
                                    if (NVenta.Guardar(aux))
                                    {
                                        tbxPreventa.Text = nropreventa.ToString();
                                        MessageBox.Show("Guardado,Escriba la preventa", "Avso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        btnGuardar.Enabled = false;
                                        tbxPreventa.Focus();
                                        label21.Text = "*****Presione ENTER para continuar*****";
                                        //Limpiar();
                                    }
                                }
                                else
                                {

                                    if (cbxCampaña.Text == "")
                                    {
                                        MessageBox.Show("Seleccione tipo de credito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        //btnGuardar.Enabled = true;
                                    }
                                    else
                                    {
                                        tipo = cbxCampaña.Text;

                                        if (textBox2.Text.Length <= 0)
                                        {
                                            aux.Pago_a_cuenta = 0;

                                        }
                                        else
                                        {
                                            aux.Pago_a_cuenta = Convert.ToSingle(textBox2.Text.Trim());
                                            inicial = Convert.ToSingle(textBox2.Text.Trim());
                                        }

                                        //tbxPreventa.Text = nropreventa.ToString();
                                        //btnGuardar.Enabled = false;
                                        if (cbxCampaña.Text == "Cash 8 partes" || cbxCampaña.Text.Trim() == "Cash 4 partes")
                                        {

                                            if (inicial > 0)
                                            {
                                                if (textBox2.Text.Length > 0)
                                                {
                                                    if (Convert.ToSingle(textBox2.Text.Trim()) > 0.2 * total)
                                                    {
                                                        inicial = Convert.ToSingle(textBox2.Text.Trim());
                                                        if (NVenta.Guardar(aux))
                                                        {
                                                            //MessageBox.Show("Guardado", "Avso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            btnAgregar.Enabled = false;
                                                            //btnGuardar.Enabled = false;
                                                            var f = new FrmPrestamos();
                                                            f.ShowDialog();
                                                            if (FrmPrestamos.est == true)
                                                            {
                                                                tbxPreventa.Text = nropreventa.ToString();
                                                                btnGuardar.Enabled = false;
                                                                tbxPreventa.Focus();
                                                                label21.Text = "*****Presione ENTER para continuar*****";
                                                            }
                                                            

                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Este tipo de campaña requiere del 20% de inicial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        btnGuardar.Enabled = true;
                                                    }

                                                }
                                                else
                                                {
                                                    inicial = 0;
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingrese la inicial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }

                                        }
                                        else
                                        {
                                            if (NVenta.Guardar(aux))
                                            {
                                                //MessageBox.Show("Guardado", "Avso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                //btnGuardar.Enabled = false;
                                                var f = new FrmPrestamos();
                                                f.ShowDialog();
                                                if (FrmPrestamos.est == true)
                                                {
                                                    tbxPreventa.Text = nropreventa.ToString();
                                                    btnGuardar.Enabled = false;
                                                    inicial = 0;
                                                    btnAgregar.Enabled = false;
                                                    tbxPreventa.Focus();
                                                    label21.Text = "*****Presione ENTER para continuar*****";
                                                }
                                                

                                            }
                                        }

                                    }

                                }
                            }

                        }
                    }
                    
                    
                }
                
            }
            
            
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var comision=(float.Parse( tbxPrecio1.Text.Trim())*Convert.ToSingle(nudCantidad.Value))*0.01f;
            if (Convert.ToSingle(tbxDescuento_porcentaje.Text) > 5)
                {
                    MessageBox.Show("El porcentaje debe ser menor al 5% del valor del producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (pro.IdProducto > 0)
                    {
                        
                        foreach (DataGridViewRow item in dgvCarrito.Rows)
                        {
                            if (pro.IdProducto==(int) item.Cells[0].Value)
                            {
                                
                                
                                //item.Cells[4].Value = Convert.ToInt32(item.Cells[4].Value)+1;
                                MessageBox.Show("Ya ha ingresado este producto a la lisata","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                dgvCarrito.Rows.RemoveAt(dgvCarrito.RowCount - 1);
                                //var f = dgvCarrito.CurrentRow;
                                var importe2 = (float)item.Cells[8].Value;
                                total -= importe2;
                                TBXtOTALvENTA.Text = total.ToString("0.00");
                            }
                            else
                            {
                                
                            }
                        }
                        dgvCarrito.Rows.Add(pro.IdProducto, pro.Marca, pro.Modelo, float.Parse(tbxPrecio2.Text.Trim()), Convert.ToInt32(nudCantidad.Value), comision, float.Parse(tbxDescuento.Text.Trim()), float.Parse(tbxIGV.Text.Trim()), float.Parse(tbxTotal.Text.Trim()));
                        var importe = float.Parse(tbxTotal.Text.Trim());
                        total += importe;
                        TBXtOTALvENTA.Text = total.ToString();
                        
                        
                    }
                }
            
            
            

            //MessageBox.Show(float.Parse(tbxTotal.Text.Trim()).ToString());
            
            
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text="";
                }
            }
            btnGuardar.Enabled=true;
        }
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            nudCantidad.Maximum = Convert.ToInt32(pro.stock);
            if (tbxDescuento_porcentaje.Text.Length == 0)
            {
                tbxDescuento.Clear();
                tbxTotal.Clear();
            }
            else
            {

                tbxDescuento.Text = ((float.Parse(tbxDescuento_porcentaje.Text) / 100f) * (float.Parse(tbxPrecio1.Text.Trim()) * Convert.ToInt32(nudCantidad.Value))).ToString("0.00");
                if (tbxDescuento_porcentaje.Text.Length > 0)
                {
                    tbxIGV.Text = ((float.Parse(tbxPrecio1.Text) * Convert.ToInt32(nudCantidad.Value) - float.Parse(tbxDescuento.Text.Trim())) * 0.18f).ToString("0.00").Trim();
                    tbxPrecio2.Text = ((float.Parse(tbxPrecio1.Text) * Convert.ToInt32(nudCantidad.Value) - float.Parse(tbxDescuento.Text.Trim()))).ToString("0.00");

                }
                if (tbxPrecio2.Text.Length > 0 && tbxDescuento.Text.Length > 0)
                {
                    tbxTotal.Text = ((float.Parse(tbxPrecio2.Text) + float.Parse(tbxIGV.Text))).ToString("0.00");
                }
            }
        }

        private void cbxVendedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            emp=new Empleado();
            var id=Convert.ToInt32( cbxVendedor.SelectedValue);
            emp.IdEmpleado = id;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.RowCount > 0)
            {
                var f = dgvCarrito.CurrentRow;
                var importe = (float)f.Cells[8].Value;
                total -= importe;
                TBXtOTALvENTA.Text = total.ToString("0.00");
                dgvCarrito.Rows.Remove(f);
                //btnGuardar.Enabled = true;
            }
            //else if(dgvCarrito.RowCount==1)
            //{
            //    btnGuardar.Enabled = false;
            //}
        }

        private void tbxModeloProducto_TextChanged(object sender, EventArgs e)
        {
            if (tbxModeloProducto.Text.Length==0)
            {
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TBXtOTALvENTA.Text = total.ToString("0.00");
            if (textBox2.Text.Length>0)
            {
                TBXtOTALvENTA.Text = (float.Parse(TBXtOTALvENTA.Text) - float.Parse(textBox2.Text.Trim())).ToString("0.00");
            }
            
        }

        private void FrmVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Limpiar();
            }
        }

        private void tbxPreventa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Limpiar();
            }
        }

        private void tbxDescuento_porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("Intrduzca solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbxDescuento_porcentaje_MaskChanged(object sender, EventArgs e)
        {
            //TBXtOTALvENTA.Text = total.ToString("0.00");
            //if (textBox2.Text.Length > 0)
            //{
            //    TBXtOTALvENTA.Text = (float.Parse(TBXtOTALvENTA.Text) - float.Parse(textBox2.Text.Trim())).ToString("0.00");
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxVendedor_Click(object sender, EventArgs e)
        {
            cbxVendedor.DataSource = NEmpladoContratado.ListaVendedores();
            cbxVendedor.DisplayMember = "Empleado";
            cbxVendedor.ValueMember = "idEmpleado";

            emp = new Empleado();
            var id = Convert.ToInt32(cbxVendedor.SelectedValue);
            emp.IdEmpleado = id;
        }

        private void cbxCategoria_Click(object sender, EventArgs e)
        {
            cbxCategoria.DataSource = NCategoria.ListarCategorias();
            cbxCategoria.DisplayMember = "NombreCategoria";
            cbxCategoria.ValueMember = "idCategoria";
            if (cbxCategoria.Items.Count==0)
            {
                var pre = MessageBox.Show("waa", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }



    }
}
