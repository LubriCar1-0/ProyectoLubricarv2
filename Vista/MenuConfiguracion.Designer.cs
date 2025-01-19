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
            this.BtnEmpresa = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.btnABMCategoriasProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnRegresar.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Location = new System.Drawing.Point(283, 180);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(63, 54);
            this.BtnRegresar.TabIndex = 14;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnEmpresa
            // 
            this.BtnEmpresa.BackgroundImage = global::Vista.Properties.Resources.BtnEmpresa1;
            this.BtnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpresa.Location = new System.Drawing.Point(1066, 414);
            this.BtnEmpresa.Name = "BtnEmpresa";
            this.BtnEmpresa.Size = new System.Drawing.Size(411, 168);
            this.BtnEmpresa.TabIndex = 2;
            this.BtnEmpresa.UseVisualStyleBackColor = true;
            this.BtnEmpresa.Click += new System.EventHandler(this.BtnEmpresa_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.BackgroundImage = global::Vista.Properties.Resources.BtnEmpleados1;
            this.BtnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Location = new System.Drawing.Point(1066, 216);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(411, 168);
            this.BtnEmpleados.TabIndex = 1;
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // btnABMCategoriasProductos
            // 
            this.btnABMCategoriasProductos.BackgroundImage = global::Vista.Properties.Resources.BTNAgregarCategorias;
            this.btnABMCategoriasProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnABMCategoriasProductos.FlatAppearance.BorderSize = 0;
            this.btnABMCategoriasProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMCategoriasProductos.Location = new System.Drawing.Point(1066, 599);
            this.btnABMCategoriasProductos.Name = "btnABMCategoriasProductos";
            this.btnABMCategoriasProductos.Size = new System.Drawing.Size(411, 168);
            this.btnABMCategoriasProductos.TabIndex = 15;
            this.btnABMCategoriasProductos.UseVisualStyleBackColor = true;
            this.btnABMCategoriasProductos.Click += new System.EventHandler(this.btnABMCategoriasProductos_Click_1);
            // 
            // MenuConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantMenuConfiguracion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnABMCategoriasProductos);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEmpresa);
            this.Controls.Add(this.BtnEmpleados);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuConfiguracion";
            this.Text = "MenuConfiguracion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnEmpresa;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button btnABMCategoriasProductos;
    }
}