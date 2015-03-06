namespace SistemaWinFormBDFacturacion
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tstMenu = new System.Windows.Forms.ToolStrip();
            this.tstPrimerRegistro = new System.Windows.Forms.ToolStripButton();
            this.tstAnterior = new System.Windows.Forms.ToolStripButton();
            this.tstSiguiente = new System.Windows.Forms.ToolStripButton();
            this.tstUltimo = new System.Windows.Forms.ToolStripButton();
            this.tstNuevo = new System.Windows.Forms.ToolStripButton();
            this.tstGuardar = new System.Windows.Forms.ToolStripButton();
            this.tstBorrar = new System.Windows.Forms.ToolStripButton();
            this.tstLimpiar = new System.Windows.Forms.ToolStripButton();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboIva = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notas";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(67, 64);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(113, 20);
            this.txtIdProducto.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(284, 64);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(172, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(63, 93);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(116, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(284, 94);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(172, 20);
            this.txtStock.TabIndex = 8;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(45, 122);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotas.Size = new System.Drawing.Size(411, 50);
            this.txtNotas.TabIndex = 10;
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(7, 189);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(783, 223);
            this.dgvProductos.TabIndex = 11;
            // 
            // tstMenu
            // 
            this.tstMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstPrimerRegistro,
            this.tstAnterior,
            this.tstSiguiente,
            this.tstUltimo,
            this.tstNuevo,
            this.tstGuardar,
            this.tstBorrar,
            this.tstLimpiar});
            this.tstMenu.Location = new System.Drawing.Point(0, 0);
            this.tstMenu.Name = "tstMenu";
            this.tstMenu.Size = new System.Drawing.Size(802, 25);
            this.tstMenu.TabIndex = 0;
            this.tstMenu.Text = "toolStrip1";
            // 
            // tstPrimerRegistro
            // 
            this.tstPrimerRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstPrimerRegistro.Image = ((System.Drawing.Image)(resources.GetObject("tstPrimerRegistro.Image")));
            this.tstPrimerRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstPrimerRegistro.Name = "tstPrimerRegistro";
            this.tstPrimerRegistro.Size = new System.Drawing.Size(23, 22);
            this.tstPrimerRegistro.Text = "toolStripButton1";
            this.tstPrimerRegistro.ToolTipText = "Va al primer registro";
            this.tstPrimerRegistro.Click += new System.EventHandler(this.tstPrimerRegistro_Click);
            // 
            // tstAnterior
            // 
            this.tstAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstAnterior.Image = ((System.Drawing.Image)(resources.GetObject("tstAnterior.Image")));
            this.tstAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstAnterior.Name = "tstAnterior";
            this.tstAnterior.Size = new System.Drawing.Size(23, 22);
            this.tstAnterior.Text = "toolStripButton1";
            this.tstAnterior.ToolTipText = "Va al anterior registro";
            this.tstAnterior.Click += new System.EventHandler(this.tstAnterior_Click);
            // 
            // tstSiguiente
            // 
            this.tstSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("tstSiguiente.Image")));
            this.tstSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSiguiente.Name = "tstSiguiente";
            this.tstSiguiente.Size = new System.Drawing.Size(23, 22);
            this.tstSiguiente.Text = "toolStripButton2";
            this.tstSiguiente.ToolTipText = "Va al siguiente registro";
            this.tstSiguiente.Click += new System.EventHandler(this.tstSiguiente_Click);
            // 
            // tstUltimo
            // 
            this.tstUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstUltimo.Image = ((System.Drawing.Image)(resources.GetObject("tstUltimo.Image")));
            this.tstUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstUltimo.Name = "tstUltimo";
            this.tstUltimo.Size = new System.Drawing.Size(23, 22);
            this.tstUltimo.Text = "Va al ultimo registro";
            this.tstUltimo.Click += new System.EventHandler(this.tstUltimo_Click);
            // 
            // tstNuevo
            // 
            this.tstNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tstNuevo.Image")));
            this.tstNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstNuevo.Name = "tstNuevo";
            this.tstNuevo.Size = new System.Drawing.Size(23, 22);
            this.tstNuevo.Text = "Nuevo registro";
            this.tstNuevo.Click += new System.EventHandler(this.tstNuevo_Click);
            // 
            // tstGuardar
            // 
            this.tstGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tstGuardar.Image")));
            this.tstGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstGuardar.Name = "tstGuardar";
            this.tstGuardar.Size = new System.Drawing.Size(23, 22);
            this.tstGuardar.Text = "Guardar";
            this.tstGuardar.Click += new System.EventHandler(this.tstGuardar_Click);
            // 
            // tstBorrar
            // 
            this.tstBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstBorrar.Image = ((System.Drawing.Image)(resources.GetObject("tstBorrar.Image")));
            this.tstBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstBorrar.Name = "tstBorrar";
            this.tstBorrar.Size = new System.Drawing.Size(23, 22);
            this.tstBorrar.Text = "Borrar";
            this.tstBorrar.Click += new System.EventHandler(this.tstBorrar_Click);
            // 
            // tstLimpiar
            // 
            this.tstLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tstLimpiar.Image")));
            this.tstLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstLimpiar.Name = "tstLimpiar";
            this.tstLimpiar.Size = new System.Drawing.Size(23, 22);
            this.tstLimpiar.Text = "Limpiar campos del formulario";
            this.tstLimpiar.Click += new System.EventHandler(this.tstLimpiar_Click);
            // 
            // cboCategorias
            // 
            this.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(561, 64);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(175, 21);
            this.cboCategorias.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Categorias";
            // 
            // cboIva
            // 
            this.cboIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIva.FormattingEnabled = true;
            this.cboIva.Location = new System.Drawing.Point(561, 111);
            this.cboIva.Name = "cboIva";
            this.cboIva.Size = new System.Drawing.Size(175, 21);
            this.cboIva.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Iva";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 421);
            this.Controls.Add(this.cboIva);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(this.tstMenu);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tstMenu.ResumeLayout(false);
            this.tstMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ToolStrip tstMenu;
        private System.Windows.Forms.ToolStripButton tstPrimerRegistro;
        private System.Windows.Forms.ToolStripButton tstAnterior;
        private System.Windows.Forms.ToolStripButton tstSiguiente;
        private System.Windows.Forms.ToolStripButton tstUltimo;
        private System.Windows.Forms.ToolStripButton tstNuevo;
        private System.Windows.Forms.ToolStripButton tstGuardar;
        private System.Windows.Forms.ToolStripButton tstBorrar;
        private System.Windows.Forms.ToolStripButton tstLimpiar;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboIva;
        private System.Windows.Forms.Label label7;
    }
}