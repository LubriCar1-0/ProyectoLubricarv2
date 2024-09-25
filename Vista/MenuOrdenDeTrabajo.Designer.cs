namespace Vista
{
    partial class MenuOrdenDeTrabajo
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
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.CmbCliente = new System.Windows.Forms.ComboBox();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.CmbModelo = new System.Windows.Forms.ComboBox();
            this.ckbNoIniciado = new System.Windows.Forms.CheckBox();
            this.CkbEnProceso = new System.Windows.Forms.CheckBox();
            this.CkbFinalizado = new System.Windows.Forms.CheckBox();
            this.TxbDescripcion = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.PtbMenuOrdenDeTrabajo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMenuOrdenDeTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Location = new System.Drawing.Point(314, 305);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(220, 20);
            this.DtpFechaInicio.TabIndex = 5;
            // 
            // CmbCliente
            // 
            this.CmbCliente.FormattingEnabled = true;
            this.CmbCliente.Location = new System.Drawing.Point(314, 156);
            this.CmbCliente.Name = "CmbCliente";
            this.CmbCliente.Size = new System.Drawing.Size(205, 21);
            this.CmbCliente.TabIndex = 6;
            // 
            // CmbMarca
            // 
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Location = new System.Drawing.Point(314, 211);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(205, 21);
            this.CmbMarca.TabIndex = 7;
            // 
            // CmbModelo
            // 
            this.CmbModelo.FormattingEnabled = true;
            this.CmbModelo.Location = new System.Drawing.Point(314, 261);
            this.CmbModelo.Name = "CmbModelo";
            this.CmbModelo.Size = new System.Drawing.Size(205, 21);
            this.CmbModelo.TabIndex = 8;
            // 
            // ckbNoIniciado
            // 
            this.ckbNoIniciado.AutoSize = true;
            this.ckbNoIniciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.ckbNoIniciado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNoIniciado.ForeColor = System.Drawing.Color.Red;
            this.ckbNoIniciado.Location = new System.Drawing.Point(314, 398);
            this.ckbNoIniciado.Name = "ckbNoIniciado";
            this.ckbNoIniciado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbNoIniciado.Size = new System.Drawing.Size(145, 28);
            this.ckbNoIniciado.TabIndex = 10;
            this.ckbNoIniciado.Text = "No Iniciado";
            this.ckbNoIniciado.UseVisualStyleBackColor = false;
            // 
            // CkbEnProceso
            // 
            this.CkbEnProceso.AutoSize = true;
            this.CkbEnProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.CkbEnProceso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbEnProceso.ForeColor = System.Drawing.Color.Yellow;
            this.CkbEnProceso.Location = new System.Drawing.Point(474, 398);
            this.CkbEnProceso.Name = "CkbEnProceso";
            this.CkbEnProceso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CkbEnProceso.Size = new System.Drawing.Size(145, 28);
            this.CkbEnProceso.TabIndex = 11;
            this.CkbEnProceso.Text = "En Proceso";
            this.CkbEnProceso.UseVisualStyleBackColor = false;
            // 
            // CkbFinalizado
            // 
            this.CkbFinalizado.AutoSize = true;
            this.CkbFinalizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.CkbFinalizado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbFinalizado.ForeColor = System.Drawing.Color.Green;
            this.CkbFinalizado.Location = new System.Drawing.Point(636, 398);
            this.CkbFinalizado.Name = "CkbFinalizado";
            this.CkbFinalizado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CkbFinalizado.Size = new System.Drawing.Size(134, 28);
            this.CkbFinalizado.TabIndex = 12;
            this.CkbFinalizado.Text = "Finalizado";
            this.CkbFinalizado.UseVisualStyleBackColor = false;
            // 
            // TxbDescripcion
            // 
            this.TxbDescripcion.Location = new System.Drawing.Point(356, 498);
            this.TxbDescripcion.Multiline = true;
            this.TxbDescripcion.Name = "TxbDescripcion";
            this.TxbDescripcion.Size = new System.Drawing.Size(414, 108);
            this.TxbDescripcion.TabIndex = 14;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Image = global::Vista.Properties.Resources.BtnCancelar1;
            this.BtnCancelar.Location = new System.Drawing.Point(665, 645);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(252, 44);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Image = global::Vista.Properties.Resources.BtnAgregar1;
            this.BtnAgregar.Location = new System.Drawing.Point(314, 645);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(252, 44);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // PtbMenuOrdenDeTrabajo
            // 
            this.PtbMenuOrdenDeTrabajo.Image = global::Vista.Properties.Resources.PantMenuOrdenDeTrabajo2;
            this.PtbMenuOrdenDeTrabajo.Location = new System.Drawing.Point(-5, -1);
            this.PtbMenuOrdenDeTrabajo.Name = "PtbMenuOrdenDeTrabajo";
            this.PtbMenuOrdenDeTrabajo.Size = new System.Drawing.Size(1275, 714);
            this.PtbMenuOrdenDeTrabajo.TabIndex = 15;
            this.PtbMenuOrdenDeTrabajo.TabStop = false;
            // 
            // MenuOrdenDeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 712);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxbDescripcion);
            this.Controls.Add(this.CkbFinalizado);
            this.Controls.Add(this.CkbEnProceso);
            this.Controls.Add(this.ckbNoIniciado);
            this.Controls.Add(this.CmbModelo);
            this.Controls.Add(this.CmbMarca);
            this.Controls.Add(this.CmbCliente);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.PtbMenuOrdenDeTrabajo);
            this.Name = "MenuOrdenDeTrabajo";
            this.Text = "MenuOrdenDeTrabajo";
            ((System.ComponentModel.ISupportInitialize)(this.PtbMenuOrdenDeTrabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.ComboBox CmbCliente;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.ComboBox CmbModelo;
        private System.Windows.Forms.CheckBox ckbNoIniciado;
        private System.Windows.Forms.CheckBox CkbEnProceso;
        private System.Windows.Forms.CheckBox CkbFinalizado;
        private System.Windows.Forms.TextBox TxbDescripcion;
        private System.Windows.Forms.PictureBox PtbMenuOrdenDeTrabajo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}