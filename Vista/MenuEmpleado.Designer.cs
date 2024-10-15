namespace Vista
{
    partial class MenuEmpleado
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
            this.TxtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.TxtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.TxtDniEmpleado = new System.Windows.Forms.TextBox();
            this.TxtCelularEmpleado = new System.Windows.Forms.TextBox();
            this.CmbCategoriaEmple = new System.Windows.Forms.ComboBox();
            this.DgvMenuEmpleado = new System.Windows.Forms.DataGridView();
            this.BtnAgregarMeEmpleado = new System.Windows.Forms.Button();
            this.BtnEditarMeEmpleado = new System.Windows.Forms.Button();
            this.BtnEliminarMeEmpleado = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMenuEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(315, 186);
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(243, 22);
            this.TxtNombreEmpleado.TabIndex = 0;
            // 
            // TxtApellidoEmpleado
            // 
            this.TxtApellidoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoEmpleado.Location = new System.Drawing.Point(768, 186);
            this.TxtApellidoEmpleado.Name = "TxtApellidoEmpleado";
            this.TxtApellidoEmpleado.Size = new System.Drawing.Size(243, 22);
            this.TxtApellidoEmpleado.TabIndex = 1;
            // 
            // TxtDniEmpleado
            // 
            this.TxtDniEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDniEmpleado.Location = new System.Drawing.Point(315, 256);
            this.TxtDniEmpleado.Name = "TxtDniEmpleado";
            this.TxtDniEmpleado.Size = new System.Drawing.Size(243, 22);
            this.TxtDniEmpleado.TabIndex = 2;
            // 
            // TxtCelularEmpleado
            // 
            this.TxtCelularEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelularEmpleado.Location = new System.Drawing.Point(315, 348);
            this.TxtCelularEmpleado.Name = "TxtCelularEmpleado";
            this.TxtCelularEmpleado.Size = new System.Drawing.Size(243, 22);
            this.TxtCelularEmpleado.TabIndex = 3;
            // 
            // CmbCategoriaEmple
            // 
            this.CmbCategoriaEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategoriaEmple.FormattingEnabled = true;
            this.CmbCategoriaEmple.Location = new System.Drawing.Point(768, 346);
            this.CmbCategoriaEmple.Name = "CmbCategoriaEmple";
            this.CmbCategoriaEmple.Size = new System.Drawing.Size(243, 24);
            this.CmbCategoriaEmple.TabIndex = 4;
            this.CmbCategoriaEmple.SelectedIndexChanged += new System.EventHandler(this.CmbCategoriaEmple_SelectedIndexChanged);
            // 
            // DgvMenuEmpleado
            // 
            this.DgvMenuEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMenuEmpleado.Location = new System.Drawing.Point(315, 473);
            this.DgvMenuEmpleado.Name = "DgvMenuEmpleado";
            this.DgvMenuEmpleado.Size = new System.Drawing.Size(657, 150);
            this.DgvMenuEmpleado.TabIndex = 6;
            // 
            // BtnAgregarMeEmpleado
            // 
            this.BtnAgregarMeEmpleado.BackgroundImage = global::Vista.Properties.Resources.BtnAgregar;
            this.BtnAgregarMeEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnAgregarMeEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarMeEmpleado.Location = new System.Drawing.Point(315, 657);
            this.BtnAgregarMeEmpleado.Name = "BtnAgregarMeEmpleado";
            this.BtnAgregarMeEmpleado.Size = new System.Drawing.Size(129, 43);
            this.BtnAgregarMeEmpleado.TabIndex = 8;
            this.BtnAgregarMeEmpleado.UseVisualStyleBackColor = true;
            this.BtnAgregarMeEmpleado.Click += new System.EventHandler(this.BtnAgregarMeEmpleado_Click);
            // 
            // BtnEditarMeEmpleado
            // 
            this.BtnEditarMeEmpleado.BackgroundImage = global::Vista.Properties.Resources.BtnEditar1;
            this.BtnEditarMeEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnEditarMeEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarMeEmpleado.Location = new System.Drawing.Point(610, 657);
            this.BtnEditarMeEmpleado.Name = "BtnEditarMeEmpleado";
            this.BtnEditarMeEmpleado.Size = new System.Drawing.Size(95, 43);
            this.BtnEditarMeEmpleado.TabIndex = 9;
            this.BtnEditarMeEmpleado.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarMeEmpleado
            // 
            this.BtnEliminarMeEmpleado.BackgroundImage = global::Vista.Properties.Resources.BtnEliminar;
            this.BtnEliminarMeEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnEliminarMeEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarMeEmpleado.Location = new System.Drawing.Point(843, 657);
            this.BtnEliminarMeEmpleado.Name = "BtnEliminarMeEmpleado";
            this.BtnEliminarMeEmpleado.Size = new System.Drawing.Size(168, 43);
            this.BtnEliminarMeEmpleado.TabIndex = 10;
            this.BtnEliminarMeEmpleado.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(768, 256);
            this.txtContraseña.MaxLength = 8;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(243, 22);
            this.txtContraseña.TabIndex = 11;
            // 
            // MenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuEmpleados1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1284, 722);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.BtnEliminarMeEmpleado);
            this.Controls.Add(this.BtnEditarMeEmpleado);
            this.Controls.Add(this.BtnAgregarMeEmpleado);
            this.Controls.Add(this.DgvMenuEmpleado);
            this.Controls.Add(this.CmbCategoriaEmple);
            this.Controls.Add(this.TxtCelularEmpleado);
            this.Controls.Add(this.TxtDniEmpleado);
            this.Controls.Add(this.TxtApellidoEmpleado);
            this.Controls.Add(this.TxtNombreEmpleado);
            this.DoubleBuffered = true;
            this.Name = "MenuEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMenuEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreEmpleado;
        private System.Windows.Forms.TextBox TxtApellidoEmpleado;
        private System.Windows.Forms.TextBox TxtDniEmpleado;
        private System.Windows.Forms.TextBox TxtCelularEmpleado;
        private System.Windows.Forms.ComboBox CmbCategoriaEmple;
        private System.Windows.Forms.DataGridView DgvMenuEmpleado;
        private System.Windows.Forms.Button BtnAgregarMeEmpleado;
        private System.Windows.Forms.Button BtnEditarMeEmpleado;
        private System.Windows.Forms.Button BtnEliminarMeEmpleado;
        private System.Windows.Forms.TextBox txtContraseña;
    }
}