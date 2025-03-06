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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.BtnAgregar.Image = global::lubricar.Properties.Resources.BtnCrearOrden;
            this.BtnAgregar.Location = new System.Drawing.Point(19, 280);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(201, 44);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(412, 130);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(279, 26);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(240, 206);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.RowHeadersWidth = 62;
            this.dgvTurnos.RowTemplate.Height = 28;
            this.dgvTurnos.Size = new System.Drawing.Size(819, 183);
            this.dgvTurnos.TabIndex = 9;
            this.dgvTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellContentClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(286, 126);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 31);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(685, 165);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(108, 31);
            this.lblVehiculo.TabIndex = 14;
            this.lblVehiculo.Text = "Patente";
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCliente.Location = new System.Drawing.Point(412, 165);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(266, 35);
            this.txtTelCliente.TabIndex = 2;
            this.txtTelCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelCliente_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::lubricar.Properties.Resources.BtnBuscarIcon;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(1065, 206);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 48);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.BackgroundImage = global::lubricar.Properties.Resources.BtnRecargarIcon;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Location = new System.Drawing.Point(1065, 260);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(54, 48);
            this.btnRecargar.TabIndex = 5;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click_1);
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(286, 165);
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(122, 31);
            this.lblTelefonoCliente.TabIndex = 8;
            this.lblTelefonoCliente.Text = "Telefono";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(195, 126);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 10;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(793, 165);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(266, 35);
            this.txtPatente.TabIndex = 3;
            // 
            // grpProductos
            // 
            this.grpProductos.BackColor = System.Drawing.Color.Transparent;
            this.grpProductos.Controls.Add(this.label6);
            this.grpProductos.Controls.Add(this.label5);
            this.grpProductos.Controls.Add(this.label4);
            this.grpProductos.Controls.Add(this.label3);
            this.grpProductos.Controls.Add(this.label2);
            this.grpProductos.Controls.Add(this.label1);
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
            this.grpProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProductos.ForeColor = System.Drawing.Color.OrangeRed;
            this.grpProductos.Location = new System.Drawing.Point(232, 395);
            this.grpProductos.Name = "grpProductos";
            this.grpProductos.Size = new System.Drawing.Size(905, 330);
            this.grpProductos.TabIndex = 26;
            this.grpProductos.TabStop = false;
            this.grpProductos.Text = "Orden De Trabajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(590, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 31);
            this.label6.TabIndex = 34;
            this.label6.Text = "Descripción";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(590, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 31);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fecha de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(301, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Patente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(301, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 31;
            this.label3.Text = "Trabajador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre";
            // 
            // btnVisualizarOrden
            // 
            this.btnVisualizarOrden.FlatAppearance.BorderSize = 0;
            this.btnVisualizarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarOrden.Image = global::lubricar.Properties.Resources.BtnVisualizarOrden;
            this.btnVisualizarOrden.Location = new System.Drawing.Point(276, 280);
            this.btnVisualizarOrden.Name = "btnVisualizarOrden";
            this.btnVisualizarOrden.Size = new System.Drawing.Size(245, 44);
            this.btnVisualizarOrden.TabIndex = 9;
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
            this.cmbTrabajador.Location = new System.Drawing.Point(306, 170);
            this.cmbTrabajador.Name = "cmbTrabajador";
            this.cmbTrabajador.Size = new System.Drawing.Size(208, 44);
            this.cmbTrabajador.TabIndex = 6;
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
            this.TxbDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbDescripcion.Location = new System.Drawing.Point(596, 170);
            this.TxbDescripcion.Multiline = true;
            this.TxbDescripcion.Name = "TxbDescripcion";
            this.TxbDescripcion.Size = new System.Drawing.Size(285, 99);
            this.TxbDescripcion.TabIndex = 7;
            // 
            // DtpFechaCargada
            // 
            this.DtpFechaCargada.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaCargada.Location = new System.Drawing.Point(596, 80);
            this.DtpFechaCargada.Name = "DtpFechaCargada";
            this.DtpFechaCargada.Size = new System.Drawing.Size(291, 28);
            this.DtpFechaCargada.TabIndex = 5;
            this.DtpFechaCargada.ValueChanged += new System.EventHandler(this.DtpFechaCargada_ValueChanged);
            // 
            // txbPatente
            // 
            this.txbPatente.Location = new System.Drawing.Point(306, 80);
            this.txbPatente.Multiline = true;
            this.txbPatente.Name = "txbPatente";
            this.txbPatente.Size = new System.Drawing.Size(208, 44);
            this.txbPatente.TabIndex = 21;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(12, 170);
            this.txbNombre.Multiline = true;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(208, 44);
            this.txbNombre.TabIndex = 19;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(12, 80);
            this.txbApellido.Multiline = true;
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(208, 44);
            this.txbApellido.TabIndex = 20;
            // 
            // chbIniciados
            // 
            this.chbIniciados.AutoSize = true;
            this.chbIniciados.BackColor = System.Drawing.Color.Transparent;
            this.chbIniciados.Location = new System.Drawing.Point(1065, 349);
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
            this.chbActivos.Location = new System.Drawing.Point(1065, 326);
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
            this.BackgroundImage = global::lubricar.Properties.Resources.PantallaMenuTurnos3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuTurnosTrabajos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}