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
            string estado = "INICIADO";
            string detalle = "Creacion de Orden De Trabajo";
            string Tabla = "OrdenTrabajo";
            Conectar.CrearOrdenTrabajo(NombreCompleto, dia, descripcion, trabajadorId, idCliente, idVehiculo, estado, idTurno);
            Conectar.UpdateEstadoTurno(idTurno, estado);
            Conectar.AgregarBitacora(Empleados.IdTrabajador, detalle, Tabla);
        }
        public static void CambioDeEstado (int idOrden, string estado, string descripcion)
        {
            Conectar capadatos = new Conectar();
            Conectar.UpdateEstado(idOrden, estado, descripcion);
            string detalle = "Cambio de estado de la Orden De Trabajo";
            string Tabla = "OrdenTrabajo";
            Conectar.AgregarBitacora(Empleados.IdTrabajador, detalle, Tabla);
        }

        #region Lista 
        private static List<OrdenDeTrabajo> ListDeProductos = new List<OrdenDeTrabajo>();
        public static int contador;

        public static void cuentafilas()
        {
            contador = ListDeProductos.Count;
        }


        public static void cargaListaProd(int IdOrden, int IdProd, string Producto, int Cantidad, double PrecioVenta)
        {

            var itemExistente = ListDeProductos.FirstOrDefault(p => p.idOrdenTrabajo == IdOrden && p.IdProducto == IdProd);
            if (itemExistente != null)
            {
                // Incrementar la cantidad y recalcular el total
                itemExistente.Cantidad += Cantidad;
                itemExistente.PrecioTotalProd = itemExistente.PrecioVenta * itemExistente.Cantidad;
            }
            else
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
                    PrecioTotalProd = PrecioVenta * Cantidad
                });
            }
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
                Conectar.AgregaListProds(item.idOrdenTrabajo, item.FilaProducto, item.Producto, item.PrecioVenta, item.Cantidad, item.PrecioTotalProd, item.IdProducto);
                Conectar.RestaCantidad(item.IdProducto, item.Cantidad);
                string detalle = "Creacion de Orden De Trabajo";
                string Tabla = "OrdenTrabajo";
                Conectar.AgregarBitacora (Empleados.IdTrabajador, Tabla, detalle);
            }
        }

        public static void LimpiaLista()
        {
            ListDeProductos.Clear();
        }
        #endregion

        #region TraerLista
        public static List<OrdenDeTrabajo> ObtenerListaGuardada(int idOrdenTrab)
        {
            Conectar capaDatos = new Conectar();
            DataTable dt = capaDatos.ObtenerProductosPorOrden(idOrdenTrab);
            List<OrdenDeTrabajo> lista = new List<OrdenDeTrabajo>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new OrdenDeTrabajo
                {
                    idOrdenTrabajo = Convert.ToInt32(row["idOrdenTrab"]),
                    FilaProducto = Convert.ToInt32(row["FilaProducto"]),
                    Producto = row["Producto"].ToString().Trim(),
                    PrecioVenta = Convert.ToDouble(row["PrecioUnitario"]),
                    Cantidad = Convert.ToDouble(row["Cantidad"]),
                    PrecioTotalProd = Convert.ToDouble(row["PrecioTotal"]),

                    
                    IdProducto = Convert.ToInt32(row["idProd"])
                });
            }
            return lista;
        }
        #endregion

      

    }

}
