using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class VentaServicio
    {
        #region Variables
        public int idCliente {  get; set; }
        public string NombreCompleto {  get; set; } 
        public int Lubripuntos {  get; set; }
        public int idVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo    { get; set; }
        public string Patente { get; set; }
        public int idTrabajador { get; set; }
        public string descripcion { get; set; }
        public string NombreCompletoTrabajador { get; set; }


        #endregion
        public static VentaServicio ObtenerDatosVenta(int idOrdenTrab)
        {
            DataTable dt = new Conectar().TraerDatosParaVenta(idOrdenTrab);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new VentaServicio
                {
                    idCliente = Convert.ToInt32(row["idCliente"]),
                    NombreCompleto = row["NombreCompletoCliente"].ToString(),
                    Lubripuntos = Convert.ToInt32(row["LubriPuntos"]),
                    idVehiculo = Convert.ToInt32(row["idVehiculo"]),
                    Marca = row["marcaVH"].ToString(),
                    Modelo = row["modeloVH"].ToString(),
                    Patente = row["patenteVH"].ToString(),
                    idTrabajador = Convert.ToInt32(row["idTrabajador"]),
                    descripcion = row["descripcion"].ToString(),
                    NombreCompletoTrabajador = row["NombreCompletoTrabajador"].ToString()
                };
            }
            return null;
        }
        public static void CargaVenta(int idOrdenTrab, int idCliente, double ManoDeObra, double SubTotal, double IVA, double Total, int lubripuntos)
        {
            
            Conectar.CargaDeVentaServ(idOrdenTrab, idCliente, ManoDeObra, SubTotal, IVA, Total);


            Conectar.CargaLubriPuntos(idCliente, lubripuntos);
        }


    }
}
