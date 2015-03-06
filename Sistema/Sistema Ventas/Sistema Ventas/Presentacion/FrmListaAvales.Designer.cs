namespace Presentacion
{
    partial class FrmListaAvales
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
            this.dgvListaAvales = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.navigationBar1 = new DevComponents.DotNetBar.NavigationBar();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnModificar = new DevComponents.DotNetBar.ButtonItem();
            this.btnDarBaja = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxApe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAvales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaAvales
            // 
            this.dgvListaAvales.AllowUserToAddRows = false;
            this.dgvListaAvales.AllowUserToDeleteRows = false;
            this.dgvListaAvales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaAvales.ColumnHeadersHeight = 26;
            this.dgvListaAvales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column19,
            this.Column20});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaAvales.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaAvales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(237)))));
            this.dgvListaAvales.Location = new System.Drawing.Point(6, 154);
            this.dgvListaAvales.Name = "dgvListaAvales";
            this.dgvListaAvales.ReadOnly = true;
            this.dgvListaAvales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaAvales.Size = new System.Drawing.Size(770, 241);
            this.dgvListaAvales.TabIndex = 22;
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
            this.Column12.HeaderText = "Nombres";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 120;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Apellidos";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 120;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "DNI";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 80;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Fec Nacimiento";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 120;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Estado Civil";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 90;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Direccion";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 160;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Distrito";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::Presentacion.Imagenes.Gnome_Applications_Utilities_64;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label11.Location = new System.Drawing.Point(252, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(538, 69);
            this.label11.TabIndex = 21;
            this.label11.Text = "        Operaciones sobre Avales";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // navigationBar1
            // 
            this.navigationBar1.AntiAlias = true;
            this.navigationBar1.AutoSizeButtonImage = false;
            this.navigationBar1.BackgroundStyle.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.navigationBar1.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationBar1.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationBar1.ItemPaddingBottom = 2;
            this.navigationBar1.ItemPaddingTop = 2;
            this.navigationBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnDarBaja,
            this.buttonItem9});
            this.navigationBar1.Location = new System.Drawing.Point(-1, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navigationBar1.Size = new System.Drawing.Size(252, 69);
            this.navigationBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationBar1.TabIndex = 20;
            this.navigationBar1.Text = "navigationBar1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Presentacion.Imagenes.lectores;
            this.btnNuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OptionGroup = "navBar";
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::Presentacion.Imagenes.Gnome_Edit_Redo_64__2_;
            this.btnModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OptionGroup = "navBar";
            this.btnModificar.Text = "Modificar";
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Checked = true;
            this.btnDarBaja.Enabled = false;
            this.btnDarBaja.Image = global::Presentacion.Imagenes.Gnome_Edit_Clear_64;
            this.btnDarBaja.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.OptionGroup = "navBar";
            this.btnDarBaja.Text = "Dar de baja";
            // 
            // buttonItem9
            // 
            this.buttonItem9.Image = global::Presentacion.Imagenes.Gnome_System_Log_Out_641;
            this.buttonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.OptionGroup = "navBar";
            this.buttonItem9.Text = "Salir";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxNom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxApe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxDNI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 61);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(75, 22);
            this.tbxNom.MaxLength = 8;
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(165, 20);
            this.tbxNom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres";
            // 
            // tbxApe
            // 
            this.tbxApe.Location = new System.Drawing.Point(317, 22);
            this.tbxApe.MaxLength = 8;
            this.tbxApe.Name = "tbxApe";
            this.tbxApe.Size = new System.Drawing.Size(190, 20);
            this.tbxApe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // tbxDNI
            // 
            this.tbxDNI.Location = new System.Drawing.Point(581, 22);
            this.tbxDNI.MaxLength = 8;
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(95, 20);
            this.tbxDNI.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // FrmListaAvales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 407);
            this.Controls.Add(this.dgvListaAvales);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "FrmListaAvales";
            this.Text = "Lista Avales";
            this.Load += new System.EventHandler(this.FrmListaAvales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAvales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvListaAvales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.Label label11;
        private DevComponents.DotNetBar.NavigationBar navigationBar1;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnModificar;
        private DevComponents.DotNetBar.ButtonItem btnDarBaja;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxApe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDNI;
        private System.Windows.Forms.Label label1;
    }
}