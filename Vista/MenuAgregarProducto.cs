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
using static Vista.Validaciones;


namespace Vista
{
    public partial class MenuAgregarProducto : Form
    {
        public MenuAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(TxtCantidad.Text.Trim()); 
            decimal precioLista = decimal.Parse(TxtPrecioList.Text.Trim());
            decimal precioVenta = decimal.Parse(txtPrecioVent.Text.Trim());
            int CodigoProducto = int.Parse(txtcodigoProducto.Text.Trim());
            decimal LitrosDisponibles = decimal.Parse(txtLitros.Text.Trim());


            ValidarProducto.AgregarUnProducto(TxtNombreProducto.Text.Trim(), TxtMarcaProducto.Text.Trim(), cmbCategoria.SelectedItem.ToString(), CodigoProducto, TxtDescripcion.Text.Trim(), cantidad, precioLista, precioVenta, LitrosDisponibles);
        }

        private void MenuAgregarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
