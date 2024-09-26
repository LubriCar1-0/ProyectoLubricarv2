using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.Empleados;
namespace Negocio
{
    public class Empleados : Conectar
    {
        public class Trabajores: Empleados 
        {
            #region Variables
            public int idTrabajador { get; set; }
            public string nomApetr { get; set; }
            public int documentoTR { get; set; }
            public string contraseñaTR { get; set; }
            public int telefonoTR { get; set; }
            public string permiso { get; set; }
            #endregion

            public static void IngresoEmpleados (int documento, string contraseña)
            {
                Conectar capaDatos = new Conectar();
                DataTable TablaEmpleados = capaDatos.BuscarEmpleados();
                bool usuarioEncontrado = false;
             

                foreach (DataRow Fila in TablaEmpleados.Rows)
                {
                    string DocumentoEnBD = Fila["documentoTR"].ToString();
                    string ContraseñaEnBD = Fila["contraseñaTR"].ToString();
                    int Documentoint = Convert.ToInt32(DocumentoEnBD);
                    if (Documentoint == documento && ContraseñaEnBD == contraseña)
                    {
                        //AccederBitacora(); agregar la funcion a la bitacora 
                        usuarioEncontrado = true;
                        return;
                    }
                    else if (Documentoint != documento/*.ToString()*/ && ContraseñaEnBD == contraseña)
                    {
                        throw new Exception("Empleado no encontrado");
                    }
                    else if (Documentoint != documento/*.ToString()*/ && ContraseñaEnBD != contraseña)
                    {
                        throw new Exception("Contraseña no valida");
                    }
                    
                }


            }
            public static void CargaDeEmpleado(string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int permiso, int categoria)
            {
                Conectar capaDatos = new Conectar();
                DataTable TablaEmpleados = capaDatos.BuscarEmpleados();
                bool usuarioEncontrado = false;

                foreach (DataRow Fila in TablaEmpleados.Rows)
                {
                    string DocumentoEnBD = Fila["documentoTR"].ToString();
                    int Documentoint = Convert.ToInt32(DocumentoEnBD);
                    if (Documentoint == Documento) 
                    { 
                        usuarioEncontrado = true;
                        throw new Exception("Ya existe un empleado con este documento");

                    
                    }

                }
                if (!usuarioEncontrado) 
                {

                    Conectar.AgregarEmpleados(Nombre, Apellido, Documento, Contraseña, Telefono, permiso, categoria);
                    // agregar un registro a la bitacora de que se agrega un empleado 

                }
            }







        }


    }

}
