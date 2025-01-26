namespace Vista
{
    partial class MenuStock
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
            this.BtnProductosFaltantes = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnControlDeStock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProductosFaltantes
            // 
            this.BtnProductosFaltantes.AutoSize = true;
            this.BtnProductosFaltantes.BackgroundImage = global::Vista.Properties.Resources.BtnProductosFaltantes;
            this.BtnProductosFaltantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProductosFaltantes.FlatAppearance.BorderSize = 0;
            this.BtnProductosFaltantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductosFaltantes.Location = new System.Drawing.Point(1107, 722);
            this.BtnProductosFaltantes.Name = "BtnProductosFaltantes";
            this.BtnProductosFaltantes.Size = new System.Drawing.Size(346, 164);
            this.BtnProductosFaltantes.TabIndex = 5;
            this.BtnProductosFaltantes.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.AutoSize = true;
            this.BtnAgregarProducto.BackgroundImage = global::Vista.Properties.Resources.BtnAgregarProducto;
            this.BtnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(1107, 244);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(346, 164);
            this.BtnAgregarProducto.TabIndex = 6;
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnControlDeStock
            // 
            this.BtnControlDeStock.AutoSize = true;
            this.BtnControlDeStock.BackgroundImage = global::Vista.Properties.Resources.BtnControlDeStock;
            this.BtnControlDeStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnControlDeStock.FlatAppearance.BorderSize = 0;
            this.BtnControlDeStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnControlDeStock.Location = new System.Drawing.Point(1107, 477);
            this.BtnControlDeStock.Name = "BtnControlDeStock";
            this.BtnControlDeStock.Size = new System.Drawing.Size(346, 164);
            this.BtnControlDeStock.TabIndex = 7;
            this.BtnControlDeStock.UseVisualStyleBackColor = true;
            this.BtnControlDeStock.Click += new System.EventHandler(this.BtnControlDeStock_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(313, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 57);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuStock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnControlDeStock);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.BtnProductosFaltantes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuStock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProductosFaltantes;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnControlDeStock;
        private System.Windows.Forms.Button button1;
    }
}