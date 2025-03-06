namespace Vista
{
    partial class MenuCategoriaEmpleado
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
            this.txbNomCat = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.btnBorraCampos = new System.Windows.Forms.Button();
            this.dgvCategoriasEmpleados = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CambiarEstado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnagregarcat = new System.Windows.Forms.Button();
            this.chPermiteEditar = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbCodPerm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriasEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNomCat
            // 
            this.txbNomCat.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomCat.Location = new System.Drawing.Point(253, 237);
            this.txbNomCat.Multiline = true;
            this.txbNomCat.Name = "txbNomCat";
            this.txbNomCat.Size = new System.Drawing.Size(372, 32);
            this.txbNomCat.TabIndex = 0;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescripcion.Location = new System.Drawing.Point(253, 344);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(487, 92);
            this.txbDescripcion.TabIndex = 1;
            // 
            // btnBorraCampos
            // 
            this.btnBorraCampos.BackgroundImage = global::Vista.Properties.Resources.blanco;
            this.btnBorraCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorraCampos.FlatAppearance.BorderSize = 0;
            this.btnBorraCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorraCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraCampos.Location = new System.Drawing.Point(921, 634);
            this.btnBorraCampos.Name = "btnBorraCampos";
            this.btnBorraCampos.Size = new System.Drawing.Size(215, 39);
            this.btnBorraCampos.TabIndex = 22;
            this.btnBorraCampos.Text = "Borrar campos";
            this.btnBorraCampos.UseVisualStyleBackColor = true;
            this.btnBorraCampos.Click += new System.EventHandler(this.btnBorraCampos_Click);
            // 
            // dgvCategoriasEmpleados
            // 
            this.dgvCategoriasEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriasEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.CambiarEstado});
            this.dgvCategoriasEmpleados.Location = new System.Drawing.Point(208, 454);
            this.dgvCategoriasEmpleados.Name = "dgvCategoriasEmpleados";
            this.dgvCategoriasEmpleados.Size = new System.Drawing.Size(939, 174);
            this.dgvCategoriasEmpleados.TabIndex = 23;
            this.dgvCategoriasEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriasEmpleados_CellContentClick);
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
            // CambiarEstado
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.CambiarEstado.DefaultCellStyle = dataGridViewCellStyle4;
            this.CambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CambiarEstado.HeaderText = "Cambiar Estado";
            this.CambiarEstado.Name = "CambiarEstado";
            this.CambiarEstado.Text = "ACT/DES";
            this.CambiarEstado.UseColumnTextForButtonValue = true;
            // 
            // btnagregarcat
            // 
            this.btnagregarcat.BackgroundImage = global::Vista.Properties.Resources.BtnAgregar2;
            this.btnagregarcat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregarcat.FlatAppearance.BorderSize = 0;
            this.btnagregarcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarcat.Location = new System.Drawing.Point(205, 642);
            this.btnagregarcat.Name = "btnagregarcat";
            this.btnagregarcat.Size = new System.Drawing.Size(207, 62);
            this.btnagregarcat.TabIndex = 24;
            this.btnagregarcat.UseVisualStyleBackColor = true;
            this.btnagregarcat.Click += new System.EventHandler(this.btnagregarcat_Click);
            // 
            // chPermiteEditar
            // 
            this.chPermiteEditar.AutoSize = true;
            this.chPermiteEditar.BackColor = System.Drawing.Color.Transparent;
            this.chPermiteEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chPermiteEditar.Location = new System.Drawing.Point(912, 407);
            this.chPermiteEditar.Name = "chPermiteEditar";
            this.chPermiteEditar.Size = new System.Drawing.Size(235, 41);
            this.chPermiteEditar.TabIndex = 25;
            this.chPermiteEditar.Text = "Permitir editar";
            this.chPermiteEditar.UseVisualStyleBackColor = false;
            this.chPermiteEditar.CheckedChanged += new System.EventHandler(this.chPermiteEditar_CheckedChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.btnVolver.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(183, 126);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 57);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbCodPerm
            // 
            this.cmbCodPerm.FormattingEnabled = true;
            this.cmbCodPerm.Location = new System.Drawing.Point(667, 237);
            this.cmbCodPerm.Name = "cmbCodPerm";
            this.cmbCodPerm.Size = new System.Drawing.Size(245, 21);
            this.cmbCodPerm.TabIndex = 27;
            // 
            // MenuCategoriaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaCategoriaEmpleados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.cmbCodPerm);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.chPermiteEditar);
            this.Controls.Add(this.btnagregarcat);
            this.Controls.Add(this.dgvCategoriasEmpleados);
            this.Controls.Add(this.btnBorraCampos);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNomCat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCategoriaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCategoriaEmpleado";
            this.Load += new System.EventHandler(this.MenuCategoriaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriasEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNomCat;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Button btnBorraCampos;
        private System.Windows.Forms.DataGridView dgvCategoriasEmpleados;
        private System.Windows.Forms.Button btnagregarcat;
        private System.Windows.Forms.CheckBox chPermiteEditar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn CambiarEstado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbCodPerm;
    }
}