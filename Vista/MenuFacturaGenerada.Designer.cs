namespace Vista
{
    partial class MenuFacturaGenerada
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
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackgroundImage = global::lubricar.Properties.Resources.BtnImprimir;
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Location = new System.Drawing.Point(741, 272);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(164, 43);
            this.BtnImprimir.TabIndex = 8;
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackgroundImage = global::lubricar.Properties.Resources.BtnVolver1;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Location = new System.Drawing.Point(776, 340);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(94, 43);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.UseVisualStyleBackColor = true;
            // 
            // MenuFacturaGenerada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.PantallaFacturaGenerada;
            this.ClientSize = new System.Drawing.Size(1138, 639);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnImprimir);
            this.Name = "MenuFacturaGenerada";
            this.Text = "MenuFacturaGenerada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnVolver;
    }
}