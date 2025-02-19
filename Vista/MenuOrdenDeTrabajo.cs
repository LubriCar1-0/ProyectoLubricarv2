using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Vista
{
    public partial class MenuOrdenDeTrabajo : Form
    {
        public double litrosDisp;
        public int cantidadDisp;
        public int idcliente;
        public double PrecioVenta;
        private PrintDocument printDocument;
        private string ticketTexto;
        public MenuOrdenDeTrabajo()
        {

            this.FormBorderStyle = FormBorderStyle.None; 
            this.WindowState = FormWindowState.Maximized; 
            this.StartPosition = FormStartPosition.CenterScreen; 
            InitializeComponent(); 
            CargatablaProductos();
            dgvProductos.Columns["idProd"].Visible = false;
            CargarCategorias();
            //ConfiguraDataGrid(dgvClientes);
            ConfiguraDataGrid(dgvProductos);
            //UsuarioPrimero();
            lblIdproducto.Visible = false;
            lblTEXTdisponible.Visible = false;
            lblTEXTOlitros.Visible = false;
            //lblIdCliente.Visible = false;
            lblIdCat.Visible = false;
            printDocument = new PrintDocument();
            //printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void MenuOrdenDeTrabajo_Load(object sender, EventArgs e)
        {

        }


        #region Cargar Tablas 
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
                dgvProductos.Columns["LitrosMinimo"].Visible = false;

                //DGVProductos.Columns["IdCategorias"].Visible = false;
                ConfiguraDataGrid(dgvProductos);
                //Categoria = 0;
                //codigo = string.Empty;
                //nombre = string.Empty;
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
        private void CargaTablaLista()
        {
            dgvVentas.DataSource = null;  // Limpia el DataGridView
            dgvVentas.DataSource = ValidarVenta.ObtenerVentas();
            //dgvVentas.Columns["idCliente"].Visible = false;
        }



        #endregion

        #region Filtro De Busqueda 

        public int IdCategorias;
        
        private void cmbCategoriaPrd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCategoriaPrd.SelectedItem is KeyValuePair<int, string> categoriaSelect)
            {
                IdCategorias = categoriaSelect.Key;

            }
        }
        private void CargarCategorias()
        {
            Dictionary<int, string> categorias = ValidaCategoriasProducto.ObtenerCategoriasProductos();
            foreach (var cat in categorias)
            {
                cmbCategoriaPrd.Items.Add(new KeyValuePair<int, string>(cat.Key, cat.Value));
            }
            cmbCategoriaPrd.DisplayMember = "Value";
            cmbCategoriaPrd.ValueMember = "Key";
        }
        
        private void btnRecargarProd_Click_1(object sender, EventArgs e)
        {
            CargatablaProductos();
        }
        private void btnBuscarProd_Click_1(object sender, EventArgs e)
        {
            int idcat = IdCategorias;
            string codprod = txtCodigoProd.Text.ToUpper();
            string nombreprod = txtNombreProd.Text.ToUpper();
            MessageBox.Show(idcat.ToString() + "," + codprod + "," + nombreprod, "Error");
            if (idcat == 0 && codprod == string.Empty && nombreprod == string.Empty)
            {
                MessageBox.Show("Debe llenar alguno de los campos para poder filtrar", "error");
                //MessageBox.Show(idcat.ToString(), "Error");

            }
            else
            {
                CargatablaProductosConfiltro(idcat, codprod, nombreprod);
                txtCodigoProd.Clear();
                txtNombreProd.Clear();
                idcat = 0;

            }
        }

        #endregion

        #region CargarLista 
        private void btnagregalista_Click_1(object sender, EventArgs e)
        {
            int valorStock = 0;
            int cantidad = Convert.ToInt32(lblDisponible.Text);
            double cantidadlitro = Convert.ToDouble(lblLitros.Text);
            int Liquido = ValidarVenta.TraeLiquido(Convert.ToInt32(lblIdCat.Text));
            if (Liquido == 1 && cantidadlitro == 0.00)
            {
                valorStock = 1;
            }

            if (Liquido == 0 && cantidad == 0)
            {
                valorStock = 1;
            }

            if (valorStock == 1)
            {
                MessageBox.Show("No hay stock a la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ValidarVenta.CargaLista(idcliente, Convert.ToInt32(lblIdproducto.Text), lblProducto.Text, Convert.ToInt32(lblDisponible.Text), Convert.ToDouble(lblLitros.Text), Convert.ToInt32(txtCantidad.Text), PrecioVenta);
                CargaTablaLista();
                double subtotal = ValidarVenta.CalculaTotal();
                //RecargaTotales(subtotal);
                ConfiguraDataGrid(dgvVentas);
                dgvVentas.Columns["idCliente"].Visible = false;
                dgvVentas.Columns["IdProducto"].Visible = false;
                LimpiaLblProducto();
                grpPresupuesto.Enabled = true;
            }
        }

        //public void RecargaTotales(double subtotal)
        //{
        //    lblSubTotal.Text = subtotal.ToString();
        //    double IVA = (subtotal * 0.21);
        //    lblIVA.Text = IVA.ToString();
        //    double Total = subtotal + IVA;
        //    lblTotal.Text = Total.ToString();
        //}
        public void LimpiaLblProducto()
        {
            lblProducto.Text = "Seleccione Producto";
            lblDisponible.Text = "0";
            lblLitros.Text = "0";
            txtCantidad.Text = string.Empty;
        }

        #endregion

        #region Restricciones 
        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }



        #endregion

        #region Confirmar Productos 
        private void btnCargaVenta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Â¿EstÃ¡s seguro de que quieres continuar?", "ConfirmaciÃ³n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //VentaProducto.Cargaventa(Convert.ToInt32(lblIdCliente.Text), Convert.ToDouble(lblSubTotal.Text), Convert.ToDouble(lblIVA.Text), Convert.ToDouble(lblTotal.Text));

                if (string.IsNullOrWhiteSpace(ticketTexto))
                {
                    MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDocument;
                previewDialog.ShowDialog();
                #endregion

                VentaProducto.LimpiaLista();
                CargaTablaLista();
                dgvVentas.Columns["idCliente"].Visible = false;
                dgvVentas.Columns["IdProducto"].Visible = false;
                CargatablaProductos();
                
            }
        }
        

    }
}
