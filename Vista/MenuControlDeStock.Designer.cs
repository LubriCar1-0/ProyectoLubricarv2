﻿namespace Vista
{
    partial class MenuControlDeStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.DgvControlDeStock = new System.Windows.Forms.DataGridView();
            this.txbPrecioVent = new System.Windows.Forms.TextBox();
            this.txbPrecioList = new System.Windows.Forms.TextBox();
            this.txbCant = new System.Windows.Forms.TextBox();
            this.txbCantMinima = new System.Windows.Forms.TextBox();
            this.txtLitrosDisp = new System.Windows.Forms.TextBox();
            this.txtLitrosMin = new System.Windows.Forms.TextBox();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.Cbxeditar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvControlDeStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = global::Vista.Properties.Resources.BtnConfirmar;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(1130, 811);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(241, 75);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // DgvControlDeStock
            // 
            this.DgvControlDeStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvControlDeStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvControlDeStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvControlDeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvControlDeStock.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvControlDeStock.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DgvControlDeStock.Location = new System.Drawing.Point(273, 359);
            this.DgvControlDeStock.Name = "DgvControlDeStock";
            this.DgvControlDeStock.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvControlDeStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvControlDeStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvControlDeStock.Size = new System.Drawing.Size(668, 645);
            this.DgvControlDeStock.TabIndex = 6;
            this.DgvControlDeStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvControlDeStock_CellContentClick);
            // 
            // txbPrecioVent
            // 
            this.txbPrecioVent.Location = new System.Drawing.Point(959, 483);
            this.txbPrecioVent.Multiline = true;
            this.txbPrecioVent.Name = "txbPrecioVent";
            this.txbPrecioVent.Size = new System.Drawing.Size(195, 33);
            this.txbPrecioVent.TabIndex = 7;
            // 
            // txbPrecioList
            // 
            this.txbPrecioList.Location = new System.Drawing.Point(1316, 483);
            this.txbPrecioList.Multiline = true;
            this.txbPrecioList.Name = "txbPrecioList";
            this.txbPrecioList.Size = new System.Drawing.Size(195, 33);
            this.txbPrecioList.TabIndex = 8;
            // 
            // txbCant
            // 
            this.txbCant.Location = new System.Drawing.Point(959, 588);
            this.txbCant.Multiline = true;
            this.txbCant.Name = "txbCant";
            this.txbCant.Size = new System.Drawing.Size(195, 33);
            this.txbCant.TabIndex = 9;
            // 
            // txbCantMinima
            // 
            this.txbCantMinima.Location = new System.Drawing.Point(1316, 588);
            this.txbCantMinima.Multiline = true;
            this.txbCantMinima.Name = "txbCantMinima";
            this.txbCantMinima.Size = new System.Drawing.Size(195, 33);
            this.txbCantMinima.TabIndex = 10;
            // 
            // txtLitrosDisp
            // 
            this.txtLitrosDisp.Location = new System.Drawing.Point(959, 701);
            this.txtLitrosDisp.Multiline = true;
            this.txtLitrosDisp.Name = "txtLitrosDisp";
            this.txtLitrosDisp.Size = new System.Drawing.Size(195, 33);
            this.txtLitrosDisp.TabIndex = 11;
            // 
            // txtLitrosMin
            // 
            this.txtLitrosMin.Location = new System.Drawing.Point(1316, 701);
            this.txtLitrosMin.Multiline = true;
            this.txtLitrosMin.Name = "txtLitrosMin";
            this.txtLitrosMin.Size = new System.Drawing.Size(195, 33);
            this.txtLitrosMin.TabIndex = 12;
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Location = new System.Drawing.Point(643, 319);
            this.TxtCodProducto.Multiline = true;
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.Size = new System.Drawing.Size(195, 33);
            this.TxtCodProducto.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.button1.BackgroundImage = global::Vista.Properties.Resources.Flechita_volver_64px;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(261, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 57);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackgroundImage = global::Vista.Properties.Resources.BtnFiltrar;
            this.btnFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Location = new System.Drawing.Point(855, 308);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(98, 45);
            this.btnFiltro.TabIndex = 16;
            this.btnFiltro.UseVisualStyleBackColor = true;
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreProd.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNombreProd.Location = new System.Drawing.Point(1300, 386);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(331, 36);
            this.lblNombreProd.TabIndex = 17;
            this.lblNombreProd.Text = "No se selecciono producto";
            this.lblNombreProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cbxeditar
            // 
            this.Cbxeditar.AutoSize = true;
            this.Cbxeditar.BackColor = System.Drawing.Color.Transparent;
            this.Cbxeditar.Location = new System.Drawing.Point(959, 359);
            this.Cbxeditar.Name = "Cbxeditar";
            this.Cbxeditar.Size = new System.Drawing.Size(90, 17);
            this.Cbxeditar.TabIndex = 18;
            this.Cbxeditar.Text = "Permitir Editar";
            this.Cbxeditar.UseVisualStyleBackColor = false;
            this.Cbxeditar.CheckedChanged += new System.EventHandler(this.Cbxeditar_CheckedChanged);
            // 
            // MenuControlDeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.PantallaControlDeStockNueva2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Cbxeditar);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCodProducto);
            this.Controls.Add(this.txtLitrosMin);
            this.Controls.Add(this.txtLitrosDisp);
            this.Controls.Add(this.txbCantMinima);
            this.Controls.Add(this.txbCant);
            this.Controls.Add(this.txbPrecioList);
            this.Controls.Add(this.txbPrecioVent);
            this.Controls.Add(this.DgvControlDeStock);
            this.Controls.Add(this.btnConfirmar);
            this.DoubleBuffered = true;
            this.Name = "MenuControlDeStock";
            this.Text = "MenuControlDeStock";
            ((System.ComponentModel.ISupportInitialize)(this.DgvControlDeStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView DgvControlDeStock;
        private System.Windows.Forms.TextBox txbPrecioVent;
        private System.Windows.Forms.TextBox txbPrecioList;
        private System.Windows.Forms.TextBox txbCant;
        private System.Windows.Forms.TextBox txbCantMinima;
        private System.Windows.Forms.TextBox txtLitrosDisp;
        private System.Windows.Forms.TextBox txtLitrosMin;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.CheckBox Cbxeditar;
    }
}