namespace ProyectoFinalUNO
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
            this.tStMenu = new System.Windows.Forms.ToolStrip();
            this.tbtPrimero = new System.Windows.Forms.ToolStripButton();
            this.tbtAnterior = new System.Windows.Forms.ToolStripButton();
            this.tbtSiguiente = new System.Windows.Forms.ToolStripButton();
            this.tbtUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbtGuardar = new System.Windows.Forms.ToolStripButton();
            this.tbtLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tbtEliminar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Notas = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.tStMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tStMenu
            // 
            this.tStMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtPrimero,
            this.tbtAnterior,
            this.tbtSiguiente,
            this.tbtUltimo,
            this.toolStripSeparator1,
            this.tbtNuevo,
            this.tbtGuardar,
            this.tbtLimpiar,
            this.tbtEliminar});
            this.tStMenu.Location = new System.Drawing.Point(0, 0);
            this.tStMenu.Name = "tStMenu";
            this.tStMenu.Size = new System.Drawing.Size(620, 25);
            this.tStMenu.TabIndex = 0;
            this.tStMenu.Text = "toolStrip1";
            // 
            // tbtPrimero
            // 
            this.tbtPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtPrimero.Image = ((System.Drawing.Image)(resources.GetObject("tbtPrimero.Image")));
            this.tbtPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtPrimero.Name = "tbtPrimero";
            this.tbtPrimero.Size = new System.Drawing.Size(23, 22);
            this.tbtPrimero.Text = "toolStripButton1";
            this.tbtPrimero.ToolTipText = "Va al primer registro";
            this.tbtPrimero.Click += new System.EventHandler(this.tbtPrimero_Click);
            // 
            // tbtAnterior
            // 
            this.tbtAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtAnterior.Image = ((System.Drawing.Image)(resources.GetObject("tbtAnterior.Image")));
            this.tbtAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtAnterior.Name = "tbtAnterior";
            this.tbtAnterior.Size = new System.Drawing.Size(23, 22);
            this.tbtAnterior.Text = "toolStripButton1";
            this.tbtAnterior.ToolTipText = "Va al anterior registro";
            this.tbtAnterior.Click += new System.EventHandler(this.tbtAnterior_Click);
            // 
            // tbtSiguiente
            // 
            this.tbtSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("tbtSiguiente.Image")));
            this.tbtSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtSiguiente.Name = "tbtSiguiente";
            this.tbtSiguiente.Size = new System.Drawing.Size(23, 22);
            this.tbtSiguiente.Text = "toolStripButton2";
            this.tbtSiguiente.ToolTipText = "Va al siguiente registro";
            this.tbtSiguiente.Click += new System.EventHandler(this.tbtSiguiente_Click);
            // 
            // tbtUltimo
            // 
            this.tbtUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtUltimo.Image = ((System.Drawing.Image)(resources.GetObject("tbtUltimo.Image")));
            this.tbtUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtUltimo.Name = "tbtUltimo";
            this.tbtUltimo.Size = new System.Drawing.Size(23, 22);
            this.tbtUltimo.Text = "toolStripButton3";
            this.tbtUltimo.ToolTipText = "Va al ultimo registro";
            this.tbtUltimo.Click += new System.EventHandler(this.tbtUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtNuevo
            // 
            this.tbtNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tbtNuevo.Image")));
            this.tbtNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtNuevo.Name = "tbtNuevo";
            this.tbtNuevo.Size = new System.Drawing.Size(23, 22);
            this.tbtNuevo.Text = "toolStripButton4";
            this.tbtNuevo.ToolTipText = "Nuevo registro";
            this.tbtNuevo.Click += new System.EventHandler(this.tbtNuevo_Click);
            // 
            // tbtGuardar
            // 
            this.tbtGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tbtGuardar.Image")));
            this.tbtGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtGuardar.Name = "tbtGuardar";
            this.tbtGuardar.Size = new System.Drawing.Size(23, 22);
            this.tbtGuardar.Text = "toolStripButton1";
            this.tbtGuardar.ToolTipText = "Guardar cambios registro";
            this.tbtGuardar.Click += new System.EventHandler(this.tbtGuardar_Click);
            // 
            // tbtLimpiar
            // 
            this.tbtLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tbtLimpiar.Image")));
            this.tbtLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtLimpiar.Name = "tbtLimpiar";
            this.tbtLimpiar.Size = new System.Drawing.Size(23, 22);
            this.tbtLimpiar.Text = "toolStripButton5";
            this.tbtLimpiar.ToolTipText = "Limpia campos del formulario";
            this.tbtLimpiar.Click += new System.EventHandler(this.tbtLimpiar_Click);
            // 
            // tbtEliminar
            // 
            this.tbtEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tbtEliminar.Image")));
            this.tbtEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtEliminar.Name = "tbtEliminar";
            this.tbtEliminar.Size = new System.Drawing.Size(23, 22);
            this.tbtEliminar.Text = "toolStripButton6";
            this.tbtEliminar.ToolTipText = "Elimina registro";
            this.tbtEliminar.Click += new System.EventHandler(this.tbtEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Producto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(82, 53);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(82, 79);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(526, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(15, 232);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(568, 353);
            this.dgvProductos.TabIndex = 0;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(82, 136);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock";
            // 
            // Notas
            // 
            this.Notas.AutoSize = true;
            this.Notas.Location = new System.Drawing.Point(12, 166);
            this.Notas.Name = "Notas";
            this.Notas.Size = new System.Drawing.Size(35, 13);
            this.Notas.TabIndex = 8;
            this.Notas.Text = "Notas";
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.Location = new System.Drawing.Point(82, 163);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotas.Size = new System.Drawing.Size(526, 63);
            this.txtNotas.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(82, 110);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 597);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.Notas);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tStMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.tStMenu.ResumeLayout(false);
            this.tStMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStMenu;
        private System.Windows.Forms.ToolStripButton tbtPrimero;
        private System.Windows.Forms.ToolStripButton tbtAnterior;
        private System.Windows.Forms.ToolStripButton tbtSiguiente;
        private System.Windows.Forms.ToolStripButton tbtNuevo;
        private System.Windows.Forms.ToolStripButton tbtLimpiar;
        private System.Windows.Forms.ToolStripButton tbtEliminar;
        private System.Windows.Forms.ToolStripButton tbtUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Notas;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}