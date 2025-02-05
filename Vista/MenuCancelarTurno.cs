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
    public partial class MenuCancelarTurno : Form
    {
        public MenuCancelarTurno()
        {
            InitializeComponent();
            CargarVehiculos();
            CargarTurnos();
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];
            int idTurno = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);
            int idCliente = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
            int idVehiculo = Convert.ToInt32(filaSeleccionada.Cells["idVehiculo"].Value);
            
            if (DateTime.TryParse(filaSeleccionada.Cells["Fecha"].Value?.ToString(), out DateTime fecha))
            {
               
            }

            if (TimeSpan.TryParse(filaSeleccionada.Cells["Hora"].Value?.ToString(), out TimeSpan hora))
            {
                DateTime fechaHora = DateTime.Today.Add(hora);
                
            }

            
            if (dgvTurnos.Columns[e.ColumnIndex].Name == "Cancelar")
            {
                if (e.RowIndex >= 0)
                {
                    int idTurnoUPD = Convert.ToInt32(filaSeleccionada.Cells["idTurno"].Value);

                    string Estado = filaSeleccionada.Cells["Estado"].Value.ToString().Trim();

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                        if (Estado == "ACT")
                        {
                            validarTurnos.CancelarTurno(idTurnoUPD, "DES");
                            MessageBox.Show("Turno CANCELADO.");
                            CargarTurnos();
                            
                            //ConfigurarDataGridView();
                            dgvTurnos.Columns["idTurno"].Visible = false;
                            dgvTurnos.Columns["idVehiculo"].Visible = false;
                            dgvTurnos.Columns["idCliente"].Visible = false;
                        }
                        else if (Estado == "DES")
                        {
                            MessageBox.Show("Este turno ya ha sido cancelado");
                            
                            


                        }
                    }
                    else if (resultado == DialogResult.No)
                    {
                        
                    }

                }
            }
        }
        private void CargarTurnos()
        {
            try
            {
                dgvTurnos.DataSource = null;
                dgvTurnos.DataSource = validarTurnos.BuscarTurnos();
                if (dgvTurnos.Columns.Contains("idVehiculo"))
                {
                    dgvTurnos.Columns["idVehiculo"].Visible = false;
                }
                if (dgvTurnos.Columns.Contains("idCliente"))
                {
                    dgvTurnos.Columns["idCliente"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los vehículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuCancelarTurno_Load(object sender, EventArgs e)
        {

        }

        private void CargarVehiculos()
        {
            Dictionary<int, string> vehiculos = validarTurnos.ObtenerVehiculos();

           
            foreach (var vehiculo in vehiculos)
            {
                cmbSelecVH.Items.Add(new KeyValuePair<int, string>(vehiculo.Key, vehiculo.Value));
            }

            cmbSelecVH.DisplayMember = "Value";
            cmbSelecVH.ValueMember = "Key";

        }
    }
}
