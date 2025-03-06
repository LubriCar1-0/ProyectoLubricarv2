namespace Vista
{
    partial class MenuClientes
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
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.TxtLocalidadCliente = new System.Windows.Forms.TextBox();
            this.TxtCuilCliente = new System.Windows.Forms.TextBox();
            this.DgvTablaClientes = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAgregarMeClientes = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.TxtRazonSocialCliente = new System.Windows.Forms.TextBox();
            this.TxtapellidoCliente = new System.Windows.Forms.TextBox();
            this.TxtNumCasaCliente = new System.Windows.Forms.TextBox();
            this.TxtCalleCliente = new System.Windows.Forms.TextBox();
            this.TxtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.CMBIVA = new System.Windows.Forms.ComboBox();
            this.chbeditar = new System.Windows.Forms.CheckBox();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaClientes)).BeginInit();
            this.grpListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(362, 164);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtNombreCliente.TabIndex = 1;
            // 
            // TxtLocalidadCliente
            // 
            this.TxtLocalidadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLocalidadCliente.Location = new System.Drawing.Point(362, 323);
            this.TxtLocalidadCliente.Name = "TxtLocalidadCliente";
            this.TxtLocalidadCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtLocalidadCliente.TabIndex = 5;
            // 
            // TxtCuilCliente
            // 
            this.TxtCuilCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuilCliente.Location = new System.Drawing.Point(816, 245);
            this.TxtCuilCliente.Name = "TxtCuilCliente";
            this.TxtCuilCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtCuilCliente.TabIndex = 4;
            this.TxtCuilCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCuilCliente_KeyPress_1);
            // 
            // DgvTablaClientes
            // 
            this.DgvTablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.DgvTablaClientes.Location = new System.Drawing.Point(6, 78);
            this.DgvTablaClientes.Name = "DgvTablaClientes";
            this.DgvTablaClientes.Size = new System.Drawing.Size(1281, 406);
            this.DgvTablaClientes.TabIndex = 4;
            this.DgvTablaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTablaClientes_CellContentClick);
            // 
            // Editar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // BtnAgregarMeClientes
            // 
            this.BtnAgregarMeClientes.BackgroundImage = global::lubricar.Properties.Resources.BtnAgregar;
            this.BtnAgregarMeClientes.FlatAppearance.BorderSize = 0;
            this.BtnAgregarMeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarMeClientes.Location = new System.Drawing.Point(845, 498);
            this.BtnAgregarMeClientes.Name = "BtnAgregarMeClientes";
            this.BtnAgregarMeClientes.Size = new System.Drawing.Size(123, 43);
            this.BtnAgregarMeClientes.TabIndex = 10;
            this.BtnAgregarMeClientes.UseVisualStyleBackColor = true;
            this.BtnAgregarMeClientes.Click += new System.EventHandler(this.BtnAgregarMeClientes_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(188, 125);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(73, 49);
            this.BtnVolver.TabIndex = 12;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // TxtRazonSocialCliente
            // 
            this.TxtRazonSocialCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRazonSocialCliente.Location = new System.Drawing.Point(362, 245);
            this.TxtRazonSocialCliente.Name = "TxtRazonSocialCliente";
            this.TxtRazonSocialCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtRazonSocialCliente.TabIndex = 3;
            // 
            // TxtapellidoCliente
            // 
            this.TxtapellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtapellidoCliente.Location = new System.Drawing.Point(816, 174);
            this.TxtapellidoCliente.Name = "TxtapellidoCliente";
            this.TxtapellidoCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtapellidoCliente.TabIndex = 2;
            // 
            // TxtNumCasaCliente
            // 
            this.TxtNumCasaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumCasaCliente.Location = new System.Drawing.Point(362, 419);
            this.TxtNumCasaCliente.Name = "TxtNumCasaCliente";
            this.TxtNumCasaCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtNumCasaCliente.TabIndex = 7;
            this.TxtNumCasaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumCasaCliente_KeyPress);
            // 
            // TxtCalleCliente
            // 
            this.TxtCalleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCalleCliente.Location = new System.Drawing.Point(816, 323);
            this.TxtCalleCliente.Name = "TxtCalleCliente";
            this.TxtCalleCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtCalleCliente.TabIndex = 6;
            // 
            // TxtTelefonoCliente
            // 
            this.TxtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoCliente.Location = new System.Drawing.Point(364, 515);
            this.TxtTelefonoCliente.Name = "TxtTelefonoCliente";
            this.TxtTelefonoCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtTelefonoCliente.TabIndex = 9;
            this.TxtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoCliente_KeyPress);
            // 
            // CMBIVA
            // 
            this.CMBIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CMBIVA.FormattingEnabled = true;
            this.CMBIVA.Location = new System.Drawing.Point(816, 419);
            this.CMBIVA.Name = "CMBIVA";
            this.CMBIVA.Size = new System.Drawing.Size(234, 28);
            this.CMBIVA.TabIndex = 8;
            this.CMBIVA.SelectedIndexChanged += new System.EventHandler(this.CMBIVA_SelectedIndexChanged);
            // 
            // chbeditar
            // 
            this.chbeditar.AutoSize = true;
            this.chbeditar.BackColor = System.Drawing.Color.Transparent;
            this.chbeditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbeditar.Location = new System.Drawing.Point(1194, 46);
            this.chbeditar.Name = "chbeditar";
            this.chbeditar.Size = new System.Drawing.Size(93, 29);
            this.chbeditar.TabIndex = 17;
            this.chbeditar.Text = "Editar";
            this.chbeditar.UseVisualStyleBackColor = false;
            this.chbeditar.CheckedChanged += new System.EventHandler(this.chbeditar_CheckedChanged);
            // 
            // grpListado
            // 
            this.grpListado.BackColor = System.Drawing.Color.PeachPuff;
            this.grpListado.Controls.Add(this.DgvTablaClientes);
            this.grpListado.Controls.Add(this.button1);
            this.grpListado.Controls.Add(this.chbeditar);
            this.grpListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListado.Location = new System.Drawing.Point(34, 232);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(1293, 362);
            this.grpListado.TabIndex = 18;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Clientes ingresados";
            this.grpListado.Enter += new System.EventHandler(this.grpListado_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.button1.Location = new System.Drawing.Point(6, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 49);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListado
            // 
            this.btnListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.Location = new System.Drawing.Point(509, 622);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(385, 54);
            this.btnListado.TabIndex = 11;
            this.btnListado.Text = "Mostrar clientes cargados";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.MenuClientes1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.CMBIVA);
            this.Controls.Add(this.TxtTelefonoCliente);
            this.Controls.Add(this.TxtCalleCliente);
            this.Controls.Add(this.TxtNumCasaCliente);
            this.Controls.Add(this.TxtapellidoCliente);
            this.Controls.Add(this.TxtRazonSocialCliente);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnAgregarMeClientes);
            this.Controls.Add(this.TxtCuilCliente);
            this.Controls.Add(this.TxtLocalidadCliente);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.btnListado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuClientes";
            this.Load += new System.EventHandler(this.MenuClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaClientes)).EndInit();
            this.grpListado.ResumeLayout(false);
            this.grpListado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.TextBox TxtLocalidadCliente;
        private System.Windows.Forms.TextBox TxtCuilCliente;
        private System.Windows.Forms.DataGridView DgvTablaClientes;
        private System.Windows.Forms.Button BtnAgregarMeClientes;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.TextBox TxtRazonSocialCliente;
        private System.Windows.Forms.TextBox TxtapellidoCliente;
        private System.Windows.Forms.TextBox TxtNumCasaCliente;
        private System.Windows.Forms.TextBox TxtCalleCliente;
        private System.Windows.Forms.TextBox TxtTelefonoCliente;
        private System.Windows.Forms.ComboBox CMBIVA;
        private System.Windows.Forms.CheckBox chbeditar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListado;
    }
}