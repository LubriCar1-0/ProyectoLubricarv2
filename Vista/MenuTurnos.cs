using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Vista
{
    public partial class MenuTurnos : Form
    {
        public MenuTurnos()
        {
            InitializeComponent();
        }
        #region Llamados
        public bool LlamarCancelCrearTurnos()
        {
            int IdCategoria = Empleados.idCategoria;

            int ChequeaPermiso = Conectar.VerificaPermiso(IdCategoria);
            if (ChequeaPermiso == 9 || ChequeaPermiso == 5)
            {
                bool permiso = true;
                return permiso;
            }
            else
            {

                bool permiso = false;
                return permiso;
            }

        }
        public bool LlamarTurnosOrden()
        {
            int IdCategoria = Empleados.idCategoria;
            int ChequeaPermiso = Conectar.VerificaPermiso(IdCategoria);
            if (ChequeaPermiso == 9 || ChequeaPermiso == 5 || ChequeaPermiso == 3)
            {
                bool permiso = true;
                return permiso;
            }
            else
            {

                bool permiso = false;
                return permiso;
            }
        }





        #endregion
        private void BtnCrearTurno_Click(object sender, EventArgs e)
        {
            bool permiso = LlamarCancelCrearTurnos();

            if (permiso == true)
            {
                MenuCrearTurnos LlamarMenuCrearTurnos = new MenuCrearTurnos();
                LlamarMenuCrearTurnos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta pantalla", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnTurnosMeTurnos_Click(object sender, EventArgs e)
        {
            bool permiso = LlamarTurnosOrden();

            if (permiso == true)
            {
                MenuTurnosTrabajos PantallaTurnos = new MenuTurnosTrabajos();
                PantallaTurnos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta pantalla", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnCancelacionTurno_Click(object sender, EventArgs e)
        {
            bool permiso = LlamarCancelCrearTurnos();
            if (permiso == true)
            {
                MenuCancelarTurno PantallaCancelarTurnos = new MenuCancelarTurno();
                PantallaCancelarTurnos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta pantalla", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
