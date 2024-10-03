namespace Vista
{
    partial class MenuControlDeStock
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.DgvControlDeStock = new System.Windows.Forms.DataGridView();
            this.txbPrecioVent = new System.Windows.Forms.TextBox();
            this.txbPrecioList = new System.Windows.Forms.TextBox();
            this.txbCant = new System.Windows.Forms.TextBox();
            this.txbCantMinima = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvControlDeStock)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::Vista.Properties.Resources.BtnCancelar;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(388, 615);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(127, 43);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = global::Vista.Properties.Resources.BtnConfirmar;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(797, 615);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(168, 43);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // DgvControlDeStock
            // 
            this.DgvControlDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvControlDeStock.Location = new System.Drawing.Point(188, 187);
            this.DgvControlDeStock.Name = "DgvControlDeStock";
            this.DgvControlDeStock.Size = new System.Drawing.Size(473, 376);
            this.DgvControlDeStock.TabIndex = 6;
            // 
            // txbPrecioVent
            // 
            this.txbPrecioVent.Location = new System.Drawing.Point(677, 337);
            this.txbPrecioVent.Multiline = true;
            this.txbPrecioVent.Name = "txbPrecioVent";
            this.txbPrecioVent.Size = new System.Drawing.Size(195, 33);
            this.txbPrecioVent.TabIndex = 7;
            // 
            // txbPrecioList
            // 
            this.txbPrecioList.Location = new System.Drawing.Point(908, 337);
            this.txbPrecioList.Multiline = true;
            this.txbPrecioList.Name = "txbPrecioList";
            this.txbPrecioList.Size = new System.Drawing.Size(195, 33);
            this.txbPrecioList.TabIndex = 8;
            // 
            // txbCant
            // 
            this.txbCant.Location = new System.Drawing.Point(677, 440);
            this.txbCant.Multiline = true;
            this.txbCant.Name = "txbCant";
            this.txbCant.Size = new System.Drawing.Size(195, 33);
            this.txbCant.TabIndex = 9;
            // 
            // txbCantMinima
            // 
            this.txbCantMinima.Location = new System.Drawing.Point(908, 440);
            this.txbCantMinima.Multiline = true;
            this.txbCantMinima.Name = "txbCantMinima";
            this.txbCantMinima.Size = new System.Drawing.Size(195, 33);
            this.txbCantMinima.TabIndex = 10;
            // 
            // MenuControlDeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.MenuControlDeStock;
            this.ClientSize = new System.Drawing.Size(1145, 722);
            this.Controls.Add(this.txbCantMinima);
            this.Controls.Add(this.txbCant);
            this.Controls.Add(this.txbPrecioList);
            this.Controls.Add(this.txbPrecioVent);
            this.Controls.Add(this.DgvControlDeStock);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.BtnCancelar);
            this.Name = "MenuControlDeStock";
            this.Text = "MenuControlDeStock";
            ((System.ComponentModel.ISupportInitialize)(this.DgvControlDeStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView DgvControlDeStock;
        private System.Windows.Forms.TextBox txbPrecioVent;
        private System.Windows.Forms.TextBox txbPrecioList;
        private System.Windows.Forms.TextBox txbCant;
        private System.Windows.Forms.TextBox txbCantMinima;
    }
}