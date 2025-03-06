namespace Vista
{
    partial class MenuOrdenesFinalizadas
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
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.dgvOrdenesFinalizadas = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVH = new System.Windows.Forms.Label();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtTrabajador = new System.Windows.Forms.TextBox();
            this.btnVisualizarOrden = new System.Windows.Forms.Button();
            this.cmbTrabajador = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesFinalizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(574, 208);
            this.txtPatente.Multiline = true;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(282, 31);
            this.txtPatente.TabIndex = 2;
            // 
            // dgvOrdenesFinalizadas
            // 
            this.dgvOrdenesFinalizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesFinalizadas.Location = new System.Drawing.Point(254, 304);
            this.dgvOrdenesFinalizadas.Name = "dgvOrdenesFinalizadas";
            this.dgvOrdenesFinalizadas.RowHeadersWidth = 62;
            this.dgvOrdenesFinalizadas.RowTemplate.Height = 28;
            this.dgvOrdenesFinalizadas.Size = new System.Drawing.Size(819, 183);
            this.dgvOrdenesFinalizadas.TabIndex = 30;
            this.dgvOrdenesFinalizadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenesFinalizadas_CellContentClick);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(574, 166);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(282, 26);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(484, 162);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 31);
            this.lblFecha.TabIndex = 35;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(459, 208);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(108, 31);
            this.lblVehiculo.TabIndex = 34;
            this.lblVehiculo.Text = "Patente";
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.BackColor = System.Drawing.Color.Transparent;
            this.lblTrabajador.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajador.Location = new System.Drawing.Point(421, 249);
            this.lblTrabajador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(146, 31);
            this.lblTrabajador.TabIndex = 29;
            this.lblTrabajador.Text = "Trabajador";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::lubricar.Properties.Resources.BtnBuscarIcon;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(895, 162);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 48);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.BackgroundImage = global::lubricar.Properties.Resources.BtnRecargarIcon;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Location = new System.Drawing.Point(386, 162);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(54, 48);
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(185, 126);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // txbCliente
            // 
            this.txbCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliente.Location = new System.Drawing.Point(258, 542);
            this.txbCliente.Multiline = true;
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(262, 34);
            this.txbCliente.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(252, 508);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(98, 31);
            this.lblCliente.TabIndex = 42;
            this.lblCliente.Text = "Cliente";
            // 
            // lblVH
            // 
            this.lblVH.AutoSize = true;
            this.lblVH.BackColor = System.Drawing.Color.Transparent;
            this.lblVH.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVH.Location = new System.Drawing.Point(547, 508);
            this.lblVH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVH.Name = "lblVH";
            this.lblVH.Size = new System.Drawing.Size(119, 31);
            this.lblVH.TabIndex = 44;
            this.lblVH.Text = "Vehiculo";
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculo.Location = new System.Drawing.Point(553, 542);
            this.txtVehiculo.Multiline = true;
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(257, 34);
            this.txtVehiculo.TabIndex = 6;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(832, 508);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(146, 31);
            this.lblEmpleado.TabIndex = 46;
            this.lblEmpleado.Text = "Trabajador";
            // 
            // txtTrabajador
            // 
            this.txtTrabajador.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabajador.Location = new System.Drawing.Point(838, 542);
            this.txtTrabajador.Multiline = true;
            this.txtTrabajador.Name = "txtTrabajador";
            this.txtTrabajador.Size = new System.Drawing.Size(256, 34);
            this.txtTrabajador.TabIndex = 7;
            // 
            // btnVisualizarOrden
            // 
            this.btnVisualizarOrden.FlatAppearance.BorderSize = 0;
            this.btnVisualizarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarOrden.Image = global::lubricar.Properties.Resources.BtnVentaDelServicio;
            this.btnVisualizarOrden.Location = new System.Drawing.Point(535, 665);
            this.btnVisualizarOrden.Name = "btnVisualizarOrden";
            this.btnVisualizarOrden.Size = new System.Drawing.Size(266, 44);
            this.btnVisualizarOrden.TabIndex = 8;
            this.btnVisualizarOrden.UseVisualStyleBackColor = true;
            this.btnVisualizarOrden.Click += new System.EventHandler(this.btnVisualizarOrden_Click);
            // 
            // cmbTrabajador
            // 
            this.cmbTrabajador.FormattingEnabled = true;
            this.cmbTrabajador.Location = new System.Drawing.Point(574, 259);
            this.cmbTrabajador.Name = "cmbTrabajador";
            this.cmbTrabajador.Size = new System.Drawing.Size(282, 21);
            this.cmbTrabajador.TabIndex = 3;
            this.cmbTrabajador.SelectedIndexChanged += new System.EventHandler(this.cmbTrabajador_SelectedIndexChanged);
            // 
            // MenuOrdenesFinalizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.MenuOrdenesFinalizadas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.cmbTrabajador);
            this.Controls.Add(this.btnVisualizarOrden);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txtTrabajador);
            this.Controls.Add(this.lblVH);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.dgvOrdenesFinalizadas);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblTrabajador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRecargar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuOrdenesFinalizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuOrdenesFinalizadas";
            this.Load += new System.EventHandler(this.MenuOrdenesFinalizadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesFinalizadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.DataGridView dgvOrdenesFinalizadas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblTrabajador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVH;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtTrabajador;
        private System.Windows.Forms.Button btnVisualizarOrden;
        private System.Windows.Forms.ComboBox cmbTrabajador;
    }
}