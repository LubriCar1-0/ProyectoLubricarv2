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
        #region Variables
        public double litrosDisp;
        public int cantidadDisp;
        public int idcliente;
        public double PrecioVenta;
        private PrintDocument printDocument;
        private string ticketTexto;
        // Propiedades públicas para recibir datos de la orden
        public string Patente { get; set; }
        public string Cliente { get; set; }
        public string Trabajador { get; set; }
        public string DescripcionOrden { get; set; }
        public DateTime FechaInicioOrden { get; set; }
        public string Vehiculo { get; set; }
        public string EstadoOrden { get; set; }
        public int idOrdenTrab {  get; set; }
        #endregion

        #region Iniciador
        public MenuOrdenDeTrabajo()
        {

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            CargatablaProductos();
            dgvProductos.Columns["idProd"].Visible = false;
            CargarCategorias();
            ConfiguraDataGrid(dgvProductos);
            lblIdproducto.Visible = false;
            lblTEXTdisponible.Visible = false;
            lblTEXTOlitros.Visible = false;
            lblIdCat.Visible = false;
            printDocument = new PrintDocument();
            TxbDescripcion.ReadOnly = true;
            txbEmpleado.ReadOnly = true;
            txbPatente.ReadOnly = true;
            txbVehiculo.ReadOnly = true;
            DtpFechaDeInicio.ShowUpDown = true; 
            DtpFechaDeInicio.Enabled = false;
            
            
        }

        private void MenuOrdenDeTrabajo_Load(object sender, EventArgs e)
        {
            // Asigna los valores recibidos a los controles correspondientes.
            // Se asume que en el formulario existen controles como txbPatenteOrden, txbClienteOrden, etc.
            txbPatente.Text = this.Patente;
            txbVehiculo.Text = this.Vehiculo;
            txbEmpleado.Text = this.Trabajador;
            TxbDescripcion.Text = this.DescripcionOrden;
            DtpFechaDeInicio.Value = this.FechaInicioOrden;
            cmbEstado.Text = this.EstadoOrden;
            //idOrdenTrabajo = this.idOrdenTrab;
            lblidOrdenTrab.Text = idOrdenTrab.ToString();
            // Limpiar cualquier item previo (opcional)
            cmbEstado.Items.Clear();
            CargarListaGuardada(idOrdenTrab);
            // Agregar los valores permitidos al ComboBox
            cmbEstado.Items.Add("INICIADO");
            cmbEstado.Items.Add("CANCELADO");
            cmbEstado.Items.Add("FINALIZADO");
            
            
            // Seleccionar por defecto "INICIADO"
            cmbEstado.SelectedItem = "INICIADO";
        }
        #endregion

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
            dgvVentas.DataSource = ValidarOrdenDeTrabajo.ObtenerLista();
            
        }
        



        private void CargarListaGuardada(int idOrden)
        {
            OrdenDeTrabajo.LimpiaLista();
            var listaGuardada = ValidarOrdenDeTrabajo.ObtenerListaGuardada(idOrden);
            foreach (var item in listaGuardada)
            {

                OrdenDeTrabajo.cargaListaProd(
                    item.idOrdenTrabajo,
                    item.IdProducto,          
                    item.Producto,
                    (int)item.Cantidad,
                    item.PrecioVenta
                );
            }

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = OrdenDeTrabajo.ObtenerListaOrden();
            ConfiguraDataGrid(dgvVentas);


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
                ValidarOrdenDeTrabajo.CargaListaDeProd(idOrdenTrab, Convert.ToInt32(lblIdproducto.Text), lblProducto.Text, Convert.ToInt32(lblDisponible.Text), Convert.ToDouble(lblLitros.Text), Convert.ToInt32(txtCantidad.Text), PrecioVenta);
                CargaTablaLista();
                ConfiguraDataGrid(dgvVentas);
                LimpiaLblProducto();
                grpPresupuesto.Enabled = true;
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

        #region Restricciones 
        
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }



        #endregion

        #region Confirmar Productos 
        private void btnGuardarLista_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Â¿EstÃ¡s seguro de que quieres continuar?", "ConfirmaciÃ³n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                OrdenDeTrabajo.CargaList(idOrdenTrab);
                VentaProducto.LimpiaLista();
                CargaTablaLista();
                //dgvVentas.Columns["idCliente"].Visible = false;
                //dgvVentas.Columns["IdProducto"].Visible = false;
                CargatablaProductos();

            }
        }
        #endregion

        #region Grid
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
        #endregion

        #region volver  
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MenuTurnosTrabajos PantallaTurnoTrabajo = new MenuTurnosTrabajos();
            Hide();
            PantallaTurnoTrabajo.ShowDialog();
        }
        #endregion
    }
}
