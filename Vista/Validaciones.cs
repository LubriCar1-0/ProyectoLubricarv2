﻿using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.Cliente;
using static Negocio.Empresa;



namespace Vista
{
    public class Validaciones: Empleados
    {
        public static void DatosEmpleado(int Documento, string contraseña)
        {
            Empleados.IngresoEmpleados(Documento, contraseña);
        }
        public static void AgregarUnEmpleado (string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int Permiso, int categoria )
        {
            Empleados.CargaDeEmpleado(Nombre, Apellido, Documento, Contraseña, Telefono, Permiso, categoria);
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
    }
    public class Validar : Cliente
    {
        public static void AgregarUnCliente(string NomCliente, string ApeCliente, string RazSocCliente, int ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, string CondicionIVA, int Telefonocl)
        {
            Personas.CargadeClientes(NomCliente, ApeCliente, RazSocCliente, ClaveCliente, LocalidadCL, CalleCliente, NumeracionCl, CondicionIVA, Telefonocl);
        }
    }
    public class CargaEmpresa : Empresa
    {
        public static void AgregarUnaEmpresa(string RazonSocial, string ClaveIdent, string Domicilio, string CondicionIVA, string PuntodVenta)
        {
            Empresa.DatosEmpresa.CargaDeEmpresa(RazonSocial, ClaveIdent, Domicilio, CondicionIVA, PuntodVenta);
        }


    }
}
