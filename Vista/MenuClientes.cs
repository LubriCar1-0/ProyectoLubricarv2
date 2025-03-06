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
            grpListado.Visible = false;
            CargarCategorias();
            DgvTablaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTablaClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvTablaClientes.CellClick += DgvTablaClientes_CellClick;
            //TxtCuilCliente.Tag = 11;
            //TxtTelefonoCliente.Tag = 10;
            //TxtNumCasaCliente.Tag = 4;
            CMBIVA.SelectedIndex = -1;
            CMBIVA.DropDownStyle = ComboBoxStyle.DropDownList;
        }
       
        private void CargarClientes() 
        {

            DgvTablaClientes.DataSource = null;
            DgvTablaClientes.DataSource = Validarcliente.ObtenerClientes();
            DgvTablaClientes.AllowUserToAddRows = false;
            DgvTablaClientes.RowHeadersVisible = false;
            ConfigurarDataGridView();
            ConfiguraDataGrid(DgvTablaClientes);
            if (DgvTablaClientes.Columns.Contains("idCliente"))
            {
                DgvTablaClientes.Columns["idCliente"].Visible = false;
            }
            if (DgvTablaClientes.Columns.Contains("IdCondicionIva"))
            {
                DgvTablaClientes.Columns["IdCondicionIva"].Visible = false;
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
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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

           
            dgv.RowHeadersVisible = false; 
            


        }
        private void CargarCategorias()
        {
            Dictionary<int, string> condiciones = Validarcliente.ObtenerCondicionesiva();
            foreach (var condicion in condiciones)
            {
                CMBIVA.Items.Add(new KeyValuePair<int, string>(condicion.Key, condicion.Value));
            }
            CMBIVA.DisplayMember = "Value";
            CMBIVA.ValueMember = "Key";
        }
        
        private void ConfigurarDataGridView()
        {
            DgvTablaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTablaClientes.ReadOnly = true;

            if (!DgvTablaClientes.Columns.Contains("CondicionIva"))
            {
                var comboBoxColumn = new DataGridViewComboBoxColumn
                {
                    Name = "CondicionIva",
                    HeaderText = "CondicionIva",
                    DataPropertyName = "IdCondicionIva",
                    //DataPropertyName = "descripcion", 

                    DisplayMember = "Value",
                    ValueMember = "Key",
                    
                };

               
                Dictionary<int, string> condiciones = Validarcliente.ObtenerCondicionesiva();
                foreach (var condicion in condiciones)
                {
                    comboBoxColumn.Items.Add(new KeyValuePair<int, string>(condicion.Key, condicion.Value));
                }

                
                DgvTablaClientes.Columns.Add(comboBoxColumn);

                comboBoxColumn.DisplayIndex = 3; 

            }

        }
        private int idCondicion;

        private void BtnAgregarMeClientes_Click(object sender, EventArgs e)
        {
            if (idCondicion == 0 || TxtNombreCliente.Text == string.Empty || TxtapellidoCliente.Text == string.Empty  || TxtCuilCliente.Text == string.Empty || TxtLocalidadCliente.Text == string.Empty || TxtCalleCliente.Text == string.Empty || TxtNumCasaCliente.Text == string.Empty || TxtTelefonoCliente.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar datos en los campos.");
                
            }
            else
            {
                Validarcliente.AgregarUnCliente(TxtNombreCliente.Text.ToUpper().Trim(), TxtapellidoCliente.Text.ToUpper().Trim(), TxtRazonSocialCliente.Text.Trim(), TxtCuilCliente.Text.Trim(), TxtLocalidadCliente.Text.Trim(), TxtCalleCliente.Text.Trim(), Convert.ToInt32(TxtNumCasaCliente.Text.Trim()), Convert.ToInt32(TxtTelefonoCliente.Text.Trim()), idCondicion);
                MessageBox.Show("Se registro correctamente");
                LimpiarTextBox();
                CargarClientes();
            }           
        }

        private void CMBIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBIVA.SelectedItem is KeyValuePair<int, string> condicionSeleccionada)
            {
                idCondicion = condicionSeleccionada.Key;
            }
        }

        private void chbeditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbeditar.Checked)
            {
                DgvTablaClientes.ReadOnly = false;
            }
            else
            {
                DgvTablaClientes.ReadOnly = true;
            }
        }
        
        
        private void DgvTablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            DataGridViewRow filaSeleccionada = DgvTablaClientes.Rows[e.RowIndex];
            int idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
            TxtNombreCliente.Text = filaSeleccionada.Cells["Nombre"].Value.ToString().Trim();
            TxtapellidoCliente.Text = filaSeleccionada.Cells["Apellido"].Value.ToString().Trim();
            TxtRazonSocialCliente.Text = filaSeleccionada.Cells["Razon Social"].Value.ToString().Trim();
            TxtCuilCliente.Text = filaSeleccionada.Cells["Cuit/Cuil"].Value.ToString().Trim();
            TxtLocalidadCliente.Text = filaSeleccionada.Cells["Localidad"].Value.ToString().Trim();
            TxtCalleCliente.Text = filaSeleccionada.Cells["Calle"].Value.ToString().Trim();
            TxtTelefonoCliente.Text = filaSeleccionada.Cells["Telefono"].Value.ToString().Trim();
            int idcondicion = Convert.ToInt32(filaSeleccionada.Cells["IdCondicionIva"].Value);
            TxtNumCasaCliente.Text = filaSeleccionada.Cells["Numero de vivienda"].Value.ToString().Trim();
            CMBIVA.SelectedIndex = idcondicion;
            if (DgvTablaClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0 && e.RowIndex < DgvTablaClientes.Rows.Count)
                {
                    DataGridViewRow filaSeleccionadaUPD = DgvTablaClientes.Rows[e.RowIndex];
                    int idClienteUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["idCliente"].Value);
                    string NombreClienteUPD = filaSeleccionadaUPD.Cells["Nombre"].Value.ToString().TrimEnd();
                    string ApellidoClienteUPD = filaSeleccionadaUPD.Cells["Apellido"].Value.ToString().TrimEnd();
                    string RazonSocialClienteUpd = filaSeleccionadaUPD.Cells["Razon Social"].Value.ToString().TrimEnd();
                    string CuilClienteUPD = filaSeleccionadaUPD.Cells["Cuit/Cuil"].Value.ToString().Trim();
                    string LocalidadClienteUPD = filaSeleccionadaUPD.Cells["Localidad"].Value.ToString().Trim();
                    string CalleClienteUPD = filaSeleccionadaUPD.Cells["Calle"].Value.ToString().Trim();
                    string TelefonoClienteUPD = filaSeleccionadaUPD.Cells["Telefono"].Value.ToString().Trim();
                    int idcondicionUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["CondicionIva"].Value);
                    string NumeroCasaClienteUPD = filaSeleccionadaUPD.Cells["Numero de vivienda"].Value.ToString().Trim();

                    

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que querer continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {

                        Validarcliente.Modificacioncliente(idClienteUPD, NombreClienteUPD.ToUpper().TrimEnd(), ApellidoClienteUPD.ToUpper().Trim(), RazonSocialClienteUpd.Trim(), CuilClienteUPD.Trim(), LocalidadClienteUPD, CalleClienteUPD, Convert.ToInt32(NumeroCasaClienteUPD.Trim()), Convert.ToInt32(TelefonoClienteUPD.Trim()), idcondicionUPD);
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
            else if (DgvTablaClientes.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.RowIndex >= 0 && e.RowIndex < DgvTablaClientes.Rows.Count)
                {
                    int idClienteUPD = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                    string Estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                        if (Estado == "ACT")
                        {
                            Validarcliente.BajaAltaCliente(idClienteUPD, "DES");
                            MessageBox.Show("Cliente DADO DE BAJA.");
                            CargarClientes();
                            
                            LimpiarTextBox();

                            DgvTablaClientes.Columns["idCliente"].Visible = false;
                        }
                        else if (Estado == "DES")
                        {
                            Validarcliente.BajaAltaCliente(idClienteUPD, "ACT");
                            MessageBox.Show("Cliente DADO DE ALTA");
                            CargarClientes();
                            
                            LimpiarTextBox();


                            DgvTablaClientes.Columns["idCliente"].Visible = false;
                        }
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarClientes(); ;
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
      

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void DgvTablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            grpListado.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpListado.Visible=false;
        }

        private void MenuClientes_Load(object sender, EventArgs e)
        {

        }

        private void grpListado_Enter(object sender, EventArgs e)
        {

        }

        private void TxtCuilCliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            TextBox txt = sender as TextBox;
            if (txt != null && txt.Tag != null)
            {
                int maxLength;
                if (int.TryParse(txt.Tag.ToString(), out maxLength))
                {
                    if (txt.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
            TxtCuilCliente.Tag = 11;
        }

        private void TxtNumCasaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            TextBox txt = sender as TextBox;
            if (txt != null && txt.Tag != null)
            {
                int maxLength;
                if (int.TryParse(txt.Tag.ToString(), out maxLength))
                {
                    if (txt.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
            TxtNumCasaCliente.Tag = 5;
        }

        private void TxtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            TextBox txt = sender as TextBox;
            if (txt != null && txt.Tag != null)
            {
                int maxLength;
                if (int.TryParse(txt.Tag.ToString(), out maxLength))
                {
                    if (txt.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
            TxtTelefonoCliente.Tag = 10;
        }

        private void TxtapellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
