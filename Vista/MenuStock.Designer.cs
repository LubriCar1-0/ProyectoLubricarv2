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
            this.BtnControlDeStock = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.PtbMenuStock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMenuStock)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnProductosFaltantes
            // 
            this.BtnProductosFaltantes.FlatAppearance.BorderSize = 0;
            this.BtnProductosFaltantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductosFaltantes.Image = global::Vista.Properties.Resources.BtnProductosFaltantes1;
            this.BtnProductosFaltantes.Location = new System.Drawing.Point(718, 496);
            this.BtnProductosFaltantes.Name = "BtnProductosFaltantes";
            this.BtnProductosFaltantes.Size = new System.Drawing.Size(329, 124);
            this.BtnProductosFaltantes.TabIndex = 3;
            this.BtnProductosFaltantes.Text = "button1";
            this.BtnProductosFaltantes.UseVisualStyleBackColor = true;
            // 
            // BtnControlDeStock
            // 
            this.BtnControlDeStock.FlatAppearance.BorderSize = 0;
            this.BtnControlDeStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnControlDeStock.Image = global::Vista.Properties.Resources.BtnControlStock;
            this.BtnControlDeStock.Location = new System.Drawing.Point(718, 334);
            this.BtnControlDeStock.Name = "BtnControlDeStock";
            this.BtnControlDeStock.Size = new System.Drawing.Size(330, 125);
            this.BtnControlDeStock.TabIndex = 2;
            this.BtnControlDeStock.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Image = global::Vista.Properties.Resources.BtnAgregarProducto1;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(718, 173);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(330, 124);
            this.BtnAgregarProducto.TabIndex = 1;
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // PtbMenuStock
            // 
            this.PtbMenuStock.Image = global::Vista.Properties.Resources.PantMenuStock;
            this.PtbMenuStock.Location = new System.Drawing.Point(12, 12);
            this.PtbMenuStock.Name = "PtbMenuStock";
            this.PtbMenuStock.Size = new System.Drawing.Size(1277, 724);
            this.PtbMenuStock.TabIndex = 0;
            this.PtbMenuStock.TabStop = false;
            // 
            // MenuStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 722);
            this.Controls.Add(this.BtnProductosFaltantes);
            this.Controls.Add(this.BtnControlDeStock);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.PtbMenuStock);
            this.Name = "MenuStock";
            this.Text = "MenuStock";
            ((System.ComponentModel.ISupportInitialize)(this.PtbMenuStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbMenuStock;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnControlDeStock;
        private System.Windows.Forms.Button BtnProductosFaltantes;
    }
}