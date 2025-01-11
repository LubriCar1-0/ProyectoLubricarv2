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
            this.BtnAgregarMeVehiculos = new System.Windows.Forms.Button();
            this.BtnEditarMeVehiculos = new System.Windows.Forms.Button();
            this.BtnEliminarMeVehiculos = new System.Windows.Forms.Button();
            this.DgvTablaMeVehiculos = new System.Windows.Forms.DataGridView();
            this.CbxClienteMeVehiculos = new System.Windows.Forms.ComboBox();
            this.TxtMarcaVehiculos = new System.Windows.Forms.TextBox();
            this.TxtModeloVehiculos = new System.Windows.Forms.TextBox();
            this.TxtPatenteVehiculo = new System.Windows.Forms.TextBox();
            this.TxtAñoVehiculos = new System.Windows.Forms.TextBox();
            this.TxtKilometrajeVehiculos = new System.Windows.Forms.TextBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaMeVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregarMeVehiculos
            // 
            this.BtnAgregarMeVehiculos.BackgroundImage = global::Vista.Properties.Resources.BtnAgregar;
            this.BtnAgregarMeVehiculos.FlatAppearance.BorderSize = 0;
            this.BtnAgregarMeVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarMeVehiculos.Location = new System.Drawing.Point(338, 677);
            this.BtnAgregarMeVehiculos.Name = "BtnAgregarMeVehiculos";
            this.BtnAgregarMeVehiculos.Size = new System.Drawing.Size(127, 43);
            this.BtnAgregarMeVehiculos.TabIndex = 4;
            this.BtnAgregarMeVehiculos.UseVisualStyleBackColor = true;
            this.BtnAgregarMeVehiculos.Click += new System.EventHandler(this.BtnAgregarMeVehiculos_Click);
            // 
            // BtnEditarMeVehiculos
            // 
            this.BtnEditarMeVehiculos.BackgroundImage = global::Vista.Properties.Resources.BtnEditar;
            this.BtnEditarMeVehiculos.FlatAppearance.BorderSize = 0;
            this.BtnEditarMeVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarMeVehiculos.Location = new System.Drawing.Point(626, 677);
            this.BtnEditarMeVehiculos.Name = "BtnEditarMeVehiculos";
            this.BtnEditarMeVehiculos.Size = new System.Drawing.Size(95, 43);
            this.BtnEditarMeVehiculos.TabIndex = 5;
            this.BtnEditarMeVehiculos.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarMeVehiculos
            // 
            this.BtnEliminarMeVehiculos.BackgroundImage = global::Vista.Properties.Resources.BtnEliminar;
            this.BtnEliminarMeVehiculos.FlatAppearance.BorderSize = 0;
            this.BtnEliminarMeVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarMeVehiculos.Location = new System.Drawing.Point(834, 677);
            this.BtnEliminarMeVehiculos.Name = "BtnEliminarMeVehiculos";
            this.BtnEliminarMeVehiculos.Size = new System.Drawing.Size(162, 43);
            this.BtnEliminarMeVehiculos.TabIndex = 6;
            this.BtnEliminarMeVehiculos.UseVisualStyleBackColor = true;
            // 
            // DgvTablaMeVehiculos
            // 
            this.DgvTablaMeVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaMeVehiculos.Location = new System.Drawing.Point(282, 521);
            this.DgvTablaMeVehiculos.Name = "DgvTablaMeVehiculos";
            this.DgvTablaMeVehiculos.Size = new System.Drawing.Size(777, 150);
            this.DgvTablaMeVehiculos.TabIndex = 7;
            // 
            // CbxClienteMeVehiculos
            // 
            this.CbxClienteMeVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxClienteMeVehiculos.FormattingEnabled = true;
            this.CbxClienteMeVehiculos.Location = new System.Drawing.Point(305, 282);
            this.CbxClienteMeVehiculos.Name = "CbxClienteMeVehiculos";
            this.CbxClienteMeVehiculos.Size = new System.Drawing.Size(234, 28);
            this.CbxClienteMeVehiculos.TabIndex = 8;
            this.CbxClienteMeVehiculos.SelectedIndexChanged += new System.EventHandler(this.CbxClienteMeVehiculos_SelectedIndexChanged);
            // 
            // TxtMarcaVehiculos
            // 
            this.TxtMarcaVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarcaVehiculos.Location = new System.Drawing.Point(305, 367);
            this.TxtMarcaVehiculos.Name = "TxtMarcaVehiculos";
            this.TxtMarcaVehiculos.Size = new System.Drawing.Size(234, 26);
            this.TxtMarcaVehiculos.TabIndex = 9;
            this.TxtMarcaVehiculos.TextChanged += new System.EventHandler(this.TxtMarcaVehiculos_TextChanged);
            // 
            // TxtModeloVehiculos
            // 
            this.TxtModeloVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtModeloVehiculos.Location = new System.Drawing.Point(782, 282);
            this.TxtModeloVehiculos.Name = "TxtModeloVehiculos";
            this.TxtModeloVehiculos.Size = new System.Drawing.Size(234, 26);
            this.TxtModeloVehiculos.TabIndex = 10;
            // 
            // TxtPatenteVehiculo
            // 
            this.TxtPatenteVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPatenteVehiculo.Location = new System.Drawing.Point(305, 453);
            this.TxtPatenteVehiculo.Name = "TxtPatenteVehiculo";
            this.TxtPatenteVehiculo.Size = new System.Drawing.Size(234, 26);
            this.TxtPatenteVehiculo.TabIndex = 11;
            // 
            // TxtAñoVehiculos
            // 
            this.TxtAñoVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAñoVehiculos.Location = new System.Drawing.Point(782, 367);
            this.TxtAñoVehiculos.Name = "TxtAñoVehiculos";
            this.TxtAñoVehiculos.Size = new System.Drawing.Size(234, 26);
            this.TxtAñoVehiculos.TabIndex = 12;
            // 
            // TxtKilometrajeVehiculos
            // 
            this.TxtKilometrajeVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKilometrajeVehiculos.Location = new System.Drawing.Point(782, 453);
            this.TxtKilometrajeVehiculos.Name = "TxtKilometrajeVehiculos";
            this.TxtKilometrajeVehiculos.Size = new System.Drawing.Size(234, 26);
            this.TxtKilometrajeVehiculos.TabIndex = 13;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(186, 122);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 14;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            // 
            // MenuVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuVehiculos2;
            this.ClientSize = new System.Drawing.Size(1347, 758);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.TxtKilometrajeVehiculos);
            this.Controls.Add(this.TxtAñoVehiculos);
            this.Controls.Add(this.TxtPatenteVehiculo);
            this.Controls.Add(this.TxtModeloVehiculos);
            this.Controls.Add(this.TxtMarcaVehiculos);
            this.Controls.Add(this.CbxClienteMeVehiculos);
            this.Controls.Add(this.DgvTablaMeVehiculos);
            this.Controls.Add(this.BtnEliminarMeVehiculos);
            this.Controls.Add(this.BtnEditarMeVehiculos);
            this.Controls.Add(this.BtnAgregarMeVehiculos);
            this.Name = "MenuVehiculos";
            this.Text = "MenuVehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaMeVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarMeVehiculos;
        private System.Windows.Forms.Button BtnEditarMeVehiculos;
        private System.Windows.Forms.Button BtnEliminarMeVehiculos;
        private System.Windows.Forms.DataGridView DgvTablaMeVehiculos;
        private System.Windows.Forms.ComboBox CbxClienteMeVehiculos;
        private System.Windows.Forms.TextBox TxtMarcaVehiculos;
        private System.Windows.Forms.TextBox TxtModeloVehiculos;
        private System.Windows.Forms.TextBox TxtPatenteVehiculo;
        private System.Windows.Forms.TextBox TxtAñoVehiculos;
        private System.Windows.Forms.TextBox TxtKilometrajeVehiculos;
        private System.Windows.Forms.Button BtnVolver;
    }
}