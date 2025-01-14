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
        public MenuCategoriaProductos()
        {
            InitializeComponent();
            CargarTablaCategoria();
            DGVCategoriasProdc.ReadOnly = true;
            chPermiteEditar.CheckedChanged += chPermiteEditar_CheckedChanged;
            DGVCategoriasProdc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCategoriasProdc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnagregarcat_Click(object sender, EventArgs e)
        {
            txtEstado.Text = " ";
            string NombreProd = TxtNombreProducto.Text;
            string Desc = TXTDescripcion.Text;
            ValidarProducto.IngresaCategoria(NombreProd.Trim(),Desc.Trim(), "ACT");
            LimpiaTextBox();
            CargarTablaCategoria();
        }

        private void CargarTablaCategoria()
        {
            DGVCategoriasProdc.DataSource = null;
            DGVCategoriasProdc.DataSource = ValidarProducto.TraeCategoriasProductos();
            DGVCategoriasProdc.Columns["IdCategorias"].Visible = false;
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

                    
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?",  "Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);                

                    if (resultado == DialogResult.Yes)
                    {
                        ValidarProducto.UpdateCategoria(IdCategoriaUPD, NombreCategoria.Trim(), Descripcion.Trim(), Estado.Trim());
                        Console.WriteLine("Cambio realizado.");
                        CargarTablaCategoria();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarTablaCategoria();
                    }


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
    }
}
