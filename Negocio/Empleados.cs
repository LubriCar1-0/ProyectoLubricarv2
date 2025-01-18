using Datos;
using Microsoft.SqlServer.Server;
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
        
            #region Variables
            public static int IdTrabajador { get; private set; }
            public static string NombreTrabajador { get; private set; }
            public class Categoria
            {
                public int IdCategoria { get; set; }
                public string NombreCat { get; set; }
            }
        #endregion

        public static void IngresoEmpleados(int documento, string contraseña)
            {
                Conectar capaDatos = new Conectar();
                DataTable TablaEmpleados = capaDatos.BuscarEmpleados();
                bool usuarioEncontrado = false;

                foreach (DataRow Fila in TablaEmpleados.Rows)
                {
                    
                    if (Fila["documentoTR"] != DBNull.Value)
                    {
                        int Documentoint = Convert.ToInt32(Fila["documentoTR"]);

                        
                        if (Documentoint == documento)
                        {
                            
                            string ContraseñaEnBD = Fila["contraseñaTR"].ToString();
                            if (ContraseñaEnBD == contraseña)
                            {
                                usuarioEncontrado = true;
                                int Idtrabajador = capaDatos.TraeId(documento);
                                IdTrabajador = Idtrabajador;
                                string Nomtrabajador = capaDatos.BuscarEmp(Idtrabajador);
                                NombreTrabajador = Nomtrabajador;
                                string detalle = "Acceso al sistema";
                                AgregarBitacora(Idtrabajador, Nomtrabajador, detalle);
                                return;
                            }
                            else
                            {
                                throw new Exception("Contraseña no válida");
                            }
                        }
                    }
                    else
                    {
                        
                        throw new Exception("El numero de documento es inválido.");
                    }
                }

                
                if (!usuarioEncontrado)
                {
                    throw new Exception("Empleado no encontrado");
                }
            }


            public static void CargaDeEmpleado(string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int categoria)
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

                Conectar.AgregarEmpleados(Nombre, Apellido, Documento, Contraseña, Telefono, categoria);
                    string detalle = "Cargar un empleado";
                    AgregarBitacora(IdTrabajador, NombreTrabajador, detalle);
                    return;
                    // agregar un registro a la bitacora de que se agrega un empleado 

                }
            }
            public DataTable ObtenerCategorias()
            {
                Conectar capaDatos = new Conectar();

                return capaDatos.TraerTablaCategorias();
            }
    }

}
