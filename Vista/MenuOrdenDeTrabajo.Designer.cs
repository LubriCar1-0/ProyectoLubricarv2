namespace Vista
{
    partial class MenuOrdenDeTrabajo
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
            this.txbPatente = new System.Windows.Forms.TextBox();
            this.txbEmpleado = new System.Windows.Forms.TextBox();
            this.txbVehiculo = new System.Windows.Forms.TextBox();
            this.TxbDescripcion = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.DtpFechaDeInicio = new System.Windows.Forms.DateTimePicker();
            this.grpProductos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdCat = new System.Windows.Forms.Label();
            this.lblIdproducto = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblTEXTOlitros = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnagregalista = new System.Windows.Forms.Button();
            this.lblTEXTdisponible = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecargarProd = new System.Windows.Forms.Button();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.cmbCategoriaPrd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpPresupuesto = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarLista = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.lblidOrdenTrab = new System.Windows.Forms.Label();
            this.grpProductos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPatente
            // 
            this.txbPatente.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txbPatente.Location = new System.Drawing.Point(804, 257);
            this.txbPatente.Multiline = true;
            this.txbPatente.Name = "txbPatente";
            this.txbPatente.Size = new System.Drawing.Size(208, 34);
            this.txbPatente.TabIndex = 20;
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleado.Location = new System.Drawing.Point(1198, 257);
            this.txbEmpleado.Multiline = true;
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.Size = new System.Drawing.Size(208, 34);
            this.txbEmpleado.TabIndex = 21;
            // 
            // txbVehiculo
            // 
            this.txbVehiculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVehiculo.Location = new System.Drawing.Point(420, 257);
            this.txbVehiculo.Multiline = true;
            this.txbVehiculo.Name = "txbVehiculo";
            this.txbVehiculo.Size = new System.Drawing.Size(208, 34);
            this.txbVehiculo.TabIndex = 22;
            // 
            // TxbDescripcion
            // 
            this.TxbDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbDescripcion.Location = new System.Drawing.Point(804, 356);
            this.TxbDescripcion.Multiline = true;
            this.TxbDescripcion.Name = "TxbDescripcion";
            this.TxbDescripcion.Size = new System.Drawing.Size(319, 85);
            this.TxbDescripcion.TabIndex = 23;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(1198, 356);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(208, 36);
            this.cmbEstado.TabIndex = 24;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // DtpFechaDeInicio
            // 
            this.DtpFechaDeInicio.Location = new System.Drawing.Point(420, 353);
            this.DtpFechaDeInicio.Name = "DtpFechaDeInicio";
            this.DtpFechaDeInicio.Size = new System.Drawing.Size(221, 20);
            this.DtpFechaDeInicio.TabIndex = 25;
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
            this.grpProductos.ForeColor = System.Drawing.Color.Black;
            this.grpProductos.Location = new System.Drawing.Point(261, 457);
            this.grpProductos.Name = "grpProductos";
            this.grpProductos.Size = new System.Drawing.Size(706, 514);
            this.grpProductos.TabIndex = 26;
            this.grpProductos.TabStop = false;
            this.grpProductos.Text = "Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.lblIdCat);
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
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 174);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionado";
            // 
            // lblIdCat
            // 
            this.lblIdCat.AutoSize = true;
            this.lblIdCat.Location = new System.Drawing.Point(420, 131);
            this.lblIdCat.Name = "lblIdCat";
            this.lblIdCat.Size = new System.Drawing.Size(60, 36);
            this.lblIdCat.TabIndex = 36;
            this.lblIdCat.Text = "Idp";
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
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(187, 135);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(85, 35);
            this.txtCantidad.TabIndex = 34;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
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
            this.btnagregalista.Click += new System.EventHandler(this.btnagregalista_Click_1);
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
            this.btnRecargarProd.Click += new System.EventHandler(this.btnRecargarProd_Click_1);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProd.BackgroundImage = global::Vista.Properties.Resources.BtnBuscarIcon;
            this.btnBuscarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProd.Location = new System.Drawing.Point(618, 68);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(54, 48);
            this.btnBuscarProd.TabIndex = 14;
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click_1);
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
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 158);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(681, 156);
            this.dgvProductos.TabIndex = 6;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
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
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F);
            this.textBox3.Location = new System.Drawing.Point(426, 804);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 48);
            this.textBox3.TabIndex = 23;
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProd.Location = new System.Drawing.Point(530, 120);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(142, 35);
            this.txtCodigoProd.TabIndex = 16;
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
            this.cmbCategoriaPrd.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaPrd_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(431, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(75, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Categoria:";
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
            // grpPresupuesto
            // 
            this.grpPresupuesto.BackColor = System.Drawing.Color.NavajoWhite;
            this.grpPresupuesto.Controls.Add(this.btnCancelar);
            this.grpPresupuesto.Controls.Add(this.btnGuardarLista);
            this.grpPresupuesto.Controls.Add(this.dgvVentas);
            this.grpPresupuesto.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.grpPresupuesto.Location = new System.Drawing.Point(973, 528);
            this.grpPresupuesto.Name = "grpPresupuesto";
            this.grpPresupuesto.Size = new System.Drawing.Size(628, 388);
            this.grpPresupuesto.TabIndex = 28;
            this.grpPresupuesto.TabStop = false;
            this.grpPresupuesto.Text = "Lista De Productos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(372, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 46);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarLista
            // 
            this.btnGuardarLista.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarLista.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarLista.Location = new System.Drawing.Point(65, 284);
            this.btnGuardarLista.Name = "btnGuardarLista";
            this.btnGuardarLista.Size = new System.Drawing.Size(176, 46);
            this.btnGuardarLista.TabIndex = 20;
            this.btnGuardarLista.Text = "Confirmar";
            this.btnGuardarLista.UseVisualStyleBackColor = true;
            this.btnGuardarLista.Click += new System.EventHandler(this.btnGuardarLista_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(13, 32);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 62;
            this.dgvVentas.Size = new System.Drawing.Size(597, 240);
            this.dgvVentas.TabIndex = 0;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(265, 177);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 29;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblidOrdenTrab
            // 
            this.lblidOrdenTrab.AutoSize = true;
            this.lblidOrdenTrab.Location = new System.Drawing.Point(311, 307);
            this.lblidOrdenTrab.Name = "lblidOrdenTrab";
            this.lblidOrdenTrab.Size = new System.Drawing.Size(35, 13);
            this.lblidOrdenTrab.TabIndex = 30;
            this.lblidOrdenTrab.Text = "label1";
            // 
            // MenuOrdenDeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.MenuOrdenDeTrabajo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblidOrdenTrab);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.grpPresupuesto);
            this.Controls.Add(this.grpProductos);
            this.Controls.Add(this.DtpFechaDeInicio);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.TxbDescripcion);
            this.Controls.Add(this.txbVehiculo);
            this.Controls.Add(this.txbEmpleado);
            this.Controls.Add(this.txbPatente);
            this.DoubleBuffered = true;
            this.Name = "MenuOrdenDeTrabajo";
            this.Text = "MenuOrdenDeTrabajo";
            this.Load += new System.EventHandler(this.MenuOrdenDeTrabajo_Load);
            this.grpProductos.ResumeLayout(false);
            this.grpProductos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpPresupuesto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPatente;
        private System.Windows.Forms.TextBox txbEmpleado;
        private System.Windows.Forms.TextBox txbVehiculo;
        private System.Windows.Forms.TextBox TxbDescripcion;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker DtpFechaDeInicio;
        private System.Windows.Forms.GroupBox grpProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIdCat;
        private System.Windows.Forms.Label lblIdproducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblTEXTOlitros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnagregalista;
        private System.Windows.Forms.Label lblTEXTdisponible;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecargarProd;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.ComboBox cmbCategoriaPrd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpPresupuesto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarLista;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label lblidOrdenTrab;
    }
}