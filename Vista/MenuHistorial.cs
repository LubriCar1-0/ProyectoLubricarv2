﻿using System;
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
    public partial class MenuHistorial : Form
    {
        public MenuHistorial()
        {
            InitializeComponent();
        }

        private void BtnBitacora_Click(object sender, EventArgs e)
        {
            MenuBitacora pantallaBitacora = new MenuBitacora();
            pantallaBitacora.ShowDialog();
            
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHistorialVentas_Click(object sender, EventArgs e)
        {
            MenuHistorialVentas llamarMenuHistorialVentas = new MenuHistorialVentas();
            llamarMenuHistorialVentas.ShowDialog();
             
        }

        private void BtnHistVentServ_Click(object sender, EventArgs e)
        {
            MenuHistorialVentServ llamarPantHistVentServ = new MenuHistorialVentServ();
            llamarPantHistVentServ.ShowDialog();
            
        }

        private void BtnHistorialLubriPuntos_Click(object sender, EventArgs e)
        {
            MenuHistorialLubriPuntos llamarMenuHistorialLubriPuntos = new MenuHistorialLubriPuntos();
            llamarMenuHistorialLubriPuntos.ShowDialog();
        }
    }
}
