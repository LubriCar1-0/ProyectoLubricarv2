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
            
            pantallaBitacora.ShowDialog();       }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PantallaMenuPrincipal llamarMenuPrincipal = new PantallaMenuPrincipal();
            llamarMenuPrincipal.ShowDialog();
        }
    }
}
