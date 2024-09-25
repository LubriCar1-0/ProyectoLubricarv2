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
            this.PtbLubriPuntos = new System.Windows.Forms.PictureBox();
            this.BtnAgregarProductos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLubriPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbLubriPuntos
            // 
            this.PtbLubriPuntos.Image = global::Vista.Properties.Resources.MenuLubri_Punts;
            this.PtbLubriPuntos.Location = new System.Drawing.Point(1, 0);
            this.PtbLubriPuntos.Name = "PtbLubriPuntos";
            this.PtbLubriPuntos.Size = new System.Drawing.Size(1189, 671);
            this.PtbLubriPuntos.TabIndex = 0;
            this.PtbLubriPuntos.TabStop = false;
            // 
            // BtnAgregarProductos
            // 
            this.BtnAgregarProductos.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProductos.Image = global::Vista.Properties.Resources.BtnAgregarProductos;
            this.BtnAgregarProductos.Location = new System.Drawing.Point(253, 572);
            this.BtnAgregarProductos.Name = "BtnAgregarProductos";
            this.BtnAgregarProductos.Size = new System.Drawing.Size(245, 43);
            this.BtnAgregarProductos.TabIndex = 1;
            this.BtnAgregarProductos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Vista.Properties.Resources.BtnCanjear;
            this.button1.Location = new System.Drawing.Point(678, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 43);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuLubriPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 670);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAgregarProductos);
            this.Controls.Add(this.PtbLubriPuntos);
            this.Name = "MenuLubriPuntos";
            this.Text = "MenuLubriPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.PtbLubriPuntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbLubriPuntos;
        private System.Windows.Forms.Button BtnAgregarProductos;
        private System.Windows.Forms.Button button1;
    }
}