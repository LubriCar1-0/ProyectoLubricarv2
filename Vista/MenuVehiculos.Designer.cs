namespace Vista
{
    partial class MenuVehiculos
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
            this.BtnAgregarMeVehiculos = new System.Windows.Forms.Button();
            this.DgvTablaMeVehiculos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CbxClienteMeVehiculos = new System.Windows.Forms.ComboBox();
            this.TxtMarcaVehiculos = new System.Windows.Forms.TextBox();
            this.TxtModeloVehiculos = new System.Windows.Forms.TextBox();
            this.TxtPatenteVehiculo = new System.Windows.Forms.TextBox();
            this.TxtAñoVehiculos = new System.Windows.Forms.TextBox();
            this.TxtKilometrajeVehiculos = new System.Windows.Forms.TextBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.chbEditar = new System.Windows.Forms.CheckBox();
            this.btnBorraCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaMeVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregarMeVehiculos
            // 
            this.BtnAgregarMeVehiculos.BackgroundImage = global::Vista.Properties.Resources.BtnAgregar;
            this.BtnAgregarMeVehiculos.FlatAppearance.BorderSize = 0;
            this.BtnAgregarMeVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarMeVehiculos.Location = new System.Drawing.Point(610, 713);
            this.BtnAgregarMeVehiculos.Name = "BtnAgregarMeVehiculos";
            this.BtnAgregarMeVehiculos.Size = new System.Drawing.Size(125, 43);
            this.BtnAgregarMeVehiculos.TabIndex = 4;
            this.BtnAgregarMeVehiculos.UseVisualStyleBackColor = true;
            this.BtnAgregarMeVehiculos.Click += new System.EventHandler(this.BtnAgregarMeVehiculos_Click);
            // 
            // DgvTablaMeVehiculos
            // 
            this.DgvTablaMeVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaMeVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.DgvTablaMeVehiculos.Location = new System.Drawing.Point(200, 510);
            this.DgvTablaMeVehiculos.Name = "DgvTablaMeVehiculos";
            this.DgvTablaMeVehiculos.Size = new System.Drawing.Size(963, 197);
            this.DgvTablaMeVehiculos.TabIndex = 7;
            this.DgvTablaMeVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTablaMeVehiculos_CellContentClick);
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
            this.Editar.Frozen = true;
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
            this.Eliminar.Frozen = true;
            this.Eliminar.HeaderText = "Estado";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "ACT/DES";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // CbxClienteMeVehiculos
            // 
            this.CbxClienteMeVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxClienteMeVehiculos.FormattingEnabled = true;
            this.CbxClienteMeVehiculos.Location = new System.Drawing.Point(310, 297);
            this.CbxClienteMeVehiculos.Name = "CbxClienteMeVehiculos";
            this.CbxClienteMeVehiculos.Size = new System.Drawing.Size(234, 28);
            this.CbxClienteMeVehiculos.TabIndex = 8;
            this.CbxClienteMeVehiculos.SelectedIndexChanged += new System.EventHandler(this.CbxClienteMeVehiculos_SelectedIndexChanged);
            // 
            // TxtMarcaVehiculos
            // 
            this.TxtMarcaVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarcaVehiculos.Location = new System.Drawing.Point(310, 376);
            this.TxtMarcaVehiculos.Name = "TxtMarcaVehiculos";
            this.TxtMarcaVehiculos.Size = new System.Drawing.Size(234, 26);
            this.TxtMarcaVehiculos.TabIndex = 9;
            this.TxtMarcaVehiculos.TextChanged += new System.EventHandler(this.TxtMarcaVehiculos_TextChanged);
            // 
            // TxtModeloVehiculos
            // 
            this.TxtModeloVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtModeloVehiculos.Location = new System.Drawing.Point(792, 297);
            this.TxtModeloVehiculos.Name = "TxtModeloVehiculos";
            this.TxtModeloVehiculos.Size = new System.Drawing.Size(234, 26);
            this.TxtModeloVehiculos.TabIndex = 10;
            // 
            // TxtPatenteVehiculo
            // 
            this.TxtPatenteVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPatenteVehiculo.Location = new System.Drawing.Point(310, 451);
            this.TxtPatenteVehiculo.Name = "TxtPatenteVehiculo";
            this.TxtPatenteVehiculo.Size = new System.Drawing.Size(234, 26);
            this.TxtPatenteVehiculo.TabIndex = 11;
            // 
            // TxtAñoVehiculos
            // 
            this.TxtAñoVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAñoVehiculos.Location = new System.Drawing.Point(792, 378);
            this.TxtAñoVehiculos.Name = "TxtAñoVehiculos";
            this.TxtAñoVehiculos.Size = new System.Drawing.Size(234, 26);
            this.TxtAñoVehiculos.TabIndex = 12;
            this.TxtAñoVehiculos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAñoVehiculos_KeyPress);
            // 
            // TxtKilometrajeVehiculos
            // 
            this.TxtKilometrajeVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKilometrajeVehiculos.Location = new System.Drawing.Point(792, 453);
            this.TxtKilometrajeVehiculos.Name = "TxtKilometrajeVehiculos";
            this.TxtKilometrajeVehiculos.Size = new System.Drawing.Size(234, 26);
            this.TxtKilometrajeVehiculos.TabIndex = 13;
            this.TxtKilometrajeVehiculos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKilometrajeVehiculos_KeyPress);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(200, 149);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 14;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // chbEditar
            // 
            this.chbEditar.AutoSize = true;
            this.chbEditar.BackColor = System.Drawing.Color.Transparent;
            this.chbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEditar.Location = new System.Drawing.Point(1000, 485);
            this.chbEditar.Name = "chbEditar";
            this.chbEditar.Size = new System.Drawing.Size(109, 20);
            this.chbEditar.TabIndex = 15;
            this.chbEditar.Text = "Permitir Editar";
            this.chbEditar.UseVisualStyleBackColor = false;
            this.chbEditar.CheckedChanged += new System.EventHandler(this.chbEditar_CheckedChanged_1);
            // 
            // btnBorraCampos
            // 
            this.btnBorraCampos.BackgroundImage = global::Vista.Properties.Resources.blanco;
            this.btnBorraCampos.FlatAppearance.BorderSize = 0;
            this.btnBorraCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorraCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraCampos.Location = new System.Drawing.Point(970, 713);
            this.btnBorraCampos.Name = "btnBorraCampos";
            this.btnBorraCampos.Size = new System.Drawing.Size(139, 30);
            this.btnBorraCampos.TabIndex = 22;
            this.btnBorraCampos.Text = "Borrar campos";
            this.btnBorraCampos.UseVisualStyleBackColor = true;
            this.btnBorraCampos.Click += new System.EventHandler(this.btnBorraCampos_Click);
            // 
            // MenuVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuVehiculos2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnBorraCampos);
            this.Controls.Add(this.chbEditar);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.TxtKilometrajeVehiculos);
            this.Controls.Add(this.TxtAñoVehiculos);
            this.Controls.Add(this.TxtPatenteVehiculo);
            this.Controls.Add(this.TxtModeloVehiculos);
            this.Controls.Add(this.TxtMarcaVehiculos);
            this.Controls.Add(this.CbxClienteMeVehiculos);
            this.Controls.Add(this.DgvTablaMeVehiculos);
            this.Controls.Add(this.BtnAgregarMeVehiculos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuVehiculos";
            this.Load += new System.EventHandler(this.MenuVehiculos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaMeVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarMeVehiculos;
        private System.Windows.Forms.DataGridView DgvTablaMeVehiculos;
        private System.Windows.Forms.ComboBox CbxClienteMeVehiculos;
        private System.Windows.Forms.TextBox TxtMarcaVehiculos;
        private System.Windows.Forms.TextBox TxtModeloVehiculos;
        private System.Windows.Forms.TextBox TxtPatenteVehiculo;
        private System.Windows.Forms.TextBox TxtAñoVehiculos;
        private System.Windows.Forms.TextBox TxtKilometrajeVehiculos;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.CheckBox chbEditar;
        private System.Windows.Forms.Button btnBorraCampos;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}