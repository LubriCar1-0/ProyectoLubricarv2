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
    public partial class MenuControlDeStock : Form
    {
        public MenuControlDeStock()
        {
            InitializeComponent();
            CargatablaProductosSinFiltro();

        }

        private void DgvControlDeStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionadaUPD = DgvControlDeStock.Rows[e.RowIndex];
                txbCant.Text = Convert.ToString(filaSeleccionadaUPD.Cells["Cantidad"].Value);
                txbCantMinima.Text = Convert.ToString(filaSeleccionadaUPD.Cells["CantidadMinima"].Value);
                txbPrecioList.Text = Convert.ToString(filaSeleccionadaUPD.Cells["Precio_Lista"].Value);
                txbPrecioVent.Text = Convert.ToString(filaSeleccionadaUPD.Cells["precioventa"].Value);
                txtLitrosDisp.Text = Convert.ToString(filaSeleccionadaUPD.Cells["LitrosDisp"].Value);
                txtLitrosMin.Text = Convert.ToString(filaSeleccionadaUPD.Cells["LitrosMinimo"].Value);
                lblNombreProd.Text = Convert.ToString(filaSeleccionadaUPD.Cells["Nombre"].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuStock PantallaMenuStock = new MenuStock();
            Hide();
            PantallaMenuStock.ShowDialog();
        }

        private void CargatablaProductosSinFiltro()
        {
            try
            {
                DgvControlDeStock.DataSource = null;
                var productos = ValidarProducto.TraeProductos();
                DgvControlDeStock.DataSource = productos;
                DgvControlDeStock.Columns["Nombre"].Width = 280;
                DgvControlDeStock.Columns["Marca"].Width = 290;
                DgvControlDeStock.Columns["Estado"].Width = 30;
                DgvControlDeStock.AllowUserToResizeColumns = false;
                DgvControlDeStock.AllowUserToResizeRows = false;
                DgvControlDeStock.Columns["IdProd"].Visible= false;
                DgvControlDeStock.Columns["IdCategorias"].Visible = false;
                DgvControlDeStock.Columns["Descripcion"].Visible = false;
                DgvControlDeStock.Columns["Estado"].Visible = false;
                DgvControlDeStock.Columns["Cantidad"].Visible = false;
                DgvControlDeStock.Columns["Precio_Lista"].Visible = false;
                DgvControlDeStock.Columns["PrecioVenta"].Visible = false;
                DgvControlDeStock.Columns["LitrosDisp"].Visible = false;
                DgvControlDeStock.Columns["CantidadMinima"].Visible = false;
                DgvControlDeStock.Columns["LitrosMinimo"].Visible = false;
                DgvControlDeStock.RowHeadersVisible = false;
                //DgvControlDeStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //DgvControlDeStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
