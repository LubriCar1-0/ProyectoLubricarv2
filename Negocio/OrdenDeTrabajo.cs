using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Datos;

namespace Negocio
{
    public class OrdenDeTrabajo
    {
        #region Variables
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Patente { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan Hora { get; set; }
        public string Descripcion { get; set; }
        #endregion

        public static void CrearOrdenDeTrabajo(string NombreCompleto, DateTime dia, string descripcion, int trabajadorId, int idCliente, int idVehiculo, int idTurno)
        {
            Conectar capaDatos = new Conectar();
            /*DataTable TablaOrdenes = capaDatos.BuscarOrdenes();
            bool usuarioEncontrado = false;
            foreach (DataRow Fila in TablaOrdenes.Rows)
            {
                int idTurnoEnBD = Convert.ToInt32( Fila["idTurno"].ToString());
                if (idTurno == idTurnoEnBD)
                {
                    usuarioEncontrado = true;
                    throw new Exception("Ya se Creo una Orden de Trabajo en base a ese Turno");


                }

            }
            string estado = "En Proceso";
            Conectar.CrearOrdenTrabajo(NombreCompleto, dia, descripcion, trabajadorId, idCliente, idVehiculo, estado, idTurno);*/
        }


    }

}
