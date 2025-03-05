namespace Vista
{
    partial class MenuCanjeoLubriPuntos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecargarProduc = new System.Windows.Forms.Button();
            this.btnBuscarProduc = new System.Windows.Forms.Button();
            this.TxtFiltroProduc = new System.Windows.Forms.TextBox();
            this.DGVproductos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRecargarCliente = new System.Windows.Forms.Button();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.txtFiltroClientes = new System.Windows.Forms.TextBox();
            this.DGVclientes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCantidadCanje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPuntosProdu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLubriClientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclientes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnRecargarProduc);
            this.groupBox1.Controls.Add(this.btnBuscarProduc);
            this.groupBox1.Controls.Add(this.TxtFiltroProduc);
            this.groupBox1.Controls.Add(this.DGVproductos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(668, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 343);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Producto a canjear";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ingrese el codigo del producto:";
            // 
            // btnRecargarProduc
            // 
            this.btnRecargarProduc.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargarProduc.BackgroundImage = global::Vista.Properties.Resources.BtnRecargarIcon;
            this.btnRecargarProduc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargarProduc.Location = new System.Drawing.Point(370, 57);
            this.btnRecargarProduc.Name = "btnRecargarProduc";
            this.btnRecargarProduc.Size = new System.Drawing.Size(54, 48);
            this.btnRecargarProduc.TabIndex = 21;
            this.btnRecargarProduc.UseVisualStyleBackColor = false;
            this.btnRecargarProduc.Click += new System.EventHandler(this.btnRecargarProduc_Click);
            // 
            // btnBuscarProduc
            // 
            this.btnBuscarProduc.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProduc.BackgroundImage = global::Vista.Properties.Resources.BtnBuscarIcon;
            this.btnBuscarProduc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProduc.Location = new System.Drawing.Point(289, 57);
            this.btnBuscarProduc.Name = "btnBuscarProduc";
            this.btnBuscarProduc.Size = new System.Drawing.Size(54, 48);
            this.btnBuscarProduc.TabIndex = 19;
            this.btnBuscarProduc.UseVisualStyleBackColor = false;
            this.btnBuscarProduc.Click += new System.EventHandler(this.btnBuscarProduc_Click);
            // 
            // TxtFiltroProduc
            // 
            this.TxtFiltroProduc.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltroProduc.Location = new System.Drawing.Point(16, 72);
            this.TxtFiltroProduc.Multiline = true;
            this.TxtFiltroProduc.Name = "TxtFiltroProduc";
            this.TxtFiltroProduc.Size = new System.Drawing.Size(245, 33);
            this.TxtFiltroProduc.TabIndex = 14;
            // 
            // DGVproductos
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVproductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproductos.Location = new System.Drawing.Point(16, 115);
            this.DGVproductos.Name = "DGVproductos";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVproductos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVproductos.Size = new System.Drawing.Size(436, 199);
            this.DGVproductos.TabIndex = 0;
            this.DGVproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproductos_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BtnRecargarCliente);
            this.groupBox2.Controls.Add(this.BtnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtFiltroClientes);
            this.groupBox2.Controls.Add(this.DGVclientes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(186, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 343);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ingrese el dni del cliente:";
            // 
            // BtnRecargarCliente
            // 
            this.BtnRecargarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnRecargarCliente.BackgroundImage = global::Vista.Properties.Resources.BtnRecargarIcon;
            this.BtnRecargarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRecargarCliente.Location = new System.Drawing.Point(367, 61);
            this.BtnRecargarCliente.Name = "BtnRecargarCliente";
            this.BtnRecargarCliente.Size = new System.Drawing.Size(54, 48);
            this.BtnRecargarCliente.TabIndex = 21;
            this.BtnRecargarCliente.UseVisualStyleBackColor = false;
            this.BtnRecargarCliente.Click += new System.EventHandler(this.BtnRecargarCliente_Click);
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarCliente.BackgroundImage = global::Vista.Properties.Resources.BtnBuscarIcon;
            this.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(283, 61);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(54, 48);
            this.BtnBuscarCliente.TabIndex = 19;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // txtFiltroClientes
            // 
            this.txtFiltroClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroClientes.Location = new System.Drawing.Point(16, 72);
            this.txtFiltroClientes.Multiline = true;
            this.txtFiltroClientes.Name = "txtFiltroClientes";
            this.txtFiltroClientes.Size = new System.Drawing.Size(245, 33);
            this.txtFiltroClientes.TabIndex = 14;
            this.txtFiltroClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroClientes_KeyPress);
            // 
            // DGVclientes
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVclientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVclientes.Location = new System.Drawing.Point(16, 115);
            this.DGVclientes.Name = "DGVclientes";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVclientes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVclientes.Size = new System.Drawing.Size(429, 199);
            this.DGVclientes.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox3.Controls.Add(this.txtCantidadCanje);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblPuntosProdu);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblProducto);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblLubriClientes);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.BtnConfirmar);
            this.groupBox3.Controls.Add(this.lblNombreProd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox3.Location = new System.Drawing.Point(203, 534);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 211);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Canjear LubriPuntos";
            // 
            // txtCantidadCanje
            // 
            this.txtCantidadCanje.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadCanje.Location = new System.Drawing.Point(465, 134);
            this.txtCantidadCanje.Multiline = true;
            this.txtCantidadCanje.Name = "txtCantidadCanje";
            this.txtCantidadCanje.Size = new System.Drawing.Size(54, 45);
            this.txtCantidadCanje.TabIndex = 50;
            this.txtCantidadCanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadCanje_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(203, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 28);
            this.label7.TabIndex = 46;
            this.label7.Text = "Seleccione un producto";
            // 
            // lblPuntosProdu
            // 
            this.lblPuntosProdu.AutoSize = true;
            this.lblPuntosProdu.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntosProdu.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosProdu.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPuntosProdu.Location = new System.Drawing.Point(631, 80);
            this.lblPuntosProdu.Name = "lblPuntosProdu";
            this.lblPuntosProdu.Size = new System.Drawing.Size(241, 26);
            this.lblPuntosProdu.TabIndex = 45;
            this.lblPuntosProdu.Text = "No se selecciono producto";
            this.lblPuntosProdu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(554, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Valor:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblProducto.Location = new System.Drawing.Point(670, 38);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(241, 26);
            this.lblProducto.TabIndex = 43;
            this.lblProducto.Text = "No se selecciono producto";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(554, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 42;
            this.label3.Text = "Producto:";
            // 
            // lblLubriClientes
            // 
            this.lblLubriClientes.AutoSize = true;
            this.lblLubriClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblLubriClientes.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLubriClientes.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLubriClientes.Location = new System.Drawing.Point(284, 81);
            this.lblLubriClientes.Name = "lblLubriClientes";
            this.lblLubriClientes.Size = new System.Drawing.Size(221, 26);
            this.lblLubriClientes.TabIndex = 41;
            this.lblLubriClientes.Text = "No se selecciono cliente";
            this.lblLubriClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(2, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cantidad de Lubri-Puntos:";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackgroundImage = global::Vista.Properties.Resources.BtnConfirmar;
            this.BtnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(537, 132);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(161, 42);
            this.BtnConfirmar.TabIndex = 39;
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreProd.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNombreProd.Location = new System.Drawing.Point(235, 43);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(221, 26);
            this.lblNombreProd.TabIndex = 36;
            this.lblNombreProd.Text = "No se selecciono cliente";
            this.lblNombreProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(2, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 28);
            this.label9.TabIndex = 35;
            this.label9.Text = "Cliente seleccionado:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(186, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 52);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuCanjeoLubriPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.MenuCanjeoLubriPuntos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCanjeoLubriPuntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCanjeoLubriPuntos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclientes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecargarProduc;
        private System.Windows.Forms.Button btnBuscarProduc;
        private System.Windows.Forms.TextBox TxtFiltroProduc;
        private System.Windows.Forms.DataGridView DGVproductos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRecargarCliente;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.TextBox txtFiltroClientes;
        private System.Windows.Forms.DataGridView DGVclientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPuntosProdu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLubriClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadCanje;
    }
}