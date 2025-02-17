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
            CargarTrabajador();
            dgvTurnos.ReadOnly = true;
        }
        private void CargarTrabajador()
        {
            List<Empleados> Trabajadores = ValidarBitacora.ObtenerListaTrabajadores(); // Cambiamos a una lista
            cmbTrabajador.Items.Clear();

            foreach (var Trabajador in Trabajadores)
            {
                if (Trabajador.IdCat == 3) // Filtrar solo los trabajadores con IdCat = 3
                {
                    cmbTrabajador.Items.Add(new KeyValuePair<int, string>(Trabajador.idtrabajador, $"{Trabajador.Nombre} {Trabajador.Apellido}"));
                }
            }

            cmbTrabajador.DisplayMember = "Value";
            cmbTrabajador.ValueMember = "Key";
        }

        private string trabajadorSeleccionadoNombre = "";
        private void cmbTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrabajador.SelectedItem is KeyValuePair<int, string> TrabajadorSeleccionado)
            {
                int TrabajadorId = TrabajadorSeleccionado.Key;
                trabajadorSeleccionadoNombre = TrabajadorSeleccionado.Value;

            }
        }

        private void MenuOrdenDeTrabajo_Load(object sender, EventArgs e)
        {
            
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd"; 

           

            txbNombre.ReadOnly = true;
            txbApellido.ReadOnly = true;
            txbPatente.ReadOnly = true;
            

            //DtpFechaCargada.Enabled = false;
            

            CargarTurnos();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string telefono = string.IsNullOrEmpty(txtTelCliente.Text) ? null : txtTelCliente.Text.Trim();
            
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



       

        
        private void CargarTurnos()
        {
            try
            {
                dgvTurnos.DataSource = null;
                dgvTurnos.DataSource = validarTurnos.BuscarTurnos();
                dgvTurnos.RowHeadersVisible = false;

                if (dgvTurnos.Columns.Contains("idTurno"))
                    dgvTurnos.Columns["idTurno"].Visible = false;
                if (dgvTurnos.Columns.Contains("idVehiculo"))
                    dgvTurnos.Columns["idVehiculo"].Visible = false;
                if (dgvTurnos.Columns.Contains("idCliente"))
                    dgvTurnos.Columns["idCliente"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los vehículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Declaración de variables para almacenar el idCliente e idVehiculo seleccionados
        private int idTurno = 0;
        private int idCliente = 0;
        private int idVehiculo = 0;
        private string NombreCompleto;

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];

            if (filaSeleccionada != null)
            {
                // Obtener el valor de la columna "Cliente" (Nombre y Apellido concatenados)
                string clienteCompleto = filaSeleccionada.Cells["Cliente"].Value?.ToString() ?? "";

                // Separar el nombre y apellido
                string[] partes = clienteCompleto.Split(' ');
                string Apellido = partes.Length > 0 ? partes[0] : "";
                string Nombre = partes.Length > 1 ? string.Join(" ", partes.Skip(1)) : "";

                // Cargar en los TextBox
                txbNombre.Text = Nombre.ToUpper();
                txbApellido.Text = Apellido.ToUpper();
                NombreCompleto = filaSeleccionada.Cells["Cliente"].Value?.ToString().ToUpper() ?? "";
                txbPatente.Text = filaSeleccionada.Cells["patenteVH"].Value?.ToString() ?? "";
                TxbDescripcion.Text = filaSeleccionada.Cells["descripcion"].Value?.ToString().ToUpper() ?? "";

                // Obtener la fecha del turno
                if (DateTime.TryParse(filaSeleccionada.Cells["Fecha"].Value?.ToString(), out DateTime fechaTurno))
                {
                    DtpFechaCargada.Value = fechaTurno;
                    DtpFechaCargada.MinDate = fechaTurno.AddDays(1); // Bloquea fechas anteriores
                }

                idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                idVehiculo = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
                idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);
            }
        }




        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DtpFechaCargada.Value >= dtpFecha.Value)
                {
                    MessageBox.Show("La fecha de inicio de la orden de trabajo debe ser posterior a la fecha del turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                string patente = txbPatente.Text.Trim();
                DateTime dia = dtpFecha.Value.Date;
                int trabajadorId = cmbTrabajador.SelectedItem is KeyValuePair<int, string> seleccionado ? seleccionado.Key : 0;
                string descripcion = TxbDescripcion.Text.Trim();

                // Validar que se haya seleccionado un turno y se hayan asignado los IDs correctamente
                if (idCliente <= 0)
                {
                    MessageBox.Show("El idCliente no es válido o no se ha seleccionado un turno.");
                    return;
                }

                if (idVehiculo <= 0)
                {
                    MessageBox.Show("El idVehiculo no es válido o no se ha seleccionado un turno.");
                    return;
                }
                if (trabajadorId <= 0)
                {
                    MessageBox.Show("Debe seleccionar un trabajador antes de continuar.");
                    return;
                }

                ValidarOrdenDeTrabajo.CrearOrden(trabajadorSeleccionadoNombre, dia, descripcion, trabajadorId, idCliente, idVehiculo, idTurno);

                MessageBox.Show("Se ha creado la Orden de Trabajo Correctamente");
                LimpiaTextBox();
                CargarTurnos();
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
            
            TxbDescripcion.Text = string.Empty;

        }

        private void btnRecargar_Click_1(object sender, EventArgs e)
        {
            
            dtpFecha.CustomFormat = " ";           
            dtpFecha.Value = DateTime.Today;
            DtpFechaCargada.CustomFormat = " ";
            DtpFechaCargada.Value = DateTime.Today;      
            txtPatente.Clear();
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
