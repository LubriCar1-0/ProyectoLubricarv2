using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conectar
    {
        #region ConexionBD
        DataTable dt = new DataTable();
        SqlDataReader leer;
        public static SqlCommand comando = new SqlCommand();
        public static SqlConnection conexion = new SqlConnection("server= localhost\\SQLEXPRESS; database= Lubri-CarBD; integrated security = true");
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
        public static void AgregarEmpleados(string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int permisoCat, int idCategoria)
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
            comando.Parameters.AddWithValue("@permiso", permisoCat);
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
        #endregion
        #region Clientes/Vehiculos
        public DataTable BuscarClientes()
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "TraerTablaClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            desconectar();
            return dt;

        }

        public static void AgregarCliente(string NomCliente, string ApeCliente, string RazSocCliente, int ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, string CondicionIVA, int Telefonocl)
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
            comando.Parameters.AddWithValue("@CondicionIvaCL", CondicionIVA);
            comando.Parameters.AddWithValue("@TelefonoCL", Telefonocl);
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


        public static void AgregarProducto(string NombreProducto, string MarcaProducto, string CategoriaProducto, string CodigoProducto, string PrecioListaProducto, string PrecioVentaProducto, string DescripcionProducto)
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "AgregarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreproducto" , NombreProducto);
            comando.Parameters.AddWithValue("@marcaproducto", MarcaProducto);
            comando.Parameters.AddWithValue("@categoriaproducto", CategoriaProducto);
            comando.Parameters.AddWithValue("@codigoproducto", CodigoProducto);
            comando.Parameters.AddWithValue("@preciolistaproducto", PrecioListaProducto);
            comando.Parameters.AddWithValue("@precioventaproducto", PrecioVentaProducto);
            comando.Parameters.AddWithValue("@descripcionproducto", DescripcionProducto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();

            /*
            create proc AgregarProducto
            @nombreproducto nvarchar (200),
            @marcaproducto nvarchar(200),
            @categoriaproducto nvarchar(200),
            @codigoproducto int,
            @preciolistaproducto float,
            @precioventaproducto float,
            @descrpcionproducto nvarchar(500)
            as
            insert into Producto values (@nombreproducto, @marcaproducto, @categoriaproducto, @codigoproducto, @preciolistaproducto, @precioventaproducto, @descripcionproducto)
            go
            */

        }
    }

        #endregion





    
}
