namespace Vista
{
    partial class MenuTurnosTrabajos
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.grpProductos = new System.Windows.Forms.GroupBox();
            this.btnVisualizarOrden = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbTrabajador = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxbDescripcion = new System.Windows.Forms.TextBox();
            this.DtpFechaCargada = new System.Windows.Forms.DateTimePicker();
            this.txbPatente = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.chbIniciados = new System.Windows.Forms.CheckBox();
            this.chbActivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.grpProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Image = global::Vista.Properties.Resources.BtnCrearOrden;
            this.BtnAgregar.Location = new System.Drawing.Point(521, 395);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(252, 44);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(739, 325);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(539, 26);
            this.dtpFecha.TabIndex = 21;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(532, 367);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.RowHeadersWidth = 62;
            this.dgvTurnos.RowTemplate.Height = 28;
            this.dgvTurnos.Size = new System.Drawing.Size(878, 183);
            this.dgvTurnos.TabIndex = 9;
            this.dgvTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellContentClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(652, 324);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(74, 30);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(628, 252);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(92, 30);
            this.lblVehiculo.TabIndex = 14;
            this.lblVehiculo.Text = "Patente";
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCliente.Location = new System.Drawing.Point(739, 181);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(540, 35);
            this.txtTelCliente.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::Vista.Properties.Resources.BtnBuscarIcon;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(1332, 180);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 48);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.BackgroundImage = global::Vista.Properties.Resources.BtnRecargarIcon;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Location = new System.Drawing.Point(517, 173);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(54, 48);
            this.btnRecargar.TabIndex = 13;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click_1);
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(627, 184);
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(106, 30);
            this.lblTelefonoCliente.TabIndex = 8;
            this.lblTelefonoCliente.Text = "Telefono";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(258, 163);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 22;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(740, 249);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(539, 35);
            this.txtPatente.TabIndex = 23;
            // 
            // grpProductos
            // 
            this.grpProductos.BackColor = System.Drawing.Color.Transparent;
            this.grpProductos.Controls.Add(this.btnVisualizarOrden);
            this.grpProductos.Controls.Add(this.button4);
            this.grpProductos.Controls.Add(this.cmbTrabajador);
            this.grpProductos.Controls.Add(this.textBox3);
            this.grpProductos.Controls.Add(this.label8);
            this.grpProductos.Controls.Add(this.TxbDescripcion);
            this.grpProductos.Controls.Add(this.DtpFechaCargada);
            this.grpProductos.Controls.Add(this.txbPatente);
            this.grpProductos.Controls.Add(this.txbNombre);
            this.grpProductos.Controls.Add(this.txbApellido);
            this.grpProductos.Controls.Add(this.BtnAgregar);
            this.grpProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grpProductos.ForeColor = System.Drawing.Color.Black;
            this.grpProductos.Location = new System.Drawing.Point(310, 584);
            this.grpProductos.Name = "grpProductos";
            this.grpProductos.Size = new System.Drawing.Size(1306, 445);
            this.grpProductos.TabIndex = 26;
            this.grpProductos.TabStop = false;
            this.grpProductos.Text = "Orden De Trabajo";
            // 
            // btnVisualizarOrden
            // 
            this.btnVisualizarOrden.FlatAppearance.BorderSize = 0;
            this.btnVisualizarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarOrden.Image = global::Vista.Properties.Resources.BtnVisualizarOrden;
            this.btnVisualizarOrden.Location = new System.Drawing.Point(521, 395);
            this.btnVisualizarOrden.Name = "btnVisualizarOrden";
            this.btnVisualizarOrden.Size = new System.Drawing.Size(252, 44);
            this.btnVisualizarOrden.TabIndex = 26;
            this.btnVisualizarOrden.UseVisualStyleBackColor = true;
            this.btnVisualizarOrden.Click += new System.EventHandler(this.btnVisualizarOrden_Click);
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
            // cmbTrabajador
            // 
            this.cmbTrabajador.FormattingEnabled = true;
            this.cmbTrabajador.Location = new System.Drawing.Point(494, 259);
            this.cmbTrabajador.Name = "cmbTrabajador";
            this.cmbTrabajador.Size = new System.Drawing.Size(208, 44);
            this.cmbTrabajador.TabIndex = 25;
            this.cmbTrabajador.SelectedIndexChanged += new System.EventHandler(this.cmbTrabajador_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F);
            this.textBox3.Location = new System.Drawing.Point(426, 804);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 48);
            this.textBox3.TabIndex = 23;
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
            // TxbDescripcion
            // 
            this.TxbDescripcion.Location = new System.Drawing.Point(912, 259);
            this.TxbDescripcion.Multiline = true;
            this.TxbDescripcion.Name = "TxbDescripcion";
            this.TxbDescripcion.Size = new System.Drawing.Size(388, 108);
            this.TxbDescripcion.TabIndex = 14;
            // 
            // DtpFechaCargada
            // 
            this.DtpFechaCargada.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaCargada.Location = new System.Drawing.Point(912, 137);
            this.DtpFechaCargada.Name = "DtpFechaCargada";
            this.DtpFechaCargada.Size = new System.Drawing.Size(353, 28);
            this.DtpFechaCargada.TabIndex = 5;
            this.DtpFechaCargada.ValueChanged += new System.EventHandler(this.DtpFechaCargada_ValueChanged);
            // 
            // txbPatente
            // 
            this.txbPatente.Location = new System.Drawing.Point(494, 145);
            this.txbPatente.Multiline = true;
            this.txbPatente.Name = "txbPatente";
            this.txbPatente.Size = new System.Drawing.Size(208, 34);
            this.txbPatente.TabIndex = 21;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(94, 259);
            this.txbNombre.Multiline = true;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(208, 34);
            this.txbNombre.TabIndex = 19;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(94, 139);
            this.txbApellido.Multiline = true;
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(208, 34);
            this.txbApellido.TabIndex = 20;
            // 
            // chbIniciados
            // 
            this.chbIniciados.AutoSize = true;
            this.chbIniciados.BackColor = System.Drawing.Color.Transparent;
            this.chbIniciados.Location = new System.Drawing.Point(1306, 249);
            this.chbIniciados.Name = "chbIniciados";
            this.chbIniciados.Size = new System.Drawing.Size(80, 17);
            this.chbIniciados.TabIndex = 27;
            this.chbIniciados.Text = "INICIADOS";
            this.chbIniciados.UseVisualStyleBackColor = false;
            // 
            // chbActivos
            // 
            this.chbActivos.AutoSize = true;
            this.chbActivos.BackColor = System.Drawing.Color.Transparent;
            this.chbActivos.Location = new System.Drawing.Point(1306, 272);
            this.chbActivos.Name = "chbActivos";
            this.chbActivos.Size = new System.Drawing.Size(72, 17);
            this.chbActivos.TabIndex = 28;
            this.chbActivos.Text = "ACTIVOS";
            this.chbActivos.UseVisualStyleBackColor = false;
            // 
            // MenuTurnosTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaMenuTurnos2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.chbActivos);
            this.Controls.Add(this.chbIniciados);
            this.Controls.Add(this.grpProductos);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblTelefonoCliente);
            this.Controls.Add(this.txtTelCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRecargar);
            this.DoubleBuffered = true;
            this.Name = "MenuTurnosTrabajos";
            this.Text = "MenuOrdenDeTrabajo";
            this.Load += new System.EventHandler(this.MenuOrdenDeTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.grpProductos.ResumeLayout(false);
            this.grpProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.GroupBox grpProductos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpFechaCargada;
        private System.Windows.Forms.TextBox TxbDescripcion;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbPatente;
        private System.Windows.Forms.ComboBox cmbTrabajador;
        private System.Windows.Forms.CheckBox chbIniciados;
        private System.Windows.Forms.CheckBox chbActivos;
        private System.Windows.Forms.Button btnVisualizarOrden;
    }
}