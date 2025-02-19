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
            CargaTurnosFiltro(telefono,patente,fecha,estado);
            dgvTurnos.ReadOnly = true;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = " ";
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTurnos.DataSource = validarTurnos.BuscarTurnos();
            dgvTurnos.RowHeadersVisible = false;


        }
        string telefono;
        string patente;
        string fecha;
        string estado = null;
        private void CargarTrabajador()
        {
            List<Empleados> Trabajadores = ValidarBitacora.ObtenerListaTrabajadores(); // Cambiamos a una lista
            cmbTrabajador.Items.Clear();

            foreach (var Trabajador in Trabajadores)
            {
                if (Trabajador.IdCat == 3) 
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
            
            //dtpFecha.Format = DateTimePickerFormat.Custom;
            //dtpFecha.CustomFormat = "yyyy-MM-dd"; 

           

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

            // Determinar el estado según los checkboxes
            string estado = null;
            if (chbIniciados.Checked && !chbActivos.Checked)
            {
                estado = "INICIADO";
            }
            else if (!chbIniciados.Checked && chbActivos.Checked)
            {
                estado = "ACTIVO";
            }
            

            
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
                // Obtener datos del cliente
                string clienteCompleto = filaSeleccionada.Cells["Cliente"].Value?.ToString() ?? "";
                string[] partes = clienteCompleto.Split(' ');
                string Apellido = partes.Length > 0 ? partes[0] : "";
                string Nombre = partes.Length > 1 ? string.Join(" ", partes.Skip(1)) : "";

                txbNombre.Text = Nombre.ToUpper();
                txbApellido.Text = Apellido.ToUpper();
                NombreCompleto = filaSeleccionada.Cells["Cliente"].Value?.ToString().ToUpper() ?? "";
                txbPatente.Text = filaSeleccionada.Cells["patenteVH"].Value?.ToString() ?? "";
                TxbDescripcion.Text = filaSeleccionada.Cells["descripcion"].Value?.ToString().ToUpper() ?? "";
                cmbTrabajador.SelectedIndex = -1;
                // Fecha
                if (DateTime.TryParse(filaSeleccionada.Cells["Fecha"].Value?.ToString(), out DateTime fechaTurno))
                {
                    // Resetear MinDate a su valor por defecto antes de asignar uno nuevo
                    DtpFechaCargada.MinDate = DateTimePicker.MinimumDateTime;  // Restablece a su valor más bajo permitido

                    // Asignar el nuevo valor y establecer MinDate solo si es necesario
                    DtpFechaCargada.Value = fechaTurno;
                    DtpFechaCargada.MinDate = fechaTurno.AddDays(1);
                }

                // IDs
                idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                idVehiculo = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
                idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);

                // Nuevo: Obtener el estado y mostrar/ocultar botones
                string estadoTurnoSeleccionado = filaSeleccionada.Cells["Estado"].Value?.ToString().ToUpper().Trim() ?? "";

                if (estadoTurnoSeleccionado == "ACTIVO")
                {
                    BtnAgregar.Visible = true;       // Crear Orden
                    btnVisualizarOrden.Visible = false;
                }
                else if (estadoTurnoSeleccionado == "INICIADO")
                {
                    BtnAgregar.Visible = false;
                    btnVisualizarOrden.Visible = true;  // Visualizar Orden
                    ValidarOrdenDeTrabajo.ObtenerOrden(idTurno);
                    TxbDescripcion.Enabled = false;
                }
                
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
            DtpFechaCargada.ValueChanged -= DtpFechaCargada_ValueChanged;

            // Resetear MinDate al valor más bajo permitido
            DtpFechaCargada.MinDate = DateTimePicker.MinimumDateTime;

            // Opcional: Restablecer el formato para que se vea vacío
            DtpFechaCargada.CustomFormat = " ";

            // Opcional: Restablecer el valor a la fecha actual
            // DtpFechaCargada.Value = DateTime.Today;

            // Limpiar otros controles
            txtPatente.Clear();
            txtTelCliente.Clear();
            txbApellido.Clear();
            txbNombre.Clear();
            txbPatente.Clear();
            TxbDescripcion.Clear();

            // Recargar la grilla
            CargarTurnos();

            // (Opcional) Si deseas que el evento se vuelva a conectar inmediatamente
            DtpFechaCargada.ValueChanged += DtpFechaCargada_ValueChanged;

            cmbTrabajador.SelectedIndex = -1;
        }




        private void DtpFechaCargada_ValueChanged(object sender, EventArgs e)
        {
            DtpFechaCargada.CustomFormat = "yyyy-MM-dd";
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MenuTurnos PantMenuTurnos = new MenuTurnos();
            Hide();
            PantMenuTurnos.ShowDialog();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void btnVisualizarOrden_Click(object sender, EventArgs e)
        {

        }
    }
}
