using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
        private int _idTrabajador;
        public MenuAgregarProducto(int idTrabajador)
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
            _idTrabajador = idTrabajador;


        }
        private void MenuAgregarProducto_Load(object sender, EventArgs e)
        {


        }


        #region ConfiguracionDataGrid
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
            //dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 250);

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
        #endregion
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
                    ValidarProducto.AgregarUnProducto(TxtNombreProducto.Text.ToUpper().Trim(), TxtMarcaProducto.Text.ToUpper().Trim(), ValorCategoria, CodigoProducto.ToUpper().Trim(), TxtDescripcion.Text.Trim(), cantidad, precioLista, precioVenta, litro, litroMin,cantidadmin, "ACT", _idTrabajador);
                    MessageBox.Show("Producto agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiaCampos();
                    Cargatabla();

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
                    int cantidadmin = Convert.ToInt32(filaSeleccionadaUPD.Cells["CantidadMinima"].Value);
                    int preciolista = Convert.ToInt32(filaSeleccionadaUPD.Cells["Precio_Lista"].Value);
                    int precioventa = Convert.ToInt32(filaSeleccionadaUPD.Cells["precioventa"].Value);
                    double litraje = Convert.ToDouble(filaSeleccionadaUPD.Cells["LitrosDisp"].Value);
                    double litrajeMin = Convert.ToDouble(filaSeleccionadaUPD.Cells["LitrosMinimo"].Value);

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ValidarProducto.UpdateProductos(IdProdUPD, Nombreprd.ToUpper().Trim(), marcaeprd.ToUpper().Trim(), categoria, codigoproducto.ToUpper().Trim(), descripcion.ToUpper().Trim(), cantidad, preciolista, precioventa, litraje, litrajeMin, cantidadmin, _idTrabajador);
                        Console.WriteLine("Cambio realizado.");
                        Cargatabla();
                        CargarCategorias();
                        ConfigurarDataGridView();
                        Acomodartabla();
                        DGVProductos.Columns["IdCategorias"].Visible = false;
                        DGVProductos.Columns["IdProd"].Visible = false;

                    }
                    else if (resultado == DialogResult.No)
                    {
                        Cargatabla();
                        CargarCategorias();
                        ConfigurarDataGridView();
                        Acomodartabla();
                        DGVProductos.Columns["IdCategorias"].Visible = false;
                        DGVProductos.Columns["IdProd"].Visible = false;
                    }


                }
            }
            else if (DGVProductos.Columns[e.ColumnIndex].Name == "CambiarEstado")
            {
                DataGridViewRow filaSeleccionadaUPD = DGVProductos.Rows[e.RowIndex];
                int IdProd = Convert.ToInt32(filaSeleccionadaUPD.Cells["IdProd"].Value);
                string Nombreprd = filaSeleccionadaUPD.Cells["Nombre"].Value.ToString().Trim();
                string Estado = filaSeleccionadaUPD.Cells["Estado"].Value.ToString().Trim();


                if (Estado == "ACT")
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres ELIMINAR EL PRODUCTO: " + Nombreprd + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        ValidarProducto.DeleteProducto(IdProd, "DES", _idTrabajador);
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
                        DGVProductos.Columns["IdCategorias"].Visible = false;
                        DGVProductos.Columns["IdProd"].Visible = false;
                    }
                }
                else if (Estado == "DES")
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres ACTIVAR EL PRODUCTO: " + Nombreprd + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        ValidarProducto.EliminarProducto(IdProd, "ACT");
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
        //private void CargarTablaCategoria()
        //{
        //    DGVProductos.DataSource = null;
        //    DGVProductos.DataSource = ValidarProducto.TraeProductos();
        //    DGVProductos.Columns["IdCategorias"].Visible = false;
        //}
        private void ConfigurarDataGridView()
        {
            var comboBoxColumn = new DataGridViewComboBoxColumn
            {
                Name = "CategoriaColumn",
                HeaderText = "Categoría",
                DataPropertyName = "IdCategorias", 
                DisplayMember = "Value",
                ValueMember = "Key"
            };

           
            Dictionary<int, string> categorias = ValidaCategoriasProducto.ObtenerCategoriasProductos();
            foreach (var categoria in categorias)
            {
                comboBoxColumn.Items.Add(new KeyValuePair<int, string>(categoria.Key, categoria.Value));
            }

            
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
                ConfiguraDataGrid(DGVProductos);
                ConfiguraDataGridStyle(DGVProductos);
                ConfigurarDataGridView();
                Acomodartabla();
                //DGVProductos.Columns["IdCategorias"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfiguraDataGridStyle(DataGridView dgv)
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
            //dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 250);

            // Otros ajustes
            dgv.RowHeadersVisible = false; // Ocultar la primera columna de encabezado
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ScrollBars = ScrollBars.Both; // Asegurar barras de desplazamiento

            //AplicarTrimDataGridViews(dgv);
        }
        public void AplicarTrimDataGridViews(DataGridView dgv)
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
            DGVProductos.Columns["CambiarEstado"].DisplayIndex = 1;
            DGVProductos.Columns["CambiarEstado"].Width = 120;
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
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void TxtCantMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void txtLitros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void TxtPrecioList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void txtPrecioVent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; 
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
            Close();
        }


        private void LimpiaCampos()
        {
            TxtCantidad.Text = "0";
            TxtCantMin.Text = "0";
            TxtPrecioList.Text = "0.0";
            txtPrecioVent.Text = "0.0";
            txtcodigoProducto.Text = string.Empty;
            txtLitros.Text = "0.0";
            txtLitrosMinimos.Text = "0.0";
            TxtNombreProducto.Text = string.Empty;
            TxtMarcaProducto.Text = string.Empty;  
            txtcodigoProducto.Text= string.Empty;

        }
    }    

}


