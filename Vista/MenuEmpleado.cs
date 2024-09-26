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
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
        }

        private void BtnAgregarMeEmpleado_Click(object sender, EventArgs e)
        {
                try
                {
                    Validaciones.AgregarUnEmpleado(TxtNombreEmpleado.Text.Trim(), TxtApellidoEmpleado.Text.Trim(), Convert.ToInt32(TxtDniEmpleado), txtContraseña.Text.Trim(), Convert.ToInt32(TxtCelularEmpleado), Convert.ToInt32(CmbPermisoEmpleado), Convert.ToInt32(CmbCategoriaEmple));

                    
                    //agregar la accion de agregar un empleado
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // agregar el intento fallido de acceder 
                }

            
        }
    }
}
