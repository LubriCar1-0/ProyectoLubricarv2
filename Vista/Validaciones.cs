using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.Cliente;
using static Negocio.Empresa;
using static Negocio.Vehiculo;
using static Negocio.Producto;
using static Negocio.Categorias;
using System.Security.Policy;


namespace Vista
{
    #region empleados
    public class Validaciones : Empleados
    {
        public static void DatosEmpleado(int Documento, string contraseña)
        {
            Empleados.IngresoEmpleados(Documento, contraseña);
        }
        public static void AgregarUnEmpleado(string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int categoria)
        {
            Empleados.CargaDeEmpleado(Nombre, Apellido, Documento, Contraseña, Telefono, categoria);
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
        public static DataTable TraeEmpleados() 
        { 
            Conectar CapaDatos = new Conectar();
            DataTable TablasEmpleados= CapaDatos.BuscarEmpleados();
            return TablasEmpleados;
        
        
        }
        public static List<Empleados> ObtenerCategorias()
        {
            Conectar capaDatos = new Conectar();
            DataTable tablaCategorias = capaDatos.TraerTablaCategorias();
            var listaCategorias = new List<Empleados>();

            foreach (DataRow row in tablaCategorias.Rows)
            {
                if (row["idCategoria"] != DBNull.Value && row["NombreCat"] != DBNull.Value)
                {
                    listaCategorias.Add(new Empleados
                    {
                        idCategoria = Convert.ToInt32(row["idCategoria"]),
                        NombreCat = row["NombreCat"].ToString()
                    });
                }
            }

            return listaCategorias;
        }
        public static string ObtCat(int idCategoria)

        {
            Conectar capaDatos = new Conectar();
            return capaDatos.ObtenerCategoria(idCategoria);
        }


        public static void ModificacionEmpleado(int idTrabajadorUPD, int idCategoriaUPD, string NombreUPD, string ApellidoUPD, int DNIUPD, string ContraseñaUPD, int CelularUPD)
        {
            try
            {
                Vehiculo.ModificarVehiculo(idTrabajadorUPD, idCategoriaUPD, NombreUPD, ApellidoUPD, DNIUPD, ContraseñaUPD, CelularUPD);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la validación de datos: {ex.Message}");
            }
        }
        public static void EstadoEmpleado(int idTrabajador)
        {
            try
            {
                Empleados.CambiarEstado(idTrabajador);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cambiar el estado:{ex.Message}");
            }


        }
        public static Dictionary<int, string> ObtenerCategoriasEmpleados()
        {
            List<Empleados> listaCategorias = Empleados.ObtenerCategoriasEmp();
            Dictionary<int, string> CategoriasEmpleados = new Dictionary<int, string>();

            foreach (var cat in listaCategorias)
            {
                CategoriasEmpleados.Add(cat.idCategoria, $"{cat.NombreCat}");
            }

            return CategoriasEmpleados;
        }

    }
    #endregion

    #region cliente
    public class Validarcliente : Clientes
    {
        public static void AgregarUnCliente(string NomCliente, string ApeCliente, string RazSocCliente, int ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, int Telefonocl, int CondicionIVA)
        {
            Clientes.CargadeClientes(NomCliente, ApeCliente, RazSocCliente, ClaveCliente, LocalidadCL, CalleCliente, NumeracionCl, Telefonocl, CondicionIVA);
        }

        public static Dictionary<int, string> ObtenerCondicionesiva()
        {
            List<Clientes> listaCondiciones = Clientes.ObtenerCondiciones();
            Dictionary<int, string> CondicionesProcesadas = new Dictionary<int, string>();

            foreach (var cond in listaCondiciones)
            {
                CondicionesProcesadas.Add(cond.IdCondicionIva, $"{cond.descripcionIva}");
            }

            return CondicionesProcesadas;
        }

        public static DataTable ObtenerClientes()
        {
            Conectar capaDatos = new Conectar();
            DataTable TablaClientes = capaDatos.BuscarClientes();
            return TablaClientes;
        }
    }




    #endregion

    #region vehiculo
    public class ValidarClientes : Vehiculo
    {
        public static Dictionary<int, string> ObtenerClientesProcesados()
        {
            List<Vehiculo> listaClientes = Vehiculo.ObtenerClientes();
            Dictionary<int, string> clientesProcesados = new Dictionary<int, string>();

            foreach (var cliente in listaClientes)
            {
                clientesProcesados.Add(cliente.IdCliente, $"{cliente.NombreCliente} {cliente.ApellidoCliente}");
            }

            return clientesProcesados;
        }

        public static void AgregarUnVehiculo(int id, string Modelo, string Marca, int año, string Patente, float Kilometraje)
        {
            Vehiculo.CargaDeVehiculos(id, Modelo, Marca, año, Patente, Kilometraje);
        }
        public static DataTable BuscarVehiculos()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasVehiculos = CapaDatos.BuscarVehiculos();
            return TablasVehiculos;

        }
        public static string ObtNomCliente(int idCliente)

        {
            Conectar capaDatos = new Conectar();
            return capaDatos.ObtenerCliente(idCliente);
        }
        public static void ModificacionVehiculo(int idVehiculo, int idCliente, string modelo, string marca, int año, string patente, int kilometraje)
        {
            try
            {
                Vehiculo.ModificarVehiculo(idVehiculo, idCliente, modelo, marca, año, patente, kilometraje);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la validación de datos: {ex.Message}");
            }
        }


    }


    #endregion

    #region empresa
    public class CargaEmpresa : Empresa
    {
        public static void AgregarUnaEmpresa(string RazonSocial, string ClaveIdent, string Domicilio, string CondicionIVA, string PuntodVenta)
        {
            Empresa.DatosEmpresa.CargaDeEmpresa(RazonSocial, ClaveIdent, Domicilio, CondicionIVA, PuntodVenta);
        }


    }
    #endregion

    #region Producto
    public class ValidarProducto : Producto
    {
        public static void AgregarUnProducto(string NombreProducto, string MarcaProducto, int CategoriaProducto, string CodigoProducto, string DescripcionProducto, int CantidadProducto, double PrecioLista, double PrecioVenta, double LitrosDisponibles)
        {
            
            Productos.CargaProductos(NombreProducto, MarcaProducto, CategoriaProducto, CodigoProducto.Trim(), DescripcionProducto, CantidadProducto, PrecioLista, PrecioVenta, LitrosDisponibles);
        }

        public static DataTable TraeProductos()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasDeLaBD = CapaDatos.BuscarProductos();
            return TablasDeLaBD;

        }
        public static DataTable TraeCategoriasProductos()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasDeLaBD = CapaDatos.TraerCategorias();
            return TablasDeLaBD;

        }

        public static void UpdateProductos(int IdProdUPD, string Nombreprd , string marca, int categoria, string codigoproducto, string descripcion, int cantidad, int preciolista, int precioventa, double litraje)
        {
            Producto.UpdateProductos(IdProdUPD, Nombreprd.ToUpper().Trim(), marca.ToUpper().Trim(), categoria, codigoproducto.ToUpper().Trim(), descripcion.ToUpper().Trim(), cantidad, preciolista, precioventa, litraje);
        }

        public static void EliminarProducto(int IdProd, string valor)
        {
            Producto.EliminarProducto(IdProd, valor);

        }
        


    }
    public class ValidaCategoriasProducto : Categorias
    {
        public static Dictionary<int, string> ObtenerCategoriasProductos()
        {
            List<Categorias> listaCategorias = Categorias.ObtenerCategorias();
            Dictionary<int, string> CategoriasProcesadas = new Dictionary<int, string>();

            foreach (var cat in listaCategorias)
            {
                CategoriasProcesadas.Add(cat.IdCategorias, $"{cat.NombreCategoria}");
            }

            return CategoriasProcesadas;
        }
        public static int ChequeaLiquido(int Id)
        {
            int valor = Categorias.ChequeaLiquido(Id);
           return valor; 
        }

        public static void IngresaCategoria(string nombreCat, string catedescripcion, string estado, string liquido)
        {
            ValidaCategoriasProducto.IngresaCatergorias(nombreCat, catedescripcion, estado, liquido);
        }

        public static void UpdateCategoria(int IdCategoriaUPD, string NombreCategoria, string Descripcion, string Estado, string liquido)
        {
            Categorias.UpdateCatergorias(IdCategoriaUPD, NombreCategoria, Descripcion, Estado, liquido);
        }


        public static void CambiarEstado(int IdCategoriaUPD, string estado)
        {
            Categorias.CambiarEstado(IdCategoriaUPD, estado);

        }
        
    }
    #endregion

}
