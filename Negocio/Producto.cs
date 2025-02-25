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
            public string Idcategorias { get; set; }
            public string descripcion { get; set; }
            public float precio { get; set; }
            public int cantDisp { get; set; }

        }
        public static void UpdateProductos(int IdProdUPD, string Nombreprd, string marcaeprd, int categoria, string codigoproducto, string descripcion, int cantidad, int preciolista, int precioventa, double litraje, double litrajeMin, int cantidadmin, int _idTrabajador)
        {
            Conectar.UpdateProductos(IdProdUPD, Nombreprd.ToUpper().Trim(), marcaeprd.ToUpper().Trim(), categoria, codigoproducto.ToUpper().Trim(), descripcion.ToUpper().Trim(), cantidad, preciolista, precioventa, litraje, litrajeMin, cantidadmin);
            string detalle = "Modificacion de Productos";
            string Tabla = "Producto";
            AgregarBitacora(_idTrabajador, detalle, Tabla);
        }
        public static void CargaProductos(string NombreProducto, string MarcaProducto, int CategoriaProducto, string CodigoProducto, string DescripcionProducto, int CantidadProducto, double PrecioLista, double PrecioVenta, double LitrosDisponibles, double litroMin, int cantidadmin, string estado, int _idTrabajador)
        {

            int encontro = Conectar.BuscaDuplicadoProducto(NombreProducto, MarcaProducto, CategoriaProducto);
            try
            {
                if (encontro == 0)
                {

                    Conectar.AgregarProducto(NombreProducto.ToUpper(), MarcaProducto.ToUpper(), CategoriaProducto, CodigoProducto.ToUpper(), DescripcionProducto.ToUpper(), CantidadProducto, PrecioLista, PrecioVenta, LitrosDisponibles, litroMin, cantidadmin, estado);
                    string detalle = "Carga de un Producto";
                    string Tabla = "Producto";
                    AgregarBitacora(_idTrabajador, detalle, Tabla);
                }
            }
            
            catch (Exception ex) {

            
                throw new Exception("Ya se encontro un producto registrado con el nombre, marca y categoria de producto");
            }
        }

        public static void EliminarProductos(int IdProd, string valor, int _idTrabajador)
        {
            Conectar.EliminarProducto(IdProd, valor);
            string detalle = "Baja de un Producto";
            string Tabla = "Producto";
            AgregarBitacora(_idTrabajador, detalle, Tabla);
        }
        public static void ControlStock(int IdProd, int cantidad, double preciolista, double precioventa, double litraje, double litrajeMin, int cantidadmin, int _IdTrabajador)
        {
            Conectar.ControlStock(IdProd, cantidad, preciolista, precioventa, litraje, litrajeMin, cantidadmin);
            string detalle = "Modificacion precio o cantidad disponible de un producto";
            string Tabla = "Producto";
            AgregarBitacora(_IdTrabajador, detalle, Tabla);
        }

        public DataTable FiltroStock(string codigo)
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasDeLaBD = CapaDatos.ControlStockFiltro(codigo);
            return TablasDeLaBD;
        }

    }
    

}
