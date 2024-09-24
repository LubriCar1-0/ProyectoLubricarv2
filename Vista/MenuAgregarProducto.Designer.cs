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
            this.TxtTipoProducto = new System.Windows.Forms.TextBox();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.TxtPrecioDeLista = new System.Windows.Forms.TextBox();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.Location = new System.Drawing.Point(210, 192);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(213, 26);
            this.TxtNombreProducto.TabIndex = 0;
            // 
            // TxtMarcaProducto
            // 
            this.TxtMarcaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarcaProducto.Location = new System.Drawing.Point(612, 192);
            this.TxtMarcaProducto.Name = "TxtMarcaProducto";
            this.TxtMarcaProducto.Size = new System.Drawing.Size(213, 26);
            this.TxtMarcaProducto.TabIndex = 1;
            // 
            // TxtTipoProducto
            // 
            this.TxtTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoProducto.Location = new System.Drawing.Point(210, 274);
            this.TxtTipoProducto.Name = "TxtTipoProducto";
            this.TxtTipoProducto.Size = new System.Drawing.Size(213, 26);
            this.TxtTipoProducto.TabIndex = 2;
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProducto.Location = new System.Drawing.Point(612, 274);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(213, 26);
            this.TxtCodigoProducto.TabIndex = 3;
            // 
            // TxtPrecioDeLista
            // 
            this.TxtPrecioDeLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioDeLista.Location = new System.Drawing.Point(210, 350);
            this.TxtPrecioDeLista.Name = "TxtPrecioDeLista";
            this.TxtPrecioDeLista.Size = new System.Drawing.Size(213, 26);
            this.TxtPrecioDeLista.TabIndex = 4;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioVenta.Location = new System.Drawing.Point(612, 361);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(213, 26);
            this.TxtPrecioVenta.TabIndex = 5;
            // 
            // MenuAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaAgregarProducto;
            this.ClientSize = new System.Drawing.Size(1173, 644);
            this.Controls.Add(this.TxtPrecioVenta);
            this.Controls.Add(this.TxtPrecioDeLista);
            this.Controls.Add(this.TxtCodigoProducto);
            this.Controls.Add(this.TxtTipoProducto);
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
        private System.Windows.Forms.TextBox TxtTipoProducto;
        private System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.TextBox TxtPrecioDeLista;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
    }
}