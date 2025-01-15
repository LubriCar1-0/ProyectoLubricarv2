using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Negocio.Cliente;
using static Vista.Validaciones;

namespace Vista
{
    public partial class MenuClientes : Form
    {
        
        public MenuClientes()
        {
            InitializeComponent();
            CargarClientes();
            ConfigurarDataGridView();
            CargarCategorias();


        }
       
        private void CargarClientes() 
        {
            
            DgvTablaClientes.DataSource = null;
            DgvTablaClientes.DataSource = Validarcliente.ObtenerClientes();
            if (DgvTablaClientes.Columns.Contains("idCondicion"))
            {
                DgvTablaClientes.Columns["idCondicion"].Visible = false;
            }


        }
        private void CargarCategorias()
        {
            Dictionary<int, string> Condiciones = Validarcliente.ObtenerCondicionesIva();
            foreach (var Cond in Condiciones)
            {
                CMBIVA.Items.Add(new KeyValuePair<int, string>(Cond.Key, Cond.Value));
            }
            CMBIVA.DisplayMember = "Value";
            CMBIVA.ValueMember = "Key";
        }
        
        private void ConfigurarDataGridView()
        {
            DgvTablaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTablaClientes.ReadOnly = true; 
        }
        private int idCondicion;

        private void BtnAgregarMeClientes_Click(object sender, EventArgs e)
        {
            if (idCondicion == 0)
            {
                MessageBox.Show("Seleccione una condicion válida.");
                return;
            }



            Validarcliente.AgregarUnCliente(TxtNombreCliente.Text.Trim(), TxtapellidoCliente.Text.Trim(), TxtRazonSocialCliente.Text.Trim(), Convert.ToInt32(TxtCuilCliente.Text.Trim()), TxtLocalidadCliente.Text.Trim(), TxtCalleCliente.Text.Trim(), Convert.ToInt32(TxtTelefonoCliente.Text.Trim()), CMBIVA.SelectedItem.ToString(), Convert.ToInt32(TxtNumCasaCliente.Text.Trim()));
            MessageBox.Show("Se registro correctamente");
            LimpiarTextBox();
            CargarClientes();
           
             


        }

        private void CMBIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBIVA.SelectedItem is KeyValuePair<int, string> Condicionseleccionada)
            {
                idCondicion = Condicionseleccionada.Key;
            }
        }

        private void chbeditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbeditar.Checked)
            {
                DgvTablaClientes.ReadOnly = false;
                MessageBox.Show("Edición habilitada. Puedes editar la grid.", "Información");
            }
            else
            {
                DgvTablaClientes.ReadOnly = true;
                MessageBox.Show("Edición deshabilitada. La grid está bloqueada.", "Información");
            }
        }
        private void DgvTablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = DgvTablaClientes.Rows[e.RowIndex];
            int idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
            TxtNombreCliente.Text = filaSeleccionada.Cells["NomCL"].Value.ToString().Trim();
            TxtapellidoCliente.Text = filaSeleccionada.Cells["ApeCL"].Value.ToString().Trim();
            TxtRazonSocialCliente.Text = filaSeleccionada.Cells["RazSocialCL"].Value.ToString().Trim();
            TxtCuilCliente.Text = filaSeleccionada.Cells["claveIdenCL"].Value.ToString().Trim();
            TxtLocalidadCliente.Text = filaSeleccionada.Cells["localidadCL"].Value.ToString().Trim();
            TxtCalleCliente.Text = filaSeleccionada.Cells["calleCL"].Value.ToString().Trim();
            TxtTelefonoCliente.Text = filaSeleccionada.Cells["telefonoCL"].Value.ToString().Trim();
            /*ACA IRIA EL COMBO BOX IVA */
            TxtNumCasaCliente.Text = filaSeleccionada.Cells["numeracionCL"].Value.ToString().Trim();

            if (DgvTablaClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionadaUPD = DgvTablaClientes.Rows[e.RowIndex];
                    int idClienteUPD = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);

                    string NombreClienteUPD = filaSeleccionada.Cells["NomCL"].Value.ToString().Trim();
                    string ApellidoClienteUPD = filaSeleccionada.Cells["ApeCL"].Value.ToString().Trim();
                    string RazonSocialClienteUpd = filaSeleccionada.Cells["RazSocialCL"].Value.ToString().Trim();
                    string CuilClienteUPD = filaSeleccionada.Cells["claveIdenCL"].Value.ToString().Trim();
                    string LocalidadClienteUPD = filaSeleccionada.Cells["localidadCL"].Value.ToString().Trim();
                    string CalleClienteUPD = filaSeleccionada.Cells["calleCL"].Value.ToString().Trim();
                    string TelefonoClienteUPD = filaSeleccionada.Cells["telefonoCL"].Value.ToString().Trim();
                    /* ACA IRIA EL COMBO BOX DE IVA*/
                    string NumeroCasaClienteUPD = filaSeleccionada.Cells["numeracionCL"].Value.ToString().Trim();
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que querer continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {

                        /*ValidarClientes.ModificacionVehiculo();*/
                        Console.WriteLine("Cambio realizado.");
                        LimpiarTextBox();
                        CargarClientes();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarClientes();
                    }
                }
            }
            
        }
        private void LimpiarTextBox()
        {
            TxtNombreCliente.Text = string.Empty;
            TxtapellidoCliente.Text = string.Empty;
            TxtRazonSocialCliente.Text = string.Empty;
            TxtCuilCliente.Text = string.Empty;
            TxtLocalidadCliente.Text = string.Empty;
            TxtCalleCliente.Text = string.Empty;
            TxtTelefonoCliente.Text = string.Empty;
            CMBIVA.Text = string.Empty;
            TxtNumCasaCliente.Text = string.Empty;
        }
    }
}
