using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vista
{
    public class Validaciones: Empleados
    {
        public static void DatosEmpleado(int Documento, string contraseña)
        {
            Trabajores.IngresoEmpleados(Documento, contraseña);
        }
        public static void AgregarUnEmpleado (string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int Permiso, int categoria )
        {
            Trabajores.CargaDeEmpleado(Nombre, Apellido, Documento, Contraseña, Telefono, Permiso, categoria);
        }
        public static Dictionary<string, int> ObtenerCategoriasProcesadas()
        {
            Dictionary<string, int> categorias = new Dictionary<string, int>();
            Conectar capaDatos = new Conectar();
            DataTable TablaCategorias = capaDatos.TraerTablaCategorias();

            foreach (DataRow row in TablaCategorias.Rows)
            {
                string nombreCat = row["NombreCat"].ToString().Trim();  
                int permisoCat = Convert.ToInt32(row["PermisoCat"]);
                categorias.Add(nombreCat, permisoCat);
            }

            return categorias;
        }

    }
}
