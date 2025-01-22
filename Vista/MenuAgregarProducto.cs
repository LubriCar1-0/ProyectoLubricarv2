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
using static Negocio.Empleados;
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
            Acomodartabla();
            DGVProductos.Visible = false;
            chPermiteEditar.Visible = false;
            DGVProductos.ReadOnly = true;
            txtLitros.Enabled = false;
            cmbCategoria.Enabled = true;
           

        }
        private void MenuAgregarProducto_Load(object sender, EventArgs e)
        {


        }
        

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            double LitrosDisponibles;
            int ValorCategoria = 0;
            int cantidad = Convert.ToInt32(TxtCantidad.Text.Trim());
            int cantidadmin = Convert.ToInt32(TxtCantMin.Text.Trim());
            double precioLista = Convert.ToDouble(TxtPrecioList.Text.Trim());
            double precioVenta = Convert.ToDouble(txtPrecioVent.Text.Trim());
            string CodigoProducto = txtcodigoProducto.Text.Trim();
            double litro = Convert.ToDouble(txtLitros.Text.Trim());
            double litroMin = Convert.ToDouble(txtLitrosMinimos.Text.Trim());
            ValorCategoria = IdCategorias;

            int Chequea = Conectar.BuscaDuplicadoProducto(TxtNombreProducto.Text.Trim(), TxtMarcaProducto.Text.Trim(), ValorCategoria);
            if (Chequea == 0)
            {
                //int liquido = ValidaCategoriasProducto.ChequeaLiquido(ValorCategoria);
                //if (liquido == 1)
                //{
                //    txtLitros.Enabled = true;
                    ValidarProducto.AgregarUnProducto(TxtNombreProducto.Text.ToUpper().Trim(), TxtMarcaProducto.Text.ToUpper().Trim(), ValorCategoria, CodigoProducto.ToUpper().Trim(), TxtDescripcion.Text.Trim(), cantidad, precioLista, precioVenta, litro, litroMin,cantidadmin);
                    MessageBox.Show("Producto agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cargatabla();
                //}
                //else
                //{
                //    txtLitros.Enabled = false;
                //    TxtCantidad.Enabled = false;
                //    TxtCantMin.Enabled = false;
                //    //double cantidadLT = 0.0;
                //    ValidarProducto.AgregarUnProducto(TxtNombreProducto.Text.ToUpper().Trim(), TxtMarcaProducto.Text.ToUpper().Trim(), ValorCategoria, CodigoProducto.ToUpper().Trim(), TxtDescripcion.Text.Trim(), cantidad, precioLista, precioVenta, litro, litroMin);
                //    MessageBox.Show("Éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    Cargatabla();
                //}

            }
            else
            {
                MessageBox.Show("Hay un duplicado del producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    int categoria = Convert.ToInt32(filaSeleccionadaUPD.Cells["CategoriaColumn"].Value);
                    string codigoproducto = filaSeleccionadaUPD.Cells["CodProd"].Value.ToString().Trim();
                    string descripcion = filaSeleccionadaUPD.Cells["Descripcion"].Value.ToString().Trim();
                    int cantidad = Convert.ToInt32(filaSeleccionadaUPD.Cells["Cantidad"].Value);
                    int preciolista = Convert.ToInt32(filaSeleccionadaUPD.Cells["Precio_Lista"].Value);
                    int precioventa = Convert.ToInt32(filaSeleccionadaUPD.Cells["precioventa"].Value);
                    double litraje = Convert.ToDouble(filaSeleccionadaUPD.Cells["precioventa"].Value);


                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ValidarProducto.UpdateProductos(IdProdUPD, Nombreprd.ToUpper().Trim(), marcaeprd.ToUpper().Trim(), categoria, codigoproducto.ToUpper().Trim(), descripcion.ToUpper().Trim(), cantidad, preciolista, precioventa, litraje);
                        Console.WriteLine("Cambio realizado.");
                        Cargatabla();
                        ConfigurarDataGridView();
                        Acomodartabla();
                        DGVProductos.Columns["IdCategorias"].Visible = false;
                        DGVProductos.Columns["IdProd"].Visible = false;

                    }
                    else if (resultado == DialogResult.No)
                    {
                        Cargatabla();
                        ConfigurarDataGridView();
                        Acomodartabla();

                        DGVProductos.Columns["IdProd"].Visible = false;
                    }


                }
            }
            else if (DGVProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DataGridViewRow filaSeleccionadaUPD = DGVProductos.Rows[e.RowIndex];
                int IdProd = Convert.ToInt32(filaSeleccionadaUPD.Cells["IdProd"].Value);
                string Nombreprd = filaSeleccionadaUPD.Cells["Nombre"].Value.ToString().Trim();

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres ELIMINAR EL PRODUCTO: "+ Nombreprd + "?", "Confirmación" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ValidarProducto.EliminarProducto(IdProd, "DES");
                    Console.WriteLine("Cambio realizado.");
                    Cargatabla();
                    ConfigurarDataGridView();
                    Acomodartabla();
                    DGVProductos.Columns["IdCategorias"].Visible = false;
                    DGVProductos.Columns["IdProd"].Visible = false;

                }
                else if (resultado == DialogResult.No)
                {
                    Cargatabla();
                    ConfigurarDataGridView();
                    Acomodartabla();

                    DGVProductos.Columns["IdProd"].Visible = false;
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


        private int IdCategorias;
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem is KeyValuePair<int, string> categoriaSelect)
            {
                IdCategorias = categoriaSelect.Key;
                VerificaLiquido(IdCategorias);

            }
        }


        private void VerificaLiquido(int ValorCategoria)
        {
            int Liquido = ValidaCategoriasProducto.ChequeaLiquido(ValorCategoria);
            if (Liquido == 1)
            {
                txtLitros.Enabled = true;
                txtLitrosMinimos.Enabled = true;    
                TxtCantMin.Enabled = false;
                TxtCantidad.Enabled = false;    
            }
            else
            {
                txtLitros.Enabled = false;
                txtLitrosMinimos.Enabled = false;
                TxtCantMin.Enabled = true;
                TxtCantidad.Enabled = true;
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
            var comboBoxColumn = new DataGridViewComboBoxColumn
            {
                Name = "CategoriaColumn",
                HeaderText = "Categoría",
                DataPropertyName = "IdCategorias", // Vincula la propiedad
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

        private void Cargatabla()
        {
            try
            {
                DGVProductos.DataSource = null;
                var productos = ValidarProducto.TraeProductos();
                DGVProductos.DataSource = productos;
                DGVProductos.Columns["IdProd"].Visible = false;
                //DGVProductos.Columns["IdCategorias"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chPermiteEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chPermiteEditar.Checked)
            {
                DGVProductos.ReadOnly = false;
            }
            else
            {
                DGVProductos.ReadOnly = true;
            }
        }

        private void cbxMostrarProductos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMostrarProductos.Checked)
            {
                chPermiteEditar.Visible = true;
                DGVProductos.Visible = true;
            }
            else
            {
                chPermiteEditar.Visible = false;
                DGVProductos.Visible = false;
            }
        }

        private void Acomodartabla()
        {
            DGVProductos.RowHeadersVisible = false;
            DGVProductos.Columns["Editar"].DisplayIndex = 0;
            DGVProductos.Columns["Editar"].Width = 75;
            DGVProductos.Columns["Eliminar"].DisplayIndex = 1;
            DGVProductos.Columns["Eliminar"].Width = 75;
            DGVProductos.Columns["IdProd"].DisplayIndex = 2;
            DGVProductos.Columns["Nombre"].DisplayIndex = 3;
            DGVProductos.Columns["Marca"].DisplayIndex = 4;
            DGVProductos.Columns["CategoriaColumn"].DisplayIndex = 5;
            DGVProductos.Columns["CodProd"].DisplayIndex = 6;
            DGVProductos.Columns["Descripcion"].DisplayIndex = 7;
            DGVProductos.Columns["Cantidad"].DisplayIndex = 8;
            DGVProductos.Columns["CantidadMinima"].DisplayIndex = 9;
            DGVProductos.Columns["Precio_Lista"].DisplayIndex = 10;
            DGVProductos.Columns["precioventa"].DisplayIndex = 11;
            DGVProductos.Columns["LitrosDisp"].DisplayIndex = 12;
            DGVProductos.Columns["LitrosMinimo"].DisplayIndex = 13;


        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }

        private void TxtCantMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }

        private void txtLitros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }

        private void TxtPrecioList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }

        private void txtPrecioVent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }


        private void VerificaLetras()
        {





        }

        private void TxtCantMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuStock LlamarMenuStock = new MenuStock();
            Hide();
            LlamarMenuStock.ShowDialog();
        }
    }    

}


