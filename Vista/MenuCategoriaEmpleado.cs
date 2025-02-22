using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MenuCategoriaEmpleado : Form
    {
        public MenuCategoriaEmpleado()
        {
            InitializeComponent();
            CargarTablaCategoriasEMP();
            dgvCategoriasEmpleados.ReadOnly = true;
            chPermiteEditar.CheckedChanged += chPermiteEditar_CheckedChanged;
            dgvCategoriasEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoriasEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnagregarcat_Click(object sender, EventArgs e)
        {
            
            string NombreCat = txbNomCat.Text;
            string Desc = txbDescripcion.Text;
            int CodPerm = Convert.ToInt32(txbCodPerm.Text);
            
            Validaciones.IngresaCategoriaEMP(NombreCat.Trim(), Desc.Trim(), CodPerm, "ACT");
            
            LimpiaTextBox();
            CargarTablaCategoriasEMP();
        }
        private void LimpiaTextBox()
        {
            txbNomCat.Text = string.Empty;
            txbDescripcion.Text = string.Empty;
            txbCodPerm.Text = string.Empty;
        }
        private void CargarTablaCategoriasEMP()
        {
            dgvCategoriasEmpleados.DataSource = null;
            dgvCategoriasEmpleados.DataSource = Validaciones.TraeCategoriasEmpleados();
            dgvCategoriasEmpleados.Columns["idCategoria"].Visible = false;
        }

        private void dgvCategoriasEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvCategoriasEmpleados.Rows[e.RowIndex];
            int IdCategoria = Convert.ToInt32(filaSeleccionada.Cells["idCategoria"].Value);
            txbNomCat.Text = filaSeleccionada.Cells["NombreCat"].Value.ToString().Trim();
            int CodPerm = Convert.ToInt32(filaSeleccionada.Cells["PermisoCat"].Value);
            txbCodPerm.Text = Convert.ToString(CodPerm);
            txbDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString().Trim();
            

            if (dgvCategoriasEmpleados.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionadaUPD = dgvCategoriasEmpleados.Rows[e.RowIndex];
                    int IdCategoriaUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["idCategoria"].Value);
                    string NombreCat = filaSeleccionadaUPD.Cells["NombreCat"].Value.ToString().Trim();
                    int CodPermUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["PermisoCat"].Value);
                    string DescUPD = filaSeleccionada.Cells["Descripcion"].Value.ToString().Trim();


                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        Validaciones.UpdateCatergoriasEmpleados(IdCategoriaUPD, NombreCat.Trim(),CodPerm, DescUPD.Trim());
                        MessageBox.Show("Cambio realizado.");
                        CargarTablaCategoriasEMP();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        CargarTablaCategoriasEMP();
                    }


                }
            }
            else if (dgvCategoriasEmpleados.Columns[e.ColumnIndex].Name == "CambiarEstado")
            {
                DataGridViewRow filaSeleccionadaUPD = dgvCategoriasEmpleados.Rows[e.RowIndex];
                int IdCategoriaUPD = Convert.ToInt32(filaSeleccionadaUPD.Cells["idCategoria"].Value);
                string Estado = filaSeleccionada.Cells["ESTADO"].Value.ToString().Trim();


                if (Estado == "ACT")
                {
                    Validaciones.CambiarEstadoEMP(IdCategoriaUPD, "DES");
                    MessageBox.Show("Estado Modificado.");
                    CargarTablaCategoriasEMP();
                }
                else if (Estado == "DES")
                {
                    Validaciones.CambiarEstadoEMP(IdCategoriaUPD, "ACT");
                    MessageBox.Show("Estado Modificado.");
                    CargarTablaCategoriasEMP();
                }





            }
        }

        private void chPermiteEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chPermiteEditar.Checked)
            {
                dgvCategoriasEmpleados.ReadOnly = false;
            }
            else
            {
                dgvCategoriasEmpleados.ReadOnly = true;

            }
        }

        private void btnBorraCampos_Click(object sender, EventArgs e)
        {
            LimpiaTextBox();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
