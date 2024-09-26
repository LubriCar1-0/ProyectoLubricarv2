namespace Vista
{
    partial class MenuVentaProductos
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
            this.TxbNombreDelEmpleado = new System.Windows.Forms.TextBox();
            this.TxbDetalle = new System.Windows.Forms.TextBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.PtbBlanco = new System.Windows.Forms.PictureBox();
            this.PtbMenuVentaProd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbBlanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMenuVentaProd)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbNombreDelEmpleado
            // 
            this.TxbNombreDelEmpleado.Location = new System.Drawing.Point(872, 140);
            this.TxbNombreDelEmpleado.Multiline = true;
            this.TxbNombreDelEmpleado.Name = "TxbNombreDelEmpleado";
            this.TxbNombreDelEmpleado.Size = new System.Drawing.Size(240, 27);
            this.TxbNombreDelEmpleado.TabIndex = 1;
            // 
            // TxbDetalle
            // 
            this.TxbDetalle.Location = new System.Drawing.Point(445, 463);
            this.TxbDetalle.Multiline = true;
            this.TxbDetalle.Name = "TxbDetalle";
            this.TxbDetalle.Size = new System.Drawing.Size(382, 163);
            this.TxbDetalle.TabIndex = 2;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(172, 112);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(65, 45);
            this.BtnVolver.TabIndex = 4;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // PtbBlanco
            // 
            this.PtbBlanco.Image = global::Vista.Properties.Resources.blanco;
            this.PtbBlanco.Location = new System.Drawing.Point(913, 26);
            this.PtbBlanco.Name = "PtbBlanco";
            this.PtbBlanco.Size = new System.Drawing.Size(190, 65);
            this.PtbBlanco.TabIndex = 3;
            this.PtbBlanco.TabStop = false;
            // 
            // PtbMenuVentaProd
            // 
            this.PtbMenuVentaProd.Image = global::Vista.Properties.Resources.MenuVentaDeProductos;
            this.PtbMenuVentaProd.Location = new System.Drawing.Point(-1, -1);
            this.PtbMenuVentaProd.Name = "PtbMenuVentaProd";
            this.PtbMenuVentaProd.Size = new System.Drawing.Size(1244, 730);
            this.PtbMenuVentaProd.TabIndex = 0;
            this.PtbMenuVentaProd.TabStop = false;
            // 
            // MenuVentaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 721);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.PtbBlanco);
            this.Controls.Add(this.TxbDetalle);
            this.Controls.Add(this.TxbNombreDelEmpleado);
            this.Controls.Add(this.PtbMenuVentaProd);
            this.Name = "MenuVentaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuVentaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.PtbBlanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMenuVentaProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbMenuVentaProd;
        private System.Windows.Forms.TextBox TxbNombreDelEmpleado;
        private System.Windows.Forms.TextBox TxbDetalle;
        private System.Windows.Forms.PictureBox PtbBlanco;
        private System.Windows.Forms.Button BtnVolver;
    }
}