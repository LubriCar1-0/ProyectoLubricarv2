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
            try
            {
                Validaciones.DatosEmpleado(Convert.ToInt32(TbxDocumento.Text), TbxContra.Text.Trim());

                PantallaMenuPrin();
                //agregar la accion de acceder a la base de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // agregar el intento fallido de acceder 
            }
            
        }

        public static void PantallaMenuPrin()
        {
            PantallaMenuPrincipal LlamarMenuPrincipal = new PantallaMenuPrincipal();
            LlamarMenuPrincipal.ShowDialog();
        }
    }
}
