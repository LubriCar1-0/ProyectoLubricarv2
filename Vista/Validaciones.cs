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
using static Negocio.Empleados;
using System.Security.Policy;
using System.Windows.Forms;
using System.Security.Cryptography;


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
        public static DataTable TraeEmpleados()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasEmpleados = CapaDatos.BuscarEmpleados();
            return TablasEmpleados;
        }
        public static List<CategoriaEmpleado> ObtenerCategorias()
        {
            Conectar capaDatos = new Conectar();
            DataTable tablaCategorias = capaDatos.TraerTablaCategorias();
            var listaCategorias = new List<CategoriaEmpleado>();

            foreach (DataRow row in tablaCategorias.Rows)
            {
                if (row["idCategoria"] != DBNull.Value && row["NombreCat"] != DBNull.Value)
                {
                    listaCategorias.Add(new CategoriaEmpleado
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
                Empleados.ModificarEmpleado(idTrabajadorUPD, idCategoriaUPD, NombreUPD, ApellidoUPD, DNIUPD, ContraseñaUPD, CelularUPD);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la validación de datos: {ex.Message}");
            }
        }
        public static void BajaAltaEmpleado(int idTrabajador, string Estado)
        {
            try
            {
                Empleados.CambiarEstado(idTrabajador, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cambiar el estado:{ex.Message}");
            }
        }
        public static Dictionary<int, string> ObtenerCategoriasEmpleados()
        {
            List<CategoriaEmpleado> listaCategorias = CategoriaEmpleado.ObtenerCategoriasEmp();
            Dictionary<int, string> CategoriasEmpleados = new Dictionary<int, string>();

            foreach (var cat in listaCategorias)
            {
                CategoriasEmpleados.Add(cat.idCategoria, $"{cat.NombreCat}");
            }
            return CategoriasEmpleados;
        }
        public static DataTable TraeCategoriasEmpleados()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasCatEMP = CapaDatos.TraerCategoriasEmpleados();
            return TablasCatEMP;

        }
        public static void UpdateCatergoriasEmpleados(int IdCategoriaUPD, string NombreCat, int CodPerm, string DescUPD)
        {
            CategoriaEmpleado.ActualizarCategoriaEMP(IdCategoriaUPD, NombreCat, CodPerm, DescUPD);
        }

        public static void CambiarEstadoEmpleados(int idCategoria, string ESTADO)
        {
            CategoriaEmpleado.ActualizarEstadoEMP(idCategoria, ESTADO);
        }
        public DataTable VerificaPermiso()
        {
            Conectar CapaDatos = new Conectar();
            DataTable VerificaPermiso = CapaDatos.TraerCategoriasEmpleados();
            return VerificaPermiso;
        }
        public static Dictionary<int, string> ObtenerTrabajadoresProcesados()
        {
            List<Vehiculo> listaClientes = Vehiculo.ObtenerClientes();
            Dictionary<int, string> clientesProcesados = new Dictionary<int, string>();

            foreach (var cliente in listaClientes)
            {
                clientesProcesados.Add(cliente.IdCliente, $"{cliente.NombreCliente}{cliente.ApellidoCliente}");
            }

            return clientesProcesados;
        }


    }
    #endregion

    #region cliente
    public class Validarcliente : Clientes
    {
        public static void AgregarUnCliente(string NomCliente, string ApeCliente, string RazSocCliente, string ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, int Telefonocl, int CondicionIVA)
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
        public static void Modificacioncliente(int idcliente, string NomCliente, string ApeCliente, string RazSocCliente, string ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, int Telefonocl, int CondicionIVA)
        {
            try
            {
                Clientes.Actulizacliente(idcliente, NomCliente, ApeCliente, RazSocCliente, ClaveCliente, LocalidadCL, CalleCliente, NumeracionCl, Telefonocl, CondicionIVA);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la validación de datos: {ex.Message}");
            }
        }
        public static void BajaAltaCliente(int idCliente, string Estado)
        {
            try
            {
                Clientes.CambiarEstadoCliente(idCliente, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cambiar el estado:{ex.Message}");
            }
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
                clientesProcesados.Add(cliente.IdCliente, $"{cliente.NombreCliente}{","}{cliente.ApellidoCliente}");
            }

            return clientesProcesados;
        }

        public static void AgregarUnVehiculo(int id, string Modelo, string Marca, int año, string Patente, int Kilometraje)
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
        public static void BajaAltaVehiculo(int idVehiculo, string Estado)
        {
            try
            {
                Vehiculo.CambiarEstado(idVehiculo, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cambiar el estado:{ex.Message}");
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
        public static void AgregarUnProducto(string NombreProducto, string MarcaProducto, int CategoriaProducto, string CodigoProducto, string DescripcionProducto, int CantidadProducto, double PrecioLista, double PrecioVenta, double LitrosDisponibles, double litroMin, int cantidadmin, string estado, int idTrab)
        {

            Productos.CargaProductos(NombreProducto, MarcaProducto, CategoriaProducto, CodigoProducto.Trim(), DescripcionProducto, CantidadProducto, PrecioLista, PrecioVenta, LitrosDisponibles, litroMin, cantidadmin, estado, idTrab);
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

        public static void UpdateProductos(int IdProdUPD, string Nombreprd, string marca, int categoria, string codigoproducto, string descripcion, int cantidad, int preciolista, int precioventa, double litraje, double litrajeMin, int cantidadmin, int _idTrabajador)
        {
            Producto.UpdateProductos(IdProdUPD, Nombreprd.ToUpper().Trim(), marca.ToUpper().Trim(), categoria, codigoproducto.ToUpper().Trim(), descripcion.ToUpper().Trim(), cantidad, preciolista, precioventa, litraje, litrajeMin, cantidadmin, _idTrabajador);
        }

        public static void DeleteProducto(int IdProd, string valor, int _idTrabajador)
        {
            Producto.EliminarProductos(IdProd, valor, _idTrabajador);

        }

        public static void ControlStock(int IdProd, int cantidad, double preciolista, double precioventa, double litraje, double litrajeMin, int cantidadmin, int _idTrabajador)
        {
            Producto.ControlStock(IdProd, cantidad, preciolista, precioventa, litraje, litrajeMin, cantidadmin, _idTrabajador);
        }
        public static DataTable ControlStockFiltro(string codigo)
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasDeLaBD = CapaDatos.ControlStockFiltro(codigo);
            return TablasDeLaBD;

        }
        public static DataTable ObtenerProductosFaltantes()
        {
            Conectar capaDatos = new Conectar();
            return capaDatos.ProductosFaltantes();
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

        public static void IngresaCat(string nombreCat, string catedescripcion, string estado, string liquido, int _idTrabajador)
        {
            Categorias.IngresaCatergorias(nombreCat, catedescripcion, estado, liquido, _idTrabajador);
        }

        public static void UpdateCategoria(int IdCategoriaUPD, string NombreCategoria, string Descripcion, string Estado, string liquido, int _idTrabajador)
        {
            Categorias.UpdateCatergorias(IdCategoriaUPD, NombreCategoria, Descripcion, Estado, liquido, _idTrabajador);
        }


        public static void CambiarEstado(int IdCategoriaUPD, string estado, int _idTrabajador)
        {
            Categorias.CambiarEstado(IdCategoriaUPD, estado, _idTrabajador);

        }

    }
    #endregion

    #region Turnos   
    public class validarTurnos : Turnos
    {
        public static Dictionary<int, string> ObtenerVehiculosPorCliente(int idCliente)
        {
            List<Turnos> listaVehiculos = Turnos.ObtenerVehiculosPorCliente(idCliente);
            Dictionary<int, string> vehiculosProcesados = new Dictionary<int, string>();

            foreach (var vehiculo in listaVehiculos)
            {
                vehiculosProcesados.Add(vehiculo.idVehiculo, $"{vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.Patente})");
            }

            return vehiculosProcesados;
        }
        public static Dictionary<int, string> ObtenerVehiculos()
        {
            List<Turnos> listaVehiculos = Turnos.ObtenerVehiculos();
            Dictionary<int, string> vehiculosProcesados = new Dictionary<int, string>();

            foreach (var vehiculo in listaVehiculos)
            {
                vehiculosProcesados.Add(vehiculo.idVehiculo, $"{vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.Patente})");
            }

            return vehiculosProcesados;
        }
        public static void AgregarUnturno(DateTime dia, DateTime Hora, int idCliente, int idVehiculo, string Descripcion)
        {
            Turnos.CargaDeTurnos(dia, Hora, idCliente, idVehiculo, Descripcion);
        }
        public static string ObtNomVehiculo(int idVH)
        {
            Conectar capaDatos = new Conectar();
            return capaDatos.ObtenerVehiculo(idVH);
        }
        public static DataTable BuscarTurnos()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasTurnos = CapaDatos.TurnosActivos(); 
            return TablasTurnos;

        }
        public static DataTable BuscarTurnosActivos()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasTurnos = CapaDatos.TurnosFiltroActivos(); 
            return TablasTurnos;

        }
        public static void ModificacionTurno(int idTurno, int idVehiculoUPD, int idClienteUPD, DateTime fechaupd, TimeSpan horaupd, string DescUPD)
        {
            try
            {
                Turnos.ModificarTurnos(idTurno, idVehiculoUPD, idClienteUPD, fechaupd, horaupd, DescUPD);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la validación de datos: {ex.Message}");
            }
        }
        public static void CancelarTurno(int idTurno, string Estado)
        {
            try
            {
                Turnos.CancelarElTurno(idTurno, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cancelar el Turno:{ex.Message}");
            }
        }
        public static DataTable TurnosFiltro(string telefono, string patente, string fecha, string estado)
        {
            Conectar capaDatos = new Conectar();
            return capaDatos.TurnosFiltro(telefono, patente, fecha, estado);
        }

    }

    #endregion

    #region OrdenDeTrabajo
    public class ValidarOrdenDeTrabajo : OrdenDeTrabajo
    {
        public static void CrearOrden(string NombreCompleto, DateTime dia, string descripcion, int trabajadorId, int idCliente, int idVehiculo, int idTurno)
        {
            OrdenDeTrabajo.CrearOrdenDeTrabajo(NombreCompleto, dia, descripcion, trabajadorId, idCliente, idVehiculo, idTurno);
        }
        public static DataTable ObtDatosOrden(int Idturno)
        {
            Conectar capaDatos = new Conectar();
            return capaDatos.BuscarOrden(Idturno);
        }
        public static void CargaListaDeProd(int idOrden, int idprod, string Producto, int Disponible, double Litros, int Cantidad, double PrecioVenta)
        {

            OrdenDeTrabajo.cargaListaProd(idOrden, idprod, Producto, Cantidad, PrecioVenta);


        }
        public static List<OrdenDeTrabajo> ObtenerLista()
        {
            return OrdenDeTrabajo.ObtenerListaOrden();
        }
        public static DataTable OrdenesDeFiltro(string Patente, string fecha, int trabajadorId, string estado)
        {
            Conectar capaDatos = new Conectar();
            return capaDatos.OrdenesFiltro(Patente, fecha, trabajadorId, estado);
        }
        public static DataTable BuscarOrdenes()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasOrdenes = CapaDatos.OrdenesFinalizadas();
            return TablasOrdenes;

        }
        public static void CambiarEstado(int idOrden, string estado)
        {
            OrdenDeTrabajo.CambioDeEstado(idOrden, estado);
        }


    }
    #endregion

    #region venta
    public class ValidarVenta : Clientes
    {
        public static DataTable VentaClientes()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasDeLaBD = CapaDatos.VentaClientes();
            return TablasDeLaBD;

        }

        public static DataTable VentaClientesFiltro(string dni)
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasDeLaBD = CapaDatos.VentaClientesFiltro(dni);
            return TablasDeLaBD;

        }
        public static DataTable VentaProductos()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasDeLaBD = CapaDatos.VentaProductos();
            return TablasDeLaBD;

        }

        public static DataTable VentaProductosFiltro(int categoria, string codigo, string nombre)
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.VentaProductosFiltro(categoria, codigo, nombre);

            return TablasDeLaBD;

        }

        public static int TraeLiquido(int Id)
        {

            int Liquido = Conectar.TraeLiquido(Id);
            return Liquido;

        }

        public static void CargaLista(int idcliente, int idprod, string Producto, int Disponible, double Litros, int Cantidad, double PrecioVenta)
        {

            VentaProducto.cargaList(idcliente, idprod, Producto, Cantidad, PrecioVenta);


        }
        public static List<VentaProducto> ObtenerVentas()
        {
            return VentaProducto.ObtenerListaVentas();
        }

        public static double CalculaTotal()
        {
            double valor = VentaProducto.CalculaTotal();
            return valor;
        }

        public static DataTable VentasProductos()
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.TraeTodasVentasProductos();

            return TablasDeLaBD;

        }
        public static DataTable VentasProductosLista(int Id)
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.SeleccionaVentaProductos(Id);

            return TablasDeLaBD;

        }
        public static DataTable FiltroHistorialVentas(DateTime fecha, DateTime fechahasta)
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.FiltroHistorialVentas(fecha, fechahasta);

            return TablasDeLaBD;

        }

    }
    #endregion

    #region Bitacora 
    public class ValidarBitacora : MenuBitacora
    {
        public static List<Empleados> ObtenerListaTrabajadores()
        {
            return Empleados.ObtenerTrabajador(); 
        }

        public static DataTable BuscarBitacora()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasBitacora = CapaDatos.Bitacora();
            return TablasBitacora;

        }
        public static DataTable BitacoraFiltro(string accion, string fecha, int trabajadorId)
        {
            Conectar capaDatos = new Conectar();
            return capaDatos.BitacoraFiltro(accion, fecha, trabajadorId);
        }
    }

    #endregion

    #region Lubripuntos
    public class ValidarLubriPuntos : LubriPuntos
    {
        public static void AsignarLubri(int Id, double Precio, int Lubri)
        {
           LubriPuntos.AsignarLubriPuntos(Id, Precio, Lubri);
        }

        public static DataTable ObtenerValoresLubriPuntos(int ID)
        {
            Conectar capaDatos = new Conectar();
            return capaDatos.ObtenerValoresLubri(ID);
        }
        public static DataTable TraerProductos()
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasDeLaBD = CapaDatos.TraerProductos();
            return TablasDeLaBD;

        }

        public static DataTable LPproductosconfiltro(string codigo)
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.LPproductosconfiltro(codigo);

            return TablasDeLaBD;

        }
        public static DataTable CanjeosLubriPuntos()
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.hCanjeosLubriPuntos();

            return TablasDeLaBD;

        }

        public static void InsertarPuntosAProducto(int idProd, int cantidadLubriPuntos)
        {
            LubriPuntos.InsertarPuntosAProducto(idProd, cantidadLubriPuntos);
        }

        public static DataTable ObtenerListaLubrixProductos()
        {
            return LubriPuntos.ObtenerListaLubrixProductos();
        }
        public static void BajaAltaProducxlubri(int idLubrixProducto, string Estado)
        {
            try
            {
                LubriPuntos.Cambiarestadoproducxlubri(idLubrixProducto, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cambiar el estado:{ex.Message}");
            }
        }
        public static DataTable TraerClientes()
        {
            Conectar capaDatos = new Conectar();
            DataTable TablaClientes = capaDatos.BuscarClientes();
            return TablaClientes;
        }
        public static DataTable Clientesconfiltro(string dni)
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.Clientesconfiltro(dni);

            return TablasDeLaBD;

        }
        public static DataTable ObtenerProductosParaCanje()
        {
            Conectar CapaDatos = new Conectar();
            return CapaDatos.ObtenerProductosParaCanje();
        }
        public static DataTable Productosparacanjeconfiltro(string codigo)
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.FiltroProductosParaCanje(codigo);

            return TablasDeLaBD;

        }
        public static void Registrarcanje(int idCliente, int puntosCanjeados)
        {
            LubriPuntos.Registrarcanje(idCliente, puntosCanjeados);
        }

        public static DataTable FiltroCanjeosLubriPuntos(DateTime fecha, DateTime fechahasta)
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.hFiltroCanjeosLubriPuntos(fecha, fechahasta);

            return TablasDeLaBD;

        }
    }
    #endregion

    #region Venta Servicio
    public class ValidarVentaServicio : VentaServicio
    {
        public static DataTable ListaDeProductos(int idOrdenTrab)
        {
            Conectar CapaDatos = new Conectar();
            DataTable TablasDeLaBD = CapaDatos.ListaDeProdUtilizados(idOrdenTrab);
            return TablasDeLaBD;
        }
        public static void CargarVentaServicio(int idOrdenTrab, int idCliente, double ManoDeObra, double SubTotal, double IVA, double Total, int lubripuntos)
        {
            VentaServicio.CargaVenta(idOrdenTrab, idCliente, ManoDeObra, SubTotal, IVA, Total, lubripuntos);
        }
        public static DataTable TraerLaTablaVentServ ()
        {
            Conectar capaDatos = new Conectar();
            DataTable TablasDeLaBD = capaDatos.TraerTablaVentaServ();
            return TablasDeLaBD;
        }
        public static DataTable VentaServicios()
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.TraeTodasVentasServicios();

            return TablasDeLaBD;

        }
        public static DataTable VentaServProductos(int Id)
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.VentaServiciosProductos(Id);

            return TablasDeLaBD;

        }
        public static DataTable FiltroHistorialDeVentServ(DateTime fecha, DateTime fechahasta)
        {
            DataTable TablasDeLaBD = new DataTable();
            Conectar CapaDatos = new Conectar();
            TablasDeLaBD = CapaDatos.FiltroHistorialVentaServ(fecha, fechahasta);

            return TablasDeLaBD;

        }
    }

    #endregion

}






