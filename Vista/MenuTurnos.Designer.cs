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
            this.SuspendLayout();
            // 
            // BtnCrearTurno
            // 
            this.BtnCrearTurno.BackgroundImage = global::Vista.Properties.Resources.BtnCrearTurno;
            this.BtnCrearTurno.FlatAppearance.BorderSize = 0;
            this.BtnCrearTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearTurno.Location = new System.Drawing.Point(644, 202);
            this.BtnCrearTurno.Name = "BtnCrearTurno";
            this.BtnCrearTurno.Size = new System.Drawing.Size(243, 98);
            this.BtnCrearTurno.TabIndex = 2;
            this.BtnCrearTurno.UseVisualStyleBackColor = true;
            // 
            // BtnTurnosMeTurnos
            // 
            this.BtnTurnosMeTurnos.BackgroundImage = global::Vista.Properties.Resources.BtnTurnos;
            this.BtnTurnosMeTurnos.FlatAppearance.BorderSize = 0;
            this.BtnTurnosMeTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTurnosMeTurnos.Location = new System.Drawing.Point(644, 306);
            this.BtnTurnosMeTurnos.Name = "BtnTurnosMeTurnos";
            this.BtnTurnosMeTurnos.Size = new System.Drawing.Size(243, 98);
            this.BtnTurnosMeTurnos.TabIndex = 3;
            this.BtnTurnosMeTurnos.UseVisualStyleBackColor = true;
            // 
            // BtnCancelacionTurno
            // 
            this.BtnCancelacionTurno.BackgroundImage = global::Vista.Properties.Resources.BtnCancelarTurno;
            this.BtnCancelacionTurno.FlatAppearance.BorderSize = 0;
            this.BtnCancelacionTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelacionTurno.Location = new System.Drawing.Point(644, 421);
            this.BtnCancelacionTurno.Name = "BtnCancelacionTurno";
            this.BtnCancelacionTurno.Size = new System.Drawing.Size(243, 98);
            this.BtnCancelacionTurno.TabIndex = 4;
            this.BtnCancelacionTurno.UseVisualStyleBackColor = true;
            // 
            // MenuTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuTurnos;
            this.ClientSize = new System.Drawing.Size(1149, 646);
            this.Controls.Add(this.BtnCancelacionTurno);
            this.Controls.Add(this.BtnTurnosMeTurnos);
            this.Controls.Add(this.BtnCrearTurno);
            this.Name = "MenuTurnos";
            this.Text = "MenuTurnos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearTurno;
        private System.Windows.Forms.Button BtnTurnosMeTurnos;
        private System.Windows.Forms.Button BtnCancelacionTurno;
    }
}