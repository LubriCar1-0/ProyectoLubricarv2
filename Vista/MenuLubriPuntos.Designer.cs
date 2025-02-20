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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnValorLP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PtbLubriPuntos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLubriPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            // btnValorLP
            // 
            this.btnValorLP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValorLP.BackgroundImage = global::Vista.Properties.Resources.BtnValoresLubri_Puntos;
            this.btnValorLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValorLP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValorLP.Location = new System.Drawing.Point(605, 179);
            this.btnValorLP.Name = "btnValorLP";
            this.btnValorLP.Size = new System.Drawing.Size(213, 82);
            this.btnValorLP.TabIndex = 2;
            this.btnValorLP.UseVisualStyleBackColor = false;
            this.btnValorLP.Click += new System.EventHandler(this.btnValorLP_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = global::Vista.Properties.Resources.BtnAsignarLubriPuntos;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(605, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 92);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PtbLubriPuntos
            // 
            this.PtbLubriPuntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnValorLP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PtbLubriPuntos);
            this.Name = "MenuLubriPuntos";
            this.Text = "MenuLubriPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.PtbLubriPuntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbLubriPuntos;
        private System.Windows.Forms.Button btnValorLP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}