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
    public partial class MenuHistorialVentas : Form
    {
        public MenuHistorialVentas()
        {
            InitializeComponent();
            CargatablaVentas();
            dtpFechaHasta.Value.AddDays(1);
            dgvVentas.Columns["IdVentaRes"].Visible = false;
            dgvVentas.ReadOnly = true;
            grpLista.Visible = false;
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionadaUPD = dgvVentas.Rows[e.RowIndex];
                int IdVenta = Convert.ToInt32(filaSeleccionadaUPD.Cells["IdVentaRes"].Value);
                dgvListaProd.DataSource = null;
                var Lista = ValidarVenta.VentasProductosLista(IdVenta);
                dgvListaProd.DataSource = Lista;
                grpLista.Visible = true;
                ConfiguraDataGrid(dgvListaProd);
                AjustarEstiloGridVentalista(dgvListaProd);




            }


        }

        private void CargatablaVentas()
        {
            try
            {
                dgvVentas.DataSource = null;
                var productos = ValidarVenta.VentasProductos();
                dgvVentas.DataSource = productos;
                dgvVentas.Columns["IdVentaRes"].Visible = false;

                ConfiguraDataGrid(dgvVentas);
                AjustarEstiloGridVenta(dgvVentas);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfiguraDataGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;

            // General
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Cabecera
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185); // Azul elegante
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Azul mÃ¡s claro
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Alternancia de color en filas
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 250);

            // Otros ajustes
            dgv.RowHeadersVisible = false; // Ocultar la primera columna de encabezado
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ScrollBars = ScrollBars.Both; // Asegurar barras de desplazamiento

            AplicarTrimDataGridView(dgv);
            
        }
        private void AplicarTrimDataGridView(DataGridView dgv)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value is string texto)
                    {
                        celda.Value = texto.Trim();
                    }
                }
            }
        }
        
        private void AjustarEstiloGridVenta(DataGridView dgv)
        {
            
            dgv.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 13.05f, FontStyle.Regular);

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 14.05f, FontStyle.Bold);

            dgv.RowTemplate.Height = 40;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void AjustarEstiloGridVentalista(DataGridView dgv)
        {
            // Definir la fuente para las celdas del DataGridView
            dgv.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 11.05f, FontStyle.Regular);

            // Definir la fuente para los encabezados de las columnas
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 12.05f, FontStyle.Bold);

            // Asegurar que el alto de las filas sea suficiente para la nueva fuente
            dgv.RowTemplate.Height = 40;

            // Ajustar el tamaño de las columnas para acomodar el texto
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpLista.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime Hoy = DateTime.Now;

            DateTime fechaDesde = Convert.ToDateTime(dtpFechaDesde.Value.ToString("yyyy-MM-dd"));
            DateTime fechaHasta = Convert.ToDateTime(dtpFechaHasta.Value.ToString("yyyy-MM-dd"));
            fechaHasta = fechaHasta.AddDays(1);        
            if (Hoy <= fechaDesde) 
           {
                MessageBox.Show("No puede ingresar una fecha mayor a hoy");
           }
           else
           {
                dgvVentas.DataSource = null;
                var productos = ValidarVenta.FiltroHistorialVentas(fechaDesde, fechaHasta);
                dgvVentas.DataSource = productos;
                dgvVentas.ReadOnly = true;
                dgvVentas.Columns["IdVentaRes"].Visible = false;

                ConfiguraDataGrid(dgvVentas);
                AjustarEstiloGridVenta(dgvVentas);
           }
              





        }

        private void MenuHistorialVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargatablaVentas();
        }
    }
}
