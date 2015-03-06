namespace Sistema_Farmaceutico
{
    partial class frm_Usuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Usuario));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNomUser = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Location = new System.Drawing.Point(0, 1);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(458, 362);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtId);
            this.groupBox7.Controls.Add(this.txtPass);
            this.groupBox7.Controls.Add(this.txtUsu);
            this.groupBox7.Controls.Add(this.txtNom);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Location = new System.Drawing.Point(51, 31);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(350, 187);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Linen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(96, 30);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(227, 21);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            this.txtId.Text = "0000";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Linen;
            this.txtPass.Location = new System.Drawing.Point(96, 149);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(227, 21);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            this.txtPass.Validated += new System.EventHandler(this.txtPass_Validated);
            // 
            // txtUsu
            // 
            this.txtUsu.BackColor = System.Drawing.Color.Linen;
            this.txtUsu.Location = new System.Drawing.Point(96, 109);
            this.txtUsu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(227, 21);
            this.txtUsu.TabIndex = 3;
            this.txtUsu.Enter += new System.EventHandler(this.txtUsu_Enter);
            this.txtUsu.Leave += new System.EventHandler(this.txtUsu_Leave);
            this.txtUsu.Validated += new System.EventHandler(this.txtUsu_Validated);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.Linen;
            this.txtNom.Location = new System.Drawing.Point(96, 69);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(227, 21);
            this.txtNom.TabIndex = 2;
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            this.txtNom.Validated += new System.EventHandler(this.txtNom_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Usuario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Id:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cboStatus);
            this.groupBox8.Controls.Add(this.cboNivel);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Location = new System.Drawing.Point(51, 218);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox8.Size = new System.Drawing.Size(350, 112);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.Linen;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Inhabilitado",
            "Habilitado"});
            this.cboStatus.Location = new System.Drawing.Point(96, 64);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(227, 24);
            this.cboStatus.TabIndex = 6;
            this.cboStatus.Enter += new System.EventHandler(this.cboStatus_Enter);
            this.cboStatus.Leave += new System.EventHandler(this.cboStatus_Leave);
            this.cboStatus.Validated += new System.EventHandler(this.cboStatus_Validated);
            // 
            // cboNivel
            // 
            this.cboNivel.BackColor = System.Drawing.Color.Linen;
            this.cboNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.cboNivel.Location = new System.Drawing.Point(96, 18);
            this.cboNivel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(227, 24);
            this.cboNivel.TabIndex = 5;
            this.cboNivel.Enter += new System.EventHandler(this.cboNivel_Enter);
            this.cboNivel.Leave += new System.EventHandler(this.cboNivel_Leave);
            this.cboNivel.Validated += new System.EventHandler(this.cboNivel_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nivel:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.txtNomUser);
            this.groupBox5.Location = new System.Drawing.Point(0, 1);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(458, 362);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar Usuario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(436, 307);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // txtNomUser
            // 
            this.txtNomUser.BackColor = System.Drawing.Color.Linen;
            this.txtNomUser.Location = new System.Drawing.Point(7, 19);
            this.txtNomUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomUser.Name = "txtNomUser";
            this.txtNomUser.Size = new System.Drawing.Size(437, 21);
            this.txtNomUser.TabIndex = 13;
            this.txtNomUser.Text = "Ingrese nombre usuario";
            this.txtNomUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomUser.TextChanged += new System.EventHandler(this.txtNomUser_TextChanged);
            this.txtNomUser.Enter += new System.EventHandler(this.txtNomUser_Enter);
            this.txtNomUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomUser_KeyPress_1);
            this.txtNomUser.Leave += new System.EventHandler(this.txtNomUser_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 364);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frm_Usuario_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNomUser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}