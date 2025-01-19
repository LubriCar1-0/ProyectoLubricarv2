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
            if (cbxLiquido.Checked)
            {
                ValidarProducto.IngresaCategoria(NombreProd.Trim(), Desc.Trim(), "ACT", "S");
            }
            else
            {
                ValidarProducto.IngresaCategoria(NombreProd.Trim(), Desc.Trim(), "ACT","N");
            }
               
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
                    string liquido = filaSeleccionada.Cells["Liquido"].Value.ToString().Trim();


                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?",  "Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);                

                    if (resultado == DialogResult.Yes)
                    {
                        ValidaCategoriasProducto.UpdateCatergorias(IdCategoriaUPD, NombreCategoria.Trim(), Descripcion.Trim(), Estado.Trim(), liquido);
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
                    ValidaCategoriasProducto.CambiarEstado(IdCategoriaUPD, "DES");
                    MessageBox.Show("Estado Modificado.");
                    CargarTablaCategoria();
                }
                else if(Estado == "DES")
                {
                    ValidaCategoriasProducto.CambiarEstado(IdCategoriaUPD, "ACT");
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
            MenuConfiguracion LlamarMenuConfiguracion = new MenuConfiguracion();
            Hide();
            LlamarMenuConfiguracion.ShowDialog();
        }
    }
}
