namespace Presentacion
{
    partial class FrmSimuladorComisiones
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
            this.tbxVendedor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxComision = new System.Windows.Forms.TextBox();
            this.tbxUltimaVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.tbxtipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxProyeccion = new System.Windows.Forms.TextBox();
            this.btnQuitar = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vendedor:";
            // 
            // tbxVendedor
            // 
            this.tbxVendedor.Location = new System.Drawing.Point(146, 33);
            this.tbxVendedor.Name = "tbxVendedor";
            this.tbxVendedor.ReadOnly = true;
            this.tbxVendedor.Size = new System.Drawing.Size(346, 20);
            this.tbxVendedor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxDNI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // tbxDNI
            // 
            this.tbxDNI.Location = new System.Drawing.Point(57, 19);
            this.tbxDNI.MaxLength = 8;
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(122, 20);
            this.tbxDNI.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comision:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ultima venta:";
            // 
            // tbxComision
            // 
            this.tbxComision.Location = new System.Drawing.Point(377, 79);
            this.tbxComision.Name = "tbxComision";
            this.tbxComision.ReadOnly = true;
            this.tbxComision.Size = new System.Drawing.Size(115, 20);
            this.tbxComision.TabIndex = 1;
            // 
            // tbxUltimaVenta
            // 
            this.tbxUltimaVenta.Location = new System.Drawing.Point(146, 63);
            this.tbxUltimaVenta.Name = "tbxUltimaVenta";
            this.tbxUltimaVenta.ReadOnly = true;
            this.tbxUltimaVenta.Size = new System.Drawing.Size(131, 20);
            this.tbxUltimaVenta.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descuento acumulado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo de venta:";
            // 
            // tbxDesc
            // 
            this.tbxDesc.Location = new System.Drawing.Point(146, 124);
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.ReadOnly = true;
            this.tbxDesc.Size = new System.Drawing.Size(131, 20);
            this.tbxDesc.TabIndex = 1;
            // 
            // tbxtipo
            // 
            this.tbxtipo.Location = new System.Drawing.Point(146, 94);
            this.tbxtipo.Name = "tbxtipo";
            this.tbxtipo.ReadOnly = true;
            this.tbxtipo.Size = new System.Drawing.Size(131, 20);
            this.tbxtipo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Proyeccion:";
            // 
            // tbxProyeccion
            // 
            this.tbxProyeccion.Location = new System.Drawing.Point(377, 120);
            this.tbxProyeccion.Name = "tbxProyeccion";
            this.tbxProyeccion.ReadOnly = true;
            this.tbxProyeccion.Size = new System.Drawing.Size(115, 20);
            this.tbxProyeccion.TabIndex = 1;
            // 
            // btnQuitar
            // 
            this.btnQuitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(161, 19);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnQuitar.Size = new System.Drawing.Size(120, 29);
            this.btnQuitar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "Salir";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxVendedor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxtipo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxUltimaVenta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxDesc);
            this.groupBox2.Controls.Add(this.tbxComision);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxProyeccion);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 163);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(23, 19);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.buttonX1.Size = new System.Drawing.Size(120, 29);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 10;
            this.buttonX1.Text = "Buscar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonX1);
            this.groupBox3.Controls.Add(this.btnQuitar);
            this.groupBox3.Location = new System.Drawing.Point(229, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro";
            // 
            // FrmSimuladorComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(541, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "FrmSimuladorComisiones";
            this.Text = "Simulador Comisiones";
            this.Load += new System.EventHandler(this.FrmSimuladorComisiones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxVendedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxComision;
        private System.Windows.Forms.TextBox tbxUltimaVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.TextBox tbxtipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxProyeccion;
        private DevComponents.DotNetBar.ButtonX btnQuitar;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxDNI;
    }
}