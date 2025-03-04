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
using static Negocio.Empleados;

namespace Vista
{
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
            
            CargarCategorias();
           
            CargarEmpleados();
            DgvMenuEmpleado.ReadOnly = true;
            DgvMenuEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvMenuEmpleado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            chbEditar.CheckedChanged += chbEditar_CheckedChanged;
            //DgvMenuEmpleado.CellClick += DgvMenuEmpleado_CellContentClick;

        }
        private void CargarEmpleados()
        {
            DgvMenuEmpleado.DataSource = null;
            DgvMenuEmpleado.DataSource = Validaciones.TraeEmpleados();
            DgvMenuEmpleado.Columns["idCategoria"].Visible = false;
            DgvMenuEmpleado.Columns["idTrabajador"].Visible = false;
            ConfigurarDataGridView();
            DgvMenuEmpleado.AllowUserToAddRows = false;
            DgvMenuEmpleado.RowHeadersVisible = false;
            ConfiguraDataGrid(DgvMenuEmpleado);

        }
        private void ConfiguraDataGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;

            // General
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Cabecera
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185); 
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); 
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

          

            // Otros ajustes
            dgv.RowHeadersVisible = false; 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ScrollBars = ScrollBars.Both; 

            
        }
        private void AplicarTrimDataGridView(DataGridView dgv)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value is string texto)
                    {
                        celda.Value = texto.Trim();
                    }
                }
            }
        }

        private void BtnAgregarMeEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbCategoriaEmple.SelectedValue == null)
                {
                    throw new Exception("Debe seleccionar una categoría.");
                }

                // Obtener el ID de la categoría seleccionada
                int idCategoriaSeleccionada = Convert.ToInt32(CmbCategoriaEmple.SelectedValue);

                if (!int.TryParse(TxtDniEmpleado.Text.Trim(), out int dniEmpleado))
                {
                    throw new Exception("El DNI debe ser un número válido.");
                }

                if (!int.TryParse(TxtCelularEmpleado.Text.Trim(), out int celularEmpleado))
                {
                    throw new Exception("El número de celular debe ser un número válido.");
                }

                MessageBox.Show(TxtNombreEmpleado.Text.Trim() + " " + TxtApellidoEmpleado.Text.Trim() + " " + dniEmpleado.ToString() + " " + txtContraseña.Text.Trim() + " " + celularEmpleado.ToString()+" " +idCategoriaSeleccionada.ToString());
                // Llamar al método para agregar el empleado
                Validaciones.AgregarUnEmpleado(TxtNombreEmpleado.Text.Trim(), TxtApellidoEmpleado.Text.Trim(), dniEmpleado, txtContraseña.Text.Trim(), celularEmpleado, idCategoriaSeleccionada );

                MessageBox.Show("El empleado ha sido cargado con éxito");
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private int idCategoria;
        private void CmbCategoriaEmple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCategoriaEmple.SelectedItem is KeyValuePair<int, string> categoriaSelect)
            {
                idCategoria = categoriaSelect.Key;


            }
        }
        
        private void chbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEditar.Checked)
            {
                DgvMenuEmpleado.ReadOnly = false;
                
            }
            else
            {
                DgvMenuEmpleado.ReadOnly = true;
                
            }
        }
        private void LimpiaTextBox()
        {
            TxtNombreEmpleado.Text = string.Empty;
            TxtApellidoEmpleado.Text = string.Empty;
            TxtDniEmpleado.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            TxtCelularEmpleado.Text = string.Empty;
            CmbCategoriaEmple.Text = string.Empty;
            TxtNombreEmpleado.Enabled = true;
            TxtApellidoEmpleado.Enabled = true;
            TxtDniEmpleado.Enabled = true;
            txtContraseña.Enabled = true;
            TxtCelularEmpleado.Enabled = true;
            CmbCategoriaEmple.Enabled = true;
        }

        private void btnBorraCampos_Click(object sender, EventArgs e)
        {
            LimpiaTextBox();
        }
        private void CargarCategorias()
        {
            try
            {
                List<CategoriaEmpleado> listaCategorias = Validaciones.ObtenerCategorias();

                if (listaCategorias.Count > 0)
                {
                    
                    CmbCategoriaEmple.DataSource = listaCategorias;
                    CmbCategoriaEmple.DisplayMember = "NombreCat"; 
                    CmbCategoriaEmple.ValueMember = "idCategoria"; 
                }
                else
                {
                    MessageBox.Show("No se encontraron categorías disponibles.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}");
            }
        }
        
        private void ConfigurarDataGridView()
        {
            // Verificar si la columna de categorías ya existe
            if (!DgvMenuEmpleado.Columns.Contains("CategoriaColumn"))
            {
                var comboBoxColumn = new DataGridViewComboBoxColumn
                {
                    Name = "CategoriaColumn",
                    HeaderText = "Categoría",
                    DataPropertyName = "NombreCat", // Vincula la propiedad
                    DisplayMember = "Value",
                    ValueMember = "Key",
                    //DataSource = new BindingSource(Validaciones.ObtenerCategoriasEmpleados(), null)
                };


                Dictionary<int, string> categorias = Validaciones.ObtenerCategoriasEmpleados();
                foreach (var categoria in categorias)
                {
                    comboBoxColumn.Items.Add(new KeyValuePair<int, string>(categoria.Key, categoria.Value));
                }


                DgvMenuEmpleado.Columns.Add(comboBoxColumn);
            }
        }

        private void DgvMenuEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = DgvMenuEmpleado.Rows[e.RowIndex];
            int idTrabajador = Convert.ToInt32(filaSeleccionada.Cells["idTrabajador"].Value);
            int idCategoria = Convert.ToInt32(filaSeleccionada.Cells["idCategoria"].Value);
            TxtNombreEmpleado.Text = filaSeleccionada.Cells["NomTR"].Value.ToString();
            TxtApellidoEmpleado.Text = filaSeleccionada.Cells["ApeTR"].Value.ToString();
            TxtDniEmpleado.Text = filaSeleccionada.Cells["documentoTR"].Value.ToString();
            txtContraseña.Text = filaSeleccionada.Cells["contraseñaTR"].Value.ToString();
            TxtCelularEmpleado.Text = filaSeleccionada.Cells["telefonoTR"].Value.ToString();
            CmbCategoriaEmple.Text = Validaciones.ObtCat(idCategoria);
            TxtNombreEmpleado.Enabled = false;
            TxtApellidoEmpleado.Enabled = false;
            TxtDniEmpleado.Enabled = false;
            txtContraseña.Enabled = false;
            TxtCelularEmpleado.Enabled = false;
            CmbCategoriaEmple.Enabled = false;
            if (DgvMenuEmpleado.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {

                    int idTrabajadorUPD = Convert.ToInt32(filaSeleccionada.Cells["idTrabajador"].Value);
                    int idCategoriaUPD = Convert.ToInt32(filaSeleccionada.Cells["CategoriaColumn"].Value);
                    string NombreUPD = filaSeleccionada.Cells["NomTR"].Value.ToString();
                    string ApellidoUPD = filaSeleccionada.Cells["ApeTR"].Value.ToString();
                    string DNIUPD = filaSeleccionada.Cells["documentoTR"].Value.ToString();
                    string ContraseñaUPD = filaSeleccionada.Cells["contraseñaTR"].Value.ToString();
                    string CelularUPD = filaSeleccionada.Cells["telefonoTR"].Value.ToString();

                    int categoriaAEnviar = idCategoriaUPD == 0 ? idCategoria : idCategoriaUPD;

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



                    if (resultado == DialogResult.Yes)
                    {

                        Validaciones.ModificacionEmpleado(idTrabajadorUPD, categoriaAEnviar, NombreUPD.Trim(), ApellidoUPD.Trim(), Convert.ToInt32(DNIUPD.Trim()), ContraseñaUPD.Trim(), Convert.ToInt32(CelularUPD.Trim()));
                        Console.WriteLine("Cambio realizado.");
                        LimpiaTextBox();
                        CargarEmpleados();
                        ConfigurarDataGridView();

                        //DgvMenuEmpleado.Columns["idCategoria"].Visible = false;
                        //DgvMenuEmpleado.Columns["idTrabajador"].Visible = false;
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarEmpleados();
                        ConfigurarDataGridView();

                        //DgvMenuEmpleado.Columns["idCategoria"].Visible = false;
                        //DgvMenuEmpleado.Columns["idTrabajador"].Visible = false;
                    }
                }
            }
            else if (DgvMenuEmpleado.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.RowIndex >= 0)
                {
                    int idTrabajadorUPD = Convert.ToInt32(filaSeleccionada.Cells["idTrabajador"].Value);
                    string Estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();



                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (resultado == DialogResult.Yes)
                    {

                        if (Estado == "ACT")
                        {
                            Validaciones.BajaAltaEmpleado(idTrabajadorUPD, "DES");
                            MessageBox.Show("Empleado DADO DE BAJA.");
                            CargarEmpleados();
                            ConfigurarDataGridView();

                            //DgvMenuEmpleado.Columns["idCategoria"].Visible = false;
                            //DgvMenuEmpleado.Columns["idTrabajador"].Visible = false;
                        }
                        else if (Estado == "DES")
                        {
                            Validaciones.BajaAltaEmpleado(idTrabajadorUPD, "ACT");
                            MessageBox.Show("Empleado DADO DE ALTA");
                            CargarEmpleados();
                            ConfigurarDataGridView();

                            //DgvMenuEmpleado.Columns["idCategoria"].Visible = false;
                            //DgvMenuEmpleado.Columns["idTrabajador"].Visible = false;
                        }
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarEmpleados();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
