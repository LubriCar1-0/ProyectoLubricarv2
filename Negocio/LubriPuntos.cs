using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LubriPuntos
    {
        public static void AsignarLubriPuntos (int Id, double Precio, int Lubri)
        {
            Conectar.AsignarLubriPuntos(Id, Precio, Lubri);
            
        }
    }
}
