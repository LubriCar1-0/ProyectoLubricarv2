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
        public static void IngresaCatergorias(string nombreCat, string catedescripcion, string estado, string liquido)
        {
            Conectar.IngresaCategoria(nombreCat, catedescripcion, estado, liquido);

        }
        public static void UpdateCatergorias(int IdCategoriaUPD, string NombreCategoria, string Descripcion, string Estado, string liquido)
        {
            Conectar.UpdateCategorias(IdCategoriaUPD, NombreCategoria, Descripcion, Estado, liquido);
        }

        public static int ChequeaLiquido(int Id)
        {
           int valor = Conectar.TraeLiquido(Id);
           return valor;
        }

    } 


}
