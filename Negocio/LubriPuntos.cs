using Datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class LubriPuntos
    {
        public int IdLubripuntos { get; set; }
        public double TotalMenor1 { get; set; }
        public double TotalMenor2 { get; set; }
        public double TotalMayor { get; set; }
        public int CantidadLubri { get; set; }

        public static void AsignarLubriPuntos(int Id, double Precio, int Lubri)
        {
            Conectar.AsignarLubriPuntos(Id, Precio, Lubri);

        }
        public List<LubriPuntos> ObtenerListaLubripuntos()
        {
            List<LubriPuntos> listaLubripuntos = new List<LubriPuntos>();
            Conectar CapaDatos = new Conectar();
            DataTable dt = CapaDatos.TraerLubripuntos();

            foreach (DataRow row in dt.Rows)
            {
                LubriPuntos lubripunto = new LubriPuntos()
                {
                    IdLubripuntos = Convert.ToInt32(row["IdValorLubripuntos"]),
                    TotalMenor1 = Convert.ToDouble(row["TotalMenor1"]),
                    TotalMenor2 = Convert.ToDouble(row["TotalMenor2"]),
                    TotalMayor = Convert.ToDouble(row["TotalMayor"]),
                    CantidadLubri = Convert.ToInt32(row["CantidadLubriPuntos"])
                };
                listaLubripuntos.Add(lubripunto);
            }

            return listaLubripuntos;
        }
        public static void Cambiarestadoproducxlubri(int idLubrixProducto, string Estado)
        {
            try
            {
                Conectar.EstadoProducxlubri(idLubrixProducto, Estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cambiar el estado del producto: {ex.Message}");
            }
        }

        public static void InsertarPuntosAProducto(int idProd, int cantidadLubriPuntos)
        {
            Conectar.InsertarPuntosAProducto(idProd, cantidadLubriPuntos);
        }
        public static DataTable ObtenerListaLubrixProductos()
        {
            Conectar CapaDatos = new Conectar();
            return CapaDatos.ObtenerLubrixProductos();
        }

        public static void RestarProducto(int IdProducto, int Cantidad)
        {
            Conectar.RestaCantidad(IdProducto, Cantidad);
        }

        public static void RestarLubriPuntos(int idCliente, int LubriPuntos)
        {
            Conectar.RestaLubriPuntos(idCliente, LubriPuntos);
        }
        public int CalculaLubriPuntos(double total)
        {
            #region variables
            List<LubriPuntos> list = new List<LubriPuntos>();
            double Precio1 = 0;
            double precio2 = 0;
            double precio3 = 0;
            int LubriCant1 = 0;
            int LubriCant2 = 0;
            int LubriCant3 = 0;
            #endregion
            list = ObtenerListaLubripuntos();
            foreach (var LBlist in list)
            {
                if (LBlist.IdLubripuntos == 1)
                {
                    Precio1 = LBlist.TotalMenor1;
                    LubriCant1 = LBlist.CantidadLubri;
                }
                if (LBlist.IdLubripuntos == 2)
                {
                    precio2 = LBlist.TotalMenor2;
                    LubriCant2 = LBlist.CantidadLubri;
                }
                if (LBlist.IdLubripuntos == 3)
                {
                    precio3 = LBlist.TotalMayor;
                    LubriCant3 = LBlist.CantidadLubri;
                }
            }

            int devuelve = 0;

            if (total <= Precio1)
            {
                devuelve = LubriCant1;
            }
            if (total >= Precio1 && total <= precio3 )
            {
                devuelve = LubriCant2;
            }
            if (total >= precio2 && precio3 <= total)
            {
                devuelve = LubriCant3;
            }


            return devuelve;
        }
    }

}
