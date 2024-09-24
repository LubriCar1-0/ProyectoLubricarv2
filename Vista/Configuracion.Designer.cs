namespace Vista
{
    partial class Configuracion
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
            this.BtnDatosEmpresa = new System.Windows.Forms.Button();
            this.BtnHistoralBitacora = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.BtnEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDatosEmpresa
            // 
            this.BtnDatosEmpresa.BackgroundImage = global::Vista.Properties.Resources.BtnDatosEmpresa;
            this.BtnDatosEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnDatosEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDatosEmpresa.Location = new System.Drawing.Point(629, 157);
            this.BtnDatosEmpresa.Name = "BtnDatosEmpresa";
            this.BtnDatosEmpresa.Size = new System.Drawing.Size(277, 109);
            this.BtnDatosEmpresa.TabIndex = 1;
            this.BtnDatosEmpresa.UseVisualStyleBackColor = true;
            // 
            // BtnHistoralBitacora
            // 
            this.BtnHistoralBitacora.BackgroundImage = global::Vista.Properties.Resources.BtnHistorialBitacora;
            this.BtnHistoralBitacora.FlatAppearance.BorderSize = 0;
            this.BtnHistoralBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistoralBitacora.Location = new System.Drawing.Point(629, 272);
            this.BtnHistoralBitacora.Name = "BtnHistoralBitacora";
            this.BtnHistoralBitacora.Size = new System.Drawing.Size(291, 114);
            this.BtnHistoralBitacora.TabIndex = 2;
            this.BtnHistoralBitacora.UseVisualStyleBackColor = true;
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.BackgroundImage = global::Vista.Properties.Resources.BtnEmpleados;
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Location = new System.Drawing.Point(629, 392);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(291, 109);
            this.BtnEmpleados.TabIndex = 3;
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            // 
            // BtnEmpresa
            // 
            this.BtnEmpresa.BackgroundImage = global::Vista.Properties.Resources.BtnEmpresa;
            this.BtnEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpresa.Location = new System.Drawing.Point(629, 507);
            this.BtnEmpresa.Name = "BtnEmpresa";
            this.BtnEmpresa.Size = new System.Drawing.Size(291, 109);
            this.BtnEmpresa.TabIndex = 4;
            this.BtnEmpresa.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaConfiguracion;
            this.ClientSize = new System.Drawing.Size(1149, 643);
            this.Controls.Add(this.BtnEmpresa);
            this.Controls.Add(this.BtnEmpleados);
            this.Controls.Add(this.BtnHistoralBitacora);
            this.Controls.Add(this.BtnDatosEmpresa);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDatosEmpresa;
        private System.Windows.Forms.Button BtnHistoralBitacora;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnEmpresa;
    }
}