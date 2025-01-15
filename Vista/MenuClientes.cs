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
           
        }
       
        private void CargarClientes() 
        {
            //DataTable tablaClientes = Clientes.AgregarCondicionIva();
            //DgvTablaClientes.DataSource = null;
            //DgvTablaClientes.DataSource = tablaClientes;

        }
        private void CargarCategorias()
        {
            Dictionary<int, string> categorias = ValidadCategoriasProducto.ObtenerCategoriasProductos();
            foreach (var cat in categorias)
            {
                CMBIVA.Items.Add(new KeyValuePair<int, string>(cat.Key, cat.Value));
            }
            CMBIVA.DisplayMember = "Value";
            CMBIVA.ValueMember = "Key";
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



            Validarcliente.AgregarUnCliente(TxtNombreCliente.Text.Trim(), TxtapellidoCliente.Text.Trim(), TxtRazonSocialCliente.Text.Trim(), CuilCliente, TxtLocalidadCliente.Text.Trim(), TxtCalleCliente.Text.Trim(), NumeracioncasaCliente, CMBIVA.SelectedItem.ToString(), TelefonoCliente);
            MessageBox.Show("Se registro correctamente");

            CargarClientes();
           
             


        }

        
    }
}
