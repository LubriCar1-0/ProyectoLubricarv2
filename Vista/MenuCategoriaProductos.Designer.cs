namespace Vista
{
    partial class MenuCategoriaProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.TXTDescripcion = new System.Windows.Forms.TextBox();
            this.DGVCategoriasProdc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnagregarcat = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chPermiteEditar = new System.Windows.Forms.CheckBox();
            this.btnBorraCampos = new System.Windows.Forms.Button();
            this.cbxLiquido = new System.Windows.Forms.CheckBox();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EstadoNuevo = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoriasProdc)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.TxtNombreProducto.Location = new System.Drawing.Point(393, 405);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(671, 47);
            this.TxtNombreProducto.TabIndex = 1;
            // 
            // TXTDescripcion
            // 
            this.TXTDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDescripcion.Location = new System.Drawing.Point(393, 289);
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.Size = new System.Drawing.Size(331, 47);
            this.TXTDescripcion.TabIndex = 2;
            this.TXTDescripcion.TextChanged += new System.EventHandler(this.TXTDescripcion_TextChanged);
            // 
            // DGVCategoriasProdc
            // 
            this.DGVCategoriasProdc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCategoriasProdc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategoriasProdc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.EstadoNuevo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCategoriasProdc.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCategoriasProdc.Location = new System.Drawing.Point(393, 557);
            this.DGVCategoriasProdc.Name = "DGVCategoriasProdc";
            this.DGVCategoriasProdc.Size = new System.Drawing.Size(1203, 443);
            this.DGVCategoriasProdc.TabIndex = 8;
            this.DGVCategoriasProdc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategoriasProdc_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(264, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 57);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnagregarcat
            // 
            this.btnagregarcat.BackgroundImage = global::Vista.Properties.Resources.BtnAgregar2;
            this.btnagregarcat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregarcat.FlatAppearance.BorderSize = 0;
            this.btnagregarcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarcat.Location = new System.Drawing.Point(393, 489);
            this.btnagregarcat.Name = "btnagregarcat";
            this.btnagregarcat.Size = new System.Drawing.Size(207, 62);
            this.btnagregarcat.TabIndex = 14;
            this.btnagregarcat.UseVisualStyleBackColor = true;
            this.btnagregarcat.Click += new System.EventHandler(this.btnagregarcat_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.txtEstado.Location = new System.Drawing.Point(1266, 342);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(66, 47);
            this.txtEstado.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1329, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Codigos de estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(831, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(1369, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "Activado : ACT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(1332, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 38);
            this.label4.TabIndex = 19;
            this.label4.Text = "Desactivado : DES";
            // 
            // chPermiteEditar
            // 
            this.chPermiteEditar.AutoSize = true;
            this.chPermiteEditar.BackColor = System.Drawing.Color.Transparent;
            this.chPermiteEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chPermiteEditar.Location = new System.Drawing.Point(1266, 510);
            this.chPermiteEditar.Name = "chPermiteEditar";
            this.chPermiteEditar.Size = new System.Drawing.Size(235, 41);
            this.chPermiteEditar.TabIndex = 20;
            this.chPermiteEditar.Text = "Permitir editar";
            this.chPermiteEditar.UseVisualStyleBackColor = false;
            this.chPermiteEditar.CheckedChanged += new System.EventHandler(this.chPermiteEditar_CheckedChanged);
            // 
            // btnBorraCampos
            // 
            this.btnBorraCampos.BackgroundImage = global::Vista.Properties.Resources.blanco;
            this.btnBorraCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorraCampos.FlatAppearance.BorderSize = 0;
            this.btnBorraCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorraCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraCampos.Location = new System.Drawing.Point(606, 512);
            this.btnBorraCampos.Name = "btnBorraCampos";
            this.btnBorraCampos.Size = new System.Drawing.Size(285, 39);
            this.btnBorraCampos.TabIndex = 21;
            this.btnBorraCampos.Text = "Borrar campos";
            this.btnBorraCampos.UseVisualStyleBackColor = true;
            this.btnBorraCampos.Click += new System.EventHandler(this.btnBorraCampos_Click);
            // 
            // cbxLiquido
            // 
            this.cbxLiquido.AutoSize = true;
            this.cbxLiquido.BackColor = System.Drawing.Color.Transparent;
            this.cbxLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLiquido.Location = new System.Drawing.Point(747, 289);
            this.cbxLiquido.Name = "cbxLiquido";
            this.cbxLiquido.Size = new System.Drawing.Size(165, 41);
            this.cbxLiquido.TabIndex = 22;
            this.cbxLiquido.Text = "Liquido?";
            this.cbxLiquido.UseVisualStyleBackColor = false;
            this.cbxLiquido.CheckedChanged += new System.EventHandler(this.cbxLiquido_CheckedChanged);
            // 
            // Editar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 75;
            // 
            // EstadoNuevo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.EstadoNuevo.DefaultCellStyle = dataGridViewCellStyle2;
            this.EstadoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EstadoNuevo.HeaderText = "";
            this.EstadoNuevo.Name = "EstadoNuevo";
            this.EstadoNuevo.Text = "Cambiar Estado";
            this.EstadoNuevo.ToolTipText = "Cambiar el estado ACT/DES";
            this.EstadoNuevo.UseColumnTextForButtonValue = true;
            // 
            // MenuCategoriaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.ABMcategoriasProductos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1892, 1041);
            this.Controls.Add(this.cbxLiquido);
            this.Controls.Add(this.btnBorraCampos);
            this.Controls.Add(this.chPermiteEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.btnagregarcat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVCategoriasProdc);
            this.Controls.Add(this.TXTDescripcion);
            this.Controls.Add(this.TxtNombreProducto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCategoriaProductos";
            this.Text = "MenuCategoriaProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoriasProdc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.TextBox TXTDescripcion;
        private System.Windows.Forms.DataGridView DGVCategoriasProdc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnagregarcat;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chPermiteEditar;
        private System.Windows.Forms.Button btnBorraCampos;
        private System.Windows.Forms.CheckBox cbxLiquido;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn EstadoNuevo;
    }
}