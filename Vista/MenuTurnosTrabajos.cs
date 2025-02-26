﻿using System;
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
        #region Variables 
        string telefono;
        string patente;
        string fecha;
        string estado = null;
        private int idTurno = 0;
        private int idCliente = 0;
        private int idVehiculo = 0;
        private string NombreCompleto;
        private string VehiculoCompleto;
        #endregion

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
            txbNombre.ReadOnly = true;
            txbApellido.ReadOnly = true;
            txbPatente.ReadOnly = true;

            CargarTurnos();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string telefono = string.IsNullOrEmpty(txtTelCliente.Text) ? null : txtTelCliente.Text.Trim();
            string patente = string.IsNullOrEmpty(txtPatente.Text) ? null : txtPatente.Text.Trim().ToUpper();
            string fecha = dtpFecha.CustomFormat != " " ? dtpFecha.Value.ToString("yyyy-MM-dd") : null;

            
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
        
        

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];

            if (filaSeleccionada != null)
            {

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

                if (DateTime.TryParse(filaSeleccionada.Cells["Fecha"].Value?.ToString(), out DateTime fechaTurno))
                {

                    DtpFechaCargada.MinDate = DateTimePicker.MinimumDateTime;


                    DtpFechaCargada.Value = fechaTurno;
                    DtpFechaCargada.MinDate = fechaTurno.AddDays(1);
                }


                idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                idVehiculo = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
                idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);

                string estadoTurnoSeleccionado = filaSeleccionada.Cells["Estado"].Value?.ToString().ToUpper().Trim() ?? "";

                if (estadoTurnoSeleccionado == "ACTIVO")
                {
                    BtnAgregar.Visible = true;
                    BtnAgregar.Enabled = true;
                    TxbDescripcion.ReadOnly = false;
                    cmbTrabajador.Enabled = true;
                    DtpFechaCargada.ShowUpDown = false; // Oculta el calendario emergente
                    DtpFechaCargada.Enabled = true; // Bloquea la modificación
                    btnVisualizarOrden.Visible = false;
                    btnVisualizarOrden.Enabled = false;
                }
                else if (estadoTurnoSeleccionado == "INICIADO")
                {
                    BtnAgregar.Visible = false;
                    BtnAgregar.Enabled = false;
                    btnVisualizarOrden.Enabled = true;
                    btnVisualizarOrden.Visible = true;
                    TxbDescripcion.ReadOnly = true;
                    cmbTrabajador.Enabled = false;
                    DtpFechaCargada.ShowUpDown = true; // Oculta el calendario emergente
                    DtpFechaCargada.Enabled = false; // Bloquea la modificación

                    // Llamada al método que obtiene los datos de la orden de trabajo según el idTurno
                    DataTable dtOrden = ValidarOrdenDeTrabajo.ObtDatosOrden(idTurno);
                    if (dtOrden != null && dtOrden.Rows.Count > 0)
                    {
                        DataRow rowOrden = dtOrden.Rows[0];
                        // Se utilizan los campos concatenados del store procedure
                        string trabajadorCompleto = rowOrden["TrabajadorCompleto"].ToString().Trim();
                        VehiculoCompleto = rowOrden["VehiculoCompleto"].ToString().Trim();

                        // Cargar los datos obtenidos en los controles correspondientes
                        TxbDescripcion.Text = rowOrden["descripcion"].ToString().ToUpper();
                        idOrdenDeTrabajo = Convert.ToInt32(rowOrden["idOrdenTrabajo"]);
                        cmbTrabajador.Text = trabajadorCompleto; // Muestra nombre y apellido juntos
                        if (DateTime.TryParse(rowOrden["FechaDeInicio"].ToString(), out DateTime fechaInicioOrden))
                        {
                            DtpFechaCargada.Value = fechaInicioOrden;
                            
                        }
                        
                        
                    }

                }
            }
        }
        int idOrdenDeTrabajo;




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

            DtpFechaCargada.MinDate = DateTimePicker.MinimumDateTime;

            
            DtpFechaCargada.CustomFormat = " ";

            // Opcional: Restablecer el valor a la fecha actual
            // DtpFechaCargada.Value = DateTime.Today;

            
            txtPatente.Clear();
            txtTelCliente.Clear();
            txbApellido.Clear();
            txbNombre.Clear();
            txbPatente.Clear();
            TxbDescripcion.Clear();

         
            CargarTurnos();

            
            DtpFechaCargada.ValueChanged += DtpFechaCargada_ValueChanged;

            cmbTrabajador.SelectedIndex = -1;
        }




        private void DtpFechaCargada_ValueChanged(object sender, EventArgs e)
        {
            DtpFechaCargada.CustomFormat = "yyyy-MM-dd";
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void btnVisualizarOrden_Click(object sender, EventArgs e)
        {
            if (idOrdenDeTrabajo == 0)
            {
                MessageBox.Show("No se selecciono ninguna orden de trabajo");
            }
            else
            {
                MenuOrdenDeTrabajo formOrden = new MenuOrdenDeTrabajo();

                
                formOrden.idOrdenTrab = idOrdenDeTrabajo;
                formOrden.Patente = txbPatente.Text;
                formOrden.Cliente = NombreCompleto;
                formOrden.Trabajador = cmbTrabajador.Text;
                formOrden.DescripcionOrden = TxbDescripcion.Text;
                formOrden.FechaInicioOrden = DtpFechaCargada.Value;
                formOrden.Vehiculo = VehiculoCompleto;
                formOrden.EstadoOrden = "INICIADO";


                formOrden.ShowDialog();
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
