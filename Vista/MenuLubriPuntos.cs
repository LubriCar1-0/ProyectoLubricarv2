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
    public partial class MenuLubriPuntos : Form
    {
        public MenuLubriPuntos()
        {
            InitializeComponent();
        }

        private void PtbLubriPuntos_Click(object sender, EventArgs e)
        {

        }

        private void btnValorLP_Click(object sender, EventArgs e)
        {
            PantallaValorLubriPuntos();
        }
        private void btnAsignacionLP_Click_1(object sender, EventArgs e)
        {
            PantallaAsignacionLubriPuntos();
        }

        public static void PantallaValorLubriPuntos()
        {
            MenuValoresLubriPuntos LlamarMenuValoresLubriPuntos = new MenuValoresLubriPuntos();
            LlamarMenuValoresLubriPuntos.ShowDialog();
        }

        public static void PantallaAsignacionLubriPuntos()
        {
            MenuAsignacionLubriPuntos LlamarMenuAsignacionLubriPuntos = new MenuAsignacionLubriPuntos();
            LlamarMenuAsignacionLubriPuntos.ShowDialog();
        }

       
    }
}
