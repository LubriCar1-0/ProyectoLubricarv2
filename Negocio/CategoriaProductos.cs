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
            public int IdCategoria { get; set; }
            public string NombreCategoria { get; set; }
            public string Descripcion { get; set; }
            public string Estado { get; set; }
            public DateTime FechaCreacion { get; set; }
            public static List<Categorias> ObtenerCategorias()
            {
                Conectar conexion = new Conectar();
                DataTable categoriaTabla = conexion.TraerCategoriasActivas();

                List<Categorias> categorias = new List<Categorias>();
                foreach (DataRow row in categoriaTabla.Rows)
                {
                        categorias.Add(new Categorias
                    {
                            IdCategoria = Convert.ToInt32(row["IdCategorias"]),
                            NombreCategoria = row["NombreCategoria"].ToString()
                    });
                }

                return categorias;
            }
        }
   
}
