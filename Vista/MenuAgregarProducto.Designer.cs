namespace Vista
{
    partial class MenuAgregarProducto
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
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.TxtMarcaProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtCantMin = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.TxtPrecioList = new System.Windows.Forms.TextBox();
            this.txtPrecioVent = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcodigoProducto = new System.Windows.Forms.TextBox();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.Location = new System.Drawing.Point(750, 289);
            this.TxtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(282, 35);
            this.TxtNombreProducto.TabIndex = 0;
            // 
            // TxtMarcaProducto
            // 
            this.TxtMarcaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarcaProducto.Location = new System.Drawing.Point(1184, 289);
            this.TxtMarcaProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMarcaProducto.Name = "TxtMarcaProducto";
            this.TxtMarcaProducto.Size = new System.Drawing.Size(282, 35);
            this.TxtMarcaProducto.TabIndex = 1;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(316, 406);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(150, 35);
            this.TxtCantidad.TabIndex = 2;
            // 
            // TxtCantMin
            // 
            this.TxtCantMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantMin.Location = new System.Drawing.Point(750, 406);
            this.TxtCantMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCantMin.Name = "TxtCantMin";
            this.TxtCantMin.Size = new System.Drawing.Size(150, 35);
            this.TxtCantMin.TabIndex = 3;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(520, 583);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(696, 33);
            this.TxtDescripcion.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Vista.Properties.Resources.BtnAgregar;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(978, 172);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 58);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(316, 289);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(232, 28);
            this.cmbCategoria.TabIndex = 8;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // TxtPrecioList
            // 
            this.TxtPrecioList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioList.Location = new System.Drawing.Point(316, 518);
            this.TxtPrecioList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecioList.Name = "TxtPrecioList";
            this.TxtPrecioList.Size = new System.Drawing.Size(150, 35);
            this.TxtPrecioList.TabIndex = 9;
            // 
            // txtPrecioVent
            // 
            this.txtPrecioVent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVent.Location = new System.Drawing.Point(750, 518);
            this.txtPrecioVent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioVent.Name = "txtPrecioVent";
            this.txtPrecioVent.Size = new System.Drawing.Size(150, 35);
            this.txtPrecioVent.TabIndex = 10;
            // 
            // txtLitros
            // 
            this.txtLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLitros.Location = new System.Drawing.Point(1246, 406);
            this.txtLitros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(150, 35);
            this.txtLitros.TabIndex = 11;
            this.txtLitros.Text = "0.0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(236, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 88);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtcodigoProducto
            // 
            this.txtcodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoProducto.Location = new System.Drawing.Point(1246, 518);
            this.txtcodigoProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodigoProducto.Name = "txtcodigoProducto";
            this.txtcodigoProducto.Size = new System.Drawing.Size(150, 35);
            this.txtcodigoProducto.TabIndex = 13;
            // 
            // DGVProductos
            // 
            this.DGVProductos.AllowUserToAddRows = false;
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(316, 642);
            this.DGVProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.RowHeadersWidth = 62;
            this.DGVProductos.Size = new System.Drawing.Size(1150, 335);
            this.DGVProductos.TabIndex = 14;
            this.DGVProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellContentClick);
            // 
            // MenuAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.MenuAgregarProductos1;
            this.ClientSize = new System.Drawing.Size(1744, 1020);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.txtcodigoProducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtPrecioVent);
            this.Controls.Add(this.TxtPrecioList);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCantMin);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtMarcaProducto);
            this.Controls.Add(this.TxtNombreProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuAgregarProducto";
            this.Text = "MenuAgregarProducto";
            this.Load += new System.EventHandler(this.MenuAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.TextBox TxtMarcaProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtCantMin;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox TxtPrecioList;
        private System.Windows.Forms.TextBox txtPrecioVent;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcodigoProducto;
        private System.Windows.Forms.DataGridView DGVProductos;
    }
}