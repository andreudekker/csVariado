namespace Sistema_Farmaceutico
{
    partial class frm_Busqueda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFInicial = new System.Windows.Forms.DateTimePicker();
            this.cboBusquedaPor = new System.Windows.Forms.ComboBox();
            this.cboSelector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFFinal);
            this.groupBox1.Controls.Add(this.dtFInicial);
            this.groupBox1.Controls.Add(this.cboBusquedaPor);
            this.groupBox1.Controls.Add(this.cboSelector);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // dtFFinal
            // 
            this.dtFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFFinal.Location = new System.Drawing.Point(411, 32);
            this.dtFFinal.Name = "dtFFinal";
            this.dtFFinal.Size = new System.Drawing.Size(110, 20);
            this.dtFFinal.TabIndex = 5;
            // 
            // dtFInicial
            // 
            this.dtFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFInicial.Location = new System.Drawing.Point(290, 32);
            this.dtFInicial.Name = "dtFInicial";
            this.dtFInicial.Size = new System.Drawing.Size(110, 20);
            this.dtFInicial.TabIndex = 5;
            // 
            // cboBusquedaPor
            // 
            this.cboBusquedaPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaPor.FormattingEnabled = true;
            this.cboBusquedaPor.Items.AddRange(new object[] {
            "Busqueda por...",
            "Productos",
            "Usuarios",
            "Tienda",
            "Rango de Fechas"});
            this.cboBusquedaPor.Location = new System.Drawing.Point(159, 32);
            this.cboBusquedaPor.Name = "cboBusquedaPor";
            this.cboBusquedaPor.Size = new System.Drawing.Size(120, 21);
            this.cboBusquedaPor.TabIndex = 1;
            this.cboBusquedaPor.SelectedIndexChanged += new System.EventHandler(this.cboBusquedaPor_SelectedIndexChanged);
            // 
            // cboSelector
            // 
            this.cboSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelector.FormattingEnabled = true;
            this.cboSelector.Items.AddRange(new object[] {
            "Seleccione...",
            "Productos",
            "Ventas",
            "Usuarios"});
            this.cboSelector.Location = new System.Drawing.Point(28, 32);
            this.cboSelector.Name = "cboSelector";
            this.cboSelector.Size = new System.Drawing.Size(120, 21);
            this.cboSelector.TabIndex = 1;
            this.cboSelector.SelectedIndexChanged += new System.EventHandler(this.cboSelector_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selector";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.dgvResultado);
            this.groupBox2.Location = new System.Drawing.Point(15, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 278);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(407, 260);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total de Registros:";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(6, 13);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(534, 244);
            this.dgvResultado.TabIndex = 0;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Busqueda";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(73, 88);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(406, 20);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(485, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frm_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(589, 438);
            this.MinimumSize = new System.Drawing.Size(589, 438);
            this.Name = "frm_Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.frm_Busqueda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFFinal;
        private System.Windows.Forms.DateTimePicker dtFInicial;
        private System.Windows.Forms.ComboBox cboBusquedaPor;
        private System.Windows.Forms.ComboBox cboSelector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
    }
}