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
            CargarVehiculos();
            //CargarTurnos();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = " "; // Inicialmente vacío
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];
            int idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);
            int idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
            int idVehiculo = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
            
            if (DateTime.TryParse(filaSeleccionada.Cells["Fecha"].Value?.ToString(), out DateTime fecha))
            {
               
            }

            if (TimeSpan.TryParse(filaSeleccionada.Cells["Hora"].Value?.ToString(), out TimeSpan hora))
            {
                DateTime fechaHora = DateTime.Today.Add(hora);
                
            }

            
            if (dgvTurnos.Columns[e.ColumnIndex].Name == "Cancelar")
            {
                if (e.RowIndex >= 0)
                {
                    int idTurnoUPD = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);

                    string Estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                        if (Estado == "ACT")
                        {
                            validarTurnos.CancelarTurno(idTurnoUPD, "DES");
                            MessageBox.Show("Turno CANCELADO.");
                            CargarTurnos();
                            
                            //ConfigurarDataGridView();
                            dgvTurnos.Columns["idTurno"].Visible = false;
                            dgvTurnos.Columns["idVehiculo"].Visible = false;
                            dgvTurnos.Columns["idCliente"].Visible = false;
                        }
                        else if (Estado == "DES")
                        {
                            MessageBox.Show("Este turno ya ha sido cancelado");
                            
                            


                        }
                    }
                    else if (resultado == DialogResult.No)
                    {
                        
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
                dgvTurnos.RowHeadersVisible = false; // Ocultar la primera columna de encabezado
                if (dgvTurnos.Columns.Contains("idVehiculo"))
                {
                    dgvTurnos.Columns["idVehiculo"].Visible = false;
                }
                if (dgvTurnos.Columns.Contains("idCliente"))
                {
                    dgvTurnos.Columns["idCliente"].Visible = false;
                }
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

        private void MenuCancelarTurno_Load(object sender, EventArgs e)
        {

        }

        // Variable para almacenar el ID del vehículo seleccionado
        private int idVehiculoSeleccionado = 0;

        private void CargarVehiculos()
        {
            Dictionary<int, string> vehiculos = validarTurnos.ObtenerVehiculos();

            cmbSelecVH.Items.Clear(); // Limpiar el ComboBox antes de cargar nuevos valores

            foreach (var vehiculo in vehiculos)
            {
                cmbSelecVH.Items.Add(new KeyValuePair<int, string>(vehiculo.Key, vehiculo.Value));
            }

            cmbSelecVH.DisplayMember = "Value";
            cmbSelecVH.ValueMember = "Key";

            // Agregar el evento al ComboBox
            cmbSelecVH.SelectedIndexChanged += CbxSelectVH_SelectedIndexChanged;
        }

        private void CbxSelectVH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelecVH.SelectedItem is KeyValuePair<int, string> vehiculoSeleccionado)
            {
                idVehiculoSeleccionado = vehiculoSeleccionado.Key; // Guardar el ID correctamente
            }
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
                //dgvTurnos.Columns["idTurno"].Visible = false;
                dgvTurnos.RowHeadersVisible = false; // Ocultar la primera columna de encabezado
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
        }
    }
}
