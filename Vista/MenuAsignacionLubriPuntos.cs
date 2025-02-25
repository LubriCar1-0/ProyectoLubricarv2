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
        }

        private void CargartablaProductos()
        {
            try
            {
                DGVproductos.DataSource = null;
                DGVproductos.DataSource = ValidarLubriPuntos.TraerProductos();
                DGVproductos.Columns["Nombre"].Width = 150;
                DGVproductos.Columns["Marca"].Width = 150;
                DGVproductos.Columns["Estado"].Width = 150;
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
    }
}
