namespace Vista
{
    partial class MenuVentas
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
            this.BtnClientesMeVentas = new System.Windows.Forms.Button();
            this.BtnVentasMeVentas = new System.Windows.Forms.Button();
            this.BtnVehiculosMeVentas = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClientesMeVentas
            // 
            this.BtnClientesMeVentas.BackgroundImage = global::Vista.Properties.Resources.BtnClientes;
            this.BtnClientesMeVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnClientesMeVentas.FlatAppearance.BorderSize = 0;
            this.BtnClientesMeVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnClientesMeVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnClientesMeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientesMeVentas.Location = new System.Drawing.Point(744, 297);
            this.BtnClientesMeVentas.Name = "BtnClientesMeVentas";
            this.BtnClientesMeVentas.Size = new System.Drawing.Size(246, 98);
            this.BtnClientesMeVentas.TabIndex = 0;
            this.BtnClientesMeVentas.UseVisualStyleBackColor = true;
            this.BtnClientesMeVentas.Click += new System.EventHandler(this.BtnClientesMeVentas_Click);
            // 
            // BtnVentasMeVentas
            // 
            this.BtnVentasMeVentas.BackgroundImage = global::Vista.Properties.Resources.BtnVentas;
            this.BtnVentasMeVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentasMeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentasMeVentas.Location = new System.Drawing.Point(744, 178);
            this.BtnVentasMeVentas.Name = "BtnVentasMeVentas";
            this.BtnVentasMeVentas.Size = new System.Drawing.Size(242, 98);
            this.BtnVentasMeVentas.TabIndex = 1;
            this.BtnVentasMeVentas.UseVisualStyleBackColor = true;
            this.BtnVentasMeVentas.Click += new System.EventHandler(this.BtnVentasMeVentas_Click);
            // 
            // BtnVehiculosMeVentas
            // 
            this.BtnVehiculosMeVentas.BackgroundImage = global::Vista.Properties.Resources.BtnVehiculos;
            this.BtnVehiculosMeVentas.FlatAppearance.BorderSize = 0;
            this.BtnVehiculosMeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVehiculosMeVentas.Location = new System.Drawing.Point(740, 420);
            this.BtnVehiculosMeVentas.Name = "BtnVehiculosMeVentas";
            this.BtnVehiculosMeVentas.Size = new System.Drawing.Size(246, 98);
            this.BtnVehiculosMeVentas.TabIndex = 2;
            this.BtnVehiculosMeVentas.UseVisualStyleBackColor = true;
            this.BtnVehiculosMeVentas.Click += new System.EventHandler(this.BtnVehiculosMeVentas_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(212, 115);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 47);
            this.BtnVolver.TabIndex = 3;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuVentas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnVehiculosMeVentas);
            this.Controls.Add(this.BtnVentasMeVentas);
            this.Controls.Add(this.BtnClientesMeVentas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuVentas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClientesMeVentas;
        private System.Windows.Forms.Button BtnVentasMeVentas;
        private System.Windows.Forms.Button BtnVehiculosMeVentas;
        private System.Windows.Forms.Button BtnVolver;
    }
}