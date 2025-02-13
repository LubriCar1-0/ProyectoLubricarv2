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
    public partial class MenuBitacora : Form
    {
        public MenuBitacora()
        {
            InitializeComponent();
            CargarTrabajador();
            CargarBitacora();

            
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void CargarTrabajador()
        {

            Dictionary<int, string> Trabajador = ValidarBitacora.ObtenerTrabajador();

            

            foreach (var Trabajadores in Trabajador)
            {
                cmbTrabajador.Items.Add(new KeyValuePair<int, string>(Trabajadores.Key, Trabajadores.Value));
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
            string accion = string.IsNullOrEmpty(txtAccion.Text) ? null : txtAccion.Text.Trim();

            // Si el formato sigue siendo " ", significa que el usuario nunca seleccionó una fecha
            string fecha = dtpFecha.CustomFormat == " " ? null : dtpFecha.Value.ToString("yyyy-MM-dd");

            int trabajadorId = cmbTrabajador.SelectedItem is KeyValuePair<int, string> seleccionado ? seleccionado.Key : 0;

            if (accion == null && fecha == null && trabajadorId == 0)
            {
                MessageBox.Show("Debe ingresar algún dato para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarBitacora();
            }
            else
            {
                CargaBitacoraFiltro(accion, fecha, trabajadorId);
            }
        }

        private void CargaBitacoraFiltro(string accion, string fecha, int trabajadorId)
        {
            try
            {
                dgvTurnos.DataSource = null;
                var turnos = ValidarBitacora.BitacoraFiltro(accion, fecha, trabajadorId);
                dgvTurnos.DataSource = turnos;
                dgvTurnos.RowHeadersVisible = false;
                
                if (dgvTurnos.Columns.Contains("idBitacora"))
                {
                    dgvTurnos.Columns["idBitacora"].Visible = false;
                }
                if (dgvTurnos.Columns.Contains("idTrabajador"))
                {
                    dgvTurnos.Columns["idTrabajador"].Visible = false;
                }
                // Ajustar columnas al tamaño del DataGridView
                foreach (DataGridViewColumn column in dgvTurnos.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la Bitacora: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarBitacora()
        {
            try
            {
                dgvTurnos.DataSource = null;
                dgvTurnos.DataSource = ValidarBitacora.BuscarBitacora();
                dgvTurnos.RowHeadersVisible = false;

                if (dgvTurnos.Columns.Contains("idBitacora"))
                {
                    dgvTurnos.Columns["idBitacora"].Visible = false;
                }
                if (dgvTurnos.Columns.Contains("idTrabajador"))
                {
                    dgvTurnos.Columns["idTrabajador"].Visible = false;
                }

                // Ajustar columnas al tamaño del DataGridView
                foreach (DataGridViewColumn column in dgvTurnos.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la Bitacora: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MenuBitacora_Load(object sender, EventArgs e)
        {
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = " "; // Hace que parezca vacío al iniciar
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            txtAccion.Clear();
            dtpFecha.CustomFormat = " ";
            cmbTrabajador.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuHistorial pantallaHistoriales = new MenuHistorial();
            Hide();
            pantallaHistoriales.ShowDialog();
        }
    }
}
