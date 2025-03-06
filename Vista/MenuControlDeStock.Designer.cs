namespace Vista
{
    partial class MenuControlDeStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.DgvControlDeStock = new System.Windows.Forms.DataGridView();
            this.txbPrecioVent = new System.Windows.Forms.TextBox();
            this.txbPrecioList = new System.Windows.Forms.TextBox();
            this.txbCant = new System.Windows.Forms.TextBox();
            this.txbCantMinima = new System.Windows.Forms.TextBox();
            this.txtLitrosDisp = new System.Windows.Forms.TextBox();
            this.txtLitrosMin = new System.Windows.Forms.TextBox();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvControlDeStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = global::lubricar.Properties.Resources.BtnConfirmar;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(781, 559);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(258, 76);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // DgvControlDeStock
            // 
            this.DgvControlDeStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvControlDeStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvControlDeStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvControlDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvControlDeStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvControlDeStock.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DgvControlDeStock.Location = new System.Drawing.Point(279, 271);
            this.DgvControlDeStock.Name = "DgvControlDeStock";
            this.DgvControlDeStock.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvControlDeStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvControlDeStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvControlDeStock.Size = new System.Drawing.Size(311, 452);
            this.DgvControlDeStock.TabIndex = 6;
            this.DgvControlDeStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvControlDeStock_CellContentClick);
            // 
            // txbPrecioVent
            // 
            this.txbPrecioVent.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecioVent.Location = new System.Drawing.Point(686, 353);
            this.txbPrecioVent.Multiline = true;
            this.txbPrecioVent.Name = "txbPrecioVent";
            this.txbPrecioVent.Size = new System.Drawing.Size(195, 33);
            this.txbPrecioVent.TabIndex = 4;
            // 
            // txbPrecioList
            // 
            this.txbPrecioList.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecioList.Location = new System.Drawing.Point(940, 353);
            this.txbPrecioList.Multiline = true;
            this.txbPrecioList.Name = "txbPrecioList";
            this.txbPrecioList.Size = new System.Drawing.Size(195, 33);
            this.txbPrecioList.TabIndex = 5;
            // 
            // txbCant
            // 
            this.txbCant.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCant.Location = new System.Drawing.Point(686, 422);
            this.txbCant.Multiline = true;
            this.txbCant.Name = "txbCant";
            this.txbCant.Size = new System.Drawing.Size(195, 33);
            this.txbCant.TabIndex = 6;
            // 
            // txbCantMinima
            // 
            this.txbCantMinima.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantMinima.Location = new System.Drawing.Point(940, 422);
            this.txbCantMinima.Multiline = true;
            this.txbCantMinima.Name = "txbCantMinima";
            this.txbCantMinima.Size = new System.Drawing.Size(195, 33);
            this.txbCantMinima.TabIndex = 7;
            // 
            // txtLitrosDisp
            // 
            this.txtLitrosDisp.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLitrosDisp.Location = new System.Drawing.Point(686, 501);
            this.txtLitrosDisp.Multiline = true;
            this.txtLitrosDisp.Name = "txtLitrosDisp";
            this.txtLitrosDisp.Size = new System.Drawing.Size(195, 33);
            this.txtLitrosDisp.TabIndex = 8;
            // 
            // txtLitrosMin
            // 
            this.txtLitrosMin.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLitrosMin.Location = new System.Drawing.Point(940, 501);
            this.txtLitrosMin.Multiline = true;
            this.txtLitrosMin.Name = "txtLitrosMin";
            this.txtLitrosMin.Size = new System.Drawing.Size(195, 33);
            this.txtLitrosMin.TabIndex = 9;
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodProducto.Location = new System.Drawing.Point(457, 232);
            this.TxtCodProducto.Multiline = true;
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.Size = new System.Drawing.Size(166, 33);
            this.TxtCodProducto.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(193, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 57);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreProd.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNombreProd.Location = new System.Drawing.Point(935, 287);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(241, 26);
            this.lblNombreProd.TabIndex = 17;
            this.lblNombreProd.Text = "No se selecciono producto";
            this.lblNombreProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::lubricar.Properties.Resources.BtnBuscarIcon;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(629, 217);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 48);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.BackgroundImage = global::lubricar.Properties.Resources.BtnRecargarIcon;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Location = new System.Drawing.Point(219, 271);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(54, 48);
            this.btnRecargar.TabIndex = 3;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // MenuControlDeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.PantallaControlDeStockNueva2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCodProducto);
            this.Controls.Add(this.txtLitrosMin);
            this.Controls.Add(this.txtLitrosDisp);
            this.Controls.Add(this.txbCantMinima);
            this.Controls.Add(this.txbCant);
            this.Controls.Add(this.txbPrecioList);
            this.Controls.Add(this.txbPrecioVent);
            this.Controls.Add(this.DgvControlDeStock);
            this.Controls.Add(this.btnConfirmar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuControlDeStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuControlDeStock";
            this.Load += new System.EventHandler(this.MenuControlDeStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvControlDeStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView DgvControlDeStock;
        private System.Windows.Forms.TextBox txbPrecioVent;
        private System.Windows.Forms.TextBox txbPrecioList;
        private System.Windows.Forms.TextBox txbCant;
        private System.Windows.Forms.TextBox txbCantMinima;
        private System.Windows.Forms.TextBox txtLitrosDisp;
        private System.Windows.Forms.TextBox txtLitrosMin;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRecargar;
    }
}