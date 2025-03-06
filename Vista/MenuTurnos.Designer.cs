namespace Vista
{
    partial class MenuTurnos
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
            this.BtnCrearTurno = new System.Windows.Forms.Button();
            this.BtnTurnosMeTurnos = new System.Windows.Forms.Button();
            this.BtnCancelacionTurno = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrearTurno
            // 
            this.BtnCrearTurno.BackgroundImage = global::lubricar.Properties.Resources.BtnCrearTurno;
            this.BtnCrearTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCrearTurno.FlatAppearance.BorderSize = 0;
            this.BtnCrearTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearTurno.Location = new System.Drawing.Point(815, 228);
            this.BtnCrearTurno.Name = "BtnCrearTurno";
            this.BtnCrearTurno.Size = new System.Drawing.Size(236, 106);
            this.BtnCrearTurno.TabIndex = 2;
            this.BtnCrearTurno.UseVisualStyleBackColor = true;
            this.BtnCrearTurno.Click += new System.EventHandler(this.BtnCrearTurno_Click);
            // 
            // BtnTurnosMeTurnos
            // 
            this.BtnTurnosMeTurnos.BackgroundImage = global::lubricar.Properties.Resources.BtnTurnos;
            this.BtnTurnosMeTurnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTurnosMeTurnos.FlatAppearance.BorderSize = 0;
            this.BtnTurnosMeTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTurnosMeTurnos.Location = new System.Drawing.Point(815, 382);
            this.BtnTurnosMeTurnos.Name = "BtnTurnosMeTurnos";
            this.BtnTurnosMeTurnos.Size = new System.Drawing.Size(236, 103);
            this.BtnTurnosMeTurnos.TabIndex = 3;
            this.BtnTurnosMeTurnos.UseVisualStyleBackColor = true;
            this.BtnTurnosMeTurnos.Click += new System.EventHandler(this.BtnTurnosMeTurnos_Click);
            // 
            // BtnCancelacionTurno
            // 
            this.BtnCancelacionTurno.BackgroundImage = global::lubricar.Properties.Resources.BtnCancelarTurno;
            this.BtnCancelacionTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelacionTurno.FlatAppearance.BorderSize = 0;
            this.BtnCancelacionTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelacionTurno.Location = new System.Drawing.Point(815, 523);
            this.BtnCancelacionTurno.Name = "BtnCancelacionTurno";
            this.BtnCancelacionTurno.Size = new System.Drawing.Size(236, 103);
            this.BtnCancelacionTurno.TabIndex = 4;
            this.BtnCancelacionTurno.UseVisualStyleBackColor = true;
            this.BtnCancelacionTurno.Click += new System.EventHandler(this.BtnCancelacionTurno_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(197, 131);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 5;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // MenuTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.PantallaMenuTurnos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnCancelacionTurno);
            this.Controls.Add(this.BtnTurnosMeTurnos);
            this.Controls.Add(this.BtnCrearTurno);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuTurnos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearTurno;
        private System.Windows.Forms.Button BtnTurnosMeTurnos;
        private System.Windows.Forms.Button BtnCancelacionTurno;
        private System.Windows.Forms.Button BtnVolver;
    }
}