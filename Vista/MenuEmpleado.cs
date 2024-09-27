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
            CargarCategorias();
        }

        private void BtnAgregarMeEmpleado_Click(object sender, EventArgs e)
        {
                try
                {
                    int dniEmpleado = Convert.ToInt32(TxtDniEmpleado.Text.Trim());
                    int celularEmpleado = Convert.ToInt32(TxtCelularEmpleado.Text.Trim());
                    string categoriaSeleccionada = CmbCategoriaEmple.SelectedItem.ToString();
                    Validaciones.AgregarUnEmpleado(TxtNombreEmpleado.Text.Trim(), TxtApellidoEmpleado.Text.Trim(), dniEmpleado, txtContraseña.Text.Trim(), celularEmpleado, categoriaSeleccionada);

                    
                    //agregar la accion de agregar un empleado
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // agregar el intento fallido de acceder 
                }

            
        }

        private void CmbCategoriaEmple_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = CmbCategoriaEmple.SelectedItem.ToString();
            var categorias = Validaciones.ObtenerCategoriasProcesadas();

            if (categorias.ContainsKey(categoriaSeleccionada))
            {
                int permisoCat = categorias[categoriaSeleccionada];
                
                
            }
        }
        private void CargarCategorias()
        {
            var categorias = Validaciones.ObtenerCategoriasProcesadas();  

            foreach (var categoria in categorias)
            {
                CmbCategoriaEmple.Items.Add(categoria.Key); 
            }
        }
    }
}
