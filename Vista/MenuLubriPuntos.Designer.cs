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
            this.button4 = new System.Windows.Forms.Button();
            this.BtnCanjeoLP = new System.Windows.Forms.Button();
            this.btnValorLP = new System.Windows.Forms.Button();
            this.btnAsignacionLP = new System.Windows.Forms.Button();
            this.PtbLubriPuntos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLubriPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button4.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(192, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 67);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // BtnCanjeoLP
            // 
            this.BtnCanjeoLP.BackColor = System.Drawing.Color.Black;
            this.BtnCanjeoLP.BackgroundImage = global::Vista.Properties.Resources.BtncanjeoLubriPuntos;
            this.BtnCanjeoLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCanjeoLP.Location = new System.Drawing.Point(605, 423);
            this.BtnCanjeoLP.Name = "BtnCanjeoLP";
            this.BtnCanjeoLP.Size = new System.Drawing.Size(213, 92);
            this.BtnCanjeoLP.TabIndex = 3;
            this.BtnCanjeoLP.UseVisualStyleBackColor = false;
            this.BtnCanjeoLP.Click += new System.EventHandler(this.BtnCanjeoLP_Click);
            // 
            // btnValorLP
            // 
            this.btnValorLP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValorLP.BackgroundImage = global::Vista.Properties.Resources.BtnValoresLubri_Puntos;
            this.btnValorLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValorLP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValorLP.Location = new System.Drawing.Point(605, 169);
            this.btnValorLP.Name = "btnValorLP";
            this.btnValorLP.Size = new System.Drawing.Size(213, 92);
            this.btnValorLP.TabIndex = 2;
            this.btnValorLP.UseVisualStyleBackColor = false;
            this.btnValorLP.Click += new System.EventHandler(this.btnValorLP_Click);
            // 
            // btnAsignacionLP
            // 
            this.btnAsignacionLP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAsignacionLP.BackgroundImage = global::Vista.Properties.Resources.BtnAsignarLubriPuntos;
            this.btnAsignacionLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsignacionLP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignacionLP.Location = new System.Drawing.Point(605, 301);
            this.btnAsignacionLP.Name = "btnAsignacionLP";
            this.btnAsignacionLP.Size = new System.Drawing.Size(213, 92);
            this.btnAsignacionLP.TabIndex = 1;
            this.btnAsignacionLP.UseVisualStyleBackColor = false;
            this.btnAsignacionLP.Click += new System.EventHandler(this.btnAsignacionLP_Click_1);
            // 
            // PtbLubriPuntos
            // 
            this.PtbLubriPuntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PtbLubriPuntos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PtbLubriPuntos.Image = global::Vista.Properties.Resources.MenuLubri_Puntos;
            this.PtbLubriPuntos.Location = new System.Drawing.Point(1, 0);
            this.PtbLubriPuntos.Name = "PtbLubriPuntos";
            this.PtbLubriPuntos.Size = new System.Drawing.Size(1005, 566);
            this.PtbLubriPuntos.TabIndex = 0;
            this.PtbLubriPuntos.TabStop = false;
            this.PtbLubriPuntos.Click += new System.EventHandler(this.PtbLubriPuntos_Click);
            // 
            // MenuLubriPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 567);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnCanjeoLP);
            this.Controls.Add(this.btnValorLP);
            this.Controls.Add(this.btnAsignacionLP);
            this.Controls.Add(this.PtbLubriPuntos);
            this.Name = "MenuLubriPuntos";
            this.Text = "MenuLubriPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.PtbLubriPuntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbLubriPuntos;
        private System.Windows.Forms.Button btnValorLP;
        private System.Windows.Forms.Button BtnCanjeoLP;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAsignacionLP;
    }
}