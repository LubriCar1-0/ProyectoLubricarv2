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
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = " ";
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar procesar clics en el encabezado
            if (e.RowIndex < 0)
                return;

            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];
            int idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);

            // Si se presionó el botón "Cancelar"
            if (dgvTurnos.Columns[e.ColumnIndex].Name == "Cancelar")
            {
                string estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    if (estado == "ACT")
                    {
                        validarTurnos.CancelarTurno(idTurno, "DES");
                        MessageBox.Show("Turno CANCELADO.");
                        CargarTurnos();
                    }
                    else if (estado == "DES")
                    {
                        MessageBox.Show("Este turno ya ha sido cancelado");
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
                // Ocultar la columna idTurno siempre
                if (dgvTurnos.Columns.Contains("idTurno"))
                    dgvTurnos.Columns["idTurno"].Visible = false;
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

            if (telefono == null && patente == null && string.IsNullOrEmpty(fecha))
            {
                MessageBox.Show("Debe ingresar algún dato para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarTurnos();
            }
            else
            {
                CargaTurnosFiltro(telefono, patente, fecha);
            }
        }

        private void CargaTurnosFiltro(string telefono, string patente, string fecha)
        {
            try
            {
                dgvTurnos.DataSource = null;
                var turnos = validarTurnos.TurnosFiltro(telefono, patente, fecha);
                dgvTurnos.DataSource = turnos;
                dgvTurnos.RowHeadersVisible = false;
                // Ocultar la columna idTurno
                if (dgvTurnos.Columns.Contains("idTurno"))
                    dgvTurnos.Columns["idTurno"].Visible = false;
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
    }
}
