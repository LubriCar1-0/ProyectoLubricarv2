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
            this.txbCodPerm = new System.Windows.Forms.TextBox();
            this.btnBorraCampos = new System.Windows.Forms.Button();
            this.dgvCategoriasEmpleados = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CambiarEstado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnagregarcat = new System.Windows.Forms.Button();
            this.chPermiteEditar = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriasEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNomCat
            // 
            this.txbNomCat.Location = new System.Drawing.Point(350, 316);
            this.txbNomCat.Multiline = true;
            this.txbNomCat.Name = "txbNomCat";
            this.txbNomCat.Size = new System.Drawing.Size(372, 32);
            this.txbNomCat.TabIndex = 0;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(350, 468);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(372, 83);
            this.txbDescripcion.TabIndex = 1;
            // 
            // txbCodPerm
            // 
            this.txbCodPerm.Location = new System.Drawing.Point(926, 316);
            this.txbCodPerm.Multiline = true;
            this.txbCodPerm.Name = "txbCodPerm";
            this.txbCodPerm.Size = new System.Drawing.Size(372, 32);
            this.txbCodPerm.TabIndex = 2;
            // 
            // btnBorraCampos
            // 
            this.btnBorraCampos.BackgroundImage = global::Vista.Properties.Resources.blanco;
            this.btnBorraCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorraCampos.FlatAppearance.BorderSize = 0;
            this.btnBorraCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorraCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraCampos.Location = new System.Drawing.Point(1183, 820);
            this.btnBorraCampos.Name = "btnBorraCampos";
            this.btnBorraCampos.Size = new System.Drawing.Size(285, 39);
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
            this.dgvCategoriasEmpleados.Location = new System.Drawing.Point(416, 624);
            this.dgvCategoriasEmpleados.Name = "dgvCategoriasEmpleados";
            this.dgvCategoriasEmpleados.Size = new System.Drawing.Size(1052, 190);
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
            this.btnagregarcat.Location = new System.Drawing.Point(350, 841);
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
            this.chPermiteEditar.Location = new System.Drawing.Point(1233, 577);
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
            this.btnVolver.Location = new System.Drawing.Point(258, 174);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 57);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // MenuCategoriaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaCategoriaEmpleados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.chPermiteEditar);
            this.Controls.Add(this.btnagregarcat);
            this.Controls.Add(this.dgvCategoriasEmpleados);
            this.Controls.Add(this.btnBorraCampos);
            this.Controls.Add(this.txbCodPerm);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNomCat);
            this.DoubleBuffered = true;
            this.Name = "MenuCategoriaEmpleado";
            this.Text = "MenuCategoriaEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriasEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNomCat;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbCodPerm;
        private System.Windows.Forms.Button btnBorraCampos;
        private System.Windows.Forms.DataGridView dgvCategoriasEmpleados;
        private System.Windows.Forms.Button btnagregarcat;
        private System.Windows.Forms.CheckBox chPermiteEditar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn CambiarEstado;
        private System.Windows.Forms.Button btnVolver;
    }
}