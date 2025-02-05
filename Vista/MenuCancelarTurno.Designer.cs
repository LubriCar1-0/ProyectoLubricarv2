namespace Vista
{
    partial class MenuCancelarTurno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.Cancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.BtnVehiculo = new System.Windows.Forms.Button();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.Btn = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbSelecVH = new System.Windows.Forms.ComboBox();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.grbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.BackgroundImage = global::Vista.Properties.Resources.BtnRecargarIcon;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Location = new System.Drawing.Point(33, 15);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(54, 48);
            this.btnRecargar.TabIndex = 13;
            this.btnRecargar.UseVisualStyleBackColor = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(223, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(539, 35);
            this.txtCliente.TabIndex = 11;
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cancelar});
            this.dgvTurnos.Location = new System.Drawing.Point(33, 305);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.RowHeadersWidth = 62;
            this.dgvTurnos.RowTemplate.Height = 28;
            this.dgvTurnos.Size = new System.Drawing.Size(878, 213);
            this.dgvTurnos.TabIndex = 9;
            this.dgvTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellContentClick);
            // 
            // Cancelar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Cancelar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelar.HeaderText = "Cancelar";
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseColumnTextForButtonValue = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::Vista.Properties.Resources.BtnBuscarIcon;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(768, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 48);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(110, 22);
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
            this.BtnVolver.Location = new System.Drawing.Point(259, 165);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 14;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            // 
            // grbFiltros
            // 
            this.grbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.grbFiltros.Controls.Add(this.dtpHorario);
            this.grbFiltros.Controls.Add(this.cmbSelecVH);
            this.grbFiltros.Controls.Add(this.dgvTurnos);
            this.grbFiltros.Controls.Add(this.Btn);
            this.grbFiltros.Controls.Add(this.lblFecha);
            this.grbFiltros.Controls.Add(this.BtnVehiculo);
            this.grbFiltros.Controls.Add(this.lblVehiculo);
            this.grbFiltros.Controls.Add(this.txtCliente);
            this.grbFiltros.Controls.Add(this.btnBuscar);
            this.grbFiltros.Controls.Add(this.btnRecargar);
            this.grbFiltros.Controls.Add(this.lblTelefonoCliente);
            this.grbFiltros.Location = new System.Drawing.Point(496, 229);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(942, 595);
            this.grbFiltros.TabIndex = 27;
            this.grbFiltros.TabStop = false;
            // 
            // BtnVehiculo
            // 
            this.BtnVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.BtnVehiculo.BackgroundImage = global::Vista.Properties.Resources.BtnBuscarIcon;
            this.BtnVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVehiculo.Location = new System.Drawing.Point(768, 87);
            this.BtnVehiculo.Name = "BtnVehiculo";
            this.BtnVehiculo.Size = new System.Drawing.Size(54, 48);
            this.BtnVehiculo.TabIndex = 15;
            this.BtnVehiculo.UseVisualStyleBackColor = false;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(110, 94);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(105, 30);
            this.lblVehiculo.TabIndex = 14;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // Btn
            // 
            this.Btn.BackColor = System.Drawing.Color.Transparent;
            this.Btn.BackgroundImage = global::Vista.Properties.Resources.BtnBuscarIcon;
            this.Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn.Location = new System.Drawing.Point(768, 159);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(54, 48);
            this.Btn.TabIndex = 18;
            this.Btn.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(110, 166);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(74, 30);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha";
            // 
            // cmbSelecVH
            // 
            this.cmbSelecVH.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelecVH.FormattingEnabled = true;
            this.cmbSelecVH.Location = new System.Drawing.Point(223, 98);
            this.cmbSelecVH.Name = "cmbSelecVH";
            this.cmbSelecVH.Size = new System.Drawing.Size(539, 33);
            this.cmbSelecVH.TabIndex = 20;
            this.cmbSelecVH.Text = "seleccionar Vehiculo";
            // 
            // dtpHorario
            // 
            this.dtpHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorario.Location = new System.Drawing.Point(223, 170);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(539, 26);
            this.dtpHorario.TabIndex = 21;
            // 
            // MenuCancelarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantCancelarTurno;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.grbFiltros);
            this.Controls.Add(this.BtnVolver);
            this.DoubleBuffered = true;
            this.Name = "MenuCancelarTurno";
            this.Text = "MenuCancelarTurno";
            this.Load += new System.EventHandler(this.MenuCancelarTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.DataGridViewButtonColumn Cancelar;
        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button BtnVehiculo;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ComboBox cmbSelecVH;
        private System.Windows.Forms.DateTimePicker dtpHorario;
    }
}