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
                
                if (int.TryParse(TbxDocumento.Text, out int documento))
                {
                    
                    Validaciones.DatosEmpleado(documento, TbxContra.Text.Trim());

                    // Bitacora Acceder a la pantalla principal
                    Hide();
                    PantallaMenuPrin();
                    
                }
                else
                {
                    
                    MessageBox.Show("El documento debe ser un número válido.");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }


        public static void PantallaMenuPrin()
        {
          
            PantallaMenuPrincipal LlamarMenuPrincipal = new PantallaMenuPrincipal();
            LlamarMenuPrincipal.ShowDialog();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
