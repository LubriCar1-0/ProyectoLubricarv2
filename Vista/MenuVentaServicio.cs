using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Vista
{
    public partial class MenuVentaServicio : Form
    {
        private int _idCliente;
        private int _idVehiculo;
        private int _idTrabajador;
        private int _idOrdenTrab;
        private DataTable _dtProductos;

        public MenuVentaServicio(int idOrdenTrab)
        {
            InitializeComponent();
            CargarDatosVenta(idOrdenTrab);
            CargaListaVenta(idOrdenTrab);
            _idOrdenTrab = idOrdenTrab;


        }

        private void lblNombreCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarDatosVenta(int idOrdenTrab)
        {
            try
            {
                
                VentaServicio venta = VentaServicio.ObtenerDatosVenta(idOrdenTrab);
                if (venta != null)
                {
                    
                    lblNombreCliente.Text = venta.NombreCompleto.Trim();
                    lblLubripts.Text = venta.Lubripuntos.ToString();
                    lblMarca.Text = venta.Marca;
                    lblModelo.Text = venta.Modelo;
                    lblPatente.Text = venta.Patente;
                    //lblNombreTrabajador.Text = venta.NombreCompletoTrabajador;

                    
                    _idCliente = venta.idCliente;
                    _idVehiculo = venta.idVehiculo;
                    _idTrabajador = venta.idTrabajador;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para la orden de trabajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaListaVenta(int OrdenTrab)
        {
            try
            {
                
                _dtProductos = ValidarVentaServicio.ListaDeProductos(OrdenTrab);
                dgvListVentas.DataSource = _dtProductos;
                dgvListVentas.Columns["idProd"].Visible = false;
                dgvListVentas.RowHeadersVisible = false;
                foreach (DataGridViewColumn column in dgvListVentas.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
               
                ActualizarTotales(_dtProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTotales(DataTable dt)
        {
            double subTotal = 0;
            foreach (DataRow row in dt.Rows)
            {
                subTotal += Convert.ToDouble(row["PrecioTotal"]);
            }

            lblSubTotal.Text = subTotal.ToString("N2");

            double iva = subTotal * 0.21;
            lblIVA.Text = iva.ToString("N2");

            double total = subTotal + iva;
            lblTotal.Text = total.ToString("N2");
        }




        private void btnGuardarMano_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbManoDeObra.Text))
            {
                MessageBox.Show("Debe ingresar el valor de la mano de obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de asignar ese valor de mano de obra?",
                                                      "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                double costoManoObra = Convert.ToDouble(txbManoDeObra.Text);

                
                DataRow newRow = _dtProductos.NewRow();
                newRow["Producto"] = "Mano de Obra";
                newRow["PrecioUnitario"] = 0.0;
                newRow["Cantidad"] = 1;
                newRow["PrecioTotal"] = costoManoObra;

                _dtProductos.Rows.Add(newRow);

                ActualizarTotales(_dtProductos);

                MessageBox.Show("El registro se ha actualizado con éxito.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Precio no asignado.", "Carga Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void dgvListVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
