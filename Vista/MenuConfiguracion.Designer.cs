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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.btnMenuCatEMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnRegresar.BackgroundImage = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Location = new System.Drawing.Point(193, 122);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(63, 54);
            this.BtnRegresar.TabIndex = 14;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.BackgroundImage = global::lubricar.Properties.Resources.BtnEmpleados1;
            this.BtnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Location = new System.Drawing.Point(786, 283);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(251, 112);
            this.BtnEmpleados.TabIndex = 1;
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // btnMenuCatEMP
            // 
            this.btnMenuCatEMP.BackgroundImage = global::lubricar.Properties.Resources.BtnCatEMP;
            this.btnMenuCatEMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuCatEMP.FlatAppearance.BorderSize = 0;
            this.btnMenuCatEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCatEMP.Location = new System.Drawing.Point(786, 421);
            this.btnMenuCatEMP.Name = "btnMenuCatEMP";
            this.btnMenuCatEMP.Size = new System.Drawing.Size(251, 112);
            this.btnMenuCatEMP.TabIndex = 16;
            this.btnMenuCatEMP.UseVisualStyleBackColor = true;
            this.btnMenuCatEMP.Click += new System.EventHandler(this.btnMenuCatEMP_Click);
            // 
            // MenuConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.PantMenuConfiguracion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnMenuCatEMP);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEmpleados);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuConfiguracion";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button btnMenuCatEMP;
    }
}