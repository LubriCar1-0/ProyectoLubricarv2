﻿using Negocio;
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
    public partial class MenuVentaProductos : Form
    {
        public double litrosDisp;
        public int cantidadDisp;
        public int idcliente;
        public double PrecioVenta;

        public MenuVentaProductos()
        {
            InitializeComponent();
            CargatablaClientes();
            dgvClientes.Columns["idCliente"].Visible = false;
            CargatablaProductos();
            dgvProductos.Columns["idProd"].Visible = false;
            CargarCategorias();
            ConfiguraDataGrid(dgvClientes);
            ConfiguraDataGrid(dgvProductos);
            UsuarioPrimero();
            lblIdproducto.Visible = false;
            lblTEXTdisponible.Visible = false;
            lblTEXTOlitros.Visible = false;
        }
        #region Volver pantalla anterior
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PantallaMenuVentas();
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
        private void CargaClientesFiltro(int dni)
        {
            try
            {
                dgvClientes.DataSource = null;
                var productos = ValidarVenta.VentaClientesFiltro(dni);
                dgvClientes.DataSource = productos;
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
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Azul más claro
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

                lblNombreCliente.Text = apellidoClien+","+NombreClien;
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
                int dni = Convert.ToInt32(txtCliente.Text);
                CargaClientesFiltro(dni);
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
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            int idcat = IdCategorias;
            string codprod = txtCodigoProd.Text.ToUpper();
            string nombreprod = txtNombreProd.Text.ToUpper();
            MessageBox.Show(idcat.ToString()+","+ codprod + "," + nombreprod, "Error");
            if (idcat == 0 &&codprod == string.Empty && nombreprod == string.Empty)
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
        #region carga lista Productos
        
        private void btnagregalista_Click(object sender, EventArgs e)
        {                 
            int cantidad = Convert.ToInt32(lblDisponible.Text);
            double cantidadlitro = Convert.ToDouble(lblLitros.Text);                
            ValidarVenta.CargaLista(idcliente,Convert.ToInt32(lblIdproducto.Text), lblProducto.Text, Convert.ToInt32(lblDisponible.Text), Convert.ToDouble(lblLitros.Text), Convert.ToInt32(txtCantidad.Text), PrecioVenta);
            CargaTablaLista();
            double subtotal = ValidarVenta.CalculaTotal();
            RecargaTotales(subtotal);
            ConfiguraDataGrid(dgvVentas);
            dgvVentas.Columns["idCliente"].Visible = false;
            dgvVentas.Columns["IdProducto"].Visible = false;
            LimpiaLblProducto();
            grpPresupuesto.Enabled = true;
            //MessageBox.Show(lblProducto.Text + "," + lblDisponible.Text + "," + lblLitros.Text + "," + txtCantidad.Text + "," + PrecioVenta);                              

        }

        public void RecargaTotales(double subtotal)
        {
            lblSubTotal.Text = subtotal.ToString();
            double IVA = (subtotal * 0.21);
            lblIVA.Text = IVA.ToString();
            double Total = subtotal + IVA;
            lblTotal.Text = Total.ToString();
        }



        #endregion

        #region carga venta
        private void button6_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                VentaProducto.Cargaventa();
                MessageBox.Show("Venta cargada con exito");
                VentaProducto.LimpiaLista();
                CargaTablaLista();
                dgvVentas.Columns["idCliente"].Visible = false;
                dgvVentas.Columns["IdProducto"].Visible = false;
                CargatablaProductos();
            }

        }



        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VentaProducto.LimpiaLista();
            CargaTablaLista();
            dgvVentas.Columns["idCliente"].Visible = false;
            dgvVentas.Columns["IdProducto"].Visible = false;

            lblSubTotal.Text = "0.0";
            lblIVA.Text = "0.0";
            lblTotal.Text = "0.0";
        }
        private void UsuarioPrimero()
        {
            grpProductos.Enabled = false;
            grpPresupuesto.Enabled = false;
        }

        #region Restriccion de botones
        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }




        #endregion

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }
    }






}


