using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Turnos
    {
        #region
        public int idVehiculo { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Patente { get; set; }
        #endregion

        public static List<Turnos> ObtenerVehiculosPorCliente(int idCliente)
        {
            Conectar conexion = new Conectar();
            DataTable vehiculosTabla = conexion.BuscarVehiculosPorCliente(idCliente);

            List<Turnos> vehiculos = new List<Turnos>();
            foreach (DataRow row in vehiculosTabla.Rows)
            {
                vehiculos.Add(new Turnos
                {
                    idVehiculo = Convert.ToInt32(row["idVehiculo"]),
                    Modelo = row["modeloVH"].ToString(),
                    Marca = row["marcaVH"].ToString(),
                    Patente = row["patenteVH"].ToString()
                });
            }

            return vehiculos;
        }
        public static void CargaDeTurnos(DateTime dia, DateTime hora, int idCliente, int idVehiculo, string descripcion)
        {
            Conectar capaDatos = new Conectar();
            DataTable TablaTurnos = capaDatos.BuscarTurnos();

            // Convertir los parámetros a cadenas para facilitar la comparación
            string fechaInput = dia.ToString("yyyy-MM-dd"); // Formato de fecha estándar
            string horaInput = hora.ToString("HH:mm:ss");  // Formato de hora estándar

            bool TurnoEncontrado = false;

            // Verificar si la fecha y la hora ya existen en la base de datos
            foreach (DataRow fila in TablaTurnos.Rows)
            {
                string fechaTurno = fila["Fecha"].ToString();
                string horaTurno = fila["Hora"].ToString();

                if (fechaInput == fechaTurno && horaInput == horaTurno)
                {
                    TurnoEncontrado = true;
                    throw new Exception("Ya existe un turno registrado para esa fecha y horario");

                }
            }

            if (!TurnoEncontrado)
            {
                // Si no existe el turno, registrar el nuevo turno
                string Estado = "ACT";
                capaDatos.InsertarTurno(dia, hora, idCliente, idVehiculo, descripcion, Estado);
                //AgregarBitacora
            }

        }
        public static void ModificarTurnos(int idTurno, int idVehiculoUPD, int idClienteUPD, DateTime fechaupd, TimeSpan horaupd, string DescUPD)
        {
            try
            {
                Conectar.ActualizarTurno(idTurno, idVehiculoUPD, idClienteUPD, fechaupd, horaupd, DescUPD);
                // agregar a la bitacora 
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el vehículo en la base de datos: {ex.Message}");
            }
        }

    }
}
