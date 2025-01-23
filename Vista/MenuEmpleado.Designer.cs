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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.TxtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.TxtDniEmpleado = new System.Windows.Forms.TextBox();
            this.TxtCelularEmpleado = new System.Windows.Forms.TextBox();
            this.CmbCategoriaEmple = new System.Windows.Forms.ComboBox();
            this.DgvMenuEmpleado = new System.Windows.Forms.DataGridView();
            this.BtnAgregarMeEmpleado = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chbEditar = new System.Windows.Forms.CheckBox();
            this.btnBorraCampos = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMenuEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(315, 186);
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(243, 22);
            this.TxtNombreEmpleado.TabIndex = 0;
            // 
            // TxtApellidoEmpleado
            // 
            this.TxtApellidoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoEmpleado.Location = new System.Drawing.Point(768, 186);
            this.TxtApellidoEmpleado.Name = "TxtApellidoEmpleado";
            this.TxtApellidoEmpleado.Size = new System.Drawing.Size(243, 22);
            this.TxtApellidoEmpleado.TabIndex = 1;
            // 
            // TxtDniEmpleado
            // 
            this.TxtDniEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDniEmpleado.Location = new System.Drawing.Point(315, 256);
            this.TxtDniEmpleado.Name = "TxtDniEmpleado";
            this.TxtDniEmpleado.Size = new System.Drawing.Size(243, 22);
            this.TxtDniEmpleado.TabIndex = 2;
            // 
            // TxtCelularEmpleado
            // 
            this.TxtCelularEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelularEmpleado.Location = new System.Drawing.Point(315, 348);
            this.TxtCelularEmpleado.Name = "TxtCelularEmpleado";
            this.TxtCelularEmpleado.Size = new System.Drawing.Size(243, 22);
            this.TxtCelularEmpleado.TabIndex = 3;
            // 
            // CmbCategoriaEmple
            // 
            this.CmbCategoriaEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategoriaEmple.FormattingEnabled = true;
            this.CmbCategoriaEmple.Location = new System.Drawing.Point(768, 346);
            this.CmbCategoriaEmple.Name = "CmbCategoriaEmple";
            this.CmbCategoriaEmple.Size = new System.Drawing.Size(243, 24);
            this.CmbCategoriaEmple.TabIndex = 4;
            this.CmbCategoriaEmple.SelectedIndexChanged += new System.EventHandler(this.CmbCategoriaEmple_SelectedIndexChanged);
            // 
            // DgvMenuEmpleado
            // 
            this.DgvMenuEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMenuEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.DgvMenuEmpleado.Location = new System.Drawing.Point(315, 420);
            this.DgvMenuEmpleado.Name = "DgvMenuEmpleado";
            this.DgvMenuEmpleado.Size = new System.Drawing.Size(696, 150);
            this.DgvMenuEmpleado.TabIndex = 6;
            this.DgvMenuEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMenuEmpleado_CellContentClick);
            // 
            // BtnAgregarMeEmpleado
            // 
            this.BtnAgregarMeEmpleado.BackgroundImage = global::Vista.Properties.Resources.BtnAgregar;
            this.BtnAgregarMeEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnAgregarMeEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarMeEmpleado.Location = new System.Drawing.Point(315, 576);
            this.BtnAgregarMeEmpleado.Name = "BtnAgregarMeEmpleado";
            this.BtnAgregarMeEmpleado.Size = new System.Drawing.Size(129, 43);
            this.BtnAgregarMeEmpleado.TabIndex = 8;
            this.BtnAgregarMeEmpleado.UseVisualStyleBackColor = true;
            this.BtnAgregarMeEmpleado.Click += new System.EventHandler(this.BtnAgregarMeEmpleado_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(768, 256);
            this.txtContraseña.MaxLength = 8;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(243, 22);
            this.txtContraseña.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(179, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 57);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // chbEditar
            // 
            this.chbEditar.AutoSize = true;
            this.chbEditar.BackColor = System.Drawing.Color.Transparent;
            this.chbEditar.Location = new System.Drawing.Point(1017, 445);
            this.chbEditar.Name = "chbEditar";
            this.chbEditar.Size = new System.Drawing.Size(90, 17);
            this.chbEditar.TabIndex = 14;
            this.chbEditar.Text = "Permitir Editar";
            this.chbEditar.UseVisualStyleBackColor = false;
            this.chbEditar.CheckedChanged += new System.EventHandler(this.chbEditar_CheckedChanged);
            // 
            // btnBorraCampos
            // 
            this.btnBorraCampos.BackgroundImage = global::Vista.Properties.Resources.blanco;
            this.btnBorraCampos.FlatAppearance.BorderSize = 0;
            this.btnBorraCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorraCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraCampos.Location = new System.Drawing.Point(872, 576);
            this.btnBorraCampos.Name = "btnBorraCampos";
            this.btnBorraCampos.Size = new System.Drawing.Size(139, 30);
            this.btnBorraCampos.TabIndex = 23;
            this.btnBorraCampos.Text = "Borrar campos";
            this.btnBorraCampos.UseVisualStyleBackColor = true;
            this.btnBorraCampos.Click += new System.EventHandler(this.btnBorraCampos_Click);
            // 
            // Editar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Eliminar.HeaderText = "Baja/Alta";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "ESTADO";
            // 
            // MenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuEmpleados1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1284, 722);
            this.Controls.Add(this.btnBorraCampos);
            this.Controls.Add(this.chbEditar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.BtnAgregarMeEmpleado);
            this.Controls.Add(this.DgvMenuEmpleado);
            this.Controls.Add(this.CmbCategoriaEmple);
            this.Controls.Add(this.TxtCelularEmpleado);
            this.Controls.Add(this.TxtDniEmpleado);
            this.Controls.Add(this.TxtApellidoEmpleado);
            this.Controls.Add(this.TxtNombreEmpleado);
            this.DoubleBuffered = true;
            this.Name = "MenuEmpleado";
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
        private System.Windows.Forms.DataGridView DgvMenuEmpleado;
        private System.Windows.Forms.Button BtnAgregarMeEmpleado;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbEditar;
        private System.Windows.Forms.Button btnBorraCampos;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}