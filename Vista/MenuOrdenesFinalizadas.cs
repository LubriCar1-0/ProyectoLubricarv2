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
    public partial class MenuOrdenesFinalizadas : Form
    {
        public MenuOrdenesFinalizadas()
        {
            InitializeComponent();
            CargarTrabajador();
            CargarOrdenes();
            
        }
        int idOrdenTrab;
        private void MenuOrdenesFinalizadas_Load(object sender, EventArgs e)
        {
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = " ";

            txbCliente.ReadOnly = true;
            txtTrabajador.ReadOnly = true;
            txtVehiculo.ReadOnly = true;
        }

        private void CargarTrabajador()
        {

            List<Empleados> Trabajadores = ValidarBitacora.ObtenerListaTrabajadores(); // Cambiamos a una lista
            cmbTrabajador.Items.Clear();



            foreach (var Trabajador in Trabajadores)
            {
                cmbTrabajador.Items.Add(new KeyValuePair<int, string>(Trabajador.idtrabajador, $"{Trabajador.Nombre} {Trabajador.Apellido}"));
            }

            cmbTrabajador.DisplayMember = "Value";
            cmbTrabajador.ValueMember = "Key";

        }

        private void cmbTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrabajador.SelectedItem is KeyValuePair<int, string> TrabajadorSeleccionado)
            {
                int TrabajadorId = TrabajadorSeleccionado.Key;

            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string patente = string.IsNullOrEmpty(txtPatente.Text) ? null : txtPatente.Text.Trim().ToUpper();

            
            string fecha = dtpFecha.CustomFormat == " " ? null : dtpFecha.Value.ToString("yyyy-MM-dd");

            int trabajadorId = cmbTrabajador.SelectedItem is KeyValuePair<int, string> seleccionado ? seleccionado.Key : 0;

            string estado = "FINALIZADO";

            if (patente == null && fecha == null && trabajadorId == 0)
            {
                MessageBox.Show("Debe ingresar algún dato para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarOrdenes();
            }
            else
            {
                CargarOrdenesFiltro(patente, fecha, trabajadorId,estado);
            }
        }
        private void CargarOrdenesFiltro(string patente, string fecha, int trabajadorId, string estado)
        {
            try
            {
                dgvOrdenesFinalizadas.DataSource = null;
                var Ordenes = ValidarOrdenDeTrabajo.OrdenesDeFiltro(patente, fecha, trabajadorId, estado);
                dgvOrdenesFinalizadas.DataSource = Ordenes;
                dgvOrdenesFinalizadas.RowHeadersVisible = false;

                if (dgvOrdenesFinalizadas.Columns.Contains("idOrdenTrab"))
                {
                    dgvOrdenesFinalizadas.Columns["idOrdenTrab"].Visible = false;
                }

                foreach (DataGridViewColumn column in dgvOrdenesFinalizadas.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la Bitacora: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarOrdenes()
        {
            try
            {
                dgvOrdenesFinalizadas.DataSource = null;
                dgvOrdenesFinalizadas.DataSource = ValidarOrdenDeTrabajo.BuscarOrdenes();
                dgvOrdenesFinalizadas.RowHeadersVisible = false;


                if (dgvOrdenesFinalizadas.Columns.Contains("idOrdenTrab"))
                {
                    dgvOrdenesFinalizadas.Columns["idOrdenTrab"].Visible = false;
                }

                foreach (DataGridViewColumn column in dgvOrdenesFinalizadas.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la Bitacora: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            txtPatente.Clear();
            dtpFecha.CustomFormat = " ";
            cmbTrabajador.SelectedIndex = -1;
            txbCliente.Clear();
            txtVehiculo.Clear();
            txtTrabajador.Clear();
            CargarOrdenes();
        }

        private void dgvOrdenesFinalizadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvOrdenesFinalizadas.Rows[e.RowIndex];
            idOrdenTrab = Convert.ToInt32(filaSeleccionada.Cells["idOrdenTrab"].Value);
            txbCliente.Text = filaSeleccionada.Cells["Cliente"].Value.ToString().Trim();
            txtVehiculo.Text = filaSeleccionada.Cells["Vehiculo"].Value.ToString().Trim();
            txtTrabajador.Text = filaSeleccionada.Cells["empleadoACargo"].Value.ToString().Trim();
        }

        private void btnVisualizarOrden_Click(object sender, EventArgs e)
        {
            MenuVentaServicio llamarVentaServ = new MenuVentaServicio(idOrdenTrab);
            llamarVentaServ.ShowDialog();
                
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
