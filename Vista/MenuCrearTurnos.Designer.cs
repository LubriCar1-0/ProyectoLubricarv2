namespace Vista
{
    partial class MenuCrearTurnos
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
            this.dtpSelecionarDia = new System.Windows.Forms.DateTimePicker();
            this.CbxSelectCL = new System.Windows.Forms.ComboBox();
            this.CbxSelectVH = new System.Windows.Forms.ComboBox();
            this.TxtDescripcionTurno = new System.Windows.Forms.TextBox();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.BtnCrearTurno = new System.Windows.Forms.Button();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.btnBorraCampos = new System.Windows.Forms.Button();
            this.chbEditar = new System.Windows.Forms.CheckBox();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSelecionarDia
            // 
            this.dtpSelecionarDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSelecionarDia.Location = new System.Drawing.Point(445, 293);
            this.dtpSelecionarDia.Name = "dtpSelecionarDia";
            this.dtpSelecionarDia.Size = new System.Drawing.Size(298, 26);
            this.dtpSelecionarDia.TabIndex = 0;
            this.dtpSelecionarDia.ValueChanged += new System.EventHandler(this.dtpSelecionarDia_ValueChanged);
            // 
            // CbxSelectCL
            // 
            this.CbxSelectCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSelectCL.FormattingEnabled = true;
            this.CbxSelectCL.Location = new System.Drawing.Point(445, 409);
            this.CbxSelectCL.Name = "CbxSelectCL";
            this.CbxSelectCL.Size = new System.Drawing.Size(298, 28);
            this.CbxSelectCL.TabIndex = 1;
            // 
            // CbxSelectVH
            // 
            this.CbxSelectVH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSelectVH.FormattingEnabled = true;
            this.CbxSelectVH.Location = new System.Drawing.Point(1144, 409);
            this.CbxSelectVH.Name = "CbxSelectVH";
            this.CbxSelectVH.Size = new System.Drawing.Size(298, 28);
            this.CbxSelectVH.TabIndex = 2;
            this.CbxSelectVH.SelectedIndexChanged += new System.EventHandler(this.CbxSelectVH_SelectedIndexChanged);
            // 
            // TxtDescripcionTurno
            // 
            this.TxtDescripcionTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionTurno.Location = new System.Drawing.Point(445, 524);
            this.TxtDescripcionTurno.Multiline = true;
            this.TxtDescripcionTurno.Name = "TxtDescripcionTurno";
            this.TxtDescripcionTurno.Size = new System.Drawing.Size(330, 88);
            this.TxtDescripcionTurno.TabIndex = 4;
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.BackgroundImage = global::Vista.Properties.Resources.BtnAgregarClientes;
            this.BtnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.BtnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(323, 955);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(214, 43);
            this.BtnAgregarCliente.TabIndex = 5;
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // BtnCrearTurno
            // 
            this.BtnCrearTurno.BackgroundImage = global::Vista.Properties.Resources.BtnCrearTurnoBlanco;
            this.BtnCrearTurno.FlatAppearance.BorderSize = 0;
            this.BtnCrearTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearTurno.Location = new System.Drawing.Point(1355, 955);
            this.BtnCrearTurno.Name = "BtnCrearTurno";
            this.BtnCrearTurno.Size = new System.Drawing.Size(214, 43);
            this.BtnCrearTurno.TabIndex = 6;
            this.BtnCrearTurno.UseVisualStyleBackColor = true;
            this.BtnCrearTurno.Click += new System.EventHandler(this.BtnCrearTurno_Click);
            // 
            // dtpHorario
            // 
            this.dtpHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorario.Location = new System.Drawing.Point(1144, 293);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(298, 26);
            this.dtpHorario.TabIndex = 8;
            this.dtpHorario.ValueChanged += new System.EventHandler(this.dtpHorario_ValueChanged_1);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dgvTurnos.Location = new System.Drawing.Point(445, 667);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.Size = new System.Drawing.Size(1031, 257);
            this.dgvTurnos.TabIndex = 9;
            this.dgvTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellContentClick_1);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(259, 167);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 15;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // btnBorraCampos
            // 
            this.btnBorraCampos.BackgroundImage = global::Vista.Properties.Resources.blanco;
            this.btnBorraCampos.FlatAppearance.BorderSize = 0;
            this.btnBorraCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorraCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraCampos.Location = new System.Drawing.Point(1337, 631);
            this.btnBorraCampos.Name = "btnBorraCampos";
            this.btnBorraCampos.Size = new System.Drawing.Size(139, 30);
            this.btnBorraCampos.TabIndex = 23;
            this.btnBorraCampos.Text = "Borrar campos";
            this.btnBorraCampos.UseVisualStyleBackColor = true;
            this.btnBorraCampos.Click += new System.EventHandler(this.btnBorraCampos_Click);
            // 
            // chbEditar
            // 
            this.chbEditar.AutoSize = true;
            this.chbEditar.BackColor = System.Drawing.Color.Transparent;
            this.chbEditar.Location = new System.Drawing.Point(1482, 768);
            this.chbEditar.Name = "chbEditar";
            this.chbEditar.Size = new System.Drawing.Size(90, 17);
            this.chbEditar.TabIndex = 24;
            this.chbEditar.Text = "Permitir Editar";
            this.chbEditar.UseVisualStyleBackColor = false;
            // 
            // Editar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // MenuCrearTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.MenuCreacionDeTurnos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.chbEditar);
            this.Controls.Add(this.btnBorraCampos);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.BtnCrearTurno);
            this.Controls.Add(this.BtnAgregarCliente);
            this.Controls.Add(this.TxtDescripcionTurno);
            this.Controls.Add(this.CbxSelectVH);
            this.Controls.Add(this.CbxSelectCL);
            this.Controls.Add(this.dtpSelecionarDia);
            this.DoubleBuffered = true;
            this.Name = "MenuCrearTurnos";
            this.Text = "MenuCrearTurnos";
            this.Load += new System.EventHandler(this.MenuCrearTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSelecionarDia;
        private System.Windows.Forms.ComboBox CbxSelectCL;
        private System.Windows.Forms.ComboBox CbxSelectVH;
        private System.Windows.Forms.TextBox TxtDescripcionTurno;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.Button BtnCrearTurno;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button btnBorraCampos;
        private System.Windows.Forms.CheckBox chbEditar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}