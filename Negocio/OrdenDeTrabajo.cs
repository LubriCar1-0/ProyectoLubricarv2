using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        
        
    }

}
