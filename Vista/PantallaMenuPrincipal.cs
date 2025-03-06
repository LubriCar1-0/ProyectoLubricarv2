using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class PantallaMenuPrincipal : Form
    {

        public PantallaMenuPrincipal()
        {
            InitializeComponent();
            //VerificarNotificacionStock();
            this.Load += PantallaMenuPrincipal_Load;
            BtnNotificacion.Visible = false;
        }

        private void PantallaMenuPrincipal_Load(object sender, EventArgs e)
        {
            
            lblUsuario.Text = Empleados.NombreTrabajador;
            
        }

        #region Llamados 

        public bool LlamarMenuVentas()
         {
            int IdCategoria = Empleados.idCategoria;

            int ChequeaPermiso = Conectar.VerificaPermiso(IdCategoria);
            if (ChequeaPermiso == 9 || ChequeaPermiso == 5)
            {
                bool permiso = true;
                return permiso;
            }
            else
            {
                
                bool permiso = false;
                return permiso;
            }

        }

        public bool LlamarMenuTurnos()
        {
            int IdCategoria = Empleados.idCategoria;

            int ChequeaPermiso = Conectar.VerificaPermiso(IdCategoria);
            if (ChequeaPermiso == 9 || ChequeaPermiso == 5 || ChequeaPermiso == 3)
            {
                bool permiso = true;
                return permiso;
            }
            else
            {

                bool permiso = false;
                return permiso;
            }
            
        }

        public bool LlamarMenuHistorial()
        {
            int IdCategoria = Empleados.idCategoria;

            int ChequeaPermiso = Conectar.VerificaPermiso(IdCategoria);
            if (ChequeaPermiso == 9 || ChequeaPermiso == 5)
            {
                bool permiso = true;
                return permiso;
            }
            else
            {

                bool permiso = false;
                return permiso;
            }

        }
        public bool LlamarMenuOrdenDeTrabajo()
        {
            int IdCategoria = Empleados.idCategoria;

            int ChequeaPermiso = Conectar.VerificaPermiso(IdCategoria);
            if (ChequeaPermiso == 9 || ChequeaPermiso == 5 || ChequeaPermiso == 3)
            {
                bool permiso = true;
                return permiso;
            }
            else
            {

                bool permiso = false;
                return permiso;
            }
        }

        public bool LlamarMenuStock()
        {
            int IdCategoria = Empleados.idCategoria;

            int ChequeaPermiso = Conectar.VerificaPermiso(IdCategoria);
            if (ChequeaPermiso == 9 || ChequeaPermiso == 5 || ChequeaPermiso == 4)
            {
                bool permiso = true;
                return permiso;
            }
            else
            {

                bool permiso = false;
                return permiso;
            }
        }
        public bool LlamarMenuConfiguracion()
        {
            int IdCategoria = Empleados.idCategoria;

            int ChequeaPermiso = Conectar.VerificaPermiso(IdCategoria);
            if (ChequeaPermiso == 9)
            {
                bool permiso = true;
                return permiso;
            }
            else
            {

                bool permiso = false;
                return permiso;
            }
        }
        public bool LlamarMenuLubriPuntos()
        {
            int IdCategoria = Empleados.idCategoria;

            int ChequeaPermiso = Conectar.VerificaPermiso(IdCategoria);
            if (ChequeaPermiso == 9 || ChequeaPermiso == 5)
            {
                bool permiso = true;
                return permiso;
            }
            else
            {

                bool permiso = false;
                return permiso;
            }
        }



        #endregion 
        private void BtnVentas_Click(object sender, EventArgs e)
        {
            bool permiso = LlamarMenuVentas();

            if(permiso ==true )
            {
                MenuVentas llamarMenuVentas = new MenuVentas(); 
                llamarMenuVentas.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta pantalla", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void BtnTurnos_Click(object sender, EventArgs e)
        {
            bool permiso = LlamarMenuTurnos();

            if (permiso == true)
            {
                MenuTurnos PantallaMenuTurnos = new MenuTurnos();
                PantallaMenuTurnos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta pantalla", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {

            bool permiso = LlamarMenuHistorial();
            if (permiso == true)
            {
                MenuHistorial PantallaMenuHistorial = new MenuHistorial();
                PantallaMenuHistorial.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta pantalla", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnOrdenDeTrabajo_Click(object sender, EventArgs e)
        {

            bool permiso = LlamarMenuOrdenDeTrabajo();
            if (permiso == true)
            {
                MenuOrdenesFinalizadas PantallaOrdenes = new MenuOrdenesFinalizadas();
             
                PantallaOrdenes.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta pantalla", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            
            bool permiso = LlamarMenuStock();
            if (permiso == true)
            {
                MenuStock PantallaMenuStock = new MenuStock();
                PantallaMenuStock.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta pantalla", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {

            bool permiso = LlamarMenuConfiguracion();
            if (permiso == true)
            {
                MenuConfiguracion PantallaMenuConfiguracion = new MenuConfiguracion();
                PantallaMenuConfiguracion.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta pantalla", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLubriPuntos_Click(object sender, EventArgs e)
        {

            bool permiso = LlamarMenuLubriPuntos();

            if (permiso == true)
            {
                MenuLubriPuntos PantallaMenuLubriPuntos = new MenuLubriPuntos();
                PantallaMenuLubriPuntos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a esta pantalla", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string detalle = "Cierre de sesion";
                string tabla = "Trabajador";
                int idTrab = Empleados.IdTrabajador;
                Conectar.AgregarBitacora(idTrab, detalle, tabla);
                InicioSesion LlamarInicio = new InicioSesion();
                Close();
                LlamarInicio.Show();

            }
        }
        //private void VerificarNotificacionStock()
        //{
        //    try
        //    {
        //        DataTable dt = ValidarProducto.ObtenerProductosFaltantes();

        //        // Verificar si la tabla tiene datos
        //        if (dt != null && dt.Rows.Count > 0)
        //        {
        //            BtnNotificacion.Visible = true;
        //            Console.WriteLine("Hay productos faltantes. Se muestra la notificación.");
        //        }
        //        else
        //        {
        //            BtnNotificacion.Visible = false;
        //            Console.WriteLine("No hay productos faltantes. Se oculta la notificación.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error en VerificarNotificacionStock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void VerificarNotificacionStock()
        //{
        //    DataTable dt = ValidarProducto.ObtenerProductosFaltantes();        
        //    if (dt.Rows.Count > 0)
        //    {
        //        BtnNotificacion.Visible = true;
        //    }
        //    else
        //    {
        //        BtnNotificacion.Visible = false;
        //    }
        //}

        private void BtnNotificacion_Click(object sender, EventArgs e)
        {

        }
    }
}
