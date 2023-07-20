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
        public string usuario;
        public GenerarVenta(object a,string User)
        {

            InitializeComponent();
            ay = a.ToString();
            usuario = User;

        }
        public GenerarVenta(string user) { InitializeComponent();  usuario = user; }

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

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
           
                Ventas Ventas1 = new Ventas(usuario);
                Ventas1.Show();
                this.Hide();
           
            
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario(usuario);
            inventario.Show();
            this.Hide();
        }

        private void btnRegisProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarVenta_Click_1(object sender, EventArgs e)
        {
            Ventas ControlVentas = new Ventas(usuario);
            ControlVentas.Show();
            this.Hide();
        }

        private void btnRegisProveedor_Click_1(object sender, EventArgs e)
        {
            if (usuario == "Administrador")
            {
                 RegistroProveedor proveedor = new RegistroProveedor(usuario);
            proveedor.Show();
            this.Hide();
            }
            else if (usuario == "Empleado")
            {
                MessageBox.Show("No tienes los permisos necesarios para entrar al apartado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {
            if (usuario == "Administrador")
            {
                Inventario inventario = new Inventario(usuario);
                inventario.Show();
                this.Hide();
            }
            else if (usuario == "Empleado")
            {
                MessageBox.Show("No tienes los permisos necesarios para entrar al apartado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void GenerarVenta_Load_1(object sender, EventArgs e)
        {

        }
    }
}
