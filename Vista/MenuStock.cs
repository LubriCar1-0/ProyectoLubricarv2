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
    public partial class MenuStock : Form
    {
        public MenuStock()
        {
            InitializeComponent();
        }
        public static void LlamarMenuAgregarProducto()
        {
            MenuAgregarProducto PantallaAgregarProducto = new MenuAgregarProducto(Empleados.IdTrabajador);
            PantallaAgregarProducto.ShowDialog();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            LlamarMenuAgregarProducto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void BtnControlDeStock_Click(object sender, EventArgs e)
        {
            MenuControlDeStock llamarcontroldestock = new MenuControlDeStock(Empleados.IdTrabajador); 
            llamarcontroldestock.ShowDialog();
        }

        private void btnABMCategoriasProductos_Click(object sender, EventArgs e)
        {
            MenuCategoriaProductos LlamarMenuCategoriasProductos = new MenuCategoriaProductos(Empleados.IdTrabajador);
            LlamarMenuCategoriasProductos.ShowDialog();
        }

        private void BtnProductosFaltantes_Click(object sender, EventArgs e)
        {
            MenuProductosFaltantes pantallaproductosFalt = new MenuProductosFaltantes();
            Hide();
            pantallaproductosFalt.ShowDialog();

        }
    }
}
