﻿using Datos;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Negocio.Cliente;

namespace Negocio
{
    public class Cliente : Conectar
    {
        public class Personas : Cliente
        {
            public int idCliente { get; set; }
            public string RazSocialCL { get; set; }
            public string claveIdenCl { get; set; }
            public string localidadCL { get; set; }
            public string calleCL { get; set; }
            public int numeracionCl { get; set; }
            public string condicionIvaCl { get; set; }
            public int telefonoCL { get; set; }

        }
        public static void CargadeClientes(string NomCliente, string ApeCliente, string RazSocCliente, int ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, string CondicionIVA, int Telefonocl)
        {
            Conectar capaDatos = new Conectar();
            DataTable TablaClientes = capaDatos.BuscarClientes();
            bool clienteencontrado = false;


            foreach (DataRow Fila in TablaClientes.Rows)
            {
                string Clavecliente = Fila["ClaveIdenCL"].ToString();
                int clave = Convert.ToInt32(Clavecliente);
                if (clave == ClaveCliente)
                {
                    clienteencontrado = true;
                    throw new Exception("Ya existe un cliente con ese documento");


                }
            }
            if (!clienteencontrado)
            {
                    Conectar.AgregarCliente(NomCliente, ApeCliente, RazSocCliente, ClaveCliente, LocalidadCL, CalleCliente, NumeracionCl, CondicionIVA, Telefonocl);
                    string detalle = "Carga de cliente al sistema";
                    AgregarBitacora(Empleados.IdTrabajador, Empleados.NombreTrabajador, detalle);
            }
            } 
        }
        public class cliente : Empleados
        {
            
        }
    }
    

