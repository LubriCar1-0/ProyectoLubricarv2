namespace Vista
{
    partial class MenuAgregarProducto
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
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.TxtMarcaProducto = new System.Windows.Forms.TextBox();
            this.TxtCatProd = new System.Windows.Forms.TextBox();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.Location = new System.Drawing.Point(200, 243);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(270, 26);
            this.TxtNombreProducto.TabIndex = 0;
            // 
            // TxtMarcaProducto
            // 
            this.TxtMarcaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarcaProducto.Location = new System.Drawing.Point(682, 243);
            this.TxtMarcaProducto.Name = "TxtMarcaProducto";
            this.TxtMarcaProducto.Size = new System.Drawing.Size(244, 26);
            this.TxtMarcaProducto.TabIndex = 1;
            // 
            // TxtCatProd
            // 
            this.TxtCatProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCatProd.Location = new System.Drawing.Point(200, 318);
            this.TxtCatProd.Name = "TxtCatProd";
            this.TxtCatProd.Size = new System.Drawing.Size(270, 26);
            this.TxtCatProd.TabIndex = 2;
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProducto.Location = new System.Drawing.Point(682, 318);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(244, 26);
            this.TxtCodigoProducto.TabIndex = 3;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(200, 427);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(380, 89);
            this.TxtDescripcion.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Vista.Properties.Resources.BtnAgregar;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(347, 599);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::Vista.Properties.Resources.BtnCancelar;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(762, 599);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(127, 43);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // MenuAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.MenuAgregarProductos;
            this.ClientSize = new System.Drawing.Size(1282, 723);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCodigoProducto);
            this.Controls.Add(this.TxtCatProd);
            this.Controls.Add(this.TxtMarcaProducto);
            this.Controls.Add(this.TxtNombreProducto);
            this.Name = "MenuAgregarProducto";
            this.Text = "MenuAgregarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.TextBox TxtMarcaProducto;
        private System.Windows.Forms.TextBox TxtCatProd;
        private System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}