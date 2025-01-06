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
            CargarClientes();
        }
        private void CargarClientes()
        {
            Dictionary<int, string> clientes = ValidarClientes.ObtenerClientesProcesados();
            foreach (var cliente in clientes)
            {
                CbxClienteMeVehiculos.Items.Add(new KeyValuePair<int, string>(cliente.Key, cliente.Value));
            }
            CbxClienteMeVehiculos.DisplayMember = "Value";
            CbxClienteMeVehiculos.ValueMember = "Key";
        }

        private int idCliente;

        private void TxtMarcaVehiculos_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarMeVehiculos_Click(object sender, EventArgs e)
        {

            try
            {
             
                    if (idCliente == 0)
                    {
                        MessageBox.Show("Seleccione un cliente válido.");
                        return;
                    }

                    // Aquí asocia el vehículo con el cliente seleccionado
                    // Llama al método necesario para guardar en la base de datos
                    // Validaciones.AgregarUnVehiculo(TxtMarcaVehiculos.Text.Trim(), TxtPatenteVehiculo.Text.Trim(), TxtModeloVehiculos.Text.Trim(), TxtAñoVehiculos.Text.Trim(), idCliente, TxtKilometrajeVehiculos.Text.Trim());
                
                
                
                MessageBox.Show("El vehiculo ha sido cargado con exito");
            }
            catch 
            {
                
            }
        }

        private void CbxClienteMeVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxClienteMeVehiculos.SelectedItem is KeyValuePair<int, string> clienteSeleccionado)
            {
                idCliente = clienteSeleccionado.Key;
            }
        }



        

        
    }
}
