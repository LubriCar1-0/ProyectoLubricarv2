﻿using System;
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








    }
}
