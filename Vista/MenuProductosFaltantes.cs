using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Vista
{
    public partial class MenuProductosFaltantes : Form
    {
        public MenuProductosFaltantes()
        {
            InitializeComponent();

        }

        private void MenuProductosFaltantes_Load(object sender, EventArgs e)
        {
            CargarGridProductosFaltantes();
        }

        private void DgvProductoFaltantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarGridProductosFaltantes()
        {
            DataTable dt = ValidarProducto.ObtenerProductosFaltantes();
            DgvProductoFaltantes.DataSource = dt;

            // Configuración de la GridView para mejorar la apariencia
            DgvProductoFaltantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProductoFaltantes.EnableHeadersVisualStyles = false;
            DgvProductoFaltantes.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            DgvProductoFaltantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvProductoFaltantes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            DgvProductoFaltantes.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            DgvProductoFaltantes.GridColor = Color.LightGray;
            DgvProductoFaltantes.BorderStyle = BorderStyle.None;
            DgvProductoFaltantes.RowTemplate.Height = 30;

            // Renombrar encabezados según lo que se muestra
            DgvProductoFaltantes.Columns["Nombre"].HeaderText = "Producto";
            DgvProductoFaltantes.Columns["Marca"].HeaderText = "Marca";
            DgvProductoFaltantes.Columns["CodProd"].HeaderText = "Código";
            DgvProductoFaltantes.Columns["CantidadActual"].HeaderText = "Cantidad Actual";
            DgvProductoFaltantes.Columns["CantidadMinima"].HeaderText = "Cantidad Minima";
            // Eliminar la última fila vacía
            DgvProductoFaltantes.AllowUserToAddRows = false;

            // Eliminar la columna vacía a la derecha
            DgvProductoFaltantes.RowHeadersVisible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuStock pantallaMenuStock = new MenuStock();
            Hide();
            pantallaMenuStock.ShowDialog();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MenuControlDeStock pantallaControlDeStock = new MenuControlDeStock(Empleados.IdTrabajador);
            pantallaControlDeStock.ShowDialog();
        }
    }
}
