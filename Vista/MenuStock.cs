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
    public partial class MenuStock : Form
    {
        public MenuStock()
        {
            InitializeComponent();
        }
        public static void LlamarMenuAgregarProducto()
        {
            MenuAgregarProducto PantallaAgregarProducto = new MenuAgregarProducto();
            PantallaAgregarProducto.ShowDialog();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            LlamarMenuAgregarProducto();
        }
    }
}
