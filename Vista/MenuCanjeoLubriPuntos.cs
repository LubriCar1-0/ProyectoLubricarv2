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
    public partial class MenuCanjeoLubriPuntos : Form
    {
        public MenuCanjeoLubriPuntos()
        {
            InitializeComponent();
            CargartablaClientes();                     
            CargarProductosParaCanje();           
            ConfiguraDataGrid(DGVclientes);
            ConfiguraDataGrid(DGVproductos);
            txtCantidadCanje.Text = "0";
            DGVclientes.CellClick += DGVclientes_CellContentClick;
            DGVclientes.Columns["idCliente"].Visible = false;
            DGVproductos.Columns["idProd"].Visible = false;
        }

        int Idproducto;
        int IdCliente;
        int CantidadLubriPuntos;
        int CategoriaProducto;
        int PuntosCliente;

        #region CargarTablas
        private void CargartablaClientes()
        {
            try
            {
                DGVclientes.DataSource = null;
                DGVclientes.DataSource = ValidarLubriPuntos.TraerClientes();
                DGVclientes.Columns["idCliente"].Visible = false;
                DGVclientes.Columns["Localidad"].Visible = false;
                DGVclientes.Columns["Calle"].Visible = false;
                DGVclientes.Columns["Numero de vivienda"].Visible = false;
                DGVclientes.Columns["Telefono"].Visible = false;
                DGVclientes.Columns["idCondicionIva"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarClientesconfiltro(string dni)
        {
            try
            {
                DGVclientes.DataSource = null;
                var clientes = ValidarLubriPuntos.Clientesconfiltro(dni);
                DGVclientes.DataSource = clientes;
                DGVclientes.Columns["idCliente"].Visible = false;
                DGVclientes.Columns["Localidad"].Visible = false;
                DGVclientes.Columns["Calle"].Visible = false;
                DGVclientes.Columns["Numero de vivienda"].Visible = false;
                DGVclientes.Columns["Telefono"].Visible = false;
                DGVclientes.Columns["idCondicionIva"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarProductosParaCanje()
        {
            try
            {
                DGVproductos.DataSource = null;
                DGVproductos.DataSource = ValidarLubriPuntos.ObtenerProductosParaCanje();
                DGVproductos.Columns["idProd"].Visible = false;
                DGVproductos.Columns["IdCategorias"].Visible = false;
                DGVproductos.Columns["CodProd"].HeaderText = "Código";
                DGVproductos.Columns["Nombre"].HeaderText = "Producto";
                DGVproductos.Columns["Marca"].HeaderText = "Marca";
                DGVproductos.Columns["Cantidad"].HeaderText = "Stock";
                DGVproductos.Columns["LitrosDisp"].HeaderText = "Litros";
                DGVproductos.Columns["CantidadLubriPuntos"].HeaderText = "LubriPuntos";
                DGVproductos.Columns["StockDisponible"].Visible=false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
         private void CargarProductosconfiltro(string codigo)
         {
            try
            {
                DGVproductos.DataSource = null;
                var productos = ValidarLubriPuntos.Productosparacanjeconfiltro(codigo);
                DGVproductos.DataSource = productos;
                DGVproductos.Columns["idProd"].Visible = false;
                DGVproductos.Columns["IdCategorias"].Visible = false;
                DGVproductos.Columns["CodProd"].HeaderText = "Código";
                DGVproductos.Columns["Nombre"].HeaderText = "Producto";
                DGVproductos.Columns["Marca"].HeaderText = "Marca";
                DGVproductos.Columns["Cantidad"].HeaderText = "Stock";
                DGVproductos.Columns["LitrosDisp"].HeaderText = "Litros";
                DGVproductos.Columns["CantidadLubriPuntos"].HeaderText = "LubriPuntos";
                DGVproductos.Columns["StockDisponible"].Visible = false;
                DGVproductos.RowHeadersVisible = false;
                ConfiguraDataGrid(DGVproductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
        #endregion

        #region ConfiguracionTablas
        
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
        private void DGVproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = DGVproductos.Rows[e.RowIndex];
                string Producto = filaSeleccionada.Cells["Nombre"].Value.ToString().Trim();
                int LubriPuntos = Convert.ToInt32(filaSeleccionada.Cells["CantidadLubriPuntos"].Value);
                CategoriaProducto = Convert.ToInt32(filaSeleccionada.Cells["IdCategorias"].Value);
                CantidadLubriPuntos = Convert.ToInt32(filaSeleccionada.Cells["CantidadLubriPuntos"].Value);
                Idproducto = Convert.ToInt32(filaSeleccionada.Cells["idProd"].Value);
                lblProducto.Text = Producto;
                lblPuntosProdu.Text = LubriPuntos.ToString();
                if (CategoriaProducto == 2)
                {
                    label7.Text = "Litros a canjear";
                }
                else if (CategoriaProducto == 3)
                {
                    label7.Text = "Cantidad a canjear";
                }
            }
        }

        private void DGVclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = DGVclientes.Rows[e.RowIndex];
                string Cliente = filaSeleccionada.Cells["Nombre"].Value.ToString().Trim();
                int LubriPuntos = Convert.ToInt32(filaSeleccionada.Cells["LubriPuntos"].Value);
                IdCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                lblNombreProd.Text = Cliente;
                lblLubriClientes.Text = LubriPuntos.ToString();
            }
        }
        #endregion

        #region Botones

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnBuscarProduc_Click(object sender, EventArgs e)
        {
            CargarProductosconfiltro(TxtFiltroProduc.Text);
            DGVproductos.Columns["idProd"].Visible = false;
          
        }

        private void btnRecargarProduc_Click(object sender, EventArgs e)
        {
            CargarProductosParaCanje();
            DGVproductos.Columns["idProd"].Visible = false;
        }
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            CargarClientesconfiltro(txtFiltroClientes.Text);
            DGVclientes.Columns["idCliente"].Visible = false;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                MessageBox.Show("Debes seleccionar un cliente antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Idproducto == 0)
            {
                MessageBox.Show("Debes seleccionar un producto antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

            int stockDisponible = 0;
            if (CategoriaProducto == 2)
            {
                stockDisponible = Convert.ToInt32(DGVproductos.SelectedRows[0].Cells["LitrosDisp"].Value);
            }
            else if (CategoriaProducto == 3)
            {
                stockDisponible = Convert.ToInt32(DGVproductos.SelectedRows[0].Cells["Cantidad"].Value);
            }

            int cantidad = Convert.ToInt32(txtCantidadCanje.Text);
            if (cantidad > stockDisponible)
            {
                MessageBox.Show("No hay suficiente stock disponible para realizar el canje.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Valorfinal = CantidadLubriPuntos * cantidad;
            int PuntosCliente = Convert.ToInt32(DGVclientes.SelectedRows[0].Cells["LubriPuntos"].Value);

            if (Valorfinal > PuntosCliente)
            {
                MessageBox.Show("El cliente no tiene suficientes puntos para realizar el canje", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (txtCantidadCanje.Text == "0")
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida a canjear.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LubriPuntos.RestarProducto(Idproducto, cantidad);
                    LubriPuntos.RestarLubriPuntos(IdCliente, Valorfinal);
                    ValidarLubriPuntos.Registrarcanje(IdCliente, Valorfinal);
                    CargarProductosParaCanje();
                    CargartablaClientes();
                    MessageBox.Show("Canje exitoso");
                    txtCantidadCanje.Text = "0";
                    Idproducto = 0;
                    IdCliente = 0;
                }

            }
        }


        private void BtnRecargarCliente_Click(object sender, EventArgs e)
        {
            CargartablaClientes();
        }

        #endregion

        private void txtFiltroClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtCantidadCanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void DGVclientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuCanjeoLubriPuntos_Load(object sender, EventArgs e)
        {

        }
    }
}
