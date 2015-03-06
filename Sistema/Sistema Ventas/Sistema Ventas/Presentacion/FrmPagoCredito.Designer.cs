namespace Presentacion
{
    partial class FrmPagoCredito
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
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNro_prestamo = new System.Windows.Forms.TextBox();
            this.tbxCliente = new System.Windows.Forms.TextBox();
            this.tbxCapital = new System.Windows.Forms.TextBox();
            this.tbxFecDesembolso = new System.Windows.Forms.TextBox();
            this.tbxPlazo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.btnQuitar = new DevComponents.DotNetBar.ButtonX();
            this.tbxcapitaltotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxinterestotal = new System.Windows.Forms.TextBox();
            this.tbxtotalcuota = new System.Windows.Forms.TextBox();
            this.tbxtotaldesgr = new System.Windows.Forms.TextBox();
            this.tbxtotaltotal = new System.Windows.Forms.TextBox();
            this.tbxtotalitf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(12, 168);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.Size = new System.Drawing.Size(620, 297);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nro";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha de Vencimiento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Capital";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Interes";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cuota";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Desgr.";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ITF";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Debe";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Fecha de pago";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro_Prestamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Capital";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha desembolso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Plazo";
            // 
            // tbxNro_prestamo
            // 
            this.tbxNro_prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNro_prestamo.Location = new System.Drawing.Point(158, 17);
            this.tbxNro_prestamo.Name = "tbxNro_prestamo";
            this.tbxNro_prestamo.ReadOnly = true;
            this.tbxNro_prestamo.Size = new System.Drawing.Size(167, 21);
            this.tbxNro_prestamo.TabIndex = 2;
            // 
            // tbxCliente
            // 
            this.tbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCliente.Location = new System.Drawing.Point(158, 41);
            this.tbxCliente.Name = "tbxCliente";
            this.tbxCliente.ReadOnly = true;
            this.tbxCliente.Size = new System.Drawing.Size(167, 21);
            this.tbxCliente.TabIndex = 2;
            // 
            // tbxCapital
            // 
            this.tbxCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCapital.Location = new System.Drawing.Point(158, 66);
            this.tbxCapital.Name = "tbxCapital";
            this.tbxCapital.ReadOnly = true;
            this.tbxCapital.Size = new System.Drawing.Size(167, 21);
            this.tbxCapital.TabIndex = 2;
            // 
            // tbxFecDesembolso
            // 
            this.tbxFecDesembolso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFecDesembolso.Location = new System.Drawing.Point(158, 90);
            this.tbxFecDesembolso.Name = "tbxFecDesembolso";
            this.tbxFecDesembolso.ReadOnly = true;
            this.tbxFecDesembolso.Size = new System.Drawing.Size(167, 21);
            this.tbxFecDesembolso.TabIndex = 2;
            // 
            // tbxPlazo
            // 
            this.tbxPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlazo.Location = new System.Drawing.Point(158, 114);
            this.tbxPlazo.Name = "tbxPlazo";
            this.tbxPlazo.ReadOnly = true;
            this.tbxPlazo.Size = new System.Drawing.Size(167, 21);
            this.tbxPlazo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxPlazo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxFecDesembolso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxCapital);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxNro_prestamo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del credito";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.buttonX4);
            this.groupBox4.Controls.Add(this.btnQuitar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(389, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 148);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(27, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnBuscar.Size = new System.Drawing.Size(190, 50);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Imprimir";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX4.Enabled = false;
            this.buttonX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX4.Location = new System.Drawing.Point(27, 84);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.buttonX4.Size = new System.Drawing.Size(78, 50);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 9;
            this.buttonX4.Text = "Guardar";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(139, 84);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnQuitar.Size = new System.Drawing.Size(78, 50);
            this.btnQuitar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "Salir";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // tbxcapitaltotal
            // 
            this.tbxcapitaltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxcapitaltotal.Location = new System.Drawing.Point(214, 480);
            this.tbxcapitaltotal.Name = "tbxcapitaltotal";
            this.tbxcapitaltotal.ReadOnly = true;
            this.tbxcapitaltotal.Size = new System.Drawing.Size(63, 21);
            this.tbxcapitaltotal.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Totales:";
            // 
            // tbxinterestotal
            // 
            this.tbxinterestotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxinterestotal.Location = new System.Drawing.Point(283, 480);
            this.tbxinterestotal.Name = "tbxinterestotal";
            this.tbxinterestotal.ReadOnly = true;
            this.tbxinterestotal.Size = new System.Drawing.Size(54, 21);
            this.tbxinterestotal.TabIndex = 2;
            // 
            // tbxtotalcuota
            // 
            this.tbxtotalcuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtotalcuota.Location = new System.Drawing.Point(343, 480);
            this.tbxtotalcuota.Name = "tbxtotalcuota";
            this.tbxtotalcuota.ReadOnly = true;
            this.tbxtotalcuota.Size = new System.Drawing.Size(76, 21);
            this.tbxtotalcuota.TabIndex = 2;
            // 
            // tbxtotaldesgr
            // 
            this.tbxtotaldesgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtotaldesgr.Location = new System.Drawing.Point(425, 480);
            this.tbxtotaldesgr.Name = "tbxtotaldesgr";
            this.tbxtotaldesgr.ReadOnly = true;
            this.tbxtotaldesgr.Size = new System.Drawing.Size(55, 21);
            this.tbxtotaldesgr.TabIndex = 2;
            // 
            // tbxtotaltotal
            // 
            this.tbxtotaltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtotaltotal.Location = new System.Drawing.Point(552, 480);
            this.tbxtotaltotal.Name = "tbxtotaltotal";
            this.tbxtotaltotal.ReadOnly = true;
            this.tbxtotaltotal.Size = new System.Drawing.Size(70, 21);
            this.tbxtotaltotal.TabIndex = 2;
            // 
            // tbxtotalitf
            // 
            this.tbxtotalitf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtotalitf.Location = new System.Drawing.Point(486, 480);
            this.tbxtotalitf.Name = "tbxtotalitf";
            this.tbxtotalitf.ReadOnly = true;
            this.tbxtotalitf.Size = new System.Drawing.Size(60, 21);
            this.tbxtotalitf.TabIndex = 2;
            // 
            // FrmPagoCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(645, 514);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.tbxtotaltotal);
            this.Controls.Add(this.tbxtotalitf);
            this.Controls.Add(this.tbxtotaldesgr);
            this.Controls.Add(this.tbxtotalcuota);
            this.Controls.Add(this.tbxinterestotal);
            this.Controls.Add(this.tbxcapitaltotal);
            this.DoubleBuffered = true;
            this.Name = "FrmPagoCredito";
            this.Text = "Nuevo credito";
            this.Load += new System.EventHandler(this.FrmPagoCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNro_prestamo;
        private System.Windows.Forms.TextBox tbxCliente;
        private System.Windows.Forms.TextBox tbxCapital;
        private System.Windows.Forms.TextBox tbxFecDesembolso;
        private System.Windows.Forms.TextBox tbxPlazo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX btnQuitar;
        private System.Windows.Forms.TextBox tbxcapitaltotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxinterestotal;
        private System.Windows.Forms.TextBox tbxtotalcuota;
        private System.Windows.Forms.TextBox tbxtotaldesgr;
        private System.Windows.Forms.TextBox tbxtotaltotal;
        private System.Windows.Forms.TextBox tbxtotalitf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}