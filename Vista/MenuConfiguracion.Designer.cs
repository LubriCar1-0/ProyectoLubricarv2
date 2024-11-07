namespace Vista
{
    partial class MenuConfiguracion
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnEmpresa = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(174, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 54);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnEmpresa
            // 
            this.BtnEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpresa.Image = global::Vista.Properties.Resources.BtnEmpresa1;
            this.BtnEmpresa.Location = new System.Drawing.Point(623, 386);
            this.BtnEmpresa.Name = "BtnEmpresa";
            this.BtnEmpresa.Size = new System.Drawing.Size(364, 137);
            this.BtnEmpresa.TabIndex = 2;
            this.BtnEmpresa.UseVisualStyleBackColor = true;
            this.BtnEmpresa.Click += new System.EventHandler(this.BtnEmpresa_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Image = global::Vista.Properties.Resources.BtnEmpleados1;
            this.BtnEmpleados.Location = new System.Drawing.Point(626, 210);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(361, 139);
            this.BtnEmpleados.TabIndex = 1;
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // MenuConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantMenuConfiguracion;
            this.ClientSize = new System.Drawing.Size(1284, 724);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnEmpresa);
            this.Controls.Add(this.BtnEmpleados);
            this.Name = "MenuConfiguracion";
            this.Text = "MenuConfiguracion";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnEmpresa;
        private System.Windows.Forms.Button button1;
    }
}