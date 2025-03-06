using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Turnos
    {
        #region Variables 
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
                if (row["ESTADO"].ToString() == "ACT")
                {
                    vehiculos.Add(new Turnos
                    {
                        idVehiculo = Convert.ToInt32(row["idVehiculo"]),
                        Modelo = row["modeloVH"].ToString(),
                        Marca = row["marcaVH"].ToString(),
                        Patente = row["patenteVH"].ToString()
                    });
                }
            }

            return vehiculos;
        }
        public static List<Turnos> ObtenerVehiculos()
        {
            Conectar conexion = new Conectar();
            DataTable vehiculosTabla = conexion.BuscarVehiculos();

            List<Turnos> vehiculos = new List<Turnos>();
            foreach (DataRow row in vehiculosTabla.Rows)
            {
                if (row["ESTADO"].ToString() == "ACT")
                {
                    vehiculos.Add(new Turnos
                    {
                        idVehiculo = Convert.ToInt32(row["idVehiculo"]),
                        Modelo = row["modeloVH"].ToString(),
                        Marca = row["marcaVH"].ToString(),
                        Patente = row["patenteVH"].ToString()
                    });
                }
            }

            return vehiculos;
        }

        public static void CargaDeTurnos(DateTime dia, DateTime hora, int idCliente, int idVehiculo, string descripcion)
        {
            
            DateTime fechaTurno = dia.Date.Add(hora.TimeOfDay);
            DateTime fechaActual = DateTime.Now;
            if (fechaTurno < fechaActual)
            {
                throw new Exception("La fecha y hora del turno no pueden ser anteriores a la fecha y hora actual.");
            }

            Conectar capaDatos = new Conectar();

            TimeSpan horaTimeSpan = hora.TimeOfDay;

            bool turnoExistente = capaDatos.ExisteTurno(dia, horaTimeSpan);

            if (turnoExistente)
            {
                throw new Exception("Ya existe un turno registrado para esa fecha y horario.");
            }
            else
            {
                string estado = "ACTIVO";
                capaDatos.InsertarTurno(dia, horaTimeSpan, idCliente, idVehiculo, descripcion, estado);
                string detalle = "Carga de un turno";
                string tabla = "Turno";
                Conectar.AgregarBitacora(Empleados.IdTrabajador, detalle, tabla);
            }
        }

        public static void ModificarTurnos(int idTurno, int idVehiculoUPD, int idClienteUPD, DateTime fechaupd, TimeSpan horaupd, string DescUPD)
        {
            DateTime fechaTurnoActualizada = fechaupd.Date.Add(horaupd);

            if (fechaTurnoActualizada < DateTime.Now)
            {
                throw new Exception("La fecha y hora del turno no pueden ser anteriores a la fecha y hora actual.");
            }

            Conectar capaDatos = new Conectar();
            
            bool turnoExistente = capaDatos.ExisteTurno(fechaupd, horaupd );

            if (turnoExistente)
            {
                throw new Exception("Ya existe un turno registrado para esa fecha y horario.");
            }

            try
            {
                Conectar.ActualizarTurno(idTurno, idVehiculoUPD, idClienteUPD, fechaupd, horaupd, DescUPD);
                string detalle = "Modificacion de un turno";
                string tabla = "Turno";
                Conectar.AgregarBitacora(Empleados.IdTrabajador, detalle, tabla);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el turno en la base de datos: {ex.Message}");
            }
        }


        public static void CancelarElTurno(int idTurno, string Estado)
        {
            try
            {
                string detalle = "Cancelacion de un turno";
                string tabla = "Turno";
                Conectar.AgregarBitacora(Empleados.IdTrabajador, detalle, tabla);
            
                Conectar.CancelarTurno(idTurno, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cambiar el estado del empleado: {ex.Message}");
            }
        }

    }
}
