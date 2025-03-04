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

           
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            CargarClientes();
            CbxSelectCL.SelectedIndexChanged += CbxSelectCL_SelectedIndexChanged;
            CbxSelectVH.SelectedIndexChanged += CbxSelectVH_SelectedIndexChanged;

            CargarTurnos();
            ConfigurarDateTimePickerHora();
            dgvTurnos.ReadOnly = true;
        }

        private bool cargandoTurno = false;
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
            Close();
        }

        int idTurno = 0;
        int idClienteBD = 0;
        int idVehiculoBD = 0;
        DateTime fecha;
        TimeSpan hora;
        private void dgvTurnos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cargandoTurno = true;
            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];
            idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);
            idClienteBD = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
            idVehiculoBD = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
            CbxSelectCL.Text = ValidarClientes.ObtNomCliente(idClienteBD);
            CbxSelectVH.Text = validarTurnos.ObtNomVehiculo(idVehiculoBD);
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
            ConfiguraDataGrid(dgvTurnos);
            cargandoTurno = false;
            CbxSelectCL.Enabled = false;
            CbxSelectVH.Enabled = false;
        }
        private void dtpHorario_ValueChanged_1(object sender, EventArgs e)
        {
            if (cargandoTurno) return;

            DateTime horaSeleccionada = dtpHorario.Value;
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
                dtpHorario.Value = horaMinima;
            }
            else if (horaRedondeada > horaMaxima)
            {
                dtpHorario.Value = horaMaxima;
            }
            else
            {
                dtpHorario.Value = horaRedondeada;
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
                ConfiguraDataGrid(dgvTurnos);
                AjustarEstiloGrid(dgvTurnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los vehículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Configuracion del tiempo
        
        private void ConfigurarDateTimePickerHora()
        {
            dtpHorario.Format = DateTimePickerFormat.Time; 
            dtpHorario.ShowUpDown = true;               
            dtpHorario.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0); 

            dtpHorario.ValueChanged += DtpHorario_ValueChanged; 
        }

        
        private DateTime ultimoValor = DateTime.Now.Date.AddHours(8); 

        private void DtpHorario_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker picker = sender as DateTimePicker;

            DateTime horaActual = picker.Value;

            
            int intervalo = (horaActual > ultimoValor) ? 30 : -30;

            DateTime nuevaHora = ultimoValor.AddMinutes(intervalo);

           
            DateTime horaMinima = new DateTime(horaActual.Year, horaActual.Month, horaActual.Day, 8, 0, 0);
            DateTime horaMaxima = new DateTime(horaActual.Year, horaActual.Month, horaActual.Day, 20, 0, 0);

            if (nuevaHora >= horaMinima && nuevaHora <= horaMaxima)
            {
                picker.Value = nuevaHora; 
                ultimoValor = nuevaHora;  
            }
            else
            {
                picker.Value = ultimoValor; 
            }
        }



        private void dtpSelecionarDia_ValueChanged(object sender, EventArgs e)
        {
            dtpSelecionarDia.Format = DateTimePickerFormat.Short;

        }
        #endregion

        #region Configuracion de grid
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

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 250);

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


        private void btnBorraCampos_Click(object sender, EventArgs e)
        {
            LimpiaTextBox();
        }

        public void LimpiaTextBox()
        {
            CbxSelectCL.Text = string.Empty;
            CbxSelectVH.Text = string.Empty;

            dtpSelecionarDia.Format = DateTimePickerFormat.Short;
            dtpSelecionarDia.Value = DateTime.Now; 

            
            dtpHorario.Format = DateTimePickerFormat.Time;
            dtpHorario.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0); 

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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea editar este registro?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                DateTime nuevaFecha = dtpSelecionarDia.Value;
                TimeSpan nuevaHora = dtpHorario.Value.TimeOfDay;
                string nuevaDescripcion = TxtDescripcionTurno.Text;

                validarTurnos.ModificacionTurno(idTurno, idClienteBD, idVehiculoBD, nuevaFecha, nuevaHora, nuevaDescripcion);

                MessageBox.Show("El registro se ha actualizado con éxito.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTurnos();
            }
            else
            {

                MessageBox.Show("La edición ha sido cancelada.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
