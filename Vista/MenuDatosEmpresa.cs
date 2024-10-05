using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class MenuDatosEmpresa : Form
    {
        public MenuDatosEmpresa()
        {
            InitializeComponent();
            
            var datos = new List<string> { "Responsable Inscripto","Responsable No Inscripto","Exento", "Monotributista","No Alcanzado" };          
            CbxCondicionIva.Items.Clear();//Borra los valores del combo box
            CbxCondicionIva.Items.AddRange(datos.ToArray());//Los carga
        }


        private void BtnConfirmarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                if (CbxCondicionIva.SelectedItem != null)
                {
                    // Guarda el valor seleccionado en una variable
                    string perfilSeleccionado = CbxCondicionIva.SelectedItem.ToString();
                    Validaciones.AgregarEmpresa(TxtNombreEmpresa.Text, TxtCuilEmpresa.Text, TxtDomicilio.Text, perfilSeleccionado, TxtPuntoDeVenta.Text);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un perfil de IVA.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnEditarEmpresa_Click(object sender, EventArgs e)
        {

        }
        

        //private void CbxCondicionIva_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    List<string> perfilesIva = new List<string>
        //    {
        //        "Responsable Inscripto",
        //        "Responsable No Inscripto",
        //        "Exento",
        //        "Monotributista",
        //        "No Alcanzado"
        //    };
        //    // Limpiar el ComboBox (si es necesario)
        //    CbxCondicionIva.Items.Clear();

        //    // Cargar los perfiles en el ComboBox
        //    CbxCondicionIva.Items.AddRange(perfilesIva.ToArray());

        //    // Seleccionar un perfil por defecto (opcional)
        //    CbxCondicionIva.SelectedIndex = 0; // Selecciona "Responsable Inscripto" por defecto
        //}
    }
}
