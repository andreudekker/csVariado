namespace Presentacion
{
    partial class FrmContrato
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
            this.navigationBar1 = new DevComponents.DotNetBar.NavigationBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmpleado = new System.Windows.Forms.TextBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNick = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxClave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxClave2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.btnBuscarEmpleado = new DevComponents.DotNetBar.ButtonX();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).BeginInit();
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
            this.buttonItem1,
            this.buttonItem2,
            this.buttonItem7});
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navigationBar1.Size = new System.Drawing.Size(161, 69);
            this.navigationBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationBar1.TabIndex = 40;
            this.navigationBar1.Text = "navigationBar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = global::Presentacion.Imagenes.lectores;
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.OptionGroup = "navBar";
            this.buttonItem1.Text = "Nuevo";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Checked = true;
            this.buttonItem2.Image = global::Presentacion.Imagenes.Gnome_Media_Zip_64;
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.OptionGroup = "navBar";
            this.buttonItem2.Text = "Guardar";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // buttonItem7
            // 
            this.buttonItem7.Image = global::Presentacion.Imagenes.Gnome_System_Log_Out_641;
            this.buttonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.OptionGroup = "navBar";
            this.buttonItem7.Text = "Salir";
            this.buttonItem7.Click += new System.EventHandler(this.buttonItem7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Empleado:";
            // 
            // tbxEmpleado
            // 
            this.tbxEmpleado.Location = new System.Drawing.Point(142, 79);
            this.tbxEmpleado.Name = "tbxEmpleado";
            this.tbxEmpleado.ReadOnly = true;
            this.tbxEmpleado.Size = new System.Drawing.Size(176, 20);
            this.tbxEmpleado.TabIndex = 0;
            // 
            // cbxCargo
            // 
            this.cbxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxCargo.Items.AddRange(new object[] {
            "",
            "Vendedor",
            "Supervisor",
            "Gerente",
            "Almacen",
            "Cajero",
            "Agente crediticio"});
            this.cbxCargo.Location = new System.Drawing.Point(142, 242);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(234, 21);
            this.cbxCargo.TabIndex = 6;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(142, 108);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(234, 20);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Fecha inicio periodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha fin periodo:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(142, 134);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(234, 20);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "NIck: ";
            // 
            // tbxNick
            // 
            this.tbxNick.Location = new System.Drawing.Point(142, 160);
            this.tbxNick.Name = "tbxNick";
            this.tbxNick.Size = new System.Drawing.Size(127, 20);
            this.tbxNick.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Clave:";
            // 
            // tbxClave
            // 
            this.tbxClave.Location = new System.Drawing.Point(142, 186);
            this.tbxClave.Name = "tbxClave";
            this.tbxClave.Size = new System.Drawing.Size(127, 20);
            this.tbxClave.TabIndex = 4;
            this.tbxClave.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Repita su clave:";
            // 
            // tbxClave2
            // 
            this.tbxClave2.Location = new System.Drawing.Point(142, 216);
            this.tbxClave2.Name = "tbxClave2";
            this.tbxClave2.Size = new System.Drawing.Size(127, 20);
            this.tbxClave2.TabIndex = 5;
            this.tbxClave2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Cargo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Turno:";
            // 
            // cbxTurno
            // 
            this.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxTurno.Items.AddRange(new object[] {
            "",
            "Todo el día",
            "Mañana",
            "Tarde"});
            this.cbxTurno.Location = new System.Drawing.Point(142, 269);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(234, 21);
            this.cbxTurno.TabIndex = 7;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarEmpleado.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(331, 77);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(16, 8, 6, 18);
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(45, 25);
            this.btnBuscarEmpleado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarEmpleado.TabIndex = 46;
            this.btnBuscarEmpleado.Text = "...";
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::Presentacion.Imagenes.Gnome_Applications_Utilities_64;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label13.Location = new System.Drawing.Point(161, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(239, 68);
            this.label13.TabIndex = 41;
            this.label13.Text = "          Contrato de          Empleados";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FrmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(393, 301);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbxTurno);
            this.Controls.Add(this.cbxCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxClave2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxClave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxNick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.navigationBar1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrmContrato";
            this.Text = "Contratos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmContrato_FormClosed);
            this.Load += new System.EventHandler(this.FrmContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private DevComponents.DotNetBar.NavigationBar navigationBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmpleado;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxClave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxClave2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxTurno;
        private DevComponents.DotNetBar.ButtonX btnBuscarEmpleado;
    }
}