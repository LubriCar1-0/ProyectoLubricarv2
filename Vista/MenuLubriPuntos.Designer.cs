namespace Vista
{
    partial class MenuLubriPuntos
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
            this.btnValorLP = new System.Windows.Forms.Button();
            this.btnAsignacionLP = new System.Windows.Forms.Button();
            this.BtnCanjeoLP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValorLP
            // 
            this.btnValorLP.AutoSize = true;
            this.btnValorLP.BackgroundImage = global::lubricar.Properties.Resources.BtnValoresLubri_Puntos;
            this.btnValorLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValorLP.FlatAppearance.BorderSize = 0;
            this.btnValorLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValorLP.Location = new System.Drawing.Point(794, 225);
            this.btnValorLP.Name = "btnValorLP";
            this.btnValorLP.Size = new System.Drawing.Size(268, 112);
            this.btnValorLP.TabIndex = 5;
            this.btnValorLP.UseVisualStyleBackColor = true;
            this.btnValorLP.Click += new System.EventHandler(this.btnValorLP_Click);
            // 
            // btnAsignacionLP
            // 
            this.btnAsignacionLP.AutoSize = true;
            this.btnAsignacionLP.BackgroundImage = global::lubricar.Properties.Resources.BtnAsignarLubriPuntos;
            this.btnAsignacionLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsignacionLP.FlatAppearance.BorderSize = 0;
            this.btnAsignacionLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignacionLP.Location = new System.Drawing.Point(794, 354);
            this.btnAsignacionLP.Name = "btnAsignacionLP";
            this.btnAsignacionLP.Size = new System.Drawing.Size(268, 112);
            this.btnAsignacionLP.TabIndex = 6;
            this.btnAsignacionLP.UseVisualStyleBackColor = true;
            this.btnAsignacionLP.Click += new System.EventHandler(this.btnAsignacionLP_Click);
            // 
            // BtnCanjeoLP
            // 
            this.BtnCanjeoLP.AutoSize = true;
            this.BtnCanjeoLP.BackgroundImage = global::lubricar.Properties.Resources.BtncanjeoLubriPuntos;
            this.BtnCanjeoLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCanjeoLP.FlatAppearance.BorderSize = 0;
            this.BtnCanjeoLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCanjeoLP.Location = new System.Drawing.Point(794, 490);
            this.BtnCanjeoLP.Name = "BtnCanjeoLP";
            this.BtnCanjeoLP.Size = new System.Drawing.Size(268, 112);
            this.BtnCanjeoLP.TabIndex = 7;
            this.BtnCanjeoLP.UseVisualStyleBackColor = true;
            this.BtnCanjeoLP.Click += new System.EventHandler(this.BtnCanjeoLP_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(241, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 57);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuLubriPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.MenuLubri_Puntos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCanjeoLP);
            this.Controls.Add(this.btnAsignacionLP);
            this.Controls.Add(this.btnValorLP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuLubriPuntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuLubriPuntos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnValorLP;
        private System.Windows.Forms.Button btnAsignacionLP;
        private System.Windows.Forms.Button BtnCanjeoLP;
        private System.Windows.Forms.Button button1;
    }
}