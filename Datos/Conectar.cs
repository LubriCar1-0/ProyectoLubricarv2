using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Datos
{
    public class Conectar
    {
        #region ConexionBD
        DataTable dt = new DataTable();
        SqlDataReader leer;
        public static SqlCommand comando = new SqlCommand();
        public static SqlConnection conexion = new SqlConnection("server= localhost\\SQLEXPRESS; database= Lubri-CarBD Test; integrated security = true");
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
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;
        }
        public static void AgregarEmpleados(string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int idCategoria)
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
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();

        }

        public DataTable TraerTablaCategorias()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaCategorias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
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
            /* create procedure BuscaIdEmp(
               @documento int)
               as begin 
               select idTrabajador from Trabajador where documentoTR=@documento;
               end*/
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
            /*  create procedure BuscarEmp(
                @idtrabajador int)
                as begin 
                select NomTR from Trabajador where idTrabajador=@idtrabajador;
                end*/
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
            desconectar();
        }
        public static void EstadoEmpleado(int idTrabajador, string Estado)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "EstadoEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idTrabajador", idTrabajador);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.ExecuteNonQuery();
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
            desconectar();
            return dt;
            /*  create procedure TraerCategoriasEmpleados
                as begin 
                select * from Categorias ;
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

        public static void AgregarCliente(string NomCliente, string ApeCliente, string RazSocCliente, int ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, int Telefonocl, int CondicionIVA)
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
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        public static void AgregarVehiculo(int id, string Modelo, string Marca, int año, string Patente, float Kilometraje)
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
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }
        /* 
        create procedure InsertarVehiculo (
        @idCliente numeric(18,0),
        @modeloVH nvarchar(255),
        @marcaVH nvarchar(255),
        @añoVH float,
        @patenteVH nvarchar(255),
        @KilometrajeVH nvarchar(255))
        as begin
        insert into Vehiculo (idCliente, modeloVH, marcaVH, añoVH, patenteVH, kilometrajeVH) values (@idCliente, @modeloVH, @marcaVH, @añoVH, @patenteVH, @KilometrajeVH)
        end
         */

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
                    string nombreCliente = leer["NomCL"].ToString();
                    string apellidoCliente = leer["ApeCl"].ToString();


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

        //CREATE PROCEDURE ObtenerCliente
        //    @idCliente INT
        //AS
        //BEGIN
        //    SELECT Nombre
        //    FROM Clientes
        //    WHERE idCliente = @idCliente;
        //END;
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

        //Alter PROCEDURE ActualizarVehiculo
        //@idVehiculo INT,
        //@idCliente INT,
        //@modeloVH NVARCHAR(255),
        //@marcaVH NVARCHAR(255),
        //@añoVH INT,
        //@patenteVH NVARCHAR(255),
        //@kilometrajeVH INT
        //AS BEGIN
        //UPDATE Vehiculo
        //SET idCliente = @idCliente, modeloVH = @modeloVH, marcaVH = @marcaVH, añoVH = @añoVH, patenteVH = @patenteVH, kilometrajeVH = @kilometrajeVH
        //WHERE idVehiculo = @idVehiculo;
        //END

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
        public static void AgregarProducto(string NombreProducto, string MarcaProducto, int CategoriaProducto, string CodigoProducto, string DescripcionProducto, int CantidadProducto, double PrecioLista, double PrecioVenta, double LitrosDisponibles)
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
            comando.Parameters.AddWithValue("@FechaCreacionModificacion", LitrosDisponibles);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();


            //AGREGAR COLUMNA ESTADO ACORDATE ESTEBAN LA CONCHA TUYA 

            /*create procedure AgregarProduc(
            @Nomproducto char(60),
            @MarcaProduc char(60),
            @CategoriaProduc int,
            @CodigoProduc Char(5),
            @DescripcionProduc char(255),
            @CantidadProduc int,
            @PrecioLista Decimal,
            @PrecioVenta Decimal,
            @LitrosDisponibles decimal)
            as begin
            Insert into Producto(Nombre, Marca, IdCategoria, CodProd, Descripcion, Cantidad, Precio_lista, PrecioVenta, LitrosDisp,FechaCreacionModificacion) values(@Nomproducto, @MarcaProduc, @CategoriaProduc, @CodigoProduc, @DescripcionProduc, @CantidadProduc, @PrecioLista, @PrecioVenta, @LitrosDisponibles,@FechaCreacionModificacion)
            end*/

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
             [FechaCreacionModificacion][datetime]
            
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
            comando.Parameters.AddWithValue("@IdCategoria", Id);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Parameters.Clear();
            desconectar();
            return id;
            /* create procedure BuscaIdEmp(
               @documento int)
               as begin 
               select COUNT(*) from CategoriasProductos where IdCategoria = @Id;
               end*/
        }

        public static int BuscaDuplicadoProducto(string nombre, string marca, int cat)
        {
            conectar();
            comando.Connection = conexion;
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
        public static void UpdateProductos(int IdProdUPD, string Nombreprd, string MarcaProducto, int categoria, string codigoproducto, string descripcion, int cantidad, int preciolista, int precioventa, double litraje)
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
            comando.Parameters.AddWithValue("@FechaCreacionModificacion", fechaHoraActual);
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
                    @LitrosDisponibles DECIMAL(18, 2),
                    @FechaCreacionModificacion DATETIME
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
                        FechaCreacionModificacion = @FechaCreacionModificacion
                    WHERE 
                        IdProd = @IdProducto; -- Condición para actualizar el producto con ese Id
                END */
                        }

        public static void EliminarProducto(int IdProd, string valor)
        {
            DateTime fechaHoraActual = DateTime.Now;
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

        #endregion



    }



}
