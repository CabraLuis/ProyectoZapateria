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
    public partial class GenerarVenta : Form
    {
        public string ay;
        public string mensajeBienvenida;
        public GenerarVenta(object a)
        {

            InitializeComponent();
            ay = a.ToString();
        }

        private void GenerarVenta_Load(object sender, EventArgs e)
        {

            // Obtener la hora actual
            DateTime now = DateTime.Now;

            // Darle forma a la hora actual
            string horaActual = now.ToString("HH:mm:ss");

            // Construir el mensaje de bienvenida
            if (ay == "Femenino")
            {
                mensajeBienvenida = "            Bienvenida.\nLa hora actual es: " + horaActual;
            }
            else if (ay == "Masculino")
            {
                mensajeBienvenida = "            Bienvenido.\nLa hora actual es: " + horaActual;

            }
            else
            {
                MessageBox.Show("Que rollo no jala" + ay);
            }

            // Mostrar el mensaje de bienvenida en el control Label
            lblBienvenido.Text = mensajeBienvenida;
        }
    }
}
