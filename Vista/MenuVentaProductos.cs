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
        public MenuVentaProductos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PantallaMenuVentas();
        }
        public static void PantallaMenuVentas()
        {
            MenuVentas LlamarMenuVentas = new MenuVentas();
            LlamarMenuVentas.ShowDialog();
        }
    }
}
