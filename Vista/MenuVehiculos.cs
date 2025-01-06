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
    public partial class MenuVehiculos : Form
    {
        public MenuVehiculos()
        {
            InitializeComponent();
        }

        private void TxtMarcaVehiculos_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarMeVehiculos_Click(object sender, EventArgs e)
        {
            try
            {


                Validaciones.AgregarUnEmpleado(TxtNombreEmpleado.Text.Trim(), TxtApellidoEmpleado.Text.Trim(), dniEmpleado, txtContraseña.Text.Trim(), celularEmpleado, permiso, categoriaSeleccionada);
                MessageBox.Show("El empleado ha sido cargado con exito");
            }
            catch 
            {
                
            }
        }
    }
}
