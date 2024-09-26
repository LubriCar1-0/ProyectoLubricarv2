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
    public partial class MenuVentas : Form
    {
        public MenuVentas()
        {
            InitializeComponent();
        }
        #region Llamados

        public static void PantallaMenuClientes()
        {
            MenuClientes LlamarMenuClientes = new MenuClientes();
            LlamarMenuClientes.ShowDialog();
        }
        public static void PantallaMenuVentas()
        {
            MenuVentaProductos LlamarMenuVentaProductos = new MenuVentaProductos();
            LlamarMenuVentaProductos.ShowDialog();
        }

        public static void PantallaMenuVehiculos()
        {
            MenuVehiculos LlamarMenuVehiculos = new MenuVehiculos();
            LlamarMenuVehiculos.ShowDialog();
        }


        #endregion
        private void BtnClientesMeVentas_Click(object sender, EventArgs e)
        {
            PantallaMenuClientes();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PantallaMenuPrin();
        }
        public static void PantallaMenuPrin()
        {
            PantallaMenuPrincipal LlamarMenuPrincipal = new PantallaMenuPrincipal();
            LlamarMenuPrincipal.ShowDialog();
        }
        

        private void BtnVentasMeVentas_Click(object sender, EventArgs e)
        {
            PantallaMenuVentas();
        }

        private void BtnVehiculosMeVentas_Click(object sender, EventArgs e)
        {
            PantallaMenuVehiculos();
        }
    }
}
