using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class CategoriaEmpleado
    {
        public int idCategoria { get; set; }
        public string NombreCat { get; set; }
        public int PermisoCat { get; set; }
        public static List<CategoriaEmpleado> ObtenerCategoriasEmp()
        {
            Conectar conexion = new Conectar();
            DataTable categoriaTabla = conexion.TraerCategoriasEmpleados();

            List<CategoriaEmpleado> categorias = new List<CategoriaEmpleado>();
            foreach (DataRow row in categoriaTabla.Rows)
            {
                categorias.Add(new CategoriaEmpleado
                {
                    idCategoria = Convert.ToInt32(row["idCategoria"]),
                    NombreCat = row["NombreCat"].ToString(),
                    //PermisoCat = Convert.ToInt32(row["PermisoCat"])

                });
            }

            return categorias;
        }

        public static void IngresaCatergoriasEMP(string nombreCat, string catedescripcion, int CodPerm)
        {
            string Estado = "ACT";
            Conectar.IngresaCategoriaEMP(nombreCat, catedescripcion, CodPerm, Estado);

        }

        public static void ActualizarCategoriaEMP (int idCategoria, string nombreCat, int codPerm,string descripcion)
        {
            Conectar.UpdateCategoriaEMP(idCategoria, nombreCat, codPerm, descripcion);
        }

        public static void ActualizarEstadoEMP (int idCategoria, string Estado)
        {
            Conectar.CambiarEstadoEMP (idCategoria, Estado);
        }
    }
}
