namespace Presentacion
{
    partial class FrmPagoInicial
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
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxVuelto = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.tbxBillete = new System.Windows.Forms.TextBox();
            this.btnCobrar = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(140, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxVuelto);
            this.groupBox1.Controls.Add(this.tbxTotal);
            this.groupBox1.Controls.Add(this.tbxBillete);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 106);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cobrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Paga con:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vuelto";
            // 
            // tbxVuelto
            // 
            this.tbxVuelto.Location = new System.Drawing.Point(82, 73);
            this.tbxVuelto.Name = "tbxVuelto";
            this.tbxVuelto.ReadOnly = true;
            this.tbxVuelto.Size = new System.Drawing.Size(136, 20);
            this.tbxVuelto.TabIndex = 9;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(82, 19);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(136, 20);
            this.tbxTotal.TabIndex = 8;
            // 
            // tbxBillete
            // 
            this.tbxBillete.Location = new System.Drawing.Point(82, 46);
            this.tbxBillete.Name = "tbxBillete";
            this.tbxBillete.Size = new System.Drawing.Size(136, 20);
            this.tbxBillete.TabIndex = 10;
            this.tbxBillete.TextChanged += new System.EventHandler(this.tbxBillete_TextChanged);
            // 
            // btnCobrar
            // 
            this.btnCobrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCobrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(34, 131);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnCobrar.Size = new System.Drawing.Size(80, 28);
            this.btnCobrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCobrar.TabIndex = 14;
            this.btnCobrar.Text = "Aceptar";
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // FrmPagoInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(263, 171);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCobrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmPagoInicial";
            this.Text = "Pago Inicial";
            this.Load += new System.EventHandler(this.FrmPagoInicial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxVuelto;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.TextBox tbxBillete;
        private DevComponents.DotNetBar.ButtonX btnCobrar;
    }
}