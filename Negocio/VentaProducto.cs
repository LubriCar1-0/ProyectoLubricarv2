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
    
    public class VentaProducto
    {
        public int idCliente { get; set; }
        public int FilaProducto { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public double PrecioVenta { get; set; }
        public double Cantidad { get; set; }
        public double PrecioTotalProd { get; set; }

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
                PrecioTotalProd = (PrecioVenta * Cantidad)
            });

        }
        public static double CalculaTotal()
        {
            double valores = 0;
            double total = 0;

            for (int i = 0; i < ListVentaProducto.Count(); i++)
            {
                valores = ListVentaProducto[i].PrecioTotalProd;

                total += valores;

            }

            return total;

        }
        public static List<VentaProducto> ObtenerListaVentas()
        {
            return ListVentaProducto;
        }

        //public static void Cargaventa()
        //{
        //    foreach (var item in ListVentaProducto)
        //    {
        //        Conectar.AgregaVenta(item.idCliente, item.FilaProducto, item.Producto, item.PrecioVenta, item.Cantidad, item.PrecioTotalProd);
        //        Conectar.RestaCantidad(item.IdProducto, item.Cantidad);
        //    }
        //}

        public static void LimpiaLista()
        {
            ListVentaProducto.Clear();
        }
        public static void CargaTotalesVenta(int IdCliente, double subtotal, double iva, double total)
        {
            Conectar.CargaTotalesVenta(IdCliente, subtotal, iva, total);

        }



        public static void Cargaventa(int Idcliente, double Subtotal, double iva, double total, int lubripuntos)
        {
            Conectar.CargaTotalesVenta(Idcliente, Subtotal, iva, total);
            int id = Conectar.TraeIdUltimaVenta();

            foreach (var item in ListVentaProducto)
            {
                Conectar.AgregaVenta(id, item.idCliente, item.FilaProducto, item.Producto, item.PrecioVenta, item.Cantidad, item.PrecioTotalProd);
                Conectar.RestaCantidad(item.IdProducto, item.Cantidad);
            }

            Conectar.CargaLubriPuntos(Idcliente, lubripuntos);
        }

        public static void CargaLubripuntos(int ValorLubri)
        {




        }


    }









}

