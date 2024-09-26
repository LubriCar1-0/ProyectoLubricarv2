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
            this.CbxCondicionIvaMeClientes = new System.Windows.Forms.ComboBox();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.TxtDomicilioCliente = new System.Windows.Forms.TextBox();
            this.TxtCuilCliente = new System.Windows.Forms.TextBox();
            this.DgvTablaClientes = new System.Windows.Forms.DataGridView();
            this.BtnEliminarMeClientes = new System.Windows.Forms.Button();
            this.BtnEditarMeClientes = new System.Windows.Forms.Button();
            this.BtnAgregarMeClientes = new System.Windows.Forms.Button();
            this.BtnVehiculoMeCliente = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxCondicionIvaMeClientes
            // 
            this.CbxCondicionIvaMeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCondicionIvaMeClientes.FormattingEnabled = true;
            this.CbxCondicionIvaMeClientes.Location = new System.Drawing.Point(623, 291);
            this.CbxCondicionIvaMeClientes.Name = "CbxCondicionIvaMeClientes";
            this.CbxCondicionIvaMeClientes.Size = new System.Drawing.Size(234, 28);
            this.CbxCondicionIvaMeClientes.TabIndex = 0;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(202, 210);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtNombreCliente.TabIndex = 1;
            // 
            // TxtDomicilioCliente
            // 
            this.TxtDomicilioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDomicilioCliente.Location = new System.Drawing.Point(202, 292);
            this.TxtDomicilioCliente.Name = "TxtDomicilioCliente";
            this.TxtDomicilioCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtDomicilioCliente.TabIndex = 2;
            // 
            // TxtCuilCliente
            // 
            this.TxtCuilCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuilCliente.Location = new System.Drawing.Point(623, 210);
            this.TxtCuilCliente.Name = "TxtCuilCliente";
            this.TxtCuilCliente.Size = new System.Drawing.Size(234, 26);
            this.TxtCuilCliente.TabIndex = 3;
            // 
            // DgvTablaClientes
            // 
            this.DgvTablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaClientes.Location = new System.Drawing.Point(202, 344);
            this.DgvTablaClientes.Name = "DgvTablaClientes";
            this.DgvTablaClientes.Size = new System.Drawing.Size(788, 205);
            this.DgvTablaClientes.TabIndex = 4;
            // 
            // BtnEliminarMeClientes
            // 
            this.BtnEliminarMeClientes.BackgroundImage = global::Vista.Properties.Resources.BtnEliminar;
            this.BtnEliminarMeClientes.FlatAppearance.BorderSize = 0;
            this.BtnEliminarMeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarMeClientes.Location = new System.Drawing.Point(600, 571);
            this.BtnEliminarMeClientes.Name = "BtnEliminarMeClientes";
            this.BtnEliminarMeClientes.Size = new System.Drawing.Size(171, 43);
            this.BtnEliminarMeClientes.TabIndex = 5;
            this.BtnEliminarMeClientes.UseVisualStyleBackColor = true;
            // 
            // BtnEditarMeClientes
            // 
            this.BtnEditarMeClientes.BackgroundImage = global::Vista.Properties.Resources.BtnEditar;
            this.BtnEditarMeClientes.FlatAppearance.BorderSize = 0;
            this.BtnEditarMeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarMeClientes.Location = new System.Drawing.Point(426, 571);
            this.BtnEditarMeClientes.Name = "BtnEditarMeClientes";
            this.BtnEditarMeClientes.Size = new System.Drawing.Size(93, 43);
            this.BtnEditarMeClientes.TabIndex = 6;
            this.BtnEditarMeClientes.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarMeClientes
            // 
            this.BtnAgregarMeClientes.BackgroundImage = global::Vista.Properties.Resources.BtnAgregar;
            this.BtnAgregarMeClientes.FlatAppearance.BorderSize = 0;
            this.BtnAgregarMeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarMeClientes.Location = new System.Drawing.Point(230, 571);
            this.BtnAgregarMeClientes.Name = "BtnAgregarMeClientes";
            this.BtnAgregarMeClientes.Size = new System.Drawing.Size(123, 43);
            this.BtnAgregarMeClientes.TabIndex = 7;
            this.BtnAgregarMeClientes.UseVisualStyleBackColor = true;
            // 
            // BtnVehiculoMeCliente
            // 
            this.BtnVehiculoMeCliente.BackgroundImage = global::Vista.Properties.Resources.BtnVehiculo;
            this.BtnVehiculoMeCliente.FlatAppearance.BorderSize = 0;
            this.BtnVehiculoMeCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVehiculoMeCliente.Location = new System.Drawing.Point(833, 571);
            this.BtnVehiculoMeCliente.Name = "BtnVehiculoMeCliente";
            this.BtnVehiculoMeCliente.Size = new System.Drawing.Size(128, 43);
            this.BtnVehiculoMeCliente.TabIndex = 8;
            this.BtnVehiculoMeCliente.UseVisualStyleBackColor = true;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(178, 107);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(72, 49);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuClientes;
            this.ClientSize = new System.Drawing.Size(1173, 670);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnVehiculoMeCliente);
            this.Controls.Add(this.BtnAgregarMeClientes);
            this.Controls.Add(this.BtnEditarMeClientes);
            this.Controls.Add(this.BtnEliminarMeClientes);
            this.Controls.Add(this.DgvTablaClientes);
            this.Controls.Add(this.TxtCuilCliente);
            this.Controls.Add(this.TxtDomicilioCliente);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.CbxCondicionIvaMeClientes);
            this.Name = "MenuClientes";
            this.Text = "MenuClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxCondicionIvaMeClientes;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.TextBox TxtDomicilioCliente;
        private System.Windows.Forms.TextBox TxtCuilCliente;
        private System.Windows.Forms.DataGridView DgvTablaClientes;
        private System.Windows.Forms.Button BtnEliminarMeClientes;
        private System.Windows.Forms.Button BtnEditarMeClientes;
        private System.Windows.Forms.Button BtnAgregarMeClientes;
        private System.Windows.Forms.Button BtnVehiculoMeCliente;
        private System.Windows.Forms.Button BtnVolver;
    }
}