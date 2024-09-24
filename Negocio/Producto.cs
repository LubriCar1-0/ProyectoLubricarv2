using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Producto
    {
        public int idProducto {  get; set; }
        public string nombre {  get; set; }
        public int codProd {  get; set; }
        public string categoria {  get; set; }
        public string descripcion { get; set; }
        public float precio {  get; set; }
        public int cantDisp {get;set; }

    }
}
