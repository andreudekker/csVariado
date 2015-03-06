namespace Presentacion
{
    partial class FrmListaContratos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationBar1 = new DevComponents.DotNetBar.NavigationBar();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnModificar = new DevComponents.DotNetBar.ButtonItem();
            this.btnDarBaja = new DevComponents.DotNetBar.ButtonItem();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaEmpleados = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationBar1
            // 
            this.navigationBar1.AntiAlias = true;
            this.navigationBar1.AutoSizeButtonImage = false;
            this.navigationBar1.BackgroundStyle.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.navigationBar1.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationBar1.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationBar1.ConfigureItemVisible = false;
            this.navigationBar1.ItemPaddingBottom = 2;
            this.navigationBar1.ItemPaddingTop = 2;
            this.navigationBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnDarBaja,
            this.btnSalir});
            this.navigationBar1.Location = new System.Drawing.Point(-1, -1);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navigationBar1.Size = new System.Drawing.Size(228, 69);
            this.navigationBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationBar1.TabIndex = 44;
            this.navigationBar1.Text = "navigationBar1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Presentacion.Imagenes.lectores;
            this.btnNuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OptionGroup = "navBar";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Checked = true;
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::Presentacion.Imagenes.Gnome_Edit_Redo_64__2_;
            this.btnModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OptionGroup = "navBar";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Enabled = false;
            this.btnDarBaja.Image = global::Presentacion.Imagenes.Gnome_Edit_Clear_64;
            this.btnDarBaja.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.OptionGroup = "navBar";
            this.btnDarBaja.Text = "Dar de baja";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Presentacion.Imagenes.Gnome_System_Log_Out_641;
            this.btnSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OptionGroup = "navBar";
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxCargo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxDNI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 51);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar empleados";
            // 
            // tbxCargo
            // 
            this.tbxCargo.Location = new System.Drawing.Point(338, 19);
            this.tbxCargo.MaxLength = 8;
            this.tbxCargo.Name = "tbxCargo";
            this.tbxCargo.Size = new System.Drawing.Size(165, 20);
            this.tbxCargo.TabIndex = 4;
            this.tbxCargo.TextChanged += new System.EventHandler(this.tbxDNI_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cargo";
            // 
            // tbxDNI
            // 
            this.tbxDNI.Location = new System.Drawing.Point(67, 21);
            this.tbxDNI.MaxLength = 8;
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(197, 20);
            this.tbxDNI.TabIndex = 2;
            this.tbxDNI.TextChanged += new System.EventHandler(this.tbxDNI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.AllowUserToAddRows = false;
            this.dgvListaEmpleados.AllowUserToDeleteRows = false;
            this.dgvListaEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaEmpleados.ColumnHeadersHeight = 26;
            this.dgvListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column11,
            this.Column12,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(237)))));
            this.dgvListaEmpleados.Location = new System.Drawing.Point(12, 141);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.ReadOnly = true;
            this.dgvListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEmpleados.Size = new System.Drawing.Size(518, 178);
            this.dgvListaEmpleados.TabIndex = 47;
            this.dgvListaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmpleados_CellClick);
            this.dgvListaEmpleados.Click += new System.EventHandler(this.dgvListaEmpleados_Click);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "IdContrato";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "IdEmpleado";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Empleado";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 120;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "DNI";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Fec inicial";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 120;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Fec_final";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 90;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "NIck";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 80;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Clave";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 130;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Cargo";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 160;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Turno";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estado";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::Presentacion.Imagenes.Gnome_Applications_Utilities_64;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label11.Location = new System.Drawing.Point(227, -2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(317, 69);
            this.label11.TabIndex = 45;
            this.label11.Text = "        Contratos";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FrmListaContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(542, 331);
            this.Controls.Add(this.dgvListaEmpleados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.navigationBar1);
            this.DoubleBuffered = true;
            this.Name = "FrmListaContratos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contratos";
            this.Load += new System.EventHandler(this.FrmListaContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationBar navigationBar1;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnModificar;
        private DevComponents.DotNetBar.ButtonItem btnDarBaja;
        private DevComponents.DotNetBar.ButtonItem btnSalir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxDNI;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvListaEmpleados;
        private System.Windows.Forms.TextBox tbxCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}