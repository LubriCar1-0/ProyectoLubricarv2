using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Stock
    {
        public int idStock {  get; set; }
        public int idProd {  get; set; }
        public string nombre { get; set; }
        public int codigoProd { get; set; }
        public string categoria {  get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public int cantidadEnStock {  get; set; }

    }
}
