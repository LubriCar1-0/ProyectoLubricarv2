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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Vista.Validaciones;


namespace Vista
{
    public partial class MenuAgregarProducto : Form
    {
        
        public MenuAgregarProducto()
        {
            InitializeComponent();
            Cargatabla();
            CargarCategorias();
            txtLitros.Enabled = false;

        }
        private void MenuAgregarProducto_Load(object sender, EventArgs e)
        {


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                double LitrosDisponibles;
                int ValorCategoria = 0;
                int cantidad = Convert.ToInt32(TxtCantidad.Text.Trim());
                double precioLista = Convert.ToDouble(TxtPrecioList.Text.Trim());
                double precioVenta = Convert.ToDouble(txtPrecioVent.Text.Trim());
                string CodigoProducto = txtcodigoProducto.Text.Trim();
                string litro = txtLitros.Text.Trim();
                ValorCategoria = IdCategoria;
            int resultado = Producto.Resultado();
                if (litro == "0.0")
                {
                    double cantidadLT = 0.0;
                    ValidarProducto.AgregarUnProducto(TxtNombreProducto.Text.Trim(), TxtMarcaProducto.Text.Trim(), ValorCategoria, CodigoProducto.Trim(), TxtDescripcion.Text.Trim(), cantidad, precioLista, precioVenta, cantidadLT);
                }
                else
                {
                    LitrosDisponibles = Convert.ToDouble(litro.Trim());
                    ValidarProducto.AgregarUnProducto(TxtNombreProducto.Text.Trim(), TxtMarcaProducto.Text.Trim(), ValorCategoria, CodigoProducto.Trim(), TxtDescripcion.Text.Trim(), cantidad, precioLista, precioVenta, LitrosDisponibles);
                }
            
            

        }

        
        private void Cargatabla()
        {
            try
            {
                DGVProductos.DataSource = null;
                DGVProductos.DataSource = ValidarProducto.TraeProductos();          
                DGVProductos.Columns["IdProd"].Visible = false;
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: {ex.Message}");
            }

}

        private void DGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0) // Asegúrate de que se hace clic en una fila válida
            //{
            //    // Obtén la fila seleccionada
            //    DataGridViewRow filaSeleccionada = DGVProductos.Rows[e.RowIndex];

            //    // Carga los valores de las celdas en los TextBox
            //    textBoxId.Text = filaSeleccionada.Cells["Id"].Value.ToString();        // Columna "Id"
            //    textBoxNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString(); // Columna "Nombre"
            //    textBoxPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString(); // Columna "Precio"
            //}

        }
        
        private void CargarCategorias()
        {
            Dictionary<int, string> categorias = ValidadCategoriasProducto.ObtenerCategoriasProductos();
            foreach (var cat in categorias)
            {
                cmbCategoria.Items.Add(new KeyValuePair<int, string>(cat.Key, cat.Value));
            }
            cmbCategoria.DisplayMember = "Value";
            cmbCategoria.ValueMember = "Key";
        }


        private int IdCategoria;
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem is KeyValuePair<int, string> categoriaSelect)
            {
                IdCategoria = categoriaSelect.Key;
                VerificaLiquido(IdCategoria);

            }
        }

        private void VerificaLiquido(int ValorCategoria)
        {
            int Liquido = ValidadCategoriasProducto.ChequeaLiquido(ValorCategoria);
            if (Liquido == 1)
            {
                txtLitros.Enabled = true;
            }
            else
            {
                txtLitros.Enabled = false;
            }

        }
        private void CargarTablaCategoria()
        {
            DGVProductos.DataSource = null;
            DGVProductos.DataSource = ValidarProducto.TraeProductos();
            DGVProductos.Columns["IdCategorias"].Visible = false;
        }



    }
}
