namespace Vista
{
    partial class MenuDatosEmpresa
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
            this.BtnEditarEmpresa = new System.Windows.Forms.Button();
            this.BtnConfirmarEmpresa = new System.Windows.Forms.Button();
            this.CbxCondicionIva = new System.Windows.Forms.ComboBox();
            this.TxtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.TxtCuilEmpresa = new System.Windows.Forms.TextBox();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.TxtPuntoDeVenta = new System.Windows.Forms.TextBox();
            this.GridEmpresa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditarEmpresa
            // 
            this.BtnEditarEmpresa.BackgroundImage = global::lubricar.Properties.Resources.BtnEditar;
            this.BtnEditarEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnEditarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarEmpresa.Location = new System.Drawing.Point(742, 428);
            this.BtnEditarEmpresa.Name = "BtnEditarEmpresa";
            this.BtnEditarEmpresa.Size = new System.Drawing.Size(95, 43);
            this.BtnEditarEmpresa.TabIndex = 8;
            this.BtnEditarEmpresa.UseVisualStyleBackColor = true;
            this.BtnEditarEmpresa.Click += new System.EventHandler(this.BtnEditarEmpresa_Click);
            // 
            // BtnConfirmarEmpresa
            // 
            this.BtnConfirmarEmpresa.BackgroundImage = global::lubricar.Properties.Resources.BtnConfirmar;
            this.BtnConfirmarEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnConfirmarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarEmpresa.Location = new System.Drawing.Point(742, 501);
            this.BtnConfirmarEmpresa.Name = "BtnConfirmarEmpresa";
            this.BtnConfirmarEmpresa.Size = new System.Drawing.Size(164, 43);
            this.BtnConfirmarEmpresa.TabIndex = 9;
            this.BtnConfirmarEmpresa.UseVisualStyleBackColor = true;
            this.BtnConfirmarEmpresa.Click += new System.EventHandler(this.BtnConfirmarEmpresa_Click);
            // 
            // CbxCondicionIva
            // 
            this.CbxCondicionIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCondicionIva.FormattingEnabled = true;
            this.CbxCondicionIva.Location = new System.Drawing.Point(625, 233);
            this.CbxCondicionIva.Name = "CbxCondicionIva";
            this.CbxCondicionIva.Size = new System.Drawing.Size(157, 28);
            this.CbxCondicionIva.TabIndex = 10;
            // 
            // TxtNombreEmpresa
            // 
            this.TxtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEmpresa.Location = new System.Drawing.Point(204, 154);
            this.TxtNombreEmpresa.Name = "TxtNombreEmpresa";
            this.TxtNombreEmpresa.Size = new System.Drawing.Size(201, 26);
            this.TxtNombreEmpresa.TabIndex = 11;
            // 
            // TxtCuilEmpresa
            // 
            this.TxtCuilEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuilEmpresa.Location = new System.Drawing.Point(625, 154);
            this.TxtCuilEmpresa.Name = "TxtCuilEmpresa";
            this.TxtCuilEmpresa.Size = new System.Drawing.Size(201, 26);
            this.TxtCuilEmpresa.TabIndex = 12;
            this.TxtCuilEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCuilEmpresa_KeyPress);
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDomicilio.Location = new System.Drawing.Point(204, 233);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(201, 26);
            this.TxtDomicilio.TabIndex = 13;
            // 
            // TxtPuntoDeVenta
            // 
            this.TxtPuntoDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntoDeVenta.Location = new System.Drawing.Point(204, 313);
            this.TxtPuntoDeVenta.Name = "TxtPuntoDeVenta";
            this.TxtPuntoDeVenta.Size = new System.Drawing.Size(201, 26);
            this.TxtPuntoDeVenta.TabIndex = 14;
            // 
            // GridEmpresa
            // 
            this.GridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmpresa.Location = new System.Drawing.Point(204, 389);
            this.GridEmpresa.Name = "GridEmpresa";
            this.GridEmpresa.Size = new System.Drawing.Size(508, 223);
            this.GridEmpresa.TabIndex = 15;
            // 
            // MenuDatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.PantallaDatosEmpresa;
            this.ClientSize = new System.Drawing.Size(1145, 644);
            this.Controls.Add(this.GridEmpresa);
            this.Controls.Add(this.TxtPuntoDeVenta);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.TxtCuilEmpresa);
            this.Controls.Add(this.TxtNombreEmpresa);
            this.Controls.Add(this.CbxCondicionIva);
            this.Controls.Add(this.BtnConfirmarEmpresa);
            this.Controls.Add(this.BtnEditarEmpresa);
            this.Name = "MenuDatosEmpresa";
            this.Text = "MenuDatosEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEditarEmpresa;
        private System.Windows.Forms.Button BtnConfirmarEmpresa;
        private System.Windows.Forms.ComboBox CbxCondicionIva;
        private System.Windows.Forms.TextBox TxtNombreEmpresa;
        private System.Windows.Forms.TextBox TxtCuilEmpresa;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.TextBox TxtPuntoDeVenta;
        private System.Windows.Forms.DataGridView GridEmpresa;
    }
}