using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MenuOrdenDeTrabajo : Form
    {
        public MenuOrdenDeTrabajo(string nombre, string apellido, string patente, DateTime dia, TimeSpan hora, string descripcion)
        {
            InitializeComponent();
            
            txbNombre.Text = nombre;
            txbApellido.Text = apellido;
            txbPatente.Text = patente;
            DtpFechaDeInicio.Value = dia;
            
            TxbDescripcion.Text = descripcion;


            txbNombre.ReadOnly = true;
            txbApellido.ReadOnly = true;
            txbPatente.ReadOnly = true;
            DtpFechaDeInicio.Enabled = false;
        }

        private void MenuOrdenDeTrabajo_Load(object sender, EventArgs e)
        {

        }
    }
}
