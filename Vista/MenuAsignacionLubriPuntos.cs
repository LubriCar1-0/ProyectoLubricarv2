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
using static Negocio.Producto;

namespace Vista
{
    public partial class MenuAsignacionLubriPuntos : Form
    {
        public MenuAsignacionLubriPuntos()
        {
            InitializeComponent();
            CargartablaProductos();
            CargarTablaLubrixProductos();
            DGVproductos.CellClick += DGVproductos_CellContentClick;
            ConfiguraDataGrid(DGVproductos);
            ConfiguraDataGrid(DGVproducxlubri);
        }

        private void CargartablaProductos()
        {
            try
            {
                DGVproductos.DataSource = null;
                DGVproductos.DataSource = ValidarLubriPuntos.TraerProductos();
                DGVproductos.AllowUserToResizeColumns = false;
                DGVproductos.AllowUserToResizeRows = false;
                DGVproductos.Columns["IdProd"].Visible = false;
                DGVproductos.Columns["IdCategorias"].Visible = false;
                DGVproductos.Columns["Descripcion"].Visible = false;
                DGVproductos.Columns["Estado"].Visible = false;
                DGVproductos.Columns["Cantidad"].Visible = false;
                DGVproductos.Columns["Precio_Lista"].Visible = false;
                DGVproductos.Columns["PrecioVenta"].Visible = false;
                DGVproductos.Columns["LitrosDisp"].Visible = false;
                DGVproductos.Columns["CantidadMinima"].Visible = false;
                DGVproductos.Columns["LitrosMinimo"].Visible = false;
                DGVproductos.RowHeadersVisible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DGVproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = DGVproductos.Rows[e.RowIndex];
                string Producto = filaSeleccionada.Cells["Nombre"].Value.ToString().Trim();
                lblNombreProd.Text = Producto;
            }
        }

        private void CargarProductosconfiltro(string codigo)
        {
            try
            {
                DGVproductos.DataSource = null;
                var productos = ValidarLubriPuntos.LPproductosconfiltro(codigo);
                DGVproductos.DataSource = productos;
                DGVproductos.Columns["IdProd"].Visible = false;
                DGVproductos.Columns["IdCategorias"].Visible = false;
                DGVproductos.Columns["Descripcion"].Visible = false;
                DGVproductos.Columns["Estado"].Visible = false;
                DGVproductos.Columns["Cantidad"].Visible = false;
                DGVproductos.Columns["Precio_Lista"].Visible = false;
                DGVproductos.Columns["PrecioVenta"].Visible = false;
                DGVproductos.Columns["LitrosDisp"].Visible = false;
                DGVproductos.Columns["CantidadMinima"].Visible = false;
                DGVproductos.Columns["LitrosMinimo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargartablaProductos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarProductosconfiltro(TxtCodProducto.Text.Trim());
        }
        private void CargarTablaLubrixProductos()
        {
            try
            {
                DGVproducxlubri.DataSource = null;
                DGVproducxlubri.DataSource = ValidarLubriPuntos.ObtenerListaLubrixProductos();
                DGVproducxlubri.Columns["idLubrixProducto"].Visible = false;
                DGVproducxlubri.Columns["idProd"].Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos con Lubripuntos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (DGVproductos.CurrentRow != null && int.TryParse(txtCantLubri.Text, out int cantidadLubriPuntos))
            {
                int idProducto = Convert.ToInt32(DGVproductos.CurrentRow.Cells["idProd"].Value);
                ValidarLubriPuntos.InsertarPuntosAProducto(idProducto, cantidadLubriPuntos);

                MessageBox.Show("Lubripuntos asignados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarTablaLubrixProductos();
            }
            else
            {
                MessageBox.Show("Seleccione un producto y cargue una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void DGVproducxlubri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = DGVproducxlubri.Rows[e.RowIndex];
            int idLubrixproduc = Convert.ToInt32(filaSeleccionada.Cells["idLubrixProducto"].Value);
            if (DGVproducxlubri.Columns[e.ColumnIndex].Name == "CambiarEstado")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionadaUPD = DGVproducxlubri.Rows[e.RowIndex];
                    int idLubrixproducUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["idLubrixProducto"].Value);
                    string Estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                        if (Estado == "ACT")
                        {
                            ValidarLubriPuntos.BajaAltaProducxlubri(idLubrixproducUPD, "DES");
                            MessageBox.Show("Prodcto DADO DE BAJA.");
                        }
                    }
                }
            }

        }

        private void DGVproducxlubri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
