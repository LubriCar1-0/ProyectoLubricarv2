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
    public partial class MenuCanjeoLubriPuntos : Form
    {
        public MenuCanjeoLubriPuntos()
        {
            InitializeComponent();
            CargartablaClientes();
            ConfiguraDataGrid(DGVclientes);
            DGVclientes.CellClick += DGVclientes_CellContentClick;
        }

        private void CargartablaClientes()
        {
            try
            {
                DGVclientes.DataSource = null;
                DGVclientes.DataSource = ValidarLubriPuntos.TraerClientes();
                DGVclientes.Columns["idCliente"].Visible = false;
                DGVclientes.Columns["Localidad"].Visible = false;
                DGVclientes.Columns["Calle"].Visible = false;
                DGVclientes.Columns["Numero de vivienda"].Visible = false;
                DGVclientes.Columns["Telefono"].Visible = false;
                DGVclientes.Columns["idCondicionIva"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarClientesconfiltro(int dni)
        {
            try
            {
                DGVclientes.DataSource = null;
                var clientes = ValidarLubriPuntos.Clientesconfiltro(dni);
                DGVclientes.DataSource = clientes;
                DGVclientes.Columns["idCliente"].Visible = false;
                DGVclientes.Columns["Localidad"].Visible = false;
                DGVclientes.Columns["Calle"].Visible = false;
                DGVclientes.Columns["Numero de vivienda"].Visible = false;
                DGVclientes.Columns["Telefono"].Visible = false;
                DGVclientes.Columns["idCondicionIva"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = DGVclientes.Rows[e.RowIndex];
                string Cliente = filaSeleccionada.Cells["Nombre"].Value.ToString().Trim();
                int LubriPuntos = Convert.ToInt32(filaSeleccionada.Cells["LubriPuntos"].Value);
                lblNombreProd.Text = Cliente;
                lblLubriClientes.Text = LubriPuntos.ToString();
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

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            CargarClientesconfiltro(Convert.ToInt32(txtFiltroClientes));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
