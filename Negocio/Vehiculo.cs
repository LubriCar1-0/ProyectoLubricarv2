﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Vehiculo
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public static List<Vehiculo> ObtenerClientes()
        {
            Conectar conexion = new Conectar();
            DataTable clientesTabla = conexion.BuscarClientes();

            List<Vehiculo> clientes = new List<Vehiculo>();
            foreach (DataRow row in clientesTabla.Rows)
            {
                clientes.Add(new Vehiculo
                {
                    IdCliente = Convert.ToInt32(row["idCliente"]),
                    NombreCliente = row["NomCl"].ToString(),
                    ApellidoCliente = row["ApeCl"].ToString()
                });
            }

            return clientes;
        }
        public static void CargaDeVehiculos(int id, string Modelo, string Marca, int año, string Patente, float Kilometraje)
        {
            Conectar capaDatos = new Conectar();
            DataTable TablaClientes = capaDatos.BuscarClientes();
            bool clienteEncontrado = false; 
            foreach (DataRow fila in TablaClientes.Rows)
            {
                string idBD = fila["idCliente"].ToString();
                int idInt = Convert.ToInt32(idBD);
                if (idInt == id) {
                    clienteEncontrado = true;
                    Conectar.AgregarVehiculo(id, Modelo, Marca, año, Patente, Kilometraje);
                    //agregar la bitacora 
                    
                
                }



            }
        }


    } 
}
