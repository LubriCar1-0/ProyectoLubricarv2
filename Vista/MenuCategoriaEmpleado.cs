﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MenuCategoriaEmpleado : Form
    {
        public MenuCategoriaEmpleado()
        {
            InitializeComponent();
            CargarTablaCategoriasEMP();
            dgvCategoriasEmpleados.ReadOnly = true;
            chPermiteEditar.CheckedChanged += chPermiteEditar_CheckedChanged;
            dgvCategoriasEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoriasEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnagregarcat_Click(object sender, EventArgs e)
        {
            string NombreCat = txbNomCat.Text;
            string Desc = txbDescripcion.Text;
            int CodPerm = Convert.ToInt32(cmbCodPerm.SelectedItem);

            Validaciones.IngresaCategoriaEMP(NombreCat.Trim(), Desc.Trim(), CodPerm, "ACT");

            LimpiaCampos();
            CargarTablaCategoriasEMP();
        }

        private void LimpiaCampos()
        {
            txbNomCat.Text = string.Empty;
            txbDescripcion.Text = string.Empty;

            cmbCodPerm.SelectedIndex = -1;
        }

        private void CargarTablaCategoriasEMP()
        {
            dgvCategoriasEmpleados.DataSource = null;
            dgvCategoriasEmpleados.DataSource = Validaciones.TraeCategoriasEmpleados();
            dgvCategoriasEmpleados.Columns["idCategoria"].Visible = false;
            dgvCategoriasEmpleados.AllowUserToAddRows = false;
            dgvCategoriasEmpleados.RowHeadersVisible = false;
            ConfiguraDataGrid(dgvCategoriasEmpleados);
        }

        private void ConfiguraDataGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Cabecera
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ScrollBars = ScrollBars.Both;

            AplicarTrimDataGridView(dgv);
        }

        private void AplicarTrimDataGridView(DataGridView dgv)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value is string texto)
                    {
                        celda.Value = texto.Trim();
                    }
                }
            }
        }

        private void dgvCategoriasEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow filaSeleccionada = dgvCategoriasEmpleados.Rows[e.RowIndex];
            int IdCategoria = Convert.ToInt32(filaSeleccionada.Cells["idCategoria"].Value);
            txbNomCat.Text = filaSeleccionada.Cells["NombreCat"].Value.ToString().Trim();
            int CodPerm = Convert.ToInt32(filaSeleccionada.Cells["PermisoCat"].Value);
            cmbCodPerm.SelectedItem = CodPerm.ToString();

            txbDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString().Trim();

            if (dgvCategoriasEmpleados.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionadaUPD = dgvCategoriasEmpleados.Rows[e.RowIndex];
                    int IdCategoriaUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["idCategoria"].Value);
                    string NombreCat = filaSeleccionadaUPD.Cells["NombreCat"].Value.ToString().Trim();
                    int CodPermUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["PermisoCat"].Value);
                    string DescUPD = filaSeleccionada.Cells["Descripcion"].Value.ToString().Trim();

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        Validaciones.UpdateCatergoriasEmpleados(IdCategoriaUPD, NombreCat.Trim(), CodPermUPD, DescUPD.Trim());
                        MessageBox.Show("Cambio realizado.");
                        CargarTablaCategoriasEMP();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarTablaCategoriasEMP();
                    }
                }
            }
            else if (dgvCategoriasEmpleados.Columns[e.ColumnIndex].Name == "CambiarEstado")
            {
                DataGridViewRow filaSeleccionadaUPD = dgvCategoriasEmpleados.Rows[e.RowIndex];
                int IdCategoriaUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["idCategoria"].Value);
                string Estado = filaSeleccionada.Cells["ESTADO"].Value.ToString().Trim();

                if (Estado == "ACT")
                {
                    Validaciones.CambiarEstadoEmpleados(IdCategoriaUPD, "DES");
                    MessageBox.Show("Estado Modificado.");
                    CargarTablaCategoriasEMP();
                }
                else if (Estado == "DES")
                {
                    Validaciones.CambiarEstadoEmpleados(IdCategoriaUPD, "ACT");
                    MessageBox.Show("Estado Modificado.");
                    CargarTablaCategoriasEMP();
                }
            }
        }

        private void chPermiteEditar_CheckedChanged(object sender, EventArgs e)
        {
            dgvCategoriasEmpleados.ReadOnly = !chPermiteEditar.Checked;
        }

        private void btnBorraCampos_Click(object sender, EventArgs e)
        {
            LimpiaCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuCategoriaEmpleado_Load(object sender, EventArgs e)
        {
            cmbCodPerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCodPerm.Items.Clear();
            cmbCodPerm.Items.Add("9");
            cmbCodPerm.Items.Add("5");
            cmbCodPerm.Items.Add("3");
            cmbCodPerm.Items.Add("4");
            cmbCodPerm.SelectedIndex = -1;
        }
    }

}
