namespace Vista
{
    partial class BtnCanjear
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
            this.DgvServiPuntos = new System.Windows.Forms.DataGridView();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvServiPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvServiPuntos
            // 
            this.DgvServiPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvServiPuntos.Location = new System.Drawing.Point(181, 151);
            this.DgvServiPuntos.Name = "DgvServiPuntos";
            this.DgvServiPuntos.Size = new System.Drawing.Size(815, 356);
            this.DgvServiPuntos.TabIndex = 0;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackgroundImage = global::Vista.Properties.Resources.BtnAgregarProductos;
            this.BtnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(252, 557);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(247, 43);
            this.BtnAgregarProducto.TabIndex = 6;
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Vista.Properties.Resources.BtnCanjear;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(675, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 43);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnCanjear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.MenuLubri_Punts;
            this.ClientSize = new System.Drawing.Size(1128, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.DgvServiPuntos);
            this.Name = "BtnCanjear";
            this.Text = "MenuServiPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvServiPuntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvServiPuntos;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button button1;
    }
}