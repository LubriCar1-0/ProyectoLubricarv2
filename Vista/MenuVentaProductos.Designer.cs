namespace Vista
{
    partial class MenuVentaProductos
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
            this.BtnVolver = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnAgregarclient = new System.Windows.Forms.Button();
            this.cmbCategoriaPrd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTEXTdisponible = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.grpProductos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdproducto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblTEXTOlitros = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.btnagregalista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecargarProd = new System.Windows.Forms.Button();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.grpPresupuesto = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblLubripts = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grpProductos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(114, 168);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(73, 58);
            this.BtnVolver.TabIndex = 4;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 164);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(797, 243);
            this.dgvProductos.TabIndex = 6;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(67, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dni Cliente:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(25, 93);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.Size = new System.Drawing.Size(751, 113);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::Vista.Properties.Resources.BtnBuscarIcon;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(685, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 48);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(259, 41);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(409, 35);
            this.txtCliente.TabIndex = 11;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // btnAgregarclient
            // 
            this.btnAgregarclient.BackgroundImage = global::Vista.Properties.Resources.BtnAgregarIcon;
            this.btnAgregarclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarclient.Location = new System.Drawing.Point(745, 39);
            this.btnAgregarclient.Name = "btnAgregarclient";
            this.btnAgregarclient.Size = new System.Drawing.Size(53, 48);
            this.btnAgregarclient.TabIndex = 12;
            this.btnAgregarclient.UseVisualStyleBackColor = true;
            // 
            // cmbCategoriaPrd
            // 
            this.cmbCategoriaPrd.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaPrd.FormattingEnabled = true;
            this.cmbCategoriaPrd.Location = new System.Drawing.Point(198, 122);
            this.cmbCategoriaPrd.Name = "cmbCategoriaPrd";
            this.cmbCategoriaPrd.Size = new System.Drawing.Size(226, 33);
            this.cmbCategoriaPrd.TabIndex = 13;
            this.cmbCategoriaPrd.Text = "seleccionar categoria";
            this.cmbCategoriaPrd.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaPrd_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(79, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(453, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Codigo:";
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProd.Location = new System.Drawing.Point(555, 120);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(142, 35);
            this.txtCodigoProd.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Seleccionado:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblProducto.Location = new System.Drawing.Point(204, 50);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(252, 30);
            this.lblProducto.TabIndex = 19;
            this.lblProducto.Text = "Producto seleccionado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 809);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 41);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cantidad:";
            // 
            // lblTEXTdisponible
            // 
            this.lblTEXTdisponible.AutoSize = true;
            this.lblTEXTdisponible.BackColor = System.Drawing.Color.Transparent;
            this.lblTEXTdisponible.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTEXTdisponible.ForeColor = System.Drawing.Color.Black;
            this.lblTEXTdisponible.Location = new System.Drawing.Point(39, 91);
            this.lblTEXTdisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTEXTdisponible.Name = "lblTEXTdisponible";
            this.lblTEXTdisponible.Size = new System.Drawing.Size(131, 30);
            this.lblTEXTdisponible.TabIndex = 21;
            this.lblTEXTdisponible.Text = "Disponible:";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.BackColor = System.Drawing.Color.Transparent;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDisponible.Location = new System.Drawing.Point(204, 91);
            this.lblDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(26, 30);
            this.lblDisponible.TabIndex = 22;
            this.lblDisponible.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F);
            this.textBox3.Location = new System.Drawing.Point(426, 804);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 48);
            this.textBox3.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1419, 866);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(347, 110);
            this.button4.TabIndex = 24;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // grpProductos
            // 
            this.grpProductos.BackColor = System.Drawing.Color.Transparent;
            this.grpProductos.Controls.Add(this.groupBox1);
            this.grpProductos.Controls.Add(this.btnRecargarProd);
            this.grpProductos.Controls.Add(this.btnBuscarProd);
            this.grpProductos.Controls.Add(this.txtNombreProd);
            this.grpProductos.Controls.Add(this.label21);
            this.grpProductos.Controls.Add(this.dgvProductos);
            this.grpProductos.Controls.Add(this.button4);
            this.grpProductos.Controls.Add(this.textBox3);
            this.grpProductos.Controls.Add(this.txtCodigoProd);
            this.grpProductos.Controls.Add(this.cmbCategoriaPrd);
            this.grpProductos.Controls.Add(this.label5);
            this.grpProductos.Controls.Add(this.label4);
            this.grpProductos.Controls.Add(this.label8);
            this.grpProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grpProductos.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpProductos.Location = new System.Drawing.Point(125, 436);
            this.grpProductos.Name = "grpProductos";
            this.grpProductos.Size = new System.Drawing.Size(813, 593);
            this.grpProductos.TabIndex = 25;
            this.grpProductos.TabStop = false;
            this.grpProductos.Text = "Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.lblIdproducto);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.lblTEXTOlitros);
            this.groupBox1.Controls.Add(this.lblLitros);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnagregalista);
            this.groupBox1.Controls.Add(this.lblTEXTdisponible);
            this.groupBox1.Controls.Add(this.lblDisponible);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(70, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 174);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionado";
            // 
            // lblIdproducto
            // 
            this.lblIdproducto.AutoSize = true;
            this.lblIdproducto.BackColor = System.Drawing.Color.Transparent;
            this.lblIdproducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdproducto.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblIdproducto.Location = new System.Drawing.Point(170, 50);
            this.lblIdproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdproducto.Name = "lblIdproducto";
            this.lblIdproducto.Size = new System.Drawing.Size(26, 30);
            this.lblIdproducto.TabIndex = 35;
            this.lblIdproducto.Text = "0";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(187, 135);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(85, 35);
            this.txtCantidad.TabIndex = 34;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblTEXTOlitros
            // 
            this.lblTEXTOlitros.AutoSize = true;
            this.lblTEXTOlitros.BackColor = System.Drawing.Color.Transparent;
            this.lblTEXTOlitros.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTEXTOlitros.ForeColor = System.Drawing.Color.Black;
            this.lblTEXTOlitros.Location = new System.Drawing.Point(95, 91);
            this.lblTEXTOlitros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTEXTOlitros.Name = "lblTEXTOlitros";
            this.lblTEXTOlitros.Size = new System.Drawing.Size(75, 30);
            this.lblTEXTOlitros.TabIndex = 32;
            this.lblTEXTOlitros.Text = "Litros:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.BackColor = System.Drawing.Color.Transparent;
            this.lblLitros.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitros.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLitros.Location = new System.Drawing.Point(204, 91);
            this.lblLitros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(26, 30);
            this.lblLitros.TabIndex = 33;
            this.lblLitros.Text = "0";
            // 
            // btnagregalista
            // 
            this.btnagregalista.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregalista.ForeColor = System.Drawing.Color.Black;
            this.btnagregalista.Location = new System.Drawing.Point(524, 112);
            this.btnagregalista.Name = "btnagregalista";
            this.btnagregalista.Size = new System.Drawing.Size(154, 56);
            this.btnagregalista.TabIndex = 25;
            this.btnagregalista.Text = "Agregar";
            this.btnagregalista.UseVisualStyleBackColor = true;
            this.btnagregalista.Click += new System.EventHandler(this.btnagregalista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cantidad:";
            // 
            // btnRecargarProd
            // 
            this.btnRecargarProd.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargarProd.BackgroundImage = global::Vista.Properties.Resources.BtnRecargarIcon;
            this.btnRecargarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargarProd.Location = new System.Drawing.Point(14, 86);
            this.btnRecargarProd.Name = "btnRecargarProd";
            this.btnRecargarProd.Size = new System.Drawing.Size(54, 48);
            this.btnRecargarProd.TabIndex = 31;
            this.btnRecargarProd.UseVisualStyleBackColor = false;
            this.btnRecargarProd.Click += new System.EventHandler(this.btnRecargarProd_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProd.BackgroundImage = global::Vista.Properties.Resources.BtnBuscarIcon;
            this.btnBuscarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProd.Location = new System.Drawing.Point(729, 110);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(54, 48);
            this.btnBuscarProd.TabIndex = 14;
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.Location = new System.Drawing.Point(198, 68);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(311, 35);
            this.txtNombreProd.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(79, 71);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 30);
            this.label21.TabIndex = 29;
            this.label21.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnRecargar);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.dgvClientes);
            this.groupBox2.Controls.Add(this.btnAgregarclient);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(119, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(813, 212);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.BackgroundImage = global::Vista.Properties.Resources.BtnRecargarIcon;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Location = new System.Drawing.Point(8, 40);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(54, 48);
            this.btnRecargar.TabIndex = 13;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // grpPresupuesto
            // 
            this.grpPresupuesto.BackColor = System.Drawing.Color.NavajoWhite;
            this.grpPresupuesto.Controls.Add(this.button8);
            this.grpPresupuesto.Controls.Add(this.btnCancelar);
            this.grpPresupuesto.Controls.Add(this.button6);
            this.grpPresupuesto.Controls.Add(this.lblTotal);
            this.grpPresupuesto.Controls.Add(this.lblIVA);
            this.grpPresupuesto.Controls.Add(this.lblSubTotal);
            this.grpPresupuesto.Controls.Add(this.label17);
            this.grpPresupuesto.Controls.Add(this.label16);
            this.grpPresupuesto.Controls.Add(this.label15);
            this.grpPresupuesto.Controls.Add(this.label14);
            this.grpPresupuesto.Controls.Add(this.label13);
            this.grpPresupuesto.Controls.Add(this.label1);
            this.grpPresupuesto.Controls.Add(this.dgvVentas);
            this.grpPresupuesto.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPresupuesto.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpPresupuesto.Location = new System.Drawing.Point(970, 507);
            this.grpPresupuesto.Name = "grpPresupuesto";
            this.grpPresupuesto.Size = new System.Drawing.Size(824, 422);
            this.grpPresupuesto.TabIndex = 27;
            this.grpPresupuesto.TabStop = false;
            this.grpPresupuesto.Text = "Presupuesto";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(4, 369);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(259, 46);
            this.button8.TabIndex = 22;
            this.button8.Text = "Imprimir Presupuesto";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(639, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 46);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(457, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 46);
            this.button6.TabIndex = 20;
            this.button6.Text = "Confirmar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTotal.Location = new System.Drawing.Point(668, 322);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 35);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "0,0";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.lblIVA.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblIVA.Location = new System.Drawing.Point(410, 322);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(54, 35);
            this.lblIVA.TabIndex = 18;
            this.lblIVA.Text = "0,0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.lblSubTotal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSubTotal.Location = new System.Drawing.Point(116, 322);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(54, 35);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "0,0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.label17.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label17.Location = new System.Drawing.Point(636, 322);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 35);
            this.label17.TabIndex = 16;
            this.label17.Text = "$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.label16.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label16.Location = new System.Drawing.Point(381, 322);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 35);
            this.label16.TabIndex = 15;
            this.label16.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label15.Location = new System.Drawing.Point(84, 322);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 35);
            this.label15.TabIndex = 14;
            this.label15.Text = "$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.label14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label14.Location = new System.Drawing.Point(645, 278);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 35);
            this.label14.TabIndex = 13;
            this.label14.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(361, 278);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 35);
            this.label13.TabIndex = 12;
            this.label13.Text = "IVA 21%:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(66, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Subtotal:";
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(13, 32);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 62;
            this.dgvVentas.Size = new System.Drawing.Size(793, 240);
            this.dgvVentas.TabIndex = 0;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNombreCliente.Location = new System.Drawing.Point(404, 57);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(277, 36);
            this.lblNombreCliente.TabIndex = 10;
            this.lblNombreCliente.Text = "Nombre del cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(116, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(287, 35);
            this.label11.TabIndex = 9;
            this.label11.Text = "Cliente seleccionado:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label22.Location = new System.Drawing.Point(119, 120);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(253, 30);
            this.label22.TabIndex = 28;
            this.label22.Text = "Cantidad LubriPuntos: ";
            // 
            // lblLubripts
            // 
            this.lblLubripts.AutoSize = true;
            this.lblLubripts.BackColor = System.Drawing.Color.Transparent;
            this.lblLubripts.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLubripts.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLubripts.Location = new System.Drawing.Point(518, 120);
            this.lblLubripts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLubripts.Name = "lblLubripts";
            this.lblLubripts.Size = new System.Drawing.Size(37, 41);
            this.lblLubripts.TabIndex = 31;
            this.lblLubripts.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox4.Controls.Add(this.lblNombreCliente);
            this.groupBox4.Controls.Add(this.lblLubripts);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox4.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox4.Location = new System.Drawing.Point(970, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(824, 189);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente seleccionado";
            // 
            // MenuVentaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaVentaDeProductos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpPresupuesto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpProductos);
            this.Controls.Add(this.BtnVolver);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuVentaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuVentaProductos";
            this.Load += new System.EventHandler(this.MenuVentaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grpProductos.ResumeLayout(false);
            this.grpProductos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpPresupuesto.ResumeLayout(false);
            this.grpPresupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnAgregarclient;
        private System.Windows.Forms.ComboBox cmbCategoriaPrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTEXTdisponible;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox grpProductos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnagregalista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPresupuesto;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblLubripts;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnRecargarProd;
        private System.Windows.Forms.Label lblTEXTOlitros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIdproducto;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}