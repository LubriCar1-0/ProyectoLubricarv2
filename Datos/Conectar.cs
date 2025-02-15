﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Datos
{
    public class Conectar
    {
        #region ConexionBD
        DataTable dt = new DataTable();
        SqlDataReader leer;
        public static SqlCommand comando = new SqlCommand();
        public static SqlConnection conexion = new SqlConnection("server= localhost\\SQLEXPRESS; database= LubriCarTest; integrated security = true");
        private static void conectar()
        {
            conexion.Open();
        }

        private static void desconectar()
        {
            conexion.Close();
        }
        #endregion

        #region Empleados
        public DataTable BuscarEmpleados()
        {
            conectar();
            comando.Parameters.Clear();
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);

            desconectar();
            return dt;
        }
        public static void AgregarEmpleados(string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int idCategoria, string Estado)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "InsertarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Documento", Documento);
            comando.Parameters.AddWithValue("@Contraseña", Contraseña);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@categoria", idCategoria);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();

        }

        public DataTable TraerTablaCategorias()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerelIDCAT";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            comando.Parameters.Clear();
            desconectar();
            return dt;
        }
        public int TraeId(int documento)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "BuscaIdEmp";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@documento", documento);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Parameters.Clear();
            desconectar();
            return id;
            
        }
        public int TraeIdCategoriaEmpleado(int documento)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraeIdCategoriaEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@documento", documento);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Parameters.Clear();
            desconectar();
            return id;
           
        }

        public string BuscarEmp(int Idtrabajador)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "BuscarEmp";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idTrabajador", Idtrabajador);
            string Usuario = Convert.ToString(comando.ExecuteScalar());
            comando.Parameters.Clear();
            desconectar();
            return Usuario;
           
        }
        public string ObtenerCategoria(int idCat)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "ObtenerNomCat";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idCategoria", idCat);
            string Categoria = Convert.ToString(comando.ExecuteScalar());
            comando.Parameters.Clear();
            desconectar();
            return Categoria;
        }
        public static void ActualizarEmpleado(int idTrabajadorUPD, int idCategoriaUPD, string NombreUPD, string ApellidoUPD, int DNIUPD, string ContraseñaUPD, int CelularUPD)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "ActualizarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idTrabajador", idTrabajadorUPD);
            comando.Parameters.AddWithValue("@NomTR", NombreUPD);
            comando.Parameters.AddWithValue("@ApeTR", ApellidoUPD);
            comando.Parameters.AddWithValue("@documentoTR", DNIUPD);
            comando.Parameters.AddWithValue("@contraseñaTR", ContraseñaUPD);
            comando.Parameters.AddWithValue("@telefonoTR", CelularUPD);
            comando.Parameters.AddWithValue("@idCategoria", idCategoriaUPD);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        public static void EstadoEmpleado(int idTrabajador, string Estado)
        {
            conectar();
            comando.Parameters.Clear();
            comando.Connection = conexion;
            comando.CommandText = "CambiarEstado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idTrabajador", idTrabajador);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
            

        }

        public DataTable TraerCategoriasEmpleados()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerCategoriasEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            comando.Parameters.Clear();
            desconectar();
            return dt;
            
        }

        public static void IngresaCategoriaEMP(string nombreCat, string catedescripcion, int CodPerm, string Estado)
        {
            DateTime fechaHoraActual = DateTime.Now;
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "IngresaCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NomCat", nombreCat);
            comando.Parameters.AddWithValue("@PermisoCat", CodPerm);
            comando.Parameters.AddWithValue("@Descripcion", catedescripcion);
            comando.Parameters.AddWithValue("@ESTADO", Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
            
        }

        public static void UpdateCategoriaEMP(int idCategoria, string NombreCat, int PermisoCat, string Descripcion)
        {
            
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "UpdateCategoriaEMP";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@NombreCat", NombreCat);
            comando.Parameters.AddWithValue("@PermisoCat", PermisoCat);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
            
        }
        public static void CambiarEstadoEMP(int idCategoria, string Estado)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "CambiarEstadoEMP";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }

        


        public static int VerificaPermiso(int verificaPermiso) 
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "VerificaPermiso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdCategoria", verificaPermiso);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Parameters.Clear();
            desconectar();
            return id;
            /* create procedure VerificaPermiso(
               @IdCategoria int)
               as begin 
               select PermisoCat from Categorias where IdCategoria = @IdCategoria;
               end*/




        }
        #endregion

        #region Clientes/Vehiculos
        public DataTable BuscarClientes()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear(); 
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
        }

        public string TraerCodindionIva(int IdCondicionIVA)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerCondicionIVA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idCondicionIva", IdCondicionIVA);
            string Condicion = Convert.ToString(comando.ExecuteScalar());
            comando.Parameters.Clear();
            desconectar();
            return Condicion;

        }

        /*CREATE PROCEDURE TraerCondicionIVA
              @idCondicionIva INT
              AS
             BEGIN
                SELECT descripcion
                FROM CondicionIva
                WHERE idCondicionIva = @idCondicionIva;
             END;*/
        public DataTable TraerCondicionesIva()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerCondiciones";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
            /*  Create procedure TraerCondiciones
                as
                begin
                select * from CondicionIva
                end*/
        }
        public DataTable BuscarVehiculos()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaVehiculos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear(); 
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
        }

        //create procedure TraerTablaVehiculos
        //as begin
        //select * from Vehiculo
        //end

        public static void AgregarCliente(string NomCliente, string ApeCliente, string RazSocCliente, int ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, int Telefonocl, int CondicionIVA, string Estado)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreCL", NomCliente);
            comando.Parameters.AddWithValue("@ApellidoCL", ApeCliente);
            comando.Parameters.AddWithValue("@RazSocialCL", RazSocCliente);
            comando.Parameters.AddWithValue("@ClaveIdenCL", ClaveCliente);
            comando.Parameters.AddWithValue("@LocalidadCliente", LocalidadCL);
            comando.Parameters.AddWithValue("@CalleCL", CalleCliente);
            comando.Parameters.AddWithValue("@NumeracionCL", NumeracionCl);
            comando.Parameters.AddWithValue("@TelefonoCL", Telefonocl);
            comando.Parameters.AddWithValue("@IDCondicionIVACL", CondicionIVA);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }

        public static void ActualizarCliente(int idcliente, string NomCliente, string ApeCliente, string RazSocCliente, int ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, int Telefonocl, int CondicionIVA)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "UpdateCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Idcliente", idcliente);
            comando.Parameters.AddWithValue("@NombreCL", NomCliente);
            comando.Parameters.AddWithValue("@ApellidoCL", ApeCliente);
            comando.Parameters.AddWithValue("@RazSocialCL", RazSocCliente);
            comando.Parameters.AddWithValue("@ClaveIdenCL", ClaveCliente);
            comando.Parameters.AddWithValue("@LocalidadCliente", LocalidadCL);
            comando.Parameters.AddWithValue("@CalleCL", CalleCliente);
            comando.Parameters.AddWithValue("@NumeracionCL", NumeracionCl);
            comando.Parameters.AddWithValue("@TelefonoCL", Telefonocl);
            comando.Parameters.AddWithValue("@IDCondicionIVACL", CondicionIVA);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        public static void EstadoCliente(int idCliente, string Estado)
        {
            conectar();
            comando.Parameters.Clear();
            comando.Connection = conexion;
            comando.CommandText = "CambiarEstadoCL";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }

        public static void AgregarVehiculo(int id, string Modelo, string Marca, int año, string Patente, int Kilometraje, string Estado)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "InsertarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", id);
            comando.Parameters.AddWithValue("@modeloVH", Modelo);
            comando.Parameters.AddWithValue("@marcaVH", Marca);
            comando.Parameters.AddWithValue("@añoVH", año);
            comando.Parameters.AddWithValue("@patenteVH", Patente);
            comando.Parameters.AddWithValue("@kilometrajeVH", Kilometraje);
            comando.Parameters.AddWithValue("@ESTADO", Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        

        public string ObtenerCliente(int idCliente)
        {
            string nombreCompleto = string.Empty;

            try
            {
                conectar();
                comando.Connection = conexion;
                comando.CommandText = "ObtenerCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idCliente", idCliente);

                leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    string nombreCliente = leer["Nombre"].ToString();
                    string apellidoCliente = leer["Apellido"].ToString();


                    nombreCompleto = $"{nombreCliente} {apellidoCliente}";
                }

                desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente: " + ex.Message);
            }

            return nombreCompleto;
        }

        
        public static void ActualizarVehiculo(int idVehiculo, int idCliente, string modelo, string marca, int año, string patente, int kilometraje)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "ActualizarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idVehiculo", idVehiculo);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@modeloVH", modelo);
            comando.Parameters.AddWithValue("@marcaVH", marca);
            comando.Parameters.AddWithValue("@añoVH", año);
            comando.Parameters.AddWithValue("@patenteVH", patente);
            comando.Parameters.AddWithValue("@kilometrajeVH", kilometraje);
            comando.ExecuteNonQuery();
            desconectar();
        }

        

        public static void EstadoVehiculo(int idVehiculo, string Estado)
        {
            conectar();
            comando.Parameters.Clear();
            comando.Connection = conexion;
            comando.CommandText = "CambiarEstadoVH";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idVehiculo", idVehiculo);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
            

        }

        #endregion

        #region Empresa
        public DataTable BuscarEmpresa()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaEmpresa";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
            /*CREATE PROCEDURE TraerTablaEmpresa
              AS BEGIN
              SELECT * FROM Empresa;
              END
            */
        }
        public static DataTable TraerEmpresa()
        {
            DataTable dt = new DataTable();
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaEmpresa";
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
            /*CREATE PROCEDURE TraerTablaEmpresa
              AS BEGIN
              SELECT * FROM Empresa;
              END
            */
        }
        public static void AgregarEmpresa(string RazonSocial, string ClaveIdent, string Domicilio, string CondicionIVA, string PuntodVenta)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "AgregarEmpresa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@RazSocial", RazonSocial);
            comando.Parameters.AddWithValue("@ClaveIdentif", ClaveIdent);
            comando.Parameters.AddWithValue("@Domicilio", Domicilio);
            comando.Parameters.AddWithValue("@CondicionIVA", CondicionIVA);
            comando.Parameters.AddWithValue("@PuntoVenta", PuntodVenta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
            /*create procedure AgregarEmpresa(
            @RazSocial char(255),
            @ClaveIdentif nvarchar(50),
            @Domicilio nvarchar(255),
            @CondicionIVA nvarchar(50),
            @PuntoVenta nvarchar(50))
            as begin 
            insert into Empresa(razonSocialEMP,claveIdenEMP,domicilioEMP,condicionIvaEMP,ptoVentaEMP) 
            values (@RazSocial,@ClaveIdentif,@Domicilio,@CondicionIVA,@PuntoVenta)
            end*/
        }




        public static void AgregarBitacora(int IdTrabajador, string Trabajador, string detalle)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "AgregarBitacora";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idTrabajador", IdTrabajador);
            comando.Parameters.AddWithValue("@Trabajador", Trabajador);
            comando.Parameters.AddWithValue("@Detalle", detalle);
            comando.Parameters.AddWithValue("@Fecha", DateTime.Now.Date);
            comando.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
            /*create procedure AgregarBitacora(
            @idTrabajador int,
            @Trabajador nvarchar(255),
            @Detalle nvarchar(255),
            @Fecha Date,
            @Time time)
            as begin
            insert into Bitacora(idTrabajador, Trabajador, Detalle, Fecha, Hora) values(@idTrabajador, @Trabajador, @Detalle, @Fecha, @Time)
            end*/
        }




        #endregion

        #region Productos
        public static void AgregarProducto(string NombreProducto, string MarcaProducto, int CategoriaProducto, string CodigoProducto, string DescripcionProducto, int CantidadProducto, double PrecioLista, double PrecioVenta, double LitrosDisponibles,double litroMin, int cantidadmin, string estado)
        {
            DateTime fechaHoraActual = DateTime.Now;
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "AgregarProduc";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nomproducto", NombreProducto);
            comando.Parameters.AddWithValue("@MarcaProduc", MarcaProducto);
            comando.Parameters.AddWithValue("@CategoriaProduc", CategoriaProducto);
            comando.Parameters.AddWithValue("@CodigoProduc", CodigoProducto);
            comando.Parameters.AddWithValue("@DescripcionProduc", DescripcionProducto);
            comando.Parameters.AddWithValue("@CantidadProduc", CantidadProducto);
            comando.Parameters.AddWithValue("@PrecioLista", PrecioLista);
            comando.Parameters.AddWithValue("@PrecioVenta", PrecioVenta);
            comando.Parameters.AddWithValue("@LitrosDisponibles", LitrosDisponibles);
            comando.Parameters.AddWithValue("@Minlitro", litroMin);
            comando.Parameters.AddWithValue("@Minimo", cantidadmin);
            comando.Parameters.AddWithValue("@Estado", estado); 
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();

            /*create procedure AgregarProduc(
            @Nomproducto char(60),
            @MarcaProduc char(60),
            @CategoriaProduc int,
            @CodigoProduc Char(5),
            @DescripcionProduc char(255),
            @CantidadProduc int,
            @PrecioLista Decimal,
            @PrecioVenta Decimal,
            @LitrosDisponibles decimal,
			@Minlitro Decimal,
			@Minimo int,
            @Estado char(3))
            as begin
            Insert into Producto(Nombre, Marca, IdCategorias, CodProd, Descripcion, Cantidad, Precio_lista, PrecioVenta, LitrosDisp,CantidadMinima,LitrosMinimo, estado) values(@Nomproducto, @MarcaProduc, @CategoriaProduc, @CodigoProduc, @DescripcionProduc, @CantidadProduc, @PrecioLista, @PrecioVenta, @LitrosDisponibles,@Minimo,@Minlitro, @Estado)
            end

            /*CREATE TABLE [dbo].[Producto](
              [idProd] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
              [Nombre] [nvarchar](60) NOT NULL,
              [Marca] [nvarchar](60) NULL,
              [Categoria] [nvarchar](60) NULL,
              [CodProd] [int] NOT NULL,
              [Descripcion] [nvarchar](255) NULL,
              [Cantidad] [int] NULL,
              [Precio_lista] [decimal](10, 2) NULL,
              [PrecioVenta] [decimal](10, 2) NULL,
              [LitrosDisp] [decimal](10, 2) NULL,
            
            alter table producto 
            add Estado char(3)
             
             EXEC sp_rename 'Producto.IdCategoria', 'IdCategorias', 'COLUMN';
             
             */



        }
        public DataTable BuscarProductos()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
            /*  create procedure TraerTablaProductos
                as begin 
                select * from Producto;
                end*/
        }

        public static void IngresaCategoria(string nombreCat, string catedescripcion, string estado, string liquido)
        {
            DateTime fechaHoraActual = DateTime.Now;
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "IngresaCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombreCat);
            comando.Parameters.AddWithValue("@Descripcion", catedescripcion);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@FechaCreacion", fechaHoraActual);
            comando.Parameters.AddWithValue("@Liquido", liquido);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
            /*create procedure IngresaCategoria(
            @Nombre char(30),
            @Descripcion char(144),
            @Estado char (3),
            @FechaCreacion DateTime)
            as begin 
            Insert into CategoriasProductos (NombreCategoria, Descripcion, Estado, FechaCreacion) values (@Nombre,@Descripcion, @Estado,@FechaCreacion)
            end
            */
        }

        public DataTable TraerCategorias()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaCategoriasProducto";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
            /*  create procedure TraerTablaCategoriasProducto
                as begin 
                select * from CategoriasProductos;
                end*/
        }
        public DataTable TraerCategoriasActivas()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerCategoriasActivas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
            /*  create procedure TraerCategoriasActivas
                as begin 
                select * from CategoriasProductos where Estado= 'ACT';
                end*/
        }
        public static void UpdateCategorias(int IdCategoriaUPD,string NombreCategoria, string Descripcion, string Estado, string liquido)
         {
            DateTime fechaHoraActual = DateTime.Now;
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "UpdateCategorias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdCategoria", IdCategoriaUPD);
            comando.Parameters.AddWithValue("@Nombre", NombreCategoria);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.Parameters.AddWithValue("@FechaActualizacion", fechaHoraActual);
            comando.Parameters.AddWithValue("@Liquido", liquido);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
            /*CREATE PROCEDURE UpdateCategoria
                @IdCategoria INT,
                @Nombre CHAR(30),
                @Descripcion CHAR(144),
                @Estado CHAR(3),
                @FechaModificacion DATETIME
            AS
            BEGIN
                UPDATE CategoriasProductos
                SET 
                    NombreCategoria = @Nombre,
                    Descripcion = @Descripcion,
                    Estado = @Estado,
                    FechaModificacion = @FechaModificacion
                WHERE 
                    IdCategoria = @IdCategoria;
            END
            */
        }

        public static int TraeLiquido(int Id)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "ChequeaLiquido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Id", Id);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            //comando.Parameters.Clear();
            desconectar();
            return id;
            /* create procedure ChequeaLiquido(
            @Id int)
            as begin 
            select COUNT(*) from CategoriasProductos where IdCategorias = @Id and Liquido = 'S';
            end*/
        }

        public static int BuscaDuplicadoProducto(string nombre, string marca, int cat)
        {
            conectar();
            comando.Connection = conexion;
            comando.Parameters.Clear();
            comando.CommandText = "BuscaDuplicadoProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre.Trim());
            comando.Parameters.AddWithValue("@marca", marca.Trim());
            comando.Parameters.AddWithValue("@categoria", cat);
            int valor = Convert.ToInt32(comando.ExecuteScalar());
            comando.Parameters.Clear();
            desconectar();
            return valor;
            /* cREATE PROCEDURE BuscaDuplicadoProductos
              @nombre char (60),
	          @marca char(60),
	          @categoria int
              AS
              BEGIN
              select count(*) from Producto where  Nombre= @nombre and Marca=@marca and IdCategoria = @categoria
              END;*/
        }
        public static void UpdateProductos(int IdProdUPD, string Nombreprd, string MarcaProducto, int categoria, string codigoproducto, string descripcion, int cantidad, int preciolista, int precioventa, double litraje, double litrajeMin, int cantidadmin)
        {
            DateTime fechaHoraActual = DateTime.Now;
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "UpdateProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProducto" , IdProdUPD);
            comando.Parameters.AddWithValue("@Nomproducto", Nombreprd);
            comando.Parameters.AddWithValue("@MarcaProduc", MarcaProducto);
            comando.Parameters.AddWithValue("@CategoriaProduc", categoria);
            comando.Parameters.AddWithValue("@CodigoProduc", codigoproducto);
            comando.Parameters.AddWithValue("@DescripcionProduc", descripcion);
            comando.Parameters.AddWithValue("@CantidadProduc", cantidad);
            comando.Parameters.AddWithValue("@PrecioLista", preciolista);
            comando.Parameters.AddWithValue("@PrecioVenta", precioventa);
            comando.Parameters.AddWithValue("@LitrosDisponibles", litraje);
            comando.Parameters.AddWithValue("@Minlitro", litrajeMin);
            comando.Parameters.AddWithValue("@Minimo", cantidadmin);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();

            /* CREATE PROCEDURE UpdateProductos
                (
                    @IdProducto INT,
                    @Nomproducto CHAR(60),
                    @MarcaProduc CHAR(60),
                    @CategoriaProduc INT,
                    @CodigoProduc CHAR(5),
                    @DescripcionProduc CHAR(255),
                    @CantidadProduc INT,
                    @PrecioLista DECIMAL(18, 2),
                    @PrecioVenta DECIMAL(18, 2),
                    @LitrosDisponibles decimal,
			        @Minlitro Decimal,
			        @Minimo int)
                )
                AS
                BEGIN
                    UPDATE Producto -- Cambié de CategoriasProductos a Productos
                    SET 
                        Nombre = @Nomproducto,
                        Marca = @MarcaProduc,
                        IdCategorias = @CategoriaProduc,
                        CodProd = @CodigoProduc,
                        Descripcion = @DescripcionProduc,
                        Cantidad = @CantidadProduc,
                        Precio_lista = @PrecioLista,
                        PrecioVenta = @PrecioVenta,
                        LitrosDisp = @LitrosDisponibles,
                        CantidadMinima =@Minimo,
                        LitrosMinimo= @Minlitro
                    WHERE 
                        IdProd = @IdProducto; -- Condición para actualizar el producto con ese Id
                END */
        }

        public static void EliminarProducto(int IdProd, string valor)
        {
           
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "EliminarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProducto", IdProd);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
            /*CREATE PROCEDURE EliminarProductos
            (
                @IdProducto INT,
                @Valor char(3)
            )
            AS
            BEGIN
                UPDATE Producto --Cambié de CategoriasProductos a Productos
                SET
                    Estado = @Valor
                WHERE
                    IdProd = @IdProducto; --Condición para actualizar el producto con ese Id
            END
            */

        }

        public static void CambiarEstado(int IdCategoriaUPD, string valorNuevo)
        {
            DateTime fechaHoraActual = DateTime.Now;
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "CambiarEstado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdCategorias", IdCategoriaUPD);
            comando.Parameters.AddWithValue("@valor", valorNuevo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
            /*CREATE PROCEDURE CambiarEstado
            (
                @IdCategorias INT,
                @Valor char(3)
            )
            AS
            BEGIN
                UPDATE CategoriasProductos 
                SET
                    Estado = @Valor
                WHERE
                    IdCategorias = @IdCategorias; 
            END
            */



        }
        public static void ControlStock(int IdProd, int cantidad, double preciolista, double precioventa, double litraje, double litrajeMin, int cantidadmin)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "Controlstock";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProducto", IdProd);
            comando.Parameters.AddWithValue("@CantidadProduc", cantidad);
            comando.Parameters.AddWithValue("@PrecioLista", preciolista);
            comando.Parameters.AddWithValue("@PrecioVenta", precioventa);
            comando.Parameters.AddWithValue("@LitrosDisponibles", litraje);
            comando.Parameters.AddWithValue("@Minlitro", litrajeMin);
            comando.Parameters.AddWithValue("@Minimo", cantidadmin);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        public DataTable ControlStockFiltro(string codigo)
        {


            conectar();
            comando.Connection = conexion;
            comando.CommandText = "FiltroStock";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@codigo", codigo);
            leer = comando.ExecuteReader();
            dt.Load(leer);

            desconectar();
            return dt;
        }



        #endregion

        #region Turnos  
        public DataTable BuscarVehiculosPorCliente(int idCliente)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerVehiculosPorCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
            
        }

        

        public void InsertarTurno(DateTime fecha, TimeSpan hora, int idCliente, int idVehiculo, string descripcion, string estado)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "InsertarTurno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Fecha", fecha);
            comando.Parameters.AddWithValue("@Hora", hora);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@idVehiculo", idVehiculo);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.ExecuteNonQuery();
            desconectar();
        }
        public string ObtenerVehiculo(int idVH)
        {
            string Automovil = string.Empty;

            try
            {
                conectar();
                comando.Connection = conexion;
                comando.CommandText = "ObtenerVehiculo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idVehiculo", idVH);

                leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    string ModeloVH = leer["modeloVH"].ToString();
                    string MarcaVH = leer["marcaVH"].ToString();


                    Automovil = $"{ModeloVH} {MarcaVH}";
                }

                desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el Vehiculo: " + ex.Message);
            }

            return Automovil;
        }
        public static void ActualizarTurno(int idTurno, int idVehiculoUPD, int idClienteUPD, DateTime fechaupd, TimeSpan horaupd, string DescUPD)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "ActualizarTurno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idTurno", idTurno);
            comando.Parameters.AddWithValue("@idVehiculo", idVehiculoUPD);
            comando.Parameters.AddWithValue("@idCliente", idClienteUPD);
            comando.Parameters.AddWithValue("@Fecha", fechaupd);
            comando.Parameters.AddWithValue("@Hora", horaupd);
            comando.Parameters.AddWithValue("@descripcion", DescUPD);
            comando.ExecuteNonQuery();
            desconectar();
        }
        public bool ExisteTurno(DateTime fecha, TimeSpan hora)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "ExisteTurno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Fecha", fecha.Date); 
            comando.Parameters.AddWithValue("@Hora", hora);       
            comando.Parameters.AddWithValue("@Estado", "ACT");     

            int count = Convert.ToInt32(comando.ExecuteScalar());
            desconectar();

            return count > 0; // Si count > 0, el turno ya existe
        }
        public static void CancelarTurno(int idTurno, string Estado)
        {
            conectar();
            comando.Parameters.Clear();
            comando.Connection = conexion;
            comando.CommandText = "CancelarTurno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idTurno", idTurno);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
           

        }

        public DataTable TurnosFiltro(string telefono, string patente, string fecha)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TurnosConFiltro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@telefono", !string.IsNullOrEmpty(telefono) ? (object)telefono : DBNull.Value);
            comando.Parameters.AddWithValue("@patente", !string.IsNullOrEmpty(patente) ? (object)patente : DBNull.Value);
            comando.Parameters.AddWithValue("@fecha", !string.IsNullOrEmpty(fecha) ? (object)fecha : DBNull.Value);
            leer = comando.ExecuteReader();
            dt.Load(leer);
            leer.Close();
            desconectar();
            return dt;
        }

        public DataTable TurnosActivos()
        {
            conectar();  
            comando.Connection = conexion;
            comando.CommandText = "TurnosSinFiltro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leer = comando.ExecuteReader();
            dt.Load(leer);
            leer.Close();
            desconectar(); 
            return dt;
        }

        public int ObtenerIDCliente(int Telefono)
        {
            int idCliente = -1; // Valor por defecto en caso de no encontrar resultados
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "ObtenerIDCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            leer = comando.ExecuteReader();
            if (leer.Read()) // Verifica si hay resultados
            {
                 idCliente = leer.GetInt32(0); // Obtiene el primer valor del resultado (idCliente)
            }
            leer.Close();
            desconectar();
            return idCliente;
        }
        public DataTable TurnosFiltroPorPatente(int idCliente, string patente, string fecha)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "FiltrarTurnosPorPatente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idCliente", idCliente != -1 ? (object)idCliente : DBNull.Value);
            comando.Parameters.AddWithValue("@patente", !string.IsNullOrEmpty(patente) ? (object)patente : DBNull.Value);
            comando.Parameters.AddWithValue("@fecha", !string.IsNullOrEmpty(fecha) ? (object)fecha : DBNull.Value);
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
        }


        #endregion

        #region Ventas
        #region tablas Clientes/Productos
        public DataTable VentaClientes()
        {
            conectar();
            comando.Parameters.Clear();
            comando.Connection = conexion;
            comando.CommandText = "TablaClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);

            desconectar();
            return dt;
        }
        public DataTable VentaClientesFiltro(int dni)
        {
            conectar();
            comando.Connection = conexion;
            comando.Parameters.Clear();
            comando.CommandText = "TraerTablaClientesConfiltro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DNI",dni);
            leer = comando.ExecuteReader();
            dt.Load(leer);

            desconectar();
            return dt;
        }
        public DataTable VentaProductos()
        {
            conectar();
            comando.Parameters.Clear();
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaProductosACT";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);

            desconectar();
            return dt;
        }
        public DataTable VentaProductosFiltro(int IdCategoria, string codigo, string nombre)
        {            
                conectar();
                comando.Connection = conexion;
                comando.CommandText = "TablaProductossConFiltro";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@IdCategoria", IdCategoria);
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@nombre", nombre);
                leer = comando.ExecuteReader();
                dt.Load(leer);

                desconectar();                          
            return dt;
        }
        #endregion

        #region CargaVenta
        public static void AgregaVenta(int IdCliente, int fila, string producto,double preciounit, double cantidad, double total)
        {
            DateTime fechaHoraActual = DateTime.Now;
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "AgregarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            comando.Parameters.AddWithValue("@FilaImpresion", fila);
            comando.Parameters.AddWithValue("@Producto", producto);
            comando.Parameters.AddWithValue("@PrecioUnitario", preciounit);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@PrecioTotal", total);
            comando.Parameters.AddWithValue("@FechaVenta", fechaHoraActual);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();


            /*CREATE TABLE VentaProductos (
            IdVenta NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
            IdCliente NUMERIC(18,0) NOT NULL,           
            FilaImpresion INT,       
            Producto CHAR(100),      
            PrecioUnitario FLOAT,    
            Cantidad INT,            
            PrecioTotal FLOAT,       
            FechaVenta DATETIME,     
            FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente) 
            );*/
            /*
            Create Procedure AgregarVenta(
            @IdCliente numeric(18, 0),
            @FilaImpresion int,
            @Producto char(100),
            @PrecioUnitario float,
            @Cantidad int,
            @PrecioTotal float,
            @FechaVenta datetime
            )
            as begin
            Insert into VentaProductos(IdCliente, FilaImpresion, Producto, PrecioUnitario, Cantidad, PrecioTotal, FechaVenta) values(@IdCliente, @FilaImpresion, @Producto, @PrecioUnitario, @Cantidad, @PrecioTotal, @FechaVenta)
            end
            */

        }


        public static void RestaCantidad(int idprod, double cantidad)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "DescuentaCantidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idprod", idprod);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();





        }
        public static void CargaTotalesVenta(int IdCliente, double subtotal, double iva, double total)
        {
            DateTime fechaHoraActual = DateTime.Now;
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "GuardaTotalVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            comando.Parameters.AddWithValue("@IvaCalculado", iva);
            comando.Parameters.AddWithValue("@SubTotal", subtotal);
            comando.Parameters.AddWithValue("@Total", total);
            comando.Parameters.AddWithValue("@FechaHora", fechaHoraActual);
            comando.ExecuteNonQuery();
            desconectar();
        }

        #endregion

        #endregion

        #region Bitacora  
        public DataTable Bitacora()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "BuscarBitacora";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leer = comando.ExecuteReader();
            dt.Load(leer);
            leer.Close();
            desconectar();
            return dt;
        }
        public DataTable BitacoraFiltro(string accion, string Fecha, int IdTrabajador)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "BitacoraConFiltro"; 
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@accion", !string.IsNullOrEmpty(accion) ? (object)accion : DBNull.Value);
            comando.Parameters.AddWithValue("@fecha", !string.IsNullOrEmpty(Fecha) ? (object)Fecha : DBNull.Value);
            comando.Parameters.AddWithValue("@IdTrabajador", IdTrabajador > 0 ? (object)IdTrabajador : DBNull.Value);
            leer = comando.ExecuteReader();
            dt.Load(leer);
            leer.Close();
            desconectar();

            return dt;
        }


        #endregion


    }


}





