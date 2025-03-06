namespace Vista
{
    partial class MenuAgregarLubriPu
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TbxCantidadPuntos = new System.Windows.Forms.TextBox();
            this.CmbSelecionarProducto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackgroundImage = global::lubricar.Properties.Resources.BtnAgregar;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(253, 531);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(129, 43);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::lubricar.Properties.Resources.BtnCancelar;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(731, 531);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(129, 43);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // TbxCantidadPuntos
            // 
            this.TbxCantidadPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCantidadPuntos.Location = new System.Drawing.Point(479, 344);
            this.TbxCantidadPuntos.Name = "TbxCantidadPuntos";
            this.TbxCantidadPuntos.Size = new System.Drawing.Size(257, 26);
            this.TbxCantidadPuntos.TabIndex = 9;
            // 
            // CmbSelecionarProducto
            // 
            this.CmbSelecionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSelecionarProducto.FormattingEnabled = true;
            this.CmbSelecionarProducto.Location = new System.Drawing.Point(479, 255);
            this.CmbSelecionarProducto.Name = "CmbSelecionarProducto";
            this.CmbSelecionarProducto.Size = new System.Drawing.Size(257, 28);
            this.CmbSelecionarProducto.TabIndex = 10;
            // 
            // MenuAgregarLubriPu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.PantallaAgregarProductoLubriPu;
            this.ClientSize = new System.Drawing.Size(1143, 638);
            this.Controls.Add(this.CmbSelecionarProducto);
            this.Controls.Add(this.TbxCantidadPuntos);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "MenuAgregarLubriPu";
            this.Text = "MenuAgregarLubriPu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TbxCantidadPuntos;
        private System.Windows.Forms.ComboBox CmbSelecionarProducto;
    }
}