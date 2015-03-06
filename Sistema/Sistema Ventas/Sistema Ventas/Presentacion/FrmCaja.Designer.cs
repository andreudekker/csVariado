namespace Presentacion
{
    partial class FrmCaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonX();
            this.btnCobrar = new DevComponents.DotNetBar.ButtonX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPreventa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxInicial = new System.Windows.Forms.TextBox();
            this.tbxTipoVenta = new System.Windows.Forms.TextBox();
            this.tbxEmpleado = new System.Windows.Forms.TextBox();
            this.tbxCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCarrito = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBXtOTALvENTA = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNuevo);
            this.groupBox4.Controls.Add(this.btnCobrar);
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Location = new System.Drawing.Point(512, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 139);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::Presentacion.Imagenes.Gnome_Document_New_48;
            this.btnNuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNuevo.Location = new System.Drawing.Point(11, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnNuevo.Size = new System.Drawing.Size(53, 90);
            this.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCobrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnCobrar.Enabled = false;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Image = global::Presentacion.Imagenes.Gold_Theme_Money_Dollars_clip_art_hight;
            this.btnCobrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCobrar.Location = new System.Drawing.Point(73, 31);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnCobrar.Size = new System.Drawing.Size(53, 90);
            this.btnCobrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCobrar.TabIndex = 9;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Presentacion.Imagenes.Gnome_System_Log_Out_641;
            this.btnSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSalir.Location = new System.Drawing.Point(135, 31);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnSalir.Size = new System.Drawing.Size(53, 90);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxPreventa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxInicial);
            this.groupBox1.Controls.Add(this.tbxTipoVenta);
            this.groupBox1.Controls.Add(this.tbxEmpleado);
            this.groupBox1.Controls.Add(this.tbxCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 139);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Escriba la preventa y presine ***ENTER***";
            // 
            // tbxPreventa
            // 
            this.tbxPreventa.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPreventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPreventa.Location = new System.Drawing.Point(108, 16);
            this.tbxPreventa.MaxLength = 8;
            this.tbxPreventa.Name = "tbxPreventa";
            this.tbxPreventa.Size = new System.Drawing.Size(100, 21);
            this.tbxPreventa.TabIndex = 0;
            this.tbxPreventa.TextChanged += new System.EventHandler(this.tbxPreventa_TextChanged);
            this.tbxPreventa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPreventa_KeyDown);
            this.tbxPreventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPreventa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Preventa:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(269, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "Inicial:";
            this.label17.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vendedor:";
            // 
            // tbxInicial
            // 
            this.tbxInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInicial.Location = new System.Drawing.Point(327, 44);
            this.tbxInicial.Name = "tbxInicial";
            this.tbxInicial.ReadOnly = true;
            this.tbxInicial.Size = new System.Drawing.Size(155, 21);
            this.tbxInicial.TabIndex = 6;
            this.tbxInicial.Visible = false;
            // 
            // tbxTipoVenta
            // 
            this.tbxTipoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTipoVenta.Location = new System.Drawing.Point(108, 44);
            this.tbxTipoVenta.Name = "tbxTipoVenta";
            this.tbxTipoVenta.ReadOnly = true;
            this.tbxTipoVenta.Size = new System.Drawing.Size(143, 21);
            this.tbxTipoVenta.TabIndex = 6;
            // 
            // tbxEmpleado
            // 
            this.tbxEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpleado.Location = new System.Drawing.Point(108, 74);
            this.tbxEmpleado.Name = "tbxEmpleado";
            this.tbxEmpleado.ReadOnly = true;
            this.tbxEmpleado.Size = new System.Drawing.Size(374, 21);
            this.tbxEmpleado.TabIndex = 6;
            // 
            // tbxCliente
            // 
            this.tbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCliente.Location = new System.Drawing.Point(108, 104);
            this.tbxCliente.Name = "tbxCliente";
            this.tbxCliente.ReadOnly = true;
            this.tbxCliente.Size = new System.Drawing.Size(374, 21);
            this.tbxCliente.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo de venta:";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column8,
            this.Column7,
            this.Column10});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCarrito.Location = new System.Drawing.Point(12, 157);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.Size = new System.Drawing.Size(698, 256);
            this.dgvCarrito.TabIndex = 26;
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
            // Column10
            // 
            this.Column10.HeaderText = "stock";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // TBXtOTALvENTA
            // 
            this.TBXtOTALvENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXtOTALvENTA.Location = new System.Drawing.Point(547, 429);
            this.TBXtOTALvENTA.Name = "TBXtOTALvENTA";
            this.TBXtOTALvENTA.Size = new System.Drawing.Size(160, 21);
            this.TBXtOTALvENTA.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(462, 435);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "Total venta:";
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(719, 457);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.TBXtOTALvENTA);
            this.Controls.Add(this.label16);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmCaja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.ButtonX btnNuevo;
        private DevComponents.DotNetBar.ButtonX btnCobrar;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxPreventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCarrito;
        private System.Windows.Forms.TextBox TBXtOTALvENTA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox tbxTipoVenta;
        private System.Windows.Forms.TextBox tbxEmpleado;
        private System.Windows.Forms.TextBox tbxInicial;
        private System.Windows.Forms.Label label2;
    }
}