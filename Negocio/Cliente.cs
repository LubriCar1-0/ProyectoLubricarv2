using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.Cliente;

namespace Negocio
{
    public class Cliente : Conectar
    {
        public class Personas : Cliente
        {
            public int idCliente { get; set; }
            public string RazSocialCL { get; set; }
            public string claveIdenCl { get; set; }
            public string localidadCL { get; set; }
            public string calleCL { get; set; }
            public int numeracionCl { get; set; }
            public string condicionIvaCl { get; set; }
            public int telefonoCL { get; set; }

        }
        public static void CargadeClientes(string NomCliente, string ApeCliente, string RazSocCliente, string ClaveCliente, string LocalidadCL, string CalleCliente, int NumeracionCl, string CondicionIVA, int Telefonocl)
        {
            Conectar capaDatos = new Conectar();
            Conectar.AgregarCliente(NomCliente, ApeCliente, RazSocCliente, ClaveCliente, LocalidadCL, CalleCliente, NumeracionCl, CondicionIVA, Telefonocl);
        }
    }
    
}
