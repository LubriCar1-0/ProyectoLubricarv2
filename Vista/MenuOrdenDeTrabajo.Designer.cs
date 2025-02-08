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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbPatente = new System.Windows.Forms.TextBox();
            this.TxbDescripcion = new System.Windows.Forms.TextBox();
            this.cmbTrabajador = new System.Windows.Forms.ComboBox();
            this.DtpFechaDeInicio = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(430, 286);
            this.txbNombre.Multiline = true;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(208, 34);
            this.txbNombre.TabIndex = 20;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(430, 402);
            this.txbApellido.Multiline = true;
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(208, 34);
            this.txbApellido.TabIndex = 21;
            // 
            // txbPatente
            // 
            this.txbPatente.Location = new System.Drawing.Point(822, 286);
            this.txbPatente.Multiline = true;
            this.txbPatente.Name = "txbPatente";
            this.txbPatente.Size = new System.Drawing.Size(208, 34);
            this.txbPatente.TabIndex = 22;
            // 
            // TxbDescripcion
            // 
            this.TxbDescripcion.Location = new System.Drawing.Point(1247, 402);
            this.TxbDescripcion.Multiline = true;
            this.TxbDescripcion.Name = "TxbDescripcion";
            this.TxbDescripcion.Size = new System.Drawing.Size(353, 108);
            this.TxbDescripcion.TabIndex = 23;
            // 
            // cmbTrabajador
            // 
            this.cmbTrabajador.FormattingEnabled = true;
            this.cmbTrabajador.Location = new System.Drawing.Point(822, 402);
            this.cmbTrabajador.Name = "cmbTrabajador";
            this.cmbTrabajador.Size = new System.Drawing.Size(208, 21);
            this.cmbTrabajador.TabIndex = 24;
            // 
            // DtpFechaDeInicio
            // 
            this.DtpFechaDeInicio.Location = new System.Drawing.Point(1247, 286);
            this.DtpFechaDeInicio.Name = "DtpFechaDeInicio";
            this.DtpFechaDeInicio.Size = new System.Drawing.Size(220, 20);
            this.DtpFechaDeInicio.TabIndex = 25;
            // 
            // MenuOrdenDeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.MenuOrdenDeTrabajo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.DtpFechaDeInicio);
            this.Controls.Add(this.cmbTrabajador);
            this.Controls.Add(this.TxbDescripcion);
            this.Controls.Add(this.txbPatente);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.DoubleBuffered = true;
            this.Name = "MenuOrdenDeTrabajo";
            this.Text = "MenuOrdenDeTrabajo";
            this.Load += new System.EventHandler(this.MenuOrdenDeTrabajo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbPatente;
        private System.Windows.Forms.TextBox TxbDescripcion;
        private System.Windows.Forms.ComboBox cmbTrabajador;
        private System.Windows.Forms.DateTimePicker DtpFechaDeInicio;
    }
}