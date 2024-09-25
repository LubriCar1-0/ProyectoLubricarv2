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


        #endregion
        private void BtnVentas_Click(object sender, EventArgs e)
        {
            LlamarMenuVentas();
        }

        
        private void BtnTurnos_Click(object sender, EventArgs e)
        {
            LlamarMenuTurnos();
        }
    }
}
