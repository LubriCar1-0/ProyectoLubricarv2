using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Vista
{
    public partial class MenuCancelarTurno : Form
    {
        public MenuCancelarTurno()
        {
            InitializeComponent();
            CargarTurnos();
            dgvTurnos.ReadOnly = true;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = " ";
            //dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvTurnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTurnos.DataSource = validarTurnos.BuscarTurnosActivos();
            dgvTurnos.RowHeadersVisible = false;

        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0)
                return;

            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];
            int idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);

            
            if (dgvTurnos.Columns[e.ColumnIndex].Name == "Cancelar")
            {
                string estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    if (estado == "ACTIVO")
                    {
                        validarTurnos.CancelarTurno(idTurno, "CANCELADO");
                        MessageBox.Show("Turno CANCELADO.");
                        CargarTurnos();
                        ConfiguraDataGrid(dgvTurnos);
                    }
                    else if (estado == "CANCELADO")
                    {
                        MessageBox.Show("Este turno ya ha sido cancelado");
                    }
                    else if (estado == "INICIADO")
                    {
                        MessageBox.Show("No se puede cancelar un turno que tiene una Orden de Trabajo INICIADA");
                    }
                }
            }
        }
        private void CargarTurnos()
        {
            try
            {
                dgvTurnos.DataSource = null;
                dgvTurnos.DataSource = validarTurnos.BuscarTurnosActivos();
                dgvTurnos.RowHeadersVisible = false;
                dgvTurnos.AllowUserToAddRows = false;

                if (dgvTurnos.Columns.Contains("idTurno"))
                    dgvTurnos.Columns["idTurno"].Visible = false;
                if (dgvTurnos.Columns.Contains("idVehiculo"))
                    dgvTurnos.Columns["idVehiculo"].Visible = false;
                if (dgvTurnos.Columns.Contains("idCliente"))
                    dgvTurnos.Columns["idCliente"].Visible = false;
                ConfiguraDataGrid(dgvTurnos);
                AjustarEstiloGrid(dgvTurnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los turnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuCancelarTurno_Load(object sender, EventArgs e)
        {

        }

       
        private int idVehiculoSeleccionado = 0;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string telefono = string.IsNullOrEmpty(txtTelCliente.Text) ? null : txtTelCliente.Text.Trim();
            
            string patente = string.IsNullOrEmpty(txtPatente.Text) ? null : txtPatente.Text.Trim().ToUpper();
            string fecha = dtpFecha.CustomFormat != " " ? dtpFecha.Value.ToString("yyyy-MM-dd") : null;
            string estado = "ACTIVO";
            
            
                CargaTurnosFiltro(telefono, patente, fecha, estado);
            


        }


        private void CargaTurnosFiltro(string telefono, string patente, string fecha, string estado)
        {
            try
            {
                dgvTurnos.DataSource = null;
                var turnos = validarTurnos.TurnosFiltro(telefono, patente, fecha, estado);
                dgvTurnos.DataSource = turnos;
                dgvTurnos.RowHeadersVisible = false;

                // Ocultar columnas no deseadas
                if (dgvTurnos.Columns.Contains("idTurno"))
                    dgvTurnos.Columns["idTurno"].Visible = false;
                if (dgvTurnos.Columns.Contains("idVehiculo"))
                    dgvTurnos.Columns["idVehiculo"].Visible = false;
                if (dgvTurnos.Columns.Contains("idCliente"))
                    dgvTurnos.Columns["idCliente"].Visible = false;
                ConfiguraDataGrid(dgvTurnos);
                AjustarEstiloGrid(dgvTurnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los turnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Configuracion de la grid
        private void ConfiguraDataGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 250);

            dgv.RowHeadersVisible = false;



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
                    // Verifica si la columna es de sólo lectura antes de asignar
                    if (!celda.OwningColumn.ReadOnly && celda.Value is string texto)
                    {
                        celda.Value = texto.Trim();
                    }
                }
            }
        }

        private void AjustarEstiloGrid(DataGridView dgv)
        {

            dgv.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 13.05f, FontStyle.Regular);

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 14.05f, FontStyle.Bold);

            dgv.RowTemplate.Height = 40;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion




        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = " ";
            txtPatente.Clear();
            txtTelCliente.Clear();
            CargarTurnos();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grbFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void txtTelCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
