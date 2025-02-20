using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Datos;

namespace Negocio
{
    public class OrdenDeTrabajo
    {
        #region Variables
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Patente { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan Hora { get; set; }
        public string Descripcion { get; set; }

        public int idOrdenTrabajo { get; set; }
        public int FilaProducto { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public double PrecioVenta { get; set; }
        public double Cantidad { get; set; }
        public double PrecioTotalProd { get; set; }



        #endregion

        public static void CrearOrdenDeTrabajo(string NombreCompleto, DateTime dia, string descripcion, int trabajadorId, int idCliente, int idVehiculo, int idTurno)
        {
            Conectar capaDatos = new Conectar();
            DataTable TablaOrdenes = capaDatos.BuscarOrdenes();
            bool usuarioEncontrado = false;
            foreach (DataRow Fila in TablaOrdenes.Rows)
            {
                int idTurnoEnBD = Convert.ToInt32( Fila["idTurno"].ToString());
                if (idTurno == idTurnoEnBD)
                {
                    usuarioEncontrado = true;
                    throw new Exception("Ya se Creo una Orden de Trabajo en base a ese Turno");


                }

            }
            string estado = "En Proceso";
            Conectar.CrearOrdenTrabajo(NombreCompleto, dia, descripcion, trabajadorId, idCliente, idVehiculo, estado, idTurno);
        }



        private static List<OrdenDeTrabajo> ListDeProductos = new List<OrdenDeTrabajo>();

        public static int contador;
        public static void cuentafilas()
        {
            for (int i = 0; i <= ListDeProductos.Count(); i++)
            {
                contador = i;

            }
        }
        public static void cargaListaProd(int IdOrden, int IdProd, string Producto, int Cantidad, double PrecioVenta)
        {
            cuentafilas();
            ListDeProductos.Add(new OrdenDeTrabajo
            {
                idOrdenTrabajo = IdOrden, 
                IdProducto = IdProd,
                FilaProducto = contador + 1,
                Producto = Producto,
                PrecioVenta = PrecioVenta,
                Cantidad = Cantidad,
                PrecioTotalProd = (PrecioVenta * Cantidad)
            });

        }
        public static double CalculaTotal()
        {
            double valores = 0;
            double total = 0;

            for (int i = 0; i < ListDeProductos.Count(); i++)
            {
                valores = ListDeProductos[i].PrecioTotalProd;

                total += valores;

            }

            return total;

        }
        public static List<OrdenDeTrabajo> ObtenerListaOrden()
        {
            return ListDeProductos;
        }
        public static void CargaList(int idOrdenTrabajo)
        {
            foreach (var item in ListDeProductos)
            {
                Conectar.AgregaListProds(item.idOrdenTrabajo, item.FilaProducto, item.Producto, item.PrecioVenta, item.Cantidad, item.PrecioTotalProd);
                Conectar.RestaCantidad(item.IdProducto, item.Cantidad);
            }
            //Conectar.CargaTotalesVenta(Idcliente, Subtotal, iva, total);
        }
        public static void LimpiaLista()
        {
            ListDeProductos.Clear();
        }

    }

}
