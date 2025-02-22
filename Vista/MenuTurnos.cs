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
        





        #endregion
        private void BtnCrearTurno_Click(object sender, EventArgs e)
        {
            MenuCrearTurnos LlamarMenuCrearTurnos = new MenuCrearTurnos();
            LlamarMenuCrearTurnos.ShowDialog();
        }

        private void BtnTurnosMeTurnos_Click(object sender, EventArgs e)
        {
            MenuTurnosTrabajos PantallaTurnos = new MenuTurnosTrabajos();
            PantallaTurnos.ShowDialog();
        }

        private void BtnCancelacionTurno_Click(object sender, EventArgs e)
        {
            MenuCancelarTurno PantallaCancelarTurnos = new MenuCancelarTurno();  
            PantallaCancelarTurnos.ShowDialog();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
