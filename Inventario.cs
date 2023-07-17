using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoZapateria
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            GenerarVenta generarVenta = new GenerarVenta();
            generarVenta.Show();
            this.Hide();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {

        }

        private void radAgregar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Agregar";
        }

        private void radActualizar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Actualizar";
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            if(radAgregar.Checked) 
            {
                btnAccion.Text = "Agregar";
            }
            else
            {
                btnAccion.Text = "Actualizar";
            }
        }
    }
}
