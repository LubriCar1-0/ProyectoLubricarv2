namespace Vista
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TbxContra = new System.Windows.Forms.TextBox();
            this.TbxDocumento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnCerrar.Location = new System.Drawing.Point(472, 416);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(100, 30);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(314, 416);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(100, 30);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TbxContra
            // 
            this.TbxContra.BackColor = System.Drawing.Color.Black;
            this.TbxContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TbxContra.ForeColor = System.Drawing.Color.White;
            this.TbxContra.Location = new System.Drawing.Point(360, 337);
            this.TbxContra.Name = "TbxContra";
            this.TbxContra.Size = new System.Drawing.Size(156, 35);
            this.TbxContra.TabIndex = 2;
            // 
            // TbxDocumento
            // 
            this.TbxDocumento.BackColor = System.Drawing.Color.Black;
            this.TbxDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxDocumento.ForeColor = System.Drawing.Color.White;
            this.TbxDocumento.Location = new System.Drawing.Point(360, 218);
            this.TbxDocumento.Name = "TbxDocumento";
            this.TbxDocumento.Size = new System.Drawing.Size(156, 35);
            this.TbxDocumento.TabIndex = 1;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TbxContra);
            this.Controls.Add(this.TbxDocumento);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TbxContra;
        private System.Windows.Forms.TextBox TbxDocumento;
    }
}

