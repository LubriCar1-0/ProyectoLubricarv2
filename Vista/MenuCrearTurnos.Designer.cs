﻿namespace Vista
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
            this.dtpSelecionarDia = new System.Windows.Forms.DateTimePicker();
            this.CbxSelectCL = new System.Windows.Forms.ComboBox();
            this.CbxSelectVH = new System.Windows.Forms.ComboBox();
            this.TxtDescripcionTurno = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnCrearTurno = new System.Windows.Forms.Button();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.btnBorraCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSelecionarDia
            // 
            this.dtpSelecionarDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSelecionarDia.Location = new System.Drawing.Point(316, 223);
            this.dtpSelecionarDia.Name = "dtpSelecionarDia";
            this.dtpSelecionarDia.Size = new System.Drawing.Size(298, 26);
            this.dtpSelecionarDia.TabIndex = 1;
            this.dtpSelecionarDia.ValueChanged += new System.EventHandler(this.dtpSelecionarDia_ValueChanged);
            // 
            // CbxSelectCL
            // 
            this.CbxSelectCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSelectCL.FormattingEnabled = true;
            this.CbxSelectCL.Location = new System.Drawing.Point(316, 309);
            this.CbxSelectCL.Name = "CbxSelectCL";
            this.CbxSelectCL.Size = new System.Drawing.Size(298, 28);
            this.CbxSelectCL.TabIndex = 3;
            // 
            // CbxSelectVH
            // 
            this.CbxSelectVH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSelectVH.FormattingEnabled = true;
            this.CbxSelectVH.Location = new System.Drawing.Point(813, 309);
            this.CbxSelectVH.Name = "CbxSelectVH";
            this.CbxSelectVH.Size = new System.Drawing.Size(298, 28);
            this.CbxSelectVH.TabIndex = 4;
            this.CbxSelectVH.SelectedIndexChanged += new System.EventHandler(this.CbxSelectVH_SelectedIndexChanged);
            // 
            // TxtDescripcionTurno
            // 
            this.TxtDescripcionTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionTurno.Location = new System.Drawing.Point(564, 362);
            this.TxtDescripcionTurno.Multiline = true;
            this.TxtDescripcionTurno.Name = "TxtDescripcionTurno";
            this.TxtDescripcionTurno.Size = new System.Drawing.Size(458, 57);
            this.TxtDescripcionTurno.TabIndex = 5;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackgroundImage = global::lubricar.Properties.Resources.BtnEditar;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Location = new System.Drawing.Point(665, 707);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(96, 43);
            this.BtnEditar.TabIndex = 7;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnCrearTurno
            // 
            this.BtnCrearTurno.BackgroundImage = global::lubricar.Properties.Resources.BtnCrearTurnoBlanco;
            this.BtnCrearTurno.FlatAppearance.BorderSize = 0;
            this.BtnCrearTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearTurno.Location = new System.Drawing.Point(433, 707);
            this.BtnCrearTurno.Name = "BtnCrearTurno";
            this.BtnCrearTurno.Size = new System.Drawing.Size(214, 43);
            this.BtnCrearTurno.TabIndex = 6;
            this.BtnCrearTurno.UseVisualStyleBackColor = true;
            this.BtnCrearTurno.Click += new System.EventHandler(this.BtnCrearTurno_Click);
            // 
            // dtpHorario
            // 
            this.dtpHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorario.Location = new System.Drawing.Point(813, 223);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(298, 26);
            this.dtpHorario.TabIndex = 2;
            this.dtpHorario.ValueChanged += new System.EventHandler(this.dtpHorario_ValueChanged_1);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(204, 444);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.Size = new System.Drawing.Size(951, 257);
            this.dgvTurnos.TabIndex = 9;
            this.dgvTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellContentClick_1);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = global::lubricar.Properties.Resources.Flechita_volver_64px;
            this.BtnVolver.Location = new System.Drawing.Point(191, 127);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(64, 40);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // btnBorraCampos
            // 
            this.btnBorraCampos.BackgroundImage = global::lubricar.Properties.Resources.blanco;
            this.btnBorraCampos.FlatAppearance.BorderSize = 0;
            this.btnBorraCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorraCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraCampos.Location = new System.Drawing.Point(783, 707);
            this.btnBorraCampos.Name = "btnBorraCampos";
            this.btnBorraCampos.Size = new System.Drawing.Size(162, 43);
            this.btnBorraCampos.TabIndex = 8;
            this.btnBorraCampos.Text = "Borrar campos";
            this.btnBorraCampos.UseVisualStyleBackColor = true;
            this.btnBorraCampos.Click += new System.EventHandler(this.btnBorraCampos_Click);
            // 
            // MenuCrearTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lubricar.Properties.Resources.MenuCreacionDeTurnos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnBorraCampos);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.BtnCrearTurno);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TxtDescripcionTurno);
            this.Controls.Add(this.CbxSelectVH);
            this.Controls.Add(this.CbxSelectCL);
            this.Controls.Add(this.dtpSelecionarDia);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCrearTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnCrearTurno;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button btnBorraCampos;
    }
}