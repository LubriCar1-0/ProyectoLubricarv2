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
        public static void AgregarEmpleados(string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int permiso, int categoria)
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
            comando.Parameters.AddWithValue("@permiso", permiso);
            comando.Parameters.AddWithValue("@idCategoria", categoria);
            comando.ExecuteNonQuery();  
            comando.Parameters.Clear();
            desconectar();

        }









    }
}
