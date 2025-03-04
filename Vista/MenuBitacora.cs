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

            List<Empleados> Trabajadores = ValidarBitacora.ObtenerListaTrabajadores(); 
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
            string accion = string.IsNullOrEmpty(txtAccion.Text) ? null : txtAccion.Text.Trim();

            
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
                dgvBitacora.DataSource = null;
                var turnos = ValidarBitacora.BitacoraFiltro(accion, fecha, trabajadorId);
                dgvBitacora.DataSource = turnos;
                dgvBitacora.RowHeadersVisible = false;
                foreach (DataGridViewRow row in dgvBitacora.Rows)
                {
                    if (row.Cells["Hora"].Value is TimeSpan tiempo)
                    {
                        row.Cells["Hora"].Value = tiempo.ToString(@"hh\:mm\:ss");
                    }
                }

                if (dgvBitacora.Columns.Contains("idBitacora"))
                {
                    dgvBitacora.Columns["idBitacora"].Visible = false;
                }
                if (dgvBitacora.Columns.Contains("idTrabajador"))
                {
                    dgvBitacora.Columns["idTrabajador"].Visible = false;
                }

                ConfiguraDataGrid(dgvBitacora);
                AjustarEstiloGrid(dgvBitacora);
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
                dgvBitacora.DataSource = null;
                dgvBitacora.DataSource = ValidarBitacora.BuscarBitacora();
                dgvBitacora.RowHeadersVisible = false;
                foreach (DataGridViewRow row in dgvBitacora.Rows)
                {
                    if (row.Cells["Hora"].Value is TimeSpan tiempo)
                    {
                        row.Cells["Hora"].Value = tiempo.ToString(@"hh\:mm\:ss");
                    }
                }


                if (dgvBitacora.Columns.Contains("idBitacora"))
                {
                    dgvBitacora.Columns["idBitacora"].Visible = false;
                }
                if (dgvBitacora.Columns.Contains("idTrabajador"))
                {
                    dgvBitacora.Columns["idTrabajador"].Visible = false;
                }


                ConfiguraDataGrid(dgvBitacora);
                AjustarEstiloGrid(dgvBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la Bitacora: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Configurar la grid
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

        private void MenuBitacora_Load(object sender, EventArgs e)
        {
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = " "; 
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            txtAccion.Clear();
            dtpFecha.CustomFormat = " ";
            cmbTrabajador.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
