namespace Vista
{
    partial class MenuControlDeStock
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
            this.BtnVolverMeControlStock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvControlDeStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvControlDeStock)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolverMeControlStock
            // 
            this.BtnVolverMeControlStock.BackgroundImage = global::Vista.Properties.Resources.BtnVolver1;
            this.BtnVolverMeControlStock.FlatAppearance.BorderSize = 0;
            this.BtnVolverMeControlStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolverMeControlStock.Location = new System.Drawing.Point(909, 558);
            this.BtnVolverMeControlStock.Name = "BtnVolverMeControlStock";
            this.BtnVolverMeControlStock.Size = new System.Drawing.Size(97, 43);
            this.BtnVolverMeControlStock.TabIndex = 4;
            this.BtnVolverMeControlStock.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Vista.Properties.Resources.BtnEditar;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(909, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 43);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DgvControlDeStock
            // 
            this.DgvControlDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvControlDeStock.Location = new System.Drawing.Point(188, 113);
            this.DgvControlDeStock.Name = "DgvControlDeStock";
            this.DgvControlDeStock.Size = new System.Drawing.Size(665, 499);
            this.DgvControlDeStock.TabIndex = 6;
            // 
            // MenuControlDeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaControlDeStock1;
            this.ClientSize = new System.Drawing.Size(1145, 624);
            this.Controls.Add(this.DgvControlDeStock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnVolverMeControlStock);
            this.Name = "MenuControlDeStock";
            this.Text = "MenuControlDeStock";
            ((System.ComponentModel.ISupportInitialize)(this.DgvControlDeStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolverMeControlStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DgvControlDeStock;
    }
}