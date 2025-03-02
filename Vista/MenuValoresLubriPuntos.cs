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
    public partial class MenuValoresLubriPuntos : Form
    {
        public MenuValoresLubriPuntos()
        {
            InitializeComponent();
            CargarValores(1);  
            CargarValores(2);  
            CargarValores(3);  
        }


        int idlubripunto = 0;
        private void BtnAsignacion1_Click(object sender, EventArgs e)
        {
            try
            {
                idlubripunto = 1;
                ValidarLubriPuntos.AsignarLubri(idlubripunto, Convert.ToDouble(TxtMenor1.Text.Trim()), Convert.ToInt32(TxtCantidad1.Text.Trim()));
                MessageBox.Show("Cantidad asignada correctamente");
            }
            catch (Exception ex)  
            {
                throw new Exception (ex.Message);
            }
        }

        private void BtnAsignacion2_Click(object sender, EventArgs e)
        {
            try
            {
                idlubripunto = 2;
                ValidarLubriPuntos.AsignarLubri(idlubripunto, Convert.ToDouble(TxtMenor2.Text.Trim()), Convert.ToInt32(TxtCantidad2.Text.Trim()));
                MessageBox.Show("Cantidad asignada correctamente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void BtnAsignacion3_Click(object sender, EventArgs e)
        {
            try
            {
                idlubripunto = 3;
                ValidarLubriPuntos.AsignarLubri(idlubripunto, Convert.ToDouble(TxtMayor.Text.Trim()), Convert.ToInt32(TxtCantidad3.Text.Trim()));
                MessageBox.Show("Cantidad asignada correctamente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void CargarValores(int id)
        {
            try
            {
                DataTable dt = ValidarLubriPuntos.ObtenerValoresLubriPuntos(id);

                if (dt.Rows.Count > 0)
                {
                    
                    double total = Convert.ToDouble(dt.Rows[0]["Total"]);
                    int cantidadLubriPuntos = Convert.ToInt32(dt.Rows[0]["CantidadLubriPuntos"]);

                    
                    if (id == 1)
                    {
                        TxtMenor1.Text = total.ToString();
                        TxtCantidad1.Text = cantidadLubriPuntos.ToString();
                    }
                    else if (id == 2)
                    {
                        TxtMenor2.Text = total.ToString();
                        TxtCantidad2.Text = cantidadLubriPuntos.ToString();
                    }
                    else if (id == 3)
                    {
                        TxtMayor.Text = total.ToString();
                        TxtCantidad3.Text = cantidadLubriPuntos.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los valores: " + ex.Message);
            }
        }

        private void BtnCargarValores1_Click(object sender, EventArgs e)
        {
            CargarValores(1);  
        }

        private void BtnCargarValores2_Click(object sender, EventArgs e)
        {
            CargarValores(2);  
        }

        private void BtnCargarValores3_Click(object sender, EventArgs e)
        {
            CargarValores(3);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
