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
    public partial class PantallaMenuPrincipal : Form
    {
        public PantallaMenuPrincipal()
        {
            InitializeComponent();
        }
        #region

        public static void LlamarMenuVentas()
        {
            MenuVentas PantallaMenuVentas = new MenuVentas();
            PantallaMenuVentas.ShowDialog();
        }

        public static void LlamarMenuTurnos()
        {
            MenuTurnos PantallaMenuTurnos = new MenuTurnos();
            PantallaMenuTurnos.ShowDialog();
        }

        public static void LlamarMenuHistorial()
        {
            MenuHistorial PantallaMenuHistorial = new MenuHistorial();
            PantallaMenuHistorial.ShowDialog();
        }
        public static void LlamarMenuOrdenDeTrabajo()
        {
            MenuOrdenDeTrabajo PantallaMenuOrdenDeTrabajo = new MenuOrdenDeTrabajo();
            PantallaMenuOrdenDeTrabajo.ShowDialog();
        }

        public static void LlamarMenuStock()
        {
            MenuStock PantallaMenuStock = new MenuStock();
            PantallaMenuStock.ShowDialog();
        }
        public static void LlamarMenuConfiguracion()
        {
            MenuConfiguracion PantallaMenuConfiguracion = new MenuConfiguracion();
            PantallaMenuConfiguracion.ShowDialog();
        }
        public static void LlamarMenuLubriPuntos()
        {
            MenuLubriPuntos PantallaMenuLubriPuntos = new MenuLubriPuntos();
            PantallaMenuLubriPuntos.ShowDialog();
        }


        #endregion
        private void BtnVentas_Click(object sender, EventArgs e)
        {
            LlamarMenuVentas();
        }


        private void BtnTurnos_Click(object sender, EventArgs e)
        {
            LlamarMenuTurnos();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            LlamarMenuHistorial();
        }

        private void BtnOrdenDeTrabajo_Click(object sender, EventArgs e)
        {
            LlamarMenuOrdenDeTrabajo();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            LlamarMenuStock();
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            LlamarMenuConfiguracion();
        }

        private void BtnLubriPuntos_Click(object sender, EventArgs e)
        {
            LlamarMenuLubriPuntos();
        }

        private void PantallaMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
