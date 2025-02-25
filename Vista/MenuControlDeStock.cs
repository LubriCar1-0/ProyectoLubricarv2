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

namespace Vista
{
    public partial class MenuControlDeStock : Form
    {
        private int _idTrabajador;
        public MenuControlDeStock(int idTrabajador)
        {
            InitializeComponent();
            CargatablaProductosSinFiltro();
            DgvControlDeStock.ReadOnly = true;
            txbCant.KeyPress += SoloNumeros_KeyPress;
            txbCantMinima.KeyPress += SoloNumeros_KeyPress;
            txtLitrosDisp.KeyPress += SoloNumerosDecimal_KeyPress;
            txtLitrosMin.KeyPress += SoloNumerosDecimal_KeyPress;
            txbPrecioList.KeyPress += SoloNumerosDecimal_KeyPress;
            txbPrecioVent.KeyPress += SoloNumerosDecimal_KeyPress;
            _idTrabajador = idTrabajador;
        }
        public int idProducto;

        private void DgvControlDeStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionadaUPD = DgvControlDeStock.Rows[e.RowIndex];
                txbCant.Text = Convert.ToString(filaSeleccionadaUPD.Cells["Cantidad"].Value);
                txbCantMinima.Text = Convert.ToString(filaSeleccionadaUPD.Cells["CantidadMinima"].Value);
                txbPrecioList.Text = Convert.ToString(filaSeleccionadaUPD.Cells["Precio_Lista"].Value);
                txbPrecioVent.Text = Convert.ToString(filaSeleccionadaUPD.Cells["precioventa"].Value);
                txtLitrosDisp.Text = Convert.ToString(filaSeleccionadaUPD.Cells["LitrosDisp"].Value);
                txtLitrosMin.Text = Convert.ToString(filaSeleccionadaUPD.Cells["LitrosMinimo"].Value);
                lblNombreProd.Text = Convert.ToString(filaSeleccionadaUPD.Cells["Nombre"].Value);
                idProducto = Convert.ToInt32(filaSeleccionadaUPD.Cells["idProd"].Value);
                int categoria = Convert.ToInt32(filaSeleccionadaUPD.Cells["IdCategorias"].Value);

                if (categoria == 2)
                {
                    
                    txbCant.Enabled = false;
                    txbCantMinima.Enabled = false;
                    
                    txtLitrosDisp.Enabled = true;
                    txtLitrosMin.Enabled = true;
                }
                else if (categoria == 3)
                {
                    txtLitrosDisp.Enabled = false;
                    txtLitrosMin.Enabled = false;
                    
                    txbCant.Enabled = true;
                    txbCantMinima.Enabled = true;
                }

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargatablaProductosSinFiltro()
        {
            try
            {
                DgvControlDeStock.DataSource = null;
                var productos = ValidarProducto.TraeProductos();
                DgvControlDeStock.DataSource = productos;
                DgvControlDeStock.Columns["Nombre"].Width = 280;
                DgvControlDeStock.Columns["Marca"].Width = 290;
                DgvControlDeStock.Columns["Estado"].Width = 30;
                DgvControlDeStock.AllowUserToResizeColumns = false;
                DgvControlDeStock.AllowUserToResizeRows = false;
                DgvControlDeStock.Columns["IdProd"].Visible= false;
                DgvControlDeStock.Columns["IdCategorias"].Visible = false;
                DgvControlDeStock.Columns["Descripcion"].Visible = false;
                DgvControlDeStock.Columns["Estado"].Visible = false;
                DgvControlDeStock.Columns["Cantidad"].Visible = false;
                DgvControlDeStock.Columns["Precio_Lista"].Visible = false;
                DgvControlDeStock.Columns["PrecioVenta"].Visible = false;
                DgvControlDeStock.Columns["LitrosDisp"].Visible = false;
                DgvControlDeStock.Columns["CantidadMinima"].Visible = false;
                DgvControlDeStock.Columns["LitrosMinimo"].Visible = false;
                DgvControlDeStock.RowHeadersVisible = false;
                //DgvControlDeStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //DgvControlDeStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
                int cantidad = Convert.ToInt32(txbCant.Text);
                int cantidadmin = Convert.ToInt32(txbCantMinima.Text);
                double preciolista = Convert.ToDouble(txbPrecioList.Text);
                double precioventa = Convert.ToDouble(txbPrecioVent.Text);
                double litraje = Convert.ToDouble(txtLitrosDisp.Text);
                double litrajeMin = Convert.ToDouble(txtLitrosMin.Text);
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que querer continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            

                if (resultado == DialogResult.Yes)
                {
                    ValidarProducto.ControlStock(idProducto, cantidad, preciolista, precioventa, litraje, litrajeMin, cantidadmin, _idTrabajador );


                    CargatablaProductosSinFiltro();

                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargatablaProductosConfiltro(TxtCodProducto.Text.Trim());

        }
        private void CargatablaProductosConfiltro(string codigo)
        {
            try
            {
                DgvControlDeStock.DataSource = null;
                var productos = ValidarProducto.ControlStockFiltro(codigo);
                DgvControlDeStock.DataSource = null;
                DgvControlDeStock.DataSource = productos;
                DgvControlDeStock.Columns["Nombre"].Width = 280;
                DgvControlDeStock.Columns["Marca"].Width = 290;
                DgvControlDeStock.Columns["Estado"].Width = 30;
                DgvControlDeStock.AllowUserToResizeColumns = false;
                DgvControlDeStock.AllowUserToResizeRows = false;
                DgvControlDeStock.Columns["IdProd"].Visible = false;
                DgvControlDeStock.Columns["IdCategorias"].Visible = false;
                DgvControlDeStock.Columns["Descripcion"].Visible = false;
                DgvControlDeStock.Columns["Estado"].Visible = false;
                DgvControlDeStock.Columns["Cantidad"].Visible = false;
                DgvControlDeStock.Columns["Precio_Lista"].Visible = false;
                DgvControlDeStock.Columns["PrecioVenta"].Visible = false;
                DgvControlDeStock.Columns["LitrosDisp"].Visible = false;
                DgvControlDeStock.Columns["CantidadMinima"].Visible = false;
                DgvControlDeStock.Columns["LitrosMinimo"].Visible = false;
                DgvControlDeStock.RowHeadersVisible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        private void SoloNumerosDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            
            if (e.KeyChar == '.' && txt.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargatablaProductosSinFiltro();
        }

        private void MenuControlDeStock_Load(object sender, EventArgs e)
        {

        }
    }
}
