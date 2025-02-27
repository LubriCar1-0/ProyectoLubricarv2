using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
using static Negocio.Producto;

namespace Vista
{
    public partial class MenuVentaServicio : Form
    {
        private int _idCliente;
        private int _idVehiculo;
        private int _idTrabajador;
        private int _idOrdenTrab;
        private DataTable _dtProductos;
        private PrintDocument printDocument;
        private string ticketTexto;
        private double costoManoObra;


        public MenuVentaServicio(int idOrdenTrab)
        {
            InitializeComponent();
            CargarDatosVenta(idOrdenTrab);
            CargaListaVenta(idOrdenTrab);
            _idOrdenTrab = idOrdenTrab;
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

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
            LubriPuntos llamalubripuntos = new LubriPuntos();
            lblLubriGana.Text = Convert.ToString(llamalubripuntos.CalculaLubriPuntos(total));
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
                 costoManoObra = Convert.ToDouble(txbManoDeObra.Text);

                
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

        private void MenuVentaServicio_Load(object sender, EventArgs e)
        {

        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            ticketTexto = GenerarPresupuesto();

            if (string.IsNullOrWhiteSpace(ticketTexto))
            {
                MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }




        #region Impresion del ticket

        private string GenerarPresupuesto()
        {
            StringBuilder ticket = new StringBuilder();
           
            DataTable dtProductos = _dtProductos;

            if (dtProductos == null || dtProductos.Rows.Count == 0)
            {
                return string.Empty;
            }

            // Encabezado del ticket
            ticket.AppendLine("==============================================");
            ticket.AppendLine("              PRESUPUESTO - LubriCar          ");
            ticket.AppendLine("==============================================");
            ticket.AppendLine($"Fecha: {DateTime.Now}");
            ticket.AppendLine($"Cliente: {lblNombreCliente.Text}");
            ticket.AppendLine("==============================================");
            ticket.AppendLine("Cant.   Producto       Precio   Total");
            ticket.AppendLine("----------------------------------------------");

            // Datos de los productos
            foreach (DataRow row in dtProductos.Rows)
            {
                int cantidad = Convert.ToInt32(row["Cantidad"]);
                string producto = row["Producto"].ToString();
                double precioUnitario = Convert.ToDouble(row["PrecioUnitario"]);
                double precioTotal = Convert.ToDouble(row["PrecioTotal"]);

                ticket.AppendLine($"{cantidad,5}   {producto,-12}  {precioUnitario,6:C}  {precioTotal,6:C}");
            }

            ticket.AppendLine("----------------------------------------------");

            // Totales calculados a partir del DataTable
            double subtotal = dtProductos.AsEnumerable().Sum(row => Convert.ToDouble(row["PrecioTotal"]));
            double iva = subtotal * 0.21; // IVA 21%
            double total = subtotal + iva;

            ticket.AppendLine($"Subtotal: {subtotal,10:C}");
            ticket.AppendLine($"IVA 21% : {iva,10:C}");
            ticket.AppendLine($"Total   : {total,10:C}");
            ticket.AppendLine("==============================================");
            ticket.AppendLine("           ¡Esperamos su compra!              ");
            ticket.AppendLine("==============================================");

            return ticket.ToString();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 10);
            float yPos = 0;
            int leftMargin = 10;
            float lineHeight = font.GetHeight(e.Graphics);

            using (StringReader reader = new StringReader(ticketTexto))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yPos += lineHeight;
                    e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, yPos);
                }
            }
        }
        private string GenerarTicket()
        {
            StringBuilder ticket = new StringBuilder();

            DataTable dtProductos = _dtProductos;

            if (dtProductos == null || dtProductos.Rows.Count == 0)
            {
                return string.Empty;
            }

            // Encabezado del ticket
            ticket.AppendLine("==============================================");
            ticket.AppendLine("               FACTURA C - LubriCar          ");
            ticket.AppendLine("==============================================");
            ticket.AppendLine($"Fecha: {DateTime.Now}");
            ticket.AppendLine($"Cliente: {lblNombreCliente.Text}");
            ticket.AppendLine("==============================================");
            ticket.AppendLine("Cant.   Producto       Precio   Total");
            ticket.AppendLine("----------------------------------------------");

            // Datos de los productos
            foreach (DataRow row in dtProductos.Rows)
            {
                int cantidad = Convert.ToInt32(row["Cantidad"]);
                string producto = row["Producto"].ToString();
                double precioUnitario = Convert.ToDouble(row["PrecioUnitario"]);
                double precioTotal = Convert.ToDouble(row["PrecioTotal"]);
                ticket.AppendLine($"{cantidad,5}   {producto,-12}  {precioUnitario,6:C}  {precioTotal,6:C}");
            }

            ticket.AppendLine("----------------------------------------------");

            // Totales
            double subtotal = dtProductos.AsEnumerable().Sum(row => Convert.ToDouble(row["PrecioTotal"]));
            double iva = subtotal * 0.21; // IVA 21%
            double total = subtotal + iva;

            ticket.AppendLine($"Subtotal: {subtotal,10:C}");
            ticket.AppendLine($"IVA 21% : {iva,10:C}");
            ticket.AppendLine($"Total   : {total,10:C}");
            ticket.AppendLine("==============================================");
            ticket.AppendLine("           Â¡Gracias por su compra!            ");
            ticket.AppendLine("==============================================");

            return ticket.ToString();
        }

        #endregion

        private void btnCargaVenta_Click(object sender, EventArgs e)
        {
            DataTable dtVentasServ = ValidarVentaServicio.TraerLaTablaVentServ();

            if (dtVentasServ.AsEnumerable().Any(row => Convert.ToInt32(row["idOrdenTrab"]) == _idOrdenTrab))
            {
                MessageBox.Show("No se puede volver a cargar la venta con la misma orden de trabajo.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resultado = MessageBox.Show("Â¿EstÃ¡s seguro de que quieres continuar?", "ConfirmaciÃ³n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int Lubripuntos = Convert.ToInt32(lblLubriGana.Text) + Convert.ToInt32(lblLubripts.Text);
                ValidarVentaServicio.CargarVentaServicio(_idOrdenTrab, _idCliente, costoManoObra, Convert.ToDouble(lblSubTotal.Text), Convert.ToDouble(lblIVA.Text), Convert.ToDouble(lblTotal.Text), Lubripuntos);
                

                #region ImprimeTicket
                ticketTexto = GenerarTicket();

                if (string.IsNullOrWhiteSpace(ticketTexto))
                {
                    MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDocument;
                previewDialog.ShowDialog();
                #endregion

                //MessageBox.Show("Venta cargada con exito");
                
                CargaListaVenta(_idOrdenTrab);
                
                
                lblSubTotal.Text = "0.0";
                lblIVA.Text = "0.0";
                lblTotal.Text = "0.0";
                lblLubriGana.Text = "No hay valor asignado";
            }
        }
    }
}
