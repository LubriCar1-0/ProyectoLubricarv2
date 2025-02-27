namespace Vista
{
    partial class MenuVentaServicio
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
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblLubripts = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.grpPresupuesto = new System.Windows.Forms.GroupBox();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.btnCargaVenta = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListVentas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnGuardarMano = new System.Windows.Forms.Button();
            this.txbManoDeObra = new System.Windows.Forms.TextBox();
            this.lblManoDeObra = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblLubriGana = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbCliente.SuspendLayout();
            this.grpPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCliente
            // 
            this.gpbCliente.BackColor = System.Drawing.Color.NavajoWhite;
            this.gpbCliente.Controls.Add(this.lblIdCliente);
            this.gpbCliente.Controls.Add(this.lblNombreCliente);
            this.gpbCliente.Controls.Add(this.lblLubripts);
            this.gpbCliente.Controls.Add(this.label11);
            this.gpbCliente.Controls.Add(this.label22);
            this.gpbCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.ForeColor = System.Drawing.Color.OrangeRed;
            this.gpbCliente.Location = new System.Drawing.Point(609, 131);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(529, 122);
            this.gpbCliente.TabIndex = 34;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Cliente";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(11, 58);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(0, 28);
            this.lblIdCliente.TabIndex = 32;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNombreCliente.Location = new System.Drawing.Point(226, 38);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(296, 28);
            this.lblNombreCliente.TabIndex = 10;
            this.lblNombreCliente.Text = "No hay cliente seleccionado";
            this.lblNombreCliente.Click += new System.EventHandler(this.lblNombreCliente_Click);
            // 
            // lblLubripts
            // 
            this.lblLubripts.AutoSize = true;
            this.lblLubripts.BackColor = System.Drawing.Color.Transparent;
            this.lblLubripts.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblLubripts.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLubripts.Location = new System.Drawing.Point(226, 73);
            this.lblLubripts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLubripts.Name = "lblLubripts";
            this.lblLubripts.Size = new System.Drawing.Size(296, 28);
            this.lblLubripts.TabIndex = 31;
            this.lblLubripts.Text = "No hay cliente seleccionado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(7, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 28);
            this.label11.TabIndex = 9;
            this.label11.Text = "Cliente seleccionado:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label22.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label22.Location = new System.Drawing.Point(95, 69);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(138, 28);
            this.label22.TabIndex = 28;
            this.label22.Text = "LubriPuntos:";
            // 
            // grpPresupuesto
            // 
            this.grpPresupuesto.BackColor = System.Drawing.Color.NavajoWhite;
            this.grpPresupuesto.Controls.Add(this.lblLubriGana);
            this.grpPresupuesto.Controls.Add(this.label4);
            this.grpPresupuesto.Controls.Add(this.btnPresupuesto);
            this.grpPresupuesto.Controls.Add(this.btnCargaVenta);
            this.grpPresupuesto.Controls.Add(this.lblTotal);
            this.grpPresupuesto.Controls.Add(this.lblIVA);
            this.grpPresupuesto.Controls.Add(this.lblSubTotal);
            this.grpPresupuesto.Controls.Add(this.label17);
            this.grpPresupuesto.Controls.Add(this.label16);
            this.grpPresupuesto.Controls.Add(this.label15);
            this.grpPresupuesto.Controls.Add(this.label14);
            this.grpPresupuesto.Controls.Add(this.label13);
            this.grpPresupuesto.Controls.Add(this.label1);
            this.grpPresupuesto.Controls.Add(this.dgvListVentas);
            this.grpPresupuesto.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPresupuesto.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpPresupuesto.Location = new System.Drawing.Point(609, 259);
            this.grpPresupuesto.Name = "grpPresupuesto";
            this.grpPresupuesto.Size = new System.Drawing.Size(529, 468);
            this.grpPresupuesto.TabIndex = 33;
            this.grpPresupuesto.TabStop = false;
            this.grpPresupuesto.Text = "Presupuesto";
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.btnPresupuesto.Location = new System.Drawing.Point(41, 398);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(259, 35);
            this.btnPresupuesto.TabIndex = 22;
            this.btnPresupuesto.Text = "Imprimir Presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // btnCargaVenta
            // 
            this.btnCargaVenta.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaVenta.ForeColor = System.Drawing.Color.Black;
            this.btnCargaVenta.Location = new System.Drawing.Point(369, 398);
            this.btnCargaVenta.Name = "btnCargaVenta";
            this.btnCargaVenta.Size = new System.Drawing.Size(131, 35);
            this.btnCargaVenta.TabIndex = 20;
            this.btnCargaVenta.Text = "Confirmar";
            this.btnCargaVenta.UseVisualStyleBackColor = true;
            this.btnCargaVenta.Click += new System.EventHandler(this.btnCargaVenta_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTotal.Location = new System.Drawing.Point(432, 306);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 28);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "0,0";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblIVA.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblIVA.Location = new System.Drawing.Point(205, 306);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(41, 28);
            this.lblIVA.TabIndex = 18;
            this.lblIVA.Text = "0,0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblSubTotal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSubTotal.Location = new System.Drawing.Point(60, 306);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(41, 28);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "0,0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label17.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label17.Location = new System.Drawing.Point(400, 306);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 28);
            this.label17.TabIndex = 16;
            this.label17.Text = "$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label16.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label16.Location = new System.Drawing.Point(176, 306);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 28);
            this.label16.TabIndex = 15;
            this.label16.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label15.Location = new System.Drawing.Point(28, 306);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 28);
            this.label15.TabIndex = 14;
            this.label15.Text = "$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label14.Location = new System.Drawing.Point(411, 278);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 28);
            this.label14.TabIndex = 13;
            this.label14.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(158, 278);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 28);
            this.label13.TabIndex = 12;
            this.label13.Text = "IVA 21%:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(12, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Subtotal:";
            // 
            // dgvListVentas
            // 
            this.dgvListVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListVentas.Location = new System.Drawing.Point(15, 38);
            this.dgvListVentas.Name = "dgvListVentas";
            this.dgvListVentas.RowHeadersWidth = 62;
            this.dgvListVentas.Size = new System.Drawing.Size(503, 240);
            this.dgvListVentas.TabIndex = 0;
            this.dgvListVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListVentas_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.lblPatente);
            this.groupBox1.Controls.Add(this.btnGuardarMano);
            this.groupBox1.Controls.Add(this.txbManoDeObra);
            this.groupBox1.Controls.Add(this.lblManoDeObra);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(186, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 419);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculo";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.BackColor = System.Drawing.Color.Transparent;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblPatente.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPatente.Location = new System.Drawing.Point(110, 101);
            this.lblPatente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(221, 28);
            this.lblPatente.TabIndex = 39;
            this.lblPatente.Text = "Patente del Vehiculo";
            // 
            // btnGuardarMano
            // 
            this.btnGuardarMano.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMano.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarMano.Location = new System.Drawing.Point(214, 353);
            this.btnGuardarMano.Name = "btnGuardarMano";
            this.btnGuardarMano.Size = new System.Drawing.Size(117, 35);
            this.btnGuardarMano.TabIndex = 38;
            this.btnGuardarMano.Text = "Guardar";
            this.btnGuardarMano.UseVisualStyleBackColor = true;
            this.btnGuardarMano.Click += new System.EventHandler(this.btnGuardarMano_Click);
            // 
            // txbManoDeObra
            // 
            this.txbManoDeObra.Location = new System.Drawing.Point(6, 353);
            this.txbManoDeObra.Multiline = true;
            this.txbManoDeObra.Name = "txbManoDeObra";
            this.txbManoDeObra.Size = new System.Drawing.Size(184, 35);
            this.txbManoDeObra.TabIndex = 37;
            // 
            // lblManoDeObra
            // 
            this.lblManoDeObra.AutoSize = true;
            this.lblManoDeObra.BackColor = System.Drawing.Color.Transparent;
            this.lblManoDeObra.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblManoDeObra.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblManoDeObra.Location = new System.Drawing.Point(7, 321);
            this.lblManoDeObra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManoDeObra.Name = "lblManoDeObra";
            this.lblManoDeObra.Size = new System.Drawing.Size(163, 28);
            this.lblManoDeObra.TabIndex = 36;
            this.lblManoDeObra.Text = "Mano de Obra:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 172);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 139);
            this.textBox1.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(7, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 28);
            this.label9.TabIndex = 34;
            this.label9.Text = "Trabajo Realizado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(7, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Patente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 32;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblMarca.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMarca.Location = new System.Drawing.Point(96, 41);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(210, 28);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca Del Vehiculo";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblModelo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblModelo.Location = new System.Drawing.Point(110, 73);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(221, 28);
            this.lblModelo.TabIndex = 31;
            this.lblModelo.Text = "Modelo del Vehiculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(7, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Marca:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(7, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 28);
            this.label8.TabIndex = 28;
            this.label8.Text = "Modelo:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.btnVolver.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(186, 131);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(52, 51);
            this.btnVolver.TabIndex = 36;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblLubriGana
            // 
            this.lblLubriGana.AutoSize = true;
            this.lblLubriGana.BackColor = System.Drawing.Color.Transparent;
            this.lblLubriGana.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblLubriGana.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLubriGana.Location = new System.Drawing.Point(240, 355);
            this.lblLubriGana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLubriGana.Name = "lblLubriGana";
            this.lblLubriGana.Size = new System.Drawing.Size(238, 28);
            this.lblLubriGana.TabIndex = 36;
            this.lblLubriGana.Text = "No hay valor asignado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(36, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "Suma LubriPuntos: ";
            // 
            // MenuVentaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.MenuVentaServicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.grpPresupuesto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuVentaServicio";
            this.Text = "MenuVentaServicio";
            this.Load += new System.EventHandler(this.MenuVentaServicio_Load);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.grpPresupuesto.ResumeLayout(false);
            this.grpPresupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblLubripts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox grpPresupuesto;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Button btnCargaVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbManoDeObra;
        private System.Windows.Forms.Label lblManoDeObra;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarMano;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblLubriGana;
        private System.Windows.Forms.Label label4;
    }
}