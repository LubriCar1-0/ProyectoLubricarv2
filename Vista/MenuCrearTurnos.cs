using System;
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
    public partial class MenuCrearTurnos : Form
    {
        public MenuCrearTurnos()
        {
            InitializeComponent();
            CargarClientes();
            CbxSelectCL.SelectedIndexChanged += CbxSelectCL_SelectedIndexChanged;
            CbxSelectVH.SelectedIndexChanged += CbxSelectVH_SelectedIndexChanged; 
            CargarTurnos();
            ConfigurarDateTimePickerHora();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuTurnos llamarMenuTurnos = new MenuTurnos();
            Hide();
            llamarMenuTurnos.ShowDialog();
        }

        private void MenuCrearTurnos_Load(object sender, EventArgs e)
        {

        }

        private void dtpHorario_ValueChanged(object sender, EventArgs e)
        {
            dtpHorario.Format = DateTimePickerFormat.Time;
            dtpHorario.ShowUpDown = true; 

        }

        private void CargarClientes()
        {
            Dictionary<int, string> clientes = ValidarClientes.ObtenerClientesProcesados();
            foreach (var cliente in clientes)
            {
                CbxSelectCL.Items.Add(new KeyValuePair<int, string>(cliente.Key, cliente.Value));
            }
            CbxSelectCL.DisplayMember = "Value";
            CbxSelectCL.ValueMember = "Key";
            
        }
        private int idCliente;
        private int idVehiculo;
        private void CbxSelectCL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxSelectCL.SelectedItem is KeyValuePair<int, string> clienteSeleccionado)
            {
                idCliente = clienteSeleccionado.Key;

               
                CargarVehiculos(idCliente);
            }
        }

        private void CargarVehiculos(int idCliente)
        {
            Console.WriteLine($"Cargando vehículos para el cliente con ID: {idCliente}"); // Depuración
            CbxSelectVH.Items.Clear();

            Dictionary<int, string> vehiculos = validarTurnos.ObtenerVehiculosPorCliente(idCliente);

            if (vehiculos.Count == 0)
            {
                Console.WriteLine("No se encontraron vehículos para este cliente."); // Depuración
            }

            foreach (var vehiculo in vehiculos)
            {
                CbxSelectVH.Items.Add(new KeyValuePair<int, string>(vehiculo.Key, vehiculo.Value));
            }

            CbxSelectVH.DisplayMember = "Value";
            CbxSelectVH.ValueMember = "Key";
            
        }
        private void CbxSelectVH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxSelectVH.SelectedItem is KeyValuePair<int, string> vehiculoSeleccionado)
            {
                idVehiculo = vehiculoSeleccionado.Key;
                
            }
        }




        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MenuTurnos llamarMenuTurnos = new MenuTurnos();
            Hide();
            llamarMenuTurnos.ShowDialog();
        }

        private void dgvTurnos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];
            int idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);
            int idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
            int idVehiculo = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
            CbxSelectCL.Text = ValidarClientes.ObtNomCliente(idCliente);
            CbxSelectVH.Text = validarTurnos.ObtNomVehiculo(idVehiculo);
            TxtDescripcionTurno.Text = filaSeleccionada.Cells["descripcion"].Value.ToString();
            if (DateTime.TryParse(filaSeleccionada.Cells["Fecha"].Value?.ToString(), out DateTime fecha))
            {
                dtpSelecionarDia.Value = fecha; 
            }

            if (TimeSpan.TryParse(filaSeleccionada.Cells["Hora"].Value?.ToString(), out TimeSpan hora))
            {
                DateTime fechaHora = DateTime.Today.Add(hora); 
                dtpHorario.Value = fechaHora; 
            }

            if (dgvTurnos.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    
                    string DescUPD = filaSeleccionada.Cells["descripcion"].Value?.ToString();
                    int idClienteUPD = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                    int idVehiculoUPD = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
                    CbxSelectVH.SelectedValue = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);

                    
                    if (DateTime.TryParse(filaSeleccionada.Cells["Fecha"].Value?.ToString(), out DateTime fechaupd))
                    {
                        dtpSelecionarDia.Value = fechaupd; 
                    }

                    
                    if (TimeSpan.TryParse(filaSeleccionada.Cells["Hora"].Value?.ToString(), out TimeSpan horaupd))
                    {
                        DateTime fechaHoraupd = DateTime.Today.Add(horaupd); 
                        dtpHorario.Value = fechaHoraupd; 
                    }
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



                    if (resultado == DialogResult.Yes)
                    {

                        validarTurnos.ModificacionTurno(idTurno, idVehiculoUPD, idClienteUPD, fechaupd, horaupd, DescUPD);
                        Console.WriteLine("Cambio realizado.");
                        //LimpiaTextBox();
                        CargarClientes();
                        LimpiaTextBox();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        LimpiaTextBox();
                        CargarClientes();
                    }
                }
            }
            else if (dgvTurnos.Columns[e.ColumnIndex].Name == "Cancelar")
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
                            LimpiaTextBox();
                            //ConfigurarDataGridView();
                            dgvTurnos.Columns["idTurno"].Visible = false;
                            dgvTurnos.Columns["idVehiculo"].Visible = false;
                            dgvTurnos.Columns["idCliente"].Visible = false;
                        }
                        else if (Estado == "DES")
                        {
                            MessageBox.Show("Este turno ya ha sido cancelado");
                            CargarClientes();
                            LimpiaTextBox();


                        }
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarClientes(); 
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los vehículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Configuracion del tiempo
        private void dtpHorario_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime horaSeleccionada = dtpHorario.Value;

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
                dtpHorario.Value = horaMinima; // Ajustar a la hora mínima si está por debajo
            }
            else if (horaRedondeada > horaMaxima)
            {
                dtpHorario.Value = horaMaxima; // Ajustar a la hora máxima si está por encima
            }
            else
            {
                dtpHorario.Value = horaRedondeada; // Establecer la hora redondeada
            }

        }
        private void ConfigurarDateTimePickerHora()
        {
            dtpHorario.Format = DateTimePickerFormat.Time; // Mostrar solo la hora
            dtpHorario.ShowUpDown = true;                 // Usar spinner en lugar de calendario
            dtpHorario.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0); // Valor inicial (8:00 AM)

            dtpHorario.ValueChanged += DtpHorario_ValueChanged; // Interceptar cambios en el valor
        }

        // Variable para rastrear el último valor del DateTimePicker
        private DateTime ultimoValor = DateTime.Now.Date.AddHours(8); // Inicial en 8:00 AM

        private void DtpHorario_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker picker = sender as DateTimePicker;

            // Obtener la hora actual del control
            DateTime horaActual = picker.Value;

            // Determinar si el cambio fue un incremento o decremento
            int intervalo = (horaActual > ultimoValor) ? 30 : -30;

            // Aplicar el incremento o decremento de 30 minutos
            DateTime nuevaHora = ultimoValor.AddMinutes(intervalo);

            // Rango permitido: 8:00 AM a 8:00 PM
            DateTime horaMinima = new DateTime(horaActual.Year, horaActual.Month, horaActual.Day, 8, 0, 0);
            DateTime horaMaxima = new DateTime(horaActual.Year, horaActual.Month, horaActual.Day, 20, 0, 0);

            // Validar que la nueva hora esté dentro del rango permitido
            if (nuevaHora >= horaMinima && nuevaHora <= horaMaxima)
            {
                picker.Value = nuevaHora; // Actualizar el valor del DateTimePicker
                ultimoValor = nuevaHora;  // Guardar el nuevo valor como referencia
            }
            else
            {
                picker.Value = ultimoValor; // Revertir al último valor válido si está fuera de rango
            }
        }



        private void dtpSelecionarDia_ValueChanged(object sender, EventArgs e)
        {
            dtpSelecionarDia.Format = DateTimePickerFormat.Short;

        }
        #endregion

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            MenuClientes PantallaMenuClientes = new MenuClientes();
            Hide();
            PantallaMenuClientes.ShowDialog();
        }

        private void btnBorraCampos_Click(object sender, EventArgs e)
        {
            LimpiaTextBox();
        }

        public void LimpiaTextBox()
        {
            CbxSelectCL.Text = string.Empty;
            CbxSelectVH.Text = string.Empty;
            dtpSelecionarDia.Text = string.Empty;
            dtpHorario.Text = string.Empty;
            TxtDescripcionTurno.Text = string.Empty;
            

        }

        private void BtnCrearTurno_Click(object sender, EventArgs e)
        {
            try
            {


                if (idCliente == 0)
                {
                    MessageBox.Show("Seleccione un cliente válido.");
                    return;
                }


                if (idVehiculo == 0)
                {
                    MessageBox.Show("Seleccione un vehículo válido.");
                    return;
                }

                DateTime dia = dtpSelecionarDia.Value.Date;
                DateTime hora = dtpHorario.Value;
                string descripcion = TxtDescripcionTurno.Text.Trim();


                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }


                validarTurnos.AgregarUnturno(dia, hora, idCliente, idVehiculo, descripcion);


                LimpiaTextBox();
                CargarTurnos();

                MessageBox.Show("El Turno ha sido registrado con éxito");




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        
    }
}
