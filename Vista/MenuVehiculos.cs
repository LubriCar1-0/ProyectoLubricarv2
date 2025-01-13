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
    public partial class MenuVehiculos : Form
    {
        public MenuVehiculos()
        {
            InitializeComponent();
            CargarClientes();
            CargarDatosEnGrid();



            chbEditar.CheckedChanged += chbEditar_CheckedChanged;


        }
        private void chbEditar_CheckedChanged(object sender, EventArgs e)
        {

            if (chbEditar.Checked)
            {
                DgvTablaMeVehiculos.ReadOnly = false;
                MessageBox.Show("Edición habilitada. Puedes editar la grid.", "Información");
            }
            else
            {
                DgvTablaMeVehiculos.ReadOnly = true;
                MessageBox.Show("Edición deshabilitada. La grid está bloqueada.", "Información");
            }
        }
        private void CargarDatosEnGrid()
        {
            DgvTablaMeVehiculos.DataSource = null;
            DgvTablaMeVehiculos.DataSource = ValidarClientes.BuscarVehiculos();
            DgvTablaMeVehiculos.Columns["idVehiculo"].Visible = false;
            DgvTablaMeVehiculos.Columns["idCliente"].Visible = false;

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

                ValidarClientes.AgregarUnVehiculo(idCliente, TxtModeloVehiculos.Text.Trim(), TxtMarcaVehiculos.Text.Trim(), Convert.ToInt32(TxtAñoVehiculos.Text.Trim()), TxtPatenteVehiculo.Text.Trim(), Convert.ToInt32(TxtKilometrajeVehiculos.Text.Trim()));
                CargarDatosEnGrid();



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



        private void MenuVehiculos_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultaMeVehiculos_Click(object sender, EventArgs e)
        {

        }

        private void DgvTablaMeVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvTablaMeVehiculos.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionada = DgvTablaMeVehiculos.Rows[e.RowIndex];

                    int idVehiculo = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
                    int idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                    CbxClienteMeVehiculos.Text = ValidarClientes.ObtNomCliente(idCliente);
                    TxtMarcaVehiculos.Text = filaSeleccionada.Cells["marcaVH"].Value.ToString().Trim();
                    TxtModeloVehiculos.Text = filaSeleccionada.Cells["modeloVH"].Value.ToString().Trim();
                    TxtAñoVehiculos.Text = filaSeleccionada.Cells["añoVh"].Value.ToString().Trim();
                    TxtPatenteVehiculo.Text = filaSeleccionada.Cells["patenteVH"].Value.ToString().Trim();
                    TxtKilometrajeVehiculos.Text = filaSeleccionada.Cells["KilometrajeVH"].Value.ToString().Trim();

                    ValidarClientes.ModificarVehiculo(idVehiculo, idCliente, TxtModeloVehiculos.Text.Trim(), TxtMarcaVehiculos.Text.Trim(), Convert.ToInt32(TxtAñoVehiculos.Text.Trim()), TxtPatenteVehiculo.Text.Trim(), Convert.ToInt32(TxtKilometrajeVehiculos.Text.Trim()));
                }
            }
            else if (DgvTablaMeVehiculos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionada = DgvTablaMeVehiculos.Rows[e.RowIndex];


                    int idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                    CbxClienteMeVehiculos.Text = ValidarClientes.ObtNomCliente(idCliente);
                    TxtMarcaVehiculos.Text = filaSeleccionada.Cells["marcaVH"].Value.ToString().Trim();
                    TxtModeloVehiculos.Text = filaSeleccionada.Cells["modeloVH"].Value.ToString().Trim();
                    TxtAñoVehiculos.Text = filaSeleccionada.Cells["añoVh"].Value.ToString().Trim();
                    TxtPatenteVehiculo.Text = filaSeleccionada.Cells["patenteVH"].Value.ToString().Trim();
                    TxtKilometrajeVehiculos.Text = filaSeleccionada.Cells["KilometrajeVH"].Value.ToString().Trim();
                }
            }




        }






    }
}
