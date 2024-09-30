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
                int permiso = 0;
                int categoriaSeleccionada = 0;

                switch (CmbCategoriaEmple.SelectedItem.ToString())
                {
                    case "Dueño":
                        permiso = 9;
                        categoriaSeleccionada = 1;
                        break;
                    case "Mostrador":
                        permiso = 5;
                        categoriaSeleccionada = 2;
                        break;
                    case "Mecanico":
                        permiso = 3;
                        categoriaSeleccionada = 3;
                        break;
                    case "Repositor":
                        permiso = 4;
                        categoriaSeleccionada = 4;
                        break;
                    default:
                        throw new Exception("No selecciono una categoria");
                }

                // Validar y convertir el DNI y el celular
                if (!int.TryParse(TxtDniEmpleado.Text.Trim(), out int dniEmpleado))
                {
                    throw new Exception("El DNI debe ser un número válido.");
                }

                if (!int.TryParse(TxtCelularEmpleado.Text.Trim(), out int celularEmpleado))
                {
                    throw new Exception("El número de celular debe ser un número válido.");
                }

                // Llamar a la capa de validaciones con las variables de permiso y categoría
                Validaciones.AgregarUnEmpleado(TxtNombreEmpleado.Text.Trim(),TxtApellidoEmpleado.Text.Trim(), dniEmpleado,txtContraseña.Text.Trim(),celularEmpleado, permiso, categoriaSeleccionada);
                MessageBox.Show("El empleado ha sido cargado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
