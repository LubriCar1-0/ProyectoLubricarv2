namespace Vista
{
    partial class MenuAsignacionLubriPuntos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVproductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantLubri = new System.Windows.Forms.TextBox();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGVproducxlubri = new System.Windows.Forms.DataGridView();
            this.CambiarEstado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproducxlubri)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVproductos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVproductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproductos.Location = new System.Drawing.Point(16, 115);
            this.DGVproductos.Name = "DGVproductos";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVproductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVproductos.Size = new System.Drawing.Size(475, 187);
            this.DGVproductos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtCodProducto);
            this.groupBox1.Controls.Add(this.btnRecargar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.DGVproductos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(180, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Producto";
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.TxtCodProducto.Location = new System.Drawing.Point(16, 75);
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.Size = new System.Drawing.Size(265, 35);
            this.TxtCodProducto.TabIndex = 1;
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.BackgroundImage = global::Vista.Properties.Resources.BtnRecargarIcon;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Location = new System.Drawing.Point(371, 65);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(54, 48);
            this.btnRecargar.TabIndex = 21;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::Vista.Properties.Resources.BtnBuscarIcon;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(287, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 48);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.txtCantLubri);
            this.groupBox2.Controls.Add(this.BtnConfirmar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblNombreProd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(373, 528);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignación de Lubri-Puntos";
            // 
            // txtCantLubri
            // 
            this.txtCantLubri.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.txtCantLubri.Location = new System.Drawing.Point(387, 99);
            this.txtCantLubri.Name = "txtCantLubri";
            this.txtCantLubri.Size = new System.Drawing.Size(146, 35);
            this.txtCantLubri.TabIndex = 2;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackgroundImage = global::Vista.Properties.Resources.BtnConfirmar;
            this.BtnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(400, 152);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(161, 42);
            this.BtnConfirmar.TabIndex = 3;
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(7, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cantidad de Lubri-Puntos a asignar:";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreProd.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.ForeColor = System.Drawing.Color.Black;
            this.lblNombreProd.Location = new System.Drawing.Point(244, 65);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(241, 26);
            this.lblNombreProd.TabIndex = 36;
            this.lblNombreProd.Text = "No se selecciono producto";
            this.lblNombreProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(2, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 28);
            this.label9.TabIndex = 35;
            this.label9.Text = "Producto seleccionado:";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.Transparent;
            this.BtnVolver.BackgroundImage = global::Vista.Properties.Resources.undo_arrow_icon_icons_com_53849;
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Location = new System.Drawing.Point(178, 123);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(59, 61);
            this.BtnVolver.TabIndex = 4;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox3.Controls.Add(this.DGVproducxlubri);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox3.Location = new System.Drawing.Point(684, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 357);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos con Lubri-Puntos";
            // 
            // DGVproducxlubri
            // 
            this.DGVproducxlubri.AllowUserToAddRows = false;
            this.DGVproducxlubri.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVproducxlubri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVproducxlubri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproducxlubri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CambiarEstado});
            this.DGVproducxlubri.Location = new System.Drawing.Point(19, 61);
            this.DGVproducxlubri.Name = "DGVproducxlubri";
            this.DGVproducxlubri.ReadOnly = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVproducxlubri.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVproducxlubri.Size = new System.Drawing.Size(428, 288);
            this.DGVproducxlubri.TabIndex = 0;
            this.DGVproducxlubri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproducxlubri_CellContentClick);
            // 
            // CambiarEstado
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.CambiarEstado.DefaultCellStyle = dataGridViewCellStyle4;
            this.CambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CambiarEstado.HeaderText = "Estado";
            this.CambiarEstado.Name = "CambiarEstado";
            this.CambiarEstado.ReadOnly = true;
            this.CambiarEstado.Text = "Cambiar Estado";
            this.CambiarEstado.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ingrese el codigo del producto:";
            // 
            // MenuAsignacionLubriPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.MenuAsignacionLubriPuntos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnVolver);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAsignacionLubriPuntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAsignacionLubriPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.DGVproductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVproducxlubri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVproductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGVproducxlubri;
        private System.Windows.Forms.TextBox txtCantLubri;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.DataGridViewButtonColumn CambiarEstado;
        private System.Windows.Forms.Label label4;
    }
}