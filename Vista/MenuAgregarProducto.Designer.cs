namespace Vista
{
    partial class MenuAgregarProducto
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
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.TxtMarcaProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtCantMin = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.TxtPrecioList = new System.Windows.Forms.TextBox();
            this.txtPrecioVent = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcodigoProducto = new System.Windows.Forms.TextBox();
            this.chPermiteEditar = new System.Windows.Forms.CheckBox();
            this.cbxMostrarProductos = new System.Windows.Forms.CheckBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtLitrosMinimos = new System.Windows.Forms.TextBox();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CambiarEstado = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.Location = new System.Drawing.Point(1198, 455);
            this.TxtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(570, 63);
            this.TxtNombreProducto.TabIndex = 2;
            // 
            // TxtMarcaProducto
            // 
            this.TxtMarcaProducto.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarcaProducto.Location = new System.Drawing.Point(1888, 455);
            this.TxtMarcaProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMarcaProducto.Name = "TxtMarcaProducto";
            this.TxtMarcaProducto.Size = new System.Drawing.Size(547, 63);
            this.TxtMarcaProducto.TabIndex = 3;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(518, 645);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(438, 63);
            this.TxtCantidad.TabIndex = 4;
            this.TxtCantidad.Text = "0";
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // TxtCantMin
            // 
            this.TxtCantMin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantMin.Location = new System.Drawing.Point(1214, 645);
            this.TxtCantMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCantMin.Name = "TxtCantMin";
            this.TxtCantMin.Size = new System.Drawing.Size(438, 63);
            this.TxtCantMin.TabIndex = 5;
            this.TxtCantMin.Text = "0";
            this.TxtCantMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCantMin.TextChanged += new System.EventHandler(this.TxtCantMin_TextChanged);
            this.TxtCantMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantMin_KeyPress);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(518, 1168);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(1836, 381);
            this.TxtDescripcion.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Vista.Properties.Resources.BtnAgregar;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(2120, 1000);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(236, 97);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TxtPrecioList
            // 
            this.TxtPrecioList.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioList.Location = new System.Drawing.Point(518, 1000);
            this.TxtPrecioList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecioList.Name = "TxtPrecioList";
            this.TxtPrecioList.Size = new System.Drawing.Size(438, 63);
            this.TxtPrecioList.TabIndex = 7;
            this.TxtPrecioList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecioList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioList_KeyPress);
            // 
            // txtPrecioVent
            // 
            this.txtPrecioVent.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVent.Location = new System.Drawing.Point(1214, 1000);
            this.txtPrecioVent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioVent.Name = "txtPrecioVent";
            this.txtPrecioVent.Size = new System.Drawing.Size(438, 63);
            this.txtPrecioVent.TabIndex = 8;
            this.txtPrecioVent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioVent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVent_KeyPress);
            // 
            // txtLitros
            // 
            this.txtLitros.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLitros.Location = new System.Drawing.Point(518, 814);
            this.txtLitros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(438, 63);
            this.txtLitros.TabIndex = 6;
            this.txtLitros.Text = "0.0";
            this.txtLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLitros_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(393, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 129);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcodigoProducto
            // 
            this.txtcodigoProducto.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoProducto.Location = new System.Drawing.Point(1888, 645);
            this.txtcodigoProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodigoProducto.Name = "txtcodigoProducto";
            this.txtcodigoProducto.Size = new System.Drawing.Size(438, 63);
            this.txtcodigoProducto.TabIndex = 9;
            this.txtcodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chPermiteEditar
            // 
            this.chPermiteEditar.AutoSize = true;
            this.chPermiteEditar.BackColor = System.Drawing.Color.Transparent;
            this.chPermiteEditar.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chPermiteEditar.Location = new System.Drawing.Point(1070, 257);
            this.chPermiteEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chPermiteEditar.Name = "chPermiteEditar";
            this.chPermiteEditar.Size = new System.Drawing.Size(358, 59);
            this.chPermiteEditar.TabIndex = 21;
            this.chPermiteEditar.Text = "Permitir editar";
            this.chPermiteEditar.UseVisualStyleBackColor = false;
            this.chPermiteEditar.CheckedChanged += new System.EventHandler(this.chPermiteEditar_CheckedChanged);
            // 
            // cbxMostrarProductos
            // 
            this.cbxMostrarProductos.AutoSize = true;
            this.cbxMostrarProductos.BackColor = System.Drawing.Color.Transparent;
            this.cbxMostrarProductos.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMostrarProductos.Location = new System.Drawing.Point(603, 257);
            this.cbxMostrarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMostrarProductos.Name = "cbxMostrarProductos";
            this.cbxMostrarProductos.Size = new System.Drawing.Size(435, 59);
            this.cbxMostrarProductos.TabIndex = 22;
            this.cbxMostrarProductos.Text = "Mostrar productos";
            this.cbxMostrarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxMostrarProductos.UseVisualStyleBackColor = false;
            this.cbxMostrarProductos.CheckedChanged += new System.EventHandler(this.cbxMostrarProductos_CheckedChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(518, 463);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(520, 63);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.Text = "Selecione categoría";
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // txtLitrosMinimos
            // 
            this.txtLitrosMinimos.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLitrosMinimos.Location = new System.Drawing.Point(1214, 834);
            this.txtLitrosMinimos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLitrosMinimos.Name = "txtLitrosMinimos";
            this.txtLitrosMinimos.Size = new System.Drawing.Size(438, 63);
            this.txtLitrosMinimos.TabIndex = 23;
            this.txtLitrosMinimos.Text = "0.0";
            this.txtLitrosMinimos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DGVProductos
            // 
            this.DGVProductos.AllowUserToAddRows = false;
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.CambiarEstado});
            this.DGVProductos.Location = new System.Drawing.Point(468, 362);
            this.DGVProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.RowHeadersWidth = 62;
            this.DGVProductos.Size = new System.Drawing.Size(1970, 1187);
            this.DGVProductos.TabIndex = 14;
            this.DGVProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellContentClick);
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
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.ToolTipText = "Se editara la fila seleccionada";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 150;
            // 
            // CambiarEstado
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.CambiarEstado.DefaultCellStyle = dataGridViewCellStyle2;
            this.CambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CambiarEstado.HeaderText = "";
            this.CambiarEstado.MinimumWidth = 8;
            this.CambiarEstado.Name = "CambiarEstado";
            this.CambiarEstado.Text = "Cambiar Estado";
            this.CambiarEstado.ToolTipText = "Se cambiara el estado  la fila seleccionada";
            this.CambiarEstado.UseColumnTextForButtonValue = true;
            this.CambiarEstado.Width = 150;
            // 
            // MenuAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaAgregarProducto1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2856, 1602);
            this.Controls.Add(this.cbxMostrarProductos);
            this.Controls.Add(this.chPermiteEditar);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.txtcodigoProducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtPrecioVent);
            this.Controls.Add(this.TxtPrecioList);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCantMin);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtMarcaProducto);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.txtLitrosMinimos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAgregarProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.TextBox TxtMarcaProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtCantMin;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox TxtPrecioList;
        private System.Windows.Forms.TextBox txtPrecioVent;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcodigoProducto;
        private System.Windows.Forms.CheckBox chPermiteEditar;
        private System.Windows.Forms.CheckBox cbxMostrarProductos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtLitrosMinimos;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn CambiarEstado;
    }
}