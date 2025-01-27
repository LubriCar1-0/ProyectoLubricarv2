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
            dtpHorario.ShowUpDown = true; // Esto cambia el control a un spinner para seleccionar hora y minutos.

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

                // Llamar al método para cargar los vehículos filtrados
                CargarVehiculos(idCliente);
            }
        }

        private void CargarVehiculos(int idCliente)
        {
            CbxSelectVH.Items.Clear(); // Limpiar el ComboBox antes de cargar nuevos datos

            Dictionary<int, string> vehiculos = validarTurnos.ObtenerVehiculosPorCliente(idCliente);
            foreach (var vehiculo in vehiculos)
            {
                CbxSelectVH.Items.Add(new KeyValuePair<int, string>(vehiculo.Key, vehiculo.Value));
            }

            CbxSelectVH.DisplayMember = "Value";
            CbxSelectVH.ValueMember = "Key";
        }


        private void BtnCrearTurnoMeCrearTurno_Click(object sender, EventArgs e)
        {
            try
            {

                // Validar que se haya seleccionado un cliente
                if (idCliente == 0)
                {
                    MessageBox.Show("Seleccione un cliente válido.");
                    return;
                }

                // Validar que se haya seleccionado un vehículo
                if (idVehiculo == 0)
                {
                    MessageBox.Show("Seleccione un vehículo válido.");
                    return;
                }

                // Extraer los valores de los controles
                DateTime dia = dtpSelecionarDia.Value.Date; // Obtener solo la fecha
                DateTime hora = dtpHorario.Value; // Obtener fecha y hora seleccionada
                string descripcion = TxtDescripcionTurno.Text.Trim(); // Obtener el texto del TextBox

                // Validar que la descripción no esté vacía
                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }

                // Llamar al método para agregar el turno
                validarTurnos.AgregarUnturno(dia, hora, idCliente, idVehiculo, descripcion);

                // Limpia los campos si es necesario
                //LimpiaTextBox();
                // CargarDatosEnGrid();

                MessageBox.Show("El Turno ha sido registrado con éxito");




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];
            int idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);
            int idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
            int idVehiculo = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);

            //CbxClienteMeVehiculos.Text = ValidarClientes.ObtNomCliente(idCliente);
            //TxtModeloVehiculos.Text = filaSeleccionada.Cells["modeloVH"].Value.ToString();
            //TxtMarcaVehiculos.Text = filaSeleccionada.Cells["marcaVH"].Value.ToString();
            //TxtAñoVehiculos.Text = filaSeleccionada.Cells["añoVh"].Value.ToString();
            //TxtPatenteVehiculo.Text = filaSeleccionada.Cells["patenteVH"].Value.ToString();
            //TxtKilometrajeVehiculos.Text = filaSeleccionada.Cells["KilometrajeVH"].Value.ToString();

            if (dgvTurnos.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionadaUPD = dgvTurnos.Rows[e.RowIndex];

                    int idVehiculoUPD = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
                    int idClienteUPD = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);

                    string ModeloUPD = filaSeleccionada.Cells["modeloVH"].Value.ToString().Trim();
                    string MarcaUPD = filaSeleccionada.Cells["marcaVH"].Value.ToString().Trim();
                    string AñoUPD = filaSeleccionada.Cells["añoVh"].Value.ToString().Trim();
                    string PatenteUPD = filaSeleccionada.Cells["patenteVH"].Value.ToString().Trim();
                    string KilometrajeUPD = filaSeleccionada.Cells["KilometrajeVH"].Value.ToString().Trim();
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



                    if (resultado == DialogResult.Yes)
                    {

                        ValidarClientes.ModificacionVehiculo(idVehiculo, idCliente, ModeloUPD.Trim(), MarcaUPD.Trim(), Convert.ToInt32(AñoUPD.Trim()), PatenteUPD.Trim(), Convert.ToInt32(KilometrajeUPD.Trim()));
                        Console.WriteLine("Cambio realizado.");
                        //LimpiaTextBox();
                        //CargarDatosEnGrid();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        //CargarDatosEnGrid();
                    }
                }
            }
            else if (dgvTurnos.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.RowIndex >= 0)
                {
                    int idVehiculoUPD = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
                    int idClienteUPD = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                    string Estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                        if (Estado == "ACT")
                        {
                            ValidarClientes.BajaAltaVehiculo(idVehiculoUPD, "DES");
                            MessageBox.Show("Vehiculo DADO DE BAJA.");
                            //CargarDatosEnGrid();
                            //ConfigurarDataGridView();
                            dgvTurnos.Columns["idTurno"].Visible = false;
                            dgvTurnos.Columns["idVehiculo"].Visible = false;
                            dgvTurnos.Columns["idCliente"].Visible = false;
                        }
                        else if (Estado == "DES")
                        {
                            ValidarClientes.BajaAltaVehiculo(idVehiculoUPD, "ACT");
                            MessageBox.Show("Empleado DADO DE ALTA");
                            //CargarDatosEnGrid();
                            //ConfigurarDataGridView();
                            dgvTurnos.Columns["idTurno"].Visible = false;
                            dgvTurnos.Columns["idVehiculo"].Visible = false;
                            dgvTurnos.Columns["idCliente"].Visible = false;
                        }
                    }
                    else if (resultado == DialogResult.No)
                    {
                        //CargarDatosEnGrid(); 
                    }

                }
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MenuTurnos llamarMenuTurnos = new MenuTurnos();
            Hide();
            llamarMenuTurnos.ShowDialog();
        }
    }
}
