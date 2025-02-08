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
    public partial class MenuOrdenDeTrabajo : Form
    {
        public MenuOrdenDeTrabajo()
        {
            InitializeComponent();
        }

        private void MenuOrdenDeTrabajo_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string telefono = txtTelCliente.Text.Trim();
            int idCliente = !string.IsNullOrEmpty(telefono) ? validarTurnos.ObtIDCliente(Convert.ToInt32(telefono)) : -1;
            int? vehiculoID = cmbSelecVH.SelectedItem is KeyValuePair<int, string> vehiculoSeleccionado ? vehiculoSeleccionado.Key : (int?)null;
            string fecha = dtpFecha.CustomFormat != " " ? dtpFecha.Value.ToString("yyyy-MM-dd") : null;

            if (idCliente == -1 && vehiculoID == null && string.IsNullOrEmpty(fecha))
            {
                MessageBox.Show("Debe ingresar algún dato para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarTurnos();
            }
            else
            {
                CargaTurnosFiltro(idCliente, vehiculoID, fecha);
            }
        }
        private void CargaTurnosFiltro(int idCliente, int? idVehiculo, string fecha)
        {
            try
            {
                dgvTurnos.DataSource = null;
                var turnos = validarTurnos.TurnosFiltro(idCliente, idVehiculo, fecha);
                dgvTurnos.DataSource = turnos;

                dgvTurnos.RowHeadersVisible = false;
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
            //cmbSelecVH.Clear();
            txbApellido.Clear();
            CargarTurnos();

        }
        private int idVehiculoSeleccionado = 0;

        private void CargarVehiculos()
        {
            Dictionary<int, string> vehiculos = validarTurnos.ObtenerVehiculos();

            cmbSelecVH.Items.Clear();

            foreach (var vehiculo in vehiculos)
            {
                cmbSelecVH.Items.Add(new KeyValuePair<int, string>(vehiculo.Key, vehiculo.Value));
            }

            cmbSelecVH.DisplayMember = "Value";
            cmbSelecVH.ValueMember = "Key";


            cmbSelecVH.SelectedIndexChanged += CbxSelectVH_SelectedIndexChanged;
        }

        private void CbxSelectVH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelecVH.SelectedItem is KeyValuePair<int, string> vehiculoSeleccionado)
            {
                idVehiculoSeleccionado = vehiculoSeleccionado.Key; // Guardar el ID correctamente
            }
        }
        private void CargarTurnos()
        {
            try
            {
                dgvTurnos.DataSource = null;
                dgvTurnos.DataSource = validarTurnos.BuscarTurnos();
                dgvTurnos.RowHeadersVisible = false;
               
                if (dgvTurnos.Columns.Contains("idTurno"))
                {
                    dgvTurnos.Columns["idTurno"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los vehículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];
            int idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);
            //CbxClienteMeVehiculos.Text = ValidarClientes.ObtNomCliente(idCliente);
            txbNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            txbApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
            txbPatente.Text = filaSeleccionada.Cells["Patente"].Value.ToString();
            DtpFechaInicio.Text = filaSeleccionada.Cells["Fecha"].Value.ToString();
            dtpHora.Text = filaSeleccionada.Cells["Hora"].Value.ToString();
            TxbDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();



            if (DateTime.TryParse(filaSeleccionada.Cells["Fecha"].Value?.ToString(), out DateTime fecha))
            {

            }

            if (TimeSpan.TryParse(filaSeleccionada.Cells["Hora"].Value?.ToString(), out TimeSpan hora))
            {
                DateTime fechaHora = DateTime.Today.Add(hora);

            }
        }
        private void dtpHora_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime horaSeleccionada = dtpHora.Value;

            // Redondear la hora al múltiplo más cercano de 30 minutos
            int minutos = horaSeleccionada.Minute;
            int minutosRedondeados = (minutos / 30) * 30;

            // Ajustar la hora al intervalo más cercano de 30 minutos
            DateTime horaRedondeada = new DateTime(
                horaSeleccionada.Year,
                horaSeleccionada.Month,
                horaSeleccionada.Day,
                horaSeleccionada.Hour,
                minutosRedondeados,
                0 // Segundos en 0
            );

            // Verificar si la hora está fuera del rango permitido (8:00 AM a 8:00 PM)
            DateTime horaMinima = new DateTime(horaSeleccionada.Year, horaSeleccionada.Month, horaSeleccionada.Day, 8, 0, 0); // 8:00 AM
            DateTime horaMaxima = new DateTime(horaSeleccionada.Year, horaSeleccionada.Month, horaSeleccionada.Day, 20, 0, 0); // 8:00 PM

            if (horaRedondeada < horaMinima)
            {
                dtpHora.Value = horaMinima; // Ajustar a la hora mínima si está por debajo
            }
            else if (horaRedondeada > horaMaxima)
            {
                dtpHora.Value = horaMaxima; // Ajustar a la hora máxima si está por encima
            }
            else
            {
                dtpHora.Value = horaRedondeada; // Establecer la hora redondeada
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dia = dtpFecha.Value.Date;
                DateTime hora = dtpHora.Value;
                

                //validarTurnos.AgregarUnturno(txbNombre.Text, txbApellido.Text, txbPatente.Text, dia, hora, TxbDescripcion.Text);


                LimpiaTextBox();
                CargarTurnos();

                MessageBox.Show("Se ha creado la Orden de Trabajo Correctamente");




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        private void LimpiaTextBox()
        {
            txbNombre.Text = string.Empty;
            txbApellido.Text = string.Empty;
            txbPatente.Text = string.Empty;
            DtpFechaInicio.Text = string.Empty;
            dtpHora.Text = string.Empty;
            TxbDescripcion.Text = string.Empty;

        }
    }
}
