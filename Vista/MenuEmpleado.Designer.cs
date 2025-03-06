namespace Vista
{
    partial class MenuEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.TxtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.TxtDniEmpleado = new System.Windows.Forms.TextBox();
            this.TxtCelularEmpleado = new System.Windows.Forms.TextBox();
            this.CmbCategoriaEmple = new System.Windows.Forms.ComboBox();
            this.BtnAgregarMeEmpleado = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chbEditar = new System.Windows.Forms.CheckBox();
            this.btnBorraCampos = new System.Windows.Forms.Button();
            this.DgvMenuEmpleado = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMenuEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(339, 198);
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(243, 34);
            this.TxtNombreEmpleado.TabIndex = 1;
            // 
            // TxtApellidoEmpleado
            // 
            this.TxtApellidoEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.TxtApellidoEmpleado.Location = new System.Drawing.Point(813, 198);
            this.TxtApellidoEmpleado.Name = "TxtApellidoEmpleado";
            this.TxtApellidoEmpleado.Size = new System.Drawing.Size(243, 34);
            this.TxtApellidoEmpleado.TabIndex = 2;
            // 
            // TxtDniEmpleado
            // 
            this.TxtDniEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.TxtDniEmpleado.Location = new System.Drawing.Point(339, 274);
            this.TxtDniEmpleado.Name = "TxtDniEmpleado";
            this.TxtDniEmpleado.Size = new System.Drawing.Size(243, 34);
            this.TxtDniEmpleado.TabIndex = 3;
            // 
            // TxtCelularEmpleado
            // 
            this.TxtCelularEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.TxtCelularEmpleado.Location = new System.Drawing.Point(339, 362);
            this.TxtCelularEmpleado.Name = "TxtCelularEmpleado";
            this.TxtCelularEmpleado.Size = new System.Drawing.Size(243, 34);
            this.TxtCelularEmpleado.TabIndex = 5;
            this.TxtCelularEmpleado.TextChanged += new System.EventHandler(this.TxtCelularEmpleado_TextChanged);
            this.TxtCelularEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelularEmpleado_KeyPress);
            // 
            // CmbCategoriaEmple
            // 
            this.CmbCategoriaEmple.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategoriaEmple.FormattingEnabled = true;
            this.CmbCategoriaEmple.Location = new System.Drawing.Point(813, 362);
            this.CmbCategoriaEmple.Name = "CmbCategoriaEmple";
            this.CmbCategoriaEmple.Size = new System.Drawing.Size(243, 36);
            this.CmbCategoriaEmple.TabIndex = 6;
            this.CmbCategoriaEmple.SelectedIndexChanged += new System.EventHandler(this.CmbCategoriaEmple_SelectedIndexChanged);
            // 
            // BtnAgregarMeEmpleado
            // 
            this.BtnAgregarMeEmpleado.BackgroundImage = global::lubricar.Properties.Resources.BtnAgregar;
            this.BtnAgregarMeEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnAgregarMeEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarMeEmpleado.Location = new System.Drawing.Point(375, 700);
            this.BtnAgregarMeEmpleado.Name = "BtnAgregarMeEmpleado";
            this.BtnAgregarMeEmpleado.Size = new System.Drawing.Size(129, 43);
            this.BtnAgregarMeEmpleado.TabIndex = 7;
            this.BtnAgregarMeEmpleado.UseVisualStyleBackColor = true;
            this.BtnAgregarMeEmpleado.Click += new System.EventHandler(this.BtnAgregarMeEmpleado_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.txtContraseña.Location = new System.Drawing.Point(813, 274);
            this.txtContraseña.MaxLength = 8;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(243, 34);
            this.txtContraseña.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(190, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 57);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbEditar
            // 
            this.chbEditar.AutoSize = true;
            this.chbEditar.BackColor = System.Drawing.Color.Transparent;
            this.chbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEditar.Location = new System.Drawing.Point(1038, 405);
            this.chbEditar.Name = "chbEditar";
            this.chbEditar.Size = new System.Drawing.Size(124, 20);
            this.chbEditar.TabIndex = 14;
            this.chbEditar.Text = "Permitir Editar";
            this.chbEditar.UseVisualStyleBackColor = false;
            this.chbEditar.CheckedChanged += new System.EventHandler(this.chbEditar_CheckedChanged);
            // 
            // btnBorraCampos
            // 
            this.btnBorraCampos.BackgroundImage = global::lubricar.Properties.Resources.blanco;
            this.btnBorraCampos.FlatAppearance.BorderSize = 0;
            this.btnBorraCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorraCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraCampos.Location = new System.Drawing.Point(880, 713);
            this.btnBorraCampos.Name = "btnBorraCampos";
            this.btnBorraCampos.Size = new System.Drawing.Size(176, 30);
            this.btnBorraCampos.TabIndex = 8;
            this.btnBorraCampos.Text = "Borrar campos";
            this.btnBorraCampos.UseVisualStyleBackColor = true;
            this.btnBorraCampos.Click += new System.EventHandler(this.btnBorraCampos_Click);
            // 
            // DgvMenuEmpleado
            // 
            this.DgvMenuEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMenuEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.DgvMenuEmpleado.Location = new System.Drawing.Point(217, 431);
            this.DgvMenuEmpleado.Name = "DgvMenuEmpleado";
            this.DgvMenuEmpleado.Size = new System.Drawing.Size(945, 259);
            this.DgvMenuEmpleado.TabIndex = 24;
            this.DgvMenuEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMenuEmpleado_CellContentClick);
            // 
            // Editar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "EDITAR";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "Estado";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "ACT/DES";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // MenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.PantallaMenuEmpleados1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.DgvMenuEmpleado);
            this.Controls.Add(this.btnBorraCampos);
            this.Controls.Add(this.chbEditar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.BtnAgregarMeEmpleado);
            this.Controls.Add(this.CmbCategoriaEmple);
            this.Controls.Add(this.TxtCelularEmpleado);
            this.Controls.Add(this.TxtDniEmpleado);
            this.Controls.Add(this.TxtApellidoEmpleado);
            this.Controls.Add(this.TxtNombreEmpleado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMenuEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreEmpleado;
        private System.Windows.Forms.TextBox TxtApellidoEmpleado;
        private System.Windows.Forms.TextBox TxtDniEmpleado;
        private System.Windows.Forms.TextBox TxtCelularEmpleado;
        private System.Windows.Forms.ComboBox CmbCategoriaEmple;
        private System.Windows.Forms.Button BtnAgregarMeEmpleado;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbEditar;
        private System.Windows.Forms.Button btnBorraCampos;
        private System.Windows.Forms.DataGridView DgvMenuEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}