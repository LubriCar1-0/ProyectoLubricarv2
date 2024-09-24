namespace Vista
{
    partial class MenuProductosFaltantes
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
            this.DgvProductoFaltantes = new System.Windows.Forms.DataGridView();
            this.BtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductoFaltantes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProductoFaltantes
            // 
            this.DgvProductoFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductoFaltantes.Location = new System.Drawing.Point(169, 113);
            this.DgvProductoFaltantes.Name = "DgvProductoFaltantes";
            this.DgvProductoFaltantes.Size = new System.Drawing.Size(673, 509);
            this.DgvProductoFaltantes.TabIndex = 0;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackgroundImage = global::Vista.Properties.Resources.BtnVolver1;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Location = new System.Drawing.Point(878, 539);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(97, 43);
            this.BtnVolver.TabIndex = 3;
            this.BtnVolver.UseVisualStyleBackColor = true;
            // 
            // MenuProductosFaltantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaProductoFaltantes2;
            this.ClientSize = new System.Drawing.Size(1147, 647);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.DgvProductoFaltantes);
            this.Name = "MenuProductosFaltantes";
            this.Text = "MenuProductosFaltantes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductoFaltantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProductoFaltantes;
        private System.Windows.Forms.Button BtnVolver;
    }
}