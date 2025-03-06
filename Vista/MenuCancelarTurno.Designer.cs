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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.Cancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.grbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.BackgroundImage = global::lubricar.Properties.Resources.BtnRecargarIcon;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Location = new System.Drawing.Point(17, 90);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(54, 48);
            this.btnRecargar.TabIndex = 5;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCliente.Location = new System.Drawing.Point(250, 22);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(468, 35);
            this.txtTelCliente.TabIndex = 1;
            this.txtTelCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelCliente_KeyPress);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cancelar});
            this.dgvTurnos.Location = new System.Drawing.Point(17, 202);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.RowHeadersWidth = 62;
            this.dgvTurnos.RowTemplate.Height = 28;
            this.dgvTurnos.Size = new System.Drawing.Size(878, 350);
            this.dgvTurnos.TabIndex = 9;
            this.dgvTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellContentClick);
            // 
            // Cancelar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Cancelar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelar.HeaderText = "Cancelar";
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseColumnTextForButtonValue = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::lubricar.Properties.Resources.BtnBuscarIcon;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(779, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 48);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(110, 22);
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(137, 36);
            this.lblTelefonoCliente.TabIndex = 8;
            this.lblTelefonoCliente.Text = "Telefono";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(186, 125);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 6;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // grbFiltros
            // 
            this.grbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.grbFiltros.Controls.Add(this.txtPatente);
            this.grbFiltros.Controls.Add(this.dtpFecha);
            this.grbFiltros.Controls.Add(this.dgvTurnos);
            this.grbFiltros.Controls.Add(this.lblFecha);
            this.grbFiltros.Controls.Add(this.lblVehiculo);
            this.grbFiltros.Controls.Add(this.txtTelCliente);
            this.grbFiltros.Controls.Add(this.btnBuscar);
            this.grbFiltros.Controls.Add(this.btnRecargar);
            this.grbFiltros.Controls.Add(this.lblTelefonoCliente);
            this.grbFiltros.Location = new System.Drawing.Point(215, 171);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(942, 568);
            this.grbFiltros.TabIndex = 27;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Enter += new System.EventHandler(this.grbFiltros_Enter);
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(250, 94);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(468, 35);
            this.txtPatente.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(250, 166);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(278, 26);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(110, 156);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 36);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(110, 94);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(133, 36);
            this.lblVehiculo.TabIndex = 14;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // MenuCancelarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.PantCancelarTurno;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.grbFiltros);
            this.Controls.Add(this.BtnVolver);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCancelarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCancelarTurno";
            this.Load += new System.EventHandler(this.MenuCancelarTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.DataGridViewButtonColumn Cancelar;
        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtPatente;
    }
}