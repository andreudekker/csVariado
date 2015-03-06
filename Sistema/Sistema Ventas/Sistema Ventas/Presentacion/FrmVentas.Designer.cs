namespace Presentacion
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCarrito = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPreventa = new System.Windows.Forms.TextBox();
            this.tbxCliente = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.cbxTipoVenta = new System.Windows.Forms.ComboBox();
            this.cbxVendedor = new System.Windows.Forms.ComboBox();
            this.cbxCampaña = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxModeloProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPrecio1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxIGV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TBXtOTALvENTA = new System.Windows.Forms.TextBox();
            this.tbxTotalIGV = new System.Windows.Forms.TextBox();
            this.tbxDescuentoTotall = new System.Windows.Forms.TextBox();
            this.tbxInicial = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxDescuento = new System.Windows.Forms.TextBox();
            this.tbxDescuento_porcentaje = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbxPrecio2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnQuitar = new DevComponents.DotNetBar.ButtonX();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column6,
            this.Column8,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCarrito.Location = new System.Drawing.Point(12, 304);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.Size = new System.Drawing.Size(637, 133);
            this.dgvCarrito.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IDPRODUCTO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MARCA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "MODELO";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Comision";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DESCUENTO";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "IGV";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TOTAL";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Preventa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo de venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vendedor:";
            // 
            // tbxPreventa
            // 
            this.tbxPreventa.BackColor = System.Drawing.Color.CadetBlue;
            this.tbxPreventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPreventa.Location = new System.Drawing.Point(108, 16);
            this.tbxPreventa.Name = "tbxPreventa";
            this.tbxPreventa.ReadOnly = true;
            this.tbxPreventa.Size = new System.Drawing.Size(100, 21);
            this.tbxPreventa.TabIndex = 0;
            this.tbxPreventa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPreventa_KeyDown);
            // 
            // tbxCliente
            // 
            this.tbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCliente.Location = new System.Drawing.Point(108, 123);
            this.tbxCliente.Name = "tbxCliente";
            this.tbxCliente.ReadOnly = true;
            this.tbxCliente.Size = new System.Drawing.Size(374, 21);
            this.tbxCliente.TabIndex = 6;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(108, 96);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(372, 23);
            this.cbxCategoria.TabIndex = 3;
            this.cbxCategoria.Click += new System.EventHandler(this.cbxCategoria_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.tbxPreventa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxTipoVenta);
            this.groupBox1.Controls.Add(this.cbxVendedor);
            this.groupBox1.Controls.Add(this.cbxCampaña);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbxCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 154);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(448, 123);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(32, 20);
            this.btnBuscarCliente.TabIndex = 14;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // cbxTipoVenta
            // 
            this.cbxTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVenta.FormattingEnabled = true;
            this.cbxTipoVenta.Items.AddRange(new object[] {
            "",
            "Contado",
            "Credito"});
            this.cbxTipoVenta.Location = new System.Drawing.Point(108, 42);
            this.cbxTipoVenta.Name = "cbxTipoVenta";
            this.cbxTipoVenta.Size = new System.Drawing.Size(140, 23);
            this.cbxTipoVenta.TabIndex = 13;
            this.cbxTipoVenta.SelectedIndexChanged += new System.EventHandler(this.cbxTipoVenta_SelectedIndexChanged);
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVendedor.FormattingEnabled = true;
            this.cbxVendedor.Location = new System.Drawing.Point(108, 69);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(371, 23);
            this.cbxVendedor.TabIndex = 4;
            this.cbxVendedor.SelectionChangeCommitted += new System.EventHandler(this.cbxVendedor_SelectionChangeCommitted);
            this.cbxVendedor.Click += new System.EventHandler(this.cbxVendedor_Click);
            // 
            // cbxCampaña
            // 
            this.cbxCampaña.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampaña.Enabled = false;
            this.cbxCampaña.FormattingEnabled = true;
            this.cbxCampaña.Location = new System.Drawing.Point(327, 41);
            this.cbxCampaña.Name = "cbxCampaña";
            this.cbxCampaña.Size = new System.Drawing.Size(152, 23);
            this.cbxCampaña.TabIndex = 4;
            this.cbxCampaña.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(257, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "Campaña:";
            this.label17.Visible = false;
            // 
            // tbxModeloProducto
            // 
            this.tbxModeloProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModeloProducto.Location = new System.Drawing.Point(109, 17);
            this.tbxModeloProducto.Name = "tbxModeloProducto";
            this.tbxModeloProducto.ReadOnly = true;
            this.tbxModeloProducto.Size = new System.Drawing.Size(230, 21);
            this.tbxModeloProducto.TabIndex = 0;
            this.tbxModeloProducto.TextChanged += new System.EventHandler(this.tbxModeloProducto_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Precio S/IGV:";
            // 
            // tbxPrecio1
            // 
            this.tbxPrecio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrecio1.Location = new System.Drawing.Point(110, 69);
            this.tbxPrecio1.Name = "tbxPrecio1";
            this.tbxPrecio1.ReadOnly = true;
            this.tbxPrecio1.Size = new System.Drawing.Size(96, 21);
            this.tbxPrecio1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(404, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "IGV:";
            // 
            // tbxIGV
            // 
            this.tbxIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIGV.Location = new System.Drawing.Point(448, 68);
            this.tbxIGV.Name = "tbxIGV";
            this.tbxIGV.ReadOnly = true;
            this.tbxIGV.Size = new System.Drawing.Size(85, 21);
            this.tbxIGV.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(370, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Dscto (%):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(396, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total:";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotal.Location = new System.Drawing.Point(448, 92);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(164, 21);
            this.tbxTotal.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Inicial:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Dscto::";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Igv:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(415, 486);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "Total venta:";
            // 
            // TBXtOTALvENTA
            // 
            this.TBXtOTALvENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXtOTALvENTA.Location = new System.Drawing.Point(489, 480);
            this.TBXtOTALvENTA.Name = "TBXtOTALvENTA";
            this.TBXtOTALvENTA.ReadOnly = true;
            this.TBXtOTALvENTA.Size = new System.Drawing.Size(160, 21);
            this.TBXtOTALvENTA.TabIndex = 3;
            // 
            // tbxTotalIGV
            // 
            this.tbxTotalIGV.Location = new System.Drawing.Point(58, 71);
            this.tbxTotalIGV.Name = "tbxTotalIGV";
            this.tbxTotalIGV.Size = new System.Drawing.Size(93, 20);
            this.tbxTotalIGV.TabIndex = 2;
            // 
            // tbxDescuentoTotall
            // 
            this.tbxDescuentoTotall.Location = new System.Drawing.Point(57, 44);
            this.tbxDescuentoTotall.Name = "tbxDescuentoTotall";
            this.tbxDescuentoTotall.Size = new System.Drawing.Size(93, 20);
            this.tbxDescuentoTotall.TabIndex = 1;
            // 
            // tbxInicial
            // 
            this.tbxInicial.Location = new System.Drawing.Point(58, 19);
            this.tbxInicial.Name = "tbxInicial";
            this.tbxInicial.Size = new System.Drawing.Size(93, 20);
            this.tbxInicial.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tbxDescuento);
            this.groupBox2.Controls.Add(this.tbxDescuento_porcentaje);
            this.groupBox2.Controls.Add(this.nudCantidad);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxModeloProducto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxPrecio1);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbxPrecio2);
            this.groupBox2.Controls.Add(this.tbxIGV);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbxTotal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 128);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Venta";
            // 
            // tbxDescuento
            // 
            this.tbxDescuento.Location = new System.Drawing.Point(552, 20);
            this.tbxDescuento.Name = "tbxDescuento";
            this.tbxDescuento.ReadOnly = true;
            this.tbxDescuento.Size = new System.Drawing.Size(60, 21);
            this.tbxDescuento.TabIndex = 16;
            // 
            // tbxDescuento_porcentaje
            // 
            this.tbxDescuento_porcentaje.Location = new System.Drawing.Point(448, 20);
            this.tbxDescuento_porcentaje.Name = "tbxDescuento_porcentaje";
            this.tbxDescuento_porcentaje.Size = new System.Drawing.Size(51, 21);
            this.tbxDescuento_porcentaje.TabIndex = 16;
            this.tbxDescuento_porcentaje.TextChanged += new System.EventHandler(this.tbxDescuento_TextChanged);
            this.tbxDescuento_porcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDescuento_porcentaje_KeyPress);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(110, 94);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(96, 21);
            this.nudCantidad.TabIndex = 13;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(109, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(230, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(388, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 15);
            this.label19.TabIndex = 11;
            this.label19.Text = "Precio:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(552, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 15);
            this.label22.TabIndex = 11;
            this.label22.Text = "18%";
            // 
            // tbxPrecio2
            // 
            this.tbxPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrecio2.Location = new System.Drawing.Point(448, 44);
            this.tbxPrecio2.Name = "tbxPrecio2";
            this.tbxPrecio2.ReadOnly = true;
            this.tbxPrecio2.Size = new System.Drawing.Size(164, 21);
            this.tbxPrecio2.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(34, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "Cantidad:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(505, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "Dscto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxInicial);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbxTotalIGV);
            this.groupBox3.Controls.Add(this.tbxDescuentoTotall);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(16, 646);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 98);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Credito";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Controls.Add(this.btnGuardar);
            this.groupBox4.Controls.Add(this.btnQuitar);
            this.groupBox4.Location = new System.Drawing.Point(512, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 154);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Presentacion.Imagenes.Buscar2_32;
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(8, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnBuscar.Size = new System.Drawing.Size(53, 60);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::Presentacion.Imagenes.Add_Files_To_Archive_32;
            this.btnAgregar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregar.Location = new System.Drawing.Point(73, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnAgregar.Size = new System.Drawing.Size(53, 60);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Presentacion.Imagenes.Gnome_save_Zip_32;
            this.btnGuardar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGuardar.Location = new System.Drawing.Point(73, 82);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnGuardar.Size = new System.Drawing.Size(53, 60);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Image = global::Presentacion.Imagenes.devolucion1_32;
            this.btnQuitar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQuitar.Location = new System.Drawing.Point(8, 82);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnQuitar.Size = new System.Drawing.Size(53, 60);
            this.btnQuitar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(415, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Inicial:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(489, 453);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(160, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(46, 480);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 25;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(661, 518);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TBXtOTALvENTA);
            this.Controls.Add(this.label16);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "***************Preventas***************";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmVentas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPreventa;
        private System.Windows.Forms.TextBox tbxCliente;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxModeloProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPrecio1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxIGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.ComboBox cbxTipoVenta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TBXtOTALvENTA;
        private System.Windows.Forms.TextBox tbxTotalIGV;
        private System.Windows.Forms.TextBox tbxDescuentoTotall;
        private System.Windows.Forms.TextBox tbxInicial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxCampaña;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxPrecio2;
        private System.Windows.Forms.Label label20;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.ButtonX btnQuitar;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ComboBox cbxVendedor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbxDescuento;
        private System.Windows.Forms.TextBox tbxDescuento_porcentaje;
    }
}