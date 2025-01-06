using System;
using System.Collections.Generic;
using System.Data;
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

    } 
}
