using Negocio;
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
    public partial class MenuVentaProductos : Form
    {
        public MenuVentaProductos()
        {
            InitializeComponent();
            CargatablaClientes();
            CargatablaProductos();
            ConfiguraDataGrid(dgvClientes);
            ConfiguraDataGrid(dgvProductos);
        }
        #region Volver pantalla anterior
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PantallaMenuVentas();
        }
        public static void PantallaMenuVentas()
        {
            MenuVentas LlamarMenuVentas = new MenuVentas();
            LlamarMenuVentas.ShowDialog();
        }
        #endregion
        #region carga tablas
        private void CargatablaClientes()
        {
            try
            {
                dgvClientes.DataSource = null;
                var productos = ValidarVenta.VentaClientes();
                dgvClientes.DataSource = productos;
                dgvClientes.Columns["idCliente"].Visible = false;
                dgvClientes.Columns["Localidad"].Visible = false;
                dgvClientes.Columns["Calle"].Visible = false;
                dgvClientes.Columns["Numero de vivienda"].Visible = false;
                dgvClientes.Columns["estado"].Visible = false;
                dgvClientes.Columns["idCondicionIva"].Visible = false;

                //DGVProductos.Columns["IdCategorias"].Visible = false;
                ConfiguraDataGrid(dgvClientes);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargatablaProductos()
        {
            try
            {
                dgvProductos.DataSource = null;
                var productos = ValidarVenta.VentaProductos();
                dgvProductos.DataSource = productos;
                dgvProductos.Columns["idProd"].Visible = false;
                dgvProductos.Columns["idCategorias"].Visible = false;
                dgvProductos.Columns["Estado"].Visible = false;
                dgvProductos.Columns["Cantidad"].Visible = false;
                dgvProductos.Columns["CantidadMinima"].Visible = false;
                dgvProductos.Columns["LitrosDisp"].Visible = false;
                dgvProductos.Columns["LitrosMinimo"].Visible = false;

                //DGVProductos.Columns["IdCategorias"].Visible = false;
                ConfiguraDataGrid(dgvProductos);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargatablaProductosConfiltro(int Categoria, string codigo, string nombre)
        {
            try
            {
                dgvProductos.DataSource = null;
                var productos = ValidarVenta.VentaProductosFiltro(Categoria, codigo, nombre);
                dgvProductos.DataSource = productos;
                dgvProductos.Columns["idProd"].Visible = false;
                dgvProductos.Columns["idCategorias"].Visible = false;
                dgvProductos.Columns["Estado"].Visible = false;
                dgvProductos.Columns["Cantidad"].Visible = false;
                dgvProductos.Columns["CantidadMinima"].Visible = false;
                dgvProductos.Columns["LitrosDisp"].Visible = false;
                dgvProductos.Columns["LitrosMinimos"].Visible = false;

                //DGVProductos.Columns["IdCategorias"].Visible = false;
                ConfiguraDataGrid(dgvProductos);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaClientesFiltro(int dni)
        {
            try
            {
                dgvClientes.DataSource = null;
                var productos = ValidarVenta.VentaClientesFiltro(dni);
                dgvClientes.DataSource = productos;
                dgvClientes.Columns["idCliente"].Visible = false;
                dgvClientes.Columns["Localidad"].Visible = false;
                dgvClientes.Columns["Calle"].Visible = false;
                dgvClientes.Columns["Numero de vivienda"].Visible = false;
                dgvClientes.Columns["estado"].Visible = false;
                dgvClientes.Columns["idCondicionIva"].Visible = false;
                ConfiguraDataGrid(dgvClientes);


                //DGVProductos.Columns["IdCategorias"].Visible = false;

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
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Azul más claro
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
        private void MenuVentaProductos_Load(object sender, EventArgs e)
        {

        }



        #endregion
        #region Selecciona Cliente
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionadaUPD = dgvClientes.Rows[e.RowIndex];
                int IdCliente = Convert.ToInt32(filaSeleccionadaUPD.Cells["idCliente"].Value);
                string NombreClien = filaSeleccionadaUPD.Cells["Nombre"].Value.ToString().Trim();
                string lubriPuntos = filaSeleccionadaUPD.Cells["LubriPuntos"].Value.ToString().Trim();

                lblNombreCliente.Text = NombreClien;
                lblLubripts.Text = lubriPuntos;



            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargatablaClientes();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {

                MessageBox.Show("Debe ingresar un dni para filtrar", "Advertencia");
                lblNombreCliente.Text = "Seleccione un cliente";
                lblLubripts.Text = "";
                CargatablaClientes();
            }
            else
            {
                int dni = Convert.ToInt32(txtCliente.Text);
                CargaClientesFiltro(dni);
            }


        }
        #endregion
        #region Selecciona Producto

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {

            CargatablaProductosConfiltro(, , )


        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];
                int IdProducto = Convert.ToInt32(filaSeleccionada.Cells["idProd"].Value);
                int idCategorias = Convert.ToInt32(filaSeleccionada.Cells["idCategorias"].Value);
                string Producto = filaSeleccionada.Cells["Nombre"].Value.ToString().Trim();
                string Disponible = filaSeleccionada.Cells["Cantidad"].Value.ToString().Trim();
                string disponibleLtr = filaSeleccionada.Cells["LitrosDisp"].Value.ToString().Trim();

                lblProducto.Text = Producto;
                int liquido = ValidarVenta.TraeLiquido(idCategorias);
                if (liquido == 1)
                {
                    lblDisponible.Text = "";
                    lblLitros.Text = disponibleLtr;
                }
                else
                {
                    lblLitros.Text = "";
                    lblDisponible.Text = Disponible;
                }
            }
        }




        #endregion



    }
}
