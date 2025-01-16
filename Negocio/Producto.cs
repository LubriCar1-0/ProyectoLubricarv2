using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Negocio.Producto;

namespace Negocio
{
    public class Producto : Conectar
    {
        public class Productos : Producto
        {
            public int idProducto { get; set; }
            public string nombre { get; set; }
            public int codProd { get; set; }
            public string Idcategoria { get; set; }
            public string descripcion { get; set; }
            public float precio { get; set; }
            public int cantDisp { get; set; }

        }
        public static void CargaProductos(string NombreProducto, string MarcaProducto, int CategoriaProducto, string CodigoProducto, string DescripcionProducto, int CantidadProducto, double PrecioLista, double PrecioVenta, double LitrosDisponibles)
        {

            int encontro = Conectar.BuscaDuplicadoProducto(NombreProducto, MarcaProducto, CategoriaProducto);
            if (encontro == 0)
            {
                Conectar.AgregarProducto(NombreProducto.ToUpper(), MarcaProducto.ToUpper(), CategoriaProducto, CodigoProducto.ToUpper(), DescripcionProducto.ToUpper(), CantidadProducto, PrecioLista, PrecioVenta, LitrosDisponibles);
                
            }
            else
            {
                throw new Exception("Ya se encontro un producto registrado con el nombre, marca y categoria de producto");
            }
        }
   
    }
    

}
