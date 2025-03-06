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
            DgvTablaMeVehiculos.ReadOnly = true;
            //DgvTablaMeVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //DgvTablaMeVehiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            chbEditar.CheckedChanged += chbEditar_CheckedChanged;
            DgvTablaMeVehiculos.CellClick += DgvTablaMeVehiculos_CellClick;
            CbxClienteMeVehiculos.SelectedIndexChanged += CbxClienteMeVehiculos_SelectedIndexChanged;

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
            try
            {
                DgvTablaMeVehiculos.DataSource = null;
                DgvTablaMeVehiculos.DataSource = ValidarClientes.BuscarVehiculos();
                DgvTablaMeVehiculos.AllowUserToAddRows = false;
                DgvTablaMeVehiculos.RowHeadersVisible = false;
                ConfiguraDataGrid(DgvTablaMeVehiculos);
                if (DgvTablaMeVehiculos.Columns.Contains("idVehiculo"))
                {
                    DgvTablaMeVehiculos.Columns["idVehiculo"].Visible = false;
                }
                if (DgvTablaMeVehiculos.Columns.Contains("idCliente"))
                {
                    DgvTablaMeVehiculos.Columns["idCliente"].Visible = false;
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los vehículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfiguraDataGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;

            
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185); 
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

           
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); 
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

           
            //dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 250);

           
            dgv.RowHeadersVisible = false; 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ScrollBars = ScrollBars.Both; 

            
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

                ValidarClientes.AgregarUnVehiculo(idCliente, TxtModeloVehiculos.Text.Trim(), TxtMarcaVehiculos.Text.Trim(), Convert.ToInt32(TxtAñoVehiculos.Text.Trim()), TxtPatenteVehiculo.Text.Trim().ToUpper(), Convert.ToInt32(TxtKilometrajeVehiculos.Text.Trim()));
                LimpiaTextBox();
                CargarDatosEnGrid();
                



                MessageBox.Show("El vehiculo ha sido cargado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }

        private void CbxClienteMeVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxClienteMeVehiculos.SelectedItem is KeyValuePair<int, string> cliente)
            {
                idCliente = cliente.Key;
                
            }
        }




        private void MenuVehiculos_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultaMeVehiculos_Click(object sender, EventArgs e)
        {

        }

        
        private void DgvTablaMeVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = DgvTablaMeVehiculos.Rows[e.RowIndex];
            int idVehiculo = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
            int idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
            CbxClienteMeVehiculos.Text = ValidarClientes.ObtNomCliente(idCliente);
            TxtModeloVehiculos.Text = filaSeleccionada.Cells["modeloVH"].Value.ToString();
            TxtMarcaVehiculos.Text = filaSeleccionada.Cells["marcaVH"].Value.ToString();
            TxtAñoVehiculos.Text = filaSeleccionada.Cells["añoVH"].Value.ToString();
            TxtPatenteVehiculo.Text = filaSeleccionada.Cells["patenteVH"].Value.ToString();
            TxtKilometrajeVehiculos.Text = filaSeleccionada.Cells["kilometrajeVH"].Value.ToString();

            if (DgvTablaMeVehiculos.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionadaUPD = DgvTablaMeVehiculos.Rows[e.RowIndex];

                    int idVehiculoUPD = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
                    int idClienteUPD = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);

                    string ModeloUPD = filaSeleccionada.Cells["modeloVH"].Value.ToString().Trim();
                    string MarcaUPD = filaSeleccionada.Cells["marcaVH"].Value.ToString().Trim();
                    string AñoUPD = filaSeleccionada.Cells["añoVH"].Value.ToString().Trim();
                    string PatenteUPD = filaSeleccionada.Cells["patenteVH"].Value.ToString().Trim();
                    string KilometrajeUPD = filaSeleccionada.Cells["kilometrajeVH"].Value.ToString().Trim();
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



                    if (resultado == DialogResult.Yes)
                    {

                        ValidarClientes.ModificacionVehiculo(idVehiculo, idCliente, ModeloUPD.Trim(), MarcaUPD.Trim(), Convert.ToInt32(AñoUPD.Trim()), PatenteUPD.Trim(), Convert.ToInt32(KilometrajeUPD.Trim()));
                        Console.WriteLine("Cambio realizado.");
                        LimpiaTextBox();
                        CargarDatosEnGrid();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarDatosEnGrid();
                    }
                }
            }
            else if (DgvTablaMeVehiculos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.RowIndex >= 0)
                {
                    int idVehiculoUPD = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
                    int idClienteUPD = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                    string Estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();
                    TxtModeloVehiculos.Enabled = false;
                    TxtMarcaVehiculos.Enabled = false;
                    TxtAñoVehiculos.Enabled = false;
                    TxtPatenteVehiculo.Enabled = false;
                    TxtKilometrajeVehiculos.Enabled = false;
                    CbxClienteMeVehiculos.Enabled = false;
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                        if (Estado == "ACT")
                        {
                            ValidarClientes.BajaAltaVehiculo(idVehiculoUPD, "DES");
                            MessageBox.Show("Vehiculo DADO DE BAJA.");
                            CargarDatosEnGrid();
                            //ConfigurarDataGridView();

                            DgvTablaMeVehiculos.Columns["idVehiculo"].Visible = false;
                            DgvTablaMeVehiculos.Columns["idCliente"].Visible = false;
                        }
                        else if (Estado == "DES")
                        {
                            ValidarClientes.BajaAltaVehiculo(idVehiculoUPD, "ACT");
                            MessageBox.Show("Empleado DADO DE ALTA");
                            CargarDatosEnGrid();
                            //ConfigurarDataGridView();

                            DgvTablaMeVehiculos.Columns["idVehiculo"].Visible = false;
                            DgvTablaMeVehiculos.Columns["idCliente"].Visible = false;
                        }
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarDatosEnGrid(); ;
                    }
                    
                }
            }




        }

        private void LimpiaTextBox()
        {
            CbxClienteMeVehiculos.Text = string.Empty;
            TxtMarcaVehiculos.Text = string.Empty;
            TxtModeloVehiculos.Text = string.Empty;
            TxtAñoVehiculos.Text = string.Empty;
            TxtPatenteVehiculo.Text = string.Empty;
            CbxClienteMeVehiculos.SelectedIndex = -1;
            idCliente = 0;
            TxtKilometrajeVehiculos.Text = string.Empty;

            TxtModeloVehiculos.Enabled = true;
            TxtMarcaVehiculos.Enabled = true;
            TxtAñoVehiculos.Enabled = true;
            TxtPatenteVehiculo.Enabled = true;
            TxtKilometrajeVehiculos.Enabled = true;
            CbxClienteMeVehiculos.Enabled = true;

        }

        private void btnBorraCampos_Click(object sender, EventArgs e)
        {
            LimpiaTextBox();
        }

        private void DgvTablaMeVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuVehiculos_Load_1(object sender, EventArgs e)
        {
            
        }

        private void chbEditar_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtAñoVehiculos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TxtKilometrajeVehiculos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
