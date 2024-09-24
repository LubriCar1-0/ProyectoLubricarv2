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
            this.SuspendLayout();
            // 
            // BtnClientesMeVentas
            // 
            this.BtnClientesMeVentas.BackgroundImage = global::Vista.Properties.Resources.BtnClientes;
            this.BtnClientesMeVentas.FlatAppearance.BorderSize = 0;
            this.BtnClientesMeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientesMeVentas.Location = new System.Drawing.Point(682, 200);
            this.BtnClientesMeVentas.Name = "BtnClientesMeVentas";
            this.BtnClientesMeVentas.Size = new System.Drawing.Size(246, 98);
            this.BtnClientesMeVentas.TabIndex = 0;
            this.BtnClientesMeVentas.UseVisualStyleBackColor = true;
            // 
            // BtnVentasMeVentas
            // 
            this.BtnVentasMeVentas.BackgroundImage = global::Vista.Properties.Resources.BtnVentas;
            this.BtnVentasMeVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentasMeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentasMeVentas.Location = new System.Drawing.Point(682, 321);
            this.BtnVentasMeVentas.Name = "BtnVentasMeVentas";
            this.BtnVentasMeVentas.Size = new System.Drawing.Size(246, 98);
            this.BtnVentasMeVentas.TabIndex = 1;
            this.BtnVentasMeVentas.UseVisualStyleBackColor = true;
            // 
            // BtnVehiculosMeVentas
            // 
            this.BtnVehiculosMeVentas.BackgroundImage = global::Vista.Properties.Resources.BtnVehiculos;
            this.BtnVehiculosMeVentas.FlatAppearance.BorderSize = 0;
            this.BtnVehiculosMeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVehiculosMeVentas.Location = new System.Drawing.Point(682, 425);
            this.BtnVehiculosMeVentas.Name = "BtnVehiculosMeVentas";
            this.BtnVehiculosMeVentas.Size = new System.Drawing.Size(246, 98);
            this.BtnVehiculosMeVentas.TabIndex = 2;
            this.BtnVehiculosMeVentas.UseVisualStyleBackColor = true;
            // 
            // MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuVentas;
            this.ClientSize = new System.Drawing.Size(1151, 653);
            this.Controls.Add(this.BtnVehiculosMeVentas);
            this.Controls.Add(this.BtnVentasMeVentas);
            this.Controls.Add(this.BtnClientesMeVentas);
            this.Name = "MenuVentas";
            this.Text = "MenuVentas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClientesMeVentas;
        private System.Windows.Forms.Button BtnVentasMeVentas;
        private System.Windows.Forms.Button BtnVehiculosMeVentas;
    }
}