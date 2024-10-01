using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Vista.Validaciones;

namespace Vista
{
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void BtnAgregarMeClientes_Click(object sender, EventArgs e)
        {
            int NumeracioncasaCliente = Convert.ToInt32(TxtNumCasaCliente.Text.Trim());
            int TelefonoCliente = Convert.ToInt32(TxtTelefonoCliente.Text.Trim());
            Validar.AgregarUnCliente(TxtNombreCliente.Text.Trim(), TxtapellidoCliente.Text.Trim(), TxtRazonSocialCliente.Text.Trim(), TxtCuilCliente.Text.Trim(), TxtLocalidadCliente.Text.Trim(), TxtCalleCliente.Text.Trim(), NumeracioncasaCliente, TxtIvaCliente.Text.Trim(), TelefonoCliente);
            MessageBox.Show("Se registro correctamente");
        }
    }
}
