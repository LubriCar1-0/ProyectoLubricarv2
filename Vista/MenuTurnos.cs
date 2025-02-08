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
    public partial class MenuTurnos : Form
    {
        public MenuTurnos()
        {
            InitializeComponent();
        }
        #region Llamados
        //public static void PantallaMenuCrearTurnos()
        //{
        //    MenuCrearTurnos LlamarMenuCrearTurnos = new MenuCrearTurnos();
        //    Hide();
        //    LlamarMenuCrearTurnos.ShowDialog(); 
        //}
        public static void PantallaMenuModificarTurnos()
        {
            
        }
        public static void PantallaMenuCancelarTurnos()
        {
           
        }





        #endregion
        private void BtnCrearTurno_Click(object sender, EventArgs e)
        {

            MenuCrearTurnos LlamarMenuCrearTurnos = new MenuCrearTurnos();
            Hide();
            LlamarMenuCrearTurnos.ShowDialog();
        }

        private void BtnTurnosMeTurnos_Click(object sender, EventArgs e)
        {
            MenuTurnosTrabajos PantallaTurnos = new MenuTurnosTrabajos();
            Hide();
            PantallaTurnos.ShowDialog();
        }

        private void BtnCancelacionTurno_Click(object sender, EventArgs e)
        {
            MenuCancelarTurno PantallaCancelarTurnos = new MenuCancelarTurno(); 
            Hide(); 
            PantallaCancelarTurnos.ShowDialog();
        }
    }
}
