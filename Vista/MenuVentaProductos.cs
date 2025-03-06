using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Negocio.Producto;


namespace Vista
{
    public partial class MenuVentaProductos : Form
    {
        public double litrosDisp;
        public int cantidadDisp;
        public int idcliente;
        public double PrecioVenta;
        private PrintDocument printDocument;
        private string ticketTexto;
        public MenuVentaProductos()
        {        
            InitializeComponent();
            RDCliente.Checked = true;
            CargatablaClientes();             
            CargatablaProductos();        
            CargarCategorias();
            ConfiguraDataGrid(dgvClientes);
            ConfiguraDataGrid(dgvProductos);
            dgvProductos.Columns["idProd"].Visible = false;
            dgvClientes.Columns["idCliente"].Visible = false;
            UsuarioPrimero();
            lblIdproducto.Visible = false;
            lblTEXTdisponible.Visible = false;
            lblTEXTOlitros.Visible = false;
            lblIdCliente.Visible = false;
            lblIdCat.Visible = false;
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            grpProductos.Visible = false;
            GRPClientes.Visible = true;
        }
        #region Volver pantalla anterior
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
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
                dgvClientes.AllowUserToAddRows = false;
                dgvClientes.RowHeadersVisible = false;
                dgvClientes.Columns["idCliente"].Visible = false;
                dgvClientes.Columns["Localidad"].Visible = false;
                dgvClientes.Columns["Calle"].Visible = false;
                dgvClientes.Columns["Numero de vivienda"].Visible = false;
                dgvClientes.Columns["estado"].Visible = false;
                dgvClientes.Columns["idCondicionIva"].Visible = false;

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
                dgvProductos.AllowUserToAddRows = false;
                dgvProductos.RowHeadersVisible = false;
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
                dgvProductos.AllowUserToAddRows = false;
                dgvProductos.RowHeadersVisible = false;
                dgvProductos.Columns["idProd"].Visible = false;
                dgvProductos.Columns["idCategorias"].Visible = false;
                dgvProductos.Columns["Estado"].Visible = false;
                dgvProductos.Columns["Cantidad"].Visible = false;
                dgvProductos.Columns["CantidadMinima"].Visible = false;
                dgvProductos.Columns["LitrosDisp"].Visible = false;
                dgvProductos.Columns["LitrosMinimo"].Visible = false;

                ConfiguraDataGrid(dgvProductos);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaClientesFiltro(string dni)
        {
            try
            {
                dgvClientes.DataSource = null;
                var productos = ValidarVenta.VentaClientesFiltro(dni);
                dgvClientes.DataSource = productos;
                dgvClientes.AllowUserToAddRows = false;
                dgvClientes.RowHeadersVisible = false;
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
                string apellidoClien = filaSeleccionadaUPD.Cells["Apellido"].Value.ToString().Trim();
                string lubriPuntos = filaSeleccionadaUPD.Cells["LubriPuntos"].Value.ToString().Trim();
                RDProductos.Checked = true;
                lblIdCliente.Text = IdCliente.ToString();
                lblNombreCliente.Text = apellidoClien + "," + NombreClien;
                lblLubripts.Text = lubriPuntos;
                idcliente = Convert.ToInt32(filaSeleccionadaUPD.Cells["idCliente"].Value.ToString().Trim());
                grpProductos.Enabled = true;


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
                //int dni = Convert.ToInt32(txtCliente.Text);
                CargaClientesFiltro(txtCliente.Text.Trim());
            }


        }
        #endregion

        #region Selecciona Producto
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
                double precioVenta = Convert.ToDouble(filaSeleccionada.Cells["PrecioVenta"].Value.ToString().Trim());
                lblProducto.Text = Producto;
                PrecioVenta = precioVenta;
                lblIdproducto.Text = IdProducto.ToString();
                lblIdCat.Text = idCategorias.ToString();
                int liquido = ValidarVenta.TraeLiquido(idCategorias);
                if (liquido == 1)
                {
                    lblLitros.Text = disponibleLtr;
                    litrosDisp = Convert.ToDouble(disponibleLtr);
                    lblDisponible.Visible = false;
                    lblTEXTdisponible.Visible = false;
                    lblLitros.Visible = true;
                    lblTEXTOlitros.Visible = true;
                }
                else
                {
                    lblDisponible.Text = Disponible;
                    cantidadDisp = Convert.ToInt32(Disponible);
                    lblDisponible.Visible = true;
                    lblTEXTdisponible.Visible = true;
                    lblLitros.Visible = false;
                    lblTEXTOlitros.Visible = false;
                }
            }
        }
        public void LimpiaLblProducto()
        {
            lblProducto.Text = "Seleccione Producto";
            lblDisponible.Text = "0";
            lblLitros.Text = "0";
            txtCantidad.Text = string.Empty;
        }

        #endregion

        #region filtraProducto
        public int IdCategorias;
        private void cmbCategoriaPrd_SelectedIndexChanged(object sender, EventArgs e)
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
        private void btnRecargarProd_Click(object sender, EventArgs e)
        {
            CargatablaProductos();
            cmbCategoriaPrd.Text = "Seleccionar Categoria";
            IdCategorias = 0;
            
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            int idcat = IdCategorias;
            string codprod = txtCodigoProd.Text.ToUpper();
            string nombreprod = txtNombreProd.Text.ToUpper();
            if (idcat == 0 && codprod == string.Empty && nombreprod == string.Empty)
            {
                MessageBox.Show("Debe llenar alguno de los campos para poder filtrar", "error");
                

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

        #region carga lista Productos

        private void btnagregalista_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                int valorStock = 0;
                int cantidad = Convert.ToInt32(lblDisponible.Text);
                double cantidadlitro = Convert.ToDouble(lblLitros.Text);
                int Liquido = ValidarVenta.TraeLiquido(Convert.ToInt32(lblIdCat.Text));
                if ((Liquido == 1 && cantidadlitro == 0.00) || (Liquido == 1 && cantidadlitro < Convert.ToDouble(txtCantidad.Text)))
                {
                    valorStock = 1;
                }

                if ((Liquido == 0 && cantidad == 0) || (Liquido == 0 && cantidad < Convert.ToInt32(txtCantidad.Text)))
                {
                    valorStock = 1;
                }

                if (valorStock == 1)
                {
                    MessageBox.Show("No hay stock a la venta o supera la cantidad en stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ValidarVenta.CargaLista(idcliente, Convert.ToInt32(lblIdproducto.Text), lblProducto.Text, Convert.ToInt32(lblDisponible.Text), Convert.ToDouble(lblLitros.Text), Convert.ToInt32(txtCantidad.Text), PrecioVenta);
                    CargaTablaLista();
                    double subtotal = ValidarVenta.CalculaTotal();
                    RecargaTotales(subtotal);
                    ConfiguraDataGrid(dgvVentas);
                    dgvVentas.Columns["idCliente"].Visible = false;
                    dgvVentas.Columns["IdProducto"].Visible = false;
                    LimpiaLblProducto();
                    grpPresupuesto.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RecargaTotales(double subtotal)
        {
            lblSubTotal.Text = subtotal.ToString();
            double IVA = (subtotal * 0.21);
            lblIVA.Text = IVA.ToString();
            double Total = subtotal + IVA;
            lblTotal.Text = Total.ToString();

            LubriPuntos llamalubripuntos = new LubriPuntos();
            lblLubriGana.Text = Convert.ToString(llamalubripuntos.CalculaLubriPuntos(Total));
        }



        #endregion

        #region carga venta
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VentaProducto.LimpiaLista();
            CargaTablaLista();
            dgvVentas.Columns["idCliente"].Visible = false;
            dgvVentas.Columns["IdProducto"].Visible = false;

            lblSubTotal.Text = "0.0";
            lblIVA.Text = "0.0";
            lblTotal.Text = "0.0";
            lblLubriGana.Text = "No hay valor asignado";
        }

        private void btnCargaVenta_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Â¿EstÃ¡s seguro de que quieres continuar?", "ConfirmaciÃ³n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                VentaProducto.Cargaventa(Convert.ToInt32(lblIdCliente.Text), Convert.ToDouble(lblSubTotal.Text), Convert.ToDouble(lblIVA.Text), Convert.ToDouble(lblTotal.Text), Convert.ToInt32(lblLubriGana.Text));
               
                #region ImprimeTicket
               ticketTexto = GenerarTicket();

                if (string.IsNullOrWhiteSpace(ticketTexto))
                {
                    MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDocument;
                previewDialog.ShowDialog();
                #endregion

                //MessageBox.Show("Venta cargada con exito");
                VentaProducto.LimpiaLista();
                CargaTablaLista();
                dgvVentas.Columns["idCliente"].Visible = false;
                dgvVentas.Columns["IdProducto"].Visible = false;
                CargatablaProductos();
                lblSubTotal.Text = "0.0";
                lblIVA.Text = "0.0";
                lblTotal.Text = "0.0";
                lblLubriGana.Text = "No hay valor asignado";
            }
        }
        private void btnPresupuesto_Click(object sender, EventArgs e)
        {

            ticketTexto = GenerarPresupuesto();

            if (string.IsNullOrWhiteSpace(ticketTexto))
            {
                MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        #endregion

        #region impresion del ticket
        private string GenerarTicket()
        {
            StringBuilder ticket = new StringBuilder();
            var listaProductos = Negocio.VentaProducto.ObtenerListaVentas();

            if (listaProductos.Count == 0)
            {
                return string.Empty;
            }

            // Encabezado del ticket
            ticket.AppendLine("==============================================");
            ticket.AppendLine("               FACTURA C - LubriCar          ");
            ticket.AppendLine("==============================================");
            ticket.AppendLine($"Fecha: {DateTime.Now}");
            ticket.AppendLine($"Cliente: {lblNombreCliente.Text}");
            ticket.AppendLine("==============================================");
            ticket.AppendLine("Cant.   Producto       Precio   Total");
            ticket.AppendLine("----------------------------------------------");

            // Datos de los productos
            foreach (var item in listaProductos)
            {
                ticket.AppendLine($"{item.Cantidad,5}   {item.Producto,-12}  {item.PrecioVenta,6:C}  {item.PrecioTotalProd,6:C}");
            }

            ticket.AppendLine("----------------------------------------------");

            // Totales
            double subtotal = listaProductos.Sum(p => p.PrecioTotalProd);
            double iva = subtotal * 0.21; // IVA 21%
            double total = subtotal + iva;

            ticket.AppendLine($"Subtotal: {subtotal,10:C}");
            ticket.AppendLine($"IVA 21% : {iva,10:C}");
            ticket.AppendLine($"Total   : {total,10:C}");
            ticket.AppendLine("==============================================");
            ticket.AppendLine("           Â¡Gracias por su compra!            ");
            ticket.AppendLine("==============================================");

            return ticket.ToString();
        }
        private string GenerarPresupuesto()
        {
            StringBuilder ticket = new StringBuilder();
            var listaProductos = Negocio.VentaProducto.ObtenerListaVentas();

            if (listaProductos.Count == 0)
            {
                return string.Empty;
            }

            // Encabezado del ticket
            ticket.AppendLine("==============================================");
            ticket.AppendLine("              PRESUPUESTO - LubriCar          ");
            ticket.AppendLine("==============================================");
            ticket.AppendLine($"Fecha: {DateTime.Now}");
            ticket.AppendLine($"Cliente: {lblNombreCliente.Text}");
            ticket.AppendLine("==============================================");
            ticket.AppendLine("Cant.   Producto       Precio   Total");
            ticket.AppendLine("----------------------------------------------");

            // Datos de los productos
            foreach (var item in listaProductos)
            {
                ticket.AppendLine($"{item.Cantidad,5}   {item.Producto,-12}  {item.PrecioVenta,6:C}  {item.PrecioTotalProd,6:C}");
            }

            ticket.AppendLine("----------------------------------------------");

            // Totales
            double subtotal = listaProductos.Sum(p => p.PrecioTotalProd);
            double iva = subtotal * 0.21; // IVA 21%
            double total = subtotal + iva;

            ticket.AppendLine($"Subtotal: {subtotal,10:C}");
            ticket.AppendLine($"IVA 21% : {iva,10:C}");
            ticket.AppendLine($"Total   : {total,10:C}");
            ticket.AppendLine("==============================================");
            ticket.AppendLine("           Â¡Esperamos su compra!              ");
            ticket.AppendLine("==============================================");

            return ticket.ToString();
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 10);
            float yPos = 0;
            int leftMargin = 10;
            float lineHeight = font.GetHeight(e.Graphics);

            using (StringReader reader = new StringReader(ticketTexto))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yPos += lineHeight;
                    e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, yPos);
                }
            }
        }
        #endregion

        #region Restriccion de botones
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
        private void RDProductos_CheckedChanged(object sender, EventArgs e)
        {
            grpProductos.Visible = true;
            GRPClientes.Visible = false;

        }

        private void RDCliente_CheckedChanged(object sender, EventArgs e)
        {
            GRPClientes.Visible = true;
            grpProductos.Visible = false;
        }




        #endregion

        private void UsuarioPrimero()
        {
            grpProductos.Enabled = false;
            grpPresupuesto.Enabled = false;
        }

        private void btnAgregarclient_Click(object sender, EventArgs e)
        {
            MenuClientes LlamarMenuClientes = new MenuClientes();
            LlamarMenuClientes.ShowDialog();
        }
    }
}