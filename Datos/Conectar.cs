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
            comando.CommandType=CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NomTR", Nombre);
            comando.Parameters.AddWithValue("@ApeTR", Apellido);
            comando.Parameters.AddWithValue("@documentoTR", Documento);
            comando.Parameters.AddWithValue("@contraseñaTR", Contraseña);
            comando.Parameters.AddWithValue("@telefonoTR", Telefono);
            comando.Parameters.AddWithValue("@permiso", permisoCat);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
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

            public static void AgregarCliente (string NomCliente, string ApeCliente, string RazSocCliente, string ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, string CondicionIVA, int Telefonocl )
        {
            conectar();
            comando.Connection = conexion;
            comando.CommandText = "InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NomCL", NomCliente);
            comando.Parameters.AddWithValue("@ApeCL", ApeCliente);
            comando.Parameters.AddWithValue("@RazSocialCL", RazSocCliente);
            comando.Parameters.AddWithValue("@claveIdenCL", ClaveCliente);
            comando.Parameters.AddWithValue("@localidadCL", LocalidadCL);
            comando.Parameters.AddWithValue("@calleCL", CalleCliente);
            comando.Parameters.AddWithValue("@numeracionCL", NumeracionCl);
            comando.Parameters.AddWithValue("@condicionIvaCL", CondicionIVA);
            comando.Parameters.AddWithValue("@telefonoCL", Telefonocl);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            desconectar();
        }








    }
}
