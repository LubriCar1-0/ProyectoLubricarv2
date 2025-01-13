using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            public string categoria { get; set; }
            public string descripcion { get; set; }
            public float precio { get; set; }
            public int cantDisp { get; set; }

        }
        public static void CargaProductos(string NombreProducto, string MarcaProducto, string CategoriaProducto, int CodigoProducto, string DescripcionProducto, int CantidadProducto, decimal PrecioLista, decimal PrecioVenta, decimal LitrosDisponibles)
        {
            Conectar capaDatos = new Conectar();
            Conectar.AgregarProducto(NombreProducto, MarcaProducto, CategoriaProducto, CodigoProducto, DescripcionProducto, CantidadProducto, PrecioLista, PrecioVenta, LitrosDisponibles);
        }
        public static void IngresaCatergorias(string nombreCat, string catedescripcion, string estado)
        {
            Conectar.IngresaCategoria(nombreCat, catedescripcion, estado);
        }
       
        public static void UpdateCatergorias(int IdCategoriaUPD, string NombreCategoria, string Descripcion, string Estado)
        {
            Conectar.UpdateCategorias(IdCategoriaUPD, NombreCategoria, Descripcion, Estado);
        }
    }


}
