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
            this.btnABMCategoriasProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProductosFaltantes
            // 
            this.BtnProductosFaltantes.AutoSize = true;
            this.BtnProductosFaltantes.BackgroundImage = global::lubricar.Properties.Resources.BtnProductosFaltantes;
            this.BtnProductosFaltantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProductosFaltantes.FlatAppearance.BorderSize = 0;
            this.BtnProductosFaltantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductosFaltantes.Location = new System.Drawing.Point(931, 429);
            this.BtnProductosFaltantes.Name = "BtnProductosFaltantes";
            this.BtnProductosFaltantes.Size = new System.Drawing.Size(243, 110);
            this.BtnProductosFaltantes.TabIndex = 5;
            this.BtnProductosFaltantes.UseVisualStyleBackColor = true;
            this.BtnProductosFaltantes.Click += new System.EventHandler(this.BtnProductosFaltantes_Click);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.AutoSize = true;
            this.BtnAgregarProducto.BackgroundImage = global::lubricar.Properties.Resources.BtnAgregarProducto;
            this.BtnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(650, 277);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(243, 110);
            this.BtnAgregarProducto.TabIndex = 6;
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnControlDeStock
            // 
            this.BtnControlDeStock.AutoSize = true;
            this.BtnControlDeStock.BackgroundImage = global::lubricar.Properties.Resources.BtnControlStock;
            this.BtnControlDeStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnControlDeStock.FlatAppearance.BorderSize = 0;
            this.BtnControlDeStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnControlDeStock.Location = new System.Drawing.Point(650, 429);
            this.BtnControlDeStock.Name = "BtnControlDeStock";
            this.BtnControlDeStock.Size = new System.Drawing.Size(243, 110);
            this.BtnControlDeStock.TabIndex = 7;
            this.BtnControlDeStock.UseVisualStyleBackColor = true;
            this.BtnControlDeStock.Click += new System.EventHandler(this.BtnControlDeStock_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(218, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 57);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnABMCategoriasProductos
            // 
            this.btnABMCategoriasProductos.BackgroundImage = global::lubricar.Properties.Resources.BTNAgregarCategorias;
            this.btnABMCategoriasProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnABMCategoriasProductos.FlatAppearance.BorderSize = 0;
            this.btnABMCategoriasProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMCategoriasProductos.Location = new System.Drawing.Point(931, 276);
            this.btnABMCategoriasProductos.Name = "btnABMCategoriasProductos";
            this.btnABMCategoriasProductos.Size = new System.Drawing.Size(242, 111);
            this.btnABMCategoriasProductos.TabIndex = 16;
            this.btnABMCategoriasProductos.UseVisualStyleBackColor = true;
            this.btnABMCategoriasProductos.Click += new System.EventHandler(this.btnABMCategoriasProductos_Click);
            // 
            // MenuStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.PantallaMenuStock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnABMCategoriasProductos);
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
            this.Load += new System.EventHandler(this.MenuStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProductosFaltantes;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnControlDeStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnABMCategoriasProductos;
    }
}