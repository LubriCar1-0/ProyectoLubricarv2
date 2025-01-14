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
            Llenarcombobox();
        }
       
        private void CargarClientes() 
        {
            DataTable tablaClientes = Personas.ObtenerClientes();
            DgvTablaClientes.DataSource = null;
            DgvTablaClientes.DataSource = tablaClientes;

        }
        private void Llenarcombobox()
        {
            DataTable dt = Cliente.CondicionesIva();
            CMBIVA.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                CMBIVA.Items.Add(new ComboBoxItem
                {
                    Value = row["idCondicionIva"],
                    Text = row["descripcion"].ToString()
                });
            }


        }
        private void ConfigurarDataGridView()
        {
            DgvTablaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTablaClientes.ReadOnly = true; 
        }

        private void BtnAgregarMeClientes_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(TxtNumCasaCliente.Text.Trim(), out int NumeracioncasaCliente))
            {
                throw new Exception("La numeracion de la casa debe ser valida");
            }

            if (!int.TryParse(TxtTelefonoCliente.Text.Trim(), out int TelefonoCliente))
            {
                throw new Exception("El número de celular debe ser un número válido.");
            }
            if (!int.TryParse(TxtCuilCliente.Text.Trim(), out int CuilCliente))
            {
                throw new Exception("El número de identificacion debe ser un número válido.");
            }

            Validar.AgregarUnCliente(TxtNombreCliente.Text.Trim(), TxtapellidoCliente.Text.Trim(), TxtRazonSocialCliente.Text.Trim(), CuilCliente, TxtLocalidadCliente.Text.Trim(), TxtCalleCliente.Text.Trim(), NumeracioncasaCliente, CMBIVA.SelectedItem.ToString(), TelefonoCliente);
            MessageBox.Show("Se registro correctamente");

            CargarClientes();
           
             


        }
        public class ComboBoxItem
        {
            public object Value { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
