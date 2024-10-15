using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Negocio.Empresa;


namespace Negocio
{
    public class Empresa: Conectar
    {
        #region Variables
        public int idEmpresa {  get; set; }
        public string razonSocialEMP {  get; set; }
        public int claveIdenEMP {  get; set; }
        public string domicilioEMP {  get; set; }
        public string condicionIvaEMP {  get; set; }
        public string ptoVentaEMP {  get; set; }
        #endregion

        public class DatosEmpresa : Empresa
        {
            public static void CargaDeEmpresa(string RazonSocial, string ClaveIdent, string Domicilio, string CondicionIVA, string PuntodVenta)
            {               
                Conectar capaDatos = new Conectar();
                DataTable TablaEmpleados = capaDatos.BuscarEmpresa();
                bool EMPEncontrado = false;

                foreach (DataRow Fila in TablaEmpleados.Rows)
                {
                    string RzSocEnBD = Fila["razonSocialEMP"].ToString();
                    string ClaveIdentEnBD = Fila["claveIdenEMP"].ToString();
                    
                    if (RazonSocial == RzSocEnBD && ClaveIdentEnBD == ClaveIdent)
                    {
                        EMPEncontrado = true;
                        throw new Exception("Ya existe la empresa");
                    }

                }
                if (!EMPEncontrado)
                {
                    Conectar.AgregarEmpresa(RazonSocial, ClaveIdent, Domicilio, CondicionIVA, PuntodVenta);
                    string detalle = "Carga de datos de la empresa";
                    AgregarBitacora(Empleados.IdTrabajador, Empleados.NombreTrabajador, detalle);
                    return;
                    throw new Exception("Empresa cargada con exito");
                    // agregar un registro a la bitacora de que se agrega una empresa

                }

            }


            public void TraerDatosEmpleados()
            {
                int trabajadorID = Empleados.IdTrabajador;
                string Nombredeltrabajador = Empleados.NombreTrabajador;
            }
        }
        
    }

    






}
