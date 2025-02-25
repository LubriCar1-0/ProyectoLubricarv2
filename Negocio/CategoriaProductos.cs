using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{

    public class Categorias
    {
        public int IdCategorias { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Liquido { get; set; }



        public static List<Categorias> ObtenerCategorias()
        {
            Conectar conexion = new Conectar();
            DataTable categoriaTabla = conexion.TraerCategoriasActivas();

            List<Categorias> categorias = new List<Categorias>();
            foreach (DataRow row in categoriaTabla.Rows)
            {
                categorias.Add(new Categorias
                {
                    IdCategorias = Convert.ToInt32(row["IdCategorias"]),
                    NombreCategoria = row["NombreCategoria"].ToString(),
                    Liquido = row["Liquido"].ToString()
                });
            }

            return categorias;
        }
        public static void IngresaCatergorias(string nombreCat, string catedescripcion, string estado, string liquido, int _idTrabajador)
        {
            Conectar.IngresaCategoria(nombreCat, catedescripcion, estado, liquido);
            string detalle = "Carga de una nueva Categoria";
            string tabla = "CategoriasProductos";
            Conectar.AgregarBitacora(_idTrabajador, detalle, tabla);

        }
        public static void UpdateCatergorias(int IdCategoriaUPD, string NombreCategoria, string Descripcion, string Estado, string liquido, int _idTrabajador)
        {
            Conectar.UpdateCategorias(IdCategoriaUPD, NombreCategoria, Descripcion, Estado, liquido);
            string detalle = "Modificacion de una Categoria";
            string tabla = "CategoriasProductos";
            Conectar.AgregarBitacora(_idTrabajador, detalle, tabla);
        }

        public static int ChequeaLiquido(int Id)
        {
           int valor = Conectar.TraeLiquido(Id);
           return valor;
        }

        public static void CambiarEstado(int IdCategoriaUPD, string estadoNuevo, int _idTrabajador)
        {
            Conectar.CambiarEstado(IdCategoriaUPD, estadoNuevo);
            string detalle = "Baja de una Categoria";
            string tabla = "CategoriasProductos";
            Conectar.AgregarBitacora(_idTrabajador, detalle, tabla);


        }






    } 


}
