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
            DataTable TablaVehiculos = capaDatos.BuscarVehiculos();
            bool VehiculoEncontrado = false;
            foreach (DataRow fila in TablaClientes.Rows)
            {
                string idBD = fila["idCliente"].ToString();
                int idInt = Convert.ToInt32(idBD);
                if (idInt == id)
                {

                    string PatenteExistente = fila["patenteVH"].ToString();
                    if (Patente == PatenteExistente)
                    {
                        VehiculoEncontrado = true;
                        throw new Exception("Ya existe un vehiculo con esa patente");

                    }
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
                throw new Exception($"Error al cambiar el estado del empleado: {ex.Message}");
            }
        }
    }
}

