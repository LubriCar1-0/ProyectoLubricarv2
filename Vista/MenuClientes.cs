﻿using Negocio;
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
            DgvTablaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTablaClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvTablaClientes.CellClick += DgvTablaClientes_CellClick;

        }
       
        private void CargarClientes() 
        {

            DgvTablaClientes.DataSource = null;
            DgvTablaClientes.DataSource = Validarcliente.ObtenerClientes();
            if (DgvTablaClientes.Columns.Contains("idCliente"))
            {
                DgvTablaClientes.Columns["idCliente"].Visible = false;
            }
            if (DgvTablaClientes.Columns.Contains("IdCondicionIva"))
            {
                DgvTablaClientes.Columns["IdCondicionIva"].Visible = false;
            }
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

                    DataPropertyName = "descripcion", 

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
            if (idCondicion == 0)
            {
                MessageBox.Show("Seleccione una condicion válida.");
                return;
            }



            Validarcliente.AgregarUnCliente(TxtNombreCliente.Text.ToUpper().Trim(), TxtapellidoCliente.Text.ToUpper().Trim(), TxtRazonSocialCliente.Text.Trim(), Convert.ToInt32(TxtCuilCliente.Text.Trim()), TxtLocalidadCliente.Text.Trim(), TxtCalleCliente.Text.Trim(), Convert.ToInt32(TxtNumCasaCliente.Text.Trim()), Convert.ToInt32(TxtTelefonoCliente.Text.Trim()),   idCondicion);
            MessageBox.Show("Se registro correctamente");
            LimpiarTextBox();
            CargarClientes();
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

            if (DgvTablaClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionadaUPD = DgvTablaClientes.Rows[e.RowIndex];
                    int idClienteUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["idCliente"].Value);
                    string NombreClienteUPD = filaSeleccionadaUPD.Cells["Nombre"].Value.ToString().Trim();
                    string ApellidoClienteUPD = filaSeleccionadaUPD.Cells["Apellido"].Value.ToString().Trim();
                    string RazonSocialClienteUpd = filaSeleccionadaUPD.Cells["Razon Social"].Value.ToString().Trim();
                    string CuilClienteUPD = filaSeleccionadaUPD.Cells["Cuit/Cuil"].Value.ToString().Trim();
                    string LocalidadClienteUPD = filaSeleccionadaUPD.Cells["Localidad"].Value.ToString().Trim();
                    string CalleClienteUPD = filaSeleccionadaUPD.Cells["Calle"].Value.ToString().Trim();
                    string TelefonoClienteUPD = filaSeleccionadaUPD.Cells["Telefono"].Value.ToString().Trim();
                    int idcondicionUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["CondicionIva"].Value);
                    string NumeroCasaClienteUPD = filaSeleccionadaUPD.Cells["Numero de vivienda"].Value.ToString().Trim();

                    int Condicionaenviar = idcondicionUPD == 0 ? idcondicion : idcondicionUPD;

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que querer continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {

                        Validarcliente.Modificacioncliente(idClienteUPD, NombreClienteUPD.ToUpper().Trim(), ApellidoClienteUPD.ToUpper().Trim(), RazonSocialClienteUpd.Trim(), Convert.ToInt32(CuilClienteUPD.Trim()), LocalidadClienteUPD, CalleClienteUPD, Convert.ToInt32(NumeroCasaClienteUPD.Trim()), Convert.ToInt32(TelefonoClienteUPD.Trim()), Condicionaenviar);
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
                if (e.RowIndex >= 0)
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
       /* private void Acomodartabla()
        {
            DgvTablaClientes.RowHeadersVisible = false;
            DgvTablaClientes.Columns["Editar"].DisplayIndex = 0;
            DgvTablaClientes.Columns["Estado"].DisplayIndex = 1;
            DgvTablaClientes.Columns["Nombre"].DisplayIndex = 2;
            DgvTablaClientes.Columns["Apellido"].DisplayIndex = 3;
            DgvTablaClientes.Columns["Razon Social"].DisplayIndex = 4;
            DgvTablaClientes.Columns["Cuit/Cuil"].DisplayIndex = 5;
            DgvTablaClientes.Columns["Localidad"].DisplayIndex = 6;
            DgvTablaClientes.Columns["Calle"].DisplayIndex = 7;
            DgvTablaClientes.Columns["Numero de vivienda"].DisplayIndex = 8;
            DgvTablaClientes.Columns["Telefono"].DisplayIndex = 9;
            DgvTablaClientes.Columns["Estado"].DisplayIndex = 10;
            DgvTablaClientes.Columns["LubriPuntos"].DisplayIndex = 11;
            DgvTablaClientes.Columns["CondicionIva"].DisplayIndex = 12;
           


        }
       */
        private void TxtCuilCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquea el caracter
            }
        }

        private void TxtNumCasaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }
        private void TxtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();    
        }

        
    }
}
