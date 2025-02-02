using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VentaProducto
    {
        public int IdVenta { get; set; }
        public int idCliente { get; set; }
        public string Producto { get; set; }
        public double PrecioVenta { get; set; }
        public double Cantidad { get; set; }
        public double PrecioTotal { get; set; }
        private static List<VentaProducto> ListVentaProducto = new List<VentaProducto>();
        public static void cargaList(int Idcliente,string Producto, int Cantidad, double PrecioVenta)
        {

            ListVentaProducto.Add(new VentaProducto
            {
               idCliente       = Idcliente,
               Producto        = Producto,
               PrecioVenta     = PrecioVenta,
               Cantidad        = Cantidad,
               PrecioTotal     = (PrecioVenta * Cantidad)
            });
            
        }

        public static List<VentaProducto> ObtenerListaVentas()
        {
            return ListVentaProducto;
        }



    }

    






}

