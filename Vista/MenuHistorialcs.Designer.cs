namespace Vista
{
    partial class MenuHistorialcs
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
            this.BtnHistorialVentas = new System.Windows.Forms.Button();
            this.BtnHistorialTurnos = new System.Windows.Forms.Button();
            this.BtnHistorialLubriPuntos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnHistorialVentas
            // 
            this.BtnHistorialVentas.BackgroundImage = global::Vista.Properties.Resources.BtnHistorialVentas;
            this.BtnHistorialVentas.FlatAppearance.BorderSize = 0;
            this.BtnHistorialVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorialVentas.Location = new System.Drawing.Point(689, 193);
            this.BtnHistorialVentas.Name = "BtnHistorialVentas";
            this.BtnHistorialVentas.Size = new System.Drawing.Size(243, 98);
            this.BtnHistorialVentas.TabIndex = 3;
            this.BtnHistorialVentas.UseVisualStyleBackColor = true;
            // 
            // BtnHistorialTurnos
            // 
            this.BtnHistorialTurnos.BackgroundImage = global::Vista.Properties.Resources.BtnHistorialTurnos;
            this.BtnHistorialTurnos.FlatAppearance.BorderSize = 0;
            this.BtnHistorialTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorialTurnos.Location = new System.Drawing.Point(689, 308);
            this.BtnHistorialTurnos.Name = "BtnHistorialTurnos";
            this.BtnHistorialTurnos.Size = new System.Drawing.Size(243, 98);
            this.BtnHistorialTurnos.TabIndex = 4;
            this.BtnHistorialTurnos.UseVisualStyleBackColor = true;
            // 
            // BtnHistorialLubriPuntos
            // 
            this.BtnHistorialLubriPuntos.BackgroundImage = global::Vista.Properties.Resources.BtnHistorialLubriPuntos;
            this.BtnHistorialLubriPuntos.FlatAppearance.BorderSize = 0;
            this.BtnHistorialLubriPuntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorialLubriPuntos.Location = new System.Drawing.Point(689, 432);
            this.BtnHistorialLubriPuntos.Name = "BtnHistorialLubriPuntos";
            this.BtnHistorialLubriPuntos.Size = new System.Drawing.Size(243, 98);
            this.BtnHistorialLubriPuntos.TabIndex = 5;
            this.BtnHistorialLubriPuntos.UseVisualStyleBackColor = true;
            // 
            // MenuHistorialcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuHistorial;
            this.ClientSize = new System.Drawing.Size(1151, 642);
            this.Controls.Add(this.BtnHistorialLubriPuntos);
            this.Controls.Add(this.BtnHistorialTurnos);
            this.Controls.Add(this.BtnHistorialVentas);
            this.Name = "MenuHistorialcs";
            this.Text = "MenuHistorialcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHistorialVentas;
        private System.Windows.Forms.Button BtnHistorialTurnos;
        private System.Windows.Forms.Button BtnHistorialLubriPuntos;
    }
}