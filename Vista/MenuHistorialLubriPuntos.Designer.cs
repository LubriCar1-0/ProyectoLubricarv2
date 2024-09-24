namespace Vista
{
    partial class MenuHistorialLubriPuntos
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
            this.DgvHistorialPuntosCanjeados = new System.Windows.Forms.DataGridView();
            this.DgvHistorialPuntosGanados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialPuntosCanjeados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialPuntosGanados)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvHistorialPuntosCanjeados
            // 
            this.DgvHistorialPuntosCanjeados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistorialPuntosCanjeados.Location = new System.Drawing.Point(174, 145);
            this.DgvHistorialPuntosCanjeados.Name = "DgvHistorialPuntosCanjeados";
            this.DgvHistorialPuntosCanjeados.Size = new System.Drawing.Size(819, 234);
            this.DgvHistorialPuntosCanjeados.TabIndex = 0;
            // 
            // DgvHistorialPuntosGanados
            // 
            this.DgvHistorialPuntosGanados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistorialPuntosGanados.Location = new System.Drawing.Point(174, 415);
            this.DgvHistorialPuntosGanados.Name = "DgvHistorialPuntosGanados";
            this.DgvHistorialPuntosGanados.Size = new System.Drawing.Size(819, 191);
            this.DgvHistorialPuntosGanados.TabIndex = 1;
            // 
            // MenuHistorialLubriPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaHistorialLubriPuntos;
            this.ClientSize = new System.Drawing.Size(1158, 661);
            this.Controls.Add(this.DgvHistorialPuntosGanados);
            this.Controls.Add(this.DgvHistorialPuntosCanjeados);
            this.Name = "MenuHistorialLubriPuntos";
            this.Text = "MenuHistorialLubriPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialPuntosCanjeados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistorialPuntosGanados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvHistorialPuntosCanjeados;
        private System.Windows.Forms.DataGridView DgvHistorialPuntosGanados;
    }
}