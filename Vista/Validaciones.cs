using Negocio;
using System;
using System.Collections.Generic;
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
        public static void AgregarUnEmpleado (string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int permiso, int categoria )
        {
            Trabajores.CargaDeEmpleado(Nombre, Apellido, Documento, Contraseña, Telefono, categoria, permiso);
        }
    }
}
