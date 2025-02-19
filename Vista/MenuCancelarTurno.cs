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
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTurnos.DataSource = validarTurnos.BuscarTurnos();
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
                dgvTurnos.DataSource = validarTurnos.BuscarTurnos();
                dgvTurnos.RowHeadersVisible = false;
                dgvTurnos.AllowUserToAddRows = false;

                if (dgvTurnos.Columns.Contains("idTurno"))
                    dgvTurnos.Columns["idTurno"].Visible = false;
                if (dgvTurnos.Columns.Contains("idVehiculo"))
                    dgvTurnos.Columns["idVehiculo"].Visible = false;
                if (dgvTurnos.Columns.Contains("idCliente"))
                    dgvTurnos.Columns["idCliente"].Visible = false;
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
            // Si el TextBox de teléfono está vacío se envía NULL; de lo contrario se hace Trim.
            string telefono = string.IsNullOrEmpty(txtTelCliente.Text) ? null : txtTelCliente.Text.Trim();
            // La patente se envía en mayúsculas luego de hacer Trim.
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los turnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






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
            MenuTurnos PantallaMenuTurnos = new MenuTurnos();
            Hide();
            PantallaMenuTurnos.ShowDialog();
        }
    }
}
