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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            PantallaMenuPrin();
        }

        public static void PantallaMenuPrin()
        {
            PantallaMenuPrincipal LlamarMenuPrincipal = new PantallaMenuPrincipal();
            LlamarMenuPrincipal.ShowDialog();
        }
    }
}
