using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.Producto;

namespace Negocio
{
    public class VentaProductoHistorial
    {
        public int IdVenta { get; set; }
        public int idCliente { get; set; }
        public int FilaProducto { get; set; }
        public string Producto { get; set; }
        public double PrecioVenta { get; set; }
        public double Cantidad { get; set; }
        public double PrecioTotal { get; set; }
    }
    public class VentaProducto
    {
        public int idCliente { get; set; }
        public int FilaProducto { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public double PrecioVenta { get; set; }
        public double Cantidad { get; set; }
        public double PrecioTotal { get; set; }

        private static List<VentaProducto> ListVentaProducto = new List<VentaProducto>();

        public static int contador;
        public static void cuentafilas()
        {
            for (int i = 0; i <= ListVentaProducto.Count(); i++)
            {
                contador = i;

            }
        }
        public static void cargaList(int Idcliente, int IdProd, string Producto, int Cantidad, double PrecioVenta)
        {
            cuentafilas();
            ListVentaProducto.Add(new VentaProducto
            {
                idCliente = Idcliente,
                IdProducto = IdProd,
                FilaProducto = contador + 1,
                Producto = Producto,
                PrecioVenta = PrecioVenta,
                Cantidad = Cantidad,
                PrecioTotal = (PrecioVenta * Cantidad)
            });

        }
        public static double CalculaTotal()
        {
            double valores = 0;
            double total = 0;

            for (int i = 0; i < ListVentaProducto.Count(); i++)
            {
                valores = ListVentaProducto[i].PrecioTotal;

                total += valores;

            }

            return total;

        }
        public static List<VentaProducto> ObtenerListaVentas()
        {
            return ListVentaProducto;
        }

        public static void Cargaventa()
        {
            foreach (var item in ListVentaProducto)
            {
                Conectar.AgregaVenta(item.idCliente, item.FilaProducto, item.Producto, item.PrecioVenta, item.Cantidad, item.PrecioTotal);
                Conectar.RestaCantidad(item.IdProducto, item.Cantidad);
            }
        }

        public static void LimpiaLista()
        {
            ListVentaProducto.Clear();
        }











    }









}

