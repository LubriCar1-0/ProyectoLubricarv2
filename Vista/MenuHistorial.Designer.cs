namespace Vista
{
    partial class MenuHistorial
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
            this.BtnBitacora = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnHistorialVentas
            // 
            this.BtnHistorialVentas.BackgroundImage = global::Vista.Properties.Resources.BtnHistorialVentas;
            this.BtnHistorialVentas.FlatAppearance.BorderSize = 0;
            this.BtnHistorialVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorialVentas.Location = new System.Drawing.Point(819, 202);
            this.BtnHistorialVentas.Name = "BtnHistorialVentas";
            this.BtnHistorialVentas.Size = new System.Drawing.Size(243, 98);
            this.BtnHistorialVentas.TabIndex = 3;
            this.BtnHistorialVentas.UseVisualStyleBackColor = true;
            this.BtnHistorialVentas.Click += new System.EventHandler(this.BtnHistorialVentas_Click);
            // 
            // BtnHistorialTurnos
            // 
            this.BtnHistorialTurnos.BackgroundImage = global::Vista.Properties.Resources.BtnHistorialTurnos;
            this.BtnHistorialTurnos.FlatAppearance.BorderSize = 0;
            this.BtnHistorialTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorialTurnos.Location = new System.Drawing.Point(819, 315);
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
            this.BtnHistorialLubriPuntos.Location = new System.Drawing.Point(819, 433);
            this.BtnHistorialLubriPuntos.Name = "BtnHistorialLubriPuntos";
            this.BtnHistorialLubriPuntos.Size = new System.Drawing.Size(243, 98);
            this.BtnHistorialLubriPuntos.TabIndex = 5;
            this.BtnHistorialLubriPuntos.UseVisualStyleBackColor = true;
            // 
            // BtnBitacora
            // 
            this.BtnBitacora.FlatAppearance.BorderSize = 0;
            this.BtnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBitacora.Image = global::Vista.Properties.Resources.BtnHistorialBitacora2;
            this.BtnBitacora.Location = new System.Drawing.Point(819, 561);
            this.BtnBitacora.Name = "BtnBitacora";
            this.BtnBitacora.Size = new System.Drawing.Size(243, 91);
            this.BtnBitacora.TabIndex = 6;
            this.BtnBitacora.UseVisualStyleBackColor = true;
            this.BtnBitacora.Click += new System.EventHandler(this.BtnBitacora_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(195, 125);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 41;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // MenuHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuHistorial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnBitacora);
            this.Controls.Add(this.BtnHistorialLubriPuntos);
            this.Controls.Add(this.BtnHistorialTurnos);
            this.Controls.Add(this.BtnHistorialVentas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuHistorialcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHistorialVentas;
        private System.Windows.Forms.Button BtnHistorialTurnos;
        private System.Windows.Forms.Button BtnHistorialLubriPuntos;
        private System.Windows.Forms.Button BtnBitacora;
        private System.Windows.Forms.Button BtnVolver;
    }
}