using System;
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
    public partial class RegistroProveedor : Form
    {
        public RegistroProveedor()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            GenerarVenta Venta2 = new GenerarVenta();
            Venta2.Show();
            this.Hide();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (radActualizarProveedor.Checked)
            {

            }
            else if (radAgregarProveedor.Checked)
            {

            }
            else if (radEliminarProveedor.Checked)
            {

            }

        }

        private void radAgregarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Agregar";
        }

        private void radActualizarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Actualizar";
        }

        private void radEliminarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Eliminar";
        }

        private void RegistroProveedor_Load(object sender, EventArgs e)
        {
            radAgregarProveedor.Checked = true;
        }
    }
}
