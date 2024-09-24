namespace Vista
{
    partial class MenuHistorialDeTurnos
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
            this.DgvHistorialDeTurnos = new System.Windows.Forms.DataGridView();
            this.BtnVerTurno = new System.Windows.Forms.Button();
            this.BtnEditarTurno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialDeTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvHistorialDeTurnos
            // 
            this.DgvHistorialDeTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistorialDeTurnos.Location = new System.Drawing.Point(194, 162);
            this.DgvHistorialDeTurnos.Name = "DgvHistorialDeTurnos";
            this.DgvHistorialDeTurnos.Size = new System.Drawing.Size(791, 379);
            this.DgvHistorialDeTurnos.TabIndex = 0;
            // 
            // BtnVerTurno
            // 
            this.BtnVerTurno.BackgroundImage = global::Vista.Properties.Resources.BtnVerTurno;
            this.BtnVerTurno.FlatAppearance.BorderSize = 0;
            this.BtnVerTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerTurno.Location = new System.Drawing.Point(256, 565);
            this.BtnVerTurno.Name = "BtnVerTurno";
            this.BtnVerTurno.Size = new System.Drawing.Size(166, 43);
            this.BtnVerTurno.TabIndex = 7;
            this.BtnVerTurno.UseVisualStyleBackColor = true;
            // 
            // BtnEditarTurno
            // 
            this.BtnEditarTurno.BackgroundImage = global::Vista.Properties.Resources.BtnEditarTurno;
            this.BtnEditarTurno.FlatAppearance.BorderSize = 0;
            this.BtnEditarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarTurno.Location = new System.Drawing.Point(748, 565);
            this.BtnEditarTurno.Name = "BtnEditarTurno";
            this.BtnEditarTurno.Size = new System.Drawing.Size(192, 43);
            this.BtnEditarTurno.TabIndex = 8;
            this.BtnEditarTurno.UseVisualStyleBackColor = true;
            // 
            // MenuHistorialDeTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaHistorialDeTurnos;
            this.ClientSize = new System.Drawing.Size(1131, 641);
            this.Controls.Add(this.BtnEditarTurno);
            this.Controls.Add(this.BtnVerTurno);
            this.Controls.Add(this.DgvHistorialDeTurnos);
            this.Name = "MenuHistorialDeTurnos";
            this.Text = "MenuHistorialDeTurnos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialDeTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvHistorialDeTurnos;
        private System.Windows.Forms.Button BtnVerTurno;
        private System.Windows.Forms.Button BtnEditarTurno;
    }
}