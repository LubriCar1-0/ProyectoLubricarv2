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
            ConfigurarDataGridView();
            CargarCategorias();
            CargarEmpleados();
            DgvMenuEmpleado.ReadOnly = true;
            DgvMenuEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvMenuEmpleado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            chbEditar.CheckedChanged += chbEditar_CheckedChanged;
            DgvMenuEmpleado.CellClick += DgvMenuEmpleado_CellClick;

        }
        private void CargarEmpleados()
        {
            DgvMenuEmpleado.DataSource = null;
            DgvMenuEmpleado.DataSource = Validaciones.TraeEmpleados();
            DgvMenuEmpleado.Columns["idCategoria"].Visible = false;
            DgvMenuEmpleado.Columns["idTrabajador"].Visible = false;


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

                // Llamar al método para agregar el empleado
                Validaciones.AgregarUnEmpleado(
                    TxtNombreEmpleado.Text.Trim(), TxtApellidoEmpleado.Text.Trim(), dniEmpleado, txtContraseña.Text.Trim(), celularEmpleado, categoria: idCategoriaSeleccionada
                );

                MessageBox.Show("El empleado ha sido cargado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CmbCategoriaEmple_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = CmbCategoriaEmple.SelectedItem.ToString();
            var categorias = Validaciones.ObtenerCategoriasProcesadas();

            if (categorias.ContainsKey(categoriaSeleccionada))
            {
                int permisoCat = categorias[categoriaSeleccionada];


            }
        }
        private void DgvMenuEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
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
            if (DgvMenuEmpleado.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {

                    int idTrabajadorUPD = Convert.ToInt32(filaSeleccionada.Cells["idTrabajador"].Value);
                    int idCategoriaUPD = Convert.ToInt32(filaSeleccionada.Cells["idCategoria"].Value);
                    string NombreUPD = filaSeleccionada.Cells["NomTR"].Value.ToString();
                    string ApellidoUPD = filaSeleccionada.Cells["ApeTR"].Value.ToString();
                    string DNIUPD = filaSeleccionada.Cells["documentoTR"].Value.ToString();
                    string ContraseñaUPD = filaSeleccionada.Cells["contraseñaTR"].Value.ToString();
                    string CelularUPD = filaSeleccionada.Cells["telefonoTR"].Value.ToString();
                    CmbCategoriaEmple.Text = Validaciones.ObtCat(idCategoriaUPD);

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



                    if (resultado == DialogResult.Yes)
                    {

                        Validaciones.ModificacionEmpleado(idTrabajadorUPD, idCategoriaUPD, NombreUPD.Trim(), ApellidoUPD.Trim(), Convert.ToInt32(DNIUPD.Trim()), ContraseñaUPD.Trim(), Convert.ToInt32(CelularUPD.Trim()));
                        Console.WriteLine("Cambio realizado.");
                        LimpiaTextBox();
                        CargarEmpleados();
                        ConfigurarDataGridView();
                        DgvMenuEmpleado.Columns["idCategoria"].Visible = false;
                        DgvMenuEmpleado.Columns["idTrabajador"].Visible = false;
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarEmpleados();
                        ConfigurarDataGridView();
                        DgvMenuEmpleado.Columns["idCategoria"].Visible = false;
                        DgvMenuEmpleado.Columns["idTrabajador"].Visible = false;
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
                            DgvMenuEmpleado.Columns["idCategoria"].Visible = false;
                            DgvMenuEmpleado.Columns["idTrabajador"].Visible = false;
                        }
                        else if (Estado == "DES")
                        {
                            Validaciones.BajaAltaEmpleado(idTrabajadorUPD, "ACT");
                            MessageBox.Show("Empleado DADO DE ALTA");
                            CargarEmpleados();
                            ConfigurarDataGridView();
                            DgvMenuEmpleado.Columns["idCategoria"].Visible = false;
                            DgvMenuEmpleado.Columns["idTrabajador"].Visible = false;
                        }
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarEmpleados();
                    }
                }
            }

        }
        private void chbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEditar.Checked)
            {
                DgvMenuEmpleado.ReadOnly = false;
                MessageBox.Show("Edición habilitada. Puedes editar la grid.", "Información");
            }
            else
            {
                DgvMenuEmpleado.ReadOnly = true;
                MessageBox.Show("Edición deshabilitada. La grid está bloqueada.", "Información");
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
        }

        private void btnBorraCampos_Click(object sender, EventArgs e)
        {
            LimpiaTextBox();
        }
        private void CargarCategorias()
        {
            try
            {
                // Obtener la lista de categorías desde la capa validaciones
                List<Empleados> listaCategorias = Validaciones.ObtenerCategorias();

                if (listaCategorias.Count > 0)
                {
                    // Configurar el ComboBox para usar la lista
                    CmbCategoriaEmple.DataSource = listaCategorias;
                    CmbCategoriaEmple.DisplayMember = "NombreCat"; // Muestra el nombre al usuario
                    CmbCategoriaEmple.ValueMember = "idCategoria"; // Internamente guarda el ID
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
            var comboBoxColumn = new DataGridViewComboBoxColumn
            {
                Name = "CategoriaColumn",
                HeaderText = "Categoría",
                DataPropertyName = "NombreCat", // Vincula la propiedad
                DisplayMember = "Value",
                ValueMember = "Key"
            };

            // Llenar el combo con las categorías
            Dictionary<int, string> categorias = Validaciones.ObtenerCategoriasEmpleados();
            foreach (var categoria in categorias)
            {
                comboBoxColumn.Items.Add(new KeyValuePair<int, string>(categoria.Key, categoria.Value));
            }

            // Agrega la columna al DataGridView
            DgvMenuEmpleado.Columns.Add(comboBoxColumn);
        }

        private void DgvMenuEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
