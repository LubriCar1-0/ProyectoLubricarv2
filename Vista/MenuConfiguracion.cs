using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Vista
{
    public partial class MenuConfiguracion : Form
    {
        public MenuConfiguracion()
        {
            InitializeComponent();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            PantallaMenuEmpleados();
        }
        public static void PantallaMenuEmpleados()
        {
            MenuEmpleado LlamarMenuEmpleado = new MenuEmpleado();
            LlamarMenuEmpleado.ShowDialog();
        }

        //private void BtnEmpresa_Click(object sender, EventArgs e)
        //{
        //    MenuDatosEmpresa LlamarMenuEmpresa = new MenuDatosEmpresa();
        //    LlamarMenuEmpresa.ShowDialog();

        //}
        private void btnABMCategoriasProductos_Click_1(object sender, EventArgs e)
        {
            MenuCategoriaProductos LlamarMenuCategoriasProductos = new MenuCategoriaProductos(Empleados.IdTrabajador);
            LlamarMenuCategoriasProductos.ShowDialog();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenuCatEMP_Click(object sender, EventArgs e)
        {
            MenuCategoriaEmpleado LlamarMenuCategoriaEmpleados = new MenuCategoriaEmpleado();
            Hide();
            LlamarMenuCategoriaEmpleados.ShowDialog();
        }
    }
}
