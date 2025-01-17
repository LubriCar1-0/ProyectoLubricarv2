using Datos;
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
            ConfigurarDataGridView();
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

            int Chequea = Conectar.BuscaDuplicadoProducto(TxtNombreProducto.Text.Trim(), TxtMarcaProducto.Text.Trim(), ValorCategoria);
            if (Chequea == 0)
            {
                if (litro == "0.0")
                {
                    double cantidadLT = 0.0;
                    ValidarProducto.AgregarUnProducto(TxtNombreProducto.Text.ToUpper().Trim(), TxtMarcaProducto.Text.ToUpper().Trim(), ValorCategoria, CodigoProducto.ToUpper().Trim(), TxtDescripcion.Text.Trim(), cantidad, precioLista, precioVenta, cantidadLT);
                    MessageBox.Show("Éxito", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LitrosDisponibles = Convert.ToDouble(litro.Trim());
                    ValidarProducto.AgregarUnProducto(TxtNombreProducto.Text.ToUpper().Trim(), TxtMarcaProducto.Text.ToUpper().Trim(), ValorCategoria, CodigoProducto.ToUpper().Trim(), TxtDescripcion.Text.Trim(), cantidad, precioLista, precioVenta, LitrosDisponibles);
                    MessageBox.Show("Producto agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hay un duplicado del producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Cargatabla()
        {
            //try
            //{
            //    DGVProductos.DataSource = null;
            //    DGVProductos.DataSource = ValidarProducto.TraeProductos();
            //    DGVProductos.Columns["IdProd"].Visible = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al cargar los productos: {ex.Message}");
            //}
            
            
            try
            {
                DGVProductos.DataSource = null;
                var productos = ValidarProducto.TraeProductos();

                // Vincula el DataSource
                DGVProductos.DataSource = productos;

                // Ocultar columnas innecesarias
                DGVProductos.Columns["IdProd"].Visible = false;

                // Configurar valores iniciales del ComboBox
                foreach (DataGridViewRow row in DGVProductos.Rows)
                {
                    if (row.Cells["IdCategoria"] != null && row.Cells["CategoriaColumn"] is DataGridViewComboBoxCell comboBoxCell)
                    {
                        comboBoxCell.Value = row.Cells["IdCategoria"].Value; // Asigna el valor inicial
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void DGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionadaUPD = DGVProductos.Rows[e.RowIndex];
                    int IdProdUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["IdProd"].Value);
                    string Nombreprd = filaSeleccionadaUPD.Cells["Nombre"].Value.ToString().Trim();
                    string marcaeprd = filaSeleccionadaUPD.Cells["Marca"].Value.ToString().Trim();
                    int categoria = Convert.ToInt32(filaSeleccionadaUPD.Cells["IdCategoria"].Value);
                    string codigoproducto = filaSeleccionadaUPD.Cells["CodProd"].Value.ToString().Trim();
                    string descripcion = filaSeleccionadaUPD.Cells["Descripcion"].Value.ToString().Trim();
                    int cantidad = Convert.ToInt32(filaSeleccionadaUPD.Cells["Cantidad"].Value);
                    int preciolista = Convert.ToInt32(filaSeleccionadaUPD.Cells["Precio_Lista"].Value);
                    int precioventa = Convert.ToInt32(filaSeleccionadaUPD.Cells["precioventa"].Value);
                    double litraje = Convert.ToDouble(filaSeleccionadaUPD.Cells["precioventa"].Value);


                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        Producto.UpdateProductos(IdProdUPD, Nombreprd.ToUpper().Trim(), marcaeprd.ToUpper().Trim(), categoria, codigoproducto.ToUpper().Trim(), descripcion.ToUpper().Trim(), cantidad, preciolista, precioventa, litraje);
                        Console.WriteLine("Cambio realizado.");
                        CargarTablaCategoria();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarTablaCategoria();
                    }


                }
            }
        }

        private void CargarCategorias()
        {
            Dictionary<int, string> categorias = ValidaCategoriasProducto.ObtenerCategoriasProductos();
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
            int Liquido = ValidaCategoriasProducto.ChequeaLiquido(ValorCategoria);
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
        private void ConfigurarDataGridView()
        {
            // Configura la columna ComboBox
            var comboBoxColumn = new DataGridViewComboBoxColumn
            {
                Name = "CategoriaColumn",
                HeaderText = "Categoría",
                DataPropertyName = "IdCategoria", // Vincula la propiedad
                DisplayMember = "Value",
                ValueMember = "Key"
            };

            // Llenar el combo con las categorías
            Dictionary<int, string> categorias = ValidaCategoriasProducto.ObtenerCategoriasProductos();
            foreach (var categoria in categorias)
            {
                comboBoxColumn.Items.Add(new KeyValuePair<int, string>(categoria.Key, categoria.Value));
            }

            // Agrega la columna al DataGridView
            DGVProductos.Columns.Add(comboBoxColumn);
        }




    }
    

}


