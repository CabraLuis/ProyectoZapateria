﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoZapateria
{
    public partial class ConsultarVentas : Form
    {
        public ConsultarVentas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
           GenerarVenta generarVenta = new GenerarVenta();
            generarVenta.Show();
            this.Hide();
        }
    }
}
