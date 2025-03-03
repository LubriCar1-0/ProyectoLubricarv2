using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MenuCategoriaProductos : Form
    {
        private int _idTrabajador;
        public MenuCategoriaProductos(int idTrabajador)
        {
            InitializeComponent();
            CargarTablaCategoria();
            DGVCategoriasProdc.ReadOnly = true;
            chPermiteEditar.CheckedChanged += chPermiteEditar_CheckedChanged;
            DGVCategoriasProdc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCategoriasProdc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _idTrabajador = idTrabajador;
        }

        private void btnagregarcat_Click(object sender, EventArgs e)
        {
            txtEstado.Text = " ";
            string NombreProd = TxtNombreProducto.Text;
            string Desc = TXTDescripcion.Text;
            if (cbxLiquido.Checked)
            {
                ValidaCategoriasProducto.IngresaCat(NombreProd.Trim(), Desc.Trim(), "ACT", "S", _idTrabajador);
            }
            else
            {
                ValidaCategoriasProducto.IngresaCat(NombreProd.Trim(), Desc.Trim(), "ACT","N", _idTrabajador);
            }
               
            LimpiaTextBox();
            CargarTablaCategoria();
        }

        private void CargarTablaCategoria()
        {
            DGVCategoriasProdc.DataSource = null;
            DGVCategoriasProdc.DataSource = ValidarProducto.TraeCategoriasProductos();
            DGVCategoriasProdc.Columns["IdCategorias"].Visible = false;
            ConfiguraDataGridStyle(DGVCategoriasProdc);
            DGVCategoriasProdc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCategoriasProdc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void ConfiguraDataGridStyle(DataGridView dgv)
        {
            dgv.ReadOnly = true;

            // General
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Cabecera
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185); // Azul elegante
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Azul mÃ¡s claro
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Alternancia de color en filas
            //dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 250);

            // Otros ajustes
            dgv.RowHeadersVisible = false; // Ocultar la primera columna de encabezado
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ScrollBars = ScrollBars.Both; // Asegurar barras de desplazamiento

            AplicarTrimDataGridViews(dgv);
        }
        public void AplicarTrimDataGridViews(DataGridView dgv)
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
        private void DGVCategoriasProdc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = DGVCategoriasProdc.Rows[e.RowIndex];
            int IdCategoria = Convert.ToInt32(filaSeleccionada.Cells["IdCategorias"].Value);
            TxtNombreProducto.Text = filaSeleccionada.Cells["NombreCategoria"].Value.ToString().Trim();
            TXTDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString().Trim();
            txtEstado.Text = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();

            if (DGVCategoriasProdc.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionadaUPD = DGVCategoriasProdc.Rows[e.RowIndex];
                    int IdCategoriaUPD = Convert.ToInt32(filaSeleccionada.Cells["IdCategorias"].Value);
                    string NombreCategoria = filaSeleccionada.Cells["NombreCategoria"].Value.ToString().Trim();
                    string Descripcion = filaSeleccionada.Cells["Descripcion"].Value.ToString().Trim();
                    string Estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();
                    string liquido = filaSeleccionada.Cells["Liquido"].Value.ToString().Trim();


                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?",  "Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);                

                    if (resultado == DialogResult.Yes)
                    {
                        ValidaCategoriasProducto.UpdateCategoria(IdCategoriaUPD, NombreCategoria.Trim(), Descripcion.Trim(), Estado.Trim(), liquido, _idTrabajador);
                        MessageBox.Show("Cambio realizado.");
                        CargarTablaCategoria();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarTablaCategoria();
                    }


                }
            }
            else if (DGVCategoriasProdc.Columns[e.ColumnIndex].Name == "EstadoNuevo")
            {
                DataGridViewRow filaSeleccionadaUPD = DGVCategoriasProdc.Rows[e.RowIndex];
                int IdCategoriaUPD = Convert.ToInt32(filaSeleccionada.Cells["IdCategorias"].Value);
                string Estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();


                if(Estado == "ACT")
                {
                    ValidaCategoriasProducto.CambiarEstado(IdCategoriaUPD, "DES", _idTrabajador);
                    MessageBox.Show("Estado Modificado.");
                    CargarTablaCategoria();
                }
                else if(Estado == "DES")
                {
                    ValidaCategoriasProducto.CambiarEstado(IdCategoriaUPD, "ACT", _idTrabajador);
                    MessageBox.Show("Estado Modificado.");
                    CargarTablaCategoria();
                }





            }



        }
        private void chPermiteEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chPermiteEditar.Checked)
            {
                DGVCategoriasProdc.ReadOnly = false;
            }
            else
            {
                DGVCategoriasProdc.ReadOnly = true;

            }
        }

        private void LimpiaTextBox()
        {
            TxtNombreProducto.Text = string.Empty;
            TXTDescripcion.Text = string.Empty; 
            txtEstado.Text = string.Empty;  
        }

        private void btnBorraCampos_Click(object sender, EventArgs e)
        {
            LimpiaTextBox();
        }

        private void cbxLiquido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TXTDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void MenuCategoriaProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
