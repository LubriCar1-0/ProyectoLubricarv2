using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class MenuTurnosTrabajos : Form
    {
        public MenuTurnosTrabajos()
        {
            InitializeComponent();
        }

        private void MenuOrdenDeTrabajo_Load(object sender, EventArgs e)
        {
            // Configurar los DateTimePicker para mostrar el formato deseado
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd"; // Solo fecha

            dtpHora.Format = DateTimePickerFormat.Custom;
            dtpHora.CustomFormat = "HH:mm"; // Solo hora

            txbNombre.ReadOnly = true;
            txbApellido.ReadOnly = true;
            txbPatente.ReadOnly = true;
            TxbDescripcion.ReadOnly = true;

            DtpFechaCargada.Enabled = false;
            dtpHora.Enabled = false;

            CargarTurnos();
            CargarVehiculos();
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return; 

            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];

            if (filaSeleccionada != null)
            {
                txbNombre.Text = filaSeleccionada.Cells["Nombre"].Value?.ToString().ToUpper() ?? "";
                txbApellido.Text = filaSeleccionada.Cells["Apellido"].Value?.ToString().ToUpper() ?? "";
                txbPatente.Text = filaSeleccionada.Cells["Patente"].Value?.ToString() ?? "";
                TxbDescripcion.Text = filaSeleccionada.Cells["Descripción"].Value?.ToString().ToUpper() ?? "";

                if (DateTime.TryParse(filaSeleccionada.Cells["Fecha"].Value?.ToString(), out DateTime fecha))
                {
                    DtpFechaCargada.Value = fecha; 
                }

                if (TimeSpan.TryParse(filaSeleccionada.Cells["Hora"].Value?.ToString(), out TimeSpan hora))
                {
                    dtpHora.Value = DateTime.Today.Add(hora); 
                }
            }
        }
        private void dtpHora_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime horaSeleccionada = dtpHora.Value;

            
            int minutos = horaSeleccionada.Minute;
            int minutosRedondeados = (minutos / 30) * 30;

            
            DateTime horaRedondeada = new DateTime(
                horaSeleccionada.Year,
                horaSeleccionada.Month,
                horaSeleccionada.Day,
                horaSeleccionada.Hour,
                minutosRedondeados,
                0 
            );

            
            DateTime horaMinima = new DateTime(horaSeleccionada.Year, horaSeleccionada.Month, horaSeleccionada.Day, 8, 0, 0); 
            DateTime horaMaxima = new DateTime(horaSeleccionada.Year, horaSeleccionada.Month, horaSeleccionada.Day, 20, 0, 0); 
            if (horaRedondeada < horaMinima)
            {
                dtpHora.Value = horaMinima; 
            }
            else if (horaRedondeada > horaMaxima)
            {
                dtpHora.Value = horaMaxima; 
            }
            else
            {
                dtpHora.Value = horaRedondeada; 
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string nombre = txbNombre.Text.Trim();
                string apellido = txbApellido.Text.Trim();
                string patente = txbPatente.Text.Trim();
                DateTime dia = dtpFecha.Value.Date;
                TimeSpan soloHora = dtpHora.Value.TimeOfDay;
                string descripcion = TxbDescripcion.Text.Trim();

               
                MenuOrdenDeTrabajo PantOrdenDeTrabajo = new MenuOrdenDeTrabajo(nombre, apellido, patente, dia, soloHora, descripcion);

                MessageBox.Show("Se ha creado la Orden de Trabajo Correctamente");
                LimpiaTextBox();
                CargarTurnos();

                
                this.Hide();
                PantOrdenDeTrabajo.ShowDialog(); 
                this.Show();

                
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
            DtpFechaCargada.Text = string.Empty;
            dtpHora.Text = string.Empty;
            TxbDescripcion.Text = string.Empty;

        }

        private void btnRecargar_Click_1(object sender, EventArgs e)
        {
            
            dtpFecha.CustomFormat = " ";           
            dtpFecha.Value = DateTime.Today;
            DtpFechaCargada.CustomFormat = " ";
            DtpFechaCargada.Value = DateTime.Today;      
            //dtpHora.CustomFormat = " "; 
            dtpHora.Value = DateTime.Now;
            cmbSelecVH.SelectedIndex = -1;
            txtTelCliente.Clear();
            txbApellido.Clear();
            txbNombre.Clear();
            txbPatente.Clear();
            TxbDescripcion.Clear();
            CargarTurnos();
        }

        private void DtpFechaCargada_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MenuTurnos PantMenuTurnos = new MenuTurnos();
            Hide();
            PantMenuTurnos.ShowDialog();
        }
    }
}
