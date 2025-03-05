using System;
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
                if (row["Estado"].ToString() == "ACT")
                {
                    clientes.Add(new Vehiculo
                    {
                        IdCliente = Convert.ToInt32(row["idCliente"]),
                        NombreCliente = row["Nombre"].ToString().Trim(),
                        ApellidoCliente = row["Apellido"].ToString()
                    });
                }
            }

            return clientes;
        }

        public static void CargaDeVehiculos(int id, string Modelo, string Marca, int año, string Patente, int Kilometraje)
        {
            Conectar capaDatos = new Conectar();
            
            DataTable TablaVehiculos = capaDatos.BuscarVehiculos();
            bool VehiculoEncontrado = false;
            foreach (DataRow filaVH in TablaVehiculos.Rows)
            {
                string PatenteExistente = filaVH["patenteVH"].ToString();
                if (Patente == PatenteExistente)
                {
                   VehiculoEncontrado = true;
                   throw new Exception("Ya existe un vehículo con esa patente.");
                }
            }          
            if (!VehiculoEncontrado)
            {
                string Estado = "ACT";
                Conectar.AgregarVehiculo(id, Modelo, Marca, año, Patente, Kilometraje, Estado);
                //agregar a la bitacora
            }
        }

        public static void ModificarVehiculo(int idVehiculo, int idCliente, string modelo, string marca, int año, string patente, int kilometraje)
        {
            try
            {
                Conectar.ActualizarVehiculo(idVehiculo, idCliente, modelo, marca, año, patente, kilometraje);
                // agregar a la bitacora 
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el vehículo en la base de datos: {ex.Message}");
            }
        }
        public static void CambiarEstado(int idVehiculo, string Estado)
        {
            try
            {

                Conectar.EstadoVehiculo(idVehiculo, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cambiar el estado del Vehiculo: {ex.Message}");
            }
        }
    }
}

