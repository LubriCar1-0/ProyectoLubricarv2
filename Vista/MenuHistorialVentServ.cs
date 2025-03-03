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
    public partial class MenuHistorialVentServ : Form
    {
        public MenuHistorialVentServ()
        {
            InitializeComponent();
            dgvVentServ.ReadOnly = true;
            grpLista.Visible = false;
            CargatablaVentasServ();
        }

        private void MenuHistorialVentServ_Load(object sender, EventArgs e)
        {

        }
        private void CargatablaVentasServ()
        {
            try
            {
                dgvVentServ.DataSource = null;
                var productos = ValidarVentaServicio.VentaServicios();
                dgvVentServ.DataSource = productos;
                dgvVentServ.Columns["idVentaTotServ"].Visible = false;
                dgvVentServ.Columns["idOrdenTrab"].Visible = false;  

                ConfiguraDataGrid(dgvVentServ);
                AjustarEstiloGridVenta(dgvVentServ);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVentServ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionadaUPD = dgvVentServ.Rows[e.RowIndex];
                int IdVenta = Convert.ToInt32(filaSeleccionadaUPD.Cells["idOrdenTrab"].Value);
                dgvListaProd.DataSource = null;
                var Lista = ValidarVentaServicio.VentaServProductos(IdVenta);
                dgvListaProd.DataSource = Lista;
                grpLista.Visible = true;
                ConfiguraDataGrid(dgvListaProd);
                AjustarEstiloGridVentalista(dgvListaProd);




            }
        }
        #region Ajuste de Grid
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
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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

        private void AjustarEstiloGridVenta(DataGridView dgv)
        {

            dgv.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 13.05f, FontStyle.Regular);

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 14.05f, FontStyle.Bold);

            dgv.RowTemplate.Height = 40;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void AjustarEstiloGridVentalista(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new Font("Microsoft YaHei UI", 11.05f, FontStyle.Regular);

            
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 12.05f, FontStyle.Bold);

            dgv.RowTemplate.Height = 40;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #endregion

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
                dgvVentServ.DataSource = null;
                var productos = ValidarVentaServicio.FiltroHistorialDeVentServ(fechaDesde, fechaHasta);
                dgvVentServ.DataSource = productos;
                dgvVentServ.ReadOnly = true;
                dgvVentServ.Columns["idVentaTotServ"].Visible = false;
                dgvVentServ.Columns["idOrdenTrab"].Visible = false;

                ConfiguraDataGrid(dgvVentServ);
                AjustarEstiloGridVenta(dgvVentServ);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpLista.Visible = false;
        }
    }
}
