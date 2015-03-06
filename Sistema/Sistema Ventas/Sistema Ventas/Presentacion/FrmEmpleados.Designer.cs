namespace Presentacion
{
    partial class FrmEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDNI = new System.Windows.Forms.TextBox();
            this.tbxNombres = new System.Windows.Forms.TextBox();
            this.tbxApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.dtpFecNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDivorciado = new System.Windows.Forms.RadioButton();
            this.cbxViudo = new System.Windows.Forms.RadioButton();
            this.cbxCasado = new System.Windows.Forms.RadioButton();
            this.cbxSoltero = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDistrito = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.navigationBar1 = new DevComponents.DotNetBar.NavigationBar();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombres: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellidos: ";
            // 
            // tbxDNI
            // 
            this.tbxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDNI.Location = new System.Drawing.Point(138, 19);
            this.tbxDNI.MaxLength = 8;
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(232, 21);
            this.tbxDNI.TabIndex = 0;
            // 
            // tbxNombres
            // 
            this.tbxNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombres.Location = new System.Drawing.Point(138, 48);
            this.tbxNombres.Name = "tbxNombres";
            this.tbxNombres.Size = new System.Drawing.Size(232, 21);
            this.tbxNombres.TabIndex = 1;
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxApellidos.Location = new System.Drawing.Point(138, 77);
            this.tbxApellidos.Name = "tbxApellidos";
            this.tbxApellidos.Size = new System.Drawing.Size(232, 21);
            this.tbxApellidos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha de nacimiento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Celular: ";
            // 
            // tbxCelular
            // 
            this.tbxCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCelular.Location = new System.Drawing.Point(138, 129);
            this.tbxCelular.Name = "tbxCelular";
            this.tbxCelular.Size = new System.Drawing.Size(233, 21);
            this.tbxCelular.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Correo electronico: ";
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCorreo.Location = new System.Drawing.Point(138, 155);
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(334, 21);
            this.tbxCorreo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dirección: ";
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDireccion.Location = new System.Drawing.Point(138, 181);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(334, 21);
            this.tbxDireccion.TabIndex = 6;
            // 
            // dtpFecNacimiento
            // 
            this.dtpFecNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNacimiento.Location = new System.Drawing.Point(138, 103);
            this.dtpFecNacimiento.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFecNacimiento.MinDate = new System.DateTime(1899, 2, 22, 0, 0, 0, 0);
            this.dtpFecNacimiento.Name = "dtpFecNacimiento";
            this.dtpFecNacimiento.Size = new System.Drawing.Size(123, 21);
            this.dtpFecNacimiento.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDivorciado);
            this.groupBox1.Controls.Add(this.cbxViudo);
            this.groupBox1.Controls.Add(this.cbxCasado);
            this.groupBox1.Controls.Add(this.cbxSoltero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(376, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado civil";
            // 
            // cbxDivorciado
            // 
            this.cbxDivorciado.AutoSize = true;
            this.cbxDivorciado.Location = new System.Drawing.Point(13, 96);
            this.cbxDivorciado.Name = "cbxDivorciado";
            this.cbxDivorciado.Size = new System.Drawing.Size(83, 19);
            this.cbxDivorciado.TabIndex = 3;
            this.cbxDivorciado.TabStop = true;
            this.cbxDivorciado.Text = "Divorciado";
            this.cbxDivorciado.UseVisualStyleBackColor = true;
            // 
            // cbxViudo
            // 
            this.cbxViudo.AutoSize = true;
            this.cbxViudo.Location = new System.Drawing.Point(13, 73);
            this.cbxViudo.Name = "cbxViudo";
            this.cbxViudo.Size = new System.Drawing.Size(56, 19);
            this.cbxViudo.TabIndex = 2;
            this.cbxViudo.TabStop = true;
            this.cbxViudo.Text = "Viudo";
            this.cbxViudo.UseVisualStyleBackColor = true;
            // 
            // cbxCasado
            // 
            this.cbxCasado.AutoSize = true;
            this.cbxCasado.Location = new System.Drawing.Point(13, 50);
            this.cbxCasado.Name = "cbxCasado";
            this.cbxCasado.Size = new System.Drawing.Size(67, 19);
            this.cbxCasado.TabIndex = 1;
            this.cbxCasado.TabStop = true;
            this.cbxCasado.Text = "Casado";
            this.cbxCasado.UseVisualStyleBackColor = true;
            // 
            // cbxSoltero
            // 
            this.cbxSoltero.AutoSize = true;
            this.cbxSoltero.Location = new System.Drawing.Point(13, 27);
            this.cbxSoltero.Name = "cbxSoltero";
            this.cbxSoltero.Size = new System.Drawing.Size(64, 19);
            this.cbxSoltero.TabIndex = 0;
            this.cbxSoltero.TabStop = true;
            this.cbxSoltero.Text = "Soltero";
            this.cbxSoltero.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Distrito: ";
            // 
            // cbxDistrito
            // 
            this.cbxDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistrito.Enabled = false;
            this.cbxDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDistrito.FormattingEnabled = true;
            this.cbxDistrito.Location = new System.Drawing.Point(138, 263);
            this.cbxDistrito.Name = "cbxDistrito";
            this.cbxDistrito.Size = new System.Drawing.Size(334, 23);
            this.cbxDistrito.TabIndex = 7;
            this.cbxDistrito.SelectionChangeCommitted += new System.EventHandler(this.cbxDistrito_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Provincia: ";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvincia.Enabled = false;
            this.cbxProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Location = new System.Drawing.Point(138, 234);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(334, 23);
            this.cbxProvincia.TabIndex = 8;
            this.cbxProvincia.SelectionChangeCommitted += new System.EventHandler(this.cbxProvincia_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Departamento: ";
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(138, 208);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(334, 23);
            this.cbxDepartamento.TabIndex = 9;
            this.cbxDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cbxDepartamento_SelectionChangeCommitted);
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
            this.btnGuardar,
            this.btnSalir});
            this.navigationBar1.Location = new System.Drawing.Point(-1, -2);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navigationBar1.Size = new System.Drawing.Size(160, 69);
            this.navigationBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationBar1.TabIndex = 12;
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
            // btnGuardar
            // 
            this.btnGuardar.Checked = true;
            this.btnGuardar.Image = global::Presentacion.Imagenes.Gnome_Media_Zip_64;
            this.btnGuardar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OptionGroup = "navBar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxDNI);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxDepartamento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxProvincia);
            this.groupBox2.Controls.Add(this.tbxNombres);
            this.groupBox2.Controls.Add(this.cbxDistrito);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.tbxApellidos);
            this.groupBox2.Controls.Add(this.dtpFecNacimiento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxDireccion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxCorreo);
            this.groupBox2.Controls.Add(this.tbxCelular);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(5, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 292);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del empleado";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::Presentacion.Imagenes.Gnome_Applications_Utilities_64;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label11.Location = new System.Drawing.Point(159, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(346, 69);
            this.label11.TabIndex = 16;
            this.label11.Text = "          Operaciones sobre                        Empleados";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(499, 372);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.navigationBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmEmpleados";
            this.Text = "Empleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEmpleados_FormClosed);
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDNI;
        private System.Windows.Forms.TextBox tbxNombres;
        private System.Windows.Forms.TextBox tbxApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.DateTimePicker dtpFecNacimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cbxDivorciado;
        private System.Windows.Forms.RadioButton cbxViudo;
        private System.Windows.Forms.RadioButton cbxCasado;
        private System.Windows.Forms.RadioButton cbxSoltero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxDistrito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxProvincia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private DevComponents.DotNetBar.NavigationBar navigationBar1;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonItem btnSalir;
        private System.Windows.Forms.Label label11;
    }
}